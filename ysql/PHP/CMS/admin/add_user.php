<!DOCTYPE html>
<html>
    
<?php include("includes/admin_header.php"); ?>

<body>

    <div id="wrapper">

        <!-- Navigation -->
      <?php include("includes/navigation.php"); ?>

        <div id="page-wrapper">

            <div class="container-fluid">

                <!-- Page Heading -->
                <div class="row">
                    <div class="col-lg-12">
                        <h1 class="page-header">
                            Insert new User
                            <small></small>
                        </h1>
                    </div>                    
                </div>
                <!-- /.row -->                
                <?php include("includes/add_users.php"); ?>
            </div>
            <!-- /.container-fluid -->

        </div>
        <!-- /#page-wrapper -->

    </div>
    <!-- /#wrapper -->

    <!-- jQuery -->
    <script src="js/jquery.js"></script>

    <!-- Bootstrap Core JavaScript -->
    <script src="js/bootstrap.min.js"></script>

</body>

</html>
