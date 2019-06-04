<?php

require_once "core/init.php";

if(isset($_GET['edit']))
{
	$SQL = mysqli_query($link,"SELECT * FROM datamasuk WHERE id=".$_GET['edit']);
	$getROW = $SQL->fetch_array();
}

if(isset($_POST['update']))
{
  $kc = strtoupper($_POST['camat']);
  $tp = $_POST['tepes'];
  $ds = strtoupper($_POST['desa']);
  $JA = $_POST['JA'];
  $PS = $_POST['PS'];
  $id = $_GET['edit'];
	 $sql = "UPDATE datamasuk SET kecamatan = '$kc', tps='$tp', desa='$ds', paslon_satu='$JA', paslon_dua='$PS' WHERE id='$id'";
  if (mysqli_query($link, $sql)) {
      echo "Record updated successfully";
      header("Location: editdata.php");
   } else {
      echo "Error updating record: " . mysqli_error($link);
   }
   mysqli_close($link);
	// header("Location: editdata2.php");
}
/* Penutup Update Data */

?>
