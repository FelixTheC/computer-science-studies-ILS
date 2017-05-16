<!DOCTYPE html>
<html>
<head>
	<meta charset = "UTF-8" />
	<title>Eingabe mit INSERT</title>
</head>
<body>

<form action="" method="post">
	<fieldset>
	<legend>Teilnehmer erfassen</legend>
	<ul>
		<li>
			<label for="tnummer">Teilnehmernummer:</label>
			<input type="text" name="tnummer" id="tnummer" value="Auto" disabled />
		</li>
		<li>
			<label for="name">Name:</label>
			<input type="text" name="name" id="name" />
		</li>
		<li>
			<label for="vname">Vorname:</label>
			<input type="text" name="vname" id="vname" />
		</li>
		<li>
			<label for="plz">Postleitzahl:</label>
			<input type="text" name="plz" id="plz" />
		</li>
		<li>
			<label for="ort">Ort:</label>
			<input type="text" name="ort" id="ort" />
		</li>
		<li>
			<label for="strasse">Strasse:</label>
			<input type="text" name="strasse" id="strasse" />
		</li>
		<li>
			<label for="hausnr">Hausnummer:</label>
			<input type="text" name="hausnr" id="hausnr" />
		</li>
		<li>
			<label for="telefon1">Telefon1:</label>
			<input type="text" name="telefon1" id="telefon1" />
		</li>
		<li>
			<label for="telefon2">Telefon2:</label>
			<input type="text" name="telefon2" id="telefon2" />
		</li>
		<li>
			<label for="email">Email:</label>
			<input type="text" name="email" id="email" />
		</li>
	</ul>
		<p>
		<input type="submit"
				value="Teilnehmer speichern" /><br />
		<input type="reset"
				value="Formular zurücksetzen" /><br />
	</fieldset>
</form>

<?php
if(isset($_POST["name"])){
	$tnummer = NULL;
	$name = $_POST["name"];
	$vname = $_POST["vname"];
	$plz = $_POST["plz"];
	$ort = $_POST["ort"];
	$strasse = $_POST["strasse"];
	$hausnr = $_POST["hausnr"];
	$telefon1 = $_POST["telefon1"];
	$telefon2 = $_POST["telefon2"];
	$email = $_POST["email"];
	
	$mysqli = new mysqli("localhost", "root", "walle", "kursverwaltung");
	
	if($mysqli->connect_error){
		echo "Verbindungsfehler" . $mysqli->connect_error;
		exit();
	}
	if($mysqli->set_charset("utf8")){
		echo "Fehler beim Laden von UTF8" . $mysqli->error;
	}
	
	$sql = "INSERT INTO teilnehmer (tnummer, name, vname, plz, ort, strasse, hausnr, telefon1, telefon2, email) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
	
	if($stmt = $mysqli -> prepare($sql)){
		$stmt->bind_param('isssssssss', $tnummer, $name, $vname, $plz, $ort, $strasse, $hausnr, $telefon1, $telefon2, $email);
		
		if($stmt -> execute()) {
			echo "<h2>Datensatz erfolgreich gespeichert! </h2>\n";
		}
			else {
				echo "<h2>Fehler beim Speichern des Datensatzes </h2>\n";
			}
			
	$stmt->close();
	}
	$mysqli->close();
}
?>	
</body>
</html>