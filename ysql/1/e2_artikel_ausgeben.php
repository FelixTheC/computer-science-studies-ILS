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
	
	$sql = "SELECT anr, gruppen.gruppe, name, preis FROM artikel JOIN gruppen ON artikel.gnr = gruppen.gnr ORDER BY anr";

	if($stmt = $mysqli -> prepare($sql)) {
		$stmt -> bind_result($anr, $gruppengruppe, $name, $preis);
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
					<td>$gruppengruppe</td>\n\t
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
	
	