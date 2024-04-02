-- MySQL dump 10.13  Distrib 8.0.21, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: marshell
-- ------------------------------------------------------
-- Server version	8.0.21

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
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
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customer` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `CNAME` varchar(50) NOT NULL,
  `SRNAME` varchar(50) NOT NULL,
  `IDNUMBER` varchar(50) NOT NULL DEFAULT '626-SOMETHING',
  `MOBILE` varchar(20) NOT NULL,
  `LOCATION` varchar(100) DEFAULT NULL,
  `NATIONALITY` varchar(50) NOT NULL DEFAULT 'NIC',
  `GENDER` varchar(10) NOT NULL,
  `BLKCUS` tinyint NOT NULL DEFAULT '0',
  `OW` float(7,2) DEFAULT '0.00',
  `CUR` char(3) DEFAULT 'NIO',
  PRIMARY KEY (`ID`),
  UNIQUE KEY `ID` (`ID`),
  UNIQUE KEY `CNAME` (`CNAME`,`SRNAME`,`IDNUMBER`,`MOBILE`,`LOCATION`,`NATIONALITY`,`GENDER`),
  UNIQUE KEY `CNAME_2` (`CNAME`,`SRNAME`,`IDNUMBER`,`MOBILE`,`LOCATION`,`NATIONALITY`,`GENDER`),
  UNIQUE KEY `CNAME_3` (`CNAME`,`SRNAME`,`IDNUMBER`,`MOBILE`,`LOCATION`,`NATIONALITY`,`GENDER`),
  CONSTRAINT `customer_chk_1` CHECK ((`GENDER` in (_utf8mb4'F',_utf8mb4'M',_utf8mb4'FEMALE',_utf8mb4'MALE',_utf8mb4'FEMENINA',_utf8mb4'MASCULINO'))),
  CONSTRAINT `customer_chk_2` CHECK ((`BLKCUS` in (0,1))),
  CONSTRAINT `customer_chk_3` CHECK ((`CUR` in (_utf8mb4'NIO',_utf8mb4'USD',_utf8mb4'EUR')))
) ENGINE=InnoDB AUTO_INCREMENT=90 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customer`
--

LOCK TABLES `customer` WRITE;
/*!40000 ALTER TABLE `customer` DISABLE KEYS */;
INSERT INTO `customer` VALUES (1,'keysie','Moses','57699188','57699188','Kahkabila','NIC','FEMALE',0,1521.00,'NIO'),(3,'china','Garth','626-131295-','82314710','NIC','NIC','FEMALE',0,755.00,'NIO'),(5,'Nadia','Gonzales','84264704','84264704','','','FEMALE',0,1065.00,'NIO'),(7,'Jonie','Humphreys','57271160','57571160','','','FEMALE',0,2445.00,'NIO'),(9,'Ciecia','Jackson','86931812','86931812','','','FEMALE',0,2194.00,'NIO'),(11,'Dianie','Patterson','1','1','','','FEMALE',0,0.00,'NIO'),(13,'Jeneicy','Bermudez','85491568','85491568','','','FEMALE',0,3850.00,'NIO'),(15,'lilia','Schartz','88480466','88480466','kahkabila','nic','FEMALE',0,3437.00,'NIO'),(19,'Britnie','Carlos','calros','58635299','Tasbapaunie','Nic','FEMALE',0,1996.00,'NIO'),(21,'Emy','Rigby','626-nose','58739458','pl','nic','FEMALE',0,390.00,'NIO'),(23,'Berverly','pondler','626-so','911','Pearl Lagoon','Nic','FEMALE',0,1361.00,'NIO'),(25,'Andrea','Pondler','456','556','lp','Nic','FEMALE',0,1179.00,'NIO'),(27,'Gertrudis','Hodgson','262-something','85159837','lp','Nic','FEMALE',0,1268.00,'NIO'),(29,'Britnie','Carlos','626-2','58635299','TasbaPaunie','Nic','FEMALE',0,1991.00,'NIO'),(31,'Jisel','Gonzales','ihion','83686898','lp','nic','FEMALE',0,1370.00,'NIO'),(33,'Adela','Bendliss','adela','83305488','lp','NIC','FEMALE',0,3512.00,'NIO'),(35,'vondie','Benliss','nlknksdnk','911','lp','nic','FEMALE',0,1768.00,'NIO'),(37,'Olga','Alvarez','miss olga','889','halouver','Nic','FEMALE',0,480.00,'NIO'),(39,'Alina','Alvarez','alina','57987903','Halouver','Nic','FEMALE',0,2139.00,'NIO'),(41,'Dorlett','Hansack','dorlett','922','Pearl Lagoon','Nic','FEMALE',0,848.00,'NIO'),(43,'Shorlett','Hansack ','shorlett','654','Lp','Nic','FEMALE',0,4915.00,'NIO'),(45,'Camilee','Downs','Cami','828','Pearl lagoon','Nic','FEMALE',0,980.00,'NIO'),(47,'Betty','Cayasso','Betty','82010949','Lp','NIC','FEMALE',0,640.00,'NIO'),(49,'Elliett','McCoy','Elliet','956','Halouver','Nic','FEMALE',0,1904.00,'NIO'),(51,'bicu','bicu','bicu','90','bicu','nic','FEMALE',0,1080.00,'NIO'),(53,'Ligia ','Brroks','','','Pearl Lagoon','Nic','FEMALE',0,950.00,'NIO'),(69,'Sharilin ','Blanford ','','57898030','Pearl Lagoon','Nic.','FEMALE',0,2966.00,'NIO'),(75,'Rumalda ','Tathum','','','','','FEMALE',0,708.00,'NIO'),(77,'ishoylet ','Nelson ','','57995687','Haulover ','NIc','FEMALE',0,595.00,'NIO'),(81,'carolina ','tathum','','','','','FEMALE',0,945.00,'NIO'),(83,'marshell ','wells','','84155776','','','FEMALE',0,0.00,'NIO'),(85,'patricia ','tathum','','','','','FEMALE',0,640.00,'NIO'),(89,'1840149565','1840149565','1840149565','1840149565',NULL,'NIC','FEMALE',0,0.00,'NIO');
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

-- Dump completed on 2021-05-02 14:34:34
