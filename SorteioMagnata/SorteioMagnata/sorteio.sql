-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 29/04/2021 às 22:22
-- Versão do servidor: 10.4.11-MariaDB
-- Versão do PHP: 7.4.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `sorteio`
--

-- --------------------------------------------------------

--
-- Estrutura para tabela `apostadores`
--

CREATE TABLE `apostadores` (
  `id` int(11) NOT NULL,
  `nome` varchar(30) NOT NULL,
  `celular` varchar(20) NOT NULL,
  `cargo` varchar(10) NOT NULL,
  `data` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Despejando dados para a tabela `apostadores`
--

INSERT INTO `apostadores` (`id`, `nome`, `celular`, `cargo`, `data`) VALUES
(2, 'Nivia', '(19)98713-5566', 'Apostador', '2021-04-13'),
(3, 'Arthur', '(19)98516-6557', 'Apostador', '2021-04-13'),
(4, 'Ricardo', '(19)98715-5623', 'Apostador', '2021-04-13');

-- --------------------------------------------------------

--
-- Estrutura para tabela `apostas`
--

CREATE TABLE `apostas` (
  `id` int(11) NOT NULL,
  `nomecartela` varchar(40) NOT NULL,
  `acertos` int(11) NOT NULL DEFAULT 0,
  `idapostador` int(11) NOT NULL,
  `numeroaposta1` varchar(10) NOT NULL,
  `aposta1flag` tinyint(1) NOT NULL DEFAULT 0,
  `numeroaposta2` varchar(10) NOT NULL,
  `aposta2flag` tinyint(1) NOT NULL DEFAULT 0,
  `numeroaposta3` varchar(10) NOT NULL,
  `aposta3flag` tinyint(1) NOT NULL DEFAULT 0,
  `numeroaposta4` varchar(10) NOT NULL,
  `aposta4flag` tinyint(1) NOT NULL DEFAULT 0,
  `numeroaposta5` varchar(10) NOT NULL,
  `aposta5flag` tinyint(1) NOT NULL DEFAULT 0,
  `numeroaposta6` varchar(10) NOT NULL,
  `aposta6flag` tinyint(1) NOT NULL DEFAULT 0,
  `numeroaposta7` varchar(10) NOT NULL,
  `aposta7flag` tinyint(1) NOT NULL DEFAULT 0,
  `numeroaposta8` varchar(10) NOT NULL,
  `aposta8flag` tinyint(1) NOT NULL DEFAULT 0,
  `numeroaposta9` varchar(10) NOT NULL,
  `aposta9flag` tinyint(1) NOT NULL DEFAULT 0,
  `numeroaposta10` varchar(10) NOT NULL,
  `aposta10flag` tinyint(1) NOT NULL DEFAULT 0,
  `data` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Despejando dados para a tabela `apostas`
--

INSERT INTO `apostas` (`id`, `nomecartela`, `acertos`, `idapostador`, `numeroaposta1`, `aposta1flag`, `numeroaposta2`, `aposta2flag`, `numeroaposta3`, `aposta3flag`, `numeroaposta4`, `aposta4flag`, `numeroaposta5`, `aposta5flag`, `numeroaposta6`, `aposta6flag`, `numeroaposta7`, `aposta7flag`, `numeroaposta8`, `aposta8flag`, `numeroaposta9`, `aposta9flag`, `numeroaposta10`, `aposta10flag`, `data`) VALUES
(41, 'Arthur (1)', 1, 3, '3', 0, '56', 0, '42', 0, '25', 0, '73', 0, '48', 0, '8', 0, '61', 0, '13', 1, '52', 0, '2021-04-29'),
(42, 'Nivia (1)', 1, 2, '34', 0, '12', 1, '16', 0, '5', 0, '73', 0, '18', 0, '34', 0, '66', 0, '46', 0, '57', 0, '2021-04-29'),
(43, 'Ricardo (1)', 1, 4, '72', 0, '42', 0, '49', 0, '20', 0, '41', 0, '14', 1, '3', 0, '77', 0, '68', 0, '29', 0, '2021-04-29'),
(44, 'Arthur (2)', 0, 3, '21', 0, '70', 0, '16', 0, '20', 0, '80', 0, '41', 0, '69', 0, '71', 0, '35', 0, '20', 0, '2021-04-29'),
(45, 'Nivia (2)', 0, 2, '25', 0, '18', 0, '49', 0, '7', 0, '79', 0, '36', 0, '74', 0, '69', 0, '46', 0, '23', 0, '2021-04-29'),
(46, 'Ricardo (2)', 0, 4, '57', 0, '36', 0, '76', 0, '27', 0, '36', 0, '34', 0, '31', 0, '68', 0, '80', 0, '21', 0, '2021-04-29'),
(47, 'Arthur (3)', 3, 3, '64', 0, '31', 0, '24', 0, '70', 0, '17', 1, '11', 1, '68', 0, '17', 1, '49', 0, '58', 0, '2021-04-29'),
(48, 'Arthur (4)', 0, 3, '18', 0, '67', 0, '68', 0, '36', 0, '2', 0, '7', 0, '54', 0, '62', 0, '62', 0, '25', 0, '2021-04-29');

-- --------------------------------------------------------

--
-- Estrutura para tabela `cambistas`
--

CREATE TABLE `cambistas` (
  `id` int(11) NOT NULL,
  `nome` varchar(30) NOT NULL,
  `celular` varchar(20) NOT NULL,
  `cargo` varchar(20) NOT NULL,
  `data` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Despejando dados para a tabela `cambistas`
--

INSERT INTO `cambistas` (`id`, `nome`, `celular`, `cargo`, `data`) VALUES
(2, 'Gustavo', '(19)98908-9222', 'Cambista', '2021-04-22'),
(3, 'Reinaldo', '(19)98715-5617', 'Cambista', '2021-04-22');

-- --------------------------------------------------------

--
-- Estrutura para tabela `cargos`
--

CREATE TABLE `cargos` (
  `id` int(11) NOT NULL,
  `cargo` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Despejando dados para a tabela `cargos`
--

INSERT INTO `cargos` (`id`, `cargo`) VALUES
(1, 'Cambista'),
(2, 'Admin'),
(3, 'Apostador');

-- --------------------------------------------------------

--
-- Estrutura para tabela `resultsorteio`
--

CREATE TABLE `resultsorteio` (
  `id` int(11) NOT NULL,
  `nomesorteio` varchar(50) NOT NULL,
  `numero1` varchar(10) NOT NULL,
  `numero2` varchar(10) NOT NULL,
  `numero3` varchar(10) NOT NULL,
  `numero4` varchar(10) NOT NULL,
  `numero5` varchar(10) NOT NULL,
  `data` date NOT NULL,
  `sorteios-finalizado` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Despejando dados para a tabela `resultsorteio`
--

INSERT INTO `resultsorteio` (`id`, `nomesorteio`, `numero1`, `numero2`, `numero3`, `numero4`, `numero5`, `data`, `sorteios-finalizado`) VALUES
(64, 'Sorteio1', '11', '12', '13', '14', '15', '2021-04-29', 0),
(65, 'sorteio76', '11', '12', '13', '15', '17', '2021-04-29', 0);

-- --------------------------------------------------------

--
-- Estrutura para tabela `usuarios`
--

CREATE TABLE `usuarios` (
  `id` int(11) NOT NULL,
  `nome` varchar(30) NOT NULL,
  `cargo` varchar(20) NOT NULL,
  `usuario` varchar(30) NOT NULL,
  `senha` varchar(30) NOT NULL,
  `data` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Despejando dados para a tabela `usuarios`
--

INSERT INTO `usuarios` (`id`, `nome`, `cargo`, `usuario`, `senha`, `data`) VALUES
(1, 'Bruno', 'Admin', 'BrunoAdm', '123', '2021-04-22');

--
-- Índices de tabelas apagadas
--

--
-- Índices de tabela `apostadores`
--
ALTER TABLE `apostadores`
  ADD PRIMARY KEY (`id`);

--
-- Índices de tabela `apostas`
--
ALTER TABLE `apostas`
  ADD PRIMARY KEY (`id`);

--
-- Índices de tabela `cambistas`
--
ALTER TABLE `cambistas`
  ADD PRIMARY KEY (`id`);

--
-- Índices de tabela `cargos`
--
ALTER TABLE `cargos`
  ADD PRIMARY KEY (`id`);

--
-- Índices de tabela `resultsorteio`
--
ALTER TABLE `resultsorteio`
  ADD PRIMARY KEY (`id`);

--
-- Índices de tabela `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT de tabelas apagadas
--

--
-- AUTO_INCREMENT de tabela `apostadores`
--
ALTER TABLE `apostadores`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de tabela `apostas`
--
ALTER TABLE `apostas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=49;

--
-- AUTO_INCREMENT de tabela `cambistas`
--
ALTER TABLE `cambistas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de tabela `cargos`
--
ALTER TABLE `cargos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de tabela `resultsorteio`
--
ALTER TABLE `resultsorteio`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=66;

--
-- AUTO_INCREMENT de tabela `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
