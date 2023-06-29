-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Jun 29, 2023 at 09:17 AM
-- Server version: 8.0.27
-- PHP Version: 7.4.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `demo_cafe_application`
--

-- --------------------------------------------------------

--
-- Table structure for table `employeesdata`
--

DROP TABLE IF EXISTS `employeesdata`;
CREATE TABLE IF NOT EXISTS `employeesdata` (
  `Id` varchar(10) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `Name` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `EmailAddress` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `PhoneNumber` int NOT NULL,
  `Gender` int NOT NULL,
  `CafeId` varchar(10) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_EmployeesData_CafeId` (`CafeId`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `employeesdata`
--

INSERT INTO `employeesdata` (`Id`, `Name`, `EmailAddress`, `PhoneNumber`, `Gender`, `CafeId`) VALUES
('UI10000001', 'rohit srivastava', 'rohit@cafe.com', 12345678, 2, 'CF1000001'),
('UI10000002', 'nisha kumari', 'nisha@cafe.com', 12345679, 1, 'CF1000001'),
('UI10000003', 'Appu', 'appu@cafe.com', 85741256, 2, 'CF1000002'),
('UI10000004', 'Manoj', 'manoj@cafe.com', 85741256, 2, 'CF1000002'),
('UI10000005', 'Sumit', 'sumit@cafe.com', 85741256, 2, 'CF1000003'),
('UI10000006', 'Vasanth', 'vasnth@cafe.com', 85741256, 2, 'CF1000001'),
('UI10000007', 'Pooja', 'pooja@cafe.com', 85741256, 1, 'CF1000001'),
('UI10000008', 'Anu', 'anu@cafe.com', 85741256, 1, 'CF1000001'),
('UI10000009', 'Manisha', 'manisha@cafe.com', 85741256, 1, 'CF1000001'),
('UI10000010', 'Mitali', 'mitali@cafe.com', 85741256, 1, 'CF1000001'),
('UI10000011', 'Shivi', 'shivi@cafe.com', 85741256, 1, 'CF1000001'),
('UI10000012', 'Shipra', 'shipra@cafe.com', 85741256, 1, 'CF1000001'),
('UI10000013', 'Abhinav', 'abhi@cafe.com', 85741256, 2, 'CF1000001'),
('UI10000014', 'Himanshu', 'himanshu@cafe.com', 85741256, 2, 'CF1000001'),
('UI10000015', 'Anubhav', 'anhbhav@cafe.com', 85741256, 3, 'CF1000001');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
