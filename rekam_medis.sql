-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: May 30, 2024 at 06:44 AM
-- Server version: 8.0.30
-- PHP Version: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `rekam_medis`
--

-- --------------------------------------------------------

--
-- Table structure for table `tb_admin`
--

CREATE TABLE `tb_admin` (
  `id_admin` int NOT NULL,
  `nama` varchar(100) NOT NULL,
  `username` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `tb_admin`
--

INSERT INTO `tb_admin` (`id_admin`, `nama`, `username`, `password`) VALUES
(1, 'Irul', 'Irul', '12345'),
(2, 'Amal', 'Amal', '12345'),
(3, 'Nira', 'Nira', '12345'),
(4, 'Putri', 'Putri', '12345');

-- --------------------------------------------------------

--
-- Table structure for table `tb_dokter`
--

CREATE TABLE `tb_dokter` (
  `id_dokter` int NOT NULL,
  `nama` varchar(100) NOT NULL,
  `jk` varchar(20) NOT NULL,
  `spesialis` varchar(100) NOT NULL,
  `username` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `tb_dokter`
--

INSERT INTO `tb_dokter` (`id_dokter`, `nama`, `jk`, `spesialis`, `username`, `password`) VALUES
(1, 'Dr. Arifin', 'Laki-Laki', 'Umum', 'Dr. Arifin', '12345'),
(2, 'Dr. Kamal', 'Laki-laki', 'Mata', 'Dr. Kamal', '12345'),
(3, 'Dr. Rizal', 'Laki-laki', 'Umum', 'Dr. Rizal', '12345'),
(4, 'Dr. Safiya', 'Perempuan', 'Kandungan', 'Dr. Safiya', '12345'),
(5, 'Dr. Nurul', 'Perempuan', 'Umum', 'Dr. Nurul', '12345');

-- --------------------------------------------------------

--
-- Table structure for table `tb_obat`
--

CREATE TABLE `tb_obat` (
  `id_obat` int NOT NULL,
  `nama` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `tb_obat`
--

INSERT INTO `tb_obat` (`id_obat`, `nama`) VALUES
(1, 'PARACETAMOL 500MG'),
(2, 'PARACETAMOL 250MG'),
(4, 'PANADOL');

-- --------------------------------------------------------

--
-- Table structure for table `tb_pasien`
--

CREATE TABLE `tb_pasien` (
  `id_pasien` int NOT NULL,
  `no_kartu` varchar(100) NOT NULL,
  `nama` varchar(100) NOT NULL,
  `jk` varchar(20) NOT NULL,
  `umur` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `tb_pasien`
--

INSERT INTO `tb_pasien` (`id_pasien`, `no_kartu`, `nama`, `jk`, `umur`) VALUES
(11, '01', 'Rasyid', 'Laki - laki', 25),
(12, '02', 'Matrui', 'Laki - laki', 50),
(13, '03', 'Kholil', 'Laki - laki', 20);

-- --------------------------------------------------------

--
-- Table structure for table `tb_rekam_medis`
--

CREATE TABLE `tb_rekam_medis` (
  `id_rekam` int NOT NULL,
  `id_pasien` int NOT NULL,
  `keluhan` text NOT NULL,
  `diagnosa` text NOT NULL,
  `tanggal` date NOT NULL,
  `id_dokter` int NOT NULL,
  `id_admin` int NOT NULL,
  `status` enum('pendaftaran','pemeriksaan','tebus_obat','selesai') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `tb_rekam_medis`
--

INSERT INTO `tb_rekam_medis` (`id_rekam`, `id_pasien`, `keluhan`, `diagnosa`, `tanggal`, `id_dokter`, `id_admin`, `status`) VALUES
(12, 11, 'sakit gigi', '', '2021-03-28', 1, 1, 'pendaftaran'),
(13, 11, 'sakit mata', 'kurang vitamin c', '2021-03-28', 1, 1, 'selesai'),
(14, 11, 'sakit gigi', 'kebayakan makan coklat', '2021-03-28', 1, 1, 'selesai'),
(15, 12, 'sakit perut', '', '2021-03-28', 1, 1, 'pendaftaran'),
(16, 12, 'sakit perut', 'salah makan', '2021-03-28', 1, 1, 'selesai'),
(17, 12, 'sakit perut', '', '2021-03-28', 1, 1, 'pendaftaran'),
(18, 12, 'sakit perut', 'adasfsdfsd', '2021-03-28', 1, 1, 'selesai'),
(19, 13, 'sakit gigi', '', '2021-03-28', 5, 1, 'pendaftaran'),
(20, 13, 'sakit gigi', 'kebayakan makam permen', '2021-03-28', 5, 1, 'tebus_obat'),
(21, 13, 'sakit gigi', 'kebanyakan banyak permen', '2021-03-28', 5, 1, 'tebus_obat'),
(23, 11, 'SAKIT MATA', 'KURANG VITAMIN A', '2021-03-28', 1, 1, 'selesai'),
(24, 12, 'SAKIt GIGI', '', '2024-05-28', 1, 1, 'pendaftaran'),
(25, 12, 'MUNTABER', 'SALAH MAKAN', '2021-03-28', 1, 1, 'selesai'),
(26, 13, 'SAKIT PERUT', '', '2021-03-28', 1, 1, 'pendaftaran'),
(27, 13, 'SAKIT PERUT', 'SALAH MAKAN', '2021-03-28', 1, 1, 'selesai');

-- --------------------------------------------------------

--
-- Table structure for table `tb_resep`
--

CREATE TABLE `tb_resep` (
  `id_resep` int NOT NULL,
  `id_rekam` int NOT NULL,
  `id_obat` int NOT NULL,
  `keterangan` text NOT NULL,
  `nama` varchar(150) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `tb_resep`
--

INSERT INTO `tb_resep` (`id_resep`, `id_rekam`, `id_obat`, `keterangan`, `nama`) VALUES
(1, 13, 1, 'Minum 3x sehari setelah makan', 'PARACETAMOL 500MG'),
(2, 14, 2, 'Minum 2x sehari sebelum makan', 'PARACETAMOL 250MG'),
(3, 16, 4, 'Minum 2x sehari setelah makan', 'PANADOL'),
(4, 18, 4, 'Minum 2x sehari setelah makan', 'PANADOL'),
(5, 20, 2, 'Minum 2x sehari sebelum makan', 'PARACETAMOL 250MG'),
(6, 21, 4, 'Minum 2x sehari setelah makan', 'PANADOL'),
(7, 23, 4, 'Minum 2x sehari setelah makan', 'PANADOL'),
(8, 25, 2, 'Minum 2x sehari sebelum makan', 'PARACETAMOL 250MG'),
(9, 27, 2, 'Minum 2x sehari sebelum makan', 'PARACETAMOL 250MG');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tb_admin`
--
ALTER TABLE `tb_admin`
  ADD PRIMARY KEY (`id_admin`);

--
-- Indexes for table `tb_dokter`
--
ALTER TABLE `tb_dokter`
  ADD PRIMARY KEY (`id_dokter`);

--
-- Indexes for table `tb_obat`
--
ALTER TABLE `tb_obat`
  ADD PRIMARY KEY (`id_obat`);

--
-- Indexes for table `tb_pasien`
--
ALTER TABLE `tb_pasien`
  ADD PRIMARY KEY (`id_pasien`);

--
-- Indexes for table `tb_rekam_medis`
--
ALTER TABLE `tb_rekam_medis`
  ADD PRIMARY KEY (`id_rekam`),
  ADD KEY `fk_id_pasien` (`id_pasien`),
  ADD KEY `fk_id_dokter` (`id_dokter`),
  ADD KEY `fk_id_admin` (`id_admin`);

--
-- Indexes for table `tb_resep`
--
ALTER TABLE `tb_resep`
  ADD PRIMARY KEY (`id_resep`),
  ADD KEY `fk_id_rekam` (`id_rekam`),
  ADD KEY `fk_id_obat` (`id_obat`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tb_admin`
--
ALTER TABLE `tb_admin`
  MODIFY `id_admin` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `tb_dokter`
--
ALTER TABLE `tb_dokter`
  MODIFY `id_dokter` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `tb_obat`
--
ALTER TABLE `tb_obat`
  MODIFY `id_obat` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `tb_pasien`
--
ALTER TABLE `tb_pasien`
  MODIFY `id_pasien` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `tb_rekam_medis`
--
ALTER TABLE `tb_rekam_medis`
  MODIFY `id_rekam` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=28;

--
-- AUTO_INCREMENT for table `tb_resep`
--
ALTER TABLE `tb_resep`
  MODIFY `id_resep` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tb_rekam_medis`
--
ALTER TABLE `tb_rekam_medis`
  ADD CONSTRAINT `fk_id_admin` FOREIGN KEY (`id_admin`) REFERENCES `tb_admin` (`id_admin`),
  ADD CONSTRAINT `fk_id_dokter` FOREIGN KEY (`id_dokter`) REFERENCES `tb_dokter` (`id_dokter`),
  ADD CONSTRAINT `fk_id_pasien` FOREIGN KEY (`id_pasien`) REFERENCES `tb_pasien` (`id_pasien`);

--
-- Constraints for table `tb_resep`
--
ALTER TABLE `tb_resep`
  ADD CONSTRAINT `fk_id_obat` FOREIGN KEY (`id_obat`) REFERENCES `tb_obat` (`id_obat`),
  ADD CONSTRAINT `fk_id_rekam` FOREIGN KEY (`id_rekam`) REFERENCES `tb_rekam_medis` (`id_rekam`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
