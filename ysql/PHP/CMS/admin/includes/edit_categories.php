<form action="" method="post">
    <div class="form-group">
        <label for="cat_title">Edit Category</label>
                                    
<?php //Edit Categorie first step       
    if(isset($_GET['update'])){
        $cat_update_id = $_GET['update'];
        $query = "SELECT * FROM categories WHERE cat_id = {$cat_update_id} ";
        $edit_query = mysqli_query($mysqli, $query);
        while($row = mysqli_fetch_assoc($edit_query)){
            $cat_id = $row['cat_id'];
            $cat_title = $row['cat_title'];
?>
            <input value="<?php if(isset($cat_title)){echo $cat_title;} ?>" class="form-control" type="text" name="edit_title"/>


<?php }} ?>

<?php //Update Query

if(isset($_POST['edit'])){
    $cat_title = $_POST['edit_title'];
   
        $query = "UPDATE categories SET cat_title = '{$cat_title}' WHERE cat_id = {$cat_id}";
        $update_query = mysqli_query($mysqli, $query);
   
    $refresh = "<meta http-equiv='refresh' content='1; URL=http://localhost/ysql/PHP/CMS/admin/categories.php'>";
    
    echo $refresh;
}
?> 
        
        