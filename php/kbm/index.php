<!DOCTYPE html>
<html lang="en" data-textdirection="ltr" class="loading">
<head>
  <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <meta name="viewport" content="width=device-width, initial-scale=1.0, user-scalable=0, minimal-ui">
  <meta name="description" content="Robust admin is super flexible, powerful, clean &amp; modern responsive bootstrap 4 admin template with unlimited possibilities.">
  <meta name="keywords" content="admin template, robust admin template, dashboard template, flat admin template, responsive admin template, web app">
  <meta name="author" content="PIXINVENT">
  <title>Sistem Informasi Monitoring KBM</title>
  <meta name="apple-mobile-web-app-capable" content="yes">
  <meta name="apple-touch-fullscreen" content="yes">
  <meta name="apple-mobile-web-app-status-bar-style" content="default">
  <!-- BEGIN VENDOR CSS-->
  <link rel="stylesheet" type="text/css" href="app-assets/css/bootstrap.css">
  <link rel="shortcut icon" href="app-assets/images/logokbm.png">
  <!-- font icons-->
  <link rel="stylesheet" type="text/css" href="app-assets/fonts/icomoon.css">
  <link rel="stylesheet" type="text/css" href="app-assets/fonts/flag-icon-css/css/flag-icon.min.css">
  <link rel="stylesheet" type="text/css" href="app-assets/vendors/css/extensions/pace.css">
  <!-- END VENDOR CSS-->
  <!-- BEGIN ROBUST CSS-->
  <link rel="stylesheet" type="text/css" href="app-assets/css/bootstrap-extended.css">
  <link rel="stylesheet" type="text/css" href="app-assets/css/app.css">
  <link rel="stylesheet" type="text/css" href="app-assets/css/colors.css">
  <!-- END ROBUST CSS-->
  <!-- BEGIN Page jenis CSS-->
  <link rel="stylesheet" type="text/css" href="app-assets/css/core/menu/menu-types/vertical-menu.css">
  <link rel="stylesheet" type="text/css" href="app-assets/css/core/menu/menu-types/vertical-overlay-menu.css">
  <link rel="stylesheet" type="text/css" href="app-assets/css/pages/login-register.css">
  <!-- END Page jenis CSS-->
  <!-- BEGIN Custom CSS-->
  <link rel="stylesheet" type="text/css" href="admin/assetsadmin/css/style.css">
  <!-- END Custom CSS-->
</head>
<body data-open="click" data-menu="vertical-menu" data-col="1-column" class="vertical-layout vertical-menu 1-column  blank-page blank-page">
  <!-- ////////////////////////////////////////////////////////////////////////////-->
  <body background="assets/img/bglogin.jpg">
    <?php
    if(isset($_GET['pesan'])){
      if($_GET['pesan'] == "gagal"){
        ?>
        <div class="alert alert-danger alert-dismissible fade in" role="alert">
          <button type="button" class="close" data-dismiss="alert" aria-label="Close"><span aria-hidden="true">×</span></button>
          <strong>Username atau Password Salah!</strong> Cek Kembali username dan password anda.
        </div>
        <?php
      }
    }
    ?>
  <?php
  session_start();
  error_reporting(0);
  if (isset($_SESSION['jabatan2']))
  {
    header('location:menu/index.php');
  }
  ?>
  <br><br>
  <div class="app-content content container-fluid">
    <div class="content-wrapper">
      <div class="content-header row">
      </div>
      <div class="content-body"><section class="flexbox-container">
        <div class="col-md-4 offset-md-4 col-xs-10 offset-xs-1  box-shadow-2 p-0">
          <div class="card border-grey border-lighten-3 m-0">
            <div class="card-header no-border">
              <div class="card-title text-xs-center">
                <h1 class="warning"><span>Sistem Informasi Monitoring</span></h1>
                <h2 class="info"><span>Kegiatan Belajar Mengajar(KBM)</span></h2>
                <br>
                <img src="assets/img/logokbm.png" height="100" width="100" alt="">&nbsp;&nbsp;
                <img src="assets/img/kensasi.png" height="90" width="90" alt="">
              </div>
              <h6 class="card-subtitle line-on-side text-muted text-xs-center font-small-3 pt-2"><span>Pilih Akses</span></h6>
              <div role="tablist" aria-multiselectable="true">
                <div id="accordionWrapa1" role="tablist" aria-multiselectable="true">
                  <div class="card">
                    <div id="heading1"  class="card-header">
                      <a data-toggle="collapse" data-parent="#accordionWrapa1" href="#accordion1" aria-expanded="true" aria-controls="accordion1" class="card-title lead">
                        <h1 align="center" class="icon-group info"><font face="helvetica"> Login User</font></h1>
                      </a>
                    </div>
                    <div id="accordion1" role="tabpanel" aria-labelledby="heading1" class="card-collapse collapse" aria-expanded="true">
                      <div class="card-block">
                        <form class="form-horizontal form-simple" action="login.php" method="post" novalidate>
                          <fieldset class="form-group position-relative has-icon-left mb-0">
                            <input type="text" class="form-control form-control-lg input-lg" placeholder="masukan username" name="username" required>
                            <div class="form-control-position">
                              <i class="icon-head"></i>
                            </div>
                          </fieldset>
                          <fieldset class="form-group position-relative has-icon-left">
                            <input type="password" class="form-control form-control-lg input-lg" placeholder="masukan password" name="password" required>
                            <div class="form-control-position">
                              <i class="icon-key3"></i>
                            </div>
                          </fieldset>
                          <button type="submit" class="btn btn-info btn-lg btn-block"><i class="icon-unlock2"></i> Login</button>
                        </form>
                      </div>
                    </div>
                    <div id="heading2"  class="card-header">
                      <a data-toggle="collapse" data-parent="#accordionWrapa1" href="#accordion2" aria-expanded="false" aria-controls="accordion2" class="card-title lead collapsed">
                        <h1 align="center" class="icon-user4 warning display"><font face="helvetica"> Login Kelas</font></h1></a>
                      </div>
                      <div id="accordion2" role="tabpanel" aria-labelledby="heading2" class="card-collapse collapse" aria-expanded="false">
                        <div class="card-body">
                          <div class="card-block">
                            <form class="form-horizontal form-simple" action="loginkelas.php" method="post" novalidate>
                              <fieldset class="form-group position-relative has-icon-left mb-0">
                                <input type="text" class="form-control form-control-lg input-lg" placeholder="masukan username" name="username" required>
                                <div class="form-control-position">
                                  <i class="icon-head"></i>
                                </div>
                              </fieldset>
                              <fieldset class="form-group position-relative has-icon-left">
                                <input type="password" class="form-control form-control-lg input-lg" placeholder="masukan password" name="password" required>
                                <div class="form-control-position">
                                  <i class="icon-key3"></i>
                                </div>
                              </fieldset>
                              <button type="submit" class="btn btn-warning btn-lg btn-block"><i class="icon-unlock2"></i> Login Kelas</button>
                            </form>
                          </div>
                        </div>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </section>

      <!-- ////////////////////////////////////////////////////////////////////////////-->

      <!-- BEGIN VENDOR JS-->
      <script src="app-assets/js/core/libraries/jquery.min.js" type="text/javascript"></script>
      <script src="app-assets/vendors/js/ui/tether.min.js" type="text/javascript"></script>
      <script src="app-assets/js/core/libraries/bootstrap.min.js" type="text/javascript"></script>
      <script src="app-assets/vendors/js/ui/perfect-scrollbar.jquery.min.js" type="text/javascript"></script>
      <script src="app-assets/vendors/js/ui/unison.min.js" type="text/javascript"></script>
      <script src="app-assets/vendors/js/ui/blockUI.min.js" type="text/javascript"></script>
      <script src="app-assets/vendors/js/ui/jquery.matchHeight-min.js" type="text/javascript"></script>
      <script src="app-assets/vendors/js/ui/screenfull.min.js" type="text/javascript"></script>
      <script src="app-assets/vendors/js/extensions/pace.min.js" type="text/javascript"></script>
      <!-- BEGIN VENDOR JS-->
      <!-- BEGIN PAGE VENDOR JS-->
      <!-- END PAGE VENDOR JS-->
      <!-- BEGIN ROBUST JS-->
      <script src="app-assets/js/core/app-menu.js" type="text/javascript"></script>
      <script src="app-assets/js/core/app.js" type="text/javascript"></script>
      <!-- END ROBUST JS-->
      <!-- BEGIN PAGE jenis JS-->
      <!-- END PAGE jenis JS-->
    </body>
    </html>
