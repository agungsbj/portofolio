<?php
session_start();
mysql_connect("localhost","root","");
mysql_select_db("kbm");

$username = mysql_real_escape_string($_POST['username']);
$password = mysql_real_escape_string($_POST['password']);
$pas=md5($password);
// query untuk mendapatkan record dari username
$query = "SELECT * FROM guru WHERE username = '$username'";
$hasil = mysql_query($query);
$data = mysql_fetch_array($hasil);
// cek kesesuaian password
if ($pas == $data['password'])
{
    // menyimpan username dan level ke dalam session
    $_SESSION['jabatan1'] = $data['jabatan1'];
    $_SESSION['jabatan2'] = $data['jabatan2'];
    $_SESSION['username'] = $data['username'];
    $_SESSION['nama'] = $data['nama'];
    $_SESSION['idguru'] = $data['idguru'];
    header('location: login.php');
}
else
	header("location:index.php?pesan=gagal") or die (mysql_error(). mysql_errno());
?>
