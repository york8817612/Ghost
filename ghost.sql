/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50617
Source Host           : localhost:3306
Source Database       : ghost

Target Server Type    : MYSQL
Target Server Version : 50617
File Encoding         : 65001

Date: 2016-07-09 19:30:04
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
INSERT INTO `accounts` VALUES ('1', 'admin', '123456', '0001-01-01 00:00:00', '0', '0', '1', '28279', '0', '0', '0', '0');
INSERT INTO `accounts` VALUES ('2', 'admin01', '123456', '0001-01-01 00:00:00', '0', '0', '1', '28388', '0', '0', '0', '0');
INSERT INTO `accounts` VALUES ('3', '7654321512141', '7654321', '0001-01-01 00:00:00', '0', '0', '1', '29955', '0', '0', '0', '0');
INSERT INTO `accounts` VALUES ('4', 'admin2', '123456', '0001-01-01 00:00:00', '0', '0', '1', '30000', '0', '0', '0', '0');
INSERT INTO `accounts` VALUES ('5', 'admin3', '123456', '0001-01-01 00:00:00', '0', '0', '1', '0', '0', '0', '0', '0');
INSERT INTO `accounts` VALUES ('10', 'asd123456', 'asd123456', '0001-01-01 00:00:00', '0', '0', '0', '5000', '0', '0', '0', '0');
INSERT INTO `accounts` VALUES ('11', 'a8332912tw', 'b851202tw', '0001-01-01 00:00:00', '0', '0', '0', '25', '0', '0', '0', '0');
INSERT INTO `accounts` VALUES ('12', 's14115239', 'a8229332', '0001-01-01 00:00:00', '0', '0', '0', '29255', '0', '0', '0', '0');
INSERT INTO `accounts` VALUES ('13', 'ghost01', 'dzss4h', '0001-01-01 00:00:00', '0', '0', '0', '500', '0', '0', '0', '0');
INSERT INTO `accounts` VALUES ('14', 'ghost02', '86v5u7', '0001-01-01 00:00:00', '0', '0', '0', '15', '0', '0', '0', '0');
INSERT INTO `accounts` VALUES ('15', 'ghost03', 'n4yg78', '0001-01-01 00:00:00', '0', '0', '0', '64', '0', '0', '0', '0');
INSERT INTO `accounts` VALUES ('16', 'ghost04', 'xahxn3', '0001-01-01 00:00:00', '0', '0', '0', '223', '0', '0', '0', '0');
INSERT INTO `accounts` VALUES ('17', 'ghost05', 'tmfpwy', '0001-01-01 00:00:00', '0', '0', '0', '202', '0', '0', '0', '0');
INSERT INTO `accounts` VALUES ('18', 'ghost06', 'gfzds2', '0001-01-01 00:00:00', '0', '0', '0', '15', '0', '0', '0', '0');
INSERT INTO `accounts` VALUES ('19', 'ghost07', 'hhwz7s', '0001-01-01 00:00:00', '0', '0', '0', '202', '0', '0', '0', '0');
INSERT INTO `accounts` VALUES ('20', 'ghost08', '38tyf4', '0001-01-01 00:00:00', '0', '0', '0', '44', '0', '0', '0', '0');
INSERT INTO `accounts` VALUES ('21', 'ghost09', '5m67d7', '0001-01-01 00:00:00', '0', '0', '0', '65', '0', '0', '0', '0');
INSERT INTO `accounts` VALUES ('22', 'ghost10', 'ucmsbm', '0001-01-01 00:00:00', '0', '0', '0', '94', '0', '0', '0', '0');
INSERT INTO `accounts` VALUES ('23', 'admin4', '123456', '0001-01-01 00:00:00', '0', '0', '0', '1878', '0', '0', '0', '0');
INSERT INTO `accounts` VALUES ('24', 'brain81421', 'harry9999', '0001-01-01 00:00:00', '0', '0', '0', '348', '0', '0', '0', '0');
INSERT INTO `accounts` VALUES ('25', 'Kpkp800625', 'as1314520', '0001-01-01 00:00:00', '0', '0', '0', '44', '0', '0', '0', '0');
INSERT INTO `accounts` VALUES ('26', '7883621', '7883621', '0001-01-01 00:00:00', '0', '0', '0', '24', '0', '0', '0', '0');
INSERT INTO `accounts` VALUES ('27', 'mike92105', '0000000', '0001-01-01 00:00:00', '0', '0', '1', '30000', '0', '0', '0', '0');
INSERT INTO `accounts` VALUES ('28', 'radid123', '123456', '0001-01-01 00:00:00', '0', '0', '0', '29457', '0', '0', '0', '0');
INSERT INTO `accounts` VALUES ('29', 'azxdc123', '123456', '0001-01-01 00:00:00', '0', '0', '0', '30000', '0', '0', '0', '0');
INSERT INTO `accounts` VALUES ('30', '', '', '0001-01-01 00:00:00', '0', '0', '0', '0', '0', '0', '0', '0');

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
) ENGINE=InnoDB AUTO_INCREMENT=130 DEFAULT CHARSET=latin1;

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
) ENGINE=InnoDB AUTO_INCREMENT=38 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of characters
-- ----------------------------
INSERT INTO `characters` VALUES ('1', '1', '0', '大目仔GM', '江湖人', '1', '9092001', '9192001', '150', '1', '255', '255', '310', '3000', '275', '3000', '1200', '1200', '390', '0', '996985269', '39', '36', '1', '3', '0', '0', '0', '0', '97', '97', '10', '120', '120', '0', '0', '60', '4', '583', '249', '3', '6', '1', '1498', '508', '1');
INSERT INTO `characters` VALUES ('4', '4', '0', '小賴打GM', '江湖人', '1', '9092001', '9192001', '10', '3', '255', '255', '165', '165', '132', '160', '1200', '1200', '0', '0', '453', '3', '3', '3', '3', '0', '0', '0', '0', '3', '5', '0', '4', '4', '0', '0', '10', '0', '40', '22', '3', '1', '50', '516', '388', '1');
INSERT INTO `characters` VALUES ('6', '5', '0', 'qeqweqwe', '江湖人', '1', '9010011', '9110011', '1', '0', '255', '255', '75', '75', '19', '25', '0', '1200', '0', '0', '0', '3', '3', '3', '3', '0', '0', '0', '0', '9', '11', '0', '4', '4', '0', '0', '12', '0', '0', '0', '3', '1', '2', '3151', '1476', '1');
INSERT INTO `characters` VALUES ('7', '3', '0', '鏡花水月', '江湖人', '2', '9050246', '9110052', '8', '0', '255', '255', '234', '234', '71', '130', '1200', '1200', '0', '0', '2944', '26', '7', '4', '3', '0', '0', '0', '0', '14', '71', '0', '4', '4', '0', '0', '22', '0', '0', '-2', '3', '1', '1', '1272', '1284', '1');
INSERT INTO `characters` VALUES ('8', '7', '0', '照雲娘泡', '江湖人', '2', '9010012', '9110062', '8', '0', '255', '255', '100', '145', '130', '130', '0', '1200', '646', '0', '3271', '3', '31', '3', '3', '0', '0', '0', '0', '43', '73', '0', '4', '4', '0', '0', '17', '0', '0', '2', '3', '3', '6', '3363', '1009', '1');
INSERT INTO `characters` VALUES ('9', '8', '0', '雲仔', '江湖人', '1', '9010041', '9150451', '5', '0', '255', '255', '113', '163', '85', '85', '1044', '1200', '246', '0', '824', '19', '3', '3', '3', '0', '0', '0', '0', '9', '46', '0', '4', '4', '0', '0', '27', '0', '0', '0', '3', '2', '6', '2656', '1045', '1');
INSERT INTO `characters` VALUES ('10', '2', '0', '哈哈騎士', '江湖人', '2', '9050244', '9150492', '150', '3', '255', '1', '25779', '26455', '18853', '20651', '900', '1200', '2065', '106', '27455964', '6500', '6884', '7034', '9147', '5', '5', '5', '5', '1000', '3000', '0', '1000', '3000', '0', '3', '1596', '0', '20092', '29949', '3', '6', '1', '1419', '470', '1');
INSERT INTO `characters` VALUES ('11', '9', '0', '搞鬼', '江湖人', '1', '9050181', '9150371', '10', '2', '255', '255', '364', '365', '118', '160', '1200', '1200', '586', '0', '64510084', '3', '43', '7', '3', '0', '0', '0', '0', '62', '104', '0', '4', '4', '0', '0', '42', '0', '0', '0', '3', '2', '6', '4039', '331', '1');
INSERT INTO `characters` VALUES ('12', '1', '0', '小賴打', '江湖人', '1', '9010011', '9110011', '6', '0', '255', '255', '123', '125', '100', '100', '48', '1200', '9', '0', '7000003', '3', '3', '3', '3', '0', '0', '0', '0', '9', '11', '0', '4', '4', '0', '0', '10', '0', '20', '12', '3', '1', '1', '4574', '1220', '2');
INSERT INTO `characters` VALUES ('13', '11', '0', '小菜', '江湖人', '1', '9050185', '9110021', '10', '1', '255', '255', '163', '405', '156', '160', '804', '1200', '220', '9', '6201', '43', '3', '3', '3', '0', '0', '0', '0', '17', '107', '0', '4', '4', '0', '0', '23', '0', '0', '0', '3', '1', '1', '1979', '1028', '1');
INSERT INTO `characters` VALUES ('14', '12', '0', '梓條', '江湖人', '1', '9010031', '9110051', '6', '0', '255', '255', '151', '213', '1', '100', '1080', '1200', '195', '0', '1179', '19', '3', '5', '3', '0', '0', '2', '0', '9', '46', '0', '4', '4', '0', '0', '22', '0', '4', '2', '3', '1', '1', '2057', '1028', '1');
INSERT INTO `characters` VALUES ('15', '11', '0', '牛哥哥', '江湖人', '1', '9050143', '9150151', '10', '4', '255', '255', '373', '381', '160', '160', '384', '1200', '789', '0', '4170', '43', '3', '3', '3', '0', '0', '0', '0', '21', '111', '0', '4', '4', '0', '0', '24', '0', '0', '0', '3', '2', '2', '5114', '1036', '2');
INSERT INTO `characters` VALUES ('16', '17', '0', '侃侃o', '江湖人', '1', '9010031', '9110061', '9', '0', '255', '255', '235', '235', '145', '145', '1200', '1200', '0', '9', '7364', '3', '31', '7', '3', '0', '1', '0', '0', '45', '75', '0', '15', '15', '0', '0', '32', '0', '0', '0', '3', '1', '1', '262', '1156', '1');
INSERT INTO `characters` VALUES ('17', '19', '0', 'GG3BE0', '江湖人', '1', '9010041', '9110061', '7', '0', '255', '255', '1', '174', '1', '115', '1200', '1200', '0', '2', '2287', '16', '14', '3', '3', '0', '0', '0', '0', '22', '64', '0', '4', '4', '0', '0', '12', '0', '0', '0', '3', '1', '1', '25', '918', '1');
INSERT INTO `characters` VALUES ('18', '13', '0', '呆恐龍', '江湖人', '1', '9010031', '9110041', '10', '2', '255', '255', '161', '237', '160', '160', '1200', '1200', '124', '2', '6682', '11', '35', '3', '3', '0', '0', '0', '0', '54', '106', '0', '4', '4', '0', '0', '12', '0', '0', '0', '3', '2', '6', '4166', '334', '1');
INSERT INTO `characters` VALUES ('19', '14', '0', '楓悠', '江湖人', '1', '9050123', '9150081', '7', '0', '255', '255', '1', '135', '1', '115', '1080', '1200', '0', '0', '2653', '3', '27', '3', '3', '0', '0', '0', '0', '38', '64', '0', '4', '4', '0', '0', '42', '0', '0', '0', '3', '1', '1', '1604', '1284', '1');
INSERT INTO `characters` VALUES ('20', '22', '0', '西西', '江湖人', '1', '9050247', '9150341', '4', '0', '255', '255', '141', '141', '70', '70', '300', '1200', '18', '0', '18', '15', '3', '3', '3', '0', '0', '0', '0', '9', '38', '0', '4', '4', '0', '0', '12', '0', '0', '0', '3', '1', '41', '755', '600', '1');
INSERT INTO `characters` VALUES ('21', '25', '0', '桐人', '江湖人', '1', '9050221', '9150631', '8', '0', '255', '255', '169', '190', '130', '130', '1200', '1200', '1028', '4', '5081', '18', '16', '3', '3', '0', '0', '0', '0', '25', '73', '0', '4', '4', '0', '0', '17', '0', '0', '0', '3', '4', '23', '1175', '1429', '1');
INSERT INTO `characters` VALUES ('22', '21', '0', '冰痕', '江湖人', '1', '9050123', '9150621', '5', '0', '255', '255', '138', '163', '77', '85', '216', '1200', '63', '3', '1729', '19', '3', '3', '3', '0', '0', '0', '0', '9', '46', '0', '4', '4', '0', '0', '27', '0', '0', '0', '3', '1', '3', '640', '1274', '1');
INSERT INTO `characters` VALUES ('23', '26', '0', 'Shake喵的啦', '江湖人', '1', '9010041', '9110061', '11', '3', '255', '255', '279', '287', '313', '322', '1200', '1200', '260', '8', '11332', '3', '3', '3', '47', '0', '0', '0', '0', '9', '11', '0', '110', '110', '0', '0', '12', '0', '0', '0', '3', '1', '4', '2470', '1107', '1');
INSERT INTO `characters` VALUES ('24', '15', '0', '戀愛血型ABO', '江湖人', '1', '9050223', '9110021', '16', '1', '255', '255', '451', '474', '250', '250', '216', '1200', '7650', '9', '32957', '46', '24', '3', '3', '0', '0', '0', '0', '42', '160', '0', '4', '4', '0', '0', '23', '0', '0', '0', '3', '6', '23', '940', '977', '1');
INSERT INTO `characters` VALUES ('25', '15', '0', '笨小孩', '江湖人', '1', '9010031', '9110041', '13', '4', '255', '255', '291', '291', '205', '205', '1200', '1200', '3332', '9', '15196', '25', '33', '3', '3', '0', '0', '0', '0', '57', '138', '0', '4', '4', '0', '0', '24', '0', '0', '0', '3', '1', '4', '1699', '1077', '2');
INSERT INTO `characters` VALUES ('26', '17', '0', '星痕', '江湖人', '1', '9010031', '9110041', '10', '3', '255', '255', '1', '174', '1', '388', '1200', '1200', '0', '9', '12711', '3', '4', '3', '42', '0', '0', '0', '0', '8', '11', '0', '100', '100', '0', '0', '12', '0', '0', '0', '3', '1', '1', '25', '918', '2');
INSERT INTO `characters` VALUES ('27', '24', '0', 'asdf', '江湖人', '1', '9010041', '9110061', '10', '3', '255', '255', '229', '231', '221', '301', '120', '1200', '942', '9', '5574', '5', '10', '3', '34', '0', '1', '0', '0', '18', '32', '0', '81', '81', '0', '0', '20', '0', '0', '0', '3', '3', '8', '2751', '670', '1');
INSERT INTO `characters` VALUES ('28', '20', '0', '太猛啦', '江湖人', '1', '9050125', '9110031', '10', '1', '255', '255', '500', '545', '150', '160', '168', '1200', '1083', '9', '4624', '33', '3', '13', '3', '0', '0', '0', '0', '17', '85', '0', '4', '4', '0', '0', '62', '0', '0', '0', '3', '2', '9', '4331', '926', '1');
INSERT INTO `characters` VALUES ('29', '16', '0', '俊俊好好人', '江湖人', '1', '9010011', '9110051', '18', '1', '255', '255', '776', '935', '449', '449', '1200', '1200', '937', '11', '40829', '23', '23', '23', '16', '0', '0', '0', '1', '57', '123', '0', '32', '32', '0', '4', '117', '0', '0', '0', '3', '3', '73', '538', '887', '1');
INSERT INTO `characters` VALUES ('30', '20', '0', '太神拉', '江湖人', '2', '9010012', '9110052', '1', '0', '255', '255', '75', '75', '25', '25', '0', '1200', '0', '0', '0', '3', '3', '3', '3', '0', '0', '0', '0', '9', '11', '0', '4', '4', '0', '0', '12', '0', '0', '0', '3', '1', '1', '2715', '1156', '2');
INSERT INTO `characters` VALUES ('31', '23', '0', '隨風飄逸o', '江湖人', '1', '9050127', '9150621', '34', '1', '255', '255', '429', '641', '471', '580', '1200', '1200', '233', '16', '4309458', '6', '6', '4', '3', '0', '0', '1', '0', '407', '680', '36', '4', '4', '0', '0', '65', '0', '138', '281', '3', '10', '3', '2384', '698', '1');
INSERT INTO `characters` VALUES ('32', '18', '0', '我的童年啊', '江湖人', '1', '9010031', '9110051', '2', '0', '255', '255', '80', '85', '18', '40', '48', '1200', '9', '0', '36', '3', '3', '3', '3', '0', '0', '0', '0', '9', '11', '0', '4', '4', '0', '0', '17', '0', '4', '1', '3', '2', '1', '2258', '430', '1');
INSERT INTO `characters` VALUES ('33', '27', '0', '很多汁怪獸', '江湖人', '1', '9010011', '9110011', '2', '0', '255', '255', '63', '85', '40', '40', '0', '1200', '12', '0', '46', '3', '3', '3', '3', '0', '0', '0', '0', '9', '11', '0', '4', '4', '0', '0', '12', '0', '4', '2', '3', '3', '3', '385', '670', '1');
INSERT INTO `characters` VALUES ('34', '13', '0', '晴晴小太陽', '江湖人', '2', '9010012', '9110042', '10', '3', '255', '255', '225', '312', '230', '292', '1200', '1200', '807', '9', '1770', '4', '3', '6', '39', '0', '0', '0', '0', '7', '11', '0', '93', '93', '0', '0', '27', '0', '0', '0', '3', '3', '7', '3810', '508', '2');
INSERT INTO `characters` VALUES ('35', '2', '0', '1234564', '江湖人', '2', '9010012', '9110012', '3', '0', '255', '255', '105', '119', '50', '55', '168', '1200', '15', '0', '96', '11', '3', '3', '3', '0', '0', '0', '0', '9', '29', '0', '4', '4', '0', '0', '12', '0', '0', '0', '3', '2', '6', '2415', '917', '2');
INSERT INTO `characters` VALUES ('36', '28', '0', '哪裡都是浮雲', '江湖人', '1', '9010041', '9110041', '2', '0', '255', '255', '93', '137', '140', '140', '0', '1200', '6', '0', '27', '7', '3', '5', '3', '0', '0', '2', '0', '9', '20', '0', '4', '4', '0', '0', '37', '0', '0', '0', '3', '77', '1', '667', '299', '1');
INSERT INTO `characters` VALUES ('37', '29', '0', '天嚕嘻嘻', '江湖人', '2', '9010012', '9110052', '1', '0', '255', '255', '75', '75', '25', '25', '0', '1200', '0', '0', '0', '3', '3', '3', '3', '0', '0', '0', '0', '9', '11', '0', '4', '4', '0', '0', '12', '0', '0', '0', '3', '1', '90', '759', '644', '1');

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
) ENGINE=InnoDB AUTO_INCREMENT=2590 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of items
-- ----------------------------
INSERT INTO `items` VALUES ('18', '4', '8510011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '5');
INSERT INTO `items` VALUES ('19', '4', '8810011', '10', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '0');
INSERT INTO `items` VALUES ('28', '4', '8092001', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '0');
INSERT INTO `items` VALUES ('30', '4', '8192001', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '1');
INSERT INTO `items` VALUES ('58', '4', '8990002', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '0');
INSERT INTO `items` VALUES ('59', '4', '8990003', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '1');
INSERT INTO `items` VALUES ('65', '1', '9410021', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '3');
INSERT INTO `items` VALUES ('67', '1', '8990003', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '1');
INSERT INTO `items` VALUES ('124', '1', '8820011', '64', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '3');
INSERT INTO `items` VALUES ('125', '1', '8820011', '33', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '4');
INSERT INTO `items` VALUES ('127', '1', '8820011', '78', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '5');
INSERT INTO `items` VALUES ('128', '1', '8810011', '86', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '6');
INSERT INTO `items` VALUES ('129', '1', '8810011', '80', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '0');
INSERT INTO `items` VALUES ('131', '4', '8820011', '79', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '4');
INSERT INTO `items` VALUES ('133', '4', '8820011', '66', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '3');
INSERT INTO `items` VALUES ('134', '4', '8820011', '63', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '5');
INSERT INTO `items` VALUES ('135', '1', '8810011', '80', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '7');
INSERT INTO `items` VALUES ('137', '6', '8010011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '0');
INSERT INTO `items` VALUES ('138', '6', '8110011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '1');
INSERT INTO `items` VALUES ('139', '6', '8510011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '5');
INSERT INTO `items` VALUES ('140', '6', '8810011', '10', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '0');
INSERT INTO `items` VALUES ('141', '6', '8820011', '10', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '1');
INSERT INTO `items` VALUES ('142', '4', '8610091', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '1');
INSERT INTO `items` VALUES ('205', '7', '8010011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '0');
INSERT INTO `items` VALUES ('206', '7', '8110012', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '1');
INSERT INTO `items` VALUES ('211', '8', '8010011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '0');
INSERT INTO `items` VALUES ('212', '8', '8120012', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '1');
INSERT INTO `items` VALUES ('214', '8', '8810011', '100', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '0');
INSERT INTO `items` VALUES ('215', '8', '8820011', '100', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '1');
INSERT INTO `items` VALUES ('216', '7', '8610122', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '6');
INSERT INTO `items` VALUES ('218', '8', '9510042', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '11');
INSERT INTO `items` VALUES ('219', '9', '8010011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '0');
INSERT INTO `items` VALUES ('220', '9', '8120011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '1');
INSERT INTO `items` VALUES ('221', '9', '8510011', '1', '9', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '5');
INSERT INTO `items` VALUES ('222', '9', '8810011', '100', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '0');
INSERT INTO `items` VALUES ('223', '9', '8820011', '58', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '1');
INSERT INTO `items` VALUES ('224', '8', '8493121', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '4');
INSERT INTO `items` VALUES ('225', '7', '9510442', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '11');
INSERT INTO `items` VALUES ('226', '8', '8610474', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '6');
INSERT INTO `items` VALUES ('227', '7', '8493261', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '4');
INSERT INTO `items` VALUES ('229', '9', '8910011', '100', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '0');
INSERT INTO `items` VALUES ('230', '9', '9510253', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '11');
INSERT INTO `items` VALUES ('231', '9', '8493121', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '4');
INSERT INTO `items` VALUES ('232', '9', '8610031', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '6');
INSERT INTO `items` VALUES ('238', '7', '8130011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '0');
INSERT INTO `items` VALUES ('239', '7', '8130011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '1');
INSERT INTO `items` VALUES ('240', '7', '8910061', '38', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '3');
INSERT INTO `items` VALUES ('242', '7', '8510011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '5');
INSERT INTO `items` VALUES ('243', '7', '8120011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '2');
INSERT INTO `items` VALUES ('244', '7', '8120011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '3');
INSERT INTO `items` VALUES ('245', '7', '8910071', '3', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '4');
INSERT INTO `items` VALUES ('246', '7', '8910031', '7', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '5');
INSERT INTO `items` VALUES ('248', '7', '8510011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '2');
INSERT INTO `items` VALUES ('249', '7', '8010011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '4');
INSERT INTO `items` VALUES ('250', '8', '8910011', '42', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '0');
INSERT INTO `items` VALUES ('251', '8', '8910021', '39', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '1');
INSERT INTO `items` VALUES ('252', '8', '8130011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '0');
INSERT INTO `items` VALUES ('253', '8', '8910051', '86', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '2');
INSERT INTO `items` VALUES ('254', '8', '8130011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '1');
INSERT INTO `items` VALUES ('255', '8', '8910061', '99', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '3');
INSERT INTO `items` VALUES ('256', '8', '8110011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '4');
INSERT INTO `items` VALUES ('257', '8', '8110011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '5');
INSERT INTO `items` VALUES ('258', '8', '8110011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '6');
INSERT INTO `items` VALUES ('259', '8', '8810011', '100', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '2');
INSERT INTO `items` VALUES ('260', '8', '8110011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '7');
INSERT INTO `items` VALUES ('261', '8', '8110011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '9');
INSERT INTO `items` VALUES ('262', '8', '8110011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '10');
INSERT INTO `items` VALUES ('263', '8', '8110011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '11');
INSERT INTO `items` VALUES ('264', '8', '8110011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '12');
INSERT INTO `items` VALUES ('265', '8', '8110011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '13');
INSERT INTO `items` VALUES ('266', '8', '8110011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '14');
INSERT INTO `items` VALUES ('267', '8', '8110011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '15');
INSERT INTO `items` VALUES ('268', '8', '8510011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '5');
INSERT INTO `items` VALUES ('269', '8', '8510011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '0');
INSERT INTO `items` VALUES ('270', '8', '8120011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '18');
INSERT INTO `items` VALUES ('271', '8', '8120011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '19');
INSERT INTO `items` VALUES ('272', '8', '8120011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '20');
INSERT INTO `items` VALUES ('273', '8', '8120011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '21');
INSERT INTO `items` VALUES ('274', '8', '8120011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '22');
INSERT INTO `items` VALUES ('275', '8', '8120011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '23');
INSERT INTO `items` VALUES ('276', '8', '8910031', '45', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '4');
INSERT INTO `items` VALUES ('277', '8', '8110011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '16');
INSERT INTO `items` VALUES ('278', '8', '8010011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '17');
INSERT INTO `items` VALUES ('279', '8', '8510011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '1');
INSERT INTO `items` VALUES ('280', '8', '8910071', '10', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '5');
INSERT INTO `items` VALUES ('281', '8', '8010011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '2');
INSERT INTO `items` VALUES ('282', '8', '8010011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '3');
INSERT INTO `items` VALUES ('283', '8', '8010011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '8');
INSERT INTO `items` VALUES ('284', '8', '8510011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '2');
INSERT INTO `items` VALUES ('285', '8', '8810011', '40', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '4');
INSERT INTO `items` VALUES ('286', '8', '8510011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '3');
INSERT INTO `items` VALUES ('287', '8', '8510011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '4');
INSERT INTO `items` VALUES ('288', '8', '8510011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '5');
INSERT INTO `items` VALUES ('289', '8', '8880011', '2', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '6');
INSERT INTO `items` VALUES ('290', '8', '8910121', '3', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '6');
INSERT INTO `items` VALUES ('291', '8', '8820011', '34', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '3');
INSERT INTO `items` VALUES ('292', '9', '8910021', '21', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '1');
INSERT INTO `items` VALUES ('293', '9', '8810011', '10', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '2');
INSERT INTO `items` VALUES ('381', '1', '9519011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '1');
INSERT INTO `items` VALUES ('386', '1', '8820011', '47', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '1');
INSERT INTO `items` VALUES ('389', '10', '9410063', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '12');
INSERT INTO `items` VALUES ('463', '1', '8810011', '9', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '10');
INSERT INTO `items` VALUES ('464', '1', '8810011', '98', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '9');
INSERT INTO `items` VALUES ('498', '1', '8990012', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '3');
INSERT INTO `items` VALUES ('500', '11', '8510011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '0');
INSERT INTO `items` VALUES ('525', '11', '8910051', '11', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '1');
INSERT INTO `items` VALUES ('527', '11', '8130012', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '0');
INSERT INTO `items` VALUES ('530', '11', '9510143', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '11');
INSERT INTO `items` VALUES ('532', '11', '8710643', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '9');
INSERT INTO `items` VALUES ('542', '7', '8910051', '4', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '0');
INSERT INTO `items` VALUES ('543', '7', '8910021', '3', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '1');
INSERT INTO `items` VALUES ('544', '7', '8910011', '3', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '2');
INSERT INTO `items` VALUES ('546', '7', '8110011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '5');
INSERT INTO `items` VALUES ('547', '7', '8120011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '6');
INSERT INTO `items` VALUES ('548', '7', '8120011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '7');
INSERT INTO `items` VALUES ('549', '7', '8910121', '11', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '6');
INSERT INTO `items` VALUES ('550', '7', '8880011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '0');
INSERT INTO `items` VALUES ('551', '7', '8910101', '7', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '7');
INSERT INTO `items` VALUES ('552', '7', '8820011', '2', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '2');
INSERT INTO `items` VALUES ('553', '7', '8120101', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '8');
INSERT INTO `items` VALUES ('554', '7', '9410143', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '12');
INSERT INTO `items` VALUES ('557', '11', '8493354', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '4');
INSERT INTO `items` VALUES ('558', '11', '8493093', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '1');
INSERT INTO `items` VALUES ('559', '11', '8910061', '13', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '2');
INSERT INTO `items` VALUES ('560', '11', '8910071', '13', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '3');
INSERT INTO `items` VALUES ('561', '11', '8910081', '10', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '4');
INSERT INTO `items` VALUES ('562', '11', '8030011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '1');
INSERT INTO `items` VALUES ('563', '11', '8820041', '100', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '2');
INSERT INTO `items` VALUES ('564', '11', '8910121', '6', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '5');
INSERT INTO `items` VALUES ('565', '11', '8880011', '3', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '4');
INSERT INTO `items` VALUES ('566', '11', '8910161', '7', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '6');
INSERT INTO `items` VALUES ('567', '11', '8110101', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '2');
INSERT INTO `items` VALUES ('568', '11', '8910141', '2', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '7');
INSERT INTO `items` VALUES ('569', '11', '8040101', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '3');
INSERT INTO `items` VALUES ('570', '11', '8010101', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '4');
INSERT INTO `items` VALUES ('571', '11', '8110101', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '5');
INSERT INTO `items` VALUES ('572', '11', '8910181', '6', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '8');
INSERT INTO `items` VALUES ('573', '11', '8510021', '1', '58', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '5');
INSERT INTO `items` VALUES ('574', '11', '8510011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '2');
INSERT INTO `items` VALUES ('575', '11', '8910211', '4', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '9');
INSERT INTO `items` VALUES ('576', '11', '8130201', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '6');
INSERT INTO `items` VALUES ('577', '11', '8910201', '2', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '10');
INSERT INTO `items` VALUES ('581', '11', '8030011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '7');
INSERT INTO `items` VALUES ('587', '12', '8010011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '0');
INSERT INTO `items` VALUES ('589', '12', '8510011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '5');
INSERT INTO `items` VALUES ('592', '7', '8110101', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '9');
INSERT INTO `items` VALUES ('596', '11', '8120101', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '1');
INSERT INTO `items` VALUES ('616', '10', '8041321', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '3');
INSERT INTO `items` VALUES ('617', '10', '8131282', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '1');
INSERT INTO `items` VALUES ('619', '10', '8210010', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '2');
INSERT INTO `items` VALUES ('621', '10', '7510014', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '13');
INSERT INTO `items` VALUES ('636', '11', '8110011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '8');
INSERT INTO `items` VALUES ('638', '11', '8010011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '10');
INSERT INTO `items` VALUES ('639', '11', '8910031', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '11');
INSERT INTO `items` VALUES ('641', '11', '8510011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '3');
INSERT INTO `items` VALUES ('644', '11', '8040101', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '0');
INSERT INTO `items` VALUES ('645', '11', '8030101', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '9');
INSERT INTO `items` VALUES ('647', '11', '8850021', '37', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '1');
INSERT INTO `items` VALUES ('648', '11', '8820011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '11');
INSERT INTO `items` VALUES ('649', '11', '8130012', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '11');
INSERT INTO `items` VALUES ('650', '11', '8910021', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '12');
INSERT INTO `items` VALUES ('651', '11', '8910011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '0');
INSERT INTO `items` VALUES ('652', '11', '8850061', '49', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '6');
INSERT INTO `items` VALUES ('654', '11', '8820041', '36', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '9');
INSERT INTO `items` VALUES ('655', '11', '8810031', '99', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '0');
INSERT INTO `items` VALUES ('672', '10', '8881021', '92', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '10');
INSERT INTO `items` VALUES ('673', '11', '8850041', '49', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '5');
INSERT INTO `items` VALUES ('674', '11', '8880041', '14', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '7');
INSERT INTO `items` VALUES ('675', '11', '8820041', '97', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '3');
INSERT INTO `items` VALUES ('676', '11', '8880041', '41', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '8');
INSERT INTO `items` VALUES ('689', '10', '9510626', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '6');
INSERT INTO `items` VALUES ('692', '10', '9510244', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '8');
INSERT INTO `items` VALUES ('712', '10', '8710173', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '9');
INSERT INTO `items` VALUES ('714', '10', '8493191', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '4');
INSERT INTO `items` VALUES ('716', '10', '8610052', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '6');
INSERT INTO `items` VALUES ('719', '10', '8051531', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '18');
INSERT INTO `items` VALUES ('723', '9', '8910011', '7', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '2');
INSERT INTO `items` VALUES ('729', '13', '8710243', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '9');
INSERT INTO `items` VALUES ('735', '13', '8910021', '34', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '0');
INSERT INTO `items` VALUES ('736', '13', '8910011', '47', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '1');
INSERT INTO `items` VALUES ('737', '13', '8910051', '24', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '2');
INSERT INTO `items` VALUES ('740', '1', '8850061', '97', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '8');
INSERT INTO `items` VALUES ('741', '13', '8510011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '0');
INSERT INTO `items` VALUES ('742', '13', '8910061', '14', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '3');
INSERT INTO `items` VALUES ('750', '10', '8890039', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '8');
INSERT INTO `items` VALUES ('774', '13', '8493093', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '4');
INSERT INTO `items` VALUES ('775', '13', '8493101', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '1');
INSERT INTO `items` VALUES ('776', '13', '8510011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '2');
INSERT INTO `items` VALUES ('777', '13', '8910071', '9', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '4');
INSERT INTO `items` VALUES ('778', '13', '8910081', '4', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '5');
INSERT INTO `items` VALUES ('780', '13', '8910121', '11', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '6');
INSERT INTO `items` VALUES ('781', '13', '8910161', '8', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '7');
INSERT INTO `items` VALUES ('782', '13', '8910141', '18', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '8');
INSERT INTO `items` VALUES ('783', '13', '8880011', '6', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '2');
INSERT INTO `items` VALUES ('787', '13', '8910181', '7', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '9');
INSERT INTO `items` VALUES ('799', '10', '8820051', '100', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '0');
INSERT INTO `items` VALUES ('800', '10', '8820051', '100', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '1');
INSERT INTO `items` VALUES ('802', '10', '8810031', '100', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '13');
INSERT INTO `items` VALUES ('803', '10', '8810031', '100', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '14');
INSERT INTO `items` VALUES ('804', '10', '8810031', '100', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '15');
INSERT INTO `items` VALUES ('805', '10', '8810031', '100', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '16');
INSERT INTO `items` VALUES ('806', '10', '8810031', '100', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '17');
INSERT INTO `items` VALUES ('807', '10', '8820051', '100', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '3');
INSERT INTO `items` VALUES ('809', '10', '8820051', '100', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '4');
INSERT INTO `items` VALUES ('813', '10', '8820051', '100', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '5');
INSERT INTO `items` VALUES ('814', '14', '7940011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '0');
INSERT INTO `items` VALUES ('816', '14', '8510011', '1', '45', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '5');
INSERT INTO `items` VALUES ('817', '14', '8810011', '17', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '0');
INSERT INTO `items` VALUES ('820', '14', '8910011', '29', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '0');
INSERT INTO `items` VALUES ('821', '14', '8910021', '29', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '1');
INSERT INTO `items` VALUES ('823', '10', '8860111', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '11');
INSERT INTO `items` VALUES ('830', '10', '8910011', '100', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '0');
INSERT INTO `items` VALUES ('831', '10', '8910021', '71', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '1');
INSERT INTO `items` VALUES ('833', '10', '8990018', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '2');
INSERT INTO `items` VALUES ('834', '13', '8990012', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '10');
INSERT INTO `items` VALUES ('835', '13', '8990002', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '11');
INSERT INTO `items` VALUES ('838', '13', '8910031', '14', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '12');
INSERT INTO `items` VALUES ('839', '13', '8990003', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '13');
INSERT INTO `items` VALUES ('845', '13', '9510643', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '11');
INSERT INTO `items` VALUES ('846', '13', '9510253', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '1');
INSERT INTO `items` VALUES ('847', '13', '8910101', '2', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '14');
INSERT INTO `items` VALUES ('856', '13', '8130011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '0');
INSERT INTO `items` VALUES ('861', '10', '8910491', '50', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '4');
INSERT INTO `items` VALUES ('862', '10', '8990043', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '5');
INSERT INTO `items` VALUES ('864', '10', '8910481', '40', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '3');
INSERT INTO `items` VALUES ('873', '10', '8990042', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '6');
INSERT INTO `items` VALUES ('883', '10', '8820051', '69', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '2');
INSERT INTO `items` VALUES ('884', '10', '8810031', '47', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '12');
INSERT INTO `items` VALUES ('896', '1', '8910481', '10', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '4');
INSERT INTO `items` VALUES ('898', '1', '8910021', '13', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '5');
INSERT INTO `items` VALUES ('901', '13', '8130102', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '3');
INSERT INTO `items` VALUES ('902', '13', '8910221', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '15');
INSERT INTO `items` VALUES ('903', '13', '8910211', '2', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '16');
INSERT INTO `items` VALUES ('904', '13', '8880021', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '3');
INSERT INTO `items` VALUES ('907', '13', '8110011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '4');
INSERT INTO `items` VALUES ('909', '13', '8110012', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '5');
INSERT INTO `items` VALUES ('910', '13', '8510021', '1', '39', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '5');
INSERT INTO `items` VALUES ('911', '13', '8510011', '1', '100', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '3');
INSERT INTO `items` VALUES ('913', '13', '8130011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '6');
INSERT INTO `items` VALUES ('914', '13', '8130012', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '7');
INSERT INTO `items` VALUES ('915', '13', '8510021', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '4');
INSERT INTO `items` VALUES ('917', '13', '8610091', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '6');
INSERT INTO `items` VALUES ('918', '10', '9510302', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '4');
INSERT INTO `items` VALUES ('919', '10', '9510332', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '5');
INSERT INTO `items` VALUES ('924', '13', '8990009', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '17');
INSERT INTO `items` VALUES ('925', '13', '8110101', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '1');
INSERT INTO `items` VALUES ('926', '13', '8120011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '8');
INSERT INTO `items` VALUES ('928', '13', '8010011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '2');
INSERT INTO `items` VALUES ('929', '13', '8510011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '5');
INSERT INTO `items` VALUES ('930', '13', '8130011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '9');
INSERT INTO `items` VALUES ('931', '13', '8130011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '10');
INSERT INTO `items` VALUES ('937', '14', '8510011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '0');
INSERT INTO `items` VALUES ('938', '14', '8120012', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '0');
INSERT INTO `items` VALUES ('939', '14', '8110012', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '1');
INSERT INTO `items` VALUES ('940', '14', '8910051', '6', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '2');
INSERT INTO `items` VALUES ('941', '15', '8810011', '25', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '0');
INSERT INTO `items` VALUES ('943', '15', '8910011', '41', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '0');
INSERT INTO `items` VALUES ('944', '15', '8910021', '30', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '1');
INSERT INTO `items` VALUES ('947', '15', '8710483', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '9');
INSERT INTO `items` VALUES ('948', '15', '9410183', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '12');
INSERT INTO `items` VALUES ('949', '15', '9510041', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '11');
INSERT INTO `items` VALUES ('950', '15', '8493071', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '4');
INSERT INTO `items` VALUES ('951', '15', '8910051', '11', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '2');
INSERT INTO `items` VALUES ('952', '15', '8510011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '0');
INSERT INTO `items` VALUES ('953', '15', '8910061', '20', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '3');
INSERT INTO `items` VALUES ('954', '15', '8910101', '10', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '4');
INSERT INTO `items` VALUES ('955', '15', '8910071', '19', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '5');
INSERT INTO `items` VALUES ('956', '15', '8510011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '1');
INSERT INTO `items` VALUES ('957', '15', '8910141', '15', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '6');
INSERT INTO `items` VALUES ('958', '15', '8910161', '9', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '7');
INSERT INTO `items` VALUES ('959', '15', '8910121', '23', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '8');
INSERT INTO `items` VALUES ('960', '15', '8880011', '3', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '2');
INSERT INTO `items` VALUES ('961', '15', '8510011', '1', '117', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '5');
INSERT INTO `items` VALUES ('962', '15', '8510021', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '2');
INSERT INTO `items` VALUES ('963', '15', '8510011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '3');
INSERT INTO `items` VALUES ('964', '15', '8910031', '4', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '9');
INSERT INTO `items` VALUES ('965', '15', '8990076', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '10');
INSERT INTO `items` VALUES ('966', '15', '8070101', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '0');
INSERT INTO `items` VALUES ('967', '15', '8140101', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '1');
INSERT INTO `items` VALUES ('968', '15', '8510011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '4');
INSERT INTO `items` VALUES ('969', '15', '8910081', '2', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '11');
INSERT INTO `items` VALUES ('970', '15', '8510021', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '5');
INSERT INTO `items` VALUES ('971', '15', '8910181', '3', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '12');
INSERT INTO `items` VALUES ('972', '15', '8510021', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '6');
INSERT INTO `items` VALUES ('973', '15', '8820011', '11', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '1');
INSERT INTO `items` VALUES ('974', '15', '8510011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '7');
INSERT INTO `items` VALUES ('975', '15', '8120012', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '0');
INSERT INTO `items` VALUES ('980', '1', '8820011', '3', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '12');
INSERT INTO `items` VALUES ('981', '1', '9510041', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '11');
INSERT INTO `items` VALUES ('982', '1', '9510213', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '0');
INSERT INTO `items` VALUES ('983', '1', '8820011', '78', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '13');
INSERT INTO `items` VALUES ('985', '1', '8820011', '78', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '16');
INSERT INTO `items` VALUES ('986', '1', '8820011', '81', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '17');
INSERT INTO `items` VALUES ('988', '4', '8110011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '0');
INSERT INTO `items` VALUES ('989', '4', '8820011', '2', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '1');
INSERT INTO `items` VALUES ('990', '4', '8820011', '46', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '2');
INSERT INTO `items` VALUES ('991', '4', '8910011', '3', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '2');
INSERT INTO `items` VALUES ('992', '12', '8810011', '10', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '0');
INSERT INTO `items` VALUES ('993', '12', '8910011', '2', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '0');
INSERT INTO `items` VALUES ('994', '12', '8110011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '0');
INSERT INTO `items` VALUES ('998', '1', '9510253', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '11');
INSERT INTO `items` VALUES ('1001', '10', '8990007', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '7');
INSERT INTO `items` VALUES ('1002', '10', '8910031', '10', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '8');
INSERT INTO `items` VALUES ('1004', '10', '8842002', '100', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '1', '0', '-1', '3', '18');
INSERT INTO `items` VALUES ('1005', '1', '8110012', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '3');
INSERT INTO `items` VALUES ('1006', '1', '8110012', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '4');
INSERT INTO `items` VALUES ('1016', '13', '8120012', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '11');
INSERT INTO `items` VALUES ('1018', '16', '8120011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '1');
INSERT INTO `items` VALUES ('1021', '16', '8820011', '24', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '1');
INSERT INTO `items` VALUES ('1023', '17', '8120011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '1');
INSERT INTO `items` VALUES ('1024', '17', '8510011', '1', '45', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '5');
INSERT INTO `items` VALUES ('1028', '18', '8120011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '1');
INSERT INTO `items` VALUES ('1029', '18', '8510011', '1', '88', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '5');
INSERT INTO `items` VALUES ('1035', '19', '8010011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '0');
INSERT INTO `items` VALUES ('1037', '19', '8510011', '1', '46', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '5');
INSERT INTO `items` VALUES ('1039', '19', '8820011', '14', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '1');
INSERT INTO `items` VALUES ('1040', '18', '8810011', '22', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '0');
INSERT INTO `items` VALUES ('1042', '18', '8130012', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '0');
INSERT INTO `items` VALUES ('1043', '18', '8110012', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '1');
INSERT INTO `items` VALUES ('1044', '18', '8910011', '5', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '0');
INSERT INTO `items` VALUES ('1045', '18', '8110012', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '2');
INSERT INTO `items` VALUES ('1046', '18', '8910021', '6', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '1');
INSERT INTO `items` VALUES ('1047', '18', '8510011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '0');
INSERT INTO `items` VALUES ('1048', '18', '8910051', '10', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '2');
INSERT INTO `items` VALUES ('1049', '18', '8910061', '17', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '3');
INSERT INTO `items` VALUES ('1050', '18', '8120011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '3');
INSERT INTO `items` VALUES ('1051', '18', '8910031', '10', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '4');
INSERT INTO `items` VALUES ('1052', '18', '8510011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '1');
INSERT INTO `items` VALUES ('1053', '18', '8120011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '4');
INSERT INTO `items` VALUES ('1054', '18', '8910071', '68', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '5');
INSERT INTO `items` VALUES ('1055', '16', '8910021', '30', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '0');
INSERT INTO `items` VALUES ('1056', '16', '8910011', '40', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '1');
INSERT INTO `items` VALUES ('1057', '16', '8510011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '0');
INSERT INTO `items` VALUES ('1058', '16', '8510011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '1');
INSERT INTO `items` VALUES ('1059', '16', '8910031', '27', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '2');
INSERT INTO `items` VALUES ('1060', '16', '8110011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '0');
INSERT INTO `items` VALUES ('1061', '16', '8510011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '2');
INSERT INTO `items` VALUES ('1062', '16', '8990002', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '3');
INSERT INTO `items` VALUES ('1063', '16', '8910051', '15', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '4');
INSERT INTO `items` VALUES ('1064', '16', '8910061', '17', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '5');
INSERT INTO `items` VALUES ('1065', '16', '8910101', '11', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '6');
INSERT INTO `items` VALUES ('1068', '19', '8910011', '29', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '0');
INSERT INTO `items` VALUES ('1070', '19', '8910051', '7', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '1');
INSERT INTO `items` VALUES ('1072', '19', '8910021', '8', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '2');
INSERT INTO `items` VALUES ('1073', '19', '8510011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '0');
INSERT INTO `items` VALUES ('1075', '17', '8910011', '11', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '0');
INSERT INTO `items` VALUES ('1076', '17', '8910021', '5', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '1');
INSERT INTO `items` VALUES ('1077', '17', '8510011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '0');
INSERT INTO `items` VALUES ('1078', '17', '8110012', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '0');
INSERT INTO `items` VALUES ('1080', '17', '8910031', '11', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '2');
INSERT INTO `items` VALUES ('1081', '17', '8510011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '1');
INSERT INTO `items` VALUES ('1083', '17', '8990002', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '3');
INSERT INTO `items` VALUES ('1085', '17', '8810011', '7', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '0');
INSERT INTO `items` VALUES ('1086', '17', '8990003', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '4');
INSERT INTO `items` VALUES ('1087', '17', '8990012', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '5');
INSERT INTO `items` VALUES ('1089', '20', '8010011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '0');
INSERT INTO `items` VALUES ('1090', '20', '8140011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '1');
INSERT INTO `items` VALUES ('1091', '20', '8510011', '1', '8', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '5');
INSERT INTO `items` VALUES ('1094', '19', '9519031', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '11');
INSERT INTO `items` VALUES ('1097', '19', '9410133', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '12');
INSERT INTO `items` VALUES ('1100', '20', '9510111', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '11');
INSERT INTO `items` VALUES ('1101', '20', '8910011', '2', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '0');
INSERT INTO `items` VALUES ('1103', '20', '8910021', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '1');
INSERT INTO `items` VALUES ('1104', '20', '8910051', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '2');
INSERT INTO `items` VALUES ('1105', '19', '8030011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '4');
INSERT INTO `items` VALUES ('1106', '19', '8910061', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '3');
INSERT INTO `items` VALUES ('1107', '19', '8910071', '5', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '4');
INSERT INTO `items` VALUES ('1108', '19', '8910081', '4', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '5');
INSERT INTO `items` VALUES ('1109', '19', '8910121', '3', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '6');
INSERT INTO `items` VALUES ('1110', '19', '8510011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '1');
INSERT INTO `items` VALUES ('1111', '19', '8910161', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '7');
INSERT INTO `items` VALUES ('1112', '19', '8910141', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '8');
INSERT INTO `items` VALUES ('1113', '19', '8510021', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '2');
INSERT INTO `items` VALUES ('1114', '19', '8910181', '2', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '9');
INSERT INTO `items` VALUES ('1115', '19', '8110011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '1');
INSERT INTO `items` VALUES ('1117', '20', '8910081', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '3');
INSERT INTO `items` VALUES ('1118', '20', '8820011', '2', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '1');
INSERT INTO `items` VALUES ('1119', '20', '8810011', '9', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '0');
INSERT INTO `items` VALUES ('1120', '17', '8910051', '3', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '6');
INSERT INTO `items` VALUES ('1121', '17', '8910061', '5', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '7');
INSERT INTO `items` VALUES ('1122', '17', '8010011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '4');
INSERT INTO `items` VALUES ('1123', '17', '8030011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '5');
INSERT INTO `items` VALUES ('1124', '17', '8010011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '0');
INSERT INTO `items` VALUES ('1125', '17', '7940011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '3');
INSERT INTO `items` VALUES ('1126', '17', '8130011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '2');
INSERT INTO `items` VALUES ('1127', '17', '8130012', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '1');
INSERT INTO `items` VALUES ('1128', '17', '8910121', '6', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '8');
INSERT INTO `items` VALUES ('1129', '17', '8910101', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '9');
INSERT INTO `items` VALUES ('1130', '17', '8910161', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '10');
INSERT INTO `items` VALUES ('1131', '17', '8910141', '2', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '11');
INSERT INTO `items` VALUES ('1132', '16', '8910071', '23', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '7');
INSERT INTO `items` VALUES ('1133', '16', '8210081', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '2');
INSERT INTO `items` VALUES ('1134', '16', '8010011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '0');
INSERT INTO `items` VALUES ('1135', '16', '8060011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '1');
INSERT INTO `items` VALUES ('1136', '16', '8910121', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '8');
INSERT INTO `items` VALUES ('1137', '16', '8990012', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '9');
INSERT INTO `items` VALUES ('1138', '16', '8990003', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '10');
INSERT INTO `items` VALUES ('1139', '16', '8110012', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '2');
INSERT INTO `items` VALUES ('1140', '16', '8130012', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '3');
INSERT INTO `items` VALUES ('1141', '16', '8030011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '4');
INSERT INTO `items` VALUES ('1142', '16', '8120012', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '5');
INSERT INTO `items` VALUES ('1143', '16', '8510021', '1', '30', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '5');
INSERT INTO `items` VALUES ('1144', '16', '8510011', '1', '112', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '3');
INSERT INTO `items` VALUES ('1145', '16', '8130012', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '6');
INSERT INTO `items` VALUES ('1146', '16', '8810011', '27', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '0');
INSERT INTO `items` VALUES ('1147', '21', '8030011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '0');
INSERT INTO `items` VALUES ('1148', '21', '8120011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '1');
INSERT INTO `items` VALUES ('1152', '21', '8910011', '28', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '0');
INSERT INTO `items` VALUES ('1153', '21', '8990002', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '1');
INSERT INTO `items` VALUES ('1156', '21', '9510527', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '11');
INSERT INTO `items` VALUES ('1158', '19', '8810011', '18', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '0');
INSERT INTO `items` VALUES ('1159', '22', '7940011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '0');
INSERT INTO `items` VALUES ('1160', '22', '8110011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '1');
INSERT INTO `items` VALUES ('1161', '22', '8510011', '1', '21', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '5');
INSERT INTO `items` VALUES ('1166', '22', '9510081', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '11');
INSERT INTO `items` VALUES ('1167', '22', '8710223', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '9');
INSERT INTO `items` VALUES ('1168', '22', '8493354', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '4');
INSERT INTO `items` VALUES ('1169', '21', '8910021', '37', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '2');
INSERT INTO `items` VALUES ('1170', '21', '8110012', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '0');
INSERT INTO `items` VALUES ('1171', '21', '8990003', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '3');
INSERT INTO `items` VALUES ('1172', '21', '8990012', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '4');
INSERT INTO `items` VALUES ('1173', '21', '8130012', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '1');
INSERT INTO `items` VALUES ('1174', '21', '8910051', '21', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '5');
INSERT INTO `items` VALUES ('1175', '21', '8110012', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '2');
INSERT INTO `items` VALUES ('1176', '21', '8910061', '13', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '6');
INSERT INTO `items` VALUES ('1177', '21', '8510011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '0');
INSERT INTO `items` VALUES ('1178', '21', '8130012', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '3');
INSERT INTO `items` VALUES ('1179', '21', '8130012', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '4');
INSERT INTO `items` VALUES ('1180', '21', '8110011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '5');
INSERT INTO `items` VALUES ('1181', '21', '8130012', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '6');
INSERT INTO `items` VALUES ('1182', '21', '8910031', '10', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '7');
INSERT INTO `items` VALUES ('1183', '21', '8110011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '7');
INSERT INTO `items` VALUES ('1184', '21', '8120012', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '8');
INSERT INTO `items` VALUES ('1185', '21', '8510011', '1', '87', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '5');
INSERT INTO `items` VALUES ('1186', '21', '8510011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '1');
INSERT INTO `items` VALUES ('1187', '21', '8130012', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '9');
INSERT INTO `items` VALUES ('1188', '21', '8110011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '10');
INSERT INTO `items` VALUES ('1190', '21', '8810011', '21', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '0');
INSERT INTO `items` VALUES ('1191', '21', '8110012', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '11');
INSERT INTO `items` VALUES ('1192', '21', '8120011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '12');
INSERT INTO `items` VALUES ('1193', '21', '8910101', '15', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '8');
INSERT INTO `items` VALUES ('1194', '21', '8910071', '13', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '9');
INSERT INTO `items` VALUES ('1195', '21', '8510011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '2');
INSERT INTO `items` VALUES ('1196', '22', '8910031', '7', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '0');
INSERT INTO `items` VALUES ('1197', '22', '8990002', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '1');
INSERT INTO `items` VALUES ('1198', '22', '8990003', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '2');
INSERT INTO `items` VALUES ('1201', '22', '8820011', '4', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '1');
INSERT INTO `items` VALUES ('1202', '22', '8810011', '6', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '0');
INSERT INTO `items` VALUES ('1204', '23', '8120011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '1');
INSERT INTO `items` VALUES ('1208', '22', '8990012', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '5');
INSERT INTO `items` VALUES ('1212', '23', '8910021', '25', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '0');
INSERT INTO `items` VALUES ('1213', '23', '8910011', '26', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '1');
INSERT INTO `items` VALUES ('1215', '23', '8910031', '23', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '2');
INSERT INTO `items` VALUES ('1217', '23', '8910071', '40', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '3');
INSERT INTO `items` VALUES ('1219', '23', '8910061', '11', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '4');
INSERT INTO `items` VALUES ('1221', '23', '8880011', '11', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '2');
INSERT INTO `items` VALUES ('1222', '23', '8910121', '33', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '5');
INSERT INTO `items` VALUES ('1224', '23', '9510081', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '11');
INSERT INTO `items` VALUES ('1225', '23', '8493012', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '4');
INSERT INTO `items` VALUES ('1226', '23', '8610091', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '6');
INSERT INTO `items` VALUES ('1243', '24', '8710333', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '9');
INSERT INTO `items` VALUES ('1244', '24', '9510607', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '11');
INSERT INTO `items` VALUES ('1245', '23', '8310081', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '3');
INSERT INTO `items` VALUES ('1246', '23', '8910101', '12', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '6');
INSERT INTO `items` VALUES ('1247', '23', '8990002', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '7');
INSERT INTO `items` VALUES ('1248', '23', '8990003', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '8');
INSERT INTO `items` VALUES ('1249', '23', '8910051', '10', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '9');
INSERT INTO `items` VALUES ('1250', '23', '8910081', '22', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '10');
INSERT INTO `items` VALUES ('1251', '23', '8510011', '1', '103', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '23');
INSERT INTO `items` VALUES ('1252', '23', '8510011', '1', '51', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '5');
INSERT INTO `items` VALUES ('1253', '23', '8510011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '2');
INSERT INTO `items` VALUES ('1254', '23', '8990011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '11');
INSERT INTO `items` VALUES ('1257', '23', '8030011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '0');
INSERT INTO `items` VALUES ('1258', '23', '8510021', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '0');
INSERT INTO `items` VALUES ('1259', '23', '8110101', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '1');
INSERT INTO `items` VALUES ('1260', '23', '8910161', '7', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '12');
INSERT INTO `items` VALUES ('1261', '23', '8910141', '6', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '13');
INSERT INTO `items` VALUES ('1262', '23', '8030101', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '2');
INSERT INTO `items` VALUES ('1264', '23', '8510021', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '1');
INSERT INTO `items` VALUES ('1288', '24', '8110101', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '1');
INSERT INTO `items` VALUES ('1291', '24', '8020101', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '0');
INSERT INTO `items` VALUES ('1303', '13', '8881011', '40', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '4');
INSERT INTO `items` VALUES ('1304', '13', '8020101', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '0');
INSERT INTO `items` VALUES ('1305', '13', '8090011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '12');
INSERT INTO `items` VALUES ('1311', '24', '8510011', '1', '108', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '0');
INSERT INTO `items` VALUES ('1327', '16', '8110012', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '7');
INSERT INTO `items` VALUES ('1331', '25', '8910031', '19', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '5');
INSERT INTO `items` VALUES ('1333', '25', '8910061', '72', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '6');
INSERT INTO `items` VALUES ('1335', '25', '8910051', '38', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '7');
INSERT INTO `items` VALUES ('1337', '25', '8910071', '40', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '8');
INSERT INTO `items` VALUES ('1340', '25', '8910101', '16', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '3');
INSERT INTO `items` VALUES ('1342', '10', '8090011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '9');
INSERT INTO `items` VALUES ('1351', '25', '8910121', '21', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '4');
INSERT INTO `items` VALUES ('1353', '26', '8110011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '1');
INSERT INTO `items` VALUES ('1354', '26', '8510011', '1', '92', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '5');
INSERT INTO `items` VALUES ('1364', '25', '8910081', '5', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '2');
INSERT INTO `items` VALUES ('1369', '25', '8070101', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '0');
INSERT INTO `items` VALUES ('1379', '27', '9510081', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '11');
INSERT INTO `items` VALUES ('1380', '27', '8610473', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '6');
INSERT INTO `items` VALUES ('1382', '27', '8493021', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '4');
INSERT INTO `items` VALUES ('1383', '25', '8140101', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '1');
INSERT INTO `items` VALUES ('1392', '25', '8910141', '77', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '9');
INSERT INTO `items` VALUES ('1393', '25', '8910161', '67', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '1');
INSERT INTO `items` VALUES ('1396', '18', '8510011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '2');
INSERT INTO `items` VALUES ('1402', '27', '8990002', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '2');
INSERT INTO `items` VALUES ('1403', '27', '8990003', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '3');
INSERT INTO `items` VALUES ('1404', '27', '8990012', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '4');
INSERT INTO `items` VALUES ('1408', '27', '8710223', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '9');
INSERT INTO `items` VALUES ('1410', '26', '8910011', '26', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '0');
INSERT INTO `items` VALUES ('1411', '26', '8910021', '22', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '1');
INSERT INTO `items` VALUES ('1412', '26', '8990002', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '2');
INSERT INTO `items` VALUES ('1413', '26', '8990003', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '3');
INSERT INTO `items` VALUES ('1414', '26', '8990012', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '4');
INSERT INTO `items` VALUES ('1415', '26', '8910051', '19', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '5');
INSERT INTO `items` VALUES ('1417', '26', '8910061', '6', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '6');
INSERT INTO `items` VALUES ('1418', '26', '8510011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '0');
INSERT INTO `items` VALUES ('1420', '26', '8910081', '7', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '7');
INSERT INTO `items` VALUES ('1421', '26', '8910161', '7', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '8');
INSERT INTO `items` VALUES ('1422', '26', '8880011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '2');
INSERT INTO `items` VALUES ('1423', '26', '8910031', '14', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '9');
INSERT INTO `items` VALUES ('1427', '26', '8910071', '5', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '10');
INSERT INTO `items` VALUES ('1428', '26', '8910101', '17', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '11');
INSERT INTO `items` VALUES ('1429', '26', '8910141', '2', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '12');
INSERT INTO `items` VALUES ('1469', '28', '8910011', '15', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '0');
INSERT INTO `items` VALUES ('1471', '28', '8120011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '0');
INSERT INTO `items` VALUES ('1472', '28', '8910021', '15', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '1');
INSERT INTO `items` VALUES ('1476', '24', '8510011', '1', '98', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '1');
INSERT INTO `items` VALUES ('1488', '28', '9510111', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '11');
INSERT INTO `items` VALUES ('1489', '28', '8493032', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '4');
INSERT INTO `items` VALUES ('1504', '28', '8910051', '11', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '2');
INSERT INTO `items` VALUES ('1505', '28', '8130012', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '1');
INSERT INTO `items` VALUES ('1506', '28', '8130012', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '2');
INSERT INTO `items` VALUES ('1507', '28', '8510011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '1');
INSERT INTO `items` VALUES ('1508', '28', '8910061', '21', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '9');
INSERT INTO `items` VALUES ('1510', '28', '8910031', '26', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '4');
INSERT INTO `items` VALUES ('1511', '28', '8910071', '57', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '5');
INSERT INTO `items` VALUES ('1512', '28', '8510011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '2');
INSERT INTO `items` VALUES ('1513', '28', '8510011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '3');
INSERT INTO `items` VALUES ('1514', '28', '8510011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '4');
INSERT INTO `items` VALUES ('1520', '24', '8510021', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '4');
INSERT INTO `items` VALUES ('1521', '24', '8910211', '3', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '2');
INSERT INTO `items` VALUES ('1522', '24', '8510021', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '5');
INSERT INTO `items` VALUES ('1523', '24', '8510021', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '6');
INSERT INTO `items` VALUES ('1524', '24', '8810011', '14', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '4');
INSERT INTO `items` VALUES ('1527', '24', '8910141', '13', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '3');
INSERT INTO `items` VALUES ('1528', '24', '8510021', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '7');
INSERT INTO `items` VALUES ('1529', '24', '8850021', '5', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '3');
INSERT INTO `items` VALUES ('1531', '24', '8910141', '100', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '1');
INSERT INTO `items` VALUES ('1532', '24', '8910181', '100', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '0');
INSERT INTO `items` VALUES ('1536', '24', '8510021', '1', '130', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '3');
INSERT INTO `items` VALUES ('1537', '24', '8120012', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '0');
INSERT INTO `items` VALUES ('1538', '24', '8910011', '3', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '4');
INSERT INTO `items` VALUES ('1539', '24', '8910051', '7', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '5');
INSERT INTO `items` VALUES ('1540', '24', '8910021', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '6');
INSERT INTO `items` VALUES ('1541', '24', '8910061', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '7');
INSERT INTO `items` VALUES ('1542', '24', '8910071', '2', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '8');
INSERT INTO `items` VALUES ('1543', '24', '8910101', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '9');
INSERT INTO `items` VALUES ('1544', '24', '8910161', '78', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '10');
INSERT INTO `items` VALUES ('1545', '24', '8880011', '24', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '6');
INSERT INTO `items` VALUES ('1546', '24', '8910121', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '11');
INSERT INTO `items` VALUES ('1547', '24', '8910141', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '12');
INSERT INTO `items` VALUES ('1548', '24', '8110101', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '1');
INSERT INTO `items` VALUES ('1549', '24', '8130102', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '2');
INSERT INTO `items` VALUES ('1550', '24', '8810011', '2', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '5');
INSERT INTO `items` VALUES ('1552', '28', '8110011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '3');
INSERT INTO `items` VALUES ('1553', '28', '8910121', '34', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '6');
INSERT INTO `items` VALUES ('1554', '28', '8510011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '5');
INSERT INTO `items` VALUES ('1555', '28', '8910101', '5', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '7');
INSERT INTO `items` VALUES ('1556', '28', '8030101', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '4');
INSERT INTO `items` VALUES ('1557', '28', '8010011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '5');
INSERT INTO `items` VALUES ('1558', '28', '8010011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '6');
INSERT INTO `items` VALUES ('1559', '28', '8030011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '7');
INSERT INTO `items` VALUES ('1560', '28', '8030011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '8');
INSERT INTO `items` VALUES ('1561', '28', '8510011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '0');
INSERT INTO `items` VALUES ('1562', '28', '8010011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '9');
INSERT INTO `items` VALUES ('1563', '28', '8110101', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '10');
INSERT INTO `items` VALUES ('1564', '28', '8880011', '5', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '1');
INSERT INTO `items` VALUES ('1565', '28', '8010011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '12');
INSERT INTO `items` VALUES ('1566', '28', '8110101', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '13');
INSERT INTO `items` VALUES ('1567', '28', '8510011', '1', '32', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '5');
INSERT INTO `items` VALUES ('1568', '28', '8510011', '1', '107', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '23');
INSERT INTO `items` VALUES ('1569', '28', '8990006', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '3');
INSERT INTO `items` VALUES ('1570', '28', '8990012', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '8');
INSERT INTO `items` VALUES ('1571', '28', '8990009', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '10');
INSERT INTO `items` VALUES ('1572', '28', '8110011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '1');
INSERT INTO `items` VALUES ('1573', '28', '8020101', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '0');
INSERT INTO `items` VALUES ('1574', '28', '8990002', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '11');
INSERT INTO `items` VALUES ('1575', '28', '8990003', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '12');
INSERT INTO `items` VALUES ('1576', '28', '8820011', '75', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '2');
INSERT INTO `items` VALUES ('1577', '28', '8810011', '15', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '0');
INSERT INTO `items` VALUES ('1578', '30', '8010011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '0');
INSERT INTO `items` VALUES ('1579', '30', '8120012', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '1');
INSERT INTO `items` VALUES ('1580', '30', '8510011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '5');
INSERT INTO `items` VALUES ('1581', '30', '8810011', '10', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '0');
INSERT INTO `items` VALUES ('1582', '30', '8820011', '10', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '1');
INSERT INTO `items` VALUES ('1593', '31', '9410163', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '12');
INSERT INTO `items` VALUES ('1620', '31', '9510867', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '11');
INSERT INTO `items` VALUES ('1621', '31', '8493354', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '4');
INSERT INTO `items` VALUES ('1622', '18', '8910121', '30', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '6');
INSERT INTO `items` VALUES ('1623', '18', '8010011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '6');
INSERT INTO `items` VALUES ('1624', '18', '8510011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '3');
INSERT INTO `items` VALUES ('1625', '18', '8880011', '6', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '2');
INSERT INTO `items` VALUES ('1626', '18', '8510011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '4');
INSERT INTO `items` VALUES ('1627', '18', '8990012', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '7');
INSERT INTO `items` VALUES ('1628', '18', '8030011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '7');
INSERT INTO `items` VALUES ('1629', '18', '8820011', '13', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '1');
INSERT INTO `items` VALUES ('1630', '18', '8030011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '8');
INSERT INTO `items` VALUES ('1631', '18', '8990007', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '8');
INSERT INTO `items` VALUES ('1632', '18', '8030101', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '0');
INSERT INTO `items` VALUES ('1633', '18', '8030011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '5');
INSERT INTO `items` VALUES ('1643', '31', '8510021', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '2');
INSERT INTO `items` VALUES ('1664', '24', '8130102', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '3');
INSERT INTO `items` VALUES ('1665', '24', '8050101', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '4');
INSERT INTO `items` VALUES ('1666', '24', '8130102', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '5');
INSERT INTO `items` VALUES ('1667', '24', '8020101', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '6');
INSERT INTO `items` VALUES ('1668', '24', '8050101', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '7');
INSERT INTO `items` VALUES ('1669', '24', '8810011', '4', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '2');
INSERT INTO `items` VALUES ('1670', '24', '8120102', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '8');
INSERT INTO `items` VALUES ('1671', '24', '8020101', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '9');
INSERT INTO `items` VALUES ('1672', '24', '8120102', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '10');
INSERT INTO `items` VALUES ('1673', '24', '8020101', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '11');
INSERT INTO `items` VALUES ('1674', '24', '8510021', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '8');
INSERT INTO `items` VALUES ('1675', '24', '8050101', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '12');
INSERT INTO `items` VALUES ('1676', '24', '8130102', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '13');
INSERT INTO `items` VALUES ('1677', '24', '8810011', '100', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '0');
INSERT INTO `items` VALUES ('1678', '24', '8120102', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '14');
INSERT INTO `items` VALUES ('1679', '24', '8050101', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '15');
INSERT INTO `items` VALUES ('1680', '24', '8810011', '4', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '7');
INSERT INTO `items` VALUES ('1681', '24', '8010101', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '16');
INSERT INTO `items` VALUES ('1682', '24', '8510021', '1', '19', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '5');
INSERT INTO `items` VALUES ('1683', '24', '8510021', '1', '130', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '2');
INSERT INTO `items` VALUES ('1684', '24', '8120102', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '17');
INSERT INTO `items` VALUES ('1685', '24', '8050101', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '18');
INSERT INTO `items` VALUES ('1686', '24', '8510021', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '9');
INSERT INTO `items` VALUES ('1687', '24', '8910181', '8', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '13');
INSERT INTO `items` VALUES ('1688', '24', '8020101', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '19');
INSERT INTO `items` VALUES ('1689', '24', '8820011', '26', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '1');
INSERT INTO `items` VALUES ('1704', '29', '8910051', '63', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '1');
INSERT INTO `items` VALUES ('1709', '23', '8910181', '9', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '14');
INSERT INTO `items` VALUES ('1710', '23', '8130102', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '4');
INSERT INTO `items` VALUES ('1711', '23', '8060101', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '0');
INSERT INTO `items` VALUES ('1712', '23', '8050101', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '3');
INSERT INTO `items` VALUES ('1713', '23', '8510021', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '3');
INSERT INTO `items` VALUES ('1714', '23', '8820011', '11', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '1');
INSERT INTO `items` VALUES ('1715', '23', '8810011', '29', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '0');
INSERT INTO `items` VALUES ('1716', '23', '8990012', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '15');
INSERT INTO `items` VALUES ('1731', '29', '8910031', '35', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '0');
INSERT INTO `items` VALUES ('1739', '25', '8510011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '5');
INSERT INTO `items` VALUES ('1742', '25', '8070201', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '0');
INSERT INTO `items` VALUES ('1746', '29', '8493091', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '4');
INSERT INTO `items` VALUES ('1748', '29', '8110011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '1');
INSERT INTO `items` VALUES ('1754', '29', '8910081', '14', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '2');
INSERT INTO `items` VALUES ('1755', '29', '8910071', '52', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '6');
INSERT INTO `items` VALUES ('1759', '29', '8910121', '67', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '3');
INSERT INTO `items` VALUES ('1764', '29', '8880011', '34', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '3');
INSERT INTO `items` VALUES ('1773', '25', '8910011', '10', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '10');
INSERT INTO `items` VALUES ('1775', '25', '8910021', '4', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '0');
INSERT INTO `items` VALUES ('1780', '25', '8910181', '6', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '11');
INSERT INTO `items` VALUES ('1781', '25', '8910211', '7', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '12');
INSERT INTO `items` VALUES ('1783', '25', '8810011', '46', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '0');
INSERT INTO `items` VALUES ('1784', '25', '8820011', '100', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '4');
INSERT INTO `items` VALUES ('1787', '25', '8510011', '1', '36', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '5');
INSERT INTO `items` VALUES ('1806', '21', '8820011', '16', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '1');
INSERT INTO `items` VALUES ('1814', '31', '8910301', '37', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '0');
INSERT INTO `items` VALUES ('1831', '31', '8710223', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '9');
INSERT INTO `items` VALUES ('1834', '31', '8810021', '100', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '6');
INSERT INTO `items` VALUES ('1859', '31', '8610603', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '6');
INSERT INTO `items` VALUES ('1861', '29', '8910101', '16', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '7');
INSERT INTO `items` VALUES ('1863', '29', '8910141', '56', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '8');
INSERT INTO `items` VALUES ('1866', '29', '8010101', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '0');
INSERT INTO `items` VALUES ('1867', '29', '8910181', '57', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '4');
INSERT INTO `items` VALUES ('1868', '29', '8880021', '5', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '2');
INSERT INTO `items` VALUES ('1869', '29', '8910211', '49', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '5');
INSERT INTO `items` VALUES ('1870', '29', '8110101', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '2');
INSERT INTO `items` VALUES ('1871', '29', '8910221', '21', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '11');
INSERT INTO `items` VALUES ('1878', '32', '7940011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '0');
INSERT INTO `items` VALUES ('1879', '32', '8120011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '1');
INSERT INTO `items` VALUES ('1880', '32', '8510011', '1', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '5');
INSERT INTO `items` VALUES ('1881', '32', '8810011', '10', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '0');
INSERT INTO `items` VALUES ('1882', '32', '8820011', '10', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '1');
INSERT INTO `items` VALUES ('1883', '32', '9510041', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '11');
INSERT INTO `items` VALUES ('1884', '32', '8493181', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '4');
INSERT INTO `items` VALUES ('1885', '32', '8610111', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '6');
INSERT INTO `items` VALUES ('1886', '32', '9410133', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '12');
INSERT INTO `items` VALUES ('1887', '32', '8710013', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '9');
INSERT INTO `items` VALUES ('1888', '32', '8910021', '2', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '0');
INSERT INTO `items` VALUES ('1889', '32', '8910011', '2', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '1');
INSERT INTO `items` VALUES ('1890', '33', '8010011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '0');
INSERT INTO `items` VALUES ('1891', '33', '8110011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '1');
INSERT INTO `items` VALUES ('1892', '33', '8510011', '1', '3', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '5');
INSERT INTO `items` VALUES ('1893', '33', '8810011', '10', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '0');
INSERT INTO `items` VALUES ('1894', '33', '8820011', '10', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '1');
INSERT INTO `items` VALUES ('1895', '33', '8910021', '2', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '0');
INSERT INTO `items` VALUES ('1901', '26', '8910121', '5', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '13');
INSERT INTO `items` VALUES ('1902', '26', '8910181', '5', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '14');
INSERT INTO `items` VALUES ('1903', '26', '8910211', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '15');
INSERT INTO `items` VALUES ('1904', '26', '8910201', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '16');
INSERT INTO `items` VALUES ('1908', '26', '8990008', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '17');
INSERT INTO `items` VALUES ('1921', '26', '8050101', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '0');
INSERT INTO `items` VALUES ('1922', '26', '8060011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '1');
INSERT INTO `items` VALUES ('1923', '26', '8990011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '18');
INSERT INTO `items` VALUES ('1924', '26', '8810011', '20', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '3');
INSERT INTO `items` VALUES ('1925', '26', '8810011', '2', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '0');
INSERT INTO `items` VALUES ('1926', '26', '8130012', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '0');
INSERT INTO `items` VALUES ('1927', '26', '8820011', '36', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '4');
INSERT INTO `items` VALUES ('1930', '13', '8810011', '19', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '0');
INSERT INTO `items` VALUES ('1931', '13', '8820011', '2', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '1');
INSERT INTO `items` VALUES ('1948', '29', '9510465', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '11');
INSERT INTO `items` VALUES ('1952', '34', '8810011', '28', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '0');
INSERT INTO `items` VALUES ('1967', '29', '8510021', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '2');
INSERT INTO `items` VALUES ('1970', '34', '8910011', '9', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '0');
INSERT INTO `items` VALUES ('1971', '34', '8910021', '13', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '1');
INSERT INTO `items` VALUES ('1973', '34', '8910061', '73', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '2');
INSERT INTO `items` VALUES ('1974', '1', '8841001', '20', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '1', '0', '-1', '6', '0');
INSERT INTO `items` VALUES ('1975', '1', '8841002', '20', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '1', '0', '-1', '6', '1');
INSERT INTO `items` VALUES ('1976', '1', '8841003', '20', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '1', '0', '-1', '6', '2');
INSERT INTO `items` VALUES ('1977', '1', '8841004', '20', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '1', '0', '-1', '6', '5');
INSERT INTO `items` VALUES ('1978', '1', '8841005', '20', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '1', '0', '-1', '6', '6');
INSERT INTO `items` VALUES ('1979', '1', '8841006', '20', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '1', '0', '-1', '6', '7');
INSERT INTO `items` VALUES ('1980', '1', '7820501', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '1', '0', '-1', '6', '8');
INSERT INTO `items` VALUES ('1984', '1', '8950530', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '6');
INSERT INTO `items` VALUES ('1985', '1', '8950532', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '8');
INSERT INTO `items` VALUES ('1986', '1', '8820011', '8', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '14');
INSERT INTO `items` VALUES ('1991', '1', '8910151', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '9');
INSERT INTO `items` VALUES ('1992', '1', '8910141', '10', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '10');
INSERT INTO `items` VALUES ('1993', '35', '8010011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '0');
INSERT INTO `items` VALUES ('1994', '35', '8110012', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '1');
INSERT INTO `items` VALUES ('1995', '35', '8510011', '1', '10', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '5');
INSERT INTO `items` VALUES ('1998', '35', '8820011', '10', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '1');
INSERT INTO `items` VALUES ('1999', '35', '8810011', '9', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '0');
INSERT INTO `items` VALUES ('2000', '35', '8910011', '8', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '0');
INSERT INTO `items` VALUES ('2001', '35', '8120012', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '0');
INSERT INTO `items` VALUES ('2002', '35', '8910021', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '1');
INSERT INTO `items` VALUES ('2003', '34', '8910051', '13', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '3');
INSERT INTO `items` VALUES ('2004', '34', '8910031', '37', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '4');
INSERT INTO `items` VALUES ('2005', '34', '8510011', '1', '4', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '5');
INSERT INTO `items` VALUES ('2006', '34', '8510011', '1', '31', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '1');
INSERT INTO `items` VALUES ('2007', '34', '8910071', '55', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '5');
INSERT INTO `items` VALUES ('2008', '34', '8910072', '46', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '6');
INSERT INTO `items` VALUES ('2009', '34', '8910121', '3', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '7');
INSERT INTO `items` VALUES ('2010', '34', '8510011', '1', '114', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '8');
INSERT INTO `items` VALUES ('2011', '34', '8880011', '100', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '2');
INSERT INTO `items` VALUES ('2012', '34', '8990012', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '8');
INSERT INTO `items` VALUES ('2013', '34', '8990002', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '9');
INSERT INTO `items` VALUES ('2014', '34', '8990003', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '10');
INSERT INTO `items` VALUES ('2015', '34', '8510011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '2');
INSERT INTO `items` VALUES ('2016', '34', '8130012', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '1');
INSERT INTO `items` VALUES ('2017', '34', '8510011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '3');
INSERT INTO `items` VALUES ('2018', '34', '8510011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '4');
INSERT INTO `items` VALUES ('2019', '34', '8820011', '58', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '1');
INSERT INTO `items` VALUES ('2020', '34', '8850021', '2', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '3');
INSERT INTO `items` VALUES ('2021', '34', '8990008', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '11');
INSERT INTO `items` VALUES ('2023', '34', '8810042', '2', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '6');
INSERT INTO `items` VALUES ('2025', '34', '8810032', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '8');
INSERT INTO `items` VALUES ('2027', '34', '8810062', '2', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '9');
INSERT INTO `items` VALUES ('2028', '34', '8820022', '2', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '10');
INSERT INTO `items` VALUES ('2031', '34', '8820012', '3', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '12');
INSERT INTO `items` VALUES ('2037', '34', '8990011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '23');
INSERT INTO `items` VALUES ('2038', '1', '8910031', '2', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '11');
INSERT INTO `items` VALUES ('2040', '34', '8820052', '2', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '15');
INSERT INTO `items` VALUES ('2041', '34', '8820042', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '17');
INSERT INTO `items` VALUES ('2042', '34', '8810062', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '5');
INSERT INTO `items` VALUES ('2043', '34', '8881041', '10', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '4');
INSERT INTO `items` VALUES ('2044', '34', '8050101', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '0');
INSERT INTO `items` VALUES ('2045', '34', '8090011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '30', '0', '0', '-1', '1', '0');
INSERT INTO `items` VALUES ('2046', '34', '8510011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '5');
INSERT INTO `items` VALUES ('2047', '34', '8030011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '1');
INSERT INTO `items` VALUES ('2048', '34', '8910101', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '12');
INSERT INTO `items` VALUES ('2049', '34', '8120101', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '2');
INSERT INTO `items` VALUES ('2074', '14', '8510011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '1');
INSERT INTO `items` VALUES ('2075', '14', '8510011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '2');
INSERT INTO `items` VALUES ('2076', '14', '8130012', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '3');
INSERT INTO `items` VALUES ('2081', '14', '9510111', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '11');
INSERT INTO `items` VALUES ('2082', '14', '8493088', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '4');
INSERT INTO `items` VALUES ('2105', '14', '8130011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '1');
INSERT INTO `items` VALUES ('2106', '14', '8110011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '2');
INSERT INTO `items` VALUES ('2107', '14', '8910061', '8', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '4');
INSERT INTO `items` VALUES ('2108', '14', '8910031', '5', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '5');
INSERT INTO `items` VALUES ('2109', '14', '8910071', '2', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '6');
INSERT INTO `items` VALUES ('2113', '14', '8842002', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '1', '0', '-1', '3', '4');
INSERT INTO `items` VALUES ('2114', '14', '8842002', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '1', '0', '-1', '3', '5');
INSERT INTO `items` VALUES ('2115', '14', '8842002', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '1', '0', '-1', '3', '6');
INSERT INTO `items` VALUES ('2116', '14', '8842002', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '1', '0', '-1', '3', '2');
INSERT INTO `items` VALUES ('2117', '14', '8890037', '99', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '3');
INSERT INTO `items` VALUES ('2118', '14', '8950106', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '8');
INSERT INTO `items` VALUES ('2119', '14', '8950107', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '3');
INSERT INTO `items` VALUES ('2120', '14', '8950102', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '7');
INSERT INTO `items` VALUES ('2121', '14', '8820011', '12', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '1');
INSERT INTO `items` VALUES ('2124', '1', '8842002', '99', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '2');
INSERT INTO `items` VALUES ('2132', '36', '8010011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '0');
INSERT INTO `items` VALUES ('2133', '36', '8120011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '1');
INSERT INTO `items` VALUES ('2134', '36', '8510011', '1', '3', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '5');
INSERT INTO `items` VALUES ('2135', '36', '8810011', '10', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '0');
INSERT INTO `items` VALUES ('2136', '36', '8820011', '10', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '1');
INSERT INTO `items` VALUES ('2137', '36', '8950102', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '1', '0', '-1', '4', '0');
INSERT INTO `items` VALUES ('2138', '36', '8493121', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '4');
INSERT INTO `items` VALUES ('2139', '36', '9510253', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '11');
INSERT INTO `items` VALUES ('2141', '36', '8610031', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '6');
INSERT INTO `items` VALUES ('2142', '36', '9410273', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '12');
INSERT INTO `items` VALUES ('2143', '36', '8910011', '4', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '1');
INSERT INTO `items` VALUES ('2144', '36', '8120012', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '0');
INSERT INTO `items` VALUES ('2145', '36', '8130011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '1');
INSERT INTO `items` VALUES ('2146', '13', '8842002', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '1', '0', '-1', '3', '5');
INSERT INTO `items` VALUES ('2147', '13', '8950501', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '18');
INSERT INTO `items` VALUES ('2148', '13', '8950103', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '19');
INSERT INTO `items` VALUES ('2149', '29', '8510021', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '3');
INSERT INTO `items` VALUES ('2150', '29', '8510021', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '5');
INSERT INTO `items` VALUES ('2151', '29', '8510021', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '0');
INSERT INTO `items` VALUES ('2155', '29', '8120011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '1');
INSERT INTO `items` VALUES ('2159', '29', '8510021', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '4');
INSERT INTO `items` VALUES ('2164', '29', '8610457', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '6');
INSERT INTO `items` VALUES ('2165', '13', '8130012', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '13');
INSERT INTO `items` VALUES ('2167', '29', '8510021', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '8');
INSERT INTO `items` VALUES ('2173', '29', '8910161', '100', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '9');
INSERT INTO `items` VALUES ('2176', '31', '8510021', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '3');
INSERT INTO `items` VALUES ('2177', '31', '8510021', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '4');
INSERT INTO `items` VALUES ('2183', '31', '8510021', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '5');
INSERT INTO `items` VALUES ('2188', '31', '8510021', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '6');
INSERT INTO `items` VALUES ('2207', '31', '8510011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '1');
INSERT INTO `items` VALUES ('2208', '31', '8510011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '0');
INSERT INTO `items` VALUES ('2211', '31', '8910241', '33', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '2');
INSERT INTO `items` VALUES ('2214', '31', '8910211', '7', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '1');
INSERT INTO `items` VALUES ('2216', '31', '8510031', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '7');
INSERT INTO `items` VALUES ('2217', '31', '8520011', '1', '130', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '8');
INSERT INTO `items` VALUES ('2234', '10', '8890037', '67', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '19');
INSERT INTO `items` VALUES ('2241', '29', '8510021', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '7');
INSERT INTO `items` VALUES ('2247', '31', '8210241', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '2');
INSERT INTO `items` VALUES ('2263', '1', '8990002', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '2');
INSERT INTO `items` VALUES ('2264', '1', '8910011', '82', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '0');
INSERT INTO `items` VALUES ('2265', '1', '8890037', '58', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '19');
INSERT INTO `items` VALUES ('2270', '1', '8020401', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '5');
INSERT INTO `items` VALUES ('2271', '1', '8910441', '21', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '12');
INSERT INTO `items` VALUES ('2272', '1', '8810021', '3', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '11');
INSERT INTO `items` VALUES ('2273', '1', '8820031', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '18');
INSERT INTO `items` VALUES ('2275', '1', '8120012', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '7');
INSERT INTO `items` VALUES ('2285', '31', '8910221', '6', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '5');
INSERT INTO `items` VALUES ('2302', '1', '8493012', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '10');
INSERT INTO `items` VALUES ('2303', '1', '8493085', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '0');
INSERT INTO `items` VALUES ('2306', '1', '8880011', '3', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '20');
INSERT INTO `items` VALUES ('2312', '1', '8020401', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '10');
INSERT INTO `items` VALUES ('2313', '1', '8910281', '82', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '13');
INSERT INTO `items` VALUES ('2337', '31', '8310321', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '3');
INSERT INTO `items` VALUES ('2351', '10', '8950501', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '1', '0', '-1', '4', '9');
INSERT INTO `items` VALUES ('2352', '10', '8950513', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '10');
INSERT INTO `items` VALUES ('2360', '1', '8090011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '2');
INSERT INTO `items` VALUES ('2362', '1', '8493092', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '2');
INSERT INTO `items` VALUES ('2363', '1', '8493091', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '4');
INSERT INTO `items` VALUES ('2364', '1', '8493093', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '5');
INSERT INTO `items` VALUES ('2365', '1', '8493094', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '6');
INSERT INTO `items` VALUES ('2366', '1', '8493352', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '7');
INSERT INTO `items` VALUES ('2367', '1', '8493391', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '1');
INSERT INTO `items` VALUES ('2368', '1', '8493422', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '11');
INSERT INTO `items` VALUES ('2370', '1', '8950106', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '7');
INSERT INTO `items` VALUES ('2374', '10', '8950102', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '16');
INSERT INTO `items` VALUES ('2375', '10', '8950107', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '15');
INSERT INTO `items` VALUES ('2376', '10', '8950106', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '13');
INSERT INTO `items` VALUES ('2377', '10', '8950104', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '14');
INSERT INTO `items` VALUES ('2378', '10', '8950101', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '11');
INSERT INTO `items` VALUES ('2379', '10', '8950103', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '12');
INSERT INTO `items` VALUES ('2380', '10', '8861011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '22');
INSERT INTO `items` VALUES ('2381', '10', '8860011', '99', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '21');
INSERT INTO `items` VALUES ('2384', '10', '8051321', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '16');
INSERT INTO `items` VALUES ('2387', '10', '8810011', '2', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '6');
INSERT INTO `items` VALUES ('2388', '10', '8820011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '9');
INSERT INTO `items` VALUES ('2389', '10', '8910011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '17');
INSERT INTO `items` VALUES ('2392', '1', '8520011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '8');
INSERT INTO `items` VALUES ('2393', '1', '8510011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '9');
INSERT INTO `items` VALUES ('2406', '10', '8521001', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '10');
INSERT INTO `items` VALUES ('2407', '10', '8860101', '91', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '7');
INSERT INTO `items` VALUES ('2408', '10', '9510216', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '0');
INSERT INTO `items` VALUES ('2409', '10', '9510384', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '11');
INSERT INTO `items` VALUES ('2410', '10', '9510042', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '7');
INSERT INTO `items` VALUES ('2413', '1', '8510101', '1', '30000', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '12');
INSERT INTO `items` VALUES ('2417', '1', '8510101', '1', '30000', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '16');
INSERT INTO `items` VALUES ('2418', '1', '8510101', '1', '30000', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '17');
INSERT INTO `items` VALUES ('2419', '1', '8510101', '1', '30000', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '18');
INSERT INTO `items` VALUES ('2420', '1', '8510101', '1', '30000', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '19');
INSERT INTO `items` VALUES ('2421', '1', '8510101', '1', '30000', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '20');
INSERT INTO `items` VALUES ('2422', '1', '8510101', '1', '30000', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '21');
INSERT INTO `items` VALUES ('2425', '10', '8310407', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '3');
INSERT INTO `items` VALUES ('2426', '10', '8310406', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '0');
INSERT INTO `items` VALUES ('2427', '10', '8510101', '1', '5', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '5');
INSERT INTO `items` VALUES ('2431', '27', '8910121', '31', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '8');
INSERT INTO `items` VALUES ('2432', '27', '8910161', '3', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '10');
INSERT INTO `items` VALUES ('2433', '27', '8910071', '3', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '11');
INSERT INTO `items` VALUES ('2440', '37', '8060011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '0');
INSERT INTO `items` VALUES ('2441', '37', '8110012', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '1');
INSERT INTO `items` VALUES ('2442', '37', '8510011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '5');
INSERT INTO `items` VALUES ('2443', '37', '8810011', '10', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '0');
INSERT INTO `items` VALUES ('2444', '37', '8820011', '10', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '1');
INSERT INTO `items` VALUES ('2463', '29', '8510021', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '6');
INSERT INTO `items` VALUES ('2464', '29', '8910201', '33', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '10');
INSERT INTO `items` VALUES ('2465', '29', '8810021', '4', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '1');
INSERT INTO `items` VALUES ('2466', '29', '8510021', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '1');
INSERT INTO `items` VALUES ('2467', '29', '8210161', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '2');
INSERT INTO `items` VALUES ('2468', '29', '8510021', '1', '59', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '5');
INSERT INTO `items` VALUES ('2469', '29', '8810011', '77', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '0');
INSERT INTO `items` VALUES ('2470', '29', '8820021', '100', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '7');
INSERT INTO `items` VALUES ('2471', '29', '8820021', '100', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '8');
INSERT INTO `items` VALUES ('2472', '29', '8850061', '9', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '5');
INSERT INTO `items` VALUES ('2473', '29', '8850021', '8', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '4');
INSERT INTO `items` VALUES ('2474', '29', '8010011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '3');
INSERT INTO `items` VALUES ('2475', '29', '8020201', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '4');
INSERT INTO `items` VALUES ('2476', '29', '8810031', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '9');
INSERT INTO `items` VALUES ('2477', '29', '8820011', '7', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '10');
INSERT INTO `items` VALUES ('2478', '29', '8910011', '5', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '12');
INSERT INTO `items` VALUES ('2479', '29', '8910021', '4', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '13');
INSERT INTO `items` VALUES ('2480', '29', '8010011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '6');
INSERT INTO `items` VALUES ('2481', '29', '8110101', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '7');
INSERT INTO `items` VALUES ('2482', '29', '8510021', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '9');
INSERT INTO `items` VALUES ('2483', '29', '8820021', '71', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '6');
INSERT INTO `items` VALUES ('2484', '29', '8110101', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '8');
INSERT INTO `items` VALUES ('2485', '29', '8110011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '9');
INSERT INTO `items` VALUES ('2486', '29', '8090011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '4', '0', '0', '-1', '0', '0');
INSERT INTO `items` VALUES ('2487', '29', '8010101', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '2', '3', '5', '0', '0', '-1', '1', '5');
INSERT INTO `items` VALUES ('2488', '29', '8810062', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '12');
INSERT INTO `items` VALUES ('2489', '29', '8970002', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '14');
INSERT INTO `items` VALUES ('2490', '29', '8810022', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '13');
INSERT INTO `items` VALUES ('2491', '29', '8970005', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '15');
INSERT INTO `items` VALUES ('2494', '10', '8910441', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '18');
INSERT INTO `items` VALUES ('2496', '10', '8051501', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '20');
INSERT INTO `items` VALUES ('2497', '10', '8051321', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '23');
INSERT INTO `items` VALUES ('2498', '10', '8051531', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '21');
INSERT INTO `items` VALUES ('2499', '10', '8051281', '1', '0', '10', '0', '0', '0', '0', '0', '0', '0', '0', '0', '10', '0', '0', '-1', '0', '0');
INSERT INTO `items` VALUES ('2500', '10', '8051361', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '19');
INSERT INTO `items` VALUES ('2501', '31', '8850061', '5', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '0');
INSERT INTO `items` VALUES ('2506', '31', '8510061', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '10');
INSERT INTO `items` VALUES ('2509', '31', '8510061', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '11');
INSERT INTO `items` VALUES ('2510', '31', '8510061', '1', '69', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '5');
INSERT INTO `items` VALUES ('2511', '31', '8510061', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '9');
INSERT INTO `items` VALUES ('2514', '31', '8510061', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '12');
INSERT INTO `items` VALUES ('2520', '31', '8820012', '2', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '13');
INSERT INTO `items` VALUES ('2524', '31', '8810032', '2', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '14');
INSERT INTO `items` VALUES ('2525', '31', '8820022', '2', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '15');
INSERT INTO `items` VALUES ('2527', '31', '8910281', '20', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '4');
INSERT INTO `items` VALUES ('2528', '31', '8910421', '19', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '3');
INSERT INTO `items` VALUES ('2530', '31', '8810062', '2', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '16');
INSERT INTO `items` VALUES ('2541', '31', '8810022', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '21');
INSERT INTO `items` VALUES ('2545', '31', '8020351', '1', '0', '0', '0', '0', '0', '4', '0', '0', '0', '0', '0', '4', '0', '0', '-1', '0', '0');
INSERT INTO `items` VALUES ('2546', '27', '8910101', '19', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '0');
INSERT INTO `items` VALUES ('2547', '27', '8210081', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '2');
INSERT INTO `items` VALUES ('2548', '27', '8510021', '1', '14', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '5');
INSERT INTO `items` VALUES ('2549', '27', '8510011', '1', '100', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '2', '1');
INSERT INTO `items` VALUES ('2550', '27', '8910011', '5', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '1');
INSERT INTO `items` VALUES ('2551', '27', '8910021', '4', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '5');
INSERT INTO `items` VALUES ('2552', '27', '8990011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '6');
INSERT INTO `items` VALUES ('2553', '27', '8060101', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '0');
INSERT INTO `items` VALUES ('2554', '27', '8060011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '0');
INSERT INTO `items` VALUES ('2555', '27', '8130101', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '1');
INSERT INTO `items` VALUES ('2556', '27', '8810011', '61', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '1');
INSERT INTO `items` VALUES ('2557', '27', '8880011', '2', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '2');
INSERT INTO `items` VALUES ('2558', '27', '8820011', '52', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '0');
INSERT INTO `items` VALUES ('2559', '27', '8120101', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '1');
INSERT INTO `items` VALUES ('2562', '1', '8110101', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '8');
INSERT INTO `items` VALUES ('2567', '1', '8910241', '80', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '15');
INSERT INTO `items` VALUES ('2568', '1', '8910211', '60', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '18');
INSERT INTO `items` VALUES ('2570', '1', '8910321', '60', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '19');
INSERT INTO `items` VALUES ('2571', '1', '8910221', '80', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '20');
INSERT INTO `items` VALUES ('2572', '1', '8950105', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '14');
INSERT INTO `items` VALUES ('2573', '1', '8910261', '64', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '16');
INSERT INTO `items` VALUES ('2574', '1', '8890021', '7', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '22');
INSERT INTO `items` VALUES ('2575', '1', '8850071', '90', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '15');
INSERT INTO `items` VALUES ('2576', '31', '8110351', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '0', '1');
INSERT INTO `items` VALUES ('2580', '1', '8020401', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '9');
INSERT INTO `items` VALUES ('2581', '1', '8910121', '4', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '17');
INSERT INTO `items` VALUES ('2582', '31', '8810021', '92', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '3', '7');
INSERT INTO `items` VALUES ('2583', '10', '8910141', '2', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '4', '19');
INSERT INTO `items` VALUES ('2585', '1', '8010101', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '6');
INSERT INTO `items` VALUES ('2586', '1', '8010011', '1', '0', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '1', '0', '0', '-1', '0', '0');
INSERT INTO `items` VALUES ('2587', '1', '8010011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '12');
INSERT INTO `items` VALUES ('2588', '1', '8110011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '2', '3', '0', '0', '-1', '0', '1');
INSERT INTO `items` VALUES ('2589', '1', '8192001', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '-1', '1', '14');

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
INSERT INTO `keymaps` VALUES ('8', 'Z', '1', '0', '0');
INSERT INTO `keymaps` VALUES ('8', 'X', '4', '0', '3');
INSERT INTO `keymaps` VALUES ('8', 'C', '3', '0', '2');
INSERT INTO `keymaps` VALUES ('8', 'V', '8820011', '3', '3');
INSERT INTO `keymaps` VALUES ('11', 'Z', '1', '0', '0');
INSERT INTO `keymaps` VALUES ('11', 'X', '4', '0', '3');
INSERT INTO `keymaps` VALUES ('11', 'C', '3', '0', '2');
INSERT INTO `keymaps` VALUES ('11', 'Delete', '8820041', '3', '3');
INSERT INTO `keymaps` VALUES ('11', 'Insert', '8810031', '3', '0');
INSERT INTO `keymaps` VALUES ('9', 'Z', '1', '0', '0');
INSERT INTO `keymaps` VALUES ('9', 'X', '3', '0', '2');
INSERT INTO `keymaps` VALUES ('9', 'C', '4', '0', '3');
INSERT INTO `keymaps` VALUES ('7', 'Z', '1', '0', '0');
INSERT INTO `keymaps` VALUES ('7', 'X', '4', '0', '3');
INSERT INTO `keymaps` VALUES ('7', 'C', '3', '0', '2');
INSERT INTO `keymaps` VALUES ('15', 'Z', '1', '0', '0');
INSERT INTO `keymaps` VALUES ('15', 'X', '4', '0', '3');
INSERT INTO `keymaps` VALUES ('15', 'C', '3', '0', '2');
INSERT INTO `keymaps` VALUES ('15', '5', '8820011', '3', '1');
INSERT INTO `keymaps` VALUES ('15', '6', '8810011', '3', '0');
INSERT INTO `keymaps` VALUES ('12', 'Z', '1', '0', '0');
INSERT INTO `keymaps` VALUES ('12', 'X', '4', '0', '3');
INSERT INTO `keymaps` VALUES ('12', 'C', '3', '0', '2');
INSERT INTO `keymaps` VALUES ('20', 'Z', '1', '0', '0');
INSERT INTO `keymaps` VALUES ('20', 'C', '8810011', '3', '0');
INSERT INTO `keymaps` VALUES ('20', 'V', '3', '0', '2');
INSERT INTO `keymaps` VALUES ('16', 'Z', '1', '0', '0');
INSERT INTO `keymaps` VALUES ('16', 'X', '4', '0', '3');
INSERT INTO `keymaps` VALUES ('16', 'C', '3', '0', '2');
INSERT INTO `keymaps` VALUES ('16', '5', '8820011', '3', '1');
INSERT INTO `keymaps` VALUES ('16', '6', '8810011', '3', '0');
INSERT INTO `keymaps` VALUES ('6', 'Z', '1', '0', '0');
INSERT INTO `keymaps` VALUES ('6', 'X', '4', '0', '3');
INSERT INTO `keymaps` VALUES ('6', 'C', '3', '0', '2');
INSERT INTO `keymaps` VALUES ('28', 'Z', '1', '0', '0');
INSERT INTO `keymaps` VALUES ('28', 'X', '4', '0', '3');
INSERT INTO `keymaps` VALUES ('28', 'C', '3', '0', '2');
INSERT INTO `keymaps` VALUES ('28', 'Insert', '8820011', '3', '2');
INSERT INTO `keymaps` VALUES ('28', 'Delete', '8810011', '3', '0');
INSERT INTO `keymaps` VALUES ('30', 'Z', '1', '0', '0');
INSERT INTO `keymaps` VALUES ('30', 'X', '4', '0', '3');
INSERT INTO `keymaps` VALUES ('30', 'C', '3', '0', '2');
INSERT INTO `keymaps` VALUES ('18', 'Z', '1', '0', '0');
INSERT INTO `keymaps` VALUES ('18', 'X', '4', '0', '3');
INSERT INTO `keymaps` VALUES ('18', 'C', '3', '0', '2');
INSERT INTO `keymaps` VALUES ('18', '5', '8820011', '3', '1');
INSERT INTO `keymaps` VALUES ('18', '6', '8810011', '3', '0');
INSERT INTO `keymaps` VALUES ('17', 'Home', '8810011', '3', '0');
INSERT INTO `keymaps` VALUES ('17', 'Z', '4', '0', '3');
INSERT INTO `keymaps` VALUES ('17', 'N', '1', '0', '0');
INSERT INTO `keymaps` VALUES ('17', 'B', '3', '0', '2');
INSERT INTO `keymaps` VALUES ('17', 'Insert', '8810011', '3', '0');
INSERT INTO `keymaps` VALUES ('24', 'Z', '1', '0', '0');
INSERT INTO `keymaps` VALUES ('24', 'X', '4', '0', '3');
INSERT INTO `keymaps` VALUES ('24', 'C', '10103', '1', '1');
INSERT INTO `keymaps` VALUES ('24', 'Insert', '8820011', '3', '1');
INSERT INTO `keymaps` VALUES ('24', '2', '8810011', '3', '0');
INSERT INTO `keymaps` VALUES ('24', 'Delete', '8810011', '3', '0');
INSERT INTO `keymaps` VALUES ('22', 'N', '8810011', '3', '0');
INSERT INTO `keymaps` VALUES ('22', 'B', '8820011', '3', '1');
INSERT INTO `keymaps` VALUES ('22', 'PageUp', '3', '0', '2');
INSERT INTO `keymaps` VALUES ('22', 'Home', '1', '0', '0');
INSERT INTO `keymaps` VALUES ('22', 'Z', '4', '0', '3');
INSERT INTO `keymaps` VALUES ('25', 'Z', '10403', '1', '2');
INSERT INTO `keymaps` VALUES ('25', 'N', '1', '0', '0');
INSERT INTO `keymaps` VALUES ('25', '2', '8810011', '3', '0');
INSERT INTO `keymaps` VALUES ('25', 'X', '4', '0', '3');
INSERT INTO `keymaps` VALUES ('25', 'Delete', '8810011', '3', '0');
INSERT INTO `keymaps` VALUES ('25', 'V', '1', '0', '0');
INSERT INTO `keymaps` VALUES ('21', 'Z', '3', '0', '2');
INSERT INTO `keymaps` VALUES ('21', 'X', '4', '0', '3');
INSERT INTO `keymaps` VALUES ('21', 'C', '1', '0', '0');
INSERT INTO `keymaps` VALUES ('19', 'Z', '1', '0', '0');
INSERT INTO `keymaps` VALUES ('19', 'X', '4', '0', '3');
INSERT INTO `keymaps` VALUES ('19', 'C', '3', '0', '2');
INSERT INTO `keymaps` VALUES ('19', '6', '8810011', '3', '0');
INSERT INTO `keymaps` VALUES ('19', '5', '8820011', '3', '1');
INSERT INTO `keymaps` VALUES ('23', 'Z', '4', '0', '3');
INSERT INTO `keymaps` VALUES ('23', 'C', '3', '0', '2');
INSERT INTO `keymaps` VALUES ('23', 'V', '1', '0', '0');
INSERT INTO `keymaps` VALUES ('23', 'Delete', '8810011', '3', '0');
INSERT INTO `keymaps` VALUES ('23', 'PageUp', '8820011', '3', '1');
INSERT INTO `keymaps` VALUES ('32', 'Z', '1', '0', '0');
INSERT INTO `keymaps` VALUES ('32', 'X', '3', '0', '2');
INSERT INTO `keymaps` VALUES ('32', 'C', '4', '0', '3');
INSERT INTO `keymaps` VALUES ('32', 'End', '8810011', '3', '0');
INSERT INTO `keymaps` VALUES ('32', 'Delete', '8820011', '3', '1');
INSERT INTO `keymaps` VALUES ('33', 'Z', '1', '0', '0');
INSERT INTO `keymaps` VALUES ('33', 'X', '4', '0', '3');
INSERT INTO `keymaps` VALUES ('33', 'C', '3', '0', '2');
INSERT INTO `keymaps` VALUES ('33', '5', '8820011', '3', '1');
INSERT INTO `keymaps` VALUES ('33', '6', '8810011', '3', '0');
INSERT INTO `keymaps` VALUES ('33', 'Insert', '8820011', '3', '1');
INSERT INTO `keymaps` VALUES ('33', 'Home', '8820011', '3', '1');
INSERT INTO `keymaps` VALUES ('33', 'PageUp', '8820011', '3', '1');
INSERT INTO `keymaps` VALUES ('26', 'Z', '1', '0', '0');
INSERT INTO `keymaps` VALUES ('26', 'X', '4', '0', '3');
INSERT INTO `keymaps` VALUES ('26', 'C', '3', '0', '2');
INSERT INTO `keymaps` VALUES ('26', '5', '8820011', '3', '4');
INSERT INTO `keymaps` VALUES ('26', '6', '8810011', '3', '0');
INSERT INTO `keymaps` VALUES ('35', 'Z', '1', '0', '0');
INSERT INTO `keymaps` VALUES ('35', 'X', '4', '0', '3');
INSERT INTO `keymaps` VALUES ('35', 'C', '3', '0', '2');
INSERT INTO `keymaps` VALUES ('35', 'Delete', '8820011', '3', '1');
INSERT INTO `keymaps` VALUES ('35', 'End', '8810011', '3', '0');
INSERT INTO `keymaps` VALUES ('34', 'Z', '1', '0', '0');
INSERT INTO `keymaps` VALUES ('34', 'X', '4', '0', '3');
INSERT INTO `keymaps` VALUES ('34', 'C', '3', '0', '2');
INSERT INTO `keymaps` VALUES ('34', '6', '8820011', '3', '1');
INSERT INTO `keymaps` VALUES ('14', 'Z', '1', '0', '0');
INSERT INTO `keymaps` VALUES ('14', 'X', '4', '0', '3');
INSERT INTO `keymaps` VALUES ('14', 'C', '3', '0', '2');
INSERT INTO `keymaps` VALUES ('14', 'V', '3', '0', '2');
INSERT INTO `keymaps` VALUES ('4', 'Z', '1', '0', '0');
INSERT INTO `keymaps` VALUES ('4', 'X', '4', '0', '3');
INSERT INTO `keymaps` VALUES ('4', 'C', '3', '0', '2');
INSERT INTO `keymaps` VALUES ('4', 'V', '10207', '1', '0');
INSERT INTO `keymaps` VALUES ('36', 'Z', '1', '0', '0');
INSERT INTO `keymaps` VALUES ('36', 'X', '3', '0', '2');
INSERT INTO `keymaps` VALUES ('36', 'C', '4', '0', '3');
INSERT INTO `keymaps` VALUES ('37', 'Z', '1', '0', '0');
INSERT INTO `keymaps` VALUES ('37', 'X', '4', '0', '3');
INSERT INTO `keymaps` VALUES ('37', 'C', '3', '0', '2');
INSERT INTO `keymaps` VALUES ('29', 'Z', '1', '0', '0');
INSERT INTO `keymaps` VALUES ('29', 'X', '4', '0', '3');
INSERT INTO `keymaps` VALUES ('29', 'C', '3', '0', '2');
INSERT INTO `keymaps` VALUES ('29', 'B', '8820021', '3', '6');
INSERT INTO `keymaps` VALUES ('29', 'N', '10106', '1', '4');
INSERT INTO `keymaps` VALUES ('29', '5', '10105', '1', '2');
INSERT INTO `keymaps` VALUES ('29', 'V', '8810011', '3', '0');
INSERT INTO `keymaps` VALUES ('27', 'Z', '4', '0', '3');
INSERT INTO `keymaps` VALUES ('27', 'Insert', '1', '0', '0');
INSERT INTO `keymaps` VALUES ('27', 'Delete', '3', '0', '2');
INSERT INTO `keymaps` VALUES ('27', 'Home', '8820011', '3', '0');
INSERT INTO `keymaps` VALUES ('27', 'PageUp', '8810011', '3', '1');
INSERT INTO `keymaps` VALUES ('13', 'Z', '1', '0', '0');
INSERT INTO `keymaps` VALUES ('13', 'X', '4', '0', '3');
INSERT INTO `keymaps` VALUES ('13', 'C', '3', '0', '2');
INSERT INTO `keymaps` VALUES ('13', '5', '8820011', '3', '1');
INSERT INTO `keymaps` VALUES ('13', '6', '8810011', '3', '0');
INSERT INTO `keymaps` VALUES ('31', 'N', '1', '0', '0');
INSERT INTO `keymaps` VALUES ('31', 'Z', '10103', '1', '1');
INSERT INTO `keymaps` VALUES ('31', 'X', '10108', '1', '2');
INSERT INTO `keymaps` VALUES ('31', 'Insert', '8820021', '3', '3');
INSERT INTO `keymaps` VALUES ('31', 'B', '3', '0', '2');
INSERT INTO `keymaps` VALUES ('31', 'C', '4', '0', '3');
INSERT INTO `keymaps` VALUES ('31', 'Home', '10107', '1', '3');
INSERT INTO `keymaps` VALUES ('31', '6', '8810021', '3', '8');
INSERT INTO `keymaps` VALUES ('31', '5', '8820031', '3', '4');
INSERT INTO `keymaps` VALUES ('10', '2', '1', '0', '0');
INSERT INTO `keymaps` VALUES ('10', 'Z', '22302', '2', '1');
INSERT INTO `keymaps` VALUES ('10', '1', '3', '0', '2');
INSERT INTO `keymaps` VALUES ('10', 'V', '10306', '1', '5');
INSERT INTO `keymaps` VALUES ('10', 'Insert', '32301', '3', '0');
INSERT INTO `keymaps` VALUES ('10', 'X', '10303', '1', '2');
INSERT INTO `keymaps` VALUES ('10', 'C', '10305', '1', '3');
INSERT INTO `keymaps` VALUES ('10', 'B', '10307', '1', '6');
INSERT INTO `keymaps` VALUES ('10', 'N', '10308', '1', '7');
INSERT INTO `keymaps` VALUES ('10', '3', '10309', '1', '8');
INSERT INTO `keymaps` VALUES ('10', '4', '10310', '1', '9');
INSERT INTO `keymaps` VALUES ('10', 'Home', '32302', '3', '2');
INSERT INTO `keymaps` VALUES ('10', 'PageUp', '8890031', '3', '20');
INSERT INTO `keymaps` VALUES ('10', 'Delete', '8890037', '3', '19');
INSERT INTO `keymaps` VALUES ('10', 'End', '32302', '3', '2');
INSERT INTO `keymaps` VALUES ('10', 'PageDown', '10309', '1', '8');
INSERT INTO `keymaps` VALUES ('1', 'Z', '1', '0', '0');
INSERT INTO `keymaps` VALUES ('1', 'X', '4', '0', '3');
INSERT INTO `keymaps` VALUES ('1', 'C', '3', '0', '2');
INSERT INTO `keymaps` VALUES ('1', 'V', '10207', '1', '1');
INSERT INTO `keymaps` VALUES ('1', 'Insert', '10106', '1', '7');
INSERT INTO `keymaps` VALUES ('1', 'Home', '10105', '1', '6');
INSERT INTO `keymaps` VALUES ('1', 'PageUp', '10106', '1', '7');
INSERT INTO `keymaps` VALUES ('1', 'Delete', '10107', '1', '8');
INSERT INTO `keymaps` VALUES ('1', 'End', '10104', '1', '5');
INSERT INTO `keymaps` VALUES ('1', 'B', '10105', '1', '6');
INSERT INTO `keymaps` VALUES ('1', 'N', '10108', '1', '9');
INSERT INTO `keymaps` VALUES ('1', 'PageDown', '10105', '1', '6');

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
INSERT INTO `pets` VALUES ('4', '5', '9212011', '0', '', '1', '100', '100', '0', '0', '10');
INSERT INTO `pets` VALUES ('5', '2', '9212011', '0', '', '1', '100', '100', '0', '0', '10');
INSERT INTO `pets` VALUES ('6', '7', '9212011', '0', '', '1', '100', '100', '0', '0', '10');
INSERT INTO `pets` VALUES ('7', '8', '9212011', '0', '', '1', '100', '100', '0', '0', '10');
INSERT INTO `pets` VALUES ('8', '9', '9212011', '0', '', '1', '100', '100', '0', '0', '10');
INSERT INTO `pets` VALUES ('9', '2', '9220011', '0', '', '1', '100', '100', '0', '5', '1');
INSERT INTO `pets` VALUES ('10', '2', '9212011', '0', '', '1', '100', '100', '0', '0', '10');
INSERT INTO `pets` VALUES ('12', '11', '9212011', '0', '', '1', '100', '100', '0', '0', '10');
INSERT INTO `pets` VALUES ('13', '13', '9212011', '0', '', '1', '100', '100', '0', '0', '10');
INSERT INTO `pets` VALUES ('40', '16', '9212014', '0', '', '1', '100', '100', '0', '0', '10');
INSERT INTO `pets` VALUES ('41', '19', '9212011', '0', '', '1', '100', '100', '0', '0', '10');
INSERT INTO `pets` VALUES ('43', '20', '9212014', '0', '', '1', '100', '100', '0', '0', '10');
INSERT INTO `pets` VALUES ('44', '17', '9212014', '0', '', '1', '100', '100', '0', '5', '0');
INSERT INTO `pets` VALUES ('45', '17', '9212023', '0', '', '1', '100', '100', '0', '0', '10');
INSERT INTO `pets` VALUES ('46', '23', '9212011', '0', '', '1', '100', '100', '0', '0', '10');
INSERT INTO `pets` VALUES ('47', '24', '9212021', '0', '', '1', '100', '100', '0', '0', '10');
INSERT INTO `pets` VALUES ('48', '26', '9212013', '0', '', '1', '100', '100', '0', '0', '10');
INSERT INTO `pets` VALUES ('49', '27', '9212013', '0', '', '1', '100', '100', '0', '0', '10');
INSERT INTO `pets` VALUES ('50', '28', '9212014', '0', '', '1', '100', '100', '0', '0', '10');
INSERT INTO `pets` VALUES ('51', '1', '9210021', '0', '', '1', '100', '100', '0', '5', '0');
INSERT INTO `pets` VALUES ('59', '14', '7820501', '0', '', '1', '100', '100', '0', '5', '0');
INSERT INTO `pets` VALUES ('61', '14', '9212011', '0', '', '1', '100', '100', '0', '0', '10');
INSERT INTO `pets` VALUES ('62', '14', '9212014', '0', '', '1', '100', '100', '0', '5', '1');
INSERT INTO `pets` VALUES ('63', '36', '9212022', '0', '', '1', '100', '100', '0', '0', '10');
INSERT INTO `pets` VALUES ('73', '1', '9212023', '0', 'adsadasd', '1', '100', '100', '0', '5', '4');
INSERT INTO `pets` VALUES ('74', '1', '9210012', '0', '', '1', '100', '100', '0', '5', '1');
INSERT INTO `pets` VALUES ('76', '1', '9212022', '0', '', '1', '100', '100', '0', '5', '2');

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
INSERT INTO `quests` VALUES ('1', '2', '2', '0', '0', '0', '49');
INSERT INTO `quests` VALUES ('2', '4', '3', '0', '0', '0', '50');
INSERT INTO `quests` VALUES ('3', '4', '4', '0', '0', '0', '50');
INSERT INTO `quests` VALUES ('4', '1', '3', '0', '0', '0', '50');
INSERT INTO `quests` VALUES ('5', '1', '4', '0', '0', '0', '50');
INSERT INTO `quests` VALUES ('6', '2', '6', '0', '0', '0', '50');
INSERT INTO `quests` VALUES ('7', '2', '43', '0', '0', '0', '50');
INSERT INTO `quests` VALUES ('8', '2', '52', '0', '0', '0', '49');
INSERT INTO `quests` VALUES ('9', '2', '7', '0', '0', '0', '49');
INSERT INTO `quests` VALUES ('10', '2', '5', '0', '0', '0', '49');
INSERT INTO `quests` VALUES ('11', '2', '3', '0', '0', '0', '50');
INSERT INTO `quests` VALUES ('12', '2', '4', '0', '0', '0', '50');
INSERT INTO `quests` VALUES ('14', '2', '44', '0', '0', '0', '49');
INSERT INTO `quests` VALUES ('52', '1', '52', '5', '0', '0', '50');
INSERT INTO `quests` VALUES ('54', '11', '2', '0', '0', '100', '49');
INSERT INTO `quests` VALUES ('55', '11', '3', '0', '0', '0', '50');
INSERT INTO `quests` VALUES ('56', '11', '5', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('57', '11', '52', '5', '0', '0', '50');
INSERT INTO `quests` VALUES ('63', '11', '19', '1', '3', '3', '50');
INSERT INTO `quests` VALUES ('64', '11', '6', '0', '0', '100', '49');
INSERT INTO `quests` VALUES ('66', '1', '19', '0', '3', '3', '50');
INSERT INTO `quests` VALUES ('67', '1', '32', '2', '0', '0', '50');
INSERT INTO `quests` VALUES ('69', '11', '32', '2', '0', '0', '50');
INSERT INTO `quests` VALUES ('71', '11', '33', '3', '0', '0', '50');
INSERT INTO `quests` VALUES ('96', '1', '2', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('97', '13', '5', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('98', '13', '52', '5', '0', '0', '50');
INSERT INTO `quests` VALUES ('99', '13', '2', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('100', '13', '3', '0', '0', '0', '50');
INSERT INTO `quests` VALUES ('101', '13', '4', '0', '0', '0', '50');
INSERT INTO `quests` VALUES ('109', '13', '568', '0', '0', '100', '49');
INSERT INTO `quests` VALUES ('115', '10', '125', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('116', '10', '182', '0', '0', '100', '49');
INSERT INTO `quests` VALUES ('117', '10', '127', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('118', '10', '108', '2', '0', '100', '50');
INSERT INTO `quests` VALUES ('119', '10', '126', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('120', '13', '6', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('121', '13', '16', '1', '3', '3', '50');
INSERT INTO `quests` VALUES ('122', '13', '23', '3', '0', '0', '50');
INSERT INTO `quests` VALUES ('123', '13', '7', '0', '0', '100', '49');
INSERT INTO `quests` VALUES ('124', '15', '351', '1', '3', '3', '50');
INSERT INTO `quests` VALUES ('125', '15', '352', '2', '0', '0', '50');
INSERT INTO `quests` VALUES ('126', '15', '2', '0', '0', '100', '49');
INSERT INTO `quests` VALUES ('127', '16', '566', '1', '0', '100', '50');
INSERT INTO `quests` VALUES ('128', '16', '567', '0', '20', '100', '50');
INSERT INTO `quests` VALUES ('129', '16', '3', '0', '0', '0', '50');
INSERT INTO `quests` VALUES ('130', '17', '566', '1', '0', '100', '50');
INSERT INTO `quests` VALUES ('131', '17', '567', '0', '20', '100', '50');
INSERT INTO `quests` VALUES ('132', '17', '568', '0', '0', '100', '49');
INSERT INTO `quests` VALUES ('133', '17', '3', '0', '0', '0', '50');
INSERT INTO `quests` VALUES ('134', '17', '4', '0', '0', '0', '50');
INSERT INTO `quests` VALUES ('135', '17', '52', '4', '0', '0', '49');
INSERT INTO `quests` VALUES ('136', '17', '2', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('137', '17', '5', '0', '0', '100', '49');
INSERT INTO `quests` VALUES ('138', '16', '5', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('139', '16', '52', '5', '0', '0', '50');
INSERT INTO `quests` VALUES ('140', '16', '2', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('141', '16', '6', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('142', '16', '4', '0', '0', '0', '50');
INSERT INTO `quests` VALUES ('143', '16', '574', '0', '0', '100', '49');
INSERT INTO `quests` VALUES ('144', '16', '573', '0', '0', '100', '49');
INSERT INTO `quests` VALUES ('145', '16', '568', '0', '0', '100', '49');
INSERT INTO `quests` VALUES ('146', '21', '2', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('147', '21', '3', '0', '0', '0', '50');
INSERT INTO `quests` VALUES ('148', '21', '4', '0', '0', '0', '50');
INSERT INTO `quests` VALUES ('149', '21', '52', '5', '0', '0', '50');
INSERT INTO `quests` VALUES ('150', '21', '5', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('151', '22', '3', '0', '0', '0', '50');
INSERT INTO `quests` VALUES ('152', '22', '4', '0', '0', '0', '50');
INSERT INTO `quests` VALUES ('153', '22', '2', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('154', '22', '52', '5', '0', '0', '50');
INSERT INTO `quests` VALUES ('155', '23', '3', '0', '0', '0', '50');
INSERT INTO `quests` VALUES ('156', '23', '4', '0', '0', '0', '50');
INSERT INTO `quests` VALUES ('157', '23', '6', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('158', '23', '21', '1', '3', '3', '50');
INSERT INTO `quests` VALUES ('159', '23', '43', '3', '0', '0', '50');
INSERT INTO `quests` VALUES ('160', '23', '2', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('161', '24', '3', '0', '0', '0', '50');
INSERT INTO `quests` VALUES ('162', '24', '6', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('163', '24', '52', '5', '0', '0', '50');
INSERT INTO `quests` VALUES ('164', '24', '5', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('165', '24', '4', '0', '0', '0', '50');
INSERT INTO `quests` VALUES ('166', '24', '16', '1', '3', '3', '50');
INSERT INTO `quests` VALUES ('167', '24', '23', '3', '0', '0', '50');
INSERT INTO `quests` VALUES ('168', '25', '3', '0', '0', '0', '50');
INSERT INTO `quests` VALUES ('169', '25', '2', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('170', '25', '52', '5', '0', '0', '50');
INSERT INTO `quests` VALUES ('171', '25', '4', '0', '0', '0', '50');
INSERT INTO `quests` VALUES ('172', '25', '5', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('173', '25', '6', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('174', '25', '351', '1', '3', '3', '50');
INSERT INTO `quests` VALUES ('175', '25', '352', '2', '0', '0', '50');
INSERT INTO `quests` VALUES ('176', '25', '353', '3', '0', '0', '50');
INSERT INTO `quests` VALUES ('177', '26', '3', '0', '0', '0', '50');
INSERT INTO `quests` VALUES ('178', '26', '4', '0', '0', '0', '50');
INSERT INTO `quests` VALUES ('179', '26', '52', '5', '0', '0', '50');
INSERT INTO `quests` VALUES ('180', '25', '7', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('181', '27', '2', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('182', '27', '3', '0', '0', '0', '50');
INSERT INTO `quests` VALUES ('183', '27', '4', '0', '0', '0', '50');
INSERT INTO `quests` VALUES ('184', '27', '52', '5', '0', '0', '50');
INSERT INTO `quests` VALUES ('185', '26', '2', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('186', '26', '5', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('187', '27', '5', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('188', '24', '25', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('189', '28', '5', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('190', '28', '16', '1', '3', '3', '50');
INSERT INTO `quests` VALUES ('191', '28', '22', '2', '0', '0', '50');
INSERT INTO `quests` VALUES ('192', '28', '52', '5', '0', '0', '50');
INSERT INTO `quests` VALUES ('193', '28', '23', '3', '0', '0', '50');
INSERT INTO `quests` VALUES ('194', '28', '6', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('195', '28', '2', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('196', '28', '3', '0', '0', '0', '50');
INSERT INTO `quests` VALUES ('197', '28', '4', '0', '0', '0', '50');
INSERT INTO `quests` VALUES ('198', '28', '7', '0', '0', '100', '49');
INSERT INTO `quests` VALUES ('199', '31', '3', '0', '0', '0', '50');
INSERT INTO `quests` VALUES ('200', '31', '4', '0', '0', '0', '50');
INSERT INTO `quests` VALUES ('201', '31', '2', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('202', '31', '52', '5', '0', '0', '50');
INSERT INTO `quests` VALUES ('203', '31', '5', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('204', '31', '6', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('205', '31', '16', '1', '3', '3', '50');
INSERT INTO `quests` VALUES ('206', '31', '23', '3', '0', '0', '50');
INSERT INTO `quests` VALUES ('207', '31', '7', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('208', '18', '2', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('209', '18', '52', '5', '0', '0', '50');
INSERT INTO `quests` VALUES ('210', '18', '5', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('211', '18', '19', '1', '3', '3', '50');
INSERT INTO `quests` VALUES ('212', '18', '33', '3', '0', '0', '50');
INSERT INTO `quests` VALUES ('213', '31', '8', '0', '11', '100', '50');
INSERT INTO `quests` VALUES ('215', '31', '566', '1', '0', '100', '50');
INSERT INTO `quests` VALUES ('216', '31', '574', '0', '23', '20', '50');
INSERT INTO `quests` VALUES ('219', '31', '567', '0', '24', '20', '50');
INSERT INTO `quests` VALUES ('220', '31', '570', '1', '0', '0', '50');
INSERT INTO `quests` VALUES ('221', '31', '571', '1', '0', '100', '50');
INSERT INTO `quests` VALUES ('222', '31', '25', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('223', '31', '9', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('224', '31', '10', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('226', '31', '11', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('227', '31', '27', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('228', '31', '12', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('229', '23', '5', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('230', '23', '52', '0', '0', '0', '49');
INSERT INTO `quests` VALUES ('231', '25', '568', '0', '0', '100', '49');
INSERT INTO `quests` VALUES ('232', '25', '570', '1', '0', '0', '50');
INSERT INTO `quests` VALUES ('233', '25', '573', '0', '0', '100', '49');
INSERT INTO `quests` VALUES ('234', '29', '52', '5', '0', '0', '50');
INSERT INTO `quests` VALUES ('235', '29', '5', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('236', '29', '3', '0', '0', '0', '50');
INSERT INTO `quests` VALUES ('237', '29', '2', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('238', '29', '4', '0', '0', '0', '50');
INSERT INTO `quests` VALUES ('239', '29', '16', '1', '3', '3', '50');
INSERT INTO `quests` VALUES ('240', '29', '22', '2', '0', '0', '50');
INSERT INTO `quests` VALUES ('241', '29', '6', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('242', '25', '354', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('243', '31', '115', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('244', '31', '675', '1', '0', '100', '50');
INSERT INTO `quests` VALUES ('245', '31', '676', '1', '0', '100', '50');
INSERT INTO `quests` VALUES ('246', '31', '53', '2', '0', '0', '50');
INSERT INTO `quests` VALUES ('247', '31', '28', '0', '36', '20', '50');
INSERT INTO `quests` VALUES ('248', '31', '114', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('249', '31', '57', '0', '20', '100', '50');
INSERT INTO `quests` VALUES ('250', '29', '23', '3', '0', '0', '50');
INSERT INTO `quests` VALUES ('251', '29', '7', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('254', '26', '6', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('255', '26', '21', '1', '3', '3', '50');
INSERT INTO `quests` VALUES ('256', '26', '42', '2', '0', '0', '50');
INSERT INTO `quests` VALUES ('258', '26', '43', '3', '0', '0', '50');
INSERT INTO `quests` VALUES ('259', '26', '7', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('261', '34', '2', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('262', '34', '52', '5', '0', '0', '50');
INSERT INTO `quests` VALUES ('263', '34', '5', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('264', '34', '3', '0', '0', '0', '50');
INSERT INTO `quests` VALUES ('265', '34', '4', '0', '0', '0', '50');
INSERT INTO `quests` VALUES ('266', '34', '6', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('267', '34', '21', '1', '3', '3', '50');
INSERT INTO `quests` VALUES ('268', '34', '42', '2', '0', '0', '50');
INSERT INTO `quests` VALUES ('269', '34', '43', '3', '0', '0', '50');
INSERT INTO `quests` VALUES ('270', '29', '24', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('271', '29', '25', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('272', '31', '116', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('274', '31', '55', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('276', '31', '69', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('277', '31', '56', '0', '0', '100', '49');
INSERT INTO `quests` VALUES ('278', '31', '14', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('280', '29', '10', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('281', '29', '11', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('282', '29', '26', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('283', '29', '27', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('284', '29', '8', '0', '10', '100', '50');
INSERT INTO `quests` VALUES ('285', '29', '9', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('286', '27', '6', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('287', '27', '21', '1', '3', '3', '50');
INSERT INTO `quests` VALUES ('288', '27', '43', '3', '0', '0', '50');
INSERT INTO `quests` VALUES ('289', '27', '7', '0', '0', '100', '50');
INSERT INTO `quests` VALUES ('290', '1', '22', '0', '0', '0', '50');
INSERT INTO `quests` VALUES ('293', '1', '69', '0', '0', '100', '49');
INSERT INTO `quests` VALUES ('298', '1', '68', '0', '0', '100', '49');

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
) ENGINE=InnoDB AUTO_INCREMENT=209 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of skills
-- ----------------------------
INSERT INTO `skills` VALUES ('1', '1', '1', '5', '0', '0');
INSERT INTO `skills` VALUES ('2', '1', '2', '10', '0', '1');
INSERT INTO `skills` VALUES ('3', '1', '3', '1', '0', '2');
INSERT INTO `skills` VALUES ('4', '1', '4', '20', '0', '3');
INSERT INTO `skills` VALUES ('13', '4', '1', '1', '0', '0');
INSERT INTO `skills` VALUES ('14', '4', '2', '1', '0', '1');
INSERT INTO `skills` VALUES ('15', '4', '3', '1', '0', '2');
INSERT INTO `skills` VALUES ('16', '4', '4', '1', '0', '3');
INSERT INTO `skills` VALUES ('21', '6', '1', '1', '0', '0');
INSERT INTO `skills` VALUES ('22', '6', '2', '1', '0', '1');
INSERT INTO `skills` VALUES ('23', '6', '3', '1', '0', '2');
INSERT INTO `skills` VALUES ('24', '6', '4', '1', '0', '3');
INSERT INTO `skills` VALUES ('26', '7', '1', '5', '0', '0');
INSERT INTO `skills` VALUES ('27', '7', '2', '9', '0', '1');
INSERT INTO `skills` VALUES ('28', '7', '3', '1', '0', '2');
INSERT INTO `skills` VALUES ('29', '7', '4', '7', '0', '3');
INSERT INTO `skills` VALUES ('30', '8', '1', '5', '0', '0');
INSERT INTO `skills` VALUES ('31', '8', '2', '2', '0', '1');
INSERT INTO `skills` VALUES ('32', '8', '3', '1', '0', '2');
INSERT INTO `skills` VALUES ('33', '8', '4', '10', '0', '3');
INSERT INTO `skills` VALUES ('34', '9', '1', '5', '0', '0');
INSERT INTO `skills` VALUES ('35', '9', '2', '7', '0', '1');
INSERT INTO `skills` VALUES ('36', '9', '3', '1', '0', '2');
INSERT INTO `skills` VALUES ('37', '9', '4', '1', '0', '3');
INSERT INTO `skills` VALUES ('38', '10', '1', '5', '0', '0');
INSERT INTO `skills` VALUES ('39', '10', '2', '10', '0', '1');
INSERT INTO `skills` VALUES ('40', '10', '3', '20', '0', '2');
INSERT INTO `skills` VALUES ('41', '10', '4', '20', '0', '3');
INSERT INTO `skills` VALUES ('42', '10', '10302', '20', '1', '0');
INSERT INTO `skills` VALUES ('43', '10', '10301', '20', '1', '1');
INSERT INTO `skills` VALUES ('44', '10', '10303', '20', '1', '2');
INSERT INTO `skills` VALUES ('45', '10', '10305', '20', '1', '3');
INSERT INTO `skills` VALUES ('46', '10', '10304', '20', '1', '4');
INSERT INTO `skills` VALUES ('47', '10', '10306', '20', '1', '5');
INSERT INTO `skills` VALUES ('48', '10', '10307', '20', '1', '6');
INSERT INTO `skills` VALUES ('49', '10', '10308', '20', '1', '7');
INSERT INTO `skills` VALUES ('50', '11', '1', '5', '0', '0');
INSERT INTO `skills` VALUES ('51', '11', '2', '13', '0', '1');
INSERT INTO `skills` VALUES ('52', '11', '3', '1', '0', '2');
INSERT INTO `skills` VALUES ('53', '11', '4', '20', '0', '3');
INSERT INTO `skills` VALUES ('54', '10', '10309', '11', '1', '8');
INSERT INTO `skills` VALUES ('55', '10', '10310', '20', '1', '9');
INSERT INTO `skills` VALUES ('56', '12', '1', '1', '0', '0');
INSERT INTO `skills` VALUES ('57', '12', '2', '1', '0', '1');
INSERT INTO `skills` VALUES ('58', '12', '3', '1', '0', '2');
INSERT INTO `skills` VALUES ('59', '12', '4', '1', '0', '3');
INSERT INTO `skills` VALUES ('60', '1', '10201', '1', '1', '0');
INSERT INTO `skills` VALUES ('61', '11', '10201', '1', '1', '0');
INSERT INTO `skills` VALUES ('62', '11', '10202', '1', '1', '1');
INSERT INTO `skills` VALUES ('63', '13', '1', '5', '0', '0');
INSERT INTO `skills` VALUES ('64', '13', '2', '10', '0', '1');
INSERT INTO `skills` VALUES ('65', '13', '3', '6', '0', '2');
INSERT INTO `skills` VALUES ('66', '13', '4', '1', '0', '3');
INSERT INTO `skills` VALUES ('67', '10', '22301', '20', '2', '0');
INSERT INTO `skills` VALUES ('68', '14', '1', '5', '0', '0');
INSERT INTO `skills` VALUES ('69', '14', '2', '5', '0', '1');
INSERT INTO `skills` VALUES ('70', '14', '3', '1', '0', '2');
INSERT INTO `skills` VALUES ('71', '14', '4', '1', '0', '3');
INSERT INTO `skills` VALUES ('72', '10', '22302', '20', '2', '1');
INSERT INTO `skills` VALUES ('73', '13', '10102', '1', '1', '0');
INSERT INTO `skills` VALUES ('74', '15', '1', '5', '0', '0');
INSERT INTO `skills` VALUES ('75', '15', '2', '10', '0', '1');
INSERT INTO `skills` VALUES ('76', '15', '3', '6', '0', '2');
INSERT INTO `skills` VALUES ('77', '15', '4', '1', '0', '3');
INSERT INTO `skills` VALUES ('78', '15', '10401', '1', '1', '0');
INSERT INTO `skills` VALUES ('79', '4', '10207', '20', '1', '0');
INSERT INTO `skills` VALUES ('80', '4', '10207', '20', '1', '0');
INSERT INTO `skills` VALUES ('81', '16', '1', '1', '0', '0');
INSERT INTO `skills` VALUES ('82', '16', '2', '3', '0', '1');
INSERT INTO `skills` VALUES ('83', '16', '3', '1', '0', '2');
INSERT INTO `skills` VALUES ('84', '16', '4', '15', '0', '3');
INSERT INTO `skills` VALUES ('85', '17', '1', '5', '0', '0');
INSERT INTO `skills` VALUES ('86', '17', '2', '9', '0', '1');
INSERT INTO `skills` VALUES ('87', '17', '3', '1', '0', '2');
INSERT INTO `skills` VALUES ('88', '17', '4', '1', '0', '3');
INSERT INTO `skills` VALUES ('89', '18', '1', '5', '0', '0');
INSERT INTO `skills` VALUES ('90', '18', '2', '5', '0', '1');
INSERT INTO `skills` VALUES ('91', '18', '3', '9', '0', '2');
INSERT INTO `skills` VALUES ('92', '18', '4', '3', '0', '3');
INSERT INTO `skills` VALUES ('93', '19', '1', '5', '0', '0');
INSERT INTO `skills` VALUES ('94', '19', '2', '9', '0', '1');
INSERT INTO `skills` VALUES ('95', '19', '3', '1', '0', '2');
INSERT INTO `skills` VALUES ('96', '19', '4', '1', '0', '3');
INSERT INTO `skills` VALUES ('97', '20', '1', '5', '0', '0');
INSERT INTO `skills` VALUES ('98', '20', '2', '3', '0', '1');
INSERT INTO `skills` VALUES ('99', '20', '3', '1', '0', '2');
INSERT INTO `skills` VALUES ('100', '20', '4', '1', '0', '3');
INSERT INTO `skills` VALUES ('101', '21', '1', '5', '0', '0');
INSERT INTO `skills` VALUES ('102', '21', '2', '10', '0', '1');
INSERT INTO `skills` VALUES ('103', '21', '3', '2', '0', '2');
INSERT INTO `skills` VALUES ('104', '21', '4', '1', '0', '3');
INSERT INTO `skills` VALUES ('105', '22', '1', '5', '0', '0');
INSERT INTO `skills` VALUES ('106', '22', '2', '5', '0', '1');
INSERT INTO `skills` VALUES ('107', '22', '3', '1', '0', '2');
INSERT INTO `skills` VALUES ('108', '22', '4', '1', '0', '3');
INSERT INTO `skills` VALUES ('109', '23', '1', '5', '0', '0');
INSERT INTO `skills` VALUES ('110', '23', '2', '10', '0', '1');
INSERT INTO `skills` VALUES ('111', '23', '3', '1', '0', '2');
INSERT INTO `skills` VALUES ('112', '23', '4', '6', '0', '3');
INSERT INTO `skills` VALUES ('113', '24', '1', '5', '0', '0');
INSERT INTO `skills` VALUES ('114', '24', '2', '10', '0', '1');
INSERT INTO `skills` VALUES ('115', '24', '3', '6', '0', '2');
INSERT INTO `skills` VALUES ('116', '24', '4', '1', '0', '3');
INSERT INTO `skills` VALUES ('117', '23', '10302', '3', '1', '0');
INSERT INTO `skills` VALUES ('118', '25', '1', '5', '0', '0');
INSERT INTO `skills` VALUES ('119', '25', '2', '8', '0', '1');
INSERT INTO `skills` VALUES ('120', '25', '3', '1', '0', '2');
INSERT INTO `skills` VALUES ('121', '25', '4', '8', '0', '3');
INSERT INTO `skills` VALUES ('122', '24', '10102', '7', '1', '0');
INSERT INTO `skills` VALUES ('123', '26', '1', '5', '0', '0');
INSERT INTO `skills` VALUES ('124', '26', '2', '1', '0', '1');
INSERT INTO `skills` VALUES ('125', '26', '3', '5', '0', '2');
INSERT INTO `skills` VALUES ('126', '26', '4', '11', '0', '3');
INSERT INTO `skills` VALUES ('127', '25', '10401', '7', '1', '0');
INSERT INTO `skills` VALUES ('128', '25', '10402', '1', '1', '1');
INSERT INTO `skills` VALUES ('129', '27', '1', '5', '0', '0');
INSERT INTO `skills` VALUES ('130', '27', '2', '7', '0', '1');
INSERT INTO `skills` VALUES ('131', '27', '3', '2', '0', '2');
INSERT INTO `skills` VALUES ('132', '27', '4', '8', '0', '3');
INSERT INTO `skills` VALUES ('133', '28', '1', '5', '0', '0');
INSERT INTO `skills` VALUES ('134', '28', '2', '5', '0', '1');
INSERT INTO `skills` VALUES ('135', '28', '3', '1', '0', '2');
INSERT INTO `skills` VALUES ('136', '28', '4', '11', '0', '3');
INSERT INTO `skills` VALUES ('137', '24', '10103', '7', '1', '1');
INSERT INTO `skills` VALUES ('138', '29', '1', '5', '0', '0');
INSERT INTO `skills` VALUES ('139', '29', '2', '10', '0', '1');
INSERT INTO `skills` VALUES ('140', '29', '3', '11', '0', '2');
INSERT INTO `skills` VALUES ('141', '29', '4', '4', '0', '3');
INSERT INTO `skills` VALUES ('142', '28', '10101', '1', '1', '0');
INSERT INTO `skills` VALUES ('143', '28', '10102', '1', '1', '1');
INSERT INTO `skills` VALUES ('144', '30', '1', '1', '0', '0');
INSERT INTO `skills` VALUES ('145', '30', '2', '1', '0', '1');
INSERT INTO `skills` VALUES ('146', '30', '3', '1', '0', '2');
INSERT INTO `skills` VALUES ('147', '30', '4', '1', '0', '3');
INSERT INTO `skills` VALUES ('148', '31', '1', '5', '0', '0');
INSERT INTO `skills` VALUES ('149', '31', '2', '10', '0', '1');
INSERT INTO `skills` VALUES ('150', '31', '3', '3', '0', '2');
INSERT INTO `skills` VALUES ('151', '31', '4', '4', '0', '3');
INSERT INTO `skills` VALUES ('152', '18', '10202', '1', '1', '0');
INSERT INTO `skills` VALUES ('153', '31', '10102', '20', '1', '0');
INSERT INTO `skills` VALUES ('154', '31', '10103', '20', '1', '1');
INSERT INTO `skills` VALUES ('155', '31', '10108', '11', '1', '2');
INSERT INTO `skills` VALUES ('156', '25', '10403', '1', '1', '2');
INSERT INTO `skills` VALUES ('157', '31', '10107', '20', '1', '3');
INSERT INTO `skills` VALUES ('158', '29', '10101', '2', '1', '0');
INSERT INTO `skills` VALUES ('159', '29', '10102', '1', '1', '1');
INSERT INTO `skills` VALUES ('160', '32', '1', '2', '0', '0');
INSERT INTO `skills` VALUES ('161', '32', '2', '1', '0', '1');
INSERT INTO `skills` VALUES ('162', '32', '3', '1', '0', '2');
INSERT INTO `skills` VALUES ('163', '32', '4', '1', '0', '3');
INSERT INTO `skills` VALUES ('164', '33', '1', '1', '0', '0');
INSERT INTO `skills` VALUES ('165', '33', '2', '1', '0', '1');
INSERT INTO `skills` VALUES ('166', '33', '3', '1', '0', '2');
INSERT INTO `skills` VALUES ('167', '33', '4', '1', '0', '3');
INSERT INTO `skills` VALUES ('168', '26', '10301', '1', '1', '0');
INSERT INTO `skills` VALUES ('169', '26', '10302', '1', '1', '1');
INSERT INTO `skills` VALUES ('170', '34', '1', '5', '0', '0');
INSERT INTO `skills` VALUES ('171', '34', '2', '3', '0', '1');
INSERT INTO `skills` VALUES ('172', '34', '3', '7', '0', '2');
INSERT INTO `skills` VALUES ('173', '34', '4', '7', '0', '3');
INSERT INTO `skills` VALUES ('174', '35', '1', '5', '0', '0');
INSERT INTO `skills` VALUES ('175', '35', '2', '1', '0', '1');
INSERT INTO `skills` VALUES ('176', '35', '3', '1', '0', '2');
INSERT INTO `skills` VALUES ('177', '35', '4', '1', '0', '3');
INSERT INTO `skills` VALUES ('178', '34', '10301', '1', '1', '0');
INSERT INTO `skills` VALUES ('179', '34', '10302', '1', '1', '1');
INSERT INTO `skills` VALUES ('180', '36', '1', '3', '0', '0');
INSERT INTO `skills` VALUES ('181', '36', '2', '1', '0', '1');
INSERT INTO `skills` VALUES ('182', '36', '3', '1', '0', '2');
INSERT INTO `skills` VALUES ('183', '36', '4', '1', '0', '3');
INSERT INTO `skills` VALUES ('184', '29', '10105', '6', '1', '2');
INSERT INTO `skills` VALUES ('185', '29', '10103', '1', '1', '3');
INSERT INTO `skills` VALUES ('186', '1', '10207', '20', '1', '1');
INSERT INTO `skills` VALUES ('187', '37', '1', '1', '0', '0');
INSERT INTO `skills` VALUES ('188', '37', '2', '1', '0', '1');
INSERT INTO `skills` VALUES ('189', '37', '3', '1', '0', '2');
INSERT INTO `skills` VALUES ('190', '37', '4', '1', '0', '3');
INSERT INTO `skills` VALUES ('191', '29', '10106', '3', '1', '4');
INSERT INTO `skills` VALUES ('192', '29', '10108', '1', '1', '5');
INSERT INTO `skills` VALUES ('193', '10', '32301', '20', '3', '0');
INSERT INTO `skills` VALUES ('194', '10', '32308', '20', '3', '1');
INSERT INTO `skills` VALUES ('195', '10', '32302', '20', '3', '2');
INSERT INTO `skills` VALUES ('196', '27', '10302', '1', '1', '0');
INSERT INTO `skills` VALUES ('197', '1', '10101', '1', '1', '2');
INSERT INTO `skills` VALUES ('198', '1', '10102', '20', '1', '3');
INSERT INTO `skills` VALUES ('199', '1', '10103', '20', '1', '4');
INSERT INTO `skills` VALUES ('200', '1', '10104', '1', '1', '5');
INSERT INTO `skills` VALUES ('201', '1', '10105', '20', '1', '6');
INSERT INTO `skills` VALUES ('202', '1', '10106', '20', '1', '7');
INSERT INTO `skills` VALUES ('203', '1', '10107', '20', '1', '8');
INSERT INTO `skills` VALUES ('204', '1', '10108', '20', '1', '9');
INSERT INTO `skills` VALUES ('205', '1', '10109', '20', '1', '10');
INSERT INTO `skills` VALUES ('206', '1', '10110', '20', '1', '11');
INSERT INTO `skills` VALUES ('207', '1', '10111', '20', '1', '12');
INSERT INTO `skills` VALUES ('208', '0', '10112', '20', '1', '13');

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
  `type` int(11) NOT NULL,
  `slot` int(11) NOT NULL,
  `money` int(10) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=72 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of storages
-- ----------------------------
INSERT INTO `storages` VALUES ('1', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0');
INSERT INTO `storages` VALUES ('4', '4', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0');
INSERT INTO `storages` VALUES ('6', '4', '8010011', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0');
INSERT INTO `storages` VALUES ('8', '4', '8110011', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '1', '0');
INSERT INTO `storages` VALUES ('10', '4', '8820011', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0');
INSERT INTO `storages` VALUES ('12', '6', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0');
INSERT INTO `storages` VALUES ('15', '7', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0');
INSERT INTO `storages` VALUES ('16', '8', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0');
INSERT INTO `storages` VALUES ('17', '9', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0');
INSERT INTO `storages` VALUES ('18', '10', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0');
INSERT INTO `storages` VALUES ('20', '10', '8910101', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0');
INSERT INTO `storages` VALUES ('21', '11', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0');
INSERT INTO `storages` VALUES ('22', '12', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0');
INSERT INTO `storages` VALUES ('23', '13', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0');
INSERT INTO `storages` VALUES ('24', '14', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0');
INSERT INTO `storages` VALUES ('25', '15', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0');
INSERT INTO `storages` VALUES ('26', '16', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0');
INSERT INTO `storages` VALUES ('27', '17', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0');
INSERT INTO `storages` VALUES ('28', '18', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0');
INSERT INTO `storages` VALUES ('29', '19', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0');
INSERT INTO `storages` VALUES ('30', '20', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0');
INSERT INTO `storages` VALUES ('31', '21', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0');
INSERT INTO `storages` VALUES ('32', '22', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0');
INSERT INTO `storages` VALUES ('33', '23', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0');
INSERT INTO `storages` VALUES ('34', '24', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0');
INSERT INTO `storages` VALUES ('35', '25', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0');
INSERT INTO `storages` VALUES ('36', '24', '8850021', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0');
INSERT INTO `storages` VALUES ('37', '24', '8510011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '5', '0');
INSERT INTO `storages` VALUES ('38', '24', '8910081', '10', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '4', '0');
INSERT INTO `storages` VALUES ('39', '24', '8910071', '10', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '8', '0');
INSERT INTO `storages` VALUES ('40', '24', '8910051', '10', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '3', '0');
INSERT INTO `storages` VALUES ('41', '24', '8910061', '10', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '9', '0');
INSERT INTO `storages` VALUES ('42', '24', '8910121', '10', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '2', '0');
INSERT INTO `storages` VALUES ('43', '26', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0');
INSERT INTO `storages` VALUES ('44', '27', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0');
INSERT INTO `storages` VALUES ('45', '28', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0');
INSERT INTO `storages` VALUES ('46', '29', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0');
INSERT INTO `storages` VALUES ('47', '30', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0');
INSERT INTO `storages` VALUES ('48', '31', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0');
INSERT INTO `storages` VALUES ('49', '25', '8510021', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '1', '0');
INSERT INTO `storages` VALUES ('50', '25', '8510011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0');
INSERT INTO `storages` VALUES ('51', '25', '8510011', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '5', '0');
INSERT INTO `storages` VALUES ('52', '32', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0');
INSERT INTO `storages` VALUES ('53', '33', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0');
INSERT INTO `storages` VALUES ('54', '34', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0');
INSERT INTO `storages` VALUES ('55', '35', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0');
INSERT INTO `storages` VALUES ('56', '36', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0');
INSERT INTO `storages` VALUES ('57', '31', '8841006', '19', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0');
INSERT INTO `storages` VALUES ('58', '31', '8020251', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '1', '0');
INSERT INTO `storages` VALUES ('60', '1', '8990002', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0');
INSERT INTO `storages` VALUES ('62', '1', '8910011', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0');
INSERT INTO `storages` VALUES ('63', '31', '8310321', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '2', '0');
INSERT INTO `storages` VALUES ('64', '31', '8210321', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '3', '0');
INSERT INTO `storages` VALUES ('65', '31', '8310241', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '4', '0');
INSERT INTO `storages` VALUES ('66', '37', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0');
INSERT INTO `storages` VALUES ('67', '31', '8310321', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '5', '0');
INSERT INTO `storages` VALUES ('68', '31', '8210321', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '6', '0');
INSERT INTO `storages` VALUES ('69', '31', '8310241', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '7', '0');
INSERT INTO `storages` VALUES ('71', '31', '8110351', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '8', '0');

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
) ENGINE=InnoDB AUTO_INCREMENT=1419 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of useslot
-- ----------------------------
INSERT INTO `useslot` VALUES ('253', '8', '3', '255');
INSERT INTO `useslot` VALUES ('254', '8', '5', '0');
INSERT INTO `useslot` VALUES ('453', '11', '3', '8');
INSERT INTO `useslot` VALUES ('454', '11', '5', '0');
INSERT INTO `useslot` VALUES ('475', '9', '3', '255');
INSERT INTO `useslot` VALUES ('476', '9', '5', '0');
INSERT INTO `useslot` VALUES ('649', '7', '3', '255');
INSERT INTO `useslot` VALUES ('650', '7', '5', '0');
INSERT INTO `useslot` VALUES ('653', '15', '3', '255');
INSERT INTO `useslot` VALUES ('654', '15', '5', '255');
INSERT INTO `useslot` VALUES ('711', '12', '3', '255');
INSERT INTO `useslot` VALUES ('712', '12', '5', '255');
INSERT INTO `useslot` VALUES ('803', '20', '3', '255');
INSERT INTO `useslot` VALUES ('804', '20', '5', '0');
INSERT INTO `useslot` VALUES ('863', '16', '3', '255');
INSERT INTO `useslot` VALUES ('864', '16', '5', '0');
INSERT INTO `useslot` VALUES ('903', '6', '3', '255');
INSERT INTO `useslot` VALUES ('904', '6', '5', '255');
INSERT INTO `useslot` VALUES ('937', '28', '3', '255');
INSERT INTO `useslot` VALUES ('938', '28', '5', '0');
INSERT INTO `useslot` VALUES ('941', '30', '3', '255');
INSERT INTO `useslot` VALUES ('942', '30', '5', '255');
INSERT INTO `useslot` VALUES ('945', '18', '3', '255');
INSERT INTO `useslot` VALUES ('946', '18', '5', '255');
INSERT INTO `useslot` VALUES ('947', '17', '3', '255');
INSERT INTO `useslot` VALUES ('948', '17', '5', '1');
INSERT INTO `useslot` VALUES ('951', '24', '3', '255');
INSERT INTO `useslot` VALUES ('952', '24', '5', '0');
INSERT INTO `useslot` VALUES ('965', '22', '3', '255');
INSERT INTO `useslot` VALUES ('966', '22', '5', '255');
INSERT INTO `useslot` VALUES ('981', '25', '3', '255');
INSERT INTO `useslot` VALUES ('982', '25', '5', '255');
INSERT INTO `useslot` VALUES ('987', '21', '3', '255');
INSERT INTO `useslot` VALUES ('988', '21', '5', '255');
INSERT INTO `useslot` VALUES ('999', '19', '3', '255');
INSERT INTO `useslot` VALUES ('1000', '19', '5', '0');
INSERT INTO `useslot` VALUES ('1001', '23', '3', '255');
INSERT INTO `useslot` VALUES ('1002', '23', '5', '0');
INSERT INTO `useslot` VALUES ('1007', '32', '3', '255');
INSERT INTO `useslot` VALUES ('1008', '32', '5', '255');
INSERT INTO `useslot` VALUES ('1015', '33', '3', '255');
INSERT INTO `useslot` VALUES ('1016', '33', '5', '255');
INSERT INTO `useslot` VALUES ('1041', '26', '3', '255');
INSERT INTO `useslot` VALUES ('1042', '26', '5', '0');
INSERT INTO `useslot` VALUES ('1091', '35', '3', '255');
INSERT INTO `useslot` VALUES ('1092', '35', '5', '255');
INSERT INTO `useslot` VALUES ('1099', '34', '3', '4');
INSERT INTO `useslot` VALUES ('1100', '34', '5', '255');
INSERT INTO `useslot` VALUES ('1113', '14', '3', '255');
INSERT INTO `useslot` VALUES ('1114', '14', '5', '1');
INSERT INTO `useslot` VALUES ('1303', '4', '3', '255');
INSERT INTO `useslot` VALUES ('1304', '4', '5', '255');
INSERT INTO `useslot` VALUES ('1305', '36', '3', '255');
INSERT INTO `useslot` VALUES ('1306', '36', '5', '0');
INSERT INTO `useslot` VALUES ('1317', '37', '3', '255');
INSERT INTO `useslot` VALUES ('1318', '37', '5', '255');
INSERT INTO `useslot` VALUES ('1323', '29', '3', '11');
INSERT INTO `useslot` VALUES ('1324', '29', '5', '255');
INSERT INTO `useslot` VALUES ('1339', '27', '3', '255');
INSERT INTO `useslot` VALUES ('1340', '27', '5', '0');
INSERT INTO `useslot` VALUES ('1341', '13', '3', '4');
INSERT INTO `useslot` VALUES ('1342', '13', '5', '0');
INSERT INTO `useslot` VALUES ('1393', '31', '3', '12');
INSERT INTO `useslot` VALUES ('1394', '31', '5', '255');
INSERT INTO `useslot` VALUES ('1407', '10', '3', '13');
INSERT INTO `useslot` VALUES ('1408', '10', '5', '255');
INSERT INTO `useslot` VALUES ('1417', '1', '3', '11');
INSERT INTO `useslot` VALUES ('1418', '1', '5', '2');
