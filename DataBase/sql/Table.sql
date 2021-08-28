-- 创建BodyIntelligence数据库
IF EXISTS(SELECT * FROM sys.databases WHERE name = 'BI') DROP DATABASE BI;
CREATE DATABASE BI;
-- 指定数据库
USE BI;

/**
* Part1: 系统表，后台输入
* 包括: 运动方式表、成就徽章表、食物信息表
*
*/

-- 创建运动方式表
 -- Unit表示单位工作量的量纲
 -- Consuming表示的是单位时间(/min)下的平均消耗，单位：kCal
CREATE TABLE Sport(
 SportType VARCHAR(30) NOT NULL,
 AvgConsuming FLOAT NOT NULL,
 PRIMARY KEY (SportType)
);

-- 成就徽章表
CREATE TABLE Achievement(
 SportType VARCHAR(30) NOT NULL FOREIGN KEY REFERENCES Sport(SportType),
 Level1 VARCHAR(255),
 Level2 VARCHAR(255),
 Level3 VARCHAR(255),
 PRIMARY KEY (SportType)
);

-- 食物信息表
CREATE TABLE Food(
 FoodName VARCHAR(30) NOT NULL,
 Energy FLOAT NOT NULL,
 Protein FLOAT NOT NULL,
 Carbohydrate FLOAT NOT NULL,
 Fat FLOAT NOT NULL,
 Descript VARCHAR(255),
 PRIMARY KEY (Foodname)
);

/**
* Part2: 用户表，用户输入
* 包括: 用户账号表、用户健康数据表、用户饮食表、用户运动行为表
*
*/

-- 创建用户账号表
CREATE TABLE UserAccount(
 UserId VARCHAR(20) NOT NULL CHECK(LEN(UserId) BETWEEN 6 AND 20 AND UserId LIKE '[A-Za-z0-9]%'),
 UserPwd VARCHAR(20) NOT NULL CHECK(LEN(UserPwd) BETWEEN 6 AND 20 AND UserPwd LIKE '[A-Za-z0-9]%'),
 UserName VARCHAR(30) NOT NULL,
 Icon VARCHAR(255),
 PRIMARY KEY (UserId)
);

-- 创建用户健康数据表
CREATE TABLE UserInfo(
 UserId VARCHAR(20) CHECK(LEN(UserId) BETWEEN 6 AND 20 AND UserId LIKE '[A-Za-z0-9]%') FOREIGN KEY REFERENCES UserAccount(UserId),
 WriteInDate DATE NOT NULL,
 Height INT NOT NULL,
 Weight INT NOT NULL,
 BodyFatRate INT,
 PRIMARY KEY (UserId, WriteInDate)
);

-- 创建用户饮食表
	-- intakeAmount单位：克

CREATE TABLE UserDite(
 UserId VARCHAR(20) CHECK(LEN(UserId) BETWEEN 6 AND 20 AND UserId LIKE '[A-Za-z0-9]%') FOREIGN KEY REFERENCES UserAccount(UserId),
 FoodName VARCHAR(30) NOT NULL FOREIGN KEY REFERENCES Food(FoodName),
 IntakeDate Date NOT NULL,
 IntakeAmount FLOAT NOT NULL,
 SugarRate FLOAT CHECK(SugarRate IN (0, 0.1, 0.2, 0.3))
 PRIMARY KEY (UserId, FoodName, IntakeDate)
);

-- 用户运动行为表
 -- Duration: /min
 -- Amount：按照Sport里面的Unit作为基本单位
CREATE TABLE UserSportTrack(
 UserId VARCHAR(20) CHECK(LEN(UserId) BETWEEN 6 AND 20 AND UserId LIKE '[A-Za-z0-9]%') FOREIGN KEY REFERENCES UserAccount(UserId),
 SportType VARCHAR(30) NOT NULL FOREIGN KEY REFERENCES Sport(SportType),
 WriteInDate DATE NOT NULL,
 Duration SMALLINT NOT NULL,
 Tensity FLOAT CHECK(Tensity IN (0.7,1,1.3)),
 PRIMARY KEY (UserId, SportType, WriteInDate)
);

/**
* part5: 测试数据
* 包括：
*
*/
INSERT INTO UserAccount (UserId, UserPwd, UserName) VALUES
('100001','123456','admin'),
('User_Theo','123456','Theo'),
('User_Felix','123456','Felix')
;

INSERT INTO UserInfo VALUES
('100001','2021-06-10',181,70,21),
('100001','2021-05-10',181,72,22),
('100001','2021-04-10',180,75,23),
('100001','2021-03-10',180,80,26),
('100001','2021-02-10',180,76,22),
('100001','2021-01-10',180,71,19),
('100001','2020-12-10',180,73,21)
;


