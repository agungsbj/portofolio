<?php
include 'koneksi.php';
$db = new database();

$aksi = $_GET['aksi'];
if($aksi == "tambahsiswa"){
	$nis=$_POST['nis'];
	$cek=mysql_num_rows(mysql_query("select * from siswa where nis='$nis'"));
	if($cek==0){
	$db->inputsiswa($_POST['nis'],$_POST['nama'],$_POST['jk'],$_POST['idjurusan'],$_POST['idkelas']);
	header("location:admin/siswa.php?pesan=berhasil");
	}else {
	header("location:admin/siswa.php?pesan=gagal");
	}
}elseif($aksi == "hapussiswa"){
	$db->hapussiswa($_GET['nis']);
	header("location:admin/siswa.php?pesan=hapus");
}elseif($aksi == "updatesiswa"){
	$db->updatesiswa($_POST['nis'],$_POST['nama'],$_POST['jk'],$_POST['idjurusan'],$_POST['idkelas']);
	header("location:admin/siswa.php?pesan=edit");

}elseif($aksi == "tambahjurusan"){
	$idjurusan=$_POST['idjurusan'];
	$cek=mysql_num_rows(mysql_query("select * from jurusan where idjurusan='$idjurusan'"));
	if($cek==0){
	$db->inputjurusan($_POST['idjurusan'],$_POST['jurusan']);
	header("location:admin/pengaturan.php?pesan=berhasil");
	}else {
	header("location:admin/pengaturan.php?pesan=gagal");
	}
}elseif($aksi == "hapusjurusan"){
	$db->hapusjurusan($_GET['idjurusan']);
	header("location:admin/pengaturan.php?pesan=hapus");
}elseif($aksi == "updatejurusan"){
	$db->updatejurusan($_POST['idjurusan'],$_POST['jurusan']);
	header("location:admin/pengaturan.php?pesan=edit");

}elseif($aksi == "tambahkelas"){
	$idkelas=$_POST['idkelas'];
	$cek=mysql_num_rows(mysql_query("select * from kelas where idkelas='$idkelas'"));
	if($cek==0){
	$db->inputkelas($_POST['idkelas'],$_POST['idjurusan'],$_POST['kelas'],$_POST['username'],$_POST['password']);
	header("location:admin/pengaturan.php?pesan=berhasil");
	}else {
	header("location:admin/pengaturan.php?pesan=gagal");
	}
}elseif($aksi == "hapuskelas"){
	$db->hapuskelas($_GET['idkelas']);
	header("location:admin/pengaturan.php?pesan=hapus");
}elseif($aksi == "updatekelas"){
	$db->updatekelas($_POST['idkelas'],$_POST['idjurusan'],$_POST['kelas'],$_POST['username'],$_POST['password']);
	header("location:admin/pengaturan.php?pesan=edit");

}elseif($aksi == "tambahguru"){
	$idguru=$_POST['idguru'];
	$cek=mysql_num_rows(mysql_query("select * from guru where idguru='$idguru'"));
	if($cek==0){
	$db->inputguru($_POST['idguru'],$_POST['nama'],$_POST['jk'],$_POST['alamat'],$_POST['username'],md5($_POST['password']),$_POST['jabatan1'],$_POST['jabatan2']);
	header("location:admin/guru.php?pesan=berhasil");
	}else {
	header("location:admin/guru.php?pesan=gagal");
	}
}elseif($aksi == "hapusguru"){
	$db->hapusguru($_GET['idguru']);
	header("location:admin/guru.php?pesan=hapus");
}elseif($aksi == "updateguru"){
	$db->updateguru($_POST['idguru'],$_POST['nama'],$_POST['jk'],$_POST['alamat'],$_POST['username'],$_POST['password'],$_POST['jabatan1'],$_POST['jabatan2']);
	header("location:admin/guru.php?pesan=edit");

}elseif($aksi == "resetpassword"){
	$idguru=$_POST['idguru'];
	mysql_query("update guru set password='123456' where idguru='$idguru'");
	header("location:admin/guru.php?pesan=edit");

}elseif($aksi == "updateuser"){
	$idguru=$_POST['idguru'];
	$cekawal=mysql_query("select * from guru where idguru='$idguru'");
	$data=mysql_fetch_array($cekawal);
	if ($data["username"]==''){
		$db->updateguru($_POST['idguru'],$_POST['nama'],$_POST['jk'],$_POST['alamat'],$_POST['username'],md5($_POST['password']),$_POST['jabatan1'],$_POST['jabatan2']);
		$db->inputjadwalgp($_POST['idjadwalgp'],$_POST['idguru'],$_POST['hari']);
		header("location:admin/user.php?pesan=berhasil");
	} else {
	$lama=md5($_POST['lama']);
	$baru=$_POST['baru'];
	$ulang=$_POST['ulang'];
	$cek=mysql_query("select * from guru where password='$lama' and idguru='$idguru'");
	if(mysql_num_rows($cek)==1){
		if($baru==$ulang){
			$b = md5($baru);
			$db->updateguru($_POST['idguru'],$_POST['nama'],$_POST['jk'],$_POST['alamat'],$_POST['username'],md5($_POST['baru']),$_POST['jabatan1'],$_POST['jabatan2']);
			header("location:admin/user.php?pesan=berhasil");
		}else{
			header("location:admin/user.php?pesan=gagalbeda");
		}
	}else{header("location:admin/user.php?pesan=gagalupdate");
	}
}

}elseif($aksi == "updateuserkelas"){
	$idkelas=$_POST['idkelas'];
	$cekawal=mysql_query("select * from kelas where idkelas='$idkelas'");
	$data=mysql_fetch_array($cekawal);
	if ($data["username"]==''){
		$db->updatekelas($_POST['idkelas'],$_POST['idjurusan'],$_POST['kelas'],$_POST['username'],md5($_POST['password']));
		header("location:admin/user.php?pesan=berhasil");
	} else {
		$lama=md5($_POST['lama']);
		$baru=$_POST['baru'];
		$ulang=$_POST['ulang'];
		$cek=mysql_query("select * from kelas where password='$lama' and idkelas='$idkelas'");
		if(mysql_num_rows($cek)==1){
			if($baru==$ulang){
				$b = md5($baru);
		$db->updatekelas($_POST['idkelas'],$_POST['idjurusan'],$_POST['kelas'],$_POST['username'],md5($_POST['baru']));
		header("location:admin/user.php?pesan=berhasil");
	}else{
		header("location:admin/user.php?pesan=gagalbeda");
	}
	}else{header("location:admin/user.php?pesan=gagalupdate");
	}
}

}elseif($aksi == "tambahmapel"){
	$mapel=$_POST['mapel'];
	$cek=mysql_num_rows(mysql_query("select * from mapel where mapel='$mapel'"));
	if($cek==0){
	$db->inputmapel($_POST['idmapel'],$_POST['mapel'],$_POST['jam']);
	header("location:admin/mapel.php?pesan=berhasil");
	}else {
	header("location:admin/mapel.php?pesan=gagal");
	}
}elseif($aksi == "hapusmapel"){
	$db->hapusmapel($_GET['idmapel']);
	header("location:admin/mapel.php?pesan=hapus");
}elseif($aksi == "updatemapel"){
	$db->updatemapel($_POST['idmapel'],$_POST['mapel'],$_POST['jam']);
	header("location:admin/mapel.php?pesan=edit");

}elseif($aksi == "tambahjadwal"){
	$db->inputjadwal($_POST['idjadwal'],$_POST['hari'],$_POST['jamawal'],$_POST['jamakhir'],$_POST['idmapel'],$_POST['idkelas'],$_POST['idguru']);
	header("location:admin/jadwal.php?pesan=berhasil");
}elseif($aksi == "hapusjadwal"){
	$db->hapusjadwal($_GET['idjadwal']);
	header("location:admin/jadwal.php?pesan=hapus");
}elseif($aksi == "updatejadwal"){
	$db->updatejadwal($_POST['idjadwal'],$_POST['hari'],$_POST['jamawal'],$_POST['jamakhir'],$_POST['idmapel'],$_POST['idkelas'],$_POST['idguru']);
	header("location:admin/jadwal.php?pesan=edit");

}elseif($aksi == "tambahjadwalgp"){
	$db->inputjadwalgp($_POST['idjadwalgp'],$_POST['idguru'],$_POST['hari']);
	header("location:admin/jadwalgp.php?pesan=berhasil");
}elseif($aksi == "hapusjadwalgp"){
	$db->hapusjadwalgp($_GET['idjadwalgp']);
	header("location:admin/jadwalgp.php?pesan=hapus");
}elseif($aksi == "updatejadwalgp"){
	$db->updatejadwalgp($_POST['idjadwalgp'],$_POST['idguru'],$_POST['hari']);
	header("location:admin/jadwalgp.php?pesan=edit");

}elseif($aksi == "tambahabsen"){
	$db->inputabsen($_POST['idabsen'],$_POST['tanggal'],$_POST['nis'],$_POST['ket'],$_POST['status']);
	header("location:ketuakelas/absensi.php?pesan=berhasil");
}elseif($aksi == "hapusabsen"){
	$db->hapusabsen($_GET['idabsen']);
	header("location:ketuakelas/absensi.php?pesan=hapus");

}elseif($aksi == "tambahabsengp"){
	$db->inputabsen($_POST['idabsen'],$_POST['tanggal'],$_POST['nis'],$_POST['ket'],$_POST['status']);
	header("location:gurupiket/absensi.php?pesan=berhasil");
}elseif($aksi == "hapusabsengp"){
	$db->hapusabsen($_GET['idabsen']);
	header("location:gurupiket/absensi.php?pesan=hapus");
}elseif($aksi == "updateabsengp"){
	$db->updateabsen($_POST['idabsen'],$_POST['tanggal'],$_POST['nis'],$_POST['ket'],$_POST['status']);
	header("location:gurupiket/absensi.php?pesan=edit");

}elseif($aksi == "tambahsuratizin"){
	$db->inputsuratizin($_POST['nosurat'],$_POST['tanggal'],$_POST['nis'],$_POST['waktu'],$_POST['keperluan'],$_POST['verifikasi']);
	header("location:ketuakelas/suratizin.php?pesan=berhasil");
}elseif($aksi == "hapussuratizin"){
	$db->hapussuratizin($_GET['nosurat']);
	header("location:ketuakelas/suratizin.php?pesan=hapus");
}elseif($aksi == "updatesuratizin"){
	$db->updatesuratizin($_POST['nosurat'],$_POST['tanggal'],$_POST['nis'],$_POST['waktu'],$_POST['keperluan'],$_POST['verifikasi']);
	header("location:ketuakelas/suratizin.php?pesan=edit");

}elseif($aksi == "tambahsuratizingp"){
	$db->inputsuratizin($_POST['nosurat'],$_POST['tanggal'],$_POST['nis'],$_POST['waktu'],$_POST['keperluan'],$_POST['verifikasi']);
	header("location:gurupiket/suratizin.php?pesan=berhasil");
}elseif($aksi == "hapussuratizingp"){
	$db->hapussuratizin($_GET['nosurat']);
	header("location:gurupiket/suratizin.php?pesan=hapus");
}elseif($aksi == "updatesuratizingp"){
	$db->updatesuratizin($_POST['nosurat'],$_POST['tanggal'],$_POST['nis'],$_POST['waktu'],$_POST['keperluan'],$_POST['verifikasi']);
	$db->inputabsen($_POST['idabsen'],$_POST['tanggal'],$_POST['nis'],$_POST['ket'],$_POST['status']);
	header("location:gurupiket/suratizin.php?pesan=edit");

}elseif($aksi == "tambahabsenguru"){
	$db->inputabsenguru($_POST['idabsenguru'],$_POST['tanggal'],$_POST['idguru'],$_POST['masuk'],$_POST['pulang'],$_POST['ket']);
	header("location:gurumapel/absensi.php?pesan=berhasil");
}elseif($aksi == "updateabsenguru"){
	$db->updateabsenguru($_POST['idabsenguru'],$_POST['tanggal'],$_POST['idguru'],$_POST['masuk'],$_POST['pulang'],$_POST['ket']);
	header("location:gurumapel/absensi.php?pesan=berhasil");

}elseif($aksi == "tambahmongm"){
	$db->inputmonitoring($_POST['idmonitoring'],$_POST['tanggal'],$_POST['idjadwal'],$_POST['statuskbmguru'],$_POST['statuskbmsiswa'],$_POST['ket'],$_POST['gurupiket']);
	header("location:gurumapel/kbm.php?pesan=berhasil");
}elseif($aksi == "updatemongm"){
	$db->updatemonitoring($_POST['idmonitoring'],$_POST['tanggal'],$_POST['idjadwal'],$_POST['statuskbmguru'],$_POST['statuskbmsiswa'],$_POST['ket'],$_POST['gurupiket']);
	header("location:gurumapel/kbm.php?pesan=berhasil");

}elseif($aksi == "tambahmonkk"){
	$db->inputmonitoring($_POST['idmonitoring'],$_POST['tanggal'],$_POST['idjadwal'],$_POST['statuskbmguru'],$_POST['statuskbmsiswa'],$_POST['ket'],$_POST['gurupiket']);
	header("location:ketuakelas/kbm.php?pesan=berhasil");
}elseif($aksi == "updatemonkk"){
	$db->updatemonitoring($_POST['idmonitoring'],$_POST['tanggal'],$_POST['idjadwal'],$_POST['statuskbmguru'],$_POST['statuskbmsiswa'],$_POST['ket'],$_POST['gurupiket']);
	header("location:ketuakelas/kbm.php?pesan=berhasil");

}elseif($aksi == "updatemongp"){
	$db->updatemonitoring($_POST['idmonitoring'],$_POST['tanggal'],$_POST['idjadwal'],$_POST['statuskbmguru'],$_POST['statuskbmsiswa'],$_POST['ket'],$_POST['gurupiket']);
	header("location:gurupiket/infokbm.php?pesan=berhasil");

}
?>
