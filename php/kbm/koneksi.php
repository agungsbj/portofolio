<?php

class database{

	var $host = "localhost";
	var $uname = "root";
	var $pass = "";
	var $db = "kbm";

	function __construct(){
		mysql_connect($this->host, $this->uname, $this->pass);
		mysql_select_db($this->db) or die("Database Tidak Ada. ".mysql_error());
	}

	function inputsiswa($nis, $nama, $jk, $idjurusan, $idkelas){
		mysql_query("insert into siswa values('$nis','$nama','$jk','$idjurusan','$idkelas')");
		}

	function hapussiswa($nis){
		mysql_query("delete from siswa where  nis='$nis'");
	}

	function editsiswa($nis){
		$data = mysql_query("select * from siswa where nis='$nis'");
		while($d = mysql_fetch_array($data)){
			$hasil[] = $d;
		}
		return $hasil;
	}

	function updatesiswa($nis, $nama, $jk, $idjurusan, $idkelas){
		mysql_query("update siswa set nis='$nis', nama='$nama', jk='$jk', idjurusan='$idjurusan', idkelas='$idkelas' where nis='$nis'");
	}

	function inputjurusan($idjurusan,$jurusan){
		mysql_query("insert into jurusan values('$idjurusan','$jurusan')");
	}

	function hapusjurusan($idjurusan){
		mysql_query("delete from jurusan where idjurusan='$idjurusan'");
	}

	function editjurusan($idjurusan){
		$data = mysql_query("select * from jurusan where idjurusan='$idjurusan'");
		while($d = mysql_fetch_array($data)){
			$hasil[] = $d;
		}
		return $hasil;
	}

	function updatejurusan($idjurusan,$jurusan){
		mysql_query("update jurusan set jurusan='$jurusan' where idjurusan='$idjurusan'");
	}

	function inputkelas($idkelas,$idjurusan,$kelas,$username, $password){
		mysql_query("insert into kelas values('$idkelas','$idjurusan','$kelas','$username','$password')");
	}

	function hapuskelas($idkelas){
		mysql_query("delete from kelas where idkelas='$idkelas'");
	}

	function editkelas($idkelas){
		$data = mysql_query("select * from kelas where idkelas='$idkelas'");
		while($d = mysql_fetch_array($data)){
			$hasil[] = $d;
		}
		return $hasil;
	}

	function updatekelas($idkelas,$idjurusan,$kelas,$username, $password){
		mysql_query("update kelas set idjurusan='$idjurusan', kelas='$kelas', username='$username', password='$password' where idkelas='$idkelas'");
	}

	function inputguru($idguru, $nama, $jk, $alamat, $username, $password, $jabatan1, $jabatan2){
		mysql_query("insert into guru values('$idguru','$nama','$jk','$alamat','$username','$password','$jabatan1','$jabatan2')");
	}

	function hapusguru($idguru){
		mysql_query("delete from guru where idguru='$idguru'");
	}

	function editguru($idguru){
		$data = mysql_query("select * from guru where idguru='$idguru'");
		while($d = mysql_fetch_array($data)){
			$hasil[] = $d;
		}
		return $hasil;
	}

	function updateguru($idguru, $nama, $jk, $alamat, $username, $password, $jabatan1, $jabatan2){
		mysql_query("update guru set idguru='$idguru', nama='$nama', jk='$jk', alamat='$alamat', username='$username', password='$password', jabatan1='$jabatan1' , jabatan2='$jabatan2' where idguru='$idguru'");
	}

	function inputmapel($idmapel, $mapel, $jam){
		mysql_query("insert into mapel values('$idmapel','$mapel','$jam')");
	}

	function hapusmapel($idmapel){
		mysql_query("delete from mapel where idmapel='$idmapel'");
	}

	function editmapel($idmapel){
		$data = mysql_query("select * from mapel where idmapel='$idmapel'");
		while($d = mysql_fetch_array($data)){
			$hasil[] = $d;
		}
		return $hasil;
	}
	function updatemapel($idmapel, $mapel, $jam){
		mysql_query("update mapel set idmapel='$idmapel', mapel='$mapel', jam='$jam' where idmapel='$idmapel'");
	}
	function inputjadwal($idjadwal, $hari, $jamawal, $jamakhir, $idmapel, $idkelas, $idguru){
		mysql_query("insert into jadwal values('$idjadwal','$hari', '$jamawal', '$jamakhir', '$idmapel', '$idkelas', '$idguru')");
	}

	function hapusjadwal($idjadwal){
		mysql_query("delete from jadwal where idjadwal='$idjadwal'");
	}

	function editjadwal($idjadwal){
		$data = mysql_query("select * from jadwal where idjadwal='$idjadwal'");
		while($d = mysql_fetch_array($data)){
			$hasil[] = $d;
		}
		return $hasil;
	}
	function updatejadwal($idjadwal, $hari, $jamawal, $jamakhir, $idmapel, $idkelas, $idguru){
		mysql_query("update jadwal set idjadwal='$idjadwal', hari='$hari', jamawal='$jamawal', jamakhir='$jamakhir', idmapel='$idmapel', idkelas='$idkelas', idguru='$idguru' where idjadwal='$idjadwal'");
	}

