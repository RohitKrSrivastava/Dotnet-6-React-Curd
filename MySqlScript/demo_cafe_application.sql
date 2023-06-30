-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Jun 30, 2023 at 05:08 PM
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
-- Table structure for table `cafedata`
--

DROP TABLE IF EXISTS `cafedata`;
CREATE TABLE IF NOT EXISTS `cafedata` (
  `Id` varchar(10) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `Name` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `Discription` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `Location` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `Logo` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `cafedata`
--

INSERT INTO `cafedata` (`Id`, `Name`, `Discription`, `Location`, `Logo`) VALUES
('CF1000001', 'Null', 'Blank', 'Null', ''),
('CF1000002', 'barista', 'this is barista', 'delhi', ''),
('CF1000003', 'c2', 'description for c2', 'Lucknow', ''),
('CF1000004', 'c1', 'description for c1', 'Lucknow', ''),
('CF1000005', 'c3', 'description for c3', 'lucknow', ''),
('CF1000006', 'c4', 'description for c4', 'lucknow', ''),
('CF1000007', 'c5', 'description for c5', 'delhi', ''),
('CF1000008', 'c6', 'description for c6', 'delhi', ''),
('CF1000009', 'c7', 'description for c7', 'delhi', ''),
('CF1000010', 'c8', 'description for c8', 'lucknow', ''),
('CF1000011', 'c9', 'description for c9', 'lucknow', ''),
('CF1000012', 'c10', 'description for c10', 'delhi', ''),
('CF1000013', 'c11', 'description for c11', 'lucknow', ''),
('CF1000014', 'c12', 'description for c12', 'delhi', ''),
('CF1000015', 'c13', 'description for c13', 'delhi', ''),
('CF1000016', 'c14', 'description for c14', 'lucknow', '');

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

-- --------------------------------------------------------

--
-- Table structure for table `__efmigrationshistory`
--

DROP TABLE IF EXISTS `__efmigrationshistory`;
CREATE TABLE IF NOT EXISTS `__efmigrationshistory` (
  `MigrationId` varchar(150) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `ProductVersion` varchar(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`MigrationId`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `__efmigrationshistory`
--

INSERT INTO `__efmigrationshistory` (`MigrationId`, `ProductVersion`) VALUES
('20230629073745_initial', '7.0.8');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
