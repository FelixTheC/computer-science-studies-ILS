<?php
         //post löschen

    if(isset($_GET['delete'])){
    $id = $_GET['delete'];
   
        $query = "DELETE FROM posts WHERE post_id = {$id}";
        $delete_query = mysqli_query($mysqli, $query);
          
     $refresh = "<meta http-equiv='refresh' content='1; URL=http://localhost/ysql/PHP/CMS/admin/allPosts.php'>";
    
    echo $refresh;
    }
?>


            