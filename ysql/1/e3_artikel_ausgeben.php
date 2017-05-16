<!DOCTYPE html>
<head>
	<meta charset = "UTF-8" />
	<title>Selectliste</title>

<?php
	require("artikel.class.php");
?>
</head>

<body>
		
<form action="e3_artikel_ausgeben.php" method="POST">
<label for="anr">Artikel: </label>

<?php

	require("artikel_db.inc.php");
	$sql = "SELECT anr, name FROM artikel";
	if($stmt = $mysqli -> prepare($sql)){	
		$stmt -> bind_result($anr, $name);
		$stmt->execute();
		
		echo "<select name='artikel' id='Artikel'>\n";
		$Artikel = $_POST['Artikel'];
		$selected = "selected='selected'";
		while($stmt -> fetch()){
			echo "<option '$selected' value='$anr'>$anr | $name</option>";
			if($artikel == $anr){
				echo "$selected";
		}
		}
		echo"</select>\t";
		
		}
	$stmt->close();
	$mysqli->close();
?>
<input type="submit" name="Submit"  value="Datensatz löschen" />

<?php
		if(isset($_POST["Submit"])){
		$artikel = new artikel();
		foreach ($_POST as $param_name => $param_val) {
		$artikel -> loeschen($param_val);
		}
		echo "<h2>Artikel wird gelöscht</h2>";
		header("refresh:3; url=e3_artikel_ausgeben.php");
    }
?>
	


</form>
</body>
</html>
			
	
	