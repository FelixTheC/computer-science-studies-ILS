<?php include "database.php"; ?>

<?php
function showData() {
	//global super wichtig damit eine Verbindung aufgebaut werden kann
	//global wird benutzt um Daten von außerhalb in die function aufzunehmen
	global $mysqli;
	//ganz wichtig um Daten aus der Datenbank abzurufen
	$query = "SELECT id FROM news";
	$result = mysqli_query($mysqli, $query);
	//########################################
	while($row = mysqli_fetch_assoc($result)){
		$id = $row['id'];
		echo "<option value='$id'>$id</option>";
	}
}
?>