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
		$sql = "Select name AS Name, vname AS Vorname, ort AS Wohnort, email AS EMail FROM teilnehmer";
		if($ergebnis = $mysqli -> query($sql)){
				/*$allespalte = $ergebnis->fetch_fields();
				foreach($allespalte As $spalte) {
				echo "name :". $spalte->name ."<br />\n";
				echo "orgname :". $spalte->orgname ."<br />\n";
				echo "table :". $spalte->table ."<br />\n";
				echo "orgtable :". $spalte->orgtable ."<br />\n";
				echo "db :". $spalte->db ."<br />\n";
				echo "max_length :". $spalte->max_length ."<br />\n";
				echo "length :". $spalte->length ."<br />\n";
				echo "type :". $spalte->type ."<br />\n";
				echo "decimals :". $spalte->decimals ."<br />\n";*/
				
				//Zeilenweiser Abruf als Objekt
				while($rowObj = $ergebnis->fetch_object()){
					echo "Name: ". $rowObj->Name ."<br />\n";
					echo "Vorname: ". $rowObj->Vorname ."<br />\n";
					echo "Wohnort: ". $rowObj->Wohnort ."<br />\n";
					echo "Email: ". $rowObj->EMail ."<br />\n";
					
				echo "<hr />\n";
			}
		    	$ergebnis -> free();
		}
		$mysqli -> close();
		
		?>
	</body>
</html>	