<?php
//connect to MYSQL
$mysqli = mysqli_connect("localhost", "root", "walle", "msgr");
	if($mysqli->connect_error){
		echo "Fehler beim Verbindungsaufbau" .$mysqli->connect_error;
		exit();
	}

?>