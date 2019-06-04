<?php session_start();
if (isset($_SESSION['username'])) {
 include '../koneksi.php';
 $db = new database();
 ?>
<html>
<head>
<title>SIMOKBM - MENU</title>
<meta charset="utf-8" />
<meta name="viewport" content="width=device-width, initial-scale=1, user-scalable=no" />
<link rel="shortcut icon" href="images/logokbm.png">
<link rel="stylesheet" href="assets/css/main.css" />
<noscript><link rel="stylesheet" href="assets/css/noscript.css" /></noscript>
<link rel="shortcut icon" href="images/logokbm.png">
</head>

<body class="is-preload">
<div id="wrapper">
 <div id="bg"></div>
 <div id="overlay"></div>
 <div id="main">

	 <!-- Header -->
		 <header id="header">
			 <h1>Selamat Datang <?php echo $_SESSION['nama']; ?>!</h1><br>
			 <h2>Masuk Sebagai :</h2>
			 <nav>
				 <ul>
						<?php
						if (isset($_SESSION['jabatan2']))
						{
						// jika jenis admin
							if (($_SESSION['jabatan2'] == "Admin") and ($_SESSION['jabatan1'] == ""))
							{ ?>
								  <li><a href="../admin/index.php" class="icon fa-users">Admin</a></li>
							<?php }
						// jika kondisi jenis user maka akan diarahkan ke halaman lain
							else if (($_SESSION['jabatan2'] == "Guru Piket") and ($_SESSION['jabatan1'] == "Guru Mapel"))
							{?>
						  <li><a href="../gurupiket/index.php" class="icon fa-copy">Guru Piket</a></li>
              <li><a href="../gurumapel/index.php" class="icon fa-users">Guru Mapel</a></li>
            <?php }
						 else if (($_SESSION['jabatan2'] == "Wakakur") and ($_SESSION['jabatan1'] == "Guru Mapel"))
						 {  ?>
							<li><a href="../wakakur/index.php" class="icon fa-copy">Wakakur</a></li>
              <li><a href="../gurumapel/index.php" class="icon fa-users">Guru Mapel</a></li>
            <?php }
             else if (($_SESSION['jabatan2'] == "") and ($_SESSION['jabatan1'] == "Guru Mapel"))
             {  ?>
              <li><a href="../gurumapel/index.php" class="icon fa-users">Guru Mapel</a></li>
						<?php }
            else if (($_SESSION['jabatan2'] == "Admin") and ($_SESSION['jabatan1'] == "Guru Mapel"))
            {  ?>
              <li><a href="../admin/index.php" class="icon fa-users">Admin</a></li>
              <li><a href="../gurumapel/index.php" class="icon fa-users">Guru Mapel</a></li>
           <?php } ?>
        <?php } ?>
        <li><a href="#" class="icon fa-unlock">Reset Password</a></li>
        <li><a href="../logout.php" class="icon fa-power-off">Keluar</a></li>
       </ul>
			 </nav>
		 </header>


	 <!-- Footer -->
		 <footer id="footer">
			 <span class="copyright">&copy; Copyright By: Agung Subagja</span>
		 </footer>

 </div>
</div>

<script type="text/javascript">
$(document).ready(function(){
	 $(".tip-bottom").tooltip({
			 placement : 'bottom'
	 });
});
</script>

<script>
 window.onload = function() { document.body.classList.remove('is-preload'); }
 window.ontouchmove = function() { return false; }
 window.onorientationchange = function() { document.body.scrollTop = 0; }
</script>
</body>
</script>
<script src="js/SmoothScroll.min.js"></script>
<!-- //smooth-scrolling-of-move-up -->
<!-- Bootstrap core JavaScript
 ================================================== -->
 <!-- Placed at the end of the document so the pages load faster -->
 <script src="js/bootstrap.js"></script>
</body>

</html>

<?php
}
else{
header('location:../index.php');
}
?>
