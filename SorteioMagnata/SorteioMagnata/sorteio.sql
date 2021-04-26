-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 26/04/2021 às 23:48
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
  `participantes` varchar(30) NOT NULL,
  `numeroaposta1` varchar(10) NOT NULL,
  `numeroaposta2` varchar(10) NOT NULL,
  `numeroaposta3` varchar(10) NOT NULL,
  `numeroaposta4` varchar(10) NOT NULL,
  `numeroaposta5` varchar(10) NOT NULL,
  `numeroaposta6` varchar(10) NOT NULL,
  `numeroaposta7` varchar(10) NOT NULL,
  `numeroaposta8` varchar(10) NOT NULL,
  `numeroaposta9` varchar(10) NOT NULL,
  `numeroaposta10` varchar(10) NOT NULL,
  `data` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Despejando dados para a tabela `apostas`
--

INSERT INTO `apostas` (`id`, `participantes`, `numeroaposta1`, `numeroaposta2`, `numeroaposta3`, `numeroaposta4`, `numeroaposta5`, `numeroaposta6`, `numeroaposta7`, `numeroaposta8`, `numeroaposta9`, `numeroaposta10`, `data`) VALUES
(2, 'Nivia', '10', '11', '12', '13', '14', '15', '16', '17', '18', '19', '2021-04-23');

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
  `participantes` varchar(30) NOT NULL,
  `numaposta` int(11) NOT NULL,
  `acertos` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

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
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

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
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Restrições para dumps de tabelas
--

--
-- Restrições para tabelas `apostas`
--
ALTER TABLE `apostas`
  ADD CONSTRAINT `apostas_ibfk_1` FOREIGN KEY (`id`) REFERENCES `apostadores` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
