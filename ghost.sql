/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50617
Source Host           : localhost:3306
Source Database       : ghost

Target Server Type    : MYSQL
Target Server Version : 50617
File Encoding         : 65001

Date: 2016-05-07 20:08:03
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `accounts`
-- ----------------------------
DROP TABLE IF EXISTS `accounts`;
CREATE TABLE `accounts` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `userName` varchar(20) CHARACTER SET big5 NOT NULL,
  `password` varchar(128) CHARACTER SET big5 NOT NULL,
  `salt` varchar(32) NOT NULL,
  `pin` varchar(32) NOT NULL,
  `birthday` datetime NOT NULL,
  `creation` datetime NOT NULL,
  `gender` int(1) NOT NULL,
  `isLoggedIn` int(1) NOT NULL,
  `isBanned` int(1) NOT NULL,
  `isMaster` int(1) NOT NULL,
  `cashPoint` int(8) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of accounts
-- ----------------------------
INSERT INTO `accounts` VALUES ('1', 'admin', '123456', '', '', '2015-04-07 21:11:26', '2015-04-07 21:11:30', '0', '0', '0', '1', '0');

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
  `position` int(4) NOT NULL DEFAULT '-1',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of characters
-- ----------------------------

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
) ENGINE=InnoDB AUTO_INCREMENT=107 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of items
-- ----------------------------

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
) ENGINE=InnoDB AUTO_INCREMENT=39 DEFAULT CHARSET=latin1;

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
) ENGINE=InnoDB AUTO_INCREMENT=43 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of skills
-- ----------------------------
