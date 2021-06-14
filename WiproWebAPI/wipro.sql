-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Tempo de geração: 14-Jun-2021 às 11:44
-- Versão do servidor: 8.0.24
-- versão do PHP: 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `wipro`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `moedas`
--

DROP TABLE IF EXISTS `moedas`;
CREATE TABLE IF NOT EXISTS `moedas` (
  `idMoeda` int NOT NULL AUTO_INCREMENT,
  `dsMoeda` varchar(5) COLLATE utf8_unicode_ci NOT NULL,
  `dtInicio` date NOT NULL,
  `dtFim` date DEFAULT NULL,
  PRIMARY KEY (`idMoeda`)
) ENGINE=InnoDB AUTO_INCREMENT=79 DEFAULT CHARSET=utf8mb3 COLLATE=utf8_unicode_ci;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
