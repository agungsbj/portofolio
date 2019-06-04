<?php
$server = 'localhost';
$uname = 'root';
$pass = '';
$db = 'pemilu';
$link = mysqli_connect($server,$uname,$pass,$db);
if (!$link){
    die("Koneksi Gagal!". mysqli_connect_error());
}
?>
