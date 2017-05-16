<?php include("includes/db.php"); ?>
<!-- Header -->
<?php include("includes/header.php"); ?>


<!-- Navigation -->
<?php include("includes/nav.php"); ?>

    <!-- Page Content -->
    <div class="container">

        <div class="row">

            <!-- Blog Entries Column -->
            <div class="col-md-8">
            <?php
              include("includes/show_diff_categorys.php"); 
            ?>

            </div>

            <!-- Blog Sidebar Widgets Column -->
           <?php include("includes/sidebar.php"); ?>

        </div>
        <!-- /.row -->

        <hr>

<?php include("includes/footer.php"); ?>