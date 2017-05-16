<!DOCTYPE html>
<html lang="en">

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
                            Welcome to categories
                            <small><?php echo $_SESSION['username']; ?></small>
                        </h1>
                        
                        <div class="col-xs-6">
                            <form action="" method="post">
                                <div class="form-group">
                                    <label for="cat_title">Add Category</label>
                                    <input class="form-control" type="text" name="cat_title"/>
                                </div>   
                                <div class="form-group">
                                    <input class="btn btn-primary" type="submit" name="submit" value="Add Category"/>
                                </div> 
                            </form>
                        
                        <?php include("includes/edit_categories.php") ?>
                                        
                                </div>   
                                <div class="form-group">
                                    <input class="btn btn-primary" type="submit" name="edit" value="Edit"/>
                                </div> 
                            </form> 
                        </div>
                        <div class="col-xs-6">
                            <table class="table table-bordered table-hover">
                                <thead>
                                    <tr>
                                        <th>ID</th>
                                        <th>Category Title</th>
                                    </tr>
                                </thead>
                                <tbody>
                              
                        <?php include("includes/functions_categories.php") ?>
                                    
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
                <!-- /.row -->

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
