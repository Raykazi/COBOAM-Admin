-- MySQL dump 10.13  Distrib 5.6.13, for Win32 (x86)
--
-- Host: localhost    Database: media
-- ------------------------------------------------------
-- Server version	5.6.15-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `order`
--

DROP TABLE IF EXISTS `order`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `order` (
  `orderID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `cusID` int(10) unsigned NOT NULL,
  `sermonID` int(10) unsigned NOT NULL DEFAULT '0',
  `dateOrdered` datetime NOT NULL DEFAULT '2013-01-01 00:00:00',
  `Type` tinyint(3) unsigned NOT NULL DEFAULT '0',
  `Quantity` int(11) NOT NULL DEFAULT '0',
  `Discounts` decimal(10,2) NOT NULL DEFAULT '0.00',
  `AmtOwed` decimal(10,2) NOT NULL DEFAULT '0.00',
  `AmtPaid` decimal(10,2) NOT NULL DEFAULT '0.00',
  `Paid` tinyint(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`orderID`),
  UNIQUE KEY `orderID_UNIQUE` (`orderID`),
  KEY `order_customer_idx` (`cusID`),
  KEY `order_sermon_idx` (`sermonID`),
  KEY `order_type_idx` (`Type`),
  KEY `order_customer_idx1` (`cusID`),
  CONSTRAINT `order_sermon` FOREIGN KEY (`sermonID`) REFERENCES `sermons` (`sermonID`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `order_type` FOREIGN KEY (`Type`) REFERENCES `types` (`ID`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=34 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `order`
--

LOCK TABLES `order` WRITE;
/*!40000 ALTER TABLE `order` DISABLE KEYS */;
INSERT INTO `order` VALUES (2,5,10,'2013-01-28 10:19:00',1,12,0.00,72.00,0.00,0),(3,15,11,'2013-01-28 10:19:00',2,1,0.00,0.00,10.00,1),(4,15,12,'2013-01-28 10:19:00',2,1,0.00,0.00,10.00,1),(5,9,13,'2013-01-28 10:19:00',5,1,0.00,0.00,0.00,1),(6,19,16,'2013-02-03 14:45:00',1,1,0.00,0.00,6.00,1),(7,9,15,'2013-02-03 14:45:11',5,1,0.00,0.00,0.00,1),(8,9,14,'2013-02-03 14:45:11',5,1,0.00,0.00,0.00,1),(9,19,12,'2013-02-06 19:38:00',1,1,0.00,0.00,6.00,1),(10,1,15,'2013-02-07 16:35:00',1,1,0.00,6.00,0.00,0),(11,1,16,'2013-02-10 08:14:51',2,1,0.00,10.00,0.00,0),(12,5,16,'2013-02-24 11:05:35',1,1,0.00,6.00,0.00,0),(13,5,18,'2013-02-24 11:05:35',1,1,0.00,6.00,0.00,0),(14,9,16,'2013-02-24 11:05:35',5,1,0.00,0.00,0.00,1),(15,30,12,'2013-03-31 09:59:35',5,2,0.00,0.00,0.00,1),(18,9,24,'2013-05-29 09:42:00',5,1,0.00,0.00,0.00,1),(19,5,30,'2013-06-02 11:53:42',1,2,0.00,12.00,0.00,0),(25,31,32,'2013-06-16 12:39:00',1,2,0.00,0.00,12.00,1),(26,32,33,'2013-07-07 12:16:00',1,1,0.00,0.00,6.00,1),(27,8,34,'2013-07-14 12:27:17',2,2,0.00,20.00,0.00,0),(28,33,35,'2013-07-14 13:19:00',1,1,0.00,0.00,6.00,0),(29,5,38,'2013-09-11 19:45:14',1,1,0.00,6.00,0.00,0),(30,34,38,'2013-09-11 19:45:14',1,1,0.00,6.00,0.00,0),(31,21,38,'2013-09-11 19:45:14',1,1,0.00,6.00,0.00,0),(32,19,39,'2013-10-02 19:10:30',1,1,0.00,0.00,6.00,0),(33,33,40,'2013-11-03 13:01:33',1,1,0.00,6.00,0.00,0);
/*!40000 ALTER TABLE `order` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2014-01-17 22:00:41
