# Host: localhost  (Version: 5.5.8)
# Date: 2020-11-23 23:41:24
# Generator: MySQL-Front 5.3  (Build 4.81)

/*!40101 SET NAMES utf8 */;

#
# Structure for table "tb_admin"
#

DROP TABLE IF EXISTS `tb_admin`;
CREATE TABLE `tb_admin` (
  `username` varchar(255) NOT NULL DEFAULT '',
  `password` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`username`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

#
# Data for table "tb_admin"
#

/*!40000 ALTER TABLE `tb_admin` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_admin` ENABLE KEYS */;

#
# Structure for table "tb_document"
#

DROP TABLE IF EXISTS `tb_document`;
CREATE TABLE `tb_document` (
  `no_doc` varchar(50) NOT NULL DEFAULT '',
  `main_proccess` varchar(255) DEFAULT NULL,
  `core_proccess` varchar(255) DEFAULT NULL,
  `proccess` varchar(255) DEFAULT NULL,
  `lob` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`no_doc`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

#
# Data for table "tb_document"
#

/*!40000 ALTER TABLE `tb_document` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_document` ENABLE KEYS */;

#
# Structure for table "tb_proccess"
#

DROP TABLE IF EXISTS `tb_proccess`;
CREATE TABLE `tb_proccess` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `proccess` varchar(255) DEFAULT NULL,
  `objective` varchar(255) DEFAULT NULL,
  `entity_reference` varchar(255) DEFAULT NULL,
  `document_reference` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

#
# Data for table "tb_proccess"
#

/*!40000 ALTER TABLE `tb_proccess` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_proccess` ENABLE KEYS */;
