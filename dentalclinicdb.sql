-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 09, 2019 at 06:18 AM
-- Server version: 10.4.10-MariaDB
-- PHP Version: 7.3.12

/* SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO"; */
SET @AUTOCOMMIT = 0;
START TRANSACTION;
SET @time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dentalclinic`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbllogin`
--

CREATE TABLE tbllogin (
  [ID] int NOT NULL,
  [Username] varchar(50) NOT NULL,
  [Password] varchar(50) NOT NULL
) ;

--
-- Dumping data for table `tbllogin`
--

INSERT INTO tbllogin ([ID], [Username], [Password]) VALUES
(1, 'a', 'a');

-- --------------------------------------------------------

--
-- Table structure for table `tblrecords`
--

CREATE TABLE tblrecords (
  [ID] int NOT NULL,
  [PatientName] varchar(50) NOT NULL,
  [Treatment] varchar(50) NOT NULL,
  [DateOfVisit] date NOT NULL
) ;

--
-- Dumping data for table `tblrecords`
--

INSERT INTO tblrecords ([ID], [PatientName], [Treatment], [DateOfVisit]) VALUES
(1, 'sample', 'sample', '2019-12-09');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbllogin`
--
ALTER TABLE [tbllogin]
  ADD PRIMARY KEY ([ID]);

--
-- Indexes for table `tblrecords`
--
ALTER TABLE [tblrecords]
  ADD PRIMARY KEY ([ID]);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbllogin`
--
ALTER TABLE [tbllogin]
  MODIFY [ID] cast(10 as int) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `tblrecords`
--
ALTER TABLE [tblrecords]
  MODIFY [ID] cast(11 as int) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
