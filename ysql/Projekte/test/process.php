<?php include "database.php"; ?>
<?php
//Neu Anlegen
	if(isset($_POST['submit'])){
		$user = $_POST['user'];
		$message = $_POST['message'];
		$id = $_POST['id'];
		global $mysqli;
		
		//schutz vor SQL-Injektion
		$user = mysqli_real_escape_string($mysqli, $user );
		$message = mysqli_real_escape_string($mysqli, $message );
		
		if(!$user || !$message || $user == "" || $message == ""){
			die('Bitte überprüfen Sie ihre Eingabe' . mysqli_error());
		} else {
			$sql = "INSERT INTO news(user, message)VALUES ('$user', '$message')";
		}
		if(isset($_POST['update'])){
			$user = $_POST['user'];
			$message = $_POST['message'];
			$id = $_POST['id'];
				$sql = "UPDATE news SET ";
				$sql .= "user = '$user', ";
				$sql .= "message = '$message' ";
				$sql .= "WHERE id = $id ";
		}
	$result = mysqli_query($mysqli, $sql);
	if(!$result){
		die ("Verbindung Fehlgeschlagen" . mysqli_error());
	}
	header('refresh:2; url=index.php');
}

//UPDATE
if(isset($_POST['update'])){
			$user = $_POST['user'];
			$message = $_POST['message'];
			$id = $_POST['id'];
			
			//schutz vor SQL-Injektion
			$user = mysqli_real_escape_string($mysqli, $user );
			$message = mysqli_real_escape_string($mysqli, $message );
			
				$sql = "UPDATE news SET ";
				$sql .= "user = '$user', ";
				$sql .= "message = '$message' ";
				$sql .= "WHERE id = $id ";
				
	$result = mysqli_query($mysqli, $sql);
	if(!$result){
		die ("Verbindung Fehlgeschlagen" . mysqli_error());
	}
	header('refresh:2; url=index.php');
}

//DELETE
if(isset($_POST['delete'])){
			$id = $_POST['id'];
				$sql = "DELETE FROM news WHERE id = $id ";
				
	$result = mysqli_query($mysqli, $sql);
	if(!$result){
		die ("Verbindung Fehlgeschlagen" . mysqli_error());
	}
	header('refresh:2; url=index.php');
}
?>