-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 10, 2024 at 10:08 AM
-- Server version: 10.4.17-MariaDB
-- PHP Version: 8.0.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `bookshelf`
--

DELIMITER $$
--
-- Procedures
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `Anzeige_Alle_Buch` ()  READS SQL DATA
SELECT * from buecher$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `Anzeige_Autor_Buch` (IN `In_autor` VARCHAR(40))  READS SQL DATA
SELECT * FROM buecher
WHERE autor like  In_autor$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `Anzeige_Genre_Buch` (IN `In_string` VARCHAR(30))  READS SQL DATA
SELECT * FROM buecher
where genre like In_string$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `Anzeige_ID_Buch` (IN `In_ID` INT)  READS SQL DATA
SELECT * From buecher
Where buchid = in_ID$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `Anzeige_ISBN_Buch` (IN `In_isbn` VARCHAR(30))  READS SQL DATA
SELECT * FROM buecher
WHERE isbn like In_isbn$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `Anzeige_Titel_Buch` (IN `In_titel` VARCHAR(40))  READS SQL DATA
SELECT * FROM buecher
WHERE titel like In_titel$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `Anzeige_Verlag_Buch` (IN `In_verlag` VARCHAR(40))  READS SQL DATA
SELECT * FROM buecher
WHERE verlag like In_verlag$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `Delete_ID_Buch` (IN `In_id` INT)  MODIFIES SQL DATA
DELETE FROM buecher
WHERE buchid = In_id$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `Insert_Buch` (IN `In_isbn` VARCHAR(30), IN `In_autor` VARCHAR(40), IN `In_titel` VARCHAR(40), IN `In_verlag` VARCHAR(40), IN `In_genre` VARCHAR(40), IN `In_seitenzahl` INT)  MODIFIES SQL DATA
INSERT INTO buecher VALUES(null,In_isbn,In_autor,In_titel,In_verlag,In_genre,In_seitenzahl)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `Update_ID_Buch` (IN `In_id` INT, IN `In_isbn` VARCHAR(30), IN `In_autor` VARCHAR(40), IN `In_titel` VARCHAR(40), IN `In_verlag` VARCHAR(40), IN `In_genre` VARCHAR(40), IN `In_seitenzahl` INT)  MODIFIES SQL DATA
UPDATE buecher
SET isbn = In_isbn,autor = In_autor,titel = In_titel, verlag = In_verlag, genre = In_genre, seitenzahl = In_seitenzahl
where buchid = In_id$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `buecher`
--

CREATE TABLE `buecher` (
  `BuchId` int(11) NOT NULL,
  `ISBN` varchar(30) NOT NULL,
  `Autor` varchar(40) NOT NULL,
  `Titel` varchar(40) NOT NULL,
  `Verlag` varchar(40) NOT NULL,
  `Genre` varchar(40) NOT NULL,
  `Seitenzahl` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `buecher`
--
ALTER TABLE `buecher`
  ADD PRIMARY KEY (`BuchId`),
  ADD UNIQUE KEY `ISBN` (`ISBN`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `buecher`
--
ALTER TABLE `buecher`
  MODIFY `BuchId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=111;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
