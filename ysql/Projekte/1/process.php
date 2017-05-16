<?php
include 'database.php';

//check from submit
if(isset($_POST['Submit'])){
	$user = $_POST['user'];
	$message = $_POST['message'];
		//set timezone
		ini_set('date.timezone', 'Europe/Berlin');
		$time = date('H:i:s', time());
		//verarbeite input
		if(!isset($user) || $user == (" ") || !isset($message) || $message == (" ")){
			$error = "Please check again Username and Message";
			header('Location: index.php?error='.urlencode($error));
		} else{
			$sql = "INSERT INTO posts(user, message,time) VALUES ('$user', '$message', '$time')";
			$result = mysqli_query($mysqli,$sql);
			if($result){
				header('Refresh: 1; url=index.php');
				exit();
			} else {
				die('Error: '. mysqli_error($mysqli));
				}
		}	
	}
?>