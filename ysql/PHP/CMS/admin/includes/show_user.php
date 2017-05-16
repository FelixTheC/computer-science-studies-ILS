<form action="" methode="get">
<table class="table table-bordered table-hover">
    <thead>
        <tr>
            <th>id</th>
            <th>username</th>
            <th>firstname</th>
            <th>lastname</th>
            <th>email</th>
            <th>image</th>
            <th>role</th>
            <th>Admin</th>
            <th>Subscr</th>
        </tr>
    </thead>
    <tbody>
                  
            
<?php
        $query="SELECT * FROM users";
        $show_all = mysqli_query($mysqli, $query);
        
        while($row = mysqli_fetch_assoc($show_all)){
            
            $user_id = $row['user_id'];
            $username = $row['username'];
            $user_firstname = $row['user_firstname'];
            $user_lastname = $row['user_lastname'];
            $user_email = $row['user_email'];
            $image = $row['user_image'];
            $role = $row['user_role'];
        ?>      
        
            <tr>
            <td><?php echo $user_id ?></td>
            <td><?php echo $username; ?></td>
            <td><?php echo $user_firstname; ?></td>
            <td><?php echo $user_lastname; ?></td>
            <td><?php echo $user_email; ?></td>
            <td><image width="20%"class='img-responsive' src="../images/<?php echo $image; ?>"</td>
            <td><?php echo $role; ?></td>
            <td><a href="users.php?adm=<?php echo $user_id ?>" name="delete">Admin</a></td>
            <td><a href="users.php?sub=<?php echo $user_id ?>" name="delete">Subscriber</a></td>
            <td><a href="users.php?del=<?php echo $user_id ?>" name="delete">Delete</a></td>
            <td><a href="edit_user.php?edit=<?php echo $user_id ?>" name="delete">Edit</a></td>
            </tr>
<?php } ?>  

            
        
    </tbody>
</table>
</form>
<?php
if(isset($_GET['del'])){
    
    $users_id = $_GET['del'];
    
    $query="DELETE FROM users WHERE user_id= $users_id";
    $delete = mysqli_query($mysqli, $query);
    
    $refresh = "<meta http-equiv='refresh' content='1; URL=http://localhost/ysql/PHP/CMS/admin/users.php'>";
    
    echo $refresh;
}
?>
<?php
if(isset($_GET['adm'])){
    
    $users_id = $_GET['adm'];
    
    $query="UPDATE users SET user_role = 'admin' WHERE user_id = $users_id";
    $adm = mysqli_query($mysqli, $query);
    
    $refresh = "<meta http-equiv='refresh' content='1; URL=http://localhost/ysql/PHP/CMS/admin/users.php'>";
    
    echo $refresh;
}
?>
<?php
if(isset($_GET['sub'])){
    
    $users_id = $_GET['sub'];
    
    $query="UPDATE users SET user_role = 'subscriber' WHERE user_id = $users_id";
    $sub = mysqli_query($mysqli, $query);
    
    $refresh = "<meta http-equiv='refresh' content='1; URL=http://localhost/ysql/PHP/CMS/admin/users.php'>";
    
    echo $refresh;
}
?>