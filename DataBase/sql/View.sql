/**
* part3: 创建视图
* 包括：用户运动成就视图，用户健康情况视图等
*
*/

USE BI;
-- 创建用户运动成就视图（对于UserSportTrack的聚合）
--CREATE VIEW V_UserSportAchiv AS (
-- SELECT UserId, SportType, SUM(Duration) AS Total_Duration, SUM(Amount) AS Total_Amount, SUM(Amount) * AVG(Consuming) AS Total_Consuming FROM (
--  SELECT t1.UserId, t1.SportType, t1.StartTime, t1.Duration, t1.Amount, t2.Consuming, t2.Unit FROM UserSportTrack t1 LEFT JOIN Sport t2 ON t1.SportType = t2.SportType) t
-- GROUP BY UserId, SportType
--);

-- 用户健康情况视图
	-- 最新健康状况视图
CREATE VIEW V_UserCurrHealth AS(
 SELECT UserId, Height, Weight, BodyFatRate, CAST(CAST(Weight AS float)/CAST(Height AS FLOAT)/Height*10000 AS decimal(3,1))AS BMI 
 FROM UserInfo x 
 WHERE WriteInDate = (SELECT MAX(WriteInDate) FROM UserInfo y WHERE x.UserId = y.UserId) 
 );

	-- 按月聚合健康状况视图
CREATE VIEW V_UserMonthHealth AS(
	SELECT UserId, LEFT(WriteInDate,7) AS 'Month', 
	AVG(Height) AS 'Height', 
	AVG(Weight) AS 'Weight', 
	AVG(BodyFatRate) AS 'BodyFatRate',
	CAST(CAST(AVG(Weight) AS float)/CAST(AVG(Height) AS FLOAT)/AVG(Height)*10000 AS decimal(3,1))AS BMI
	FROM UserInfo 
	GROUP BY UserId,LEFT(WriteInDate,7)
);

-- 用户每日运动视图（增加总消耗、总运动时长、糖元消耗、脂肪消耗字段）
CREATE VIEW V_UserDailySport AS(
	SELECT UserId, WriteInDate, 
	CAST (SUM(Duration) AS INT) AS Daily_Duration, 
	CAST( SUM(AvgConsuming*Duration*Tensity) AS INT)AS Daily_Consuming,
	SUM(Sugar_Consuming) AS Daily_SugarConsuming,
	SUM(Fat_Consuming) AS Daily_FatConsuming
	FROM (
		SELECT UserId, WriteInDate, Duration, Tensity, AvgConsuming, 
		(0.6 - CAST(Duration AS FLOAT)/100*0.2) * AvgConsuming * Tensity*Duration AS Sugar_Consuming,
		(0.4 +CAST(Duration AS FLOAT)/100*0.2) * AvgConsuming * Tensity*Duration AS Fat_Consuming
		FROM UserSportTrack x 
		LEFT JOIN Sport y 
		ON x.SportType = y.SportType
	) T
	GROUP BY UserId, WriteInDate
);


-- 用户7日内运动视图（7日内总运动时常、7日内总消耗）
CREATE VIEW V_UserWeeklySport AS (
	SELECT UserId, 
	SUM(Daily_Duration) AS Weekly_Duration, 
	SUM(Daily_Consuming) AS Weekly_Consuming 
	FROM V_UserDailySport 
	WHERE DateDiff(dd,WriteInDate,getdate())<=7 
	GROUP BY UserId
);


-- 用户-运动视图(GROUP BY uesrId,Sport， 统计每种运动的次数，每种运动总时间，卡路里)
CREATE VIEW V_SportAggr AS (
	SELECT UserId, SportType, 
	COUNT(*) AS cnt, 
	SUM(Duration) AS Total_Duration,
	SUM(Consuming) AS Total_Consuming
	FROM (
		SELECT UserId, x.SportType, Duration, Tensity * AvgConsuming AS Consuming
		FROM UserSportTrack x 
		LEFT JOIN Sport y 
		ON x.SportType = y.SportType
	) T
	GROUP BY UserId, SportType
);

-- 用户饮食视图（每天摄入总能量(KCal)、总克数(g)、总蛋白质(g)、总碳水(g)、总脂肪(g))
CREATE VIEW V_DiteDaily AS(
	SELECT UserId, IntakeDate, 
	SUM(IntakeAmount) AS Daily_Amt,
	SUM(Energy_Intake) AS Daily_Energy, 
	SUM(Protein_Intake) AS Daily_Protein,
	SUM(Carbohydrate_Intake) AS Daily_carb,
	SUM(Fat_Intake) AS Daily_Fat 
	FROM(
		SELECT UserId, IntakeDate, x.FoodName,IntakeAmount, 
		(SugarRate*IntakeAmount*4 + IntakeAmount * Energy) AS Energy_Intake,
		IntakeAmount * Protein AS Protein_Intake,
		(SugarRate*IntakeAmount*1.0 + IntakeAmount*Carbohydrate) AS Carbohydrate_Intake,
		IntakeAmount * Fat AS Fat_Intake
		FROM UserDite x LEFT JOIN Food y ON x.FoodName  =y.FoodName
	) T
	GROUP BY UserId, IntakeDate
);