INSERT INTO Sport VALUES
('跑步', 8),
('骑行', 6),
('游泳', 8),
('篮球', 9),
('足球', 9),
('排球', 9),
('羽毛球', 8.5),
('网球', 7.2),
('乒乓球', 6),
('自由活动', 4)
;

INSERT INTO Food (FoodName, Energy, Protein, Carbohydrate, Fat) VALUES
('谷物米面',3.46,0.06,0.72,0.009),
('面包烘焙',3.12,0.08,0.6,0.05),
('兽禽肉类',4,0.13,0.02,0.35),
('鱼虾海鲜',1.2,0.16,0.04,0.05),
('蛋类',1.44,0.14,0.03,0.08),
('蔬菜',0.1,0.01,0.01,0.003),
('水果',0.5,0,0.1,0),
('牛奶',0.6,0.03,0.03,0.03),
('甜品',5,0.07,0.6,0.25),
('油脂',9,0,0,1),
('糖',4,0,1,0)
;

INSERT INTO UserSportTrack VALUES
('100001','游泳','2021-06-14',100,1),
('100001','跑步','2021-06-13',50,1),
('100001','自由活动','2021-06-13',120,0.7),
('100001','游泳','2021-06-12',60,1.3),
('100001','骑行','2021-06-11',60,1),
('100001','跑步','2021-06-11',30,1.3),
('100001','自由活动','2021-06-10',30,1.3),
('100001','游泳','2021-06-10',120,0.7),
('100001','足球','2021-06-10',20,1.3),
('100001','足球','2021-06-09',30,1.3),
('100001','游泳','2021-06-08',100,1.3),
('100001','跑步','2021-06-07',20,1),
('100001','骑行','2021-06-07',25,1),
('100001','游泳','2021-06-06',60,0.7),
('100001','足球','2021-06-05',60,1.3),
('100001','游泳','2021-06-04',40,1.3),
('100001','跑步','2021-06-04',30,1)
;


INSERT INTO UserDite VALUES
--
('100001', '谷物米面', '2021-6-14', 200, 0.1),
('100001', '面包烘焙', '2021-6-14', 100, 0.3),
('100001', '兽禽肉类', '2021-6-14', 200, 0.1),
('100001', '牛奶', '2021-6-14', 200, 0.1),
('100001', '蔬菜', '2021-6-14', 100, 0.1),
--
('100001', '水果', '2021-6-13', 200, 0.1),
('100001', '牛奶', '2021-6-13', 200, 0),
('100001', '兽禽肉类', '2021-6-13', 200, 0.1),
('100001', '蛋类', '2021-6-13', 100, 0),
('100001', '谷物米面', '2021-6-13', 400, 0.1),
--
('100001', '谷物米面', '2021-6-12', 300, 0),
('100001', '兽禽肉类', '2021-6-12', 100, 0.1),
('100001', '蔬菜', '2021-6-12', 200, 0.1),
('100001', '蛋类', '2021-6-12', 50, 0),
('100001', '甜品', '2021-6-12', 100, 0.3),
--
('100001', '谷物米面', '2021-6-11', 300, 0),
('100001', '兽禽肉类', '2021-6-11', 200, 0.1),
('100001', '蛋类', '2021-6-11', 100, 0),
('100001', '蔬菜', '2021-6-11', 200, 0.1),
--
('100001', '谷物米面', '2021-6-10', 100, 0),
('100001', '水果', '2021-6-10', 300, 0.1),
('100001', '牛奶', '2021-6-10', 500, 0),
('100001', '鱼虾海鲜', '2021-6-10', 200, 0.1),
--
('100001', '面包烘焙', '2021-6-09', 200, 0.2),
('100001', '谷物米面', '2021-6-09', 300, 0),
('100001', '蔬菜', '2021-6-09', 300, 0),
('100001', '水果', '2021-6-09', 100, 0.1),
('100001', '牛奶', '2021-6-09', 200, 0),
--
('100001', '谷物米面', '2021-6-08', 300, 0.1),
('100001', '兽禽肉类', '2021-6-08', 200, 0.1),
('100001', '蔬菜', '2021-6-08', 100, 0.1),
('100001', '蛋类', '2021-6-08', 100, 0),
('100001', '甜品', '2021-6-08', 100, 0.3),
--
('100001', '谷物米面', '2021-6-07', 100, 0),
('100001', '面包烘焙', '2021-6-07', 300, 0.2),
('100001', '兽禽肉类', '2021-6-07', 200, 0.1),
('100001', '牛奶', '2021-6-07', 300, 0.1),
('100001', '蔬菜', '2021-6-07', 200, 0.1)
;