-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Jul 13, 2024 at 02:26 PM
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
  `nama` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `tb_admin`
--

INSERT INTO `tb_admin` (`id_admin`, `nama`) VALUES
(1, 'Admin - Irul'),
(2, 'Admin - Amal'),
(3, 'Admin - Nira'),
(4, 'Admin - Putri');

-- --------------------------------------------------------

--
-- Table structure for table `tb_dokter`
--

CREATE TABLE `tb_dokter` (
  `id_dokter` int NOT NULL,
  `nama` varchar(100) NOT NULL,
  `jk` varchar(20) NOT NULL,
  `spesialis` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `tb_dokter`
--

INSERT INTO `tb_dokter` (`id_dokter`, `nama`, `jk`, `spesialis`) VALUES
(1, 'Dr. Arifin', 'Laki-Laki', 'Umum'),
(2, 'Dr. Kamal', 'Laki-laki', 'Mata'),
(3, 'Dr. Rizal', 'Laki-laki', 'Umum'),
(4, 'Dr. Safiya', 'Perempuan', 'Kandungan'),
(5, 'Dr. Nurul', 'Perempuan', 'Umum');

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
(9, 'Nitroglycerin'),
(10, 'Aspirin 81MG'),
(11, 'Tetrahydrozoline (Visine)'),
(12, 'Paracetamol 500MG'),
(13, 'Ibuprofen 400MG');

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
(11, '01', 'Rasyid', 'Laki - laki', 30),
(12, '02', 'Matrui', 'Laki - laki', 58),
(13, '03', 'Kholil', 'Laki - laki', 20),
(14, '04', 'Shasa', 'Perempuan', 35),
(15, '05', 'Yanti', 'Perempuan', 70);

-- --------------------------------------------------------

--
-- Table structure for table `tb_rekam_medis`
--

CREATE TABLE `tb_rekam_medis` (
  `id_rekam` int NOT NULL,
  `id_pasien` int NOT NULL,
  `keluhan` text NOT NULL,
  `diagnosa` text CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `tanggal` date NOT NULL,
  `id_dokter` int NOT NULL,
  `status` enum('pendaftaran','pemeriksaan','selesai') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `tb_rekam_medis`
--

INSERT INTO `tb_rekam_medis` (`id_rekam`, `id_pasien`, `keluhan`, `diagnosa`, `tanggal`, `id_dokter`, `status`) VALUES
(15, 12, 'Sakit Jantung', '', '2021-03-28', 1, 'pendaftaran'),
(19, 13, 'Sakit Gigi', '', '2021-03-28', 5, 'pendaftaran'),
(25, 12, 'Sakit Jantung', '', '2021-03-28', 1, 'pendaftaran'),
(26, 13, 'Sakit Jantung', '', '2021-03-28', 1, 'pemeriksaan'),
(34, 11, 'Menggigil', 'Demam', '2024-06-01', 3, 'selesai'),
(35, 12, 'Sakit Kepala', 'Migren', '2024-06-01', 4, 'pemeriksaan'),
(38, 15, 'Sakit Hati', 'Habis Putus', '2024-07-24', 1, 'selesai'),
(40, 14, 'Sakit Kepala', 'Migren', '2024-07-11', 5, 'selesai'),
(44, 15, 'Sakit Mata', 'Mata Iritasi', '2024-07-12', 4, 'selesai'),
(45, 12, 'Sakit Mata', 'Iritasi Mata', '2024-07-16', 2, 'selesai'),
(47, 13, 'Sakit Gigi', 'Gigi Berlubang', '2024-07-12', 5, 'selesai'),
(48, 13, 'Sakit Kepala', 'Migren', '2024-07-13', 1, 'selesai'),
(49, 11, 'Sakit Gigi', NULL, '2024-07-13', 1, 'pendaftaran'),
(50, 14, 'Sakit Mata', 'Iritasi', '2024-07-13', 1, 'selesai'),
(52, 11, 'Sakit Mata', NULL, '2024-07-13', 2, 'pemeriksaan'),
(53, 13, 'Sakit Mata', NULL, '2024-07-13', 2, 'pemeriksaan'),
(54, 13, 'Pusing', NULL, '2024-07-13', 3, 'pemeriksaan'),
(55, 15, 'Sakit Perut', NULL, '2024-07-13', 3, 'pemeriksaan'),
(56, 14, 'Sakit Perut', NULL, '2024-07-13', 4, 'pemeriksaan'),
(57, 15, 'Nyeri Perut', NULL, '2024-07-13', 4, 'pemeriksaan'),
(58, 14, 'Demam', NULL, '2024-07-13', 5, 'pemeriksaan');

-- --------------------------------------------------------

--
-- Table structure for table `tb_resep`
--

CREATE TABLE `tb_resep` (
  `id_resep` int NOT NULL,
  `id_rekam` int NOT NULL,
  `id_obat` int NOT NULL,
  `keterangan` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `tb_resep`
--

INSERT INTO `tb_resep` (`id_resep`, `id_rekam`, `id_obat`, `keterangan`) VALUES
(15, 34, 12, 'Minum 3 kali sehari setelah makan'),
(16, 38, 12, 'Move on'),
(17, 40, 12, 'Minum 2 kali sehari setelah makan'),
(20, 44, 11, 'Teteskan 1-2 tetes di mata 3-4x kali sehari'),
(21, 45, 11, 'Teteskan 2-3 kali sehari'),
(22, 47, 9, 'Minum 2x sehari setelah makan'),
(23, 47, 12, 'Minum 2x sehari'),
(24, 47, 9, 'Minum 2x sehari'),
(25, 48, 12, 'Minum 1 tablet 2x sehari setelah makan'),
(26, 50, 11, 'Teteskan 2-3 tetes 3-4 kali sehari ');

-- --------------------------------------------------------

--
-- Table structure for table `tb_user`
--

CREATE TABLE `tb_user` (
  `username` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL,
  `level` varchar(15) NOT NULL,
  `id_admin` int DEFAULT NULL,
  `id_dokter` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `tb_user`
--

INSERT INTO `tb_user` (`username`, `password`, `level`, `id_admin`, `id_dokter`) VALUES
('admin', 'admin123', 'Admin', 1, NULL),
('admin2', 'admin123', 'Admin', 2, NULL),
('arifin', '12345', 'Dokter', NULL, 1),
('kamal', '12345', 'Dokter', NULL, 2),
('nurul', '12345', 'Dokter', NULL, 5),
('rizal', '12345', 'Dokter', NULL, 3),
('safiya', '12345', 'Dokter', NULL, 4);

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
  ADD KEY `fk_id_dokter` (`id_dokter`);

--
-- Indexes for table `tb_resep`
--
ALTER TABLE `tb_resep`
  ADD PRIMARY KEY (`id_resep`),
  ADD KEY `fk_id_obat` (`id_obat`),
  ADD KEY `fk_tb_rekam_medis_id_rekam` (`id_rekam`);

--
-- Indexes for table `tb_user`
--
ALTER TABLE `tb_user`
  ADD PRIMARY KEY (`username`),
  ADD KEY `fk_admin` (`id_admin`),
  ADD KEY `fk_dokter` (`id_dokter`);

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
  MODIFY `id_dokter` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `tb_obat`
--
ALTER TABLE `tb_obat`
  MODIFY `id_obat` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT for table `tb_pasien`
--
ALTER TABLE `tb_pasien`
  MODIFY `id_pasien` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT for table `tb_rekam_medis`
--
ALTER TABLE `tb_rekam_medis`
  MODIFY `id_rekam` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=59;

--
-- AUTO_INCREMENT for table `tb_resep`
--
ALTER TABLE `tb_resep`
  MODIFY `id_resep` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tb_rekam_medis`
--
ALTER TABLE `tb_rekam_medis`
  ADD CONSTRAINT `fk_id_dokter` FOREIGN KEY (`id_dokter`) REFERENCES `tb_dokter` (`id_dokter`),
  ADD CONSTRAINT `fk_id_pasien` FOREIGN KEY (`id_pasien`) REFERENCES `tb_pasien` (`id_pasien`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
