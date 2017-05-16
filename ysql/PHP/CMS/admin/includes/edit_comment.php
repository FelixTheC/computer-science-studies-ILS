<form action="" method="post">
<table class="table table-bordered">
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
        if(isset($_GET['edit'])){
        $comnt_id = $_GET['edit'];
            
        
        $query="SELECT * FROM comments WHERE comment_id = $comnt_id ";
        $show_all = mysqli_query($mysqli, $query);
        
        foreach ($show_all as $row){
            
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
        
            <td name="cnt_id"><?php echo $comment_id ?></td>
            <td><?php echo $date; ?></td>
            <td><?php echo $comment_author; ?></td>
            <td><?php echo $comment_email; ?></td>
            <td><?php echo $content; ?></td>
            <td><select name="stat" class="form-control">
                <option >controlled</option>
                <option >uncontrolled</option>
                </select></td>
            <td><button class="btn btn-primary" name="upd">Update</button></td>
            
       
<?php }} ?>  
    </tbody>
</table>
</form>
<?php
    
        if(isset($_POST['upd'])){
                $cnt_id = $_GET['edit'];
                $con_status = $_POST['stat'];
        
                $query = "UPDATE comments SET comment_status ='{$con_status}' WHERE comment_id = '{$cnt_id}'";
        
                $com_upd = mysqli_query($mysqli, $query);
                    $refresh = "<meta http-equiv='refresh' content='1; URL=http://localhost/ysql/PHP/CMS/admin/comments.php'>";
                echo $refresh;
                
            }
?>            