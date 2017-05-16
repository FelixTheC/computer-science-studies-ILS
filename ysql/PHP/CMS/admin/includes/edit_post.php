<?php
        //post bearbeiten
        
    if(isset($_POST['edit_post'])){
        
        $e_author = $_POST['author'];
        $e_title = $_POST['title'];
        $e_category_id = $_POST['categorys'];
        $e_status = $_POST['post_status'];
        $e_image = $_FILES['imgFile']['name'];
        $e_image_temp = $_FILES['imgFile']['tmp_name'];
        $e_tags = $_POST['tags'];
        $e_content = $_POST['content'];
        
        move_uploaded_file($e_image_temp, "../images/$e_image");
        
        $query = "UPDATE posts SET ";
        $query .="post_category_id = '{$e_category_id}', ";
        $query .="post_title = '{$e_title}', ";
        $query .="post_date = now(), ";
        $query .="post_author = '{$e_author}', ";
        $query .="post_status = '{$e_status}', ";
        $query .="post_tags = '{$e_tags}', ";
        $query .="post_content = '{$e_content}', ";
        $query .="post_image = '{$e_image}' ";
        $query .="WHERE post_id = {$id}";
   
        $update_post = mysqli_query($mysqli, $query);
        
        $refresh = "<meta http-equiv='refresh' content='1; URL=http://localhost/ysql/PHP/CMS/admin/allPosts.php'>";
    
        echo $refresh;
        
        }
        
             
?>