/*
 Navicat Premium Data Transfer

 Source Server         : localhost_sqlserver
 Source Server Type    : SQL Server
 Source Server Version : 11002100
 Source Host           : LAPTOP-Q7SEB9E1:1433
 Source Catalog        : SDE
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 11002100
 File Encoding         : 65001

 Date: 18/05/2022 15:26:20
*/


-- ----------------------------
-- Table structure for userInfo
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[userInfo]') AND type IN ('U'))
	DROP TABLE [dbo].[userInfo]
GO

CREATE TABLE [dbo].[userInfo] (
  [id] int  IDENTITY(1,1) NOT NULL,
  [name] nchar(10) COLLATE Chinese_PRC_CI_AS  NULL,
  [password] nvarchar(50) COLLATE Chinese_PRC_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[userInfo] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of [userInfo]
-- ----------------------------
SET IDENTITY_INSERT [dbo].[userInfo] ON
GO

INSERT INTO [dbo].[userInfo] ([id], [name], [password]) VALUES (N'1', N'admin     ', N'123456')
GO

SET IDENTITY_INSERT [dbo].[userInfo] OFF
GO

