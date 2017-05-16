<!DOCTYPE html>
<html>
<head>
	<meta charset="UTF-8" />
	<title>Artikel ausgeben</title>
</head>
<body>
<?php
	$data = array();
	
	require("artikel_db.inc.php");
	
	if($stmt = $mysqli -> prepare("SELECT anr, gnr, name, preis FROM artikel")) {
		$stmt -> bind_result($anr, $gnr, $name, $preis);
		echo "<table>";
		echo "<thead>
		 <tr>
			<th>Artikelnummer\t\t</th><th>Gruppennummer\t\t</th><th>Name\t\t</th><th>Preis</th>\n
		 </tr>
		</thead>";
		$stmt -> execute();
		$stmt -> fetch();
		while ($stmt -> fetch()){
		echo "
					<tr>
					<td>$anr</td>\n\t
					<td>$gnr</td>\n\t
					<td>$name</td>\n\t
					<td>$preis</td>\n\t</tr>";								
		}
		echo "</table>";
		$stmt->close();
	}
	$mysqli->close();
?>
</body>
</html>
	
	