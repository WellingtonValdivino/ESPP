CREATE DATABASE  IF NOT EXISTS `esppcontadigital` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `esppcontadigital`;
-- MySQL dump 10.13  Distrib 5.7.31, for Win64 (x86_64)
--
-- Host: localhost    Database: esppcontadigital
-- ------------------------------------------------------
-- Server version	5.5.5-10.3.16-MariaDB

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
-- Table structure for table `tb_pessoafisica`
--

DROP TABLE IF EXISTS `tb_pessoafisica`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_pessoafisica` (
  `id_PessoaFisica` int(11) NOT NULL AUTO_INCREMENT,
  `nome_PessoaFisica` varchar(45) CHARACTER SET latin1 NOT NULL,
  `cpf_PessoaFisica` varchar(45) CHARACTER SET latin1 NOT NULL,
  PRIMARY KEY (`id_PessoaFisica`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_pessoafisica`
--

LOCK TABLES `tb_pessoafisica` WRITE;
/*!40000 ALTER TABLE `tb_pessoafisica` DISABLE KEYS */;
INSERT INTO `tb_pessoafisica` VALUES (1,'Wellington Valdivino de Oliveira','396.607.528-81'),(2,'Larissa Ribeiro','389.896.078-17');
/*!40000 ALTER TABLE `tb_pessoafisica` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_pessoajuridica`
--

DROP TABLE IF EXISTS `tb_pessoajuridica`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_pessoajuridica` (
  `id_pessoajuridica` int(11) NOT NULL AUTO_INCREMENT,
  `razaoSocial_pessoajuridica` varchar(45) CHARACTER SET latin1 NOT NULL,
  `nomeFantasia_pessoajuridica` varchar(45) CHARACTER SET latin1 NOT NULL,
  `cnpj_pessoajuridica` varchar(45) CHARACTER SET latin1 NOT NULL,
  PRIMARY KEY (`id_pessoajuridica`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_pessoajuridica`
--

LOCK TABLES `tb_pessoajuridica` WRITE;
/*!40000 ALTER TABLE `tb_pessoajuridica` DISABLE KEYS */;
INSERT INTO `tb_pessoajuridica` VALUES (1,'Spal Indústria Brasileira de Bebidas S.A.','Coca Cola FEMSA','61.186.888/0001-93');
/*!40000 ALTER TABLE `tb_pessoajuridica` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_transacao`
--

DROP TABLE IF EXISTS `tb_transacao`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_transacao` (
  `id_transacao` int(11) NOT NULL AUTO_INCREMENT,
  `data_transacao` datetime NOT NULL,
  `tipo_transacao` varchar(45) CHARACTER SET latin1 NOT NULL,
  `valor_transacao` decimal(5,2) NOT NULL,
  PRIMARY KEY (`id_transacao`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_transacao`
--

LOCK TABLES `tb_transacao` WRITE;
/*!40000 ALTER TABLE `tb_transacao` DISABLE KEYS */;
INSERT INTO `tb_transacao` VALUES (1,'2020-07-25 00:00:00','Débito',587.69);
/*!40000 ALTER TABLE `tb_transacao` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-07-26 15:18:37
