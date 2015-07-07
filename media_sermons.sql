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
-- Table structure for table `sermons`
--

DROP TABLE IF EXISTS `sermons`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `sermons` (
  `sermonID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `PID` int(11) NOT NULL,
  `Title` text NOT NULL,
  `Date` date NOT NULL,
  PRIMARY KEY (`sermonID`),
  KEY `sermons_preachers_idx` (`PID`),
  CONSTRAINT `sermons_preachers` FOREIGN KEY (`PID`) REFERENCES `preachers` (`PID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=43 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sermons`
--

LOCK TABLES `sermons` WRITE;
/*!40000 ALTER TABLE `sermons` DISABLE KEYS */;
INSERT INTO `sermons` VALUES (1,1,'Defeating The Roaring Lions','2011-07-03'),(2,1,'A Father\'s Love','2011-06-19'),(3,1,'Look What The Lord Has Done','2011-04-24'),(4,2,'CD/DVD Duplication','2011-07-12'),(5,1,'When The Brook Dries Up','2011-07-17'),(6,1,'Postioned To Posses','2011-07-31'),(7,2,'4 Week Series','2011-07-31'),(8,1,'Slaying Your Giants','2011-07-31'),(9,1,'Pastor E.W Edwards','2013-01-06'),(10,2,'2012 Balance','2013-01-01'),(11,2,'Xmas Program 2012','2012-12-16'),(12,7,'Its Time To Judge','2012-12-30'),(13,3,'Anniversary Friday 2012','2012-11-09'),(14,4,'Anniversary Saturday 2012','2012-11-10'),(15,5,'Anniversary Sunday 2012','2012-11-11'),(16,6,'It\'s Your Time','2013-01-27'),(17,1,'I Am The Apple Of His Eye','2013-01-13'),(18,8,'Not An Ordinary Servant','2013-01-20'),(19,1,'No Longer An Ordinary Servant','2013-01-20'),(20,1,'Worthy is the Lamb','2013-03-31'),(21,1,'Rebuilding The Trust','2013-04-07'),(22,9,'Our God','2013-04-21'),(23,9,'05-05-13','2013-05-05'),(24,1,'A Mother\'s Love','2013-05-12'),(25,10,'Arise...And Go','2013-05-19'),(27,1,'What Will Your Memorial Say','2013-05-26'),(30,1,'Breathe ','2013-06-02'),(31,11,'The Sound','2013-06-23'),(32,6,'Transformed Heart Transformed Mind','2013-06-16'),(33,1,'God Keeps His Words','2013-07-07'),(34,2,'Baptism','2013-06-16'),(35,1,'7 Hinderances Of A Fruitful Prayer','2013-07-14'),(36,1,'Stand Your Ground','2013-07-21'),(37,1,'Getting High For God','2013-09-01'),(38,1,'Putting God In His Place','2013-09-08'),(39,13,'Youth Svc 9-22-13','2013-09-22'),(40,1,'Dont Say That I Am','2013-10-27'),(41,3,'His Brace is Enough','2013-11-10'),(42,3,'His Grace is Enough','2013-11-10');
/*!40000 ALTER TABLE `sermons` ENABLE KEYS */;
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
