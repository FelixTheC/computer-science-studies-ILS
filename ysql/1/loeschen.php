<!DOCTYPE html>
<html>
<head>
	<meta charset = "UTF-8" />
	<title>Artikel löschen</title>
</head>
<body>

<?php
class artikel{
	public function loeschen($id){
	$mysqli = new mysqli("localhost", "root", "walle", "bestelldatenbank");
	
	if($mysqli -> connect_error) {
		echo "Fehler beim Verbindungsaufbau" . $mysqli -> connect_error;
		exit();
	}
	
	if(!$mysqli->set_charset("utf8")){
		echo "Fehler beim Laden des Zeichensatzes UTF-8" . $mysqli->error;
	}
	
	$sql = "DELETE FROM artikel WHERE anr = ?";
	if($stmt = $mysqli -> prepare($sql)){
		$stmt->bind_param('i', $anr);
		$stmt->execute();
	}
	$stmt->close();
	header("refresh:3; url=loeschen.php");
	$mysqli->close();
	}
}
?>

</body>
</html>