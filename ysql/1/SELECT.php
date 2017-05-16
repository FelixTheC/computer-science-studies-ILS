<!DOCTYPE html>
<html>
<head>
	<meta charset = "UTF-8" />
	<title>template1</title>
</head>
<body>
<?php
	$data = array();
	$mysqli = new mysqli("localhost", "root", "walle", "kursverwaltung");
	
	if($mysqli->connect_error){
		echo "Der Verbindungsaufbau schlug fehl" . $mysqli->connect_error;
		exit();
	}
	if(!$mysqli-> set_charset("utf8")){
		echo "Laden von UTF-8 fehlgeschlagen" . $mysqli->error;
	}
	
	$id = mt_rand(0, 10);
	if($stmt = $mysqli -> prepare("SELECT name, vname,
									plz, ort, strasse, hausnr, telefon1, email FROM teilnehmer WHERE tnummer = ?")) {
							
							$stmt->bind_param('i',$id);
							$stmt -> execute();
							$stmt -> bind_result($name, $vname,
									$plz, $ort, $strasse, $hausnr, $telefon1, $email);
					
							$stmt -> fetch();
							echo "Name: $name <br />
								Vorname: $vname <br />
								Ort: $ort <br />
								Email: $email<br />\n";
							$stmt -> close();
						}
			$mysqli -> close();
						
?>
</body>
</html>