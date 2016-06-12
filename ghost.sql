/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50617
Source Host           : localhost:3306
Source Database       : ghost

Target Server Type    : MYSQL
Target Server Version : 50617
File Encoding         : 65001

Date: 2016-06-12 13:41:56
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `accounts`
-- ----------------------------
DROP TABLE IF EXISTS `accounts`;
CREATE TABLE `accounts` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(20) CHARACTER SET big5 NOT NULL,
  `password` varchar(128) CHARACTER SET big5 NOT NULL,
  `creation` datetime NOT NULL,
  `isLoggedIn` int(1) NOT NULL,
  `isBanned` int(1) NOT NULL,
  `isMaster` int(1) NOT NULL,
  `cashPoint` int(8) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of accounts
-- ----------------------------
INSERT INTO `accounts` VALUES ('1', 'admin', 'admin', '2015-04-07 21:11:30', '0', '0', '1', '0');

-- ----------------------------
-- Table structure for `characters`
-- ----------------------------
DROP TABLE IF EXISTS `characters`;
CREATE TABLE `characters` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `accountId` int(11) NOT NULL,
  `worldId` int(1) NOT NULL,
  `name` varchar(20) CHARACTER SET big5 NOT NULL,
  `title` varchar(20) CHARACTER SET big5 NOT NULL,
  `gender` int(1) NOT NULL DEFAULT '1',
  `hair` int(8) NOT NULL,
  `eyes` int(8) NOT NULL,
  `level` int(4) NOT NULL DEFAULT '1',
  `classId` int(4) NOT NULL DEFAULT '0',
  `classLv` int(4) NOT NULL DEFAULT '-1',
  `hp` int(8) NOT NULL DEFAULT '1',
  `maxHp` int(8) NOT NULL DEFAULT '1',
  `mp` int(8) NOT NULL DEFAULT '1',
  `maxMp` int(8) NOT NULL DEFAULT '1',
  `fury` int(8) NOT NULL DEFAULT '0',
  `maxFury` int(8) NOT NULL DEFAULT '1200',
  `exp` int(8) NOT NULL DEFAULT '0',
  `fame` int(8) NOT NULL DEFAULT '0',
  `money` int(8) NOT NULL DEFAULT '0',
  `rank` int(8) NOT NULL DEFAULT '0',
  `c_str` int(4) NOT NULL DEFAULT '3',
  `c_dex` int(4) NOT NULL DEFAULT '3',
  `c_vit` int(4) NOT NULL DEFAULT '3',
  `c_int` int(4) NOT NULL DEFAULT '3',
  `upgradeStr` int(4) NOT NULL DEFAULT '0',
  `upgradeDex` int(4) NOT NULL DEFAULT '0',
  `upgradeVit` int(4) NOT NULL DEFAULT '0',
  `upgradeInt` int(4) NOT NULL DEFAULT '0',
  `attack` int(4) NOT NULL DEFAULT '0',
  `maxAttack` int(4) NOT NULL DEFAULT '0',
  `upgradeAttack` int(4) NOT NULL DEFAULT '0',
  `magic` int(4) NOT NULL DEFAULT '0',
  `maxMagic` int(4) NOT NULL DEFAULT '0',
  `upgradeMagic` int(4) NOT NULL DEFAULT '0',
  `defense` int(4) NOT NULL DEFAULT '0',
  `upgradeDefense` int(4) NOT NULL DEFAULT '0',
  `abilityBonus` int(4) NOT NULL DEFAULT '0',
  `skillBonus` int(4) NOT NULL DEFAULT '0',
  `jumpHeight` int(4) NOT NULL DEFAULT '3',
  `mapX` int(4) NOT NULL DEFAULT '0',
  `mapY` int(4) NOT NULL DEFAULT '0',
  `playerX` int(4) NOT NULL DEFAULT '0',
  `playerY` int(4) NOT NULL DEFAULT '0',
  `direction` int(4) NOT NULL,
  `position` int(4) NOT NULL DEFAULT '-1',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=64 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of characters
-- ----------------------------
INSERT INTO `characters` VALUES ('63', '1', '0', 'Test', '江湖人', '1', '9010041', '9110061', '6', '0', '255', '161', '161', '100', '100', '1305', '1200', '45', '0', '959147', '0', '15', '3', '3', '3', '0', '0', '0', '0', '1', '37', '0', '1', '3', '0', '10', '0', '8', '4', '3', '1', '41', '755', '628', '0', '1');

-- ----------------------------
-- Table structure for `coupon`
-- ----------------------------
DROP TABLE IF EXISTS `coupon`;
CREATE TABLE `coupon` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `code` varchar(20) NOT NULL,
  `itemID` int(8) NOT NULL,
  `quantity` int(3) NOT NULL,
  `valid` int(1) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of coupon
-- ----------------------------

-- ----------------------------
-- Table structure for `drop_data`
-- ----------------------------
DROP TABLE IF EXISTS `drop_data`;
CREATE TABLE `drop_data` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `mobID` int(11) NOT NULL DEFAULT '0',
  `itemID` int(11) NOT NULL DEFAULT '0',
  `min_quantity` int(11) NOT NULL DEFAULT '1',
  `max_quantity` int(11) NOT NULL DEFAULT '1',
  `questID` int(11) NOT NULL DEFAULT '0',
  `chance` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of drop_data
-- ----------------------------
INSERT INTO `drop_data` VALUES ('1', '1000101', '8820011', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('2', '1000101', '8810011', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('3', '1000101', '8130011', '1', '1', '0', '100000');
INSERT INTO `drop_data` VALUES ('4', '1000101', '8120012', '1', '1', '0', '100000');
INSERT INTO `drop_data` VALUES ('5', '1000101', '8910011', '1', '1', '0', '600000');
INSERT INTO `drop_data` VALUES ('6', '1000101', '8510011', '1', '1', '0', '50000');
INSERT INTO `drop_data` VALUES ('7', '1000201', '8820011', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('8', '1000201', '8810011', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('9', '1000201', '8130012', '1', '1', '0', '100000');
INSERT INTO `drop_data` VALUES ('10', '1000201', '8110012', '1', '1', '0', '100000');
INSERT INTO `drop_data` VALUES ('11', '1000201', '8910021', '1', '1', '0', '600000');
INSERT INTO `drop_data` VALUES ('12', '1000201', '8510011', '1', '1', '0', '50000');

-- ----------------------------
-- Table structure for `items`
-- ----------------------------
DROP TABLE IF EXISTS `items`;
CREATE TABLE `items` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `cid` int(11) NOT NULL,
  `itemId` int(8) NOT NULL,
  `quantity` int(3) NOT NULL,
  `slot` int(3) NOT NULL,
  `type` int(3) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=424 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of items
-- ----------------------------
INSERT INTO `items` VALUES ('254', '63', '8010011', '1', '0', '0');
INSERT INTO `items` VALUES ('255', '63', '8120011', '1', '1', '0');
INSERT INTO `items` VALUES ('256', '63', '8510011', '1', '5', '0');
INSERT INTO `items` VALUES ('262', '63', '8130011', '1', '0', '1');
INSERT INTO `items` VALUES ('265', '63', '8510011', '1', '0', '2');
INSERT INTO `items` VALUES ('328', '63', '8130012', '1', '6', '1');
INSERT INTO `items` VALUES ('329', '63', '8110012', '1', '7', '1');
INSERT INTO `items` VALUES ('331', '63', '8510011', '1', '1', '2');
INSERT INTO `items` VALUES ('336', '63', '8510011', '1', '2', '2');
INSERT INTO `items` VALUES ('343', '63', '8130012', '1', '12', '1');
INSERT INTO `items` VALUES ('352', '63', '8510011', '1', '6', '2');
INSERT INTO `items` VALUES ('355', '63', '8130012', '1', '18', '1');
INSERT INTO `items` VALUES ('356', '63', '8110012', '1', '19', '1');
INSERT INTO `items` VALUES ('358', '63', '8510011', '1', '7', '2');
INSERT INTO `items` VALUES ('382', '63', '8130012', '1', '1', '1');
INSERT INTO `items` VALUES ('383', '63', '8130011', '1', '2', '1');
INSERT INTO `items` VALUES ('385', '63', '8820011', '100', '0', '3');
INSERT INTO `items` VALUES ('388', '63', '8910011', '35', '0', '4');
INSERT INTO `items` VALUES ('394', '63', '8510011', '1', '3', '2');
INSERT INTO `items` VALUES ('396', '63', '8510011', '1', '4', '2');
INSERT INTO `items` VALUES ('397', '63', '8120012', '1', '4', '1');
INSERT INTO `items` VALUES ('398', '63', '8510011', '1', '5', '2');
INSERT INTO `items` VALUES ('399', '63', '8120012', '1', '5', '1');
INSERT INTO `items` VALUES ('400', '63', '8510011', '1', '8', '2');
INSERT INTO `items` VALUES ('401', '63', '8510011', '1', '9', '2');
INSERT INTO `items` VALUES ('402', '63', '8120012', '1', '8', '1');
INSERT INTO `items` VALUES ('405', '63', '8510011', '1', '12', '2');
INSERT INTO `items` VALUES ('406', '63', '8120012', '1', '13', '1');
INSERT INTO `items` VALUES ('407', '63', '8510011', '1', '13', '2');
INSERT INTO `items` VALUES ('408', '63', '8120012', '1', '14', '1');
INSERT INTO `items` VALUES ('409', '63', '8510011', '1', '14', '2');
INSERT INTO `items` VALUES ('412', '63', '8120012', '1', '20', '1');
INSERT INTO `items` VALUES ('413', '63', '8120012', '1', '21', '1');
INSERT INTO `items` VALUES ('414', '63', '8120012', '1', '22', '1');
INSERT INTO `items` VALUES ('415', '63', '8120012', '1', '23', '1');
INSERT INTO `items` VALUES ('417', '63', '8810011', '100', '2', '3');
INSERT INTO `items` VALUES ('418', '63', '8820011', '100', '1', '3');
INSERT INTO `items` VALUES ('419', '63', '8820011', '100', '3', '3');
INSERT INTO `items` VALUES ('420', '63', '8820011', '100', '4', '3');
INSERT INTO `items` VALUES ('421', '63', '8820011', '100', '5', '3');
INSERT INTO `items` VALUES ('422', '63', '8810011', '50', '6', '3');
INSERT INTO `items` VALUES ('423', '63', '8820011', '50', '7', '3');

-- ----------------------------
-- Table structure for `keymaps`
-- ----------------------------
DROP TABLE IF EXISTS `keymaps`;
CREATE TABLE `keymaps` (
  `cid` int(11) NOT NULL,
  `quickslot` varchar(8) CHARACTER SET big5 NOT NULL,
  `skillID` int(6) NOT NULL,
  `type` int(3) NOT NULL,
  `slot` int(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of keymaps
-- ----------------------------
INSERT INTO `keymaps` VALUES ('63', 'Z', '1', '0', '0');
INSERT INTO `keymaps` VALUES ('63', 'C', '3', '0', '2');
INSERT INTO `keymaps` VALUES ('63', 'X', '4', '0', '3');

-- ----------------------------
-- Table structure for `quests`
-- ----------------------------
DROP TABLE IF EXISTS `quests`;
CREATE TABLE `quests` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `cid` int(11) NOT NULL,
  `questId` int(8) NOT NULL,
  `questState` int(3) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of quests
-- ----------------------------

-- ----------------------------
-- Table structure for `skills`
-- ----------------------------
DROP TABLE IF EXISTS `skills`;
CREATE TABLE `skills` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `cid` int(11) NOT NULL,
  `skillId` int(8) NOT NULL,
  `skillLevel` int(3) NOT NULL,
  `type` int(3) NOT NULL,
  `slot` int(3) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=268 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of skills
-- ----------------------------
INSERT INTO `skills` VALUES ('264', '63', '1', '1', '0', '0');
INSERT INTO `skills` VALUES ('265', '63', '2', '7', '0', '1');
INSERT INTO `skills` VALUES ('266', '63', '3', '1', '0', '2');
INSERT INTO `skills` VALUES ('267', '63', '4', '1', '0', '3');

-- ----------------------------
-- Table structure for `storages`
-- ----------------------------
DROP TABLE IF EXISTS `storages`;
CREATE TABLE `storages` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `cid` int(11) NOT NULL,
  `itemID` int(11) NOT NULL DEFAULT '0',
  `quantity` int(11) NOT NULL DEFAULT '0',
  `type` int(11) NOT NULL DEFAULT '0',
  `slot` int(11) NOT NULL DEFAULT '0',
  `money` int(10) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=114 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of storages
-- ----------------------------
INSERT INTO `storages` VALUES ('113', '63', '0', '0', '0', '0', '0');
