<?php
                        
  if(isset($_GET['edit'])){
      $id = $_GET['edit'];
      
      $query = "SELECT * FROM posts WHERE post_id = {$id}";
      $show_edit = mysqli_query($mysqli, $query);
      while($row = mysqli_fetch_assoc($show_edit)){
          $show_author = $row['post_author'];
          $show_title = $row['post_title'];
          $show_category = $row['post_category_id'];
          $show_status = $row['post_status'];
          $show_tags = $row['post_tags'];
          $show_content = $row['post_content'];
          $show_image = $row['post_image'];
          
      }}
                      
?>
    <form action="" method="post" enctype="multipart/form-data">  
        <div class="form-group"> 
            <div class="form-group">
                <label for="author">Author</label>
                <input class="form-control" type='text' name='author' value='<?php echo $show_author; ?>'>
            </div>
            <div class="form-group">
                <label for="title">Title</label>
                <input class="form-control" type='text' name='title' value='<?php echo $show_title; ?>' >
            </div>
            <div class="form-group">
                <label for="categorys">Category</label>
                <br />
                <select class="form-class" name="categorys" id="">
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
                <label for="status">Status</label>
                <select class="form-control" name="post_status">
                    <option value='draft'>draft</option>
                    <option value='published'>published</option>
                </select>
            </div>
            <div class="form-group">
                <label for="imager">Img</label>
                <img width="40%" src="../images/<?php echo $show_image; ?>">
                <input type="file" name="imgFile">
            </div>
            <div class="form-group">
                <label for="tags">Tags</label>
                <input class="form-control" type='text' name='tags' placeholder='<?php echo $show_tags; ?>'>
            </div>
            <div class="form-group">
                <label for="content">Content</label>
                <textarea class="form-control" name='content'><?php echo $show_content; ?></textarea> 
            </div>
            <div class="form-group">
                <button name="edit_post" class="btn btn-primary">Edit</button>
            </div>
        </div>
    </form>

<?php include("includes/edit_post.php"); ?>  