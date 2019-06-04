-- phpMyAdmin SQL Dump
-- version 4.6.5.2
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: Apr 23, 2019 at 03:54 PM
-- Server version: 10.1.21-MariaDB
-- PHP Version: 5.6.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `kbm`
--

-- --------------------------------------------------------

--
-- Table structure for table `absen`
--

CREATE TABLE `absen` (
  `idabsen` varchar(12) NOT NULL,
  `tanggal` date NOT NULL,
  `nis` varchar(10) NOT NULL,
  `ket` varchar(10) NOT NULL,
  `status` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `absen`
--

INSERT INTO `absen` (`idabsen`, `tanggal`, `nis`, `ket`, `status`) VALUES
(' 18121805093', '2018-12-18', '161710236', 'Sakit', NULL),
('181218051320', '2018-12-18', '161710237', 'Izin', NULL),
('181218051602', '2018-12-18', '161710236', 'Sakit', NULL),
('181219022342', '2018-12-19', '161710254', 'Sakit', NULL),
('181219022401', '2018-12-19', '161710238', 'Izin', NULL),
('181219022423', '2018-12-19', '161710277', 'Sakit', NULL),
('181229112852', '2018-12-29', '161710275', 'Izin', NULL),
('190101083359', '2019-01-01', '161710299', 'Sakit', NULL),
('190105102846', '2019-01-05', '161710268', 'Izin', NULL),
('190311080045', '2019-03-11', '161710236', 'Sakit', NULL),
('190311080131', '2019-03-11', '161710278', 'Izin', NULL),
('190405013649', '2019-04-05', '161710317', 'Sakit', NULL),
('190405022249', '2019-04-05', '161710255', 'Alfa', NULL),
('190405125415', '2019-04-05', '161710236', 'Izin', NULL),
('190406022210', '2019-04-06', '161710236', 'Izin', NULL),
('190406022249', '2019-04-06', '161710237', 'Alfa', NULL),
('190406022355', '2019-04-06', '161710238', 'Izin', NULL),
('190408125121', '2019-04-08', '161710236', 'Izin', NULL),
('190416023000', '2019-04-16', '161710237', 'Alfa', 'SUDAH'),
('190416035012', '2019-04-16', '161710243', 'Alfa', 'SUDAH'),
('190416064808', '2019-04-16', '161710241', 'Sakit', 'SUDAH'),
('190416064830', '2019-04-16', '161710265', 'Izin', 'SUDAH'),
('190423101454', '2019-04-23', '161710236', 'Izin', 'BELUM'),
('190423102651', '2019-04-23', '161710237', 'Izin', 'BELUM'),
('190423104432', '2019-04-23', '161710255', 'Alfa', 'BELUM');

-- --------------------------------------------------------

--
-- Table structure for table `absenguru`
--

CREATE TABLE `absenguru` (
  `idabsenguru` varchar(12) NOT NULL,
  `tanggal` date NOT NULL,
  `idguru` varchar(10) NOT NULL,
  `masuk` time DEFAULT NULL,
  `pulang` time DEFAULT NULL,
  `ket` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `absenguru`
--

INSERT INTO `absenguru` (`idabsenguru`, `tanggal`, `idguru`, `masuk`, `pulang`, `ket`) VALUES
('G19041102370', '2019-04-11', '10', '14:37:00', '14:41:00', 'PULANG'),
('G19041102515', '2019-04-11', '2', '14:51:00', '14:51:00', 'PULANG'),
('G19041601595', '2019-04-16', '2', '13:59:00', '13:59:00', 'PULANG'),
('G19041704590', '2019-04-17', '2', '16:59:00', '20:36:00', 'PULANG'),
('G19041908375', '2019-04-19', '1', '20:37:00', '00:00:00', 'MASUK'),
('G19042311043', '2019-04-23', '6', '11:04:00', '15:04:00', 'PULANG');

-- --------------------------------------------------------

--
-- Table structure for table `guru`
--

CREATE TABLE `guru` (
  `idguru` varchar(10) NOT NULL,
  `nama` varchar(30) NOT NULL,
  `jk` varchar(10) NOT NULL,
  `alamat` varchar(30) NOT NULL,
  `username` varchar(15) DEFAULT NULL,
  `password` varchar(50) DEFAULT NULL,
  `jabatan1` varchar(10) DEFAULT NULL,
  `jabatan2` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `guru`
--

INSERT INTO `guru` (`idguru`, `nama`, `jk`, `alamat`, `username`, `password`, `jabatan1`, `jabatan2`) VALUES
('1', 'Admin', 'Perempuan', 'Bungkul', 'admin', '21232f297a57a5a743894a0e4a801fc3', NULL, 'Admin'),
('10', 'Doni', 'Laki-laki', 'Indramayu', 'doni', '2da9cd653f63c010b6d6c5a5ad73fe32', 'Guru Mapel', 'Guru Piket'),
('11', 'Faank', 'Laki-laki', 'Indramayu', 'faank', 'f720b0fb220577500cf32977a48f6e93', 'Guru Mapel', ''),
('2', 'Agung Subagja', 'Laki-laki', 'Bungkul Selatan', 'agung', 'e59cd3ce33a68f536c19fedb82a7936f', 'Guru Mapel', 'Guru Piket'),
('3', 'Ronjani', 'Laki-laki', 'Panyingkiran Kidul Wetan', 'jani', 'd5d51a2d88cda585e37315067891381f', 'Guru Mapel', ''),
('4', 'Muhammad Afif', 'Laki-laki', 'Mekar Gading', 'apip', '5afc731a4d5274f52c9bf71be129b609', 'Guru Mapel', 'Guru Piket'),
('5', 'Asep Aris Setiawan', 'Laki-laki', 'Bumi Dermayu Indah', 'aris', '288077f055be4fadc3804a69422dd4f8', 'Guru Mapel', 'Admin'),
('6', 'Nuranto', 'Laki-laki', 'Tambak', 'nuranto', 'c4595866f412f14ea508fd7b7f7841fe', 'Guru Mapel', ''),
('7', 'Iip Arif Fadillah', 'Laki-laki', 'Pabean', 'iip', '15080aef9becea7697a1e16500b12aa5', 'Guru Mapel', ''),
('8', 'Heri Heryanto', 'Laki-laki', 'Terusan', 'heri', '6812af90c6a1bbec134e323d7e70587b', 'Guru Mapel', 'Wakakur'),
('9', 'Ice Susilawati', 'Perempuan', 'Plumbon', 'ice', '7bdff76536f12a7c5ffde207e72cfe3a', 'Guru Mapel', '');

-- --------------------------------------------------------

--
-- Table structure for table `jadwal`
--

CREATE TABLE `jadwal` (
  `idjadwal` varchar(10) NOT NULL,
  `hari` varchar(10) NOT NULL,
  `jamawal` time NOT NULL,
  `jamakhir` time NOT NULL,
  `idmapel` varchar(10) NOT NULL,
  `idkelas` varchar(10) NOT NULL,
  `idguru` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `jadwal`
--

INSERT INTO `jadwal` (`idjadwal`, `hari`, `jamawal`, `jamakhir`, `idmapel`, `idkelas`, `idguru`) VALUES
('S003', 'Rabu', '07:00:00', '10:00:00', '016', '1', '3'),
('S004', 'Kamis', '07:00:00', '10:00:00', '007', '8', '2'),
('S005', 'Jumat', '07:00:00', '10:00:00', '003', '7', '3'),
('S010', 'Senin', '07:00:00', '08:30:00', '001', '1', '2'),
('S011', 'Senin', '08:30:00', '10:00:00', '002', '1', '3'),
('S012', 'Senin', '10:30:00', '12:00:00', '003', '1', '4'),
('S013', 'Tuesday', '13:00:00', '15:00:00', '017', '1', '5'),
('S014', 'Selasa', '07:00:00', '08:30:00', '010', '1', '9'),
('S015', 'Selasa', '08:30:00', '10:00:00', '015', '1', '6'),
('S016', 'Selasa', '10:30:00', '12:00:00', '007', '1', '4'),
('S017', 'Selasa', '13:00:00', '15:00:00', '004', '1', '5'),
('S018', 'Senin', '07:00:00', '08:00:00', '012', '2', '4'),
('S019', 'Senin', '08:00:00', '10:00:00', '003', '2', '10'),
('S020', 'Senin', '10:30:00', '12:00:00', '015', '2', '8'),
('S021', 'Senin', '13:00:00', '15:00:00', '002', '2', '6'),
('S022', 'Kamis', '10:30:00', '12:00:00', '003', '6', '2'),
('S023', 'Kamis', '13:00:00', '15:00:00', '006', '3', '2'),
('S024', 'Kamis', '10:30:00', '15:00:00', '002', '2', '11');

-- --------------------------------------------------------

--
-- Table structure for table `jurusan`
--

CREATE TABLE `jurusan` (
  `idjurusan` varchar(10) NOT NULL,
  `jurusan` varchar(35) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `jurusan`
--

INSERT INTO `jurusan` (`idjurusan`, `jurusan`) VALUES
('tb', 'Tata Busana'),
('tkj', 'Teknik Komputer dan Jaringan'),
('tkr', 'Teknik Kendaraan Ringan'),
('toi', 'Teknik Otomasi Industri');

-- --------------------------------------------------------

--
-- Table structure for table `kelas`
--

CREATE TABLE `kelas` (
  `idkelas` varchar(10) NOT NULL,
  `idjurusan` varchar(10) NOT NULL,
  `kelas` varchar(10) NOT NULL,
  `username` varchar(10) DEFAULT NULL,
  `password` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `kelas`
--

INSERT INTO `kelas` (`idkelas`, `idjurusan`, `kelas`, `username`, `password`) VALUES
('1', 'tkj', 'XII TKJ', 'xiitkj', '7290e4e18a6fbcd0cb16104f2a588faa'),
('2', 'tkr', 'XII TKR', 'xiitkr', 'ae926986651993e6099c00188c4261ac'),
('3', 'tb', 'XII TB', 'xiitb', 'f197aa133013f5ecb173ef0cd1ab4d04'),
('4', 'toi', 'XII TOI', 'xiitoi', '233ca8b05e19d9dec378e5573db16ee8'),
('5', 'tb', 'XI TB', 'xitb', '0cb46da274bd4a92c848c392e675acd8'),
('6', 'tkj', 'XI TKJ', 'xitkj', '4c6c53af76513374e8e85eb8002b2e75'),
('7', 'tkr', 'XI TKR', 'xitkr', 'f47b4b432e580f736151153b234985d5'),
('8', 'toi', 'XI TOI', 'xitoi', '7d0830e49bad9095e537691d615f0bb7');

-- --------------------------------------------------------

--
-- Table structure for table `mapel`
--

CREATE TABLE `mapel` (
  `idmapel` varchar(10) NOT NULL,
  `mapel` varchar(50) NOT NULL,
  `jam` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `mapel`
--

INSERT INTO `mapel` (`idmapel`, `mapel`, `jam`) VALUES
('001', 'Bahasa Indonesia', 4),
('002', 'Matematika', 4),
('003', 'Bahasa Inggris', 4),
('004', 'Produktif', 4),
('005', 'Bahasa Jepang', 2),
('006', 'Bahasa Mandarin', 2),
('007', 'Pendidikan Kewarganegaraan', 2),
('008', 'Seni Budaya', 2),
('009', 'Sejarah Indonesia', 2),
('010', 'Fisika', 3),
('011', 'Kimia', 3),
('012', 'Simulasi Digital', 3),
('013', 'Pengembangan Produk Kreatif', 3),
('014', 'Penjas', 2),
('015', 'Pendidikan Agama dan Budi Pekerti', 3),
('016', 'Matematika Mesin', 2),
('017', 'Rancang Bangun Jaringan', 9);

-- --------------------------------------------------------

--
-- Table structure for table `monitoring`
--

CREATE TABLE `monitoring` (
  `idmonitoring` varchar(13) NOT NULL,
  `tanggal` date NOT NULL,
  `idjadwal` varchar(10) NOT NULL,
  `statuskbmguru` varchar(10) DEFAULT NULL,
  `statuskbmsiswa` varchar(10) DEFAULT NULL,
  `ket` varchar(100) DEFAULT NULL,
  `gurupiket` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `monitoring`
--

INSERT INTO `monitoring` (`idmonitoring`, `tanggal`, `idjadwal`, `statuskbmguru`, `statuskbmsiswa`, `ket`, `gurupiket`) VALUES
('M190422074000', '2019-04-22', 'S018', 'MASUK', '', 'masuk bor', ''),
('M190422080051', '2019-04-22', 'S019', 'MASUK', '', 'as', ''),
('M190423075632', '2019-04-23', 'S014', '', '', 'iya masuk. buka halaman 45', ''),
('M190423094217', '2019-04-23', 'S015', 'TDK MASUK', 'MASUK', 'masuk', '');

-- --------------------------------------------------------

--
-- Table structure for table `siswa`
--

CREATE TABLE `siswa` (
  `nis` varchar(10) NOT NULL,
  `nama` varchar(20) NOT NULL,
  `jk` varchar(10) NOT NULL,
  `idjurusan` varchar(10) NOT NULL,
  `idkelas` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `siswa`
--

INSERT INTO `siswa` (`nis`, `nama`, `jk`, `idjurusan`, `idkelas`) VALUES
('161710236', 'Ade Rivaldi', 'Laki-laki', 'tkj', '1'),
('161710237', 'Adi Pratama', 'Laki-laki', 'tkj', '1'),
('161710238', 'Aditya Hermawan', 'Laki-laki', 'tkj', '1'),
('161710239', 'Afif Yuliyanto', 'Laki-laki', 'tkj', '1'),
('161710240', 'Agung Hermawan', 'Laki-laki', 'tb', '3'),
('161710241', 'Ahmad Septiana Azhar', 'Laki-laki', 'tkr', '2'),
('161710243', 'Akhmad Bady', 'Laki-laki', 'tkr', '2'),
('161710244', 'Aliyah Indriani', 'Perempuan', 'tb', '3'),
('161710245', 'Andre Priyono', 'Laki-laki', 'tb', '3'),
('161710246', 'Anggara Putra', 'Laki-laki', 'tb', '3'),
('161710247', 'Anisatun Nahdiyah', 'Perempuan', 'tb', '3'),
('161710248', 'Anita Kusmiyanti', 'Perempuan', 'toi', '4'),
('161710249', 'Anton Supriyadi', 'Laki-laki', 'toi', '4'),
('161710250', 'Arifin Triyando', 'Laki-laki', 'toi', '4'),
('161710251', 'Arin Septianingsih', 'Perempuan', 'toi', '4'),
('161710253', 'Ayu Heriyani', 'Perempuan', 'tkr', '2'),
('161710254', 'Ayunisa Nur Fitihah', 'Perempuan', 'tkj', '1'),
('161710255', 'Baequni Adnan', 'Laki-laki', 'tkj', '1'),
('161710256', 'Bayu Rizki', 'Laki-laki', 'tkr', '2'),
('161710257', 'Bayu Setiadji', 'Laki-laki', 'tb', '3'),
('161710259', 'Cartinih', 'Perempuan', 'toi', '4'),
('161710260', 'Cindi Indriyani', 'Perempuan', 'toi', '4'),
('161710263', 'Darniti', 'Perempuan', 'tkr', '2'),
('161710264', 'Dea Indriyani', 'Perempuan', 'tkr', '2'),
('161710265', 'Dede Kurniasih', 'Perempuan', 'tkr', '2'),
('161710266', 'Della Arsyita', 'Perempuan', 'tkr', '2'),
('161710267', 'Dewina', 'Perempuan', 'tb', '3'),
('161710268', 'Dian Antini', 'Perempuan', 'tb', '3'),
('161710269', 'Dian Rakmah', 'Perempuan', 'tb', '3'),
('161710270', 'Diana', 'Perempuan', 'tb', '3'),
('161710271', 'Difa Sulthan Syahla ', 'Laki-laki', 'toi', '4'),
('161710272', 'Dimas Arie Sunanto', 'Laki-laki', 'toi', '4'),
('161710273', 'Dina Nurdiyana', 'Perempuan', 'toi', '4'),
('161710275', 'Dodi Yulianto', 'Laki-laki', 'toi', '4'),
('161710276', 'Dwi Aisyah', 'Perempuan', 'toi', '4'),
('161710277', 'Dwi Muslimawati', 'Perempuan', 'tkj', '1'),
('161710278', 'Elsa Haryanti', 'Perempuan', 'tkj', '1'),
('161710279', 'Elsa Heriyanti', 'Perempuan', 'tkj', '1'),
('161710281', 'Erni', 'Perempuan', 'tkr', '2'),
('161710282', 'Eva Runingsih', 'Perempuan', 'tb', '3'),
('161710283', 'Evi Aprilia', 'Perempuan', 'tb', '3'),
('161710284', 'Fadia Nuraeni', 'Perempuan', 'tb', '3'),
('161710285', 'Fadly Bagus Laksana', 'Laki-laki', 'tb', '3'),
('161710287', 'Fariz Lucky Amukti', 'Laki-laki', 'toi', '4'),
('161710289', 'Fera Permata Sari', 'Perempuan', 'toi', '4'),
('161710290', 'Feti Prihatin', 'Perempuan', 'tkj', '1'),
('161710292', 'Fira Ramadhanti', 'Perempuan', 'tkj', '1'),
('161710294', 'Fitria Novita Sari', 'Perempuan', 'tkr', '2'),
('161710295', 'Friangga', 'Laki-laki', 'tkr', '2'),
('161710296', 'Friska Amelia', 'Perempuan', 'tkr', '2'),
('161710298', 'Heka Sephia', 'Perempuan', 'tb', '3'),
('161710299', 'Ice', 'Perempuan', 'tb', '3'),
('161710300', 'Icha Indriani', 'Perempuan', 'tb', '3'),
('161710301', 'Idah Jubaedah', 'Perempuan', 'tb', '3'),
('161710302', 'Imam Tantowi Reza', 'Laki-laki', 'toi', '4'),
('161710303', 'Indah Permata Sari', 'Perempuan', 'tkj', '1'),
('161710304', 'Julianti', 'Perempuan', 'tkj', '1'),
('161710306', 'Kameliyah Sari', 'Perempuan', 'tkr', '2'),
('161710308', 'Kasfaroh', 'Perempuan', 'tb', '3'),
('161710309', 'Khaerul Adnan', 'Laki-laki', 'tb', '3'),
('161710311', 'Krisna Dewi', 'Perempuan', 'toi', '4'),
('161710312', 'Kusniawati', 'Perempuan', 'toi', '4'),
('161710313', 'Kuspita', 'Perempuan', 'toi', '4'),
('161710314', 'Kuswati', 'Perempuan', 'tkj', '1'),
('161710315', 'Liana Rachmawati', 'Perempuan', 'tkj', '1'),
('161710316', 'M. Asrof', 'Laki-laki', 'tkj', '1'),
('161710317', 'Madu Lestari', 'Perempuan', 'tkj', '1'),
('161710318', 'Maryam', 'Perempuan', 'tkj', '1'),
('161710319', 'Miftahuddin Fikri', 'Laki-laki', 'tkj', '1'),
('161710321', 'Mochamad Rizky Alfar', 'Laki-laki', 'tkr', '2'),
('161710322', 'Mohammad Afnan', 'Laki-laki', 'tkr', '2'),
('161710323', 'Muhamad Dimas Syihab', 'Laki-laki', 'tb', '3'),
('161710324', 'Muhammad Rifky Alfar', 'Laki-laki', 'tb', '3'),
('161710325', 'Munir Huda', 'Laki-laki', 'toi', '4'),
('161710326', 'Naufal Anugrah Allam', 'Laki-laki', 'toi', '4'),
('161710327', 'Niken Septyani Raiha', 'Perempuan', 'toi', '4'),
('161710328', 'Nina Rosanti', 'Perempuan', 'toi', '4'),
('161710329', 'Nindika Ayu Fadhilla', 'Perempuan', 'tkj', '1'),
('161710330', 'Nining Dianti', 'Perempuan', 'tkj', '1'),
('161710331', 'Nova', 'Perempuan', 'tkj', '1'),
('161710332', 'Novi Aprilianti', 'Perempuan', 'tkr', '2'),
('161710334', 'Nur Anita', 'Perempuan', 'tkr', '2'),
('161710335', 'Nurcahyati Ramayani', 'Perempuan', 'tb', '3'),
('161710336', 'Nurhikmawanti', 'Perempuan', 'tb', '3'),
('161710337', 'Pipit Puji Arti', 'Perempuan', 'tb', '3'),
('161710338', 'Putri Septi Hardiyan', 'Perempuan', 'tb', '3'),
('161710339', 'Rafi Zainul Arifin', 'Laki-laki', 'toi', '4'),
('161710340', 'Rini Kesari', 'Perempuan', 'toi', '4'),
('161710342', 'Rizki Indrajaya', 'Laki-laki', 'tkj', '1'),
('161710343', 'Robin Yansen', 'Laki-laki', 'tkj', '1'),
('161710345', 'Roni Herjandi', 'Laki-laki', 'tkr', '2'),
('161710346', 'Rosi Setiyani', 'Perempuan', 'tkr', '2'),
('161710347', 'Rudi Hidayat', 'Laki-laki', 'tb', '3'),
('161710349', 'Saputri', 'Perempuan', 'tb', '3'),
('161710351', 'Sartika Dewi', 'Perempuan', 'toi', '4'),
('161710352', 'Selly Agustin', 'Perempuan', 'toi', '4'),
('161710353', 'Shendy Varsellino', 'Laki-laki', 'toi', '4'),
('161710354', 'Siska Lutviana', 'Perempuan', 'toi', '4'),
('161710355', 'Siti Alizah', 'Perempuan', 'tkj', '1'),
('161710356', 'Siti Meliawati', 'Perempuan', 'tkj', '1'),
('161710357', 'Sobirun', 'Laki-laki', 'tkj', '1'),
('161710358', 'Sri Ayu', 'Perempuan', 'toi', '4'),
('161710359', 'Sri Rahayu Wulandari', 'Perempuan', 'tkr', '2'),
('161710360', 'Sri Wahyuni', 'Perempuan', 'tkr', '2'),
('161710361', 'Suci Amaliyah', 'Perempuan', 'tkr', '2'),
('161710363', 'Sunenti', 'Perempuan', 'tkj', '1'),
('161710364', 'Taofik Safrudin', 'Laki-laki', 'tkr', '2'),
('161710366', 'Tarjuki', 'Laki-laki', 'tkj', '1'),
('161710367', 'Tarmana', 'Laki-laki', 'tb', '3'),
('161710368', 'Tati Indrawati', 'Perempuan', 'tb', '3'),
('161710369', 'Teguh Firmansyah', 'Laki-laki', 'tb', '3'),
('161710370', 'Tiwi Adriyanti', 'Perempuan', 'toi', '4'),
('161710371', 'Toni Hapidin', 'Laki-laki', 'tkj', '1'),
('161710372', 'Trisna Novia', 'Perempuan', 'toi', '4'),
('161710375', 'Vina Melistia', 'Perempuan', 'tkj', '1'),
('161710376', 'Wahyudin', 'Perempuan', 'tkj', '1'),
('161710377', 'Wahyuni', 'Perempuan', 'tb', '3'),
('161710378', 'Wantinih', 'Perempuan', 'tkr', '2'),
('161710379', 'Warsinih', 'Perempuan', 'tkr', '2'),
('161710381', 'Wina Yulita', 'Perempuan', 'tkr', '2'),
('161710382', 'Winday Nuh Sahfitri', 'Perempuan', 'tkr', '2'),
('161710383', 'Windi Yanti', 'Perempuan', 'tb', '3'),
('161710384', 'Wiwin Widyawati', 'Perempuan', 'tb', '3'),
('161710386', 'Wulan Pebriyanti', 'Perempuan', 'toi', '4'),
('161710387', 'Yayan Rosayani', 'Perempuan', 'toi', '4'),
('161710388', 'Yesika Fitri', 'Perempuan', 'tb', '3'),
('161710389', 'Yudistira Hardiansya', 'Laki-laki', 'tb', '3'),
('161710390', 'Zafar Sidiq', 'Laki-laki', 'tkj', '1'),
('161710392', 'Ayuni Wulandari', 'Perempuan', 'tkj', '1'),
('161710393', 'Tursinah', 'Perempuan', 'tkj', '1'),
('161710479', 'Della Oktaviani', 'Perempuan', 'tb', '3'),
('171810346', 'Muhammad Aufa', 'Laki-laki', 'toi', '4');

-- --------------------------------------------------------

--
-- Table structure for table `suratizin`
--

CREATE TABLE `suratizin` (
  `nosurat` varchar(15) NOT NULL,
  `tanggal` date NOT NULL,
  `nis` varchar(10) NOT NULL,
  `waktu` varchar(15) NOT NULL,
  `keperluan` varchar(30) NOT NULL,
  `verifikasi` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `suratizin`
--

INSERT INTO `suratizin` (`nosurat`, `tanggal`, `nis`, `waktu`, `keperluan`, `verifikasi`) VALUES
('G190422075318', '2019-04-22', 'S010', 'MASUK', 'NULL', ''),
('SIK-SMKN1-002', '2019-04-09', '161710239', '6', 'izin sakit(demam)\r\n', 'SUDAH'),
('SIK-SMKN1-003', '2019-04-09', '161710330', '4', 'Sakit', 'SUDAH');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `absen`
--
ALTER TABLE `absen`
  ADD PRIMARY KEY (`idabsen`);

--
-- Indexes for table `absenguru`
--
ALTER TABLE `absenguru`
  ADD PRIMARY KEY (`idabsenguru`);

--
-- Indexes for table `guru`
--
ALTER TABLE `guru`
  ADD UNIQUE KEY `idguru` (`idguru`);

--
-- Indexes for table `jadwal`
--
ALTER TABLE `jadwal`
  ADD PRIMARY KEY (`idjadwal`);

--
-- Indexes for table `jurusan`
--
ALTER TABLE `jurusan`
  ADD PRIMARY KEY (`idjurusan`);

--
-- Indexes for table `kelas`
--
ALTER TABLE `kelas`
  ADD PRIMARY KEY (`idkelas`);

--
-- Indexes for table `mapel`
--
ALTER TABLE `mapel`
  ADD PRIMARY KEY (`idmapel`);

--
-- Indexes for table `monitoring`
--
ALTER TABLE `monitoring`
  ADD PRIMARY KEY (`idmonitoring`);

--
-- Indexes for table `siswa`
--
ALTER TABLE `siswa`
  ADD PRIMARY KEY (`nis`);

--
-- Indexes for table `suratizin`
--
ALTER TABLE `suratizin`
  ADD PRIMARY KEY (`nosurat`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
