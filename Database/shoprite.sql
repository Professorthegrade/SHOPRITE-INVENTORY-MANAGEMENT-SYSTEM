-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Aug 26, 2022 at 06:20 PM
-- Server version: 10.4.11-MariaDB
-- PHP Version: 7.4.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `shoprite`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `firstname` varchar(8) NOT NULL,
  `surname` varchar(15) NOT NULL,
  `username` varchar(8) NOT NULL,
  `password` varchar(8) CHARACTER SET utf8 COLLATE utf8_unicode_520_nopad_ci NOT NULL,
  `year` year(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`firstname`, `surname`, `username`, `password`, `year`) VALUES
('edd', 'ddd', 'edd', '2', 2022);

-- --------------------------------------------------------

--
-- Table structure for table `products`
--

CREATE TABLE `products` (
  `barcode` varchar(11) NOT NULL,
  `name` varchar(11) NOT NULL,
  `price` double NOT NULL,
  `instock` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `products`
--

INSERT INTO `products` (`barcode`, `name`, `price`, `instock`) VALUES
('AS1', 'Abena Sardi', 4.5, 16),
('CB1', 'Cowbell cof', 35, 50),
('CM1', 'Can malt ', 30, 15),
('CR1', 'cindy rice ', 45, 0),
('DS', 'Donsimon', 10, 34),
('Fl1', 'Fanta lemon', 34, 35),
('FO1', 'Fritol oil ', 300, 0),
('FO2', 'Frytol oil ', 150, 0),
('LR1', 'lele Rice', 12, 20),
('LS', 'Lele spaghe', 50, 0),
('PR1', 'Precious Ri', 24.5, 23),
('QS', 'Queen sardi', 258, 0),
('S1', 'Sugar 50kg', 345, 0);

-- --------------------------------------------------------

--
-- Table structure for table `staff`
--

CREATE TABLE `staff` (
  `firstname` varchar(8) NOT NULL,
  `surname` varchar(15) NOT NULL,
  `username` varchar(10) NOT NULL,
  `password` varchar(8) CHARACTER SET keybcs2 NOT NULL,
  `year` date NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `staff`
--

INSERT INTO `staff` (`firstname`, `surname`, `username`, `password`, `year`) VALUES
('Edward', 'Sena', 'br41ne', '2', '0000-00-00'),
('Rose', 'Calton', 'cal', '32', '2022-08-25');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `products`
--
ALTER TABLE `products`
  ADD UNIQUE KEY `barcode` (`barcode`);

--
-- Indexes for table `staff`
--
ALTER TABLE `staff`
  ADD UNIQUE KEY `username` (`username`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
