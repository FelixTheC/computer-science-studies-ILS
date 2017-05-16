<?php include("includes/db.php"); ?>
<?php session_start(); ?>
<?php include('includes/header.php'); ?>


    <!-- Navigation -->
    <?php
        include('includes/nav.php');
    ?>
            <!-- /.navbar-collapse -->
        </div>
        <!-- /.container -->
    </nav>

    <!-- Page Content -->
    <div class="container">

        <div class="row">

            <!-- Blog Post Content Column -->
            <div class="col-lg-8">

                <!-- Blog Post -->

                <!-- Title -->
                
                <hr>

 <?php include("includes/post_comment.php"); ?>

               
                <!-- Blog Comments -->

                
                <!-- Comments Form -->
                <div class="well">
                    <h4>Leave a Comment:</h4>
                    <form  action="" method="post" enctype="multipart/form-data">
                        <div class="form-group">
                            <label for="author">Author:</label>
                            <input type="text" class="form-control" name="author" value="<?php if(isset($_SESSION['username'])){ echo $_SESSION['username'];}  else echo ''?>" disabled>
                            <br/>
                            <label for="email">E-Mail:</label>
                            <input type="email" class="form-control" name="email" value="<?php if(isset($_SESSION['email'])){ echo $_SESSION['email'];}  else echo ''?>" disabled>
                            <br/>
                            <textarea class="form-control" name="content"rows="3" placeholder="Plz leave a Message here"></textarea>
                        </div>
                        <?php
                        if(isset($_SESSION['username'])){
                        echo "<button class='btn btn-primary' type='submit' name='create'>Create</button>";}
                        ?>
                    </form>
                </div>
<?php
    if(isset($_POST['create'])){
        $the_post_id = $_GET['p_id'];
        $author = $_SESSION['username'];
        $email = $_SESSION['email'];
        $content = $_POST['content'];
        $status = "uncontrolled";
                
    if($author != ""){      
    $query = "INSERT INTO comments ";
    $query .="(comment_post_id, comment_date, comment_author, comment_email, comment_content,comment_status)";
    $query .="VALUES ($the_post_id, now(), '{$author}', '{$email}', '{$content}', '{$status}')";
                
    $new_comment = mysqli_query($mysqli, $query);
    }   else{
        echo "Plz Typ in Your Author-Name";
        }

    }

?>
                <hr>

                <!-- Posted Comments -->

                <!-- Comment -->
               <?php include("includes/comment_comment.php") ?>
            </div>
        
            <!-- Blog Sidebar Widgets Column -->
            
            <?php include("includes/sidebar.php"); ?>


        </div>
        <!-- /.row -->

        <hr>

        <!-- Footer -->
        <footer>
            <div class="row">
                <div class="col-lg-12">
                    <p>Copyright &copy; Your Website 2014</p>
                </div>
            </div>
            <!-- /.row -->
        </footer>

    </div>
    <!-- /.container -->

    <!-- jQuery -->
    <script src="js/jquery.js"></script>

    <!-- Bootstrap Core JavaScript -->
    <script src="js/bootstrap.min.js"></script>

</body>

</html>
