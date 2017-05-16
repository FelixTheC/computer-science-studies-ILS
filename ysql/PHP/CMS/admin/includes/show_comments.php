<form action="" methode="get">
<table class="table table-bordered table-hover">
    <thead>
        <tr>
            <th>comment for post</th>
            <th>id</th>
            <th>date</th>
            <th>author</th>
            <th>email</th>
            <th>content</th>
            <th>status</th>
        </tr>
    </thead>
    <tbody>
                  
            
<?php
        $query="SELECT * FROM comments";
        $show_all = mysqli_query($mysqli, $query);
        
        while($row = mysqli_fetch_assoc($show_all)){
            
            $comment_id = $row['comment_id'];
            $post_id = $row['comment_post_id'];
            $date = $row['comment_date'];
            $comment_author = $row['comment_author'];
            $comment_email = $row['comment_email'];
            $content = $row['comment_content'];
            $status = $row['comment_status'];
              
        
            $query = "SELECT * FROM posts WHERE post_id=$post_id";
            $show_post = mysqli_query($mysqli, $query);
        
        foreach ($show_post as $row) {
            $show_post = $row['post_title'];            
            
            echo"<tr>";
            echo"<td>$show_post</td>";
        } ?>
        
            <td name="com_id"><?php echo $comment_id ?></td>
            <td><?php echo $date; ?></td>
            <td><?php echo $comment_author; ?></td>
            <td><?php echo $comment_email; ?></td>
            <td><?php echo $content; ?></td>
            <td><?php echo $status; ?></td>
            <td><a href="editComment.php?edit=<?php echo $comment_id ?>">Edit</a></td>
            <td><a href="comments.php?delete=<?php echo $comment_id ?>">Delete</a></td>
            </tr>
<?php } ?>  

            
        
    </tbody>
</table>
</form>
<?php
if(isset($_GET['delete'])){
    
    $com_id = $_GET['delete'];
    
    $query="DELETE FROM comments WHERE comment_id= $com_id";
    $delet = mysqli_query($mysqli, $query);
    header('location:comments.php');
    
}
?>