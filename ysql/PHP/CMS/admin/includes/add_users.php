<form class="form-horizontal" action="" method="post" enctype="multipart/form-data">
    <div class="form-group">
        <label for="id">ID: </label>
        <input class="form-control" type="text" name="id" readonly>
    </div>
    <div class="form-group">
        <label for="username">Username: </label>
        <input class="form-control" type="text" name="username" >
    </div>
    <div class="form-group">
        <label for="user_firstname">Firstname: </label>
        <input class="form-control" class="form-control" type="text" name="user_firstname" >
    </div>
    <div class="form-group">
        <label for="user_lastname">Lastname: </label>
        <input class="form-control" class="form-control" type="text" name="user_lastname" >
    </div>
    <div class="form-group">
        <label for="user_email">e-Mail: </label>
        <input class="form-control" class="form-control" type="email" name="user_email" >
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
        <input class="form-control" name="user_password" type="password" >
    </div>
    <div class="form-group">
        <button class="btn btn-primary" type="submit" name="create">Add User</button>
    </div>
</form>


<?php

if(isset($_POST['create'])){
    $username = $_POST['username'];
    $user_firstname = $_POST['user_firstname'];
    $user_lastname = $_POST['user_lastname'];
    $user_email = $_POST['user_email'];
    
    $image = $_FILES['post_image']['name'];
    $post_image_temp = $_FILES['post_image']['tmp_name'];
    
    $role = $_POST['user_role'];
    $user_password = $_POST['user_password'];
    
        move_uploaded_file($post_image_temp, "../images/$image");    
    
        $refresh = "<meta http-equiv='refresh' content='1; URL=http://localhost/ysql/PHP/CMS/admin/users.php'>";
    
  
        $query = "INSERT INTO users ";
        $query .="(username, user_password, user_firstname, user_lastname, ";
        $query .="user_email, user_image, user_role)";
        $query .="VALUES (";
        $query .="'$username','$user_password','$user_firstname','$user_lastname', '$user_email',";
        $query .="'$image','$role') ";
        
    $add_user = mysqli_query($mysqli, $query);
        if(!$add_user){
            die("SOMETHING went WRONG") .mysqli_error($mysqli);
            echo $refresh;
        }else{
            
            echo $refresh;
        }
        
    }  

?>