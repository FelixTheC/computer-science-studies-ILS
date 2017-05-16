<?php include("includes/db.php"); ?>
<?php session_start(); ?>

<?php

if(isset($_POST['login'])){
    
    $username = $_POST['name_input'];
    $passwd = $_POST['passwd'];

        $username = mysqli_real_escape_string($mysqli, $username);
        $passwd = mysqli_real_escape_string($mysqli, $passwd);
    
    $query = "SELECT * FROM users WHERE username = '$username' ";
    $login_user = mysqli_query ($mysqli, $query);
    
    if(!$login_user){
        
        die("QUERY FAILED" . mysqli_error($mysqli));
    }
    
    
    while($row = mysqli_fetch_array($login_user)){
        $nameOfUser = $row['username'];
        $user_firstname = $row['user_firstname'];
        $user_lastname = $row['user_lastname'];
        $role = $row['user_role'];
        $user_id = $row['user_id'];
        $user_email = $row['user_email'];
        $user_password = $row['user_password'];
            
            if($user_password !== $passwd){
                
                header("Location:indexFehler.php");
                                
            } else if($nameOfUser == $username && $user_password == $passwd){
                
                $_SESSION['username'] = $nameOfUser;
                $_SESSION['firstname'] = $user_firstname;
                $_SESSION['lastname'] = $user_lastname;
                $_SESSION['email'] =$user_email;
                $_SESSION['role'] = $role;
                header("Location:admin/index.php");
            }
        else {
            header("Location:index.php");
        }
    }
    
}


?>

<?php

    if(isset($_POST['logout'])){
        
        session_destroy();
        header('location:index.php');
        
    }

?>