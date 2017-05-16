<?php //Insert a new Categorie
    
    if(isset($_POST['submit'])){
    $cat_title = $_POST['cat_title'];
    
    if($cat_title == "" || empty($cat_title)){
        echo"<strong> This field should not be empty </strong>";
    } else{
    
        $query = "INSERT INTO categories(cat_title) VALUE('{$cat_title}')";
        
        $create_categorie_query = mysqli_query($mysqli, $query);
        if(!$create_categorie_query){
            
            die('QUERY FAILED').mysqli_error();
        }
    }                            
}
?>
 <?php //Show all Categories
     
    $query = "SELECT * FROM categories";
    $all_categories = mysqli_query($mysqli, $query);
                                    
    while($row = mysqli_fetch_assoc($all_categories)){
        $cat_id = $row['cat_id'];
        $cat_title = $row['cat_title'];  
                   
        echo "<tr>";
        echo "<td>{$cat_id}</td>";
        echo "<td>{$cat_title}</td>";
        echo "<td><a href='categories.php?delete={$cat_id}'>Delete</a></td>";
        echo "<td><a href='categories.php?update={$cat_id}'>Edit</a></td>";
        echo "</tr>";
}
?>
                                    
<?php //Delete Query

    if(isset($_GET['delete'])){
    $cat_id = $_GET['delete'];
   
        $query = "DELETE FROM categories WHERE cat_id = {$cat_id}";
        $delete_query = mysqli_query($mysqli, $query);
          
     $refresh = "<meta http-equiv='refresh' content='1; URL=http://localhost/ysql/PHP/CMS/admin/categories.php'>";
    
    echo $refresh;
    }
?>   
