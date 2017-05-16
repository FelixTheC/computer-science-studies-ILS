<?php include("includes/init.php"); ?>

<?php
    if(isset($_POST['logout'])){
    
        $session->logout();
        redirect("../index.php");
    }
if(isset($_POST['back'])){
    
        redirect("index.php");
    }
?>
<!DOCTYPE html>
<html lang="en">

<head>

    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="description" content="">
    <meta name="author" content="">

    <title>SB Admin - Bootstrap Admin Template</title>

    <!-- Bootstrap Core CSS -->
    <link href="css/bootstrap.min.css" rel="stylesheet">

    <!-- Custom CSS -->
    <link href="css/sb-admin.css" rel="stylesheet">

    <!-- Custom Fonts -->
    <link href="font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css">
    
</head>

<body>

        <div id="page-wrapper">

            <div class="container-fluid">

                <!-- Page Heading -->
                <div class="row">
                    <div class="col-md-4 col-md-offset-4">
                        <h1 class="header">
                            Logout
                        </h1>
                            <form action="" method="post">
                            <div class="form-group">
                                <h3>Sure you wanna logout</h3>
                            <div class="form-group">
                                <button class="btn btn-warning" name="logout" class="form-control">Logout</button>
                                <button class="btn btn-primary" name="back" class="form-control">Back</button>
                            </div>
                        </form>
                    </div>                
                </div>
                <!-- /.row -->

            </div>
            <!-- /.container-fluid -->

        </div>
        <!-- /#page-wrapper -->

  <?php include("includes/footer.php"); ?>