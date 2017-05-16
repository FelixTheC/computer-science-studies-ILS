<?php
    if(isset($_GET['p_id'])){
        $post_id = $_GET['p_id'];
    }
    $query = "SELECT * FROM posts WHERE post_id = $post_id";
                
    $select_all_posts_query = mysqli_query($mysqli, $query);
                        
        foreach($select_all_posts_query as $row){
            $post_title = $row['post_title'];
            $post_author = $row['post_author'];
            $post_date = $row['post_date'];
            $post_image = $row['post_image'];
            $post_content = $row['post_content'];   
        ?>
               
                <h2>
                    <a href="#"><?php echo $post_title; ?></a>
                </h2>
                <p class="lead">
                    by <a href="index.php"><?php echo $post_author; ?></a>
                </p>
                <p><span class="glyphicon glyphicon-time"></span> Posted <?php echo $post_date; ?></p>
                <hr>
                <img class="img-responsive" src="images/<?php echo $post_image; ?>" alt="">
                <hr>
                <p><?php echo $post_content; ?></p>
                
                
<?php
    }
?>