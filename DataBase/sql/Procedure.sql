
/**
* part4: 存储过程、触发器
* 包括：
*
*/
USE BI;

 -- 查询用户某一天的运动总时长、运动总消耗
CREATE PROCEDURE GetDailySportRecord
@SelectedId varchar(100),
@SelectedDate varchar(100)
AS
BEGIN
	SELECT * FROM V_UserDailySport WHERE UserId = @SelectedId AND WriteInDate = @SelectedDate
end;

 -- 查询某用户运动时长分布
CREATE PROCEDURE GetSportTimeDistribute
@SelectId varchar(100)
AS
BEGIN
	SELECT UserId, TimeZone, COUNT(*) AS cnt FROM(
		SELECT 
		UserId,
		CASE(Duration/30)
			WHEN 0 THEN '0-30'
			WHEN 1 THEN '30-60'
		ELSE '60+' END AS TimeZone
		FROM UserSportTrack 
		WHERE UserId = @SelectId
	) T
	GROUP BY UserId,TimeZone
	ORDER BY TimeZone
END;

-- 查询某用户运动强度分布
CREATE PROCEDURE GetSportIntensityDistribute
@SelectedId varchar(100)
AS
BEGIN
	SELECT UserId, Tensity, COUNT(*) AS cnt FROM UserSportTrack GROUP BY UserId, Tensity HAVING UserId = @SelectedId
END;

-- 查询用户饮食热量分布（高热量，中热量，低热量）
CREATE PROCEDURE GetDiteEnergyDistribute
@SelectedId varchar(100)
AS
BEGIN
	SELECT UserId, EnergyZone, COUNT(*) AS cnt FROM (
		SELECT UserId, 
		CASE 
			WHEN Daily_Energy < 1600 THEN '低热量'
			WHEN Daily_Energy BETWEEN 1600 AND 2400 THEN '中热量'
			WHEN Daily_Energy > 2400 THEN '高热量'
		END AS EnergyZone
		FROM V_DiteDaily WHERE UserId = @SelectedId
	) T
	GROUP BY UserId, EnergyZone
	ORDER BY cnt DESC
END;

-- 查询用户饮食营养分布
CREATE PROCEDURE GetDiteNutriDistribute
@SelectedId varchar(100)
AS
BEGIN
	SELECT UserId,
		SUM(Daily_Protein) AS 'Total_Protein', 
		SUM(Daily_carb) AS 'Total_Carb', 
		SUM(Daily_Fat) AS 'Total_Fat' 
	FROM V_DiteDaily WHERE UserId = @SelectedId
	GROUP BY UserId
END;

-- 查询饮食种类分布情况（各种饮食的摄入量、总热量）
CREATE PROCEDURE GetDiteTypeDistribute
@SelectedId varchar(100)
AS
BEGIN
	SELECT UserId, FoodName, SUM(IntakeAmount) AS 'Total_IntakeAmt', SUM(IntakeAmount*Energy) AS 'Total_Energy' FROM(
		SELECT UserId, x.FoodName, IntakeAmount, Energy
		FROM UserDite x LEFT JOIN Food y 
		ON x.FoodName  =y.FoodName
		WHERE UserId = @SelectedId
	) T
	GROUP BY UserId, FoodName
	ORDER BY Total_IntakeAmt DESC;
END;

-- 查询某用户某天的机能指数参数(过去7日平均每日运动消耗、中高强度总次数、中高强度总次数)
CREATE PROCEDURE GetPaiAggr
@SelectedId varchar(100),
@SelectedDate varchar(100)
AS
BEGIN
	SELECT UserId, MAX(WriteInDate) AS SelectedDay ,AVG(Daily_Consuming) AS Latest7DaysAvgConcuming, SUM(中高强度) AS '中高强度', SUM(中低强度) AS '中低强度' FROM (
	SELECT UserId, WriteInDate, 
		CAST(SUM(AvgConsuming*Duration*Tensity) AS INT) AS Daily_Consuming,
		SUM(中高强度) AS '中高强度',
		SUM(中低强度) AS '中低强度'
		FROM (
			SELECT UserId, WriteInDate, Tensity, Duration, AvgConsuming,
				CASE WHEN Tensity IN (1.0,1.3) THEN 1 WHEN Tensity = 0.7 THEN 0 END AS '中高强度',
				CASE WHEN Tensity IN (1.0,0.7) THEN 1 WHEN Tensity = 1.3 THEN 0 END AS '中低强度'
			FROM UserSportTrack x 
			LEFT JOIN Sport y 
			ON x.SportType = y.SportType
		) T
	WHERE UserId = @SelectedId AND  DateDiff(dd,WriteInDate,@SelectedDate) BETWEEN 0 AND 6 
	GROUP BY UserId, WriteInDate
) T
GROUP BY UserId;
END;