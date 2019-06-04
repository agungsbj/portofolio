<?php

//Fungsi memasukkan data pendaftaran ke database
function register_user($kecamatan, $tps, $desa, $JA, $PS){
    global $link; //Variabel Koneksi Database dijadikan Variabel Global


    //Mencegah sql_injection
    $kecamatan    = mysqli_real_escape_string($link, $kecamatan);
    $tps    = mysqli_real_escape_string($link, $tps);
    $desa    = mysqli_real_escape_string($link, $desa);
    $JA     = mysqli_real_escape_string($link, $JA);
    $PS   = mysqli_real_escape_string($link, $PS);

    $query = "INSERT INTO datamasuk (kecamatan, tps, desa, paslon_satu, paslon_dua) VALUES ('$kecamatan','$tps', '$desa','$JA','$PS')";

    if (mysqli_query($link, $query) ){
        return true;
    }else {
        return false;
    }
}


//Menguji user apakah sudah terdaftar sebelumnya, yang dijadikan penguji adalah NIM
function register_cek_tps($kecamatan, $tps, $desa) {
    global $link;
    $kecamatan       = mysqli_real_escape_string($link, $kecamatan);
    $tps       = mysqli_real_escape_string($link, $tps);
    $desa       = mysqli_real_escape_string($link, $desa);
    $query     = "SELECT * FROM datamasuk WHERE tps = '$tps' AND kecamatan = '$kecamatan' AND desa = '$desa'";
    if ($hasil = mysqli_query($link, $query) ){
        if (mysqli_num_rows($hasil) == 0) return true;
        else return false;
    }

}
?>
