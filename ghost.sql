/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50617
Source Host           : localhost:3306
Source Database       : ghost3

Target Server Type    : MYSQL
Target Server Version : 50617
File Encoding         : 65001

Date: 2019-04-30 04:18:09
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
  `total_donate` int(8) NOT NULL,
  `VIP` int(1) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of accounts
-- ----------------------------
INSERT INTO `accounts` VALUES ('1', 'admin', '123456', '0001-01-01 00:00:00', '0', '0', '1', '27935', '0', '0', '0', '0');

-- ----------------------------
-- Table structure for `amuletcommodity`
-- ----------------------------
DROP TABLE IF EXISTS `amuletcommodity`;
CREATE TABLE `amuletcommodity` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `itemID` int(11) NOT NULL,
  `price` int(11) NOT NULL,
  `bargainPrice` int(11) NOT NULL,
  `term` int(11) NOT NULL DEFAULT '-1',
  `flag` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of amuletcommodity
-- ----------------------------
INSERT INTO `amuletcommodity` VALUES ('1', '8841001', '99', '99', '-1', '0');
INSERT INTO `amuletcommodity` VALUES ('2', '8841002', '99', '99', '-1', '0');
INSERT INTO `amuletcommodity` VALUES ('3', '8841003', '99', '99', '-1', '0');
INSERT INTO `amuletcommodity` VALUES ('4', '8841004', '99', '99', '-1', '0');
INSERT INTO `amuletcommodity` VALUES ('5', '8841005', '99', '99', '-1', '0');
INSERT INTO `amuletcommodity` VALUES ('6', '8841006', '149', '149', '-1', '0');
INSERT INTO `amuletcommodity` VALUES ('7', '8842002', '49', '49', '-1', '0');

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
) ENGINE=InnoDB AUTO_INCREMENT=255 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of boydresscommodity
-- ----------------------------
INSERT INTO `boydresscommodity` VALUES ('1', '9510011', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('2', '9510021', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('3', '9510031', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('4', '9510041', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('5', '9510013', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('6', '9510015', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('7', '9510023', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('8', '9510025', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('9', '9510033', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('10', '9510035', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('11', '9510043', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('12', '9510045', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('13', '9510051', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('14', '9510053', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('15', '9510055', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('16', '9510061', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('17', '9510063', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('18', '9510065', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('19', '9510071', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('20', '9510073', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('21', '9510075', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('22', '9510081', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('23', '9510083', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('24', '9510085', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('25', '9510087', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('26', '9510091', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('27', '9510093', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('28', '9510095', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('29', '9510101', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('30', '9510111', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('31', '9510121', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('32', '9510131', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('33', '9510141', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('34', '9510143', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('35', '9510145', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('36', '9510147', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('37', '9510151', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('38', '9510153', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('39', '9510155', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('40', '9510171', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('41', '9510173', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('42', '9510175', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('43', '9510161', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('44', '9510163', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('45', '9510165', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('46', '9510191', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('47', '9510193', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('48', '9510195', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('49', '9510251', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('50', '9510253', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('51', '9510255', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('52', '9510257', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('53', '9510181', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('54', '9510183', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('55', '9510185', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('56', '9510201', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('57', '9510203', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('58', '9510205', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('59', '9510211', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('60', '9510213', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('61', '9510215', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('62', '9510241', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('63', '9510243', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('64', '9510245', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('65', '9510247', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('66', '9510221', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('67', '9510223', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('68', '9510225', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('69', '9510231', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('70', '9510233', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('71', '9510235', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('72', '9510237', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('73', '9510261', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('74', '9510263', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('75', '9510267', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('76', '9510265', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('77', '9510381', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('78', '9510383', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('79', '9510385', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('80', '9510387', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('81', '9510391', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('82', '9510393', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('83', '9510395', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('84', '9510397', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('85', '9510271', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('86', '9510281', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('87', '9510283', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('88', '9510285', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('89', '9510291', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('90', '9510301', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('91', '9510305', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('92', '9510303', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('93', '9510307', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('94', '9510311', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('95', '9510313', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('96', '9510315', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('97', '9510317', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('98', '9510321', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('99', '9510323', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('100', '9510325', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('101', '9510327', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('102', '9510341', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('103', '9510343', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('104', '9510345', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('105', '9510347', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('106', '9510331', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('107', '9510333', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('108', '9510335', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('109', '9519001', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('110', '9519005', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('111', '9519003', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('112', '9510371', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('113', '9510373', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('114', '9510375', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('115', '9510377', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('116', '9510351', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('117', '9510353', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('118', '9510355', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('119', '9510357', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('120', '9510411', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('121', '9510413', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('122', '9510415', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('123', '9510417', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('124', '9510431', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('125', '9510433', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('126', '9510435', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('127', '9510437', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('128', '9510401', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('129', '9510403', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('130', '9510405', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('131', '9510407', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('132', '9510421', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('133', '9510425', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('134', '9510427', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('135', '9510423', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('136', '9510361', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('137', '9510363', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('138', '9510365', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('139', '9510367', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('140', '9510441', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('141', '9510443', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('142', '9510445', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('143', '9510447', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('144', '9510451', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('145', '9510453', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('146', '9510455', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('147', '9510457', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('148', '9519031', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('149', '9510461', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('150', '9510463', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('151', '9510465', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('152', '9510467', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('153', '9510501', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('154', '9510503', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('155', '9510505', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('156', '9510507', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('157', '9510471', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('158', '9510473', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('159', '9510475', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('160', '9510477', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('161', '9510481', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('162', '9510483', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('163', '9510485', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('164', '9510487', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('165', '9510491', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('166', '9510493', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('167', '9510495', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('168', '9510497', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('169', '9510521', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('170', '9510523', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('171', '9510525', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('172', '9510527', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('173', '9510531', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('174', '9510533', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('175', '9510535', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('176', '9510537', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('177', '9510541', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('178', '9510543', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('179', '9510545', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('180', '9510547', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('181', '9510551', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('182', '9510553', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('183', '9510555', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('184', '9510557', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('185', '9510561', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('186', '9510563', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('187', '9510565', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('188', '9510567', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('189', '9510571', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('190', '9510573', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('191', '9510575', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('192', '9510577', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('193', '9510511', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('194', '9510513', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('195', '9510515', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('196', '9510517', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('197', '9510591', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('198', '9510593', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('199', '9510595', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('200', '9510597', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('201', '9510631', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('202', '9510633', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('203', '9510635', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('204', '9510637', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('205', '9510651', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('206', '9510653', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('207', '9510655', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('208', '9510657', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('209', '9510641', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('210', '9510643', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('211', '9510645', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('212', '9510647', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('213', '9510661', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('214', '9510663', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('215', '9510665', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('216', '9510667', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('217', '9510681', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('218', '9510671', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('219', '9510673', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('220', '9510675', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('221', '9510677', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('222', '9510581', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('223', '9510583', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('224', '9510585', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('225', '9510587', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('226', '9510611', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('227', '9510613', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('228', '9510615', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('229', '9510617', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('230', '9510621', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('231', '9510623', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('232', '9510625', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('233', '9510627', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('234', '9510601', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('235', '9510603', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('236', '9510605', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('237', '9510607', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('238', '9510801', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('239', '9510803', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('240', '9510791', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('241', '9510793', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('242', '9510871', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('243', '9510873', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('244', '9510875', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('245', '9510877', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('246', '9510851', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('247', '9510853', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('248', '9510855', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('249', '9510857', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('250', '9510861', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('251', '9510863', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('252', '9510865', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('253', '9510867', '129', '129', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('254', '9510841', '129', '129', '-1', '0');

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
) ENGINE=InnoDB AUTO_INCREMENT=82 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of boyeyescommodity
-- ----------------------------
INSERT INTO `boyeyescommodity` VALUES ('1', '9110011', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('2', '9110021', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('3', '9110031', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('4', '9110041', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('5', '9110051', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('6', '9110061', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('7', '9150011', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('8', '9150121', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('9', '9150231', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('10', '9150341', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('11', '9150051', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('12', '9150061', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('13', '9150081', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('14', '9150091', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('15', '9150101', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('16', '9150111', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('17', '9150071', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('18', '9150131', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('19', '9150141', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('20', '9150151', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('21', '9150161', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('22', '9150171', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('23', '9150181', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('24', '9150191', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('25', '9150201', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('26', '9150211', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('27', '9150221', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('28', '9150241', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('29', '9150251', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('30', '9150261', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('31', '9150271', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('32', '9150281', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('33', '9150291', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('34', '9150301', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('35', '9150311', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('36', '9150321', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('37', '9150331', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('38', '9150351', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('39', '9150361', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('40', '9150371', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('41', '9150381', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('42', '9150431', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('43', '9150441', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('44', '9150451', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('45', '9150461', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('46', '9150471', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('47', '9150481', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('48', '9150491', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('49', '9150501', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('50', '9150631', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('51', '9150641', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('52', '9150651', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('53', '9150661', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('54', '9150671', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('55', '9150681', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('56', '9150691', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('57', '9150701', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('58', '9150511', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('59', '9150521', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('60', '9150531', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('61', '9150541', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('62', '9150551', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('63', '9150561', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('64', '9150571', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('65', '9150581', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('66', '9150591', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('67', '9150601', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('68', '9150611', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('69', '9150621', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('70', '9150791', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('71', '9150801', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('72', '9150811', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('73', '9150821', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('74', '9150751', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('75', '9150761', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('76', '9150771', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('77', '9150781', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('78', '9150831', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('79', '9150841', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('80', '9150851', '29', '29', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('81', '9150861', '29', '29', '-1', '0');

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
) ENGINE=InnoDB AUTO_INCREMENT=102 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of boyhaircommodity
-- ----------------------------
INSERT INTO `boyhaircommodity` VALUES ('1', '9010011', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('2', '9010021', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('3', '9010031', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('4', '9010041', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('5', '9050011', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('6', '9050021', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('7', '9050031', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('8', '9050041', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('9', '9010013', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('10', '9010015', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('11', '9010023', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('12', '9010025', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('13', '9010033', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('14', '9010035', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('15', '9010043', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('16', '9010045', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('17', '9050013', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('18', '9050015', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('19', '9050023', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('20', '9050025', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('21', '9050033', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('22', '9050035', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('23', '9050037', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('24', '9050043', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('25', '9050045', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('26', '9050051', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('27', '9050053', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('28', '9050055', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('29', '9050091', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('30', '9050093', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('31', '9050061', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('32', '9050063', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('33', '9050065', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('34', '9050067', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('35', '9050069', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('36', '9050073', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('37', '9050075', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('38', '9050077', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('39', '9050081', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('40', '9050083', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('41', '9050085', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('42', '9050087', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('43', '9059001', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('44', '9059003', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('45', '9050095', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('46', '9050097', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('47', '9050101', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('48', '9050103', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('49', '9050105', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('50', '9050107', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('51', '9050123', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('52', '9050125', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('53', '9050127', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('54', '9050131', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('55', '9050133', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('56', '9050135', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('57', '9050137', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('58', '9050141', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('59', '9050143', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('60', '9050145', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('61', '9050147', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('62', '9050151', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('63', '9050153', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('64', '9050155', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('65', '9050157', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('66', '9050161', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('67', '9050163', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('68', '9050165', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('69', '9050167', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('70', '9050171', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('71', '9050173', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('72', '9050175', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('73', '9050177', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('74', '9050181', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('75', '9050183', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('76', '9050185', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('77', '9050187', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('78', '9050201', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('79', '9050203', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('80', '9050205', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('81', '9050207', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('82', '9050191', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('83', '9050193', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('84', '9050195', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('85', '9050197', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('86', '9050211', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('87', '9050213', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('88', '9050215', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('89', '9050217', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('90', '9050221', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('91', '9050223', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('92', '9050225', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('93', '9050227', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('94', '9050231', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('95', '9050233', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('96', '9050235', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('97', '9050237', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('98', '9050241', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('99', '9050243', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('100', '9050245', '59', '59', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('101', '9050247', '59', '59', '-1', '0');

-- ----------------------------
-- Table structure for `buycommoditylog`
-- ----------------------------
DROP TABLE IF EXISTS `buycommoditylog`;
CREATE TABLE `buycommoditylog` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(20) CHARACTER SET big5 NOT NULL,
  `itemID` int(11) NOT NULL,
  `itemName` varchar(62) CHARACTER SET big5 NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=135 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of buycommoditylog
-- ----------------------------
INSERT INTO `buycommoditylog` VALUES ('6', '大目仔GM', '8842002', '伺服器傳音秘笈');
INSERT INTO `buycommoditylog` VALUES ('7', '大目仔GM', '8890031', '鞭炮');
INSERT INTO `buycommoditylog` VALUES ('8', '大目仔GM', '8890037', '心花怒放');
INSERT INTO `buycommoditylog` VALUES ('9', '大目仔GM', '9510253', '黑申微服(男)');
INSERT INTO `buycommoditylog` VALUES ('10', '大目仔GM', '8842002', '伺服器傳音秘笈');
INSERT INTO `buycommoditylog` VALUES ('11', '哈哈騎士', '9212021', '綠大目仔靈物');
INSERT INTO `buycommoditylog` VALUES ('12', '哈哈騎士', '8842002', '伺服器傳音秘笈');
INSERT INTO `buycommoditylog` VALUES ('13', '大目仔GM', '9212021', '綠大目仔靈物');
INSERT INTO `buycommoditylog` VALUES ('14', '哈哈騎士', '8890037', '心花怒放');
INSERT INTO `buycommoditylog` VALUES ('15', '哈哈騎士', '8890031', '鞭炮');
INSERT INTO `buycommoditylog` VALUES ('16', '哈哈騎士', '9212013', '藍賴打靈物');
INSERT INTO `buycommoditylog` VALUES ('17', 'GG3BE0', '9212014', '白賴打靈物');
INSERT INTO `buycommoditylog` VALUES ('18', '侃侃o', '9212014', '白賴打靈物');
INSERT INTO `buycommoditylog` VALUES ('19', '楓悠', '9212011', '黃賴打靈物');
INSERT INTO `buycommoditylog` VALUES ('20', 'GG3BE0', '9212023', '藍大目仔靈物');
INSERT INTO `buycommoditylog` VALUES ('21', '楓悠', '9519031', '天上柳巾衣(男)');
INSERT INTO `buycommoditylog` VALUES ('22', '楓悠', '9050123', '綠色伊格拉髮');
INSERT INTO `buycommoditylog` VALUES ('23', '楓悠', '9150081', '藍英宰眼(男)');
INSERT INTO `buycommoditylog` VALUES ('24', '楓悠', '9410133', '彩色面紋');
INSERT INTO `buycommoditylog` VALUES ('25', '西西', '9150341', '憂鬱的眼(男)');
INSERT INTO `buycommoditylog` VALUES ('26', '西西', '9050247', '飄飄光澤黑髮(男)');
INSERT INTO `buycommoditylog` VALUES ('27', '西西', '9510111', '韓國足球服(男)');
INSERT INTO `buycommoditylog` VALUES ('28', '西西', '9212014', '白賴打靈物');
INSERT INTO `buycommoditylog` VALUES ('29', '桐人', '9050221', '尊哥哥黑髮(男)');
INSERT INTO `buycommoditylog` VALUES ('30', '桐人', '9150631', '黑色瞳鈴眼(男)');
INSERT INTO `buycommoditylog` VALUES ('31', '桐人', '9510527', '黑河岳服(男)');
INSERT INTO `buycommoditylog` VALUES ('32', '桐人', '8842002', '伺服器傳音秘笈');
INSERT INTO `buycommoditylog` VALUES ('33', '冰痕', '9050123', '綠色伊格拉髮');
INSERT INTO `buycommoditylog` VALUES ('34', '冰痕', '9150621', '氣態凝神藍眼(男)');
INSERT INTO `buycommoditylog` VALUES ('35', '冰痕', '9510081', '蓮華黑衣(男)');
INSERT INTO `buycommoditylog` VALUES ('36', '冰痕', '8710223', '驗祖眼鏡');
INSERT INTO `buycommoditylog` VALUES ('37', '冰痕', '8493354', '黑九尾狐尾巴');
INSERT INTO `buycommoditylog` VALUES ('38', 'Shake喵的啦', '9212011', '黃賴打靈物');
INSERT INTO `buycommoditylog` VALUES ('39', 'Shake喵的啦', '9510081', '蓮華黑衣(男)');
INSERT INTO `buycommoditylog` VALUES ('40', 'Shake喵的啦', '8493012', '黑披風');
INSERT INTO `buycommoditylog` VALUES ('41', 'Shake喵的啦', '8610091', '武士帽');
INSERT INTO `buycommoditylog` VALUES ('42', '戀愛血型ABO', '9212021', '綠大目仔靈物');
INSERT INTO `buycommoditylog` VALUES ('43', '戀愛血型ABO', '9050223', '尊哥哥紫髮(男)');
INSERT INTO `buycommoditylog` VALUES ('44', '戀愛血型ABO', '8710333', '妄想面具');
INSERT INTO `buycommoditylog` VALUES ('45', '戀愛血型ABO', '9510607', '黃鴨鴨泳圈(男)');
INSERT INTO `buycommoditylog` VALUES ('46', '小菜', '8842002', '伺服器傳音秘笈');
INSERT INTO `buycommoditylog` VALUES ('47', '星痕', '9212013', '藍賴打靈物');
INSERT INTO `buycommoditylog` VALUES ('48', 'asdf', '9510081', '蓮華黑衣(男)');
INSERT INTO `buycommoditylog` VALUES ('49', 'asdf', '8610473', '裝鬼嚇不死你(男)');
INSERT INTO `buycommoditylog` VALUES ('50', 'asdf', '8842002', '伺服器傳音秘笈');
INSERT INTO `buycommoditylog` VALUES ('51', 'asdf', '8493021', '黃色漁斗笠');
INSERT INTO `buycommoditylog` VALUES ('52', 'asdf', '9212013', '藍賴打靈物');
INSERT INTO `buycommoditylog` VALUES ('53', 'asdf', '8710223', '驗祖眼鏡');
INSERT INTO `buycommoditylog` VALUES ('54', 'asdf', '8842002', '伺服器傳音秘笈');
INSERT INTO `buycommoditylog` VALUES ('55', '太猛啦', '9050125', '黑色伊格拉髮');
INSERT INTO `buycommoditylog` VALUES ('56', '太猛啦', '9510111', '韓國足球服(男)');
INSERT INTO `buycommoditylog` VALUES ('57', '太猛啦', '8493032', '紫月刀');
INSERT INTO `buycommoditylog` VALUES ('58', '太猛啦', '9212014', '白賴打靈物');
INSERT INTO `buycommoditylog` VALUES ('59', '隨風飄逸o', '9150081', '藍英宰眼(男)');
INSERT INTO `buycommoditylog` VALUES ('60', '隨風飄逸o', '9050127', '紅色伊格拉髮');
INSERT INTO `buycommoditylog` VALUES ('61', '隨風飄逸o', '8710223', '驗祖眼鏡');
INSERT INTO `buycommoditylog` VALUES ('62', '隨風飄逸o', '9410163', '十字紗布');
INSERT INTO `buycommoditylog` VALUES ('63', '隨風飄逸o', '9510867', '牛仔白夾克(男)');
INSERT INTO `buycommoditylog` VALUES ('64', '隨風飄逸o', '8493354', '黑九尾狐尾巴');
INSERT INTO `buycommoditylog` VALUES ('65', '俊俊好好人', '8493091', '蒂芬妮之羽');
INSERT INTO `buycommoditylog` VALUES ('66', 'asdf', '8842002', '伺服器傳音秘笈');
INSERT INTO `buycommoditylog` VALUES ('67', '隨風飄逸o', '8610603', '牛仔皮黑帽(男)');
INSERT INTO `buycommoditylog` VALUES ('68', '我的童年啊', '9510041', '黑忍服(男)');
INSERT INTO `buycommoditylog` VALUES ('69', '我的童年啊', '8493181', '闇赤鬼龍之翼');
INSERT INTO `buycommoditylog` VALUES ('70', '我的童年啊', '8610111', '上帝之手');
INSERT INTO `buycommoditylog` VALUES ('71', '我的童年啊', '9410133', '彩色面紋');
INSERT INTO `buycommoditylog` VALUES ('72', '我的童年啊', '8710013', '忍字刺青');
INSERT INTO `buycommoditylog` VALUES ('73', '俊俊好好人', '9510465', '凡爾賽白西服(男)');
INSERT INTO `buycommoditylog` VALUES ('74', '大目仔GM', '8841001', '力量還原本');
INSERT INTO `buycommoditylog` VALUES ('75', '大目仔GM', '8841002', '精力還原本');
INSERT INTO `buycommoditylog` VALUES ('76', '大目仔GM', '8841003', '氣力還原本');
INSERT INTO `buycommoditylog` VALUES ('77', '大目仔GM', '8841004', '智力還原本');
INSERT INTO `buycommoditylog` VALUES ('78', '大目仔GM', '8841005', '自由還原本');
INSERT INTO `buycommoditylog` VALUES ('79', '大目仔GM', '8841006', '全部還原本');
INSERT INTO `buycommoditylog` VALUES ('80', '大目仔GM', '7820501', '靈物名牌');
INSERT INTO `buycommoditylog` VALUES ('81', '大目仔GM', '8950532', '七夕情人裝飾');
INSERT INTO `buycommoditylog` VALUES ('82', '大目仔GM', '8950105', '聖雪飛空');
INSERT INTO `buycommoditylog` VALUES ('83', '大目仔GM', '8950530', '聖誕麋鹿裝飾');
INSERT INTO `buycommoditylog` VALUES ('84', '大目仔GM', '7820501', '靈物名牌');
INSERT INTO `buycommoditylog` VALUES ('85', '隨風飄逸o', '8841006', '全部還原本');
INSERT INTO `buycommoditylog` VALUES ('86', '大目仔GM', '8842002', '伺服器傳音秘笈');
INSERT INTO `buycommoditylog` VALUES ('87', '梓條', '8842002', '伺服器傳音秘笈');
INSERT INTO `buycommoditylog` VALUES ('88', '梓條', '8842002', '伺服器傳音秘笈');
INSERT INTO `buycommoditylog` VALUES ('89', '梓條', '7820501', '靈物名牌');
INSERT INTO `buycommoditylog` VALUES ('90', '梓條', '9212014', '白賴打靈物');
INSERT INTO `buycommoditylog` VALUES ('91', '梓條', '9510111', '韓國足球服(男)');
INSERT INTO `buycommoditylog` VALUES ('92', '梓條', '8493088', '命關東旗(紅)');
INSERT INTO `buycommoditylog` VALUES ('93', '梓條', '8950106', '浪波勁空');
INSERT INTO `buycommoditylog` VALUES ('94', '隨風飄逸o', '8842002', '伺服器傳音秘笈');
INSERT INTO `buycommoditylog` VALUES ('95', '隨風飄逸o', '8842002', '伺服器傳音秘笈');
INSERT INTO `buycommoditylog` VALUES ('96', '隨風飄逸o', '8842002', '伺服器傳音秘笈');
INSERT INTO `buycommoditylog` VALUES ('97', '隨風飄逸o', '8842002', '伺服器傳音秘笈');
INSERT INTO `buycommoditylog` VALUES ('98', '梓條', '8950107', '冰火升空');
INSERT INTO `buycommoditylog` VALUES ('99', '梓條', '8950102', '草上飛');
INSERT INTO `buycommoditylog` VALUES ('100', '梓條', '8890037', '心花怒放');
INSERT INTO `buycommoditylog` VALUES ('101', '梓條', '8842002', '伺服器傳音秘笈');
INSERT INTO `buycommoditylog` VALUES ('102', '梓條', '8842002', '伺服器傳音秘笈');
INSERT INTO `buycommoditylog` VALUES ('103', '梓條', '8842002', '伺服器傳音秘笈');
INSERT INTO `buycommoditylog` VALUES ('104', '梓條', '8842002', '伺服器傳音秘笈');
INSERT INTO `buycommoditylog` VALUES ('105', '哪裡都是浮雲', '8950102', '草上飛');
INSERT INTO `buycommoditylog` VALUES ('106', '哪裡都是浮雲', '8493121', '柳生雙背刃');
INSERT INTO `buycommoditylog` VALUES ('107', '哪裡都是浮雲', '9510253', '黑申微服(男)');
INSERT INTO `buycommoditylog` VALUES ('108', '哪裡都是浮雲', '9212022', '紅大目仔靈物');
INSERT INTO `buycommoditylog` VALUES ('109', '哪裡都是浮雲', '8610031', '黑鬼華斗笠');
INSERT INTO `buycommoditylog` VALUES ('110', '哪裡都是浮雲', '9410273', '白繃帶頭巾');
INSERT INTO `buycommoditylog` VALUES ('111', '小菜', '8842002', '伺服器傳音秘笈');
INSERT INTO `buycommoditylog` VALUES ('112', '小菜', '8950501', '黑摸摸裝飾');
INSERT INTO `buycommoditylog` VALUES ('113', '小菜', '8950103', '火焰疾走');
INSERT INTO `buycommoditylog` VALUES ('114', '俊俊好好人', '8610457', '小熊貓趴頭上(男)');
INSERT INTO `buycommoditylog` VALUES ('115', '隨風飄逸o', '9150621', '氣態凝神藍眼(男)');
INSERT INTO `buycommoditylog` VALUES ('116', '隨風飄逸o', '8842002', '伺服器傳音秘笈');
INSERT INTO `buycommoditylog` VALUES ('117', '隨風飄逸o', '8842002', '伺服器傳音秘笈');
INSERT INTO `buycommoditylog` VALUES ('118', '隨風飄逸o', '8842002', '伺服器傳音秘笈');
INSERT INTO `buycommoditylog` VALUES ('119', '隨風飄逸o', '8842002', '伺服器傳音秘笈');
INSERT INTO `buycommoditylog` VALUES ('120', '哈哈騎士', '8950501', '黑摸摸裝飾');
INSERT INTO `buycommoditylog` VALUES ('121', '哈哈騎士', '8950513', '紅熊熊裝飾');
INSERT INTO `buycommoditylog` VALUES ('122', '哈哈騎士', '8950107', '冰火升空');
INSERT INTO `buycommoditylog` VALUES ('123', '哈哈騎士', '8950102', '草上飛');
INSERT INTO `buycommoditylog` VALUES ('124', '哈哈騎士', '8950106', '浪波勁空');
INSERT INTO `buycommoditylog` VALUES ('125', '哈哈騎士', '8950104', '震雷狂升');
INSERT INTO `buycommoditylog` VALUES ('126', '哈哈騎士', '8950101', '凌空微步');
INSERT INTO `buycommoditylog` VALUES ('127', '哈哈騎士', '8950103', '火焰疾走');
INSERT INTO `buycommoditylog` VALUES ('128', '大目仔GM', '8950106', '浪波勁空');
INSERT INTO `buycommoditylog` VALUES ('129', '隨風飄逸o', '8841006', '全部還原本');
INSERT INTO `buycommoditylog` VALUES ('130', '測試A', '9510021', '紅狐服(男)');
INSERT INTO `buycommoditylog` VALUES ('131', '測試A', '8493084', '愛搞鬼關東旗(黃)');
INSERT INTO `buycommoditylog` VALUES ('132', '測試A', '8950101', '凌空微步');
INSERT INTO `buycommoditylog` VALUES ('133', '測試A', '8950503', '相框裝飾');
INSERT INTO `buycommoditylog` VALUES ('134', '測試A', '8890037', '心花怒放');

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
  `guild` int(4) NOT NULL,
  `hp` int(8) NOT NULL DEFAULT '1',
  `maxHp` int(8) NOT NULL DEFAULT '1',
  `mp` int(8) NOT NULL DEFAULT '1',
  `maxMp` int(8) NOT NULL DEFAULT '1',
  `fury` int(8) NOT NULL DEFAULT '0',
  `maxFury` int(8) NOT NULL DEFAULT '1200',
  `exp` int(8) NOT NULL DEFAULT '0',
  `rank` int(8) NOT NULL DEFAULT '0',
  `money` int(8) NOT NULL DEFAULT '0',
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
  `position` int(4) NOT NULL DEFAULT '-1',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=41 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of characters
-- ----------------------------
INSERT INTO `characters` VALUES ('40', '1', '0', '測試A', '江湖人', '1', '9010011', '9110011', '2', '0', '255', '255', '125', '125', '40', '40', '144', '1200', '0', '0', '19', '3', '3', '5', '3', '0', '0', '2', '0', '9', '11', '0', '4', '4', '0', '0', '27', '0', '4', '2', '3', '2', '6', '873', '1040', '1');

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
) ENGINE=InnoDB AUTO_INCREMENT=347 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of drop_data
-- ----------------------------
INSERT INTO `drop_data` VALUES ('1', '1000101', '8910011', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('2', '1000201', '8910021', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('3', '1000301', '8910031', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('4', '1000401', '8910041', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('5', '1000501', '8910051', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('6', '1000601', '8910061', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('7', '1000701', '8910071', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('8', '1000702', '8910072', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('9', '1000801', '8910081', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('10', '1000901', '8910091', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('11', '1001001', '8910101', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('12', '1001201', '8910121', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('13', '1001301', '8910131', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('14', '1001401', '8910141', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('15', '1001501', '8910151', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('16', '1001502', '8910152', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('17', '1001601', '8910161', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('18', '1001701', '8910171', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('19', '1001801', '8910181', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('20', '1002001', '8910201', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('21', '1002101', '8910211', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('22', '1002201', '8910221', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('23', '1002302', '8910232', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('24', '1002401', '8910241', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('25', '1002502', '8910252', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('26', '1002601', '8910261', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('27', '1002702', '8910272', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('28', '1002801', '8910281', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('29', '1003001', '8910301', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('30', '1003003', '8910303', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('31', '1003201', '8910321', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('32', '1003202', '8910322', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('33', '1003401', '8910341', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('34', '1003402', '8910342', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('35', '1003501', '8910351', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('36', '1003601', '8910361', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('37', '1003602', '8910362', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('38', '1003701', '8910371', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('39', '1003801', '8910381', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('40', '1003802', '8910382', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('41', '1003901', '8910391', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('42', '1004001', '8910401', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('43', '1004002', '8910402', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('44', '1004201', '8910421', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('45', '1004301', '8910431', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('46', '1004302', '8910432', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('47', '1004401', '8910441', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('48', '1004501', '8910451', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('49', '1004502', '8910452', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('50', '1004601', '8910461', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('51', '1004701', '8910471', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('52', '1004801', '8910481', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('53', '1004802', '8910482', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('54', '1004901', '8910491', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('55', '1004902', '8910492', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('56', '1005001', '8910501', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('57', '1005002', '8910502', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('58', '1005101', '8910511', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('59', '1005201', '8910521', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('60', '1005301', '8910531', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('61', '1005401', '8910541', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('62', '1005402', '8910542', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('63', '1005501', '8910551', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('64', '1005502', '8910552', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('65', '1005601', '8910561', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('66', '1005701', '8910571', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('67', '1005702', '8910572', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('68', '1005801', '8910581', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('69', '1005802', '8910582', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('70', '1005901', '8910591', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('71', '1006001', '8910601', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('72', '1006002', '8910602', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('73', '1006101', '8910611', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('74', '1006102', '8910612', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('75', '1006201', '8910621', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('76', '1006401', '8910641', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('77', '1006601', '8910661', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('78', '1006701', '8910671', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('79', '1006801', '8910681', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('80', '1007001', '8910701', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('81', '1007101', '8910711', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('82', '1007102', '8910712', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('83', '1007201', '8910721', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('84', '1007401', '8910741', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('85', '1007501', '8910751', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('86', '1007502', '8910752', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('87', '1007701', '8910771', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('88', '1007801', '8910781', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('89', '1007901', '8910791', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('90', '1008001', '8910801', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('91', '1008101', '8910811', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('92', '1008201', '8910821', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('93', '1008301', '8910831', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('94', '1008401', '8910841', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('95', '1008501', '8910851', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('96', '1008601', '8910861', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('97', '1008701', '8910871', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('98', '1008801', '8910881', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('99', '1008901', '8910891', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('100', '1009001', '8910901', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('101', '1009101', '8910911', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('102', '1009201', '8910921', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('103', '1009301', '8910931', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('104', '1009401', '8910941', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('105', '1009501', '8910951', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('106', '1009701', '8910971', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('107', '1009901', '8910991', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('108', '1010101', '8911011', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('109', '1010301', '8911031', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('110', '1010401', '8911041', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('111', '1010501', '8911051', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('112', '1010701', '8911071', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('113', '1010801', '8911081', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('114', '1010901', '8911091', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('115', '1011001', '8911101', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('116', '1011201', '8911121', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('117', '1011401', '8911141', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('118', '1011501', '8911151', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('119', '1011601', '8911161', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('120', '1011801', '8911181', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('121', '1011901', '8911191', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('122', '1012001', '8911201', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('123', '1012002', '8911202', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('124', '1012101', '8911211', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('125', '1012301', '8911231', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('126', '1012501', '8911251', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('127', '1012701', '8911271', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('128', '1013001', '8911301', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('129', '1013002', '8911302', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('130', '1013201', '8911321', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('131', '1013401', '8911341', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('132', '1013601', '8911361', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('133', '1013701', '8911371', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('134', '1013901', '8911391', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('135', '1014001', '8911401', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('136', '1014002', '8911402', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('137', '1014101', '8911411', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('138', '1014102', '8911412', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('139', '1014201', '8911421', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('140', '1014301', '8911431', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('141', '1014302', '8911432', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('142', '1014401', '8911441', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('143', '1014501', '8911451', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('144', '1014502', '8911452', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('145', '1014503', '8911453', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('146', '1014601', '8911461', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('147', '1014602', '8911462', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('148', '1014701', '8911471', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('149', '1014801', '8911481', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('150', '1014901', '8911491', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('151', '1015001', '8911501', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('152', '1015002', '8911502', '1', '1', '0', '400000');
INSERT INTO `drop_data` VALUES ('153', '1000101', '8820011', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('154', '1000101', '8810011', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('155', '1000101', '8130011', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('156', '1000101', '8120012', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('157', '1000101', '8510011', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('158', '1000201', '8820011', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('159', '1000201', '8810011', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('160', '1000201', '8130012', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('161', '1000201', '8110012', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('162', '1000201', '8510011', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('163', '1000301', '8820011', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('164', '1000301', '8810011', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('165', '1000301', '8010011', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('166', '1000301', '8110011', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('167', '1000301', '8510011', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('168', '1000501', '8820011', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('169', '1000501', '8810011', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('170', '1000501', '8030011', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('171', '1000501', '8130012', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('172', '1000501', '8510011', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('173', '1000601', '8820011', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('174', '1000601', '8810011', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('175', '1000601', '8110011', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('176', '1000601', '8120011', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('177', '1000601', '8510011', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('178', '1000701', '8820011', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('179', '1000701', '8810011', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('180', '1000701', '8010011', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('181', '1000701', '8030011', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('182', '1000701', '8510011', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('183', '1000801', '8820011', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('184', '1000801', '8810011', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('185', '1000801', '8120011', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('186', '1000801', '8510011', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('187', '1001001', '8820011', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('188', '1001001', '8810011', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('189', '1001001', '8210081', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('190', '1001001', '8310081', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('191', '1001201', '8820011', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('192', '1001201', '8810011', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('193', '1001201', '8030101', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('194', '1001201', '8110101', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('195', '1001201', '8120101', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('196', '1001201', '8880011', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('197', '1001201', '8510021', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('198', '1001401', '8820011', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('199', '1001401', '8810011', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('200', '1001401', '8040101', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('201', '1001401', '8060101', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('202', '1001401', '8110102', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('203', '1001401', '8880011', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('204', '1001401', '8510021', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('205', '1001601', '8820011', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('206', '1001601', '8810011', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('207', '1001601', '8120102', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('208', '1001601', '8050101', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('209', '1001601', '8010101', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('210', '1001601', '8880011', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('211', '1001601', '8510021', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('212', '1001801', '8820011', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('213', '1001801', '8810011', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('214', '1001801', '8020101', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('215', '1001801', '8130102', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('216', '1001801', '8110101', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('217', '1001801', '8880011', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('218', '1001801', '8510021', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('219', '1002001', '8820021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('220', '1002001', '8810021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('221', '1002001', '8880011', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('222', '1002001', '8310161', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('223', '1002001', '8210161', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('224', '1002001', '8510021', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('225', '1002101', '8810021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('226', '1002101', '8880021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('227', '1002101', '8060201', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('228', '1002101', '8060251', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('229', '1002101', '8130201', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('230', '1002101', '8130202', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('231', '1002101', '8130151', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('232', '1002101', '8040251', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('233', '1002201', '8810021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('234', '1002201', '8820021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('235', '1002201', '8880021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('236', '1002201', '8020201', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('237', '1002201', '8020251', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('238', '1002201', '8120202', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('239', '1002201', '8120251', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('240', '1002401', '8810021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('241', '1002401', '8820021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('242', '1002401', '8880021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('243', '1002401', '8110201', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('244', '1002401', '8040251', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('245', '1002401', '8030251', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('246', '1002601', '8880021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('247', '1002601', '8310241', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('248', '1002601', '8120201', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('249', '1002601', '8120252', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('250', '1002601', '8110251', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('251', '1002601', '8110252', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('252', '1002601', '8010201', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('253', '1002601', '8010251', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('254', '1002801', '8810021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('255', '1002801', '8820021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('256', '1002801', '8880021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('257', '1002801', '8210241', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('258', '1002801', '8130202', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('259', '1002801', '8110202', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('260', '1002801', '8110251', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('261', '1002801', '8050201', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('262', '1002801', '8050251', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('263', '1003001', '8810021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('264', '1003001', '8820021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('265', '1003001', '8880021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('266', '1003001', '8310321', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('267', '1003001', '8210321', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('268', '1003201', '8810021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('269', '1003201', '8820021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('270', '1003201', '8510061', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('271', '1003201', '8130301', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('272', '1003201', '8110351', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('273', '1003201', '8050301', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('274', '1003201', '8010351', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('275', '1003401', '8810021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('276', '1003401', '8820021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('277', '1003401', '8120302', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('278', '1003401', '8040301', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('279', '1003401', '8020351', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('280', '1003401', '8020301', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('281', '1003401', '8020351', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('282', '1003501', '8810021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('283', '1003501', '8820021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('284', '1003501', '8880031', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('285', '1003501', '8130302', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('286', '1003501', '8110302', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('287', '1003501', '8120352', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('288', '1003501', '8110352', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('289', '1003501', '8020301', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('290', '1003601', '8710173', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('291', '1003601', '8810021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('292', '1003601', '8820021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('293', '1003601', '8880031', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('294', '1003601', '8130301', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('295', '1003601', '8120301', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('296', '1003601', '8050301', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('297', '1003601', '8060351', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('298', '1003701', '8810021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('299', '1003701', '8820021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('300', '1003701', '8880031', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('301', '1003701', '8110302', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('302', '1003701', '8130301', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('303', '1003701', '8120301', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('304', '1003701', '8050301', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('305', '1003701', '8030351', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('306', '1003701', '8040301', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('307', '1003701', '8040351', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('308', '1003801', '8810021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('309', '1003801', '8820021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('310', '1003801', '8880031', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('311', '1003801', '8130302', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('312', '1003801', '8110301', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('313', '1003801', '8020301', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('314', '1003801', '8040351', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('315', '1003901', '8810021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('316', '1003901', '8820021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('317', '1003901', '8130302', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('318', '1003901', '8110301', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('319', '1003901', '8120352', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('320', '1003901', '8130352', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('321', '1003901', '8010301', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('322', '1004001', '8810021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('323', '1004001', '8820021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('324', '1004001', '8210401', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('325', '1004001', '8310401', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('326', '1004301', '8810021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('327', '1004301', '8820021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('328', '1004301', '8050351', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('329', '1004301', '8130401', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('330', '1004401', '8810021', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('331', '1004401', '8820031', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('332', '1004401', '8020401', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('333', '1004401', '8030401', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('334', '1004501', '8110401', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('335', '1004501', '8120402', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('336', '1004601', '8820031', '1', '1', '0', '30000');
INSERT INTO `drop_data` VALUES ('337', '1004601', '8010401', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('338', '1004601', '8110401', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('339', '1004601', '8050351', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('340', '1004801', '8120402', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('341', '1004801', '8060401', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('342', '1004801', '8030401', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('343', '1004901', '8130402', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('344', '1004901', '8130401', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('345', '1004901', '8030401', '1', '1', '0', '10000');
INSERT INTO `drop_data` VALUES ('346', '1005001', '8310402', '1', '1', '0', '10000');

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
) ENGINE=InnoDB AUTO_INCREMENT=81 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of face1commodity
-- ----------------------------
INSERT INTO `face1commodity` VALUES ('1', '8710013', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('2', '8710023', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('3', '8710033', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('4', '8710043', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('5', '8710053', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('6', '8710063', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('7', '8710073', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('8', '8710083', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('9', '8710093', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('10', '8710103', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('11', '8710113', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('12', '8710123', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('13', '8710133', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('14', '8710143', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('15', '8710153', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('16', '8710183', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('17', '8710163', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('18', '8710173', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('19', '8710203', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('20', '8710193', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('21', '8710213', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('22', '8710233', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('23', '8710243', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('24', '8710253', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('25', '8710263', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('26', '8710273', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('27', '8710283', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('28', '8710293', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('29', '8710303', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('30', '8710313', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('31', '8710323', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('32', '8710333', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('33', '8710343', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('34', '8710353', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('35', '8710363', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('36', '8710373', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('37', '8710223', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('38', '8710383', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('39', '8710393', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('40', '8710403', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('41', '8710413', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('42', '8710423', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('43', '8710433', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('44', '8710443', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('45', '8710453', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('46', '8710463', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('47', '8710473', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('48', '8710483', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('49', '8710493', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('50', '8710503', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('51', '8710513', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('52', '8710523', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('53', '8710573', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('54', '8710583', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('55', '8710593', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('56', '8710603', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('57', '8710613', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('58', '8710533', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('59', '8710543', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('60', '8710553', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('61', '8710563', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('62', '8710623', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('63', '8710633', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('64', '8710643', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('65', '8710653', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('66', '8710703', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('67', '8710713', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('68', '8710723', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('69', '8710733', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('70', '8710663', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('71', '8710673', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('72', '8710683', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('73', '8710693', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('74', '8710741', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('75', '8710742', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('76', '8710743', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('77', '8710751', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('78', '8710752', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('79', '8710753', '49', '49', '-1', '0');
INSERT INTO `face1commodity` VALUES ('80', '8710763', '49', '49', '-1', '0');

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
) ENGINE=InnoDB AUTO_INCREMENT=59 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of face2commodity
-- ----------------------------
INSERT INTO `face2commodity` VALUES ('1', '9410011', '49', '49', '-1', '0');
INSERT INTO `face2commodity` VALUES ('2', '9410021', '49', '49', '-1', '0');
INSERT INTO `face2commodity` VALUES ('3', '9410053', '49', '49', '-1', '0');
INSERT INTO `face2commodity` VALUES ('4', '9410063', '49', '49', '-1', '0');
INSERT INTO `face2commodity` VALUES ('5', '9410013', '49', '49', '-1', '0');
INSERT INTO `face2commodity` VALUES ('6', '9410023', '49', '49', '-1', '0');
INSERT INTO `face2commodity` VALUES ('7', '9410033', '49', '49', '-1', '0');
INSERT INTO `face2commodity` VALUES ('8', '9410043', '49', '49', '-1', '0');
INSERT INTO `face2commodity` VALUES ('9', '9410073', '49', '49', '-1', '0');
INSERT INTO `face2commodity` VALUES ('10', '9410083', '49', '49', '-1', '0');
INSERT INTO `face2commodity` VALUES ('11', '9410093', '49', '49', '-1', '0');
INSERT INTO `face2commodity` VALUES ('12', '9410103', '49', '49', '-1', '0');
INSERT INTO `face2commodity` VALUES ('13', '9410113', '49', '49', '-1', '0');
INSERT INTO `face2commodity` VALUES ('14', '9410123', '49', '49', '-1', '0');
INSERT INTO `face2commodity` VALUES ('15', '9410133', '49', '49', '-1', '0');
INSERT INTO `face2commodity` VALUES ('16', '9410143', '49', '49', '-1', '0');
INSERT INTO `face2commodity` VALUES ('17', '9410153', '49', '49', '-1', '0');
INSERT INTO `face2commodity` VALUES ('18', '9410163', '49', '49', '-1', '0');
INSERT INTO `face2commodity` VALUES ('19', '9410173', '49', '49', '-1', '0');
INSERT INTO `face2commodity` VALUES ('20', '9410183', '49', '49', '-1', '0');
INSERT INTO `face2commodity` VALUES ('21', '9410193', '49', '49', '-1', '0');
INSERT INTO `face2commodity` VALUES ('22', '9410203', '49', '49', '-1', '0');
INSERT INTO `face2commodity` VALUES ('23', '9410223', '49', '49', '-1', '0');
INSERT INTO `face2commodity` VALUES ('24', '9410213', '49', '49', '-1', '0');
INSERT INTO `face2commodity` VALUES ('25', '9410233', '49', '49', '-1', '0');
INSERT INTO `face2commodity` VALUES ('26', '9410243', '49', '49', '-1', '0');
INSERT INTO `face2commodity` VALUES ('27', '9410253', '49', '49', '-1', '0');
INSERT INTO `face2commodity` VALUES ('28', '9410263', '49', '49', '-1', '0');
INSERT INTO `face2commodity` VALUES ('29', '9410353', '49', '49', '-1', '0');
INSERT INTO `face2commodity` VALUES ('30', '9410363', '49', '49', '-1', '0');
INSERT INTO `face2commodity` VALUES ('31', '9410373', '49', '49', '-1', '0');
INSERT INTO `face2commodity` VALUES ('32', '9410383', '49', '49', '-1', '0');
INSERT INTO `face2commodity` VALUES ('33', '9410273', '49', '49', '-1', '0');
INSERT INTO `face2commodity` VALUES ('34', '9410283', '49', '49', '-1', '0');
INSERT INTO `face2commodity` VALUES ('35', '9410293', '49', '49', '-1', '0');
INSERT INTO `face2commodity` VALUES ('36', '9410313', '49', '49', '-1', '0');
INSERT INTO `face2commodity` VALUES ('37', '9410323', '49', '49', '-1', '0');
INSERT INTO `face2commodity` VALUES ('38', '9410333', '49', '49', '-1', '0');
INSERT INTO `face2commodity` VALUES ('39', '9410343', '49', '49', '-1', '0');
INSERT INTO `face2commodity` VALUES ('40', '9410473', '49', '49', '-1', '0');
INSERT INTO `face2commodity` VALUES ('41', '9410483', '49', '49', '-1', '0');
INSERT INTO `face2commodity` VALUES ('42', '9410493', '49', '49', '-1', '0');
INSERT INTO `face2commodity` VALUES ('43', '9410503', '49', '49', '-1', '0');
INSERT INTO `face2commodity` VALUES ('44', '9410513', '49', '49', '-1', '0');
INSERT INTO `face2commodity` VALUES ('45', '9410523', '49', '49', '-1', '0');
INSERT INTO `face2commodity` VALUES ('46', '9410533', '49', '49', '-1', '0');
INSERT INTO `face2commodity` VALUES ('47', '9410543', '49', '49', '-1', '0');
INSERT INTO `face2commodity` VALUES ('48', '9410433', '49', '49', '-1', '0');
INSERT INTO `face2commodity` VALUES ('49', '9410443', '49', '49', '-1', '0');
INSERT INTO `face2commodity` VALUES ('50', '9410453', '49', '49', '-1', '0');
INSERT INTO `face2commodity` VALUES ('51', '9410463', '49', '49', '-1', '0');
INSERT INTO `face2commodity` VALUES ('52', '9410553', '49', '49', '-1', '0');
INSERT INTO `face2commodity` VALUES ('53', '9410563', '49', '49', '-1', '0');
INSERT INTO `face2commodity` VALUES ('54', '9410393', '49', '49', '-1', '0');
INSERT INTO `face2commodity` VALUES ('55', '9410403', '49', '49', '-1', '0');
INSERT INTO `face2commodity` VALUES ('56', '9410413', '49', '49', '-1', '0');
INSERT INTO `face2commodity` VALUES ('57', '9410423', '49', '49', '-1', '0');
INSERT INTO `face2commodity` VALUES ('58', '9410573', '49', '49', '-1', '0');

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
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

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
) ENGINE=InnoDB AUTO_INCREMENT=257 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of girldresscommodity
-- ----------------------------
INSERT INTO `girldresscommodity` VALUES ('1', '9510012', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('2', '9510032', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('3', '9510022', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('4', '9510042', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('5', '9510014', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('6', '9510016', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('7', '9510034', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('8', '9510036', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('9', '9510024', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('10', '9510026', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('11', '9510044', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('12', '9510046', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('13', '9510052', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('14', '9510054', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('15', '9510056', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('16', '9510062', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('17', '9510064', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('18', '9510066', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('19', '9510082', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('20', '9510084', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('21', '9510086', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('22', '9510088', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('23', '9510102', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('24', '9510112', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('25', '9510122', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('26', '9510132', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('27', '9510142', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('28', '9510144', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('29', '9510146', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('30', '9510148', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('31', '9510152', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('32', '9510154', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('33', '9510156', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('34', '9510172', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('35', '9510174', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('36', '9510176', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('37', '9510162', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('38', '9510164', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('39', '9510166', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('40', '9510192', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('41', '9510194', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('42', '9510196', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('43', '9510252', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('44', '9510254', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('45', '9510256', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('46', '9510258', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('47', '9510182', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('48', '9510184', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('49', '9510186', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('50', '9510202', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('51', '9510204', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('52', '9510206', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('53', '9510212', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('54', '9510214', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('55', '9510216', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('56', '9510242', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('57', '9510244', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('58', '9510246', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('59', '9510248', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('60', '9510222', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('61', '9510224', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('62', '9510226', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('63', '9510232', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('64', '9510234', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('65', '9510236', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('66', '9510238', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('67', '9510262', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('68', '9510264', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('69', '9510266', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('70', '9510268', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('71', '9510392', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('72', '9510394', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('73', '9510396', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('74', '9510398', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('75', '9510402', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('76', '9510404', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('77', '9510406', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('78', '9510408', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('79', '9510272', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('80', '9510282', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('81', '9510284', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('82', '9510286', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('83', '9510292', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('84', '9510302', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('85', '9510304', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('86', '9510306', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('87', '9510308', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('88', '9510312', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('89', '9510314', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('90', '9510316', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('91', '9510318', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('92', '9510322', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('93', '9510324', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('94', '9510326', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('95', '9510328', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('96', '9510342', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('97', '9510344', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('98', '9510346', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('99', '9510348', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('100', '9510332', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('101', '9510334', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('102', '9510336', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('103', '9519004', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('104', '9519002', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('105', '9519006', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('106', '9510382', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('107', '9510384', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('108', '9510386', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('109', '9510388', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('110', '9510362', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('111', '9510364', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('112', '9510366', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('113', '9510368', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('114', '9510422', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('115', '9510424', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('116', '9510426', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('117', '9510428', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('118', '9510442', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('119', '9510444', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('120', '9510446', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('121', '9510448', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('122', '9510412', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('123', '9510414', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('124', '9510416', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('125', '9510418', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('126', '9510432', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('127', '9510436', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('128', '9510438', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('129', '9510434', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('130', '9510372', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('131', '9510374', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('132', '9510376', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('133', '9510378', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('134', '9510352', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('135', '9510354', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('136', '9510356', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('137', '9510358', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('138', '9510452', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('139', '9510454', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('140', '9510456', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('141', '9510458', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('142', '9510462', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('143', '9510464', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('144', '9510466', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('145', '9510468', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('146', '9519032', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('147', '9510472', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('148', '9510474', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('149', '9510476', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('150', '9510478', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('151', '9510512', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('152', '9510514', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('153', '9510516', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('154', '9510518', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('155', '9510482', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('156', '9510484', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('157', '9510486', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('158', '9510488', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('159', '9510492', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('160', '9510494', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('161', '9510496', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('162', '9510498', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('163', '9510502', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('164', '9510504', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('165', '9510506', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('166', '9510508', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('167', '9510532', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('168', '9510534', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('169', '9510536', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('170', '9510538', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('171', '9510542', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('172', '9510544', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('173', '9510546', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('174', '9510548', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('175', '9510552', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('176', '9510554', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('177', '9510556', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('178', '9510558', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('179', '9510562', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('180', '9510564', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('181', '9510566', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('182', '9510568', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('183', '9510572', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('184', '9510574', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('185', '9510576', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('186', '9510578', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('187', '9510582', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('188', '9510584', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('189', '9510586', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('190', '9510588', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('191', '9510522', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('192', '9510524', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('193', '9510526', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('194', '9510528', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('195', '9510612', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('196', '9510614', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('197', '9510616', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('198', '9510618', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('199', '9510652', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('200', '9510654', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('201', '9510656', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('202', '9510658', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('203', '9510672', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('204', '9510674', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('205', '9510676', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('206', '9510678', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('207', '9510662', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('208', '9510664', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('209', '9510666', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('210', '9510668', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('211', '9510682', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('212', '9510684', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('213', '9510686', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('214', '9510688', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('215', '9510702', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('216', '9510692', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('217', '9510694', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('218', '9510696', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('219', '9510698', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('220', '9510602', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('221', '9510604', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('222', '9510606', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('223', '9510608', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('224', '9510632', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('225', '9510634', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('226', '9510636', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('227', '9510638', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('228', '9510642', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('229', '9510644', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('230', '9510646', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('231', '9510648', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('232', '9510592', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('233', '9510594', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('234', '9510596', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('235', '9510598', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('236', '9510622', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('237', '9510624', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('238', '9510626', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('239', '9510628', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('240', '9510732', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('241', '9510734', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('242', '9510722', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('243', '9510724', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('244', '9510802', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('245', '9510804', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('246', '9510806', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('247', '9510808', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('248', '9510782', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('249', '9510784', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('250', '9510786', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('251', '9510788', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('252', '9510792', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('253', '9510794', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('254', '9510796', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('255', '9510798', '129', '129', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('256', '9510772', '129', '129', '-1', '0');

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
) ENGINE=InnoDB AUTO_INCREMENT=86 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of girleyescommodity
-- ----------------------------
INSERT INTO `girleyescommodity` VALUES ('1', '9110012', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('2', '9110022', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('3', '9110032', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('4', '9110042', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('5', '9110052', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('6', '9110062', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('7', '9150012', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('8', '9150122', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('9', '9150232', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('10', '9150342', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('11', '9150052', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('12', '9150062', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('13', '9150082', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('14', '9150092', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('15', '9150102', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('16', '9150112', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('17', '9150072', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('18', '9150132', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('19', '9150142', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('20', '9150152', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('21', '9150162', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('22', '9150172', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('23', '9150182', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('24', '9150192', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('25', '9150202', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('26', '9150212', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('27', '9150222', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('28', '9150242', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('29', '9150252', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('30', '9150262', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('31', '9150272', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('32', '9150282', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('33', '9150292', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('34', '9150302', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('35', '9150312', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('36', '9150322', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('37', '9150332', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('38', '9150352', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('39', '9150362', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('40', '9150372', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('41', '9150382', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('42', '9150392', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('43', '9150402', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('44', '9150412', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('45', '9150422', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('46', '9150472', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('47', '9150482', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('48', '9150492', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('49', '9150502', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('50', '9150512', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('51', '9150522', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('52', '9150532', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('53', '9150542', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('54', '9150672', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('55', '9150682', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('56', '9150692', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('57', '9150702', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('58', '9150712', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('59', '9150722', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('60', '9150732', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('61', '9150742', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('62', '9150552', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('63', '9150562', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('64', '9150572', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('65', '9150582', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('66', '9150592', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('67', '9150602', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('68', '9150612', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('69', '9150622', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('70', '9150632', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('71', '9150642', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('72', '9150652', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('73', '9150662', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('74', '9150832', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('75', '9150842', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('76', '9150852', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('77', '9150862', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('78', '9150792', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('79', '9150802', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('80', '9150812', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('81', '9150822', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('82', '9150872', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('83', '9150882', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('84', '9150892', '29', '29', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('85', '9150902', '29', '29', '-1', '0');

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
) ENGINE=InnoDB AUTO_INCREMENT=125 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of girlhaircommodity
-- ----------------------------
INSERT INTO `girlhaircommodity` VALUES ('1', '9010012', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('2', '9010022', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('3', '9010032', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('4', '9010042', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('5', '9050012', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('6', '9050022', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('7', '9050032', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('8', '9050042', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('9', '9010014', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('10', '9010016', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('11', '9010024', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('12', '9010026', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('13', '9010034', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('14', '9010036', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('15', '9010044', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('16', '9010046', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('17', '9050014', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('18', '9050016', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('19', '9050024', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('20', '9050026', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('21', '9050028', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('22', '9050034', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('23', '9050036', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('24', '9050044', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('25', '9050046', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('26', '9050052', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('27', '9050054', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('28', '9050056', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('29', '9050062', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('30', '9050064', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('31', '9050066', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('32', '9050070', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('33', '9050080', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('34', '9050090', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('35', '9050100', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('36', '9050010', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('37', '9050020', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('38', '9050030', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('39', '9050040', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('40', '9050050', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('41', '9050060', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('42', '9050072', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('43', '9050076', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('44', '9050074', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('45', '9050078', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('46', '9050092', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('47', '9050094', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('48', '9050058', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('49', '9050082', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('50', '9050084', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('51', '9050086', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('52', '9050088', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('53', '9050096', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('54', '9050098', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('55', '9059002', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('56', '9059004', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('57', '9050110', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('58', '9050120', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('59', '9050130', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('60', '9050140', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('61', '9050102', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('62', '9050104', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('63', '9050106', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('64', '9050108', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('65', '9050112', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('66', '9050114', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('67', '9050116', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('68', '9050118', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('69', '9050122', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('70', '9050124', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('71', '9050126', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('72', '9050128', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('73', '9050132', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('74', '9050134', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('75', '9050136', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('76', '9050138', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('77', '9050142', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('78', '9050144', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('79', '9050146', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('80', '9050148', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('81', '9050162', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('82', '9050164', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('83', '9050166', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('84', '9050168', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('85', '9050152', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('86', '9050154', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('87', '9050156', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('88', '9050158', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('89', '9050172', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('90', '9050174', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('91', '9050176', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('92', '9050178', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('93', '9050192', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('94', '9050194', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('95', '9050196', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('96', '9050198', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('97', '9050182', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('98', '9050184', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('99', '9050186', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('100', '9050188', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('101', '9050212', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('102', '9050214', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('103', '9050216', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('104', '9050218', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('105', '9050202', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('106', '9050204', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('107', '9050206', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('108', '9050208', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('109', '9050222', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('110', '9050224', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('111', '9050226', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('112', '9050228', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('113', '9050232', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('114', '9050234', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('115', '9050236', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('116', '9050238', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('117', '9050242', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('118', '9050244', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('119', '9050246', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('120', '9050248', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('121', '9050252', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('122', '9050254', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('123', '9050256', '59', '59', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('124', '9050258', '59', '59', '-1', '0');

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
INSERT INTO `hatcommodity` VALUES ('1', '8610011', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('2', '8610012', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('3', '8610013', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('4', '8610021', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('5', '8610022', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('6', '8610023', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('7', '8610031', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('8', '8610032', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('9', '8610033', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('10', '8610041', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('11', '8610042', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('12', '8610043', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('13', '8610051', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('14', '8610052', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('15', '8610053', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('16', '8610061', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('17', '8610062', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('18', '8610063', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('19', '8610064', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('20', '8610071', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('21', '8610072', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('22', '8610073', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('23', '8610074', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('24', '8610081', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('25', '8610082', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('26', '8610083', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('27', '8610084', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('28', '8610091', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('29', '8610092', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('30', '8610101', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('31', '8610102', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('32', '8610103', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('33', '8610104', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('34', '8610105', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('35', '8610111', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('36', '8610112', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('37', '8610121', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('38', '8610122', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('39', '8610123', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('40', '8610125', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('41', '8610127', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('42', '8610124', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('43', '8610126', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('44', '8610128', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('45', '8610151', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('46', '8610152', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('47', '8610153', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('48', '8610154', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('49', '8610161', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('50', '8610162', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('51', '8610163', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('52', '8610164', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('53', '8610131', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('54', '8610133', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('55', '8610135', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('56', '8610137', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('57', '8610132', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('58', '8610134', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('59', '8610136', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('60', '8610138', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('61', '8610142', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('62', '8610144', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('63', '8610146', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('64', '8610148', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('65', '8610171', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('66', '8610173', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('67', '8610172', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('68', '8610174', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('69', '8610176', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('70', '8610178', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('71', '8610181', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('72', '8610182', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('73', '8610183', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('74', '8610184', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('75', '8610191', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('76', '8610192', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('77', '8610193', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('78', '8610201', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('79', '8610202', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('80', '8610203', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('81', '8610204', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('82', '8610231', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('83', '8610233', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('84', '8610235', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('85', '8610237', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('86', '8610211', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('87', '8610212', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('88', '8610213', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('89', '8610214', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('90', '8610241', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('91', '8610243', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('92', '8610245', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('93', '8610247', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('94', '8610242', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('95', '8610244', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('96', '8610246', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('97', '8610248', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('98', '8610271', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('99', '8610272', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('100', '8610273', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('101', '8610274', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('102', '8610261', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('103', '8610262', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('104', '8610263', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('105', '8610264', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('106', '8610251', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('107', '8610252', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('108', '8610253', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('109', '8610254', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('110', '8610221', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('111', '8610222', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('112', '8610223', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('113', '8610224', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('114', '8610291', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('115', '8610292', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('116', '8610293', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('117', '8610294', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('118', '8610281', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('119', '8610282', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('120', '8610283', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('121', '8610284', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('122', '8610301', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('123', '8610302', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('124', '8610303', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('125', '8610304', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('126', '8610311', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('127', '8610312', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('128', '8610313', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('129', '8610314', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('130', '8610205', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('131', '8610401', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('132', '8610402', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('133', '8610403', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('134', '8610404', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('135', '8610405', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('136', '8610406', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('137', '8610407', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('138', '8610408', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('139', '8611001', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('140', '8611002', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('141', '8610351', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('142', '8610352', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('143', '8610411', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('144', '8610412', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('145', '8610413', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('146', '8610414', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('147', '8610371', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('148', '8610372', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('149', '8610373', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('150', '8610374', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('151', '8610375', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('152', '8610376', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('153', '8610377', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('154', '8610378', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('155', '8610321', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('156', '8610322', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('157', '8610323', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('158', '8610324', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('159', '8610361', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('160', '8610363', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('161', '8610365', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('162', '8610367', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('163', '8610331', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('164', '8610332', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('165', '8610333', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('166', '8610334', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('167', '8610341', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('168', '8610421', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('169', '8610422', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('170', '8610423', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('171', '8610424', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('172', '8610473', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('173', '8610474', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('174', '8610381', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('175', '8610382', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('176', '8610383', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('177', '8610384', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('178', '8610451', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('179', '8610453', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('180', '8610455', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('181', '8610457', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('182', '8610452', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('183', '8610454', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('184', '8610456', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('185', '8610458', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('186', '8610385', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('187', '8610386', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('188', '8610387', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('189', '8610388', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('190', '8610461', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('191', '8610462', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('192', '8610463', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('193', '8610464', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('194', '8610471', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('195', '8610472', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('196', '8610481', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('197', '8610482', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('198', '8610633', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('199', '8610631', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('200', '8610635', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('201', '8610637', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('202', '8610632', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('203', '8610634', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('204', '8610636', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('205', '8610638', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('206', '8610601', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('207', '8610603', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('208', '8610605', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('209', '8610607', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('210', '8610602', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('211', '8610604', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('212', '8610606', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('213', '8610608', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('214', '8610611', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('215', '8610612', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('216', '8610613', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('217', '8610614', '99', '99', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('218', '8610501', '49', '49', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('219', '8610502', '49', '49', '-1', '0');

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
  `level1` int(3) NOT NULL,
  `level2` int(3) NOT NULL,
  `level3` int(3) NOT NULL,
  `level4` int(3) NOT NULL,
  `level5` int(3) NOT NULL,
  `level6` int(3) NOT NULL,
  `level7` int(3) NOT NULL,
  `level8` int(3) NOT NULL,
  `level9` int(3) NOT NULL,
  `level10` int(3) NOT NULL,
  `fusion` int(3) NOT NULL,
  `isLocked` int(1) NOT NULL,
  `icon` int(11) NOT NULL,
  `term` int(11) NOT NULL DEFAULT '-1',
  `type` int(3) NOT NULL,
  `slot` int(3) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2615 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of items
-- ----------------------------
INSERT INTO `items` VALUES ('2601', '40', '8110011', '1', '-1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '1');
INSERT INTO `items` VALUES ('2602', '40', '8510011', '1', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '5');
INSERT INTO `items` VALUES ('2605', '40', '8820011', '9', '-1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '1');
INSERT INTO `items` VALUES ('2606', '40', '8810011', '9', '-1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '0');
INSERT INTO `items` VALUES ('2607', '40', '8010011', '1', '-1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '0');
INSERT INTO `items` VALUES ('2608', '40', '9510021', '1', '-1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '11');
INSERT INTO `items` VALUES ('2609', '40', '8493084', '1', '-1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '4');
INSERT INTO `items` VALUES ('2610', '40', '8950101', '1', '-1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '0');
INSERT INTO `items` VALUES ('2611', '40', '8950503', '1', '-1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '1');
INSERT INTO `items` VALUES ('2613', '40', '8890037', '99', '-1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '2');
INSERT INTO `items` VALUES ('2614', '40', '8910011', '3', '-1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '2');

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
INSERT INTO `keymaps` VALUES ('40', 'Z', '1', '0', '0');
INSERT INTO `keymaps` VALUES ('40', 'X', '4', '0', '3');
INSERT INTO `keymaps` VALUES ('40', 'C', '3', '0', '2');
INSERT INTO `keymaps` VALUES ('40', 'Delete', '8820011', '3', '1');
INSERT INTO `keymaps` VALUES ('40', 'End', '8810011', '3', '0');

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
) ENGINE=InnoDB AUTO_INCREMENT=116 DEFAULT CHARSET=latin1;

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
INSERT INTO `mantlecommodity` VALUES ('24', '8493094', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('25', '8493101', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('26', '8493102', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('27', '8493111', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('28', '8493112', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('29', '8493113', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('30', '8493114', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('31', '8493121', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('32', '8493122', '99', '99', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('33', '8493051', '80', '80', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('34', '8493151', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('35', '8493152', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('36', '8493153', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('37', '8493154', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('38', '8493161', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('39', '8493162', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('40', '8493163', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('41', '8493164', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('42', '8493141', '99', '99', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('43', '8493142', '99', '99', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('44', '8493143', '99', '99', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('45', '8493144', '99', '99', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('46', '8493131', '99', '99', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('47', '8493132', '99', '99', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('48', '8493133', '99', '99', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('49', '8493134', '99', '99', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('50', '8493171', '99', '99', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('51', '8493181', '99', '99', '-1', '0');
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
INSERT INTO `mantlecommodity` VALUES ('79', '8493401', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('80', '8493402', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('81', '8493403', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('82', '8493404', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('83', '8493405', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('84', '8493406', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('85', '8493361', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('86', '8493362', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('87', '8493363', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('88', '8493364', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('89', '8493341', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('90', '8493342', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('91', '8493343', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('92', '8493344', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('93', '8493351', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('94', '8493352', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('95', '8493353', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('96', '8493354', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('97', '8493422', '99', '99', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('98', '8493423', '99', '99', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('99', '8493431', '99', '99', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('100', '8493451', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('101', '8493371', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('102', '8493391', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('103', '8493450', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('104', '8493413', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('105', '8493411', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('106', '8493412', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('107', '8493331', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('108', '8493332', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('109', '8493333', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('110', '8493334', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('111', '8493421', '99', '99', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('112', '8493441', '99', '99', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('113', '8493442', '99', '99', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('114', '8493414', '88', '88', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('115', '8493415', '88', '88', '-1', '0');

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
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of petcommodity
-- ----------------------------
INSERT INTO `petcommodity` VALUES ('1', '9212011', '129', '129', '-1', '0');
INSERT INTO `petcommodity` VALUES ('2', '9212012', '129', '129', '-1', '0');
INSERT INTO `petcommodity` VALUES ('3', '9212013', '129', '129', '-1', '0');
INSERT INTO `petcommodity` VALUES ('4', '9212014', '129', '129', '-1', '0');
INSERT INTO `petcommodity` VALUES ('5', '9212021', '129', '129', '-1', '0');
INSERT INTO `petcommodity` VALUES ('6', '9212022', '129', '129', '-1', '0');
INSERT INTO `petcommodity` VALUES ('7', '9212023', '129', '129', '-1', '0');
INSERT INTO `petcommodity` VALUES ('8', '7820501', '49', '49', '-1', '0');

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
) ENGINE=InnoDB AUTO_INCREMENT=77 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of pets
-- ----------------------------

-- ----------------------------
-- Table structure for `producecommodity`
-- ----------------------------
DROP TABLE IF EXISTS `producecommodity`;
CREATE TABLE `producecommodity` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `itemID` int(11) NOT NULL,
  `price` int(11) NOT NULL,
  `bargainPrice` int(11) NOT NULL,
  `term` int(11) NOT NULL DEFAULT '-1',
  `flag` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=40 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of producecommodity
-- ----------------------------
INSERT INTO `producecommodity` VALUES ('1', '8950101', '49', '49', '-1', '0');
INSERT INTO `producecommodity` VALUES ('2', '8950102', '49', '49', '-1', '0');
INSERT INTO `producecommodity` VALUES ('3', '8950103', '49', '49', '-1', '0');
INSERT INTO `producecommodity` VALUES ('4', '8950104', '49', '49', '-1', '0');
INSERT INTO `producecommodity` VALUES ('5', '8950105', '49', '49', '-1', '0');
INSERT INTO `producecommodity` VALUES ('6', '8950106', '49', '49', '-1', '0');
INSERT INTO `producecommodity` VALUES ('7', '8950107', '49', '49', '-1', '0');
INSERT INTO `producecommodity` VALUES ('8', '8950501', '49', '49', '-1', '0');
INSERT INTO `producecommodity` VALUES ('9', '8950502', '49', '49', '-1', '0');
INSERT INTO `producecommodity` VALUES ('10', '8950503', '49', '49', '-1', '0');
INSERT INTO `producecommodity` VALUES ('11', '8950504', '49', '49', '-1', '0');
INSERT INTO `producecommodity` VALUES ('12', '8950505', '49', '49', '-1', '0');
INSERT INTO `producecommodity` VALUES ('13', '8950506', '49', '49', '-1', '0');
INSERT INTO `producecommodity` VALUES ('14', '8950507', '49', '49', '-1', '0');
INSERT INTO `producecommodity` VALUES ('15', '8950508', '49', '49', '-1', '0');
INSERT INTO `producecommodity` VALUES ('16', '8950509', '49', '49', '-1', '0');
INSERT INTO `producecommodity` VALUES ('17', '8950510', '49', '49', '-1', '0');
INSERT INTO `producecommodity` VALUES ('18', '8950511', '49', '49', '-1', '0');
INSERT INTO `producecommodity` VALUES ('19', '8950512', '49', '49', '-1', '0');
INSERT INTO `producecommodity` VALUES ('20', '8950513', '49', '49', '-1', '0');
INSERT INTO `producecommodity` VALUES ('21', '8950514', '49', '49', '-1', '0');
INSERT INTO `producecommodity` VALUES ('22', '8950515', '49', '49', '-1', '0');
INSERT INTO `producecommodity` VALUES ('23', '8950516', '49', '49', '-1', '0');
INSERT INTO `producecommodity` VALUES ('24', '8950517', '49', '49', '-1', '0');
INSERT INTO `producecommodity` VALUES ('25', '8950518', '49', '49', '-1', '0');
INSERT INTO `producecommodity` VALUES ('26', '8950519', '49', '49', '-1', '0');
INSERT INTO `producecommodity` VALUES ('27', '8950520', '49', '49', '-1', '0');
INSERT INTO `producecommodity` VALUES ('28', '8950521', '49', '49', '-1', '0');
INSERT INTO `producecommodity` VALUES ('29', '8950522', '49', '49', '-1', '0');
INSERT INTO `producecommodity` VALUES ('30', '8950523', '49', '49', '-1', '0');
INSERT INTO `producecommodity` VALUES ('31', '8950524', '49', '49', '-1', '0');
INSERT INTO `producecommodity` VALUES ('32', '8950525', '49', '49', '-1', '0');
INSERT INTO `producecommodity` VALUES ('33', '8950526', '49', '49', '-1', '0');
INSERT INTO `producecommodity` VALUES ('34', '8950527', '49', '49', '-1', '0');
INSERT INTO `producecommodity` VALUES ('35', '8950528', '49', '49', '-1', '0');
INSERT INTO `producecommodity` VALUES ('36', '8950529', '49', '49', '-1', '0');
INSERT INTO `producecommodity` VALUES ('37', '8950530', '49', '49', '-1', '0');
INSERT INTO `producecommodity` VALUES ('38', '8950531', '49', '49', '-1', '0');
INSERT INTO `producecommodity` VALUES ('39', '8950532', '49', '49', '-1', '0');

-- ----------------------------
-- Table structure for `quests`
-- ----------------------------
DROP TABLE IF EXISTS `quests`;
CREATE TABLE `quests` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `cid` int(11) NOT NULL,
  `questId` int(8) NOT NULL,
  `stage` int(3) NOT NULL,
  `completeMonster` int(11) NOT NULL,
  `requireMonster` int(11) NOT NULL,
  `questState` int(3) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=299 DEFAULT CHARSET=latin1;

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
) ENGINE=InnoDB AUTO_INCREMENT=213 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of skills
-- ----------------------------
INSERT INTO `skills` VALUES ('209', '40', '1', '1', '0', '0');
INSERT INTO `skills` VALUES ('210', '40', '2', '1', '0', '1');
INSERT INTO `skills` VALUES ('211', '40', '3', '1', '0', '2');
INSERT INTO `skills` VALUES ('212', '40', '4', '1', '0', '3');

-- ----------------------------
-- Table structure for `storages`
-- ----------------------------
DROP TABLE IF EXISTS `storages`;
CREATE TABLE `storages` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `cid` int(11) NOT NULL,
  `itemID` int(11) NOT NULL,
  `quantity` int(11) NOT NULL,
  `spirit` int(11) NOT NULL,
  `level1` int(3) NOT NULL,
  `level2` int(3) NOT NULL,
  `level3` int(3) NOT NULL,
  `level4` int(3) NOT NULL,
  `level5` int(3) NOT NULL,
  `level6` int(3) NOT NULL,
  `level7` int(3) NOT NULL,
  `level8` int(3) NOT NULL,
  `level9` int(3) NOT NULL,
  `level10` int(3) NOT NULL,
  `fusion` int(3) NOT NULL,
  `isLocked` int(1) NOT NULL,
  `icon` int(11) NOT NULL,
  `term` int(11) NOT NULL,
  `type` int(11) NOT NULL,
  `slot` int(11) NOT NULL,
  `money` int(10) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=73 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of storages
-- ----------------------------
INSERT INTO `storages` VALUES ('72', '40', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0');

-- ----------------------------
-- Table structure for `talismancommodity`
-- ----------------------------
DROP TABLE IF EXISTS `talismancommodity`;
CREATE TABLE `talismancommodity` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `itemID` int(11) NOT NULL,
  `price` int(11) NOT NULL,
  `bargainPrice` int(11) NOT NULL,
  `term` int(11) NOT NULL DEFAULT '-1',
  `flag` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of talismancommodity
-- ----------------------------
INSERT INTO `talismancommodity` VALUES ('1', '8890031', '49', '49', '-1', '0');
INSERT INTO `talismancommodity` VALUES ('2', '8890037', '29', '29', '-1', '0');

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
) ENGINE=InnoDB AUTO_INCREMENT=1423 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of useslot
-- ----------------------------
INSERT INTO `useslot` VALUES ('1421', '40', '3', '255');
INSERT INTO `useslot` VALUES ('1422', '40', '5', '255');
