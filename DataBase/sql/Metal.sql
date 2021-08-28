--徽章表--
USE BI
CREATE TABLE Metal (
	MetalId INT IDENTITY(1,1) NOT NULL,
	MetalName VARCHAR(20) NOT NULL,
	Experience INT NOT NULL,
	PRIMARY KEY(MetalId)
)

--徽章数据--
INSERT INTO Metal Values
	('始于足下',70),
	('心血来潮',120),
	('毫无保留',100)

--创建用户徽章记录表--
USE BI
CREATE TABLE UserMetal(
	UserId VARCHAR(20) NOT NULL CHECK(LEN(UserId) BETWEEN 6 AND 20 AND UserId LIKE '[A-Za-z0-9]%') FOREIGN KEY REFERENCES UserAccount(UserId),
	MetalId INT NOT NULL FOREIGN KEY REFERENCES Metal(MetalId),
	Number INT NOT NULL
)
--用户徽章记录--
INSERT INTO UserMetal VALUES
	('100001',1,3),
	('100001',2,2),
	('100001',3,1)

--向用户徽章记录表中添加WriteInDate列--
ALTER TABLE UserMetal ADD WriteInDate DATE