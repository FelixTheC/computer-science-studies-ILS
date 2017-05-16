  <table class="table table-bordered">
    <thead>
        <tr>
            <th>ID</th>
            <th>Author</th>
            <th>Title</th>
            <th>Category</th>
            <th>Status</th>
            <th>Image</th>
            <th>Tags</th>
            <th>Comments</th>
            <th>Date</th>
        </tr>
    </thead>
        <tbody>
<?php
        //alle Posts anzeigen
            
            $query = "SELECT * FROM posts";
            $show_all_posts = mysqli_query($mysqli, $query);
                            
        while($row = mysqli_fetch_assoc($show_all_posts)){
            $post_id = $row['post_id'];
            $author = $row['post_author'];
            $title = $row['post_title'];
            $category = $row['post_category_id'];
            $status = $row['post_status'];
            $tags = $row['post_tags'];
            $image = $row['post_image'];
            $comments = $row['post_comment_counts'];
            $date = $row['post_date'];                            
        
        echo"<tr>";
        echo"<td>{$post_id}</td>";
        echo"<td>{$author}</td>";
        echo"<td>{$title}</td>";
        
            $query = "SELECT * FROM categories WHERE cat_id= $category";
            $show_cat = mysqli_query($mysqli, $query);
        
        while($row = mysqli_fetch_assoc($show_cat)){
            $cat_id = $row['cat_id'];
            $show_cat_name = $row['cat_title'];
        echo"<td>{$show_cat_name}</td>";
            }      
        
        echo"<td>{$status}</td>";
        echo"<td><img width='100%' class='img-responsive' src='../images/$image' alt='image'></td>";
        echo"<td>{$tags}</td>";
        echo"<td>{$comments}</td>";
        echo"<td>{$date}</td>";
        echo "<td><a href='allPosts.php?delete={$post_id}'>Delete</a></td>";
        echo "<td><a href='editPosts.php?edit={$post_id}'>Edit</a></td>";
        echo"</tr>";
        }
?>
            <?php include("delete_post.php"); ?>                                
        </tbody>
</table>