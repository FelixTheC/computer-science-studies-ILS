<?php
include ("includes/init.php");


if(isset($_POST['submit'])){
    $user = new User();
    $user->username = $_POST['username'];
    $user->first_name = $_POST['firstname'];
    $user->last_name = $_POST['lastname'];
    $user->password = $_POST['password'];
    
    $user->create();
    redirect("login.php");
}

if(isset($_POST['back'])){
    
        redirect("../index.php");
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
                    <div class="col-md-4 col-md-offset-3">
                        <h1 class="header">
                            Create a new User
                        </h1>
                            <h2 class="bg-danger"><?php //echo $the_msg; ?> </h2>
                            <form action="" method="post">
                            <div class="form-group">
                                <label for="username">Username:</label>
                                <input name="username" type="text" class="form-control">
                            </div>
                            <br>
                            <div class="form-group">
                                <label for="username">Firstname:</label>
                                <input name="firstname" type="text" class="form-control">
                            </div>
                            <br>
                            <div class="form-group">
                                <label for="username">Lastname:</label>
                                <input name="lastname" type="text" class="form-control" placeholder=" ">
                            </div>
                            <br>
                            <div class="form-group">
                                <label for="password">Password:</label>
                                <input type="password" name="password" class="form-control">        
                            </div> 
                            <div class="form-group">
                                <button class="btn btn-primary" name="submit" class="form-control">Submit</button>
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