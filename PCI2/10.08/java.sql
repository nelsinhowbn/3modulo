-- phpMyAdmin SQL Dump
-- version 4.7.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 11-Ago-2018 às 01:34
-- Versão do servidor: 5.7.17
-- PHP Version: 5.6.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `java`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `alunos`
--

CREATE TABLE `alunos` (
  `id` int(3) NOT NULL,
  `nome` varchar(80) NOT NULL,
  `endereco` varchar(150) NOT NULL,
  `bairro` varchar(80) NOT NULL,
  `cep` int(30) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `alunos`
--

INSERT INTO `alunos` (`id`, `nome`, `endereco`, `bairro`, `cep`) VALUES
(12, ' Professor Jefferson', 'Av Aguia de Haia, 2750', 'Itaquacetuba', 1068444557),
(13, ' Professor Jefferson', 'Av Aguia de Haia, 2750', 'Itaquacetuba', 1068444557),
(11, ' Professor Jefferson', 'Av Aguia de Haia, 2750', 'Itaquacetuba', 1068444557),
(9, ' Vinicius Alves', 'Av Lopes, 2700', 'Penha', 10514557),
(10, ' Professor Jefferson', 'Av Aguia de Haia, 2750', 'Itaquacetuba', 1068444557);

-- --------------------------------------------------------

--
-- Estrutura da tabela `cordenador`
--

CREATE TABLE `cordenador` (
  `id` int(3) NOT NULL,
  `nome` varchar(80) NOT NULL,
  `endereco` varchar(80) NOT NULL,
  `bairro` varchar(80) NOT NULL,
  `cep` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `cordenador`
--

INSERT INTO `cordenador` (`id`, `nome`, `endereco`, `bairro`, `cep`) VALUES
(1, ' Vitão Huguinho Michelin', 'Rua do Richard, 2040', 'Itanhaem', 74634557),
(2, ' Vitão Huguinho Michelin', 'Rua do Richard, 2040', 'Itanhaem', 74634557);

-- --------------------------------------------------------

--
-- Estrutura da tabela `professor`
--

CREATE TABLE `professor` (
  `id` int(3) NOT NULL,
  `nome` varchar(80) NOT NULL,
  `endereco` varchar(80) NOT NULL,
  `bairro` varchar(90) NOT NULL,
  `cep` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `professor`
--

INSERT INTO `professor` (`id`, `nome`, `endereco`, `bairro`, `cep`) VALUES
(2, ' Professor Jefferson', 'Av Aguia de Haia, 2750', 'Itaquacetuba', 1068444557),
(3, ' Professor Jefferson', 'Av Aguia de Haia, 2750', 'Itaquacetuba', 1068444557);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `alunos`
--
ALTER TABLE `alunos`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `cordenador`
--
ALTER TABLE `cordenador`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `professor`
--
ALTER TABLE `professor`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `alunos`
--
ALTER TABLE `alunos`
  MODIFY `id` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;
--
-- AUTO_INCREMENT for table `cordenador`
--
ALTER TABLE `cordenador`
  MODIFY `id` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `professor`
--
ALTER TABLE `professor`
  MODIFY `id` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
