/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50617
Source Host           : localhost:3306
Source Database       : ghost

Target Server Type    : MYSQL
Target Server Version : 50617
File Encoding         : 65001

Date: 2016-06-17 20:27:17
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
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of accounts
-- ----------------------------
INSERT INTO `accounts` VALUES ('1', 'admin', 'admin', '2015-04-07 21:11:30', '0', '0', '1', '99999999', '10000', '3000');

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
INSERT INTO `boydresscommodity` VALUES ('1', '9510011', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('2', '9510021', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('3', '9510031', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('4', '9510041', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('5', '9510013', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('6', '9510015', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('7', '9510023', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('8', '9510025', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('9', '9510033', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('10', '9510035', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('11', '9510043', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('12', '9510045', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('13', '9510051', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('14', '9510053', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('15', '9510055', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('16', '9510061', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('17', '9510063', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('18', '9510065', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('19', '9510071', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('20', '9510073', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('21', '9510075', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('22', '9510081', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('23', '9510083', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('24', '9510085', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('25', '9510087', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('26', '9510091', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('27', '9510093', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('28', '9510095', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('29', '9510101', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('30', '9510111', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('31', '9510121', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('32', '9510131', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('33', '9510141', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('34', '9510143', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('35', '9510145', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('36', '9510147', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('37', '9510151', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('38', '9510153', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('39', '9510155', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('40', '9510171', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('41', '9510173', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('42', '9510175', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('43', '9510161', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('44', '9510163', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('45', '9510165', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('46', '9510191', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('47', '9510193', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('48', '9510195', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('49', '9510251', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('50', '9510253', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('51', '9510255', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('52', '9510257', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('53', '9510181', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('54', '9510183', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('55', '9510185', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('56', '9510201', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('57', '9510203', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('58', '9510205', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('59', '9510211', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('60', '9510213', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('61', '9510215', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('62', '9510241', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('63', '9510243', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('64', '9510245', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('65', '9510247', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('66', '9510221', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('67', '9510223', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('68', '9510225', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('69', '9510231', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('70', '9510233', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('71', '9510235', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('72', '9510237', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('73', '9510261', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('74', '9510263', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('75', '9510267', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('76', '9510265', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('77', '9510381', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('78', '9510383', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('79', '9510385', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('80', '9510387', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('81', '9510391', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('82', '9510393', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('83', '9510395', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('84', '9510397', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('85', '9510271', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('86', '9510281', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('87', '9510283', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('88', '9510285', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('89', '9510291', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('90', '9510301', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('91', '9510305', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('92', '9510303', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('93', '9510307', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('94', '9510311', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('95', '9510313', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('96', '9510315', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('97', '9510317', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('98', '9510321', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('99', '9510323', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('100', '9510325', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('101', '9510327', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('102', '9510341', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('103', '9510343', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('104', '9510345', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('105', '9510347', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('106', '9510331', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('107', '9510333', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('108', '9510335', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('109', '9519001', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('110', '9519005', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('111', '9519003', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('112', '9510371', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('113', '9510373', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('114', '9510375', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('115', '9510377', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('116', '9510351', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('117', '9510353', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('118', '9510355', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('119', '9510357', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('120', '9510411', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('121', '9510413', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('122', '9510415', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('123', '9510417', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('124', '9510431', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('125', '9510433', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('126', '9510435', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('127', '9510437', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('128', '9510401', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('129', '9510403', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('130', '9510405', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('131', '9510407', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('132', '9510421', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('133', '9510425', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('134', '9510427', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('135', '9510423', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('136', '9510361', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('137', '9510363', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('138', '9510365', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('139', '9510367', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('140', '9510441', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('141', '9510443', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('142', '9510445', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('143', '9510447', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('144', '9510451', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('145', '9510453', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('146', '9510455', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('147', '9510457', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('148', '9519031', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('149', '9510461', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('150', '9510463', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('151', '9510465', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('152', '9510467', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('153', '9510501', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('154', '9510503', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('155', '9510505', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('156', '9510507', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('157', '9510471', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('158', '9510473', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('159', '9510475', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('160', '9510477', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('161', '9510481', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('162', '9510483', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('163', '9510485', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('164', '9510487', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('165', '9510491', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('166', '9510493', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('167', '9510495', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('168', '9510497', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('169', '9510521', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('170', '9510523', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('171', '9510525', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('172', '9510527', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('173', '9510531', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('174', '9510533', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('175', '9510535', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('176', '9510537', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('177', '9510541', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('178', '9510543', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('179', '9510545', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('180', '9510547', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('181', '9510551', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('182', '9510553', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('183', '9510555', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('184', '9510557', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('185', '9510561', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('186', '9510563', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('187', '9510565', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('188', '9510567', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('189', '9510571', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('190', '9510573', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('191', '9510575', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('192', '9510577', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('193', '9510511', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('194', '9510513', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('195', '9510515', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('196', '9510517', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('197', '9510591', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('198', '9510593', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('199', '9510595', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('200', '9510597', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('201', '9510631', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('202', '9510633', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('203', '9510635', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('204', '9510637', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('205', '9510651', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('206', '9510653', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('207', '9510655', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('208', '9510657', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('209', '9510641', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('210', '9510643', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('211', '9510645', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('212', '9510647', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('213', '9510661', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('214', '9510663', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('215', '9510665', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('216', '9510667', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('217', '9510681', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('218', '9510671', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('219', '9510673', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('220', '9510675', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('221', '9510677', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('222', '9510581', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('223', '9510583', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('224', '9510585', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('225', '9510587', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('226', '9510611', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('227', '9510613', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('228', '9510615', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('229', '9510617', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('230', '9510621', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('231', '9510623', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('232', '9510625', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('233', '9510627', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('234', '9510601', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('235', '9510603', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('236', '9510605', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('237', '9510607', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('238', '9510801', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('239', '9510803', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('240', '9510791', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('241', '9510793', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('242', '9510871', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('243', '9510873', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('244', '9510875', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('245', '9510877', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('246', '9510851', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('247', '9510853', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('248', '9510855', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('249', '9510857', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('250', '9510861', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('251', '9510863', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('252', '9510865', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('253', '9510867', '100', '100', '-1', '0');
INSERT INTO `boydresscommodity` VALUES ('254', '9510841', '100', '100', '-1', '0');

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
INSERT INTO `boyeyescommodity` VALUES ('1', '9110011', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('2', '9110021', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('3', '9110031', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('4', '9110041', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('5', '9110051', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('6', '9110061', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('7', '9150011', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('8', '9150121', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('9', '9150231', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('10', '9150341', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('11', '9150051', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('12', '9150061', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('13', '9150081', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('14', '9150091', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('15', '9150101', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('16', '9150111', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('17', '9150071', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('18', '9150131', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('19', '9150141', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('20', '9150151', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('21', '9150161', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('22', '9150171', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('23', '9150181', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('24', '9150191', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('25', '9150201', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('26', '9150211', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('27', '9150221', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('28', '9150241', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('29', '9150251', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('30', '9150261', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('31', '9150271', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('32', '9150281', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('33', '9150291', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('34', '9150301', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('35', '9150311', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('36', '9150321', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('37', '9150331', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('38', '9150351', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('39', '9150361', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('40', '9150371', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('41', '9150381', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('42', '9150431', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('43', '9150441', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('44', '9150451', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('45', '9150461', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('46', '9150471', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('47', '9150481', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('48', '9150491', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('49', '9150501', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('50', '9150631', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('51', '9150641', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('52', '9150651', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('53', '9150661', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('54', '9150671', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('55', '9150681', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('56', '9150691', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('57', '9150701', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('58', '9150511', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('59', '9150521', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('60', '9150531', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('61', '9150541', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('62', '9150551', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('63', '9150561', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('64', '9150571', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('65', '9150581', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('66', '9150591', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('67', '9150601', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('68', '9150611', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('69', '9150621', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('70', '9150791', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('71', '9150801', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('72', '9150811', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('73', '9150821', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('74', '9150751', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('75', '9150761', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('76', '9150771', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('77', '9150781', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('78', '9150831', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('79', '9150841', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('80', '9150851', '100', '100', '-1', '0');
INSERT INTO `boyeyescommodity` VALUES ('81', '9150861', '100', '100', '-1', '0');

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
INSERT INTO `boyhaircommodity` VALUES ('1', '9010011', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('2', '9010021', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('3', '9010031', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('4', '9010041', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('5', '9050011', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('6', '9050021', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('7', '9050031', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('8', '9050041', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('9', '9010013', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('10', '9010015', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('11', '9010023', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('12', '9010025', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('13', '9010033', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('14', '9010035', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('15', '9010043', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('16', '9010045', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('17', '9050013', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('18', '9050015', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('19', '9050023', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('20', '9050025', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('21', '9050033', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('22', '9050035', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('23', '9050037', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('24', '9050043', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('25', '9050045', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('26', '9050051', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('27', '9050053', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('28', '9050055', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('29', '9050091', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('30', '9050093', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('31', '9050061', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('32', '9050063', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('33', '9050065', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('34', '9050067', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('35', '9050069', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('36', '9050073', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('37', '9050075', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('38', '9050077', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('39', '9050081', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('40', '9050083', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('41', '9050085', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('42', '9050087', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('43', '9059001', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('44', '9059003', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('45', '9050095', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('46', '9050097', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('47', '9050101', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('48', '9050103', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('49', '9050105', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('50', '9050107', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('51', '9050123', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('52', '9050125', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('53', '9050127', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('54', '9050131', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('55', '9050133', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('56', '9050135', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('57', '9050137', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('58', '9050141', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('59', '9050143', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('60', '9050145', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('61', '9050147', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('62', '9050151', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('63', '9050153', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('64', '9050155', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('65', '9050157', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('66', '9050161', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('67', '9050163', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('68', '9050165', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('69', '9050167', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('70', '9050171', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('71', '9050173', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('72', '9050175', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('73', '9050177', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('74', '9050181', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('75', '9050183', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('76', '9050185', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('77', '9050187', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('78', '9050201', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('79', '9050203', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('80', '9050205', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('81', '9050207', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('82', '9050191', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('83', '9050193', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('84', '9050195', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('85', '9050197', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('86', '9050211', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('87', '9050213', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('88', '9050215', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('89', '9050217', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('90', '9050221', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('91', '9050223', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('92', '9050225', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('93', '9050227', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('94', '9050231', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('95', '9050233', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('96', '9050235', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('97', '9050237', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('98', '9050241', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('99', '9050243', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('100', '9050245', '100', '100', '-1', '0');
INSERT INTO `boyhaircommodity` VALUES ('101', '9050247', '100', '100', '-1', '0');

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
) ENGINE=InnoDB AUTO_INCREMENT=73 DEFAULT CHARSET=latin1;

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
INSERT INTO `face1commodity` VALUES ('1', '8710013', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('2', '8710023', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('3', '8710033', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('4', '8710043', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('5', '8710053', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('6', '8710063', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('7', '8710073', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('8', '8710083', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('9', '8710093', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('10', '8710103', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('11', '8710113', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('12', '8710123', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('13', '8710133', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('14', '8710143', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('15', '8710153', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('16', '8710183', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('17', '8710163', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('18', '8710173', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('19', '8710203', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('20', '8710193', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('21', '8710213', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('22', '8710233', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('23', '8710243', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('24', '8710253', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('25', '8710263', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('26', '8710273', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('27', '8710283', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('28', '8710293', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('29', '8710303', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('30', '8710313', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('31', '8710323', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('32', '8710333', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('33', '8710343', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('34', '8710353', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('35', '8710363', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('36', '8710373', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('37', '8710223', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('38', '8710383', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('39', '8710393', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('40', '8710403', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('41', '8710413', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('42', '8710423', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('43', '8710433', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('44', '8710443', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('45', '8710453', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('46', '8710463', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('47', '8710473', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('48', '8710483', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('49', '8710493', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('50', '8710503', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('51', '8710513', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('52', '8710523', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('53', '8710573', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('54', '8710583', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('55', '8710593', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('56', '8710603', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('57', '8710613', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('58', '8710533', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('59', '8710543', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('60', '8710553', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('61', '8710563', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('62', '8710623', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('63', '8710633', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('64', '8710643', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('65', '8710653', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('66', '8710703', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('67', '8710713', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('68', '8710723', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('69', '8710733', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('70', '8710663', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('71', '8710673', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('72', '8710683', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('73', '8710693', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('74', '8710741', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('75', '8710742', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('76', '8710743', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('77', '8710751', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('78', '8710752', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('79', '8710753', '100', '100', '-1', '0');
INSERT INTO `face1commodity` VALUES ('80', '8710763', '100', '100', '-1', '0');

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
INSERT INTO `face2commodity` VALUES ('1', '9410011', '100', '100', '-1', '0');
INSERT INTO `face2commodity` VALUES ('2', '9410021', '100', '100', '-1', '0');
INSERT INTO `face2commodity` VALUES ('3', '9410053', '100', '100', '-1', '0');
INSERT INTO `face2commodity` VALUES ('4', '9410063', '100', '100', '-1', '0');
INSERT INTO `face2commodity` VALUES ('5', '9410013', '100', '100', '-1', '0');
INSERT INTO `face2commodity` VALUES ('6', '9410023', '100', '100', '-1', '0');
INSERT INTO `face2commodity` VALUES ('7', '9410033', '100', '100', '-1', '0');
INSERT INTO `face2commodity` VALUES ('8', '9410043', '100', '100', '-1', '0');
INSERT INTO `face2commodity` VALUES ('9', '9410073', '100', '100', '-1', '0');
INSERT INTO `face2commodity` VALUES ('10', '9410083', '100', '100', '-1', '0');
INSERT INTO `face2commodity` VALUES ('11', '9410093', '100', '100', '-1', '0');
INSERT INTO `face2commodity` VALUES ('12', '9410103', '100', '100', '-1', '0');
INSERT INTO `face2commodity` VALUES ('13', '9410113', '100', '100', '-1', '0');
INSERT INTO `face2commodity` VALUES ('14', '9410123', '100', '100', '-1', '0');
INSERT INTO `face2commodity` VALUES ('15', '9410133', '100', '100', '-1', '0');
INSERT INTO `face2commodity` VALUES ('16', '9410143', '100', '100', '-1', '0');
INSERT INTO `face2commodity` VALUES ('17', '9410153', '100', '100', '-1', '0');
INSERT INTO `face2commodity` VALUES ('18', '9410163', '100', '100', '-1', '0');
INSERT INTO `face2commodity` VALUES ('19', '9410173', '100', '100', '-1', '0');
INSERT INTO `face2commodity` VALUES ('20', '9410183', '100', '100', '-1', '0');
INSERT INTO `face2commodity` VALUES ('21', '9410193', '100', '100', '-1', '0');
INSERT INTO `face2commodity` VALUES ('22', '9410203', '100', '100', '-1', '0');
INSERT INTO `face2commodity` VALUES ('23', '9410223', '100', '100', '-1', '0');
INSERT INTO `face2commodity` VALUES ('24', '9410213', '100', '100', '-1', '0');
INSERT INTO `face2commodity` VALUES ('25', '9410233', '100', '100', '-1', '0');
INSERT INTO `face2commodity` VALUES ('26', '9410243', '100', '100', '-1', '0');
INSERT INTO `face2commodity` VALUES ('27', '9410253', '100', '100', '-1', '0');
INSERT INTO `face2commodity` VALUES ('28', '9410263', '100', '100', '-1', '0');
INSERT INTO `face2commodity` VALUES ('29', '9410353', '100', '100', '-1', '0');
INSERT INTO `face2commodity` VALUES ('30', '9410363', '100', '100', '-1', '0');
INSERT INTO `face2commodity` VALUES ('31', '9410373', '100', '100', '-1', '0');
INSERT INTO `face2commodity` VALUES ('32', '9410383', '100', '100', '-1', '0');
INSERT INTO `face2commodity` VALUES ('33', '9410273', '100', '100', '-1', '0');
INSERT INTO `face2commodity` VALUES ('34', '9410283', '100', '100', '-1', '0');
INSERT INTO `face2commodity` VALUES ('35', '9410293', '100', '100', '-1', '0');
INSERT INTO `face2commodity` VALUES ('36', '9410313', '100', '100', '-1', '0');
INSERT INTO `face2commodity` VALUES ('37', '9410323', '100', '100', '-1', '0');
INSERT INTO `face2commodity` VALUES ('38', '9410333', '100', '100', '-1', '0');
INSERT INTO `face2commodity` VALUES ('39', '9410343', '100', '100', '-1', '0');
INSERT INTO `face2commodity` VALUES ('40', '9410473', '100', '100', '-1', '0');
INSERT INTO `face2commodity` VALUES ('41', '9410483', '100', '100', '-1', '0');
INSERT INTO `face2commodity` VALUES ('42', '9410493', '100', '100', '-1', '0');
INSERT INTO `face2commodity` VALUES ('43', '9410503', '100', '100', '-1', '0');
INSERT INTO `face2commodity` VALUES ('44', '9410513', '100', '100', '-1', '0');
INSERT INTO `face2commodity` VALUES ('45', '9410523', '100', '100', '-1', '0');
INSERT INTO `face2commodity` VALUES ('46', '9410533', '100', '100', '-1', '0');
INSERT INTO `face2commodity` VALUES ('47', '9410543', '100', '100', '-1', '0');
INSERT INTO `face2commodity` VALUES ('48', '9410433', '100', '100', '-1', '0');
INSERT INTO `face2commodity` VALUES ('49', '9410443', '100', '100', '-1', '0');
INSERT INTO `face2commodity` VALUES ('50', '9410453', '100', '100', '-1', '0');
INSERT INTO `face2commodity` VALUES ('51', '9410463', '100', '100', '-1', '0');
INSERT INTO `face2commodity` VALUES ('52', '9410553', '100', '100', '-1', '0');
INSERT INTO `face2commodity` VALUES ('53', '9410563', '100', '100', '-1', '0');
INSERT INTO `face2commodity` VALUES ('54', '9410393', '100', '100', '-1', '0');
INSERT INTO `face2commodity` VALUES ('55', '9410403', '100', '100', '-1', '0');
INSERT INTO `face2commodity` VALUES ('56', '9410413', '100', '100', '-1', '0');
INSERT INTO `face2commodity` VALUES ('57', '9410423', '100', '100', '-1', '0');
INSERT INTO `face2commodity` VALUES ('58', '9410573', '100', '100', '-1', '0');

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
INSERT INTO `girldresscommodity` VALUES ('1', '9510012', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('2', '9510032', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('3', '9510022', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('4', '9510042', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('5', '9510014', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('6', '9510016', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('7', '9510034', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('8', '9510036', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('9', '9510024', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('10', '9510026', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('11', '9510044', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('12', '9510046', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('13', '9510052', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('14', '9510054', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('15', '9510056', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('16', '9510062', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('17', '9510064', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('18', '9510066', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('19', '9510082', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('20', '9510084', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('21', '9510086', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('22', '9510088', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('23', '9510102', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('24', '9510112', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('25', '9510122', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('26', '9510132', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('27', '9510142', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('28', '9510144', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('29', '9510146', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('30', '9510148', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('31', '9510152', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('32', '9510154', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('33', '9510156', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('34', '9510172', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('35', '9510174', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('36', '9510176', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('37', '9510162', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('38', '9510164', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('39', '9510166', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('40', '9510192', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('41', '9510194', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('42', '9510196', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('43', '9510252', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('44', '9510254', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('45', '9510256', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('46', '9510258', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('47', '9510182', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('48', '9510184', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('49', '9510186', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('50', '9510202', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('51', '9510204', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('52', '9510206', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('53', '9510212', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('54', '9510214', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('55', '9510216', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('56', '9510242', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('57', '9510244', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('58', '9510246', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('59', '9510248', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('60', '9510222', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('61', '9510224', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('62', '9510226', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('63', '9510232', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('64', '9510234', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('65', '9510236', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('66', '9510238', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('67', '9510262', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('68', '9510264', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('69', '9510266', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('70', '9510268', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('71', '9510392', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('72', '9510394', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('73', '9510396', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('74', '9510398', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('75', '9510402', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('76', '9510404', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('77', '9510406', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('78', '9510408', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('79', '9510272', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('80', '9510282', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('81', '9510284', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('82', '9510286', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('83', '9510292', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('84', '9510302', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('85', '9510304', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('86', '9510306', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('87', '9510308', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('88', '9510312', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('89', '9510314', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('90', '9510316', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('91', '9510318', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('92', '9510322', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('93', '9510324', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('94', '9510326', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('95', '9510328', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('96', '9510342', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('97', '9510344', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('98', '9510346', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('99', '9510348', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('100', '9510332', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('101', '9510334', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('102', '9510336', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('103', '9519004', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('104', '9519002', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('105', '9519006', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('106', '9510382', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('107', '9510384', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('108', '9510386', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('109', '9510388', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('110', '9510362', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('111', '9510364', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('112', '9510366', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('113', '9510368', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('114', '9510422', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('115', '9510424', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('116', '9510426', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('117', '9510428', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('118', '9510442', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('119', '9510444', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('120', '9510446', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('121', '9510448', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('122', '9510412', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('123', '9510414', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('124', '9510416', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('125', '9510418', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('126', '9510432', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('127', '9510436', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('128', '9510438', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('129', '9510434', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('130', '9510372', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('131', '9510374', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('132', '9510376', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('133', '9510378', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('134', '9510352', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('135', '9510354', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('136', '9510356', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('137', '9510358', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('138', '9510452', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('139', '9510454', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('140', '9510456', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('141', '9510458', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('142', '9510462', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('143', '9510464', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('144', '9510466', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('145', '9510468', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('146', '9519032', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('147', '9510472', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('148', '9510474', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('149', '9510476', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('150', '9510478', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('151', '9510512', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('152', '9510514', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('153', '9510516', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('154', '9510518', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('155', '9510482', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('156', '9510484', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('157', '9510486', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('158', '9510488', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('159', '9510492', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('160', '9510494', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('161', '9510496', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('162', '9510498', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('163', '9510502', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('164', '9510504', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('165', '9510506', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('166', '9510508', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('167', '9510532', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('168', '9510534', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('169', '9510536', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('170', '9510538', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('171', '9510542', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('172', '9510544', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('173', '9510546', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('174', '9510548', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('175', '9510552', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('176', '9510554', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('177', '9510556', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('178', '9510558', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('179', '9510562', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('180', '9510564', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('181', '9510566', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('182', '9510568', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('183', '9510572', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('184', '9510574', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('185', '9510576', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('186', '9510578', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('187', '9510582', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('188', '9510584', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('189', '9510586', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('190', '9510588', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('191', '9510522', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('192', '9510524', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('193', '9510526', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('194', '9510528', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('195', '9510612', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('196', '9510614', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('197', '9510616', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('198', '9510618', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('199', '9510652', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('200', '9510654', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('201', '9510656', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('202', '9510658', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('203', '9510672', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('204', '9510674', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('205', '9510676', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('206', '9510678', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('207', '9510662', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('208', '9510664', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('209', '9510666', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('210', '9510668', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('211', '9510682', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('212', '9510684', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('213', '9510686', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('214', '9510688', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('215', '9510702', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('216', '9510692', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('217', '9510694', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('218', '9510696', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('219', '9510698', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('220', '9510602', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('221', '9510604', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('222', '9510606', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('223', '9510608', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('224', '9510632', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('225', '9510634', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('226', '9510636', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('227', '9510638', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('228', '9510642', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('229', '9510644', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('230', '9510646', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('231', '9510648', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('232', '9510592', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('233', '9510594', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('234', '9510596', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('235', '9510598', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('236', '9510622', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('237', '9510624', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('238', '9510626', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('239', '9510628', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('240', '9510732', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('241', '9510734', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('242', '9510722', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('243', '9510724', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('244', '9510802', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('245', '9510804', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('246', '9510806', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('247', '9510808', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('248', '9510782', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('249', '9510784', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('250', '9510786', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('251', '9510788', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('252', '9510792', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('253', '9510794', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('254', '9510796', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('255', '9510798', '100', '100', '-1', '0');
INSERT INTO `girldresscommodity` VALUES ('256', '9510772', '100', '100', '-1', '0');

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
INSERT INTO `girleyescommodity` VALUES ('1', '9110012', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('2', '9110022', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('3', '9110032', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('4', '9110042', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('5', '9110052', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('6', '9110062', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('7', '9150012', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('8', '9150122', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('9', '9150232', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('10', '9150342', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('11', '9150052', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('12', '9150062', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('13', '9150082', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('14', '9150092', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('15', '9150102', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('16', '9150112', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('17', '9150072', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('18', '9150132', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('19', '9150142', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('20', '9150152', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('21', '9150162', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('22', '9150172', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('23', '9150182', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('24', '9150192', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('25', '9150202', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('26', '9150212', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('27', '9150222', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('28', '9150242', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('29', '9150252', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('30', '9150262', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('31', '9150272', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('32', '9150282', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('33', '9150292', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('34', '9150302', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('35', '9150312', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('36', '9150322', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('37', '9150332', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('38', '9150352', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('39', '9150362', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('40', '9150372', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('41', '9150382', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('42', '9150392', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('43', '9150402', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('44', '9150412', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('45', '9150422', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('46', '9150472', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('47', '9150482', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('48', '9150492', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('49', '9150502', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('50', '9150512', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('51', '9150522', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('52', '9150532', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('53', '9150542', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('54', '9150672', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('55', '9150682', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('56', '9150692', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('57', '9150702', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('58', '9150712', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('59', '9150722', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('60', '9150732', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('61', '9150742', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('62', '9150552', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('63', '9150562', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('64', '9150572', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('65', '9150582', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('66', '9150592', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('67', '9150602', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('68', '9150612', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('69', '9150622', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('70', '9150632', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('71', '9150642', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('72', '9150652', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('73', '9150662', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('74', '9150832', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('75', '9150842', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('76', '9150852', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('77', '9150862', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('78', '9150792', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('79', '9150802', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('80', '9150812', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('81', '9150822', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('82', '9150872', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('83', '9150882', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('84', '9150892', '100', '100', '-1', '0');
INSERT INTO `girleyescommodity` VALUES ('85', '9150902', '100', '100', '-1', '0');

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
INSERT INTO `girlhaircommodity` VALUES ('1', '9010012', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('2', '9010022', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('3', '9010032', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('4', '9010042', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('5', '9050012', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('6', '9050022', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('7', '9050032', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('8', '9050042', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('9', '9010014', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('10', '9010016', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('11', '9010024', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('12', '9010026', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('13', '9010034', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('14', '9010036', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('15', '9010044', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('16', '9010046', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('17', '9050014', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('18', '9050016', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('19', '9050024', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('20', '9050026', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('21', '9050028', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('22', '9050034', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('23', '9050036', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('24', '9050044', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('25', '9050046', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('26', '9050052', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('27', '9050054', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('28', '9050056', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('29', '9050062', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('30', '9050064', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('31', '9050066', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('32', '9050070', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('33', '9050080', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('34', '9050090', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('35', '9050100', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('36', '9050010', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('37', '9050020', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('38', '9050030', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('39', '9050040', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('40', '9050050', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('41', '9050060', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('42', '9050072', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('43', '9050076', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('44', '9050074', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('45', '9050078', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('46', '9050092', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('47', '9050094', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('48', '9050058', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('49', '9050082', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('50', '9050084', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('51', '9050086', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('52', '9050088', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('53', '9050096', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('54', '9050098', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('55', '9059002', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('56', '9059004', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('57', '9050110', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('58', '9050120', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('59', '9050130', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('60', '9050140', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('61', '9050102', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('62', '9050104', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('63', '9050106', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('64', '9050108', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('65', '9050112', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('66', '9050114', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('67', '9050116', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('68', '9050118', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('69', '9050122', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('70', '9050124', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('71', '9050126', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('72', '9050128', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('73', '9050132', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('74', '9050134', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('75', '9050136', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('76', '9050138', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('77', '9050142', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('78', '9050144', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('79', '9050146', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('80', '9050148', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('81', '9050162', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('82', '9050164', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('83', '9050166', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('84', '9050168', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('85', '9050152', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('86', '9050154', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('87', '9050156', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('88', '9050158', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('89', '9050172', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('90', '9050174', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('91', '9050176', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('92', '9050178', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('93', '9050192', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('94', '9050194', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('95', '9050196', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('96', '9050198', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('97', '9050182', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('98', '9050184', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('99', '9050186', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('100', '9050188', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('101', '9050212', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('102', '9050214', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('103', '9050216', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('104', '9050218', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('105', '9050202', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('106', '9050204', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('107', '9050206', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('108', '9050208', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('109', '9050222', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('110', '9050224', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('111', '9050226', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('112', '9050228', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('113', '9050232', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('114', '9050234', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('115', '9050236', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('116', '9050238', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('117', '9050242', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('118', '9050244', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('119', '9050246', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('120', '9050248', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('121', '9050252', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('122', '9050254', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('123', '9050256', '100', '100', '-1', '0');
INSERT INTO `girlhaircommodity` VALUES ('124', '9050258', '100', '100', '-1', '0');

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
) ENGINE=InnoDB AUTO_INCREMENT=233 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of hatcommodity
-- ----------------------------
INSERT INTO `hatcommodity` VALUES ('1', '8610011', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('2', '8610011', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('3', '8610012', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('4', '8610013', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('5', '8610021', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('6', '8610022', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('7', '8610023', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('8', '8610031', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('9', '8610032', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('10', '8610033', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('11', '8610041', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('12', '8610042', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('13', '8610043', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('14', '8610051', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('15', '8610052', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('16', '8610053', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('17', '8610061', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('18', '8610062', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('19', '8610063', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('20', '8610064', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('21', '8610071', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('22', '8610072', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('23', '8610073', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('24', '8610074', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('25', '8610081', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('26', '8610082', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('27', '8610083', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('28', '8610084', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('29', '8610091', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('30', '8610092', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('31', '8610101', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('32', '8610102', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('33', '8610103', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('34', '8610104', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('35', '8610105', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('36', '8610111', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('37', '8610112', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('38', '8610121', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('39', '8610122', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('40', '8610123', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('41', '8610125', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('42', '8610127', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('43', '8610124', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('44', '8610126', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('45', '8610128', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('46', '8610151', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('47', '8610152', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('48', '8610153', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('49', '8610154', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('50', '8610161', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('51', '8610162', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('52', '8610163', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('53', '8610164', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('54', '8610131', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('55', '8610133', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('56', '8610135', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('57', '8610137', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('58', '8610132', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('59', '8610134', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('60', '8610136', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('61', '8610138', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('62', '8610142', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('63', '8610144', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('64', '8610146', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('65', '8610148', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('66', '8610171', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('67', '8610173', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('68', '8610172', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('69', '8610174', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('70', '8610176', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('71', '8610178', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('72', '8610181', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('73', '8610182', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('74', '8610183', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('75', '8610184', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('76', '8610191', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('77', '8610192', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('78', '8610193', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('79', '8610201', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('80', '8610202', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('81', '8610203', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('82', '8610204', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('83', '8610231', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('84', '8610233', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('85', '8610235', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('86', '8610237', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('87', '8610211', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('88', '8610212', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('89', '8610213', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('90', '8610214', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('91', '8610241', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('92', '8610243', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('93', '8610245', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('94', '8610247', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('95', '8610242', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('96', '8610244', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('97', '8610246', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('98', '8610248', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('99', '8610271', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('100', '8610272', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('101', '8610273', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('102', '8610274', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('103', '8610261', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('104', '8610262', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('105', '8610263', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('106', '8610264', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('107', '8610251', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('108', '8610252', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('109', '8610253', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('110', '8610254', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('111', '8610221', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('112', '8610222', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('113', '8610223', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('114', '8610224', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('115', '8610291', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('116', '8610292', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('117', '8610293', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('118', '8610294', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('119', '8610281', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('120', '8610282', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('121', '8610283', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('122', '8610284', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('123', '8610301', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('124', '8610302', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('125', '8610303', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('126', '8610304', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('127', '8610311', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('128', '8610312', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('129', '8610313', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('130', '8610314', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('131', '8610205', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('132', '8610401', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('133', '8610402', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('134', '8610403', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('135', '8610404', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('136', '8610405', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('137', '8610406', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('138', '8610407', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('139', '8610408', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('140', '8611001', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('141', '8611002', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('142', '8610351', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('143', '8610352', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('144', '8610411', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('145', '8610412', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('146', '8610413', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('147', '8610414', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('148', '8610371', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('149', '8610372', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('150', '8610373', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('151', '8610374', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('152', '8610375', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('153', '8610376', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('154', '8610377', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('155', '8610378', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('156', '8610321', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('157', '8610322', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('158', '8610323', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('159', '8610324', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('160', '8610361', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('161', '8610363', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('162', '8610365', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('163', '8610367', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('164', '8610331', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('165', '8610332', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('166', '8610333', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('167', '8610334', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('168', '8610341', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('169', '8610431', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('170', '8610432', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('171', '8610433', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('172', '8610434', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('173', '8610441', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('174', '8610442', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('175', '8610443', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('176', '8610444', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('177', '8610445', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('178', '8610446', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('179', '8610447', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('180', '8610448', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('181', '8610421', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('182', '8610422', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('183', '8610423', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('184', '8610424', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('185', '8610473', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('186', '8610474', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('187', '8610381', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('188', '8610382', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('189', '8610383', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('190', '8610384', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('191', '8610451', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('192', '8610453', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('193', '8610455', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('194', '8610457', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('195', '8610452', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('196', '8610454', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('197', '8610456', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('198', '8610458', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('199', '8610385', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('200', '8610386', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('201', '8610387', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('202', '8610388', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('203', '8610461', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('204', '8610462', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('205', '8610463', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('206', '8610464', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('207', '8610471', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('208', '8610472', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('209', '8610481', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('210', '8610482', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('211', '8610633', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('212', '8610631', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('213', '8610635', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('214', '8610637', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('215', '8610632', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('216', '8610634', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('217', '8610636', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('218', '8610638', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('219', '8610601', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('220', '8610603', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('221', '8610605', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('222', '8610607', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('223', '8610602', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('224', '8610604', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('225', '8610606', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('226', '8610608', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('227', '8610611', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('228', '8610612', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('229', '8610613', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('230', '8610614', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('231', '8610501', '100', '100', '-1', '0');
INSERT INTO `hatcommodity` VALUES ('232', '8610502', '100', '100', '-1', '0');

-- ----------------------------
-- Table structure for `items`
-- ----------------------------
DROP TABLE IF EXISTS `items`;
CREATE TABLE `items` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `cid` int(11) NOT NULL,
  `itemId` int(8) NOT NULL,
  `quantity` int(3) NOT NULL,
  `isLocked` int(1) NOT NULL,
  `icon` int(11) NOT NULL,
  `term` int(11) NOT NULL DEFAULT '-1',
  `type` int(3) NOT NULL,
  `slot` int(3) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=630 DEFAULT CHARSET=latin1;

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
) ENGINE=InnoDB AUTO_INCREMENT=141 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of mantlecommodity
-- ----------------------------
INSERT INTO `mantlecommodity` VALUES ('1', '8493011', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('2', '8493012', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('3', '8493013', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('4', '8493021', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('5', '8493022', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('6', '8493023', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('7', '8493031', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('8', '8493032', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('9', '8493041', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('10', '8493042', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('11', '8493043', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('12', '8493052', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('13', '8493081', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('14', '8493082', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('15', '8493083', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('16', '8493084', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('17', '8493085', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('18', '8493086', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('19', '8493087', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('20', '8493088', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('21', '8493089', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('22', '8493061', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('23', '8493062', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('24', '8493063', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('25', '8493071', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('26', '8493072', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('27', '8493073', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('28', '8493090', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('29', '8493091', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('30', '8493092', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('31', '8493094', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('32', '8493101', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('33', '8493102', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('34', '8493111', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('35', '8493112', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('36', '8493113', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('37', '8493114', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('38', '8493121', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('39', '8493122', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('40', '8493051', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('41', '8493151', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('42', '8493152', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('43', '8493153', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('44', '8493154', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('45', '8493161', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('46', '8493162', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('47', '8493163', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('48', '8493164', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('49', '8493141', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('50', '8493142', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('51', '8493143', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('52', '8493144', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('53', '8493131', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('54', '8493132', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('55', '8493133', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('56', '8493134', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('57', '8493171', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('58', '8493181', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('59', '8493194', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('60', '8493191', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('61', '8493192', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('62', '8493193', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('63', '8493201', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('64', '8493202', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('65', '8493203', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('66', '8493204', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('67', '8493231', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('68', '8493232', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('69', '8493233', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('70', '8493241', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('71', '8493242', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('72', '8493243', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('73', '8493251', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('74', '8493252', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('75', '8493253', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('76', '8493261', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('77', '8493262', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('78', '8493263', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('79', '8493264', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('80', '8493271', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('81', '8493272', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('82', '8493273', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('83', '8493274', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('84', '8493291', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('85', '8493292', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('86', '8493293', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('87', '8493294', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('88', '8493281', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('89', '8493282', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('90', '8493283', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('91', '8493284', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('92', '8493301', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('93', '8493302', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('94', '8493303', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('95', '8493304', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('96', '8493501', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('97', '8493401', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('98', '8493402', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('99', '8493403', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('100', '8493404', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('101', '8493405', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('102', '8493406', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('103', '8493502', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('104', '8493503', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('105', '8493505', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('106', '8493506', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('107', '8493507', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('108', '8493508', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('109', '8493509', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('110', '8493361', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('111', '8493362', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('112', '8493363', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('113', '8493364', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('114', '8493341', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('115', '8493342', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('116', '8493343', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('117', '8493344', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('118', '8493351', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('119', '8493352', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('120', '8493353', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('121', '8493354', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('122', '8493422', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('123', '8493423', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('124', '8493431', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('125', '8493451', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('126', '8493371', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('127', '8493391', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('128', '8493450', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('129', '8493413', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('130', '8493411', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('131', '8493412', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('132', '8493331', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('133', '8493332', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('134', '8493333', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('135', '8493334', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('136', '8493421', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('137', '8493441', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('138', '8493442', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('139', '8493414', '100', '100', '-1', '0');
INSERT INTO `mantlecommodity` VALUES ('140', '8493415', '100', '100', '-1', '0');

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
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

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
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

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
) ENGINE=InnoDB AUTO_INCREMENT=328 DEFAULT CHARSET=latin1;

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
) ENGINE=InnoDB AUTO_INCREMENT=123 DEFAULT CHARSET=latin1;

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
) ENGINE=InnoDB AUTO_INCREMENT=374 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of useslot
-- ----------------------------
