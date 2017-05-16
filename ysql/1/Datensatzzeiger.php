<!DOCTYPE html>
<html>
	<head>
		<meta charset ="UTF-8" />
		<title>Datensatzanzeiger</title>
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
		$sql = "Select name AS Name, vname AS Vorname, ort AS Wohnort, email AS EMail FROM teilnehmer";
		if($ergebnis = $mysqli -> query($sql)){
			$num = mt_rand(0, ($ergebnis->num_rows-1));
			if($ergebnis->data_seek($num)){
				echo "<h1>Datensatz: $num</h1>";
				if($rowObj = $ergebnis->fetch_object()){
					echo "Name: ". $rowObj->Name ."<br />\n";
					echo "Vorname: ". $rowObj->Vorname ."<br />\n";
					echo "Wohnort: ". $rowObj->Wohnort ."<br />\n";
					echo "Email: ". $rowObj->EMail ."<br />\n";
				}
				echo "<hr />\n";
			}
		    	$ergebnis -> free();
		}
		$mysqli -> close();
		
		?>
	</body>
</html>	
	