/*
SQLyog Ultimate v13.1.1 (64 bit)
MySQL - 8.0.36 : Database - kasir
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`kasir` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;

USE `kasir`;

/*Table structure for table `barang` */

DROP TABLE IF EXISTS `barang`;

CREATE TABLE `barang` (
  `kodebrg` varchar(50) NOT NULL,
  `namabrg` varchar(100) DEFAULT NULL,
  `satuanbrg` varchar(10) DEFAULT NULL,
  `hrgbeli` double DEFAULT NULL,
  `hrgjual` double DEFAULT NULL,
  `stokbrg` int DEFAULT NULL,
  PRIMARY KEY (`kodebrg`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

/*Data for the table `barang` */

insert  into `barang`(`kodebrg`,`namabrg`,`satuanbrg`,`hrgbeli`,`hrgjual`,`stokbrg`) values 
('BRG-001','PENSIL','pcs',4000,5000,10),
('BRG-002','PENA','box',10000,12000,10);

/*Table structure for table `pelanggan` */

DROP TABLE IF EXISTS `pelanggan`;

CREATE TABLE `pelanggan` (
  `kodepel` varchar(50) NOT NULL,
  `namapel` varchar(150) DEFAULT NULL,
  `emailpel` varchar(50) DEFAULT NULL,
  `alamat` varchar(150) DEFAULT NULL,
  `telp` varchar(13) DEFAULT NULL,
  PRIMARY KEY (`kodepel`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

/*Data for the table `pelanggan` */

insert  into `pelanggan`(`kodepel`,`namapel`,`emailpel`,`alamat`,`telp`) values 
('PEL-001','CASH','-','-\r\n','0');

/*Table structure for table `supplier` */

DROP TABLE IF EXISTS `supplier`;

CREATE TABLE `supplier` (
  `kodesup` varchar(25) NOT NULL,
  `namasup` varchar(150) DEFAULT NULL,
  `emailsup` varchar(50) DEFAULT NULL,
  `alamatsup` varchar(150) DEFAULT NULL,
  `telp` varchar(13) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  PRIMARY KEY (`kodesup`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

/*Data for the table `supplier` */

insert  into `supplier`(`kodesup`,`namasup`,`emailsup`,`alamatsup`,`telp`) values 
('SUP-001','MITRA SOLUTION','-','-\r\n','0'),
('SUP-002','SILVER PRINT','-','-\r\n','0'),
('SUP-003','QIESOFT','-','-\r\n','0');

/*Table structure for table `temp` */

DROP TABLE IF EXISTS `temp`;

CREATE TABLE `temp` (
  `kode` text,
  `brg` text,
  `nama` text,
  `jml` text
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

/*Data for the table `temp` */

insert  into `temp`(`kode`,`brg`,`nama`,`jml`) values 
('Q1111','BRG-001\r\n','PENSIL','10'),
('qz','brg-002\r\n','PENA','10');

/*Table structure for table `user` */

DROP TABLE IF EXISTS `user`;

CREATE TABLE `user` (
  `userid` varchar(20) NOT NULL,
  `username` varchar(100) DEFAULT NULL,
  `nama` varchar(100) DEFAULT NULL,
  `pass` varchar(35) DEFAULT NULL,
  `level` varchar(2) DEFAULT NULL,
  `useraktif` varchar(2) DEFAULT NULL,
  PRIMARY KEY (`userid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

/*Data for the table `user` */

insert  into `user`(`userid`,`username`,`nama`,`pass`,`level`,`useraktif`) values 
('01','q','q','q','1','1');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
