<?php include("includes/init.php"); ?>

<?php

if ($session->is_signed_in()){ redirect("index.php"); }

    if(isset($_POST['submit'])){
    
        $username = trim($_POST['username']);
        $password = trim($_POST['password']);

        $user_found = User::verify_user($username, $password);
    
    if($user_found){
    
        $session->login($user_found);
        redirect("index.php");
    
    }else{
    
        $the_msg = "Your password or username are not correct"; 
    
    }
    
    }else{

    $the_msg="";
    $username="";
    $password="";
    
    }

if(isset($_POST['back'])){
    
        $session->logout();
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
                            Login
                        </h1>
                            <h2 class="bg-danger"><?php echo $the_msg; ?> </h2>
                            <form action="" method="post">
                            <div class="form-group">
                                <label for="username">Username:</label>
                                <input name="username" type="text" class="form-control" value="<?php echo htmlentities($username) ?>">
                            </div>
                            <br>
                            <div class="form-group">
                                <label for="password">Password:</label>
                                <input type="password" name="password" class="form-control" value="<?php echo htmlentities($password) ?>">        
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