	function inputabsen($idabsen, $tanggal, $nis, $ket, $status){
		mysql_query("insert into absen values('$idabsen','$tanggal','$nis','$ket','$status')");
	}
	function hapusabsen($idabsen){
		mysql_query("delete from absen where idabsen='$idabsen'");
	}

	function editabsen($idabsen){
		$data = mysql_query("select * from absen where idabsen='$idabsen'");
		while($d = mysql_fetch_array($data)){
			$hasil[] = $d;
		}
		return $hasil;
	}
	function updateabsen($idabsen, $tanggal, $nis, $ket, $status){
		mysql_query("update absen set idabsen='$idabsen', tanggal='$tanggal', nis='$nis', ket='$ket', status='$status' where idabsen='$idabsen'");
	}

	function inputsuratizin($nosurat, $tanggal, $nis, $waktu, $keperluan, $verifikasi){
		mysql_query("insert into suratizin values('$nosurat','$tanggal','$nis','$waktu','$keperluan','$verifikasi')");
	}
	function hapussuratizin($nosurat){
		mysql_query("delete from suratizin where nosurat='$nosurat'");
	}

	function editsuratizin($nosurat){
		$data = mysql_query("select * from suratizin where nosurat='$nosurat'");
		while($d = mysql_fetch_array($data)){
			$hasil[] = $d;
		}
		return $hasil;
	}
	function updatesuratizin($nosurat, $tanggal, $nis, $waktu, $keperluan, $verifikasi){
		mysql_query("update suratizin set nosurat='$nosurat', tanggal='$tanggal', nis='$nis', waktu='$waktu', keperluan='$keperluan', verifikasi='$verifikasi' where nosurat='$nosurat'");
	}

	function inputabsenguru($idabsenguru, $tanggal, $idguru, $masuk, $pulang , $ket){
	  mysql_query("insert into absenguru values('$idabsenguru','$tanggal','$idguru','$masuk','$pulang','$ket')");
	}

	function editabsenguru($idabsenguru){
	  $data = mysql_query("select * from absenguru where idabsenguru='$idabsenguru'");
	  while($d = mysql_fetch_array($data)){
	    $hasil[] = $d;
	  }
	  return $hasil;
	}

	function updateabsenguru($idabsenguru, $tanggal, $idguru, $masuk, $pulang ,$ket){
	  mysql_query("update absenguru set idabsenguru='$idabsenguru', tanggal='$tanggal', idguru='$idguru', masuk='$masuk', pulang='$pulang', ket='$ket' where idabsenguru='$idabsenguru'");
	}

	function inputmonitoring($idmonitoring, $tanggal, $idjadwal, $statuskbmguru, $statuskbmsiswa, $ket, $gurupiket){
		mysql_query("insert into monitoring values('$idmonitoring','$tanggal','$idjadwal','$statuskbmguru','$statuskbmsiswa','$ket','$gurupiket')");
	}

	function hapusmonitoring($idmonitoring){
		mysql_query("delete from monitoring where idmonitoring='$idmonitoring'");
	}

	function editmonitoring($idmonitoring){
		$data = mysql_query("select * from monitoring where idmonitoring='$idmonitoring'");
		while($d = mysql_fetch_array($data)){
			$hasil[] = $d;
		}
		return $hasil;
	}
	function updatemonitoring($idmonitoring, $tanggal, $idjadwal, $statuskbmguru, $statuskbmsiswa, $ket, $gurupiket){
		mysql_query("update monitoring set idmonitoring='$idmonitoring', tanggal='$tanggal', idjadwal='$idjadwal', statuskbmguru='$statuskbmguru', statuskbmsiswa='$statuskbmsiswa', ket='$ket', gurupiket='$gurupiket' where idmonitoring='$idmonitoring'");
	}

	function inputjadwalgp($idjadwalgp, $idguru, $hari){
		mysql_query("insert into jadwalgp values('$idjadwalgp','$idguru','$hari')");
	}
	function hapusjadwalgp($idjadwalgp){
		mysql_query("delete from jadwalgp where idjadwalgp='$idjadwalgp'");
	}
	function editjadwalgp($idjadwalgp){
		$data = mysql_query("select * from jadwalgp where idjadwalgp='$idjadwalgp'");
		while($d = mysql_fetch_array($data)){
			$hasil[] = $d;
		}
		return $hasil;
	}
	function updatejadwalgp($idjadwalgp, $idguru, $hari){
		mysql_query("update jadwalgp set idjadwalgp='$idjadwalgp', idguru='$idguru', hari='$hari' where idjadwalgp='$idjadwalgp'");
	}

}
?>
