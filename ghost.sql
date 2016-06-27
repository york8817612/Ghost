/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50617
Source Host           : localhost:3306
Source Database       : ghost

Target Server Type    : MYSQL
Target Server Version : 50617
File Encoding         : 65001

Date: 2016-06-26 20:20:43
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
  `gamePoints` int(11) NOT NULL,
  `giftPoints` int(11) NOT NULL,
  `bonusPoints` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of accounts
-- ----------------------------
INSERT INTO `accounts` VALUES ('1', 'admin', 'admin', '2015-04-07 21:11:30', '0', '0', '1', '99999879', '10000', '3000');
INSERT INTO `accounts` VALUES ('2', 'admin2', 'admin', '0001-01-01 00:00:00', '0', '0', '1', '99999999', '0', '0');

-- ----------------------------
-- Table structure for `boydresscommodity`
-- ----------------------------
DROP TABLE IF EXISTS `boydresscommodity`;
CREATE TABLE `boydresscommodity` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `itemID` int(11) NOT NULL,
  `price` int(11) NOT NULL,
  `bargainPrice` int(11) NOT NULL,
  `term` int(11) NOT NULL DEFAULT '-1',
  `flag` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=197 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of boydresscommodity
-- ----------------------------
INSERT INTO `boydresscommodity` VALUES ('1', '9510011', '130', '130', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('2', '9510021', '130', '130', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('3', '9510031', '120', '120', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('4', '9510041', '140', '140', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('5', '9510013', '130', '130', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('6', '9510015', '130', '130', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('7', '9510023', '130', '130', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('8', '9510025', '130', '130', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('9', '9510033', '120', '120', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('10', '9510035', '120', '120', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('11', '9510043', '140', '140', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('12', '9510045', '140', '140', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('13', '9510141', '130', '130', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('14', '9510143', '130', '130', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('15', '9510145', '130', '130', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('16', '9510147', '130', '130', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('17', '9510151', '130', '130', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('18', '9510153', '130', '130', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('19', '9510155', '130', '130', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('20', '9510171', '130', '130', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('21', '9510173', '130', '130', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('22', '9510175', '130', '130', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('23', '9510161', '120', '120', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('24', '9510163', '120', '120', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('25', '9510165', '120', '120', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('26', '9510191', '115', '115', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('27', '9510193', '115', '115', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('28', '9510195', '115', '115', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('29', '9510251', '130', '130', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('30', '9510253', '130', '130', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('31', '9510255', '130', '130', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('32', '9510257', '130', '130', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('33', '9510181', '115', '115', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('34', '9510183', '115', '115', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('35', '9510185', '115', '115', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('36', '9510201', '130', '130', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('37', '9510203', '130', '130', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('38', '9510205', '130', '130', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('39', '9510211', '130', '130', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('40', '9510213', '130', '130', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('41', '9510215', '130', '130', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('42', '9510241', '115', '115', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('43', '9510243', '115', '115', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('44', '9510245', '115', '115', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('45', '9510247', '115', '115', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('46', '9510221', '110', '110', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('47', '9510223', '110', '110', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('48', '9510225', '110', '110', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('49', '9510231', '105', '105', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('50', '9510233', '105', '105', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('51', '9510235', '105', '105', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('52', '9510237', '105', '105', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('53', '9510261', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('54', '9510263', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('55', '9510267', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('56', '9510265', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('57', '9510381', '90', '90', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('58', '9510383', '90', '90', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('59', '9510385', '90', '90', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('60', '9510387', '90', '90', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('61', '9510391', '90', '90', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('62', '9510393', '90', '90', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('63', '9510395', '90', '90', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('64', '9510397', '90', '90', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('65', '9510271', '90', '90', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('66', '9510281', '90', '90', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('67', '9510283', '90', '90', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('68', '9510285', '90', '90', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('69', '9510291', '130', '130', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('70', '9510301', '130', '130', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('71', '9510305', '130', '130', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('72', '9510303', '130', '130', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('73', '9510307', '130', '130', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('74', '9510311', '130', '130', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('75', '9510313', '130', '130', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('76', '9510315', '130', '130', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('77', '9510317', '130', '130', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('78', '9510321', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('79', '9510323', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('80', '9510325', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('81', '9510327', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('82', '9510341', '130', '130', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('83', '9510343', '130', '130', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('84', '9510345', '130', '130', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('85', '9510347', '130', '130', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('86', '9510331', '130', '130', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('87', '9510333', '130', '130', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('88', '9510335', '130', '130', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('89', '9510371', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('90', '9510373', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('91', '9510375', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('92', '9510377', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('93', '9510351', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('94', '9510353', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('95', '9510355', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('96', '9510357', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('97', '9510411', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('98', '9510413', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('99', '9510415', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('100', '9510417', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('101', '9510431', '105', '105', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('102', '9510433', '105', '105', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('103', '9510435', '105', '105', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('104', '9510437', '105', '105', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('105', '9510401', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('106', '9510403', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('107', '9510405', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('108', '9510407', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('109', '9510421', '105', '105', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('110', '9510425', '105', '105', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('111', '9510427', '105', '105', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('112', '9510423', '105', '105', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('113', '9510361', '105', '105', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('114', '9510363', '105', '105', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('115', '9510365', '105', '105', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('116', '9510367', '105', '105', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('117', '9510441', '105', '105', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('118', '9510443', '105', '105', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('119', '9510445', '105', '105', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('120', '9510447', '105', '105', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('121', '9510451', '105', '105', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('122', '9510453', '105', '105', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('123', '9510455', '105', '105', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('124', '9510457', '105', '105', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('125', '9510461', '105', '105', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('126', '9510463', '105', '105', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('127', '9510465', '105', '105', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('128', '9510467', '105', '105', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('129', '9510481', '105', '105', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('130', '9510483', '105', '105', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('131', '9510485', '105', '105', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('132', '9510487', '105', '105', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('133', '9510491', '125', '125', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('134', '9510493', '125', '125', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('135', '9510495', '125', '125', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('136', '9510497', '125', '125', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('137', '9510531', '90', '90', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('138', '9510533', '90', '90', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('139', '9510535', '90', '90', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('140', '9510537', '90', '90', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('141', '9510541', '105', '105', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('142', '9510543', '105', '105', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('143', '9510545', '105', '105', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('144', '9510547', '105', '105', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('145', '9510561', '90', '90', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('146', '9510563', '90', '90', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('147', '9510565', '90', '90', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('148', '9510567', '90', '90', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('149', '9510571', '130', '130', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('150', '9510573', '130', '130', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('151', '9510575', '130', '130', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('152', '9510577', '130', '130', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('153', '9510651', '90', '90', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('154', '9510653', '90', '90', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('155', '9510655', '90', '90', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('156', '9510657', '90', '90', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('157', '9510641', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('158', '9510643', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('159', '9510645', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('160', '9510647', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('161', '9510661', '90', '90', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('162', '9510663', '90', '90', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('163', '9510665', '90', '90', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('164', '9510667', '90', '90', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('165', '9510681', '130', '130', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('166', '9510671', '105', '105', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('167', '9510673', '105', '105', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('168', '9510675', '105', '105', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('169', '9510677', '105', '105', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('170', '9510581', '130', '130', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('171', '9510583', '130', '130', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('172', '9510585', '130', '130', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('173', '9510587', '130', '130', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('174', '9510611', '130', '130', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('175', '9510613', '130', '130', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('176', '9510615', '130', '130', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('177', '9510617', '130', '130', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('178', '9510601', '130', '130', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('179', '9510603', '130', '130', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('180', '9510605', '130', '130', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('181', '9510607', '130', '130', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('182', '9510791', '105', '105', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('183', '9510793', '105', '105', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('184', '9510871', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('185', '9510873', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('186', '9510875', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('187', '9510877', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('188', '9510851', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('189', '9510853', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('190', '9510855', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('191', '9510857', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('192', '9510861', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('193', '9510863', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('194', '9510865', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('195', '9510867', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('196', '9510841', '105', '105', '-1', '0');

-- ----------------------------
-- Table structure for `boyeyescommodity`
-- ----------------------------
DROP TABLE IF EXISTS `boyeyescommodity`;
CREATE TABLE `boyeyescommodity` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `itemID` int(11) NOT NULL,
  `price` int(11) NOT NULL,
  `bargainPrice` int(11) NOT NULL,
  `term` int(11) NOT NULL DEFAULT '-1',
  `flag` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of boyeyescommodity
-- ----------------------------
INSERT INTO `boyeyescommodity` VALUES ('1', '9150081', '30', '30', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('2', '9150091', '30', '30', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('3', '9150101', '30', '30', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('4', '9150111', '30', '30', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('5', '9150141', '25', '25', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('6', '9150151', '25', '25', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('7', '9150161', '25', '25', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('8', '9150171', '25', '25', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('9', '9150181', '25', '25', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('10', '9150191', '25', '25', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('11', '9150201', '25', '25', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('12', '9150301', '30', '30', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('13', '9150311', '30', '30', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('14', '9150321', '30', '30', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('15', '9150331', '30', '30', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('16', '9150351', '25', '25', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('17', '9150361', '25', '25', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('18', '9150371', '25', '25', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('19', '9150381', '25', '25', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('20', '9150431', '25', '25', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('21', '9150441', '25', '25', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('22', '9150451', '25', '25', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('23', '9150461', '25', '25', '-1', '0');

-- ----------------------------
-- Table structure for `boyhaircommodity`
-- ----------------------------
DROP TABLE IF EXISTS `boyhaircommodity`;
CREATE TABLE `boyhaircommodity` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `itemID` int(11) NOT NULL,
  `price` int(11) NOT NULL,
  `bargainPrice` int(11) NOT NULL,
  `term` int(11) NOT NULL DEFAULT '-1',
  `flag` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=57 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of boyhaircommodity
-- ----------------------------
INSERT INTO `boyhaircommodity` VALUES ('1', '9050091', '56', '56', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('2', '9050092', '56', '56', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('3', '9050093', '56', '56', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('4', '9050094', '56', '56', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('5', '9050061', '35', '35', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('6', '9050063', '35', '35', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('7', '9050065', '35', '35', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('8', '9050067', '35', '35', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('9', '9050069', '35', '35', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('10', '9050073', '30', '30', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('11', '9050075', '30', '30', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('12', '9050077', '30', '30', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('13', '9050081', '35', '35', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('14', '9050083', '35', '35', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('15', '9050085', '35', '35', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('16', '9050087', '35', '35', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('17', '9059001', '35', '35', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('18', '9059003', '35', '35', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('19', '9050095', '35', '35', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('20', '9050097', '35', '35', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('21', '9050121', '30', '30', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('22', '9050123', '30', '30', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('23', '9050125', '30', '30', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('24', '9050127', '30', '30', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('25', '9050131', '30', '30', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('26', '9050133', '30', '30', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('27', '9050135', '30', '30', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('28', '9050137', '30', '30', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('29', '9050141', '30', '30', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('30', '9050143', '30', '30', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('31', '9050145', '30', '30', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('32', '9050147', '30', '30', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('33', '9050151', '30', '30', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('34', '9050153', '30', '30', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('35', '9050155', '30', '30', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('36', '9050157', '30', '30', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('37', '9050161', '29', '29', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('38', '9050163', '29', '29', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('39', '9050165', '29', '29', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('40', '9050167', '29', '29', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('41', '9050181', '35', '35', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('42', '9050183', '35', '35', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('43', '9050185', '35', '35', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('44', '9050187', '35', '35', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('45', '9050201', '35', '35', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('46', '9050203', '35', '35', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('47', '9050205', '35', '35', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('48', '9050207', '35', '35', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('49', '9050221', '30', '30', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('50', '9050223', '30', '30', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('51', '9050225', '30', '30', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('52', '9050227', '30', '30', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('53', '9050231', '35', '35', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('54', '9050233', '35', '35', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('55', '9050235', '35', '35', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('56', '9050237', '35', '35', '-1', '0');

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
  `avoid` int(4) NOT NULL DEFAULT '0',
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
) ENGINE=InnoDB AUTO_INCREMENT=79 DEFAULT CHARSET=latin1;

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
INSERT INTO `drop_data` VALUES ('1', '1000101', '8820011', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('2', '1000101', '8810011', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('3', '1000101', '8130011', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('4', '1000101', '8120012', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('5', '1000101', '8910011', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('6', '1000101', '8510011', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('7', '1000201', '8820011', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('8', '1000201', '8810011', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('9', '1000201', '8130012', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('10', '1000201', '8110012', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('11', '1000201', '8910021', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('12', '1000201', '8510011', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('13', '1000301', '8820011', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('14', '1000301', '8810011', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('15', '1000301', '8010011', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('16', '1000301', '8110011', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('17', '1000301', '8910031', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('18', '1000301', '8510011', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('19', '1000501', '8820011', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('20', '1000501', '8810011', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('21', '1000501', '8030011', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('22', '1000501', '8130012', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('23', '1000501', '8910051', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('24', '1000501', '8510011', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('25', '1000601', '8820011', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('26', '1000601', '8810011', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('27', '1000601', '8110011', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('28', '1000601', '8120011', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('29', '1000601', '8910061', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('30', '1000601', '8510011', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('36', '1000701', '8820011', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('37', '1000701', '8810011', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('38', '1000701', '8010011', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('39', '1000701', '8030011', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('40', '1000701', '8910071', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('41', '1000701', '8510011', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('42', '1000801', '8820011', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('43', '1000801', '8810011', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('44', '1000801', '8120011', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('45', '1000801', '8910081', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('46', '1000801', '8510011', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('47', '1001001', '8820011', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('48', '1001001', '8810011', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('49', '1001001', '8210081', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('50', '1001001', '8310081', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('51', '1001001', '8910101', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('52', '1001201', '8820011', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('53', '1001201', '8810011', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('54', '1001201', '8030101', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('55', '1001201', '8110101', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('56', '1001201', '8120101', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('57', '1001201', '8880011', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('58', '1001201', '8910121', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('59', '1001201', '8510021', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('60', '1001401', '8820011', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('61', '1001401', '8810011', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('62', '1001401', '8040101', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('63', '1001401', '8060101', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('64', '1001401', '8110102', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('65', '1001401', '8880011', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('66', '1001401', '8910141', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('67', '1001401', '8510021', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('68', '1001601', '8820011', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('69', '1001601', '8810011', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('70', '1001601', '8120102', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('71', '1001601', '8050101', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('72', '1001601', '8010101', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('73', '1001601', '8880011', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('74', '1001601', '8910161', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('75', '1001601', '8510021', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('76', '1001801', '8820011', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('77', '1001801', '8810011', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('78', '1001801', '8020101', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('79', '1001801', '8130102', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('80', '1001801', '8110101', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('81', '1001801', '8880011', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('82', '1001801', '8910181', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('83', '1001801', '8510021', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('84', '1002001', '8820021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('85', '1002001', '8810021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('86', '1002001', '8880011', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('87', '1002001', '8310161', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('88', '1002001', '8210161', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('89', '1002001', '8910201', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('90', '1002001', '8510021', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('232', '1002101', '8910211', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('233', '1002101', '8810021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('234', '1002101', '8880021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('235', '1002101', '8060201', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('236', '1002101', '8060251', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('237', '1002101', '8130201', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('238', '1002101', '8130202', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('239', '1002101', '8130151', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('240', '1002101', '8040251', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('241', '1002201', '8910221', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('242', '1002201', '8810021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('243', '1002201', '8820021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('244', '1002201', '8880021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('245', '1002201', '8020201', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('246', '1002201', '8020251', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('247', '1002201', '8120202', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('248', '1002201', '8120251', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('249', '1002401', '8910241', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('250', '1002401', '8810021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('251', '1002401', '8820021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('252', '1002401', '8880021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('253', '1002401', '8110201', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('254', '1002401', '8040251', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('255', '1002401', '8030251', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('256', '1002601', '8910261', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('257', '1002601', '8910261', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('258', '1002601', '8910261', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('259', '1002601', '8880021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('260', '1002601', '8310241', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('261', '1002601', '8120201', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('262', '1002601', '8120252', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('263', '1002601', '8110251', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('264', '1002601', '8110252', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('265', '1002601', '8010201', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('266', '1002601', '8010251', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('267', '1002801', '8910281', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('268', '1002801', '8810021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('269', '1002801', '8820021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('270', '1002801', '8880021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('271', '1002801', '8210241', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('272', '1002801', '8130202', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('273', '1002801', '8110202', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('274', '1002801', '8110251', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('275', '1002801', '8050201', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('276', '1002801', '8050251', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('277', '1003001', '8910301', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('278', '1003001', '8810021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('279', '1003001', '8820021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('280', '1003001', '8880021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('281', '1003001', '8310321', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('282', '1003001', '8210321', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('283', '1003201', '8910321', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('284', '1003201', '8810021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('285', '1003201', '8820021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('286', '1003201', '8510061', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('287', '1003201', '8130301', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('288', '1003201', '8110351', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('289', '1003201', '8050301', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('290', '1003201', '8010351', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('291', '1003401', '8910341', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('292', '1003401', '8810021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('293', '1003401', '8820021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('294', '1003401', '8120302', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('295', '1003401', '8040301', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('296', '1003401', '8020351', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('297', '1003401', '8020301', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('298', '1003401', '8020351', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('299', '1003501', '8810021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('300', '1003501', '8820021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('301', '1003501', '8880031', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('302', '1003501', '8130302', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('303', '1003501', '8110302', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('304', '1003501', '8120352', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('305', '1003501', '8110352', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('306', '1003501', '8020301', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('307', '1003601', '8710173', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('308', '1003601', '8810021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('309', '1003601', '8820021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('310', '1003601', '8880031', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('311', '1003601', '8130301', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('312', '1003601', '8120301', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('313', '1003601', '8050301', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('314', '1003601', '8060351', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('315', '1003701', '8810021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('316', '1003701', '8820021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('317', '1003701', '8880031', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('318', '1003701', '8110302', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('319', '1003701', '8130301', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('320', '1003701', '8120301', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('321', '1003701', '8050301', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('322', '1003701', '8030351', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('323', '1003701', '8040301', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('324', '1003701', '8040351', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('325', '1003801', '8910381', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('326', '1003801', '8810021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('327', '1003801', '8820021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('328', '1003801', '8880031', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('329', '1003801', '8130302', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('330', '1003801', '8110301', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('331', '1003801', '8020301', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('332', '1003801', '8040351', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('333', '1003901', '8910391', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('334', '1003901', '8810021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('335', '1003901', '8820021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('336', '1003901', '8130302', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('337', '1003901', '8110301', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('338', '1003901', '8120352', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('339', '1003901', '8130352', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('340', '1003901', '8010301', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('341', '1004001', '8910401', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('342', '1004001', '8810021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('343', '1004001', '8820021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('344', '1004001', '8210401', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('345', '1004001', '8310401', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('346', '1004301', '8810021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('347', '1004301', '8820021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('348', '1004301', '8050351', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('349', '1004301', '8130401', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('350', '1004301', '8910431', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('351', '1004401', '8910441', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('352', '1004401', '8810021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('353', '1004401', '8820031', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('354', '1004401', '8020401', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('355', '1004401', '8030401', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('356', '1004501', '8110401', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('357', '1004501', '8120402', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('358', '1004601', '8910391', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('359', '1004601', '8820031', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('360', '1004601', '8010401', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('361', '1004601', '8110401', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('362', '1004601', '8050351', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('363', '1004801', '8910481', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('364', '1004801', '8120402', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('365', '1004801', '8060401', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('366', '1004801', '8030401', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('367', '1004901', '8910491', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('368', '1004901', '8130402', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('369', '1004901', '8130401', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('370', '1004901', '8030401', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('371', '1005001', '8910501', '1', '1', '0', '300000');
INSERT INTO `drop_data` VALUES ('372', '1005001', '8310402', '1', '1', '0', '10000');

-- ----------------------------
-- Table structure for `face1commodity`
-- ----------------------------
DROP TABLE IF EXISTS `face1commodity`;
CREATE TABLE `face1commodity` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `itemID` int(11) NOT NULL,
  `price` int(11) NOT NULL,
  `bargainPrice` int(11) NOT NULL,
  `term` int(11) NOT NULL DEFAULT '-1',
  `flag` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=59 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of face1commodity
-- ----------------------------
INSERT INTO `face1commodity` VALUES ('1', '8710013', '29', '29', '-1', '0');
INSERT INTO `face1commodity` VALUES ('2', '8710023', '55', '55', '-1', '0');
INSERT INTO `face1commodity` VALUES ('3', '8710123', '25', '25', '-1', '0');
INSERT INTO `face1commodity` VALUES ('4', '8710133', '25', '25', '-1', '0');
INSERT INTO `face1commodity` VALUES ('5', '8710183', '29', '29', '-1', '0');
INSERT INTO `face1commodity` VALUES ('6', '8710233', '40', '40', '-1', '0');
INSERT INTO `face1commodity` VALUES ('7', '8710243', '40', '40', '-1', '0');
INSERT INTO `face1commodity` VALUES ('8', '8710253', '40', '40', '-1', '0');
INSERT INTO `face1commodity` VALUES ('9', '8710263', '40', '40', '-1', '0');
INSERT INTO `face1commodity` VALUES ('10', '8710273', '40', '40', '-1', '0');
INSERT INTO `face1commodity` VALUES ('11', '8710283', '40', '40', '-1', '0');
INSERT INTO `face1commodity` VALUES ('12', '8710293', '40', '40', '-1', '0');
INSERT INTO `face1commodity` VALUES ('13', '8710303', '40', '40', '-1', '0');
INSERT INTO `face1commodity` VALUES ('14', '8710313', '40', '40', '-1', '0');
INSERT INTO `face1commodity` VALUES ('15', '8710323', '40', '40', '-1', '0');
INSERT INTO `face1commodity` VALUES ('16', '8710333', '40', '40', '-1', '0');
INSERT INTO `face1commodity` VALUES ('17', '8710343', '40', '40', '-1', '0');
INSERT INTO `face1commodity` VALUES ('18', '8710353', '40', '40', '-1', '0');
INSERT INTO `face1commodity` VALUES ('19', '8710363', '40', '40', '-1', '0');
INSERT INTO `face1commodity` VALUES ('20', '8710373', '40', '40', '-1', '0');
INSERT INTO `face1commodity` VALUES ('21', '8710223', '29', '29', '-1', '0');
INSERT INTO `face1commodity` VALUES ('22', '8710383', '25', '25', '-1', '0');
INSERT INTO `face1commodity` VALUES ('23', '8710393', '25', '25', '-1', '0');
INSERT INTO `face1commodity` VALUES ('24', '8710403', '25', '25', '-1', '0');
INSERT INTO `face1commodity` VALUES ('25', '8710413', '25', '25', '-1', '0');
INSERT INTO `face1commodity` VALUES ('26', '8710423', '35', '35', '-1', '0');
INSERT INTO `face1commodity` VALUES ('27', '8710433', '35', '35', '-1', '0');
INSERT INTO `face1commodity` VALUES ('28', '8710443', '35', '35', '-1', '0');
INSERT INTO `face1commodity` VALUES ('29', '8710453', '35', '35', '-1', '0');
INSERT INTO `face1commodity` VALUES ('30', '8710463', '35', '35', '-1', '0');
INSERT INTO `face1commodity` VALUES ('31', '8710473', '35', '35', '-1', '0');
INSERT INTO `face1commodity` VALUES ('32', '8710483', '40', '40', '-1', '0');
INSERT INTO `face1commodity` VALUES ('33', '8710493', '40', '40', '-1', '0');
INSERT INTO `face1commodity` VALUES ('34', '8710503', '40', '40', '-1', '0');
INSERT INTO `face1commodity` VALUES ('35', '8710513', '40', '40', '-1', '0');
INSERT INTO `face1commodity` VALUES ('36', '8710523', '40', '40', '-1', '0');
INSERT INTO `face1commodity` VALUES ('37', '8710573', '40', '40', '-1', '0');
INSERT INTO `face1commodity` VALUES ('38', '8710583', '40', '40', '-1', '0');
INSERT INTO `face1commodity` VALUES ('39', '8710593', '40', '40', '-1', '0');
INSERT INTO `face1commodity` VALUES ('40', '8710603', '40', '40', '-1', '0');
INSERT INTO `face1commodity` VALUES ('41', '8710613', '40', '40', '-1', '0');
INSERT INTO `face1commodity` VALUES ('42', '8710533', '29', '29', '-1', '0');
INSERT INTO `face1commodity` VALUES ('43', '8710543', '29', '29', '-1', '0');
INSERT INTO `face1commodity` VALUES ('44', '8710553', '29', '29', '-1', '0');
INSERT INTO `face1commodity` VALUES ('45', '8710563', '29', '29', '-1', '0');
INSERT INTO `face1commodity` VALUES ('46', '8710623', '40', '40', '-1', '0');
INSERT INTO `face1commodity` VALUES ('47', '8710633', '40', '40', '-1', '0');
INSERT INTO `face1commodity` VALUES ('48', '8710643', '40', '40', '-1', '0');
INSERT INTO `face1commodity` VALUES ('49', '8710653', '40', '40', '-1', '0');
INSERT INTO `face1commodity` VALUES ('50', '8710703', '35', '35', '-1', '0');
INSERT INTO `face1commodity` VALUES ('51', '8710713', '35', '35', '-1', '0');
INSERT INTO `face1commodity` VALUES ('52', '8710723', '35', '35', '-1', '0');
INSERT INTO `face1commodity` VALUES ('53', '8710733', '35', '35', '-1', '0');
INSERT INTO `face1commodity` VALUES ('54', '8710663', '40', '40', '-1', '0');
INSERT INTO `face1commodity` VALUES ('55', '8710673', '40', '40', '-1', '0');
INSERT INTO `face1commodity` VALUES ('56', '8710683', '40', '40', '-1', '0');
INSERT INTO `face1commodity` VALUES ('57', '8710693', '40', '40', '-1', '0');
INSERT INTO `face1commodity` VALUES ('58', '8710763', '29', '29', '-1', '0');

-- ----------------------------
-- Table structure for `face2commodity`
-- ----------------------------
DROP TABLE IF EXISTS `face2commodity`;
CREATE TABLE `face2commodity` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `itemID` int(11) NOT NULL,
  `price` int(11) NOT NULL,
  `bargainPrice` int(11) NOT NULL,
  `term` int(11) NOT NULL DEFAULT '-1',
  `flag` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=49 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of face2commodity
-- ----------------------------
INSERT INTO `face2commodity` VALUES ('1', '9410011', '29', '29', '-1', '0');
INSERT INTO `face2commodity` VALUES ('2', '9410021', '29', '29', '-1', '0');
INSERT INTO `face2commodity` VALUES ('3', '9410053', '30', '30', '-1', '0');
INSERT INTO `face2commodity` VALUES ('4', '9410063', '26', '26', '-1', '0');
INSERT INTO `face2commodity` VALUES ('5', '9410023', '45', '45', '-1', '0');
INSERT INTO `face2commodity` VALUES ('6', '9410143', '45', '45', '-1', '0');
INSERT INTO `face2commodity` VALUES ('7', '9410153', '100', '100', '-1', '0');
INSERT INTO `face2commodity` VALUES ('8', '9410163', '20', '20', '-1', '0');
INSERT INTO `face2commodity` VALUES ('9', '9410173', '40', '40', '-1', '0');
INSERT INTO `face2commodity` VALUES ('10', '9410183', '45', '45', '-1', '0');
INSERT INTO `face2commodity` VALUES ('11', '9410193', '45', '45', '-1', '0');
INSERT INTO `face2commodity` VALUES ('12', '9410203', '45', '45', '-1', '0');
INSERT INTO `face2commodity` VALUES ('13', '9410223', '39', '39', '-1', '0');
INSERT INTO `face2commodity` VALUES ('14', '9410213', '45', '45', '-1', '0');
INSERT INTO `face2commodity` VALUES ('15', '9410233', '45', '45', '-1', '0');
INSERT INTO `face2commodity` VALUES ('16', '9410243', '45', '45', '-1', '0');
INSERT INTO `face2commodity` VALUES ('17', '9410253', '45', '45', '-1', '0');
INSERT INTO `face2commodity` VALUES ('18', '9410263', '45', '45', '-1', '0');
INSERT INTO `face2commodity` VALUES ('19', '9410353', '45', '45', '-1', '0');
INSERT INTO `face2commodity` VALUES ('20', '9410363', '45', '45', '-1', '0');
INSERT INTO `face2commodity` VALUES ('21', '9410373', '45', '45', '-1', '0');
INSERT INTO `face2commodity` VALUES ('22', '9410383', '45', '45', '-1', '0');
INSERT INTO `face2commodity` VALUES ('23', '9410273', '45', '45', '-1', '0');
INSERT INTO `face2commodity` VALUES ('24', '9410283', '45', '45', '-1', '0');
INSERT INTO `face2commodity` VALUES ('25', '9410293', '45', '45', '-1', '0');
INSERT INTO `face2commodity` VALUES ('26', '9410313', '45', '45', '-1', '0');
INSERT INTO `face2commodity` VALUES ('27', '9410323', '45', '45', '-1', '0');
INSERT INTO `face2commodity` VALUES ('28', '9410333', '45', '45', '-1', '0');
INSERT INTO `face2commodity` VALUES ('29', '9410343', '45', '45', '-1', '0');
INSERT INTO `face2commodity` VALUES ('30', '9410473', '45', '45', '-1', '0');
INSERT INTO `face2commodity` VALUES ('31', '9410483', '45', '45', '-1', '0');
INSERT INTO `face2commodity` VALUES ('32', '9410493', '45', '45', '-1', '0');
INSERT INTO `face2commodity` VALUES ('33', '9410503', '45', '45', '-1', '0');
INSERT INTO `face2commodity` VALUES ('34', '9410513', '45', '45', '-1', '0');
INSERT INTO `face2commodity` VALUES ('35', '9410523', '45', '45', '-1', '0');
INSERT INTO `face2commodity` VALUES ('36', '9410533', '45', '45', '-1', '0');
INSERT INTO `face2commodity` VALUES ('37', '9410543', '45', '45', '-1', '0');
INSERT INTO `face2commodity` VALUES ('38', '9410433', '39', '39', '-1', '0');
INSERT INTO `face2commodity` VALUES ('39', '9410443', '39', '39', '-1', '0');
INSERT INTO `face2commodity` VALUES ('40', '9410453', '39', '39', '-1', '0');
INSERT INTO `face2commodity` VALUES ('41', '9410463', '39', '39', '-1', '0');
INSERT INTO `face2commodity` VALUES ('42', '9410553', '45', '45', '-1', '0');
INSERT INTO `face2commodity` VALUES ('43', '9410563', '45', '45', '-1', '0');
INSERT INTO `face2commodity` VALUES ('44', '9410393', '45', '45', '-1', '0');
INSERT INTO `face2commodity` VALUES ('45', '9410403', '45', '45', '-1', '0');
INSERT INTO `face2commodity` VALUES ('46', '9410413', '45', '45', '-1', '0');
INSERT INTO `face2commodity` VALUES ('47', '9410423', '45', '45', '-1', '0');
INSERT INTO `face2commodity` VALUES ('48', '9410573', '45', '45', '-1', '0');

-- ----------------------------
-- Table structure for `gifts`
-- ----------------------------
DROP TABLE IF EXISTS `gifts`;
CREATE TABLE `gifts` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(20) CHARACTER SET big5 NOT NULL,
  `itemID` int(11) NOT NULL,
  `itemName` varchar(62) CHARACTER SET big5 NOT NULL,
  `receive` int(1) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of gifts
-- ----------------------------

-- ----------------------------
-- Table structure for `girldresscommodity`
-- ----------------------------
DROP TABLE IF EXISTS `girldresscommodity`;
CREATE TABLE `girldresscommodity` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `itemID` int(11) NOT NULL,
  `price` int(11) NOT NULL,
  `bargainPrice` int(11) NOT NULL,
  `term` int(11) NOT NULL DEFAULT '-1',
  `flag` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=201 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of girldresscommodity
-- ----------------------------
INSERT INTO `girldresscommodity` VALUES ('1', '9510032', '120', '120', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('2', '9510022', '125', '125', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('3', '9510042', '140', '140', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('4', '9510034', '120', '120', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('5', '9510036', '120', '120', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('6', '9510024', '125', '125', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('7', '9510026', '125', '125', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('8', '9510044', '140', '140', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('9', '9510046', '140', '140', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('10', '9510052', '115', '115', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('11', '9510054', '115', '115', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('12', '9510056', '115', '115', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('13', '9510142', '130', '130', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('14', '9510144', '130', '130', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('15', '9510146', '130', '130', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('16', '9510148', '130', '130', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('17', '9510152', '130', '130', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('18', '9510154', '130', '130', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('19', '9510156', '130', '130', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('20', '9510172', '130', '130', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('21', '9510174', '130', '130', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('22', '9510176', '130', '130', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('23', '9510162', '120', '120', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('24', '9510164', '120', '120', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('25', '9510166', '120', '120', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('26', '9510192', '115', '115', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('27', '9510194', '115', '115', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('28', '9510196', '115', '115', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('29', '9510252', '130', '130', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('30', '9510254', '130', '130', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('31', '9510256', '130', '130', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('32', '9510258', '130', '130', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('33', '9510182', '115', '115', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('34', '9510184', '115', '115', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('35', '9510186', '115', '115', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('36', '9510202', '130', '130', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('37', '9510204', '130', '130', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('38', '9510206', '130', '130', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('39', '9510212', '130', '130', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('40', '9510214', '130', '130', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('41', '9510216', '130', '130', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('42', '9510242', '115', '115', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('43', '9510244', '115', '115', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('44', '9510246', '115', '115', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('45', '9510248', '115', '115', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('46', '9510222', '105', '105', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('47', '9510224', '105', '105', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('48', '9510226', '105', '105', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('49', '9510232', '105', '105', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('50', '9510234', '105', '105', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('51', '9510236', '105', '105', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('52', '9510238', '105', '105', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('53', '9510262', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('54', '9510264', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('55', '9510266', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('56', '9510268', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('57', '9510392', '90', '90', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('58', '9510394', '90', '90', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('59', '9510396', '90', '90', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('60', '9510398', '90', '90', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('61', '9510402', '90', '90', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('62', '9510404', '90', '90', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('63', '9510406', '90', '90', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('64', '9510408', '90', '90', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('65', '9510272', '90', '90', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('66', '9510282', '90', '90', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('67', '9510284', '90', '90', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('68', '9510286', '90', '90', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('69', '9510292', '130', '130', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('70', '9510302', '130', '130', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('71', '9510304', '130', '130', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('72', '9510306', '130', '130', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('73', '9510308', '130', '130', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('74', '9510312', '130', '130', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('75', '9510314', '130', '130', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('76', '9510316', '130', '130', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('77', '9510318', '130', '130', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('78', '9510322', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('79', '9510324', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('80', '9510326', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('81', '9510328', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('82', '9510342', '130', '130', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('83', '9510344', '130', '130', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('84', '9510346', '130', '130', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('85', '9510348', '130', '130', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('86', '9510332', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('87', '9510334', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('88', '9510336', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('89', '9510382', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('90', '9510384', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('91', '9510386', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('92', '9510388', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('93', '9510362', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('94', '9510364', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('95', '9510366', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('96', '9510368', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('97', '9510422', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('98', '9510424', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('99', '9510426', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('100', '9510428', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('101', '9510442', '105', '105', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('102', '9510444', '105', '105', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('103', '9510446', '105', '105', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('104', '9510448', '105', '105', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('105', '9510412', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('106', '9510414', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('107', '9510416', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('108', '9510418', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('109', '9510432', '105', '105', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('110', '9510436', '105', '105', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('111', '9510438', '105', '105', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('112', '9510434', '105', '105', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('113', '9510372', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('114', '9510374', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('115', '9510376', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('116', '9510378', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('117', '9510352', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('118', '9510354', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('119', '9510356', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('120', '9510358', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('121', '9510452', '105', '105', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('122', '9510454', '105', '105', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('123', '9510456', '105', '105', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('124', '9510458', '105', '105', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('125', '9510462', '105', '105', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('126', '9510464', '105', '105', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('127', '9510466', '105', '105', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('128', '9510468', '105', '105', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('129', '9510472', '105', '105', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('130', '9510474', '105', '105', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('131', '9510476', '105', '105', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('132', '9510478', '105', '105', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('133', '9510492', '105', '105', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('134', '9510494', '105', '105', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('135', '9510496', '105', '105', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('136', '9510498', '105', '105', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('137', '9510502', '125', '125', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('138', '9510504', '125', '125', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('139', '9510506', '125', '125', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('140', '9510508', '125', '125', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('141', '9510542', '90', '90', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('142', '9510544', '90', '90', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('143', '9510546', '90', '90', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('144', '9510548', '90', '90', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('145', '9510552', '90', '90', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('146', '9510554', '90', '90', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('147', '9510556', '90', '90', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('148', '9510558', '90', '90', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('149', '9510572', '90', '90', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('150', '9510574', '90', '90', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('151', '9510576', '90', '90', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('152', '9510578', '90', '90', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('153', '9510582', '130', '130', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('154', '9510584', '130', '130', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('155', '9510586', '130', '130', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('156', '9510588', '130', '130', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('157', '9510672', '90', '90', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('158', '9510674', '90', '90', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('159', '9510676', '90', '90', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('160', '9510678', '90', '90', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('161', '9510662', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('162', '9510664', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('163', '9510666', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('164', '9510668', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('165', '9510682', '90', '90', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('166', '9510684', '90', '90', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('167', '9510686', '90', '90', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('168', '9510688', '90', '90', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('169', '9510702', '130', '130', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('170', '9510692', '105', '105', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('171', '9510694', '105', '105', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('172', '9510696', '105', '105', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('173', '9510698', '105', '105', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('174', '9510602', '130', '130', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('175', '9510604', '130', '130', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('176', '9510606', '130', '130', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('177', '9510608', '130', '130', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('178', '9510592', '130', '130', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('179', '9510594', '130', '130', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('180', '9510596', '130', '130', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('181', '9510598', '130', '130', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('182', '9510622', '130', '130', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('183', '9510624', '130', '130', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('184', '9510626', '130', '130', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('185', '9510628', '130', '130', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('186', '9510722', '105', '105', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('187', '9510724', '105', '105', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('188', '9510802', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('189', '9510804', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('190', '9510806', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('191', '9510808', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('192', '9510782', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('193', '9510784', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('194', '9510786', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('195', '9510788', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('196', '9510792', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('197', '9510794', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('198', '9510796', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('199', '9510798', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('200', '9510772', '105', '105', '-1', '0');

-- ----------------------------
-- Table structure for `girleyescommodity`
-- ----------------------------
DROP TABLE IF EXISTS `girleyescommodity`;
CREATE TABLE `girleyescommodity` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `itemID` int(11) NOT NULL,
  `price` int(11) NOT NULL,
  `bargainPrice` int(11) NOT NULL,
  `term` int(11) NOT NULL DEFAULT '-1',
  `flag` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of girleyescommodity
-- ----------------------------
INSERT INTO `girleyescommodity` VALUES ('1', '9150082', '30', '30', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('2', '9150092', '30', '30', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('3', '9150102', '30', '30', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('4', '9150112', '30', '30', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('5', '9150142', '25', '25', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('6', '9150152', '25', '25', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('7', '9150162', '25', '25', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('8', '9150172', '25', '25', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('9', '9150182', '25', '25', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('10', '9150192', '25', '25', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('11', '9150202', '25', '25', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('12', '9150352', '30', '30', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('13', '9150362', '30', '30', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('14', '9150372', '30', '30', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('15', '9150382', '30', '30', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('16', '9150392', '25', '25', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('17', '9150402', '25', '25', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('18', '9150412', '25', '25', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('19', '9150422', '25', '25', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('20', '9150472', '25', '25', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('21', '9150482', '25', '25', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('22', '9150492', '25', '25', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('23', '9150502', '25', '25', '-1', '0');

-- ----------------------------
-- Table structure for `girlhaircommodity`
-- ----------------------------
DROP TABLE IF EXISTS `girlhaircommodity`;
CREATE TABLE `girlhaircommodity` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `itemID` int(11) NOT NULL,
  `price` int(11) NOT NULL,
  `bargainPrice` int(11) NOT NULL,
  `term` int(11) NOT NULL DEFAULT '-1',
  `flag` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=62 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of girlhaircommodity
-- ----------------------------
INSERT INTO `girlhaircommodity` VALUES ('1', '9050072', '35', '35', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('2', '9050076', '35', '35', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('3', '9050074', '35', '35', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('4', '9050078', '35', '35', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('5', '9050058', '35', '35', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('6', '9050082', '35', '35', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('7', '9050084', '35', '35', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('8', '9050086', '35', '35', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('9', '9050088', '35', '35', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('10', '9050096', '35', '35', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('11', '9050098', '35', '35', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('12', '9059002', '35', '35', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('13', '9059004', '35', '35', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('14', '9050110', '35', '35', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('15', '9050120', '35', '35', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('16', '9050130', '35', '35', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('17', '9050140', '35', '35', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('18', '9050102', '30', '30', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('19', '9050104', '30', '30', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('20', '9050106', '30', '30', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('21', '9050108', '30', '30', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('22', '9050112', '30', '30', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('23', '9050114', '30', '30', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('24', '9050116', '30', '30', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('25', '9050118', '30', '30', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('26', '9050122', '30', '30', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('27', '9050124', '30', '30', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('28', '9050126', '30', '30', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('29', '9050128', '30', '30', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('30', '9050132', '30', '30', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('31', '9050134', '30', '30', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('32', '9050136', '30', '30', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('33', '9050138', '30', '30', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('34', '9050142', '29', '29', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('35', '9050144', '29', '29', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('36', '9050146', '29', '29', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('37', '9050148', '29', '29', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('38', '9050172', '35', '35', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('39', '9050174', '35', '35', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('40', '9050176', '35', '35', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('41', '9050178', '35', '35', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('42', '9050192', '35', '35', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('43', '9050194', '35', '35', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('44', '9050196', '35', '35', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('45', '9050198', '35', '35', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('46', '9050182', '35', '35', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('47', '9050184', '35', '35', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('48', '9050186', '35', '35', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('49', '9050188', '35', '35', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('50', '9050222', '30', '30', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('51', '9050224', '30', '30', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('52', '9050226', '30', '30', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('53', '9050228', '30', '30', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('54', '9050232', '35', '35', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('55', '9050234', '35', '35', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('56', '9050236', '35', '35', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('57', '9050238', '35', '35', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('58', '9050242', '35', '35', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('59', '9050244', '35', '35', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('60', '9050246', '35', '35', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('61', '9050248', '35', '35', '-1', '0');

-- ----------------------------
-- Table structure for `hatcommodity`
-- ----------------------------
DROP TABLE IF EXISTS `hatcommodity`;
CREATE TABLE `hatcommodity` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `itemID` int(11) NOT NULL,
  `price` int(11) NOT NULL,
  `bargainPrice` int(11) NOT NULL,
  `term` int(11) NOT NULL DEFAULT '-1',
  `flag` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=220 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of hatcommodity
-- ----------------------------
INSERT INTO `hatcommodity` VALUES ('1', '8610011', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('2', '8610012', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('3', '8610013', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('4', '8610021', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('5', '8610022', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('6', '8610023', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('7', '8610031', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('8', '8610032', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('9', '8610033', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('10', '8610041', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('11', '8610042', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('12', '8610043', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('13', '8610051', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('14', '8610052', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('15', '8610053', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('16', '8610061', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('17', '8610062', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('18', '8610063', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('19', '8610064', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('20', '8610071', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('21', '8610072', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('22', '8610073', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('23', '8610074', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('24', '8610081', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('25', '8610082', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('26', '8610083', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('27', '8610084', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('28', '8610091', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('29', '8610092', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('30', '8610101', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('31', '8610102', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('32', '8610103', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('33', '8610104', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('34', '8610105', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('35', '8610111', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('36', '8610112', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('37', '8610121', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('38', '8610122', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('39', '8610123', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('40', '8610125', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('41', '8610127', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('42', '8610124', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('43', '8610126', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('44', '8610128', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('45', '8610151', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('46', '8610152', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('47', '8610153', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('48', '8610154', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('49', '8610161', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('50', '8610162', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('51', '8610163', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('52', '8610164', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('53', '8610131', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('54', '8610133', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('55', '8610135', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('56', '8610137', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('57', '8610132', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('58', '8610134', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('59', '8610136', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('60', '8610138', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('61', '8610142', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('62', '8610144', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('63', '8610146', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('64', '8610148', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('65', '8610171', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('66', '8610173', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('67', '8610172', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('68', '8610174', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('69', '8610176', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('70', '8610178', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('71', '8610181', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('72', '8610182', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('73', '8610183', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('74', '8610184', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('75', '8610191', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('76', '8610192', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('77', '8610193', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('78', '8610201', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('79', '8610202', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('80', '8610203', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('81', '8610204', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('82', '8610231', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('83', '8610233', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('84', '8610235', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('85', '8610237', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('86', '8610211', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('87', '8610212', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('88', '8610213', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('89', '8610214', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('90', '8610241', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('91', '8610243', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('92', '8610245', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('93', '8610247', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('94', '8610242', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('95', '8610244', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('96', '8610246', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('97', '8610248', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('98', '8610271', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('99', '8610272', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('100', '8610273', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('101', '8610274', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('102', '8610261', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('103', '8610262', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('104', '8610263', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('105', '8610264', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('106', '8610251', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('107', '8610252', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('108', '8610253', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('109', '8610254', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('110', '8610221', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('111', '8610222', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('112', '8610223', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('113', '8610224', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('114', '8610291', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('115', '8610292', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('116', '8610293', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('117', '8610294', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('118', '8610281', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('119', '8610282', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('120', '8610283', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('121', '8610284', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('122', '8610301', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('123', '8610302', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('124', '8610303', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('125', '8610304', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('126', '8610311', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('127', '8610312', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('128', '8610313', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('129', '8610314', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('130', '8610205', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('131', '8610401', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('132', '8610402', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('133', '8610403', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('134', '8610404', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('135', '8610405', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('136', '8610406', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('137', '8610407', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('138', '8610408', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('139', '8611001', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('140', '8611002', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('141', '8610351', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('142', '8610352', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('143', '8610411', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('144', '8610412', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('145', '8610413', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('146', '8610414', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('147', '8610371', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('148', '8610372', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('149', '8610373', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('150', '8610374', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('151', '8610375', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('152', '8610376', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('153', '8610377', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('154', '8610378', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('155', '8610321', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('156', '8610322', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('157', '8610323', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('158', '8610324', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('159', '8610361', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('160', '8610363', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('161', '8610365', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('162', '8610367', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('163', '8610331', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('164', '8610332', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('165', '8610333', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('166', '8610334', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('167', '8610341', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('168', '8610421', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('169', '8610422', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('170', '8610423', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('171', '8610424', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('172', '8610473', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('173', '8610474', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('174', '8610381', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('175', '8610382', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('176', '8610383', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('177', '8610384', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('178', '8610451', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('179', '8610453', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('180', '8610455', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('181', '8610457', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('182', '8610452', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('183', '8610454', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('184', '8610456', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('185', '8610458', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('186', '8610385', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('187', '8610386', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('188', '8610387', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('189', '8610388', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('190', '8610461', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('191', '8610462', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('192', '8610463', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('193', '8610464', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('194', '8610471', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('195', '8610472', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('196', '8610481', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('197', '8610482', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('198', '8610633', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('199', '8610631', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('200', '8610635', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('201', '8610637', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('202', '8610632', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('203', '8610634', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('204', '8610636', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('205', '8610638', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('206', '8610601', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('207', '8610603', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('208', '8610605', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('209', '8610607', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('210', '8610602', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('211', '8610604', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('212', '8610606', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('213', '8610608', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('214', '8610611', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('215', '8610612', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('216', '8610613', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('217', '8610614', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('218', '8610501', '50', '50', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('219', '8610502', '50', '50', '-1', '0');

-- ----------------------------
-- Table structure for `items`
-- ----------------------------
DROP TABLE IF EXISTS `items`;
CREATE TABLE `items` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `cid` int(11) NOT NULL,
  `itemId` int(8) NOT NULL,
  `quantity` int(3) NOT NULL,
  `spirit` int(11) NOT NULL,
  `isLocked` int(1) NOT NULL,
  `icon` int(11) NOT NULL,
  `term` int(11) NOT NULL DEFAULT '-1',
  `type` int(3) NOT NULL,
  `slot` int(3) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=1008 DEFAULT CHARSET=latin1;

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
-- Table structure for `mantlecommodity`
-- ----------------------------
DROP TABLE IF EXISTS `mantlecommodity`;
CREATE TABLE `mantlecommodity` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `itemID` int(11) NOT NULL,
  `price` int(11) NOT NULL,
  `bargainPrice` int(11) NOT NULL,
  `term` int(11) NOT NULL DEFAULT '-1',
  `flag` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=124 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of mantlecommodity
-- ----------------------------
INSERT INTO `mantlecommodity` VALUES ('1', '8493041', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('2', '8493042', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('3', '8493043', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('4', '8493052', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('5', '8493081', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('6', '8493082', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('7', '8493083', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('8', '8493084', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('9', '8493085', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('10', '8493086', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('11', '8493087', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('12', '8493088', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('13', '8493089', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('14', '8493061', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('15', '8493062', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('16', '8493063', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('17', '8493071', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('18', '8493072', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('19', '8493073', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('20', '8493090', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('21', '8493091', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('22', '8493092', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('23', '8493093', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('24', '8493094', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('25', '8493101', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('26', '8493102', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('27', '8493111', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('28', '8493112', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('29', '8493113', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('30', '8493114', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('31', '8493121', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('32', '8493122', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('33', '8493051', '80', '80', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('34', '8493151', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('35', '8493152', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('36', '8493153', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('37', '8493154', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('38', '8493161', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('39', '8493162', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('40', '8493163', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('41', '8493164', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('42', '8493141', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('43', '8493142', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('44', '8493143', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('45', '8493144', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('46', '8493131', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('47', '8493132', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('48', '8493133', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('49', '8493134', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('50', '8493171', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('51', '8493181', '99', '99', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('52', '8493194', '299', '299', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('53', '8493191', '299', '299', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('54', '8493192', '299', '299', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('55', '8493193', '299', '299', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('56', '8493231', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('57', '8493232', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('58', '8493233', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('59', '8493261', '99', '99', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('60', '8493262', '99', '99', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('61', '8493263', '99', '99', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('62', '8493264', '99', '99', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('63', '8493271', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('64', '8493272', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('65', '8493273', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('66', '8493274', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('67', '8493291', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('68', '8493292', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('69', '8493293', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('70', '8493294', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('71', '8493281', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('72', '8493282', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('73', '8493283', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('74', '8493284', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('75', '8493301', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('76', '8493302', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('77', '8493303', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('78', '8493304', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('79', '8493501', '1', '1', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('80', '8493401', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('81', '8493402', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('82', '8493403', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('83', '8493404', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('84', '8493405', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('85', '8493406', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('86', '8493502', '1', '1', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('87', '8493503', '1', '1', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('88', '8493505', '1', '1', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('89', '8493506', '1', '1', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('90', '8493507', '1', '1', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('91', '8493508', '1', '1', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('92', '8493509', '1', '1', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('93', '8493361', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('94', '8493362', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('95', '8493363', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('96', '8493364', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('97', '8493341', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('98', '8493342', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('99', '8493343', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('100', '8493344', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('101', '8493351', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('102', '8493352', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('103', '8493353', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('104', '8493354', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('105', '8493422', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('106', '8493423', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('107', '8493431', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('108', '8493451', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('109', '8493371', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('110', '8493391', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('111', '8493450', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('112', '8493413', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('113', '8493411', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('114', '8493412', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('115', '8493331', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('116', '8493332', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('117', '8493333', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('118', '8493334', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('119', '8493421', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('120', '8493441', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('121', '8493442', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('122', '8493414', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('123', '8493415', '88', '88', '-1', '0');

-- ----------------------------
-- Table structure for `petcommodity`
-- ----------------------------
DROP TABLE IF EXISTS `petcommodity`;
CREATE TABLE `petcommodity` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `itemID` int(11) NOT NULL,
  `price` int(11) NOT NULL,
  `bargainPrice` int(11) NOT NULL,
  `term` int(11) NOT NULL DEFAULT '-1',
  `flag` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of petcommodity
-- ----------------------------
INSERT INTO `petcommodity` VALUES ('1', '9212011', '120', '120', '-1', '0');

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
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;

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
  `stage` int(3) NOT NULL,
  `requireMonster` int(11) NOT NULL,
  `completeMonster` int(11) NOT NULL,
  `questState` int(3) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=latin1;

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
) ENGINE=InnoDB AUTO_INCREMENT=354 DEFAULT CHARSET=latin1;

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
) ENGINE=InnoDB AUTO_INCREMENT=268 DEFAULT CHARSET=latin1;

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
) ENGINE=InnoDB AUTO_INCREMENT=1040 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of useslot
-- ----------------------------
