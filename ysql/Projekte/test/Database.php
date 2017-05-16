<?php

	$mysqli = mysqli_connect("localhost", "root", "walle", "test");
	
	if(!$mysqli){
		echo "Fehler beim Herstellen einer Verbindung" . mysqli_error();
	}

?>