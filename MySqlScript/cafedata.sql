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
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
