-- phpMyAdmin SQL Dump
-- version 4.6.5.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 08, 2019 at 06:54 PM
-- Server version: 10.1.21-MariaDB
-- PHP Version: 7.1.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `test_excelsoft`
--

-- --------------------------------------------------------

--
-- Table structure for table `bioskop`
--

CREATE TABLE `bioskop` (
  `id_bioskop` int(11) NOT NULL,
  `kd_bioskop` varchar(3) NOT NULL,
  `nama_bioskop` varchar(100) NOT NULL,
  `alamat_bioskop` varchar(300) NOT NULL,
  `kota` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `bioskop`
--

INSERT INTO `bioskop` (`id_bioskop`, `kd_bioskop`, `nama_bioskop`, `alamat_bioskop`, `kota`) VALUES
(8, 'CPB', 'Cinerma 21', 'Jl. Pramuka', 'Batu'),
(9, 'CSM', 'Cinerma 21', 'Jl. S. Parman', 'Malang'),
(10, 'MHM', 'Mandala', 'Jl. Hasanudin ', 'Malang');

-- --------------------------------------------------------

--
-- Table structure for table `film`
--

CREATE TABLE `film` (
  `id_film` int(11) NOT NULL,
  `kd_film` varchar(105) NOT NULL,
  `judul_film` varchar(100) NOT NULL,
  `tgl_launch` datetime NOT NULL,
  `synopsis` varchar(1000) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `film`
--

INSERT INTO `film` (`id_film`, `kd_film`, `judul_film`, `tgl_launch`, `synopsis`) VALUES
(285, 'RW001', 'Run Winner', '2019-12-13 06:43:02', 'Terus berlari tanpa hentiiii, pantang menyerah....'),
(286, 'RW002', 'Run Away', '2019-12-16 06:43:02', 'Berlari menjauh'),
(287, 'RW003', 'Rusuh Woi', '2019-12-21 06:43:02', 'Kalemmmm ajaaa...'),
(288, 'RW004', 'Rasa Uwu', '2019-12-23 06:46:35', 'Rasaaaaanyaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa'),
(289, 'WY001', 'Away', '2019-12-30 06:55:40', 'AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA'),
(290, 'WY002', 'Away', '2019-12-27 06:55:40', 'bbbb'),
(291, 'WY003', 'Away', '2019-12-27 06:55:40', 'bbbb'),
(292, 'WY004', 'Away', '2019-12-27 06:55:40', 'bbbb'),
(293, 'KD001', 'Aku Suka Kamu Apa Adanya', '2020-01-10 06:55:40', 'YAAAA KANNN...'),
(294, 'KD002', 'Aku Suka Kamu Apa Adanya', '2020-01-10 06:55:40', 'YAAAA KANNN...'),
(295, 'KD003', 'Aku Suka Kamu Apa Adanya', '2020-01-10 06:55:40', 'YAAAA KANNN...'),
(296, 'KD004', 'Aku Suka Kamu Apa Adanya', '2020-01-10 06:55:40', 'YAAAA KANNN...'),
(297, 'KD005', 'Aku Suka Kamu Apa Adanya', '2020-01-10 06:55:40', 'YAAAA KANNN...'),
(298, 'KD006', 'Aku Suka Kamu Apa Adanya', '2020-01-10 06:55:40', 'YAAAA KANNN...'),
(299, 'KD007', 'Aku Suka Kamu Apa Adanya', '2020-01-10 06:55:40', 'YAAAA KANNN...'),
(300, 'KD008', 'Aku Suka Kamu Apa Adanya', '2020-01-10 06:55:40', 'YAAAA KANNN...'),
(301, 'KD009', 'Aku Suka Kamu Apa Adanya', '2020-01-10 06:55:40', 'YAAAA KANNN...'),
(302, 'KD010', 'Aku Suka Kamu Apa Adanya', '2020-01-10 06:55:40', 'YAAAA KANNN...'),
(303, 'HH001', 'Hai', '2020-01-10 06:55:40', 'YAAAA KANNN...'),
(304, 'HA001', 'ahha', '2020-01-10 06:55:40', 'YAAAA KANNN...'),
(305, 'HA002', 'ahha', '2020-01-10 06:55:40', 'YAAAA KANNN...'),
(306, 'HA003', 'ahha', '2020-01-10 06:55:40', 'YAAAA KANNN...'),
(307, 'HH002', 'Haiiiiiii', '2020-01-10 06:55:40', 'YAAAA KANNN...'),
(308, 'HH003', 'Haiiiiiii', '2020-01-10 06:55:40', 'YAAAA KANNN...'),
(309, 'RW005', 'Run Winner2', '2019-12-09 00:18:06', 'Lanjutan season 1');

-- --------------------------------------------------------

--
-- Table structure for table `jadwal_tayang`
--

CREATE TABLE `jadwal_tayang` (
  `id_tayang` int(11) NOT NULL,
  `kd_tayang` varchar(25) NOT NULL,
  `judul_film` varchar(100) NOT NULL,
  `tgldanwaktu_tayang` varchar(20) NOT NULL,
  `jml_kursi` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `jadwal_tayang`
--

INSERT INTO `jadwal_tayang` (`id_tayang`, `kd_tayang`, `judul_film`, `tgldanwaktu_tayang`, `jml_kursi`) VALUES
(1, 'CPB141220191145RW00100001', 'Run Winner', '14/12/2019 11:45', 100),
(2, 'CPB141220191145RW00100002', 'Run Winner', '14/12/2019 11:45', 100),
(3, 'CPB141220191145RW00100003', 'Run Winner', '14/12/2019 11:45', 100),
(4, 'CPB141220191145RW00100004', 'Run Winner', '14/12/2019 11:45', 100),
(5, 'CPB141220191145RW00100005', 'Run Winner', '14/12/2019 11:45', 100),
(6, 'CPB141220191915RW00100001', 'Run Winner', '14/12/2019 19:15', 100),
(7, 'CPB141220191915RW00100002', 'Run Winner', '14/12/2019 19:15', 100),
(9, 'CSM4120201645KD01000001', 'Aku Suka Kamu Apa Adanya', '4/1/2020 16:45', 60),
(10, 'CSM4120201645KD01000002', 'Aku Suka Kamu Apa Adanya', '4/1/2020 16:45', 60),
(11, 'CSM4120201645KD01000003', 'Aku Suka Kamu Apa Adanya', '4/1/2020 16:45', 60),
(12, 'CSM4120201645KD01000004', 'Aku Suka Kamu Apa Adanya', '4/1/2020 16:45', 900),
(13, 'MHM91220191415KD01000001', 'Aku Suka Kamu Apa Adanya', '9/12/2019 14:15', 78),
(14, 'MHM91220191415KD01000002', 'Aku Suka Kamu Apa Adanya', '9/12/2019 14:15', 78);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `bioskop`
--
ALTER TABLE `bioskop`
  ADD PRIMARY KEY (`id_bioskop`);

--
-- Indexes for table `film`
--
ALTER TABLE `film`
  ADD PRIMARY KEY (`id_film`);

--
-- Indexes for table `jadwal_tayang`
--
ALTER TABLE `jadwal_tayang`
  ADD PRIMARY KEY (`id_tayang`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `bioskop`
--
ALTER TABLE `bioskop`
  MODIFY `id_bioskop` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
--
-- AUTO_INCREMENT for table `film`
--
ALTER TABLE `film`
  MODIFY `id_film` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=310;
--
-- AUTO_INCREMENT for table `jadwal_tayang`
--
ALTER TABLE `jadwal_tayang`
  MODIFY `id_tayang` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
