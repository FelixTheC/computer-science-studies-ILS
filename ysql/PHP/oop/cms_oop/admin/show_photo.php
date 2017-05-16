<?php include("includes/header.php"); ?>

<!-- Navigation -->
<?php include("includes/top_nav.php"); ?>

<!--Sidebar -->
<?php include("includes/sidebar.php"); ?>
<?php

$photos = Photo::find_all();

?>
       
        <div id="page-wrapper">

            <div class="container-fluid">

                <!-- Page Heading -->
                 <!-- /.row -->
                <div class="col-md-12">
                    <table class="table table-hover">
                        <thead>
                            <tr>
                                <th>Photo</th>
                                <th>ID</th>
                                <th>File Name</th>
                                <th>Title</th>
                                <th>Size</th>
                            </tr>  
                        </thead>
                        <tbody>
                            <?php foreach ($photos as $photo) : ?>
                            <tr>
                                <td><img src="<?php echo $photo->picture_path();  ?>" alt="">
                                <div class="picture_link">
                                
                                    <a href="delete_photo.php?id=<?php echo $photo->id; ?>">Delete</a>
                                    <a href="edit.php">Edit</a>
                                    <a href="#">View</a>
                                    
                                </div>
                                </td>
                                <td><?php echo $photo->id; ?></td>
                                <td><?php echo $photo->filename; ?></td>
                                <td><?php echo $photo->type; ?></td>
                                <td><?php echo $photo->size; ?></td>
                            </tr>
                            <?php endforeach; ?>
                        </tbody>
                    </table>
                </div>
            </div>
            <!-- /.container-fluid -->

        </div>
        <!-- /#page-wrapper -->

  <?php include("includes/footer.php"); ?>