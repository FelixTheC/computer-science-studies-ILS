<form class="form-horizontal" action="" method="post" enctype="multipart/form-data">
    <div class="form-group">
        <label for="post_author">Autor: </label>
        <input class="form-control" type="text" name="post_author" placeholder="Author">
    </div>
    <div class="form-group">
        <label for="post_title">Title: </label>
        <input class="form-control" class="form-control" type="text" name="post_title" placeholder="Titel">
    </div>
    <div class="form-group">
        <label for="post_category">Category: </label>
        <select class="form-class" name="categorys" id="">
            <br />
                    <?php
                        
                        $query = "SELECT * FROM categories";
                        $show_categories = mysqli_query($mysqli, $query);
          
                        while($row = mysqli_fetch_assoc($show_categories)){
                            $cat_id = $row['cat_id'];
                            $cat_title = $row['cat_title'];
                                                        
                        echo"<option value='$cat_id'>{$cat_title}</option>";    
                        }
                    ?>                 
        </select>
    </div>
    <div class="form-group">
        <label for="post_status">Status: </label>
        <select class="form-control" name="post_status">
            <option value="draft">draft</option>
            <option value="published">published</option>
        </select>
    </div>
    <div class="form-group">
        <label for="post_image">Image: </label>
        <input class="form-control" type="file" name="post_image">
    </div>
    <div class="form-group">
        <label for="post_tags">Tags: </label>
        <input class="form-control" type="text" name="post_tags" placeholder="Tags">
    </div>
    <div class="form-group">
        <label for="content">Content: </label>
        <textarea class="form-control" name="content" rows="3"></textarea>
    </div>
    <div class="form-group">
        <button class="btn btn-primary" type="submit" name="create">Create</button>
    </div>
</form>

<?php

if(isset($_POST['create'])){
    $author = $_POST['post_author'];
    $title = $_POST['post_title'];
    $status = $_POST['post_status'];
    $category_id = $_POST['categorys'];
    
    $image = $_FILES['post_image']['name'];
    $post_image_temp = $_FILES['post_image']['tmp_name'];
    
    $tags = $_POST['post_tags'];
    $date = date('d-m-y');
    $content = $_POST['content'];
    $post_comment_count = 4;
    
        move_uploaded_file($post_image_temp, "../images/$image");
    
    
        $refresh = "<meta http-equiv='refresh' content='1; URL=http://localhost/ysql/PHP/CMS/admin/allPosts.php'>";
    
  
        $query = "INSERT INTO posts ";
        $query .="(post_category_id, post_title, post_author, ";
        $query .="post_date, post_image, post_content, post_tags, post_status)";
        $query .="VALUES (";
        $query .="$category_id,'$title','$author', now(), ";
        $query .="'$image', '$content', '$tags', '$status') ";
        
    $add_post = mysqli_query($mysqli, $query);
        if(!$add_post){
            die("SOMETHING went WRONG") .mysqli_error($mysqli);
            echo $refresh;
        }else{
            
            echo $refresh;
        }
        
    }  

?>