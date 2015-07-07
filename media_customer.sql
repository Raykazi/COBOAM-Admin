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
-- Table structure for table `customer`
--

DROP TABLE IF EXISTS `customer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `customer` (
  `cusID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `lastName` varchar(45) NOT NULL,
  `firstName` varchar(45) NOT NULL,
  `totalPaid` decimal(10,0) NOT NULL,
  `totalOwed` decimal(10,0) NOT NULL,
  `balance` decimal(10,0) NOT NULL,
  PRIMARY KEY (`cusID`)
) ENGINE=InnoDB AUTO_INCREMENT=36 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customer`
--

LOCK TABLES `customer` WRITE;
/*!40000 ALTER TABLE `customer` DISABLE KEYS */;
INSERT INTO `customer` VALUES (2,'Steel','Patricia',0,0,0),(3,'Steele','Carol',0,0,0),(5,'Blackwood','Jennifer',0,2,-6),(6,'Nemoede','Brian',0,0,0),(7,'Edwards','Thelma',0,0,0),(8,'Edwards','Ryland',0,20,-20),(9,'Linton','Lorraine',0,6,-6),(10,'Robinson','Sharrise',0,0,0),(11,'Edwards','James',0,-12,12),(12,'Radway','Melva',0,0,0),(15,'McCalla','Murven',0,0,0),(16,'Williams','Audrey',0,0,0),(17,'McFarlane','Audrey',0,0,0),(18,'Williams','Steve',0,0,0),(19,'Lyle','Michelle',6,0,6),(21,'Small','Laurel',0,6,-6),(23,'Graham','Christopher',0,0,0),(28,'Dawkins','Minister',0,0,0),(29,'Harriott','Trevaughn',-14,-9,-5),(30,'Edwards','Everell',0,0,0),(31,'Visitor','Unknown',12,0,12),(32,'Banton','Gloria',0,6,-6),(33,'Robinson','Dannie',-6,6,-6),(34,'Daswell','Everton',0,6,-6),(35,'Radway','Melva',0,0,0);
/*!40000 ALTER TABLE `customer` ENABLE KEYS */;
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
