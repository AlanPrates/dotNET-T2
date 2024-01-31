-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: localhost:8889
-- Generation Time: Jan 31, 2024 at 07:53 AM
-- Server version: 5.7.39
-- PHP Version: 7.4.33

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `techadvocacia`
--

-- --------------------------------------------------------

--
-- Table structure for table `Advogados`
--

CREATE TABLE `Advogados` (
  `Id` int(11) NOT NULL,
  `Nome` varchar(100) NOT NULL,
  `DataDeNascimento` datetime(6) NOT NULL,
  `CPF` varchar(11) NOT NULL,
  `CNA` varchar(20) NOT NULL,
  `EstadoCivil` longtext NOT NULL,
  `Profissao` longtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `Advogados`
--

INSERT INTO `Advogados` (`Id`, `Nome`, `DataDeNascimento`, `CPF`, `CNA`, `EstadoCivil`, `Profissao`) VALUES
(2, ' Alan Prates', '2024-01-31 07:48:44.316000', 'string', 'string', 'string', 'string');

-- --------------------------------------------------------

--
-- Table structure for table `Clientes`
--

CREATE TABLE `Clientes` (
  `Id` int(11) NOT NULL,
  `EstadoCivil` longtext NOT NULL,
  `Profissao` longtext NOT NULL,
  `Nome` varchar(150) NOT NULL,
  `DataDeNascimento` datetime(6) NOT NULL,
  `CPF` longtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `__EFMigrationsHistory`
--

CREATE TABLE `__EFMigrationsHistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `__EFMigrationsHistory`
--

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`) VALUES
('20240131073116_InitialMigration', '7.0.15');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `Advogados`
--
ALTER TABLE `Advogados`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `Clientes`
--
ALTER TABLE `Clientes`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `__EFMigrationsHistory`
--
ALTER TABLE `__EFMigrationsHistory`
  ADD PRIMARY KEY (`MigrationId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `Advogados`
--
ALTER TABLE `Advogados`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `Clientes`
--
ALTER TABLE `Clientes`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
