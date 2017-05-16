<?php
   if(isset($_GET['edit'])){
        $user_id = $_GET['edit'];
        
        $query = "SELECT * FROM users WHERE user_id = $user_id";
        $show_user = mysqli_query($mysqli, $query);

        while($row = mysqli_fetch_assoc($show_user)){
            
            $user_id = $row['user_id'];
            $username = $row['username'];
            $user_firstname = $row['user_firstname'];
            $user_lastname = $row['user_lastname'];
            $user_email = $row['user_email'];
            $image = $row['user_image'];
            $role = $row['user_role'];
            $user_password = $row['user_password'];

?>


<form class="form-horizontal" action="" method="post" enctype="multipart/form-data">
    <div class="form-group">
        <label for="id">ID: </label>
        <input class="form-control" type="text" name="id" placeholder="<?php echo $user_id ?>" readonly>
    </div>
    <div class="form-group">
        <label for="username">Username: </label>
        <input class="form-control" type="text" name="username" placeholder="<?php echo $username ?>">
    </div>
    <div class="form-group">
        <label for="user_firstname">Firstname: </label>
        <input class="form-control" class="form-control" type="text" name="user_firstname" placeholder="<?php echo $user_firstname ?>">
    </div>
    <div class="form-group">
        <label for="user_lastname">Lastname: </label>
        <input class="form-control" class="form-control" type="text" name="user_lastname" placeholder="<?php echo $user_lastname ?>">
    </div>
    <div class="form-group">
        <label for="user_email">e-Mail: </label>
        <input class="form-control" class="form-control" type="email" name="user_email" placeholder="<?php echo $user_email ?>">
    </div>
    <div class="form-group">
        <label for="post_image">Image: </label>
        <input class="form-control" type="file" name="post_image">
    </div>
    <div class="form-group">
        <select name="user_role">
            <option value="subscriber">Select a Rolle</option>
            <option value="admin">Admin</option>
            <option value="subscriber">Subscriber</option>
        </select>    
    </div>
    <div class="form-group">
        <label for="user_pasword">Password: </label>
        <input class="form-control" name="user_password" type="password" placeholder="<?php echo $user_password ?>">
    </div>
    <div class="form-group">
        <button class="btn btn-primary" type="submit" name="update">Update User</button>
    </div>
</form>

<?php 
//Foreach-Schleife schließen
}} ?>

<?php
if(isset($_POST['update'])){
    
    $user_id = $_GET['edit'];
    $username = $_POST['username'];
    $user_firstname = $_POST['user_firstname'];
    $user_lastname = $_POST['user_lastname'];
    $user_email = $_POST['user_email'];
    
    $image = $_FILES['post_image']['name'];
    $post_image_temp = $_FILES['post_image']['tmp_name'];
    
    $role = $_POST['user_role'];
    $user_password = $_POST['user_password'];
    
    $query="UPDATE users SET username = '$username', user_firstname = '$user_firstname', user_lastname = '$user_lastname', user_email = '$user_email', user_password = '$user_password' user_role = '$role' WHERE user_id = $users_id";
    $adm = mysqli_query($mysqli, $query);
    
    $refresh = "<meta http-equiv='refresh' content='1; URL=http://localhost/ysql/PHP/CMS/admin/users.php'>";
    
    echo $refresh;
}
?>