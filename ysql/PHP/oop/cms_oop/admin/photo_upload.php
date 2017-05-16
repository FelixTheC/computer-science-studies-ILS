<?php include("includes/header.php"); ?>
<?php include("includes/directory.php"); ?>

<!-- Navigation -->
<?php include("includes/top_nav.php"); ?>

<!--Sidebar -->
<?php include("includes/sidebar.php"); ?>
<?php
    $message = "";
if (isset($_POST['submit'])){
    
   $photo_upload = new Photo();
    
    $photo_upload->title = $_POST['title'];
    $photo_upload->set_file($_FILES['file_upload']);
    
    if($photo_upload->save()){
        
        $message = "Your Photo was uploaded Succesfully";
    }else{
        $message = join("<br>", $photo_upload->errors);
    }
    
}

?>
        
       
        <div id="page-wrapper">

            <div class="container-fluid">

                <!-- Page Heading -->
                 <!-- /.row -->
                <div class="col-md-6 col-md-offset-3">
                <div class="form-group">
                    <h2><?php echo $message ?></h2>
                    <form action="" method="post" enctype="multipart/form-data">
                        <br>
                        <label for="title">Title:</label>
                        <input name="title" type="text" placeholder="discripe your pic in one word" class="form-control">
                        <br>
                        <input type="file" name="file_upload">
                        <br>
                        <button name="submit" class="form-control btn btn-primary">Submit</button>
                    </form>
                </div>     
                </div>
            </div>
            <!-- /.container-fluid -->

        </div>
        <!-- /#page-wrapper -->

  <?php include("includes/footer.php"); ?>