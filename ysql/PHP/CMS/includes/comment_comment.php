 <div class="media">
                <?php
                  
                    if(isset($_GET['p_id'])){
                        $id = $_GET['p_id'];
                        
                    }
                    
                    $query = "SELECT * FROM comments WHERE comment_post_id = $id";
                    $comments = mysqli_query($mysqli, $query);
                    
                    while($row = mysqli_fetch_assoc($comments)){
                        $comment_author = $row['comment_author'];
                        $comment_content = $row['comment_content'];
                        $comment_date = $row['comment_date'];
                        $comment_email = $row['comment_email'];
                   
                ?>
                    <a class="pull-left" href="#">
                        <img class="media-object" src="http://placehold.it/64x64" alt="">
                    </a>
                    <div class="media-body">
                        <h4 class="media-heading"><?php echo $comment_author; ?>
                            <small><?php echo $comment_email; ?><br/><?php echo $comment_date; ?></small>
                        </h4>
                        <?php echo $comment_content; ?>
                    </div>
                    <br/>
                        <?php } ?>
                    <br />
     
                </div>
                
                