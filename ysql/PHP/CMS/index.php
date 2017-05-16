<?php include("includes/db.php"); ?>
<?php session_start(); ?>
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
              
                $query = "SELECT * FROM posts";
                
                 $select_all_posts_query = mysqli_query($mysqli, $query);
                        
                    //zugriff auf die einzelnen Zeilen ohne while schleife würde man
                    //immer das letzte element auswählen
                    while($row = mysqli_fetch_assoc($select_all_posts_query)){
                        //um nur eine spezielle spalte auszuwählen gut ist wenn man die Variable
                        //die man erstellt genauso benennt wie die spalte
                        $post_id = $row['post_id'];
                        $post_title = $row['post_title'];
                        $post_author = $row['post_author'];
                        $post_date = $row['post_date'];
                        $post_image = $row['post_image'];
                        $post_content = substr($row['post_content'],0,50);
                        
                //php hier unterbrechen aber darauf achten das der while-loop noch nicht //geschlossen wird. Das passiert weiter unten    
                        ?>
               

                <!-- First Blog Post -->
                <h2>
                    <a href="post.php?p_id=<?php echo $post_id; ?>"><?php echo $post_title; ?></a>
                </h2>
                <p class="lead">
                    by <a href="index.php"><?php echo $post_author; ?></a>
                </p>
                <p><span class="glyphicon glyphicon-time"></span> Posted <?php echo $post_date; ?></p>
                <hr>
                <a href="post.php?p_id=<?php echo $post_id; ?>">
                <img class="img-responsive" src="images/<?php echo $post_image; ?>" alt="">
                </a>
                <hr>
                <p><?php echo $post_content; ?></p>
                <a class="btn btn-primary" href="post.php?p_id=<?php echo $post_id; ?>">Read More <span class="glyphicon glyphicon-chevron-right"></span></a>
                
                
                <?php
                //hier wird jetzt der while-loop geschlossen
                    }
                ?>


            </div>

            <!-- Blog Sidebar Widgets Column -->
           <?php include("includes/sidebar.php"); ?>

        </div>
        <!-- /.row -->

        <hr>

<?php include("includes/footer.php"); ?>