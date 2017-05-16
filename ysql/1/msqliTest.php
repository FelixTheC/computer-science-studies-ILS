<!DOCTYPE html>
<html>
	<head>
		<meta charset ="UTF-8" />
		<title>Query</title>
	</head>
	<body>
		
		<?php
		$data = array();
		//mysqli müssen localhost der root oder ähnliches das password des root und die Datenbank die geöffnet werden soll
		$mysqli = new mysqli("localhost", "root", "walle", "kursverwaltung");
		
			if($mysqli->connect_error){
				echo "Verbindungsfehler: " . $mysqli->connect_error;
				exit();
			}
		//Um sicherzustellen das auch der Richtige Zeichensatz geladen wird
		if(!$mysqli-> set_charset("utf8")) {
			echo "Fehler beim Laden von UFT8 " . $mysqli->error;
		}
		//wie bei mysql übergeben wir query die Dinge die wir ansehen möchten
		if($ergebnis = $mysqli -> query("SELECT * FROM teilnehmer"))
		{
			$data = $ergebnis -> fetch_all(1);
			$ergebnis -> free();
		}
		print_r($data);
		$mysqli -> close();
		
		?>
	</body>
</html>	