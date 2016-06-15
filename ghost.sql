/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50617
Source Host           : localhost:3306
Source Database       : ghost

Target Server Type    : MYSQL
Target Server Version : 50617
File Encoding         : 65001

Date: 2016-06-15 18:55:44
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
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

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
) ENGINE=InnoDB AUTO_INCREMENT=69 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of characters
-- ----------------------------

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
) ENGINE=InnoDB AUTO_INCREMENT=373 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of drop_data
-- ----------------------------
INSERT INTO `drop_data` VALUES ('1', '1000101', '8820011', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('2', '1000101', '8810011', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('3', '1000101', '8130011', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('4', '1000101', '8120012', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('5', '1000101', '8910011', '1', '1', '0', '600000');
INSERT INTO `drop_data` VALUES ('6', '1000101', '8510011', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('7', '1000201', '8820011', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('8', '1000201', '8810011', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('9', '1000201', '8130012', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('10', '1000201', '8110012', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('11', '1000201', '8910021', '1', '1', '0', '600000');
INSERT INTO `drop_data` VALUES ('12', '1000201', '8510011', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('13', '1000301', '8820011', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('14', '1000301', '8810011', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('15', '1000301', '8010011', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('16', '1000301', '8110011', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('17', '1000301', '8910031', '1', '1', '0', '600000');
INSERT INTO `drop_data` VALUES ('18', '1000301', '8510011', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('19', '1000501', '8820011', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('20', '1000501', '8810011', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('21', '1000501', '8030011', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('22', '1000501', '8130012', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('23', '1000501', '8910051', '1', '1', '0', '600000');
INSERT INTO `drop_data` VALUES ('24', '1000501', '8510011', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('25', '1000601', '8820011', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('26', '1000601', '8810011', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('27', '1000601', '8110011', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('28', '1000601', '8120011', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('29', '1000601', '8910061', '1', '1', '0', '600000');
INSERT INTO `drop_data` VALUES ('30', '1000601', '8510011', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('36', '1000701', '8820011', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('37', '1000701', '8810011', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('38', '1000701', '8010011', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('39', '1000701', '8030011', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('40', '1000701', '8910071', '1', '1', '0', '600000');
INSERT INTO `drop_data` VALUES ('41', '1000701', '8510011', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('42', '1000801', '8820011', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('43', '1000801', '8810011', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('44', '1000801', '8120011', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('45', '1000801', '8910081', '1', '1', '0', '600000');
INSERT INTO `drop_data` VALUES ('46', '1000801', '8510011', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('47', '1001001', '8820011', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('48', '1001001', '8810011', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('49', '1001001', '8210081', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('50', '1001001', '8310081', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('51', '1001001', '8910101', '1', '1', '0', '600000');
INSERT INTO `drop_data` VALUES ('52', '1001201', '8820011', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('53', '1001201', '8810011', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('54', '1001201', '8030101', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('55', '1001201', '8110101', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('56', '1001201', '8120101', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('57', '1001201', '8880011', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('58', '1001201', '8910121', '1', '1', '0', '600000');
INSERT INTO `drop_data` VALUES ('59', '1001201', '8510021', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('60', '1001401', '8820011', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('61', '1001401', '8810011', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('62', '1001401', '8040101', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('63', '1001401', '8060101', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('64', '1001401', '8110102', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('65', '1001401', '8880011', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('66', '1001401', '8910141', '1', '1', '0', '600000');
INSERT INTO `drop_data` VALUES ('67', '1001401', '8510021', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('68', '1001601', '8820011', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('69', '1001601', '8810011', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('70', '1001601', '8120102', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('71', '1001601', '8050101', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('72', '1001601', '8010101', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('73', '1001601', '8880011', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('74', '1001601', '8910161', '1', '1', '0', '600000');
INSERT INTO `drop_data` VALUES ('75', '1001601', '8510021', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('76', '1001801', '8820011', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('77', '1001801', '8810011', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('78', '1001801', '8020101', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('79', '1001801', '8130102', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('80', '1001801', '8110101', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('81', '1001801', '8880011', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('82', '1001801', '8910181', '1', '1', '0', '600000');
INSERT INTO `drop_data` VALUES ('83', '1001801', '8510021', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('84', '1002001', '8820021', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('85', '1002001', '8810021', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('86', '1002001', '8880011', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('87', '1002001', '8310161', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('88', '1002001', '8210161', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('89', '1002001', '8910201', '1', '1', '0', '600000');
INSERT INTO `drop_data` VALUES ('90', '1002001', '8510021', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('232', '1002101', '8910211', '1', '1', '0', '600000');
INSERT INTO `drop_data` VALUES ('233', '1002101', '8810021', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('234', '1002101', '8880021', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('235', '1002101', '8060201', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('236', '1002101', '8060251', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('237', '1002101', '8130201', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('238', '1002101', '8130202', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('239', '1002101', '8130151', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('240', '1002101', '8040251', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('241', '1002201', '8910221', '1', '1', '0', '600000');
INSERT INTO `drop_data` VALUES ('242', '1002201', '8810021', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('243', '1002201', '8820021', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('244', '1002201', '8880021', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('245', '1002201', '8020201', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('246', '1002201', '8020251', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('247', '1002201', '8120202', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('248', '1002201', '8120251', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('249', '1002401', '8910241', '1', '1', '0', '600000');
INSERT INTO `drop_data` VALUES ('250', '1002401', '8810021', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('251', '1002401', '8820021', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('252', '1002401', '8880021', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('253', '1002401', '8110201', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('254', '1002401', '8040251', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('255', '1002401', '8030251', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('256', '1002601', '8910261', '1', '1', '0', '600000');
INSERT INTO `drop_data` VALUES ('257', '1002601', '8910261', '1', '1', '0', '600000');
INSERT INTO `drop_data` VALUES ('258', '1002601', '8910261', '1', '1', '0', '600000');
INSERT INTO `drop_data` VALUES ('259', '1002601', '8880021', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('260', '1002601', '8310241', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('261', '1002601', '8120201', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('262', '1002601', '8120252', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('263', '1002601', '8110251', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('264', '1002601', '8110252', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('265', '1002601', '8010201', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('266', '1002601', '8010251', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('267', '1002801', '8910281', '1', '1', '0', '600000');
INSERT INTO `drop_data` VALUES ('268', '1002801', '8810021', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('269', '1002801', '8820021', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('270', '1002801', '8880021', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('271', '1002801', '8210241', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('272', '1002801', '8130202', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('273', '1002801', '8110202', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('274', '1002801', '8110251', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('275', '1002801', '8050201', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('276', '1002801', '8050251', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('277', '1003001', '8910301', '1', '1', '0', '600000');
INSERT INTO `drop_data` VALUES ('278', '1003001', '8810021', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('279', '1003001', '8820021', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('280', '1003001', '8880021', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('281', '1003001', '8310321', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('282', '1003001', '8210321', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('283', '1003201', '8910321', '1', '1', '0', '600000');
INSERT INTO `drop_data` VALUES ('284', '1003201', '8810021', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('285', '1003201', '8820021', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('286', '1003201', '8510061', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('287', '1003201', '8130301', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('288', '1003201', '8110351', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('289', '1003201', '8050301', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('290', '1003201', '8010351', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('291', '1003401', '8910341', '1', '1', '0', '600000');
INSERT INTO `drop_data` VALUES ('292', '1003401', '8810021', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('293', '1003401', '8820021', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('294', '1003401', '8120302', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('295', '1003401', '8040301', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('296', '1003401', '8020351', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('297', '1003401', '8020301', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('298', '1003401', '8020351', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('299', '1003501', '8810021', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('300', '1003501', '8820021', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('301', '1003501', '8880031', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('302', '1003501', '8130302', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('303', '1003501', '8110302', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('304', '1003501', '8120352', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('305', '1003501', '8110352', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('306', '1003501', '8020301', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('307', '1003601', '8710173', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('308', '1003601', '8810021', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('309', '1003601', '8820021', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('310', '1003601', '8880031', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('311', '1003601', '8130301', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('312', '1003601', '8120301', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('313', '1003601', '8050301', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('314', '1003601', '8060351', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('315', '1003701', '8810021', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('316', '1003701', '8820021', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('317', '1003701', '8880031', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('318', '1003701', '8110302', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('319', '1003701', '8130301', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('320', '1003701', '8120301', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('321', '1003701', '8050301', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('322', '1003701', '8030351', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('323', '1003701', '8040301', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('324', '1003701', '8040351', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('325', '1003801', '8910381', '1', '1', '0', '600000');
INSERT INTO `drop_data` VALUES ('326', '1003801', '8810021', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('327', '1003801', '8820021', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('328', '1003801', '8880031', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('329', '1003801', '8130302', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('330', '1003801', '8110301', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('331', '1003801', '8020301', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('332', '1003801', '8040351', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('333', '1003901', '8910391', '1', '1', '0', '600000');
INSERT INTO `drop_data` VALUES ('334', '1003901', '8810021', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('335', '1003901', '8820021', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('336', '1003901', '8130302', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('337', '1003901', '8110301', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('338', '1003901', '8120352', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('339', '1003901', '8130352', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('340', '1003901', '8010301', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('341', '1004001', '8910401', '1', '1', '0', '600000');
INSERT INTO `drop_data` VALUES ('342', '1004001', '8810021', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('343', '1004001', '8820021', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('344', '1004001', '8210401', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('345', '1004001', '8310401', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('346', '1004301', '8810021', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('347', '1004301', '8820021', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('348', '1004301', '8050351', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('349', '1004301', '8130401', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('350', '1004301', '8910431', '1', '1', '0', '600000');
INSERT INTO `drop_data` VALUES ('351', '1004401', '8910441', '1', '1', '0', '600000');
INSERT INTO `drop_data` VALUES ('352', '1004401', '8810021', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('353', '1004401', '8820031', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('354', '1004401', '8020401', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('355', '1004401', '8030401', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('356', '1004501', '8110401', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('357', '1004501', '8120402', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('358', '1004601', '8910391', '1', '1', '0', '600000');
INSERT INTO `drop_data` VALUES ('359', '1004601', '8820031', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('360', '1004601', '8010401', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('361', '1004601', '8110401', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('362', '1004601', '8050351', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('363', '1004801', '8910481', '1', '1', '0', '600000');
INSERT INTO `drop_data` VALUES ('364', '1004801', '8120402', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('365', '1004801', '8060401', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('366', '1004801', '8030401', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('367', '1004901', '8910491', '1', '1', '0', '600000');
INSERT INTO `drop_data` VALUES ('368', '1004901', '8130402', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('369', '1004901', '8130401', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('370', '1004901', '8030401', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('371', '1005001', '8910501', '1', '1', '0', '600000');
INSERT INTO `drop_data` VALUES ('372', '1005001', '8310402', '1', '1', '0', '10000');

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
) ENGINE=InnoDB AUTO_INCREMENT=583 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of items
-- ----------------------------

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

-- ----------------------------
-- Table structure for `pets`
-- ----------------------------
DROP TABLE IF EXISTS `pets`;
CREATE TABLE `pets` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `cid` int(11) NOT NULL,
  `itemId` int(11) NOT NULL,
  `decorateId` int(11) NOT NULL,
  `name` varchar(20) CHARACTER SET big5 NOT NULL,
  `level` int(11) NOT NULL,
  `hp` int(11) NOT NULL,
  `mp` int(11) NOT NULL,
  `exp` int(11) NOT NULL,
  `type` int(3) NOT NULL,
  `slot` int(3) NOT NULL,
  `originalSlot` int(3) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of pets
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
) ENGINE=InnoDB AUTO_INCREMENT=29 DEFAULT CHARSET=latin1;

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
) ENGINE=InnoDB AUTO_INCREMENT=312 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of skills
-- ----------------------------

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
) ENGINE=InnoDB AUTO_INCREMENT=119 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of storages
-- ----------------------------

-- ----------------------------
-- Table structure for `useslot`
-- ----------------------------
DROP TABLE IF EXISTS `useslot`;
CREATE TABLE `useslot` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `cid` int(11) NOT NULL,
  `type` int(3) NOT NULL,
  `slot` int(3) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=314 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of useslot
-- ----------------------------
