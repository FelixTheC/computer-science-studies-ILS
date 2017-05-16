<!DOCTYPE html>
<html>
<head>
	<meta charset="UTF-8"/>
	<title>EinsendeaufgabeYSQL4B.1</title>
</head>
<body>
	<form action ="" method ="post">
<?php if(isset($_POST["auswahl"])){
		$Auswahl = $_POST["auswahl"];
		ausgabe();
}
else {
	$Auswahl ="";
}
?>

<?php
	function dynAuswahl($wahl,$gegenStand,$text){
	
	$ausgabe = "value='$gegenStand'";
		if(isset($_POST["auswahl"]))
			if($_POST["$wahl"] == $gegenStand) {
			$ausgabe .="$text";}
			
	$ausgabe .=">$text";
	echo $ausgabe;
	}
?>
<?php
	function ausgabe()
	{
		if($_POST["auswahl"] != ""){
		echo "<h2>Ihre Bestellung lautet:";
			echo "<ul>\n";
			echo"<li>{$_POST["auswahl"]}</li>";
			echo "</ul>\n";
		}
	}
?>

<?php
	function dynAuswahl3($id,$name,$dinge ,$multiple)
	{
		if($multiple == true)
		{
			$groeße = $_POST["size='5'"];
			$multiple ="multiple>";
		}
		else{
			$objekt = "";
			$id = "<select id";
			$name = "name='$name'>";
			if(is_array($dinge)){
				foreach($dinge as $wert)
				$objekt = $wert;
			}
			$options = "<option 'value=$objekt>$objekt</option>";
		}
	}
?>
<?php
	echo dynAuswahl3('dynamische2','auswahl3',array("Wasser","Tee","Kaffee"),false);
	?>
<p>
<select id ='dynamisch1' name='auswahl'>
	<option <?php dynAuswahl ("auswahl","Brot","Brot" )?></option>
	<option <?php dynAuswahl ("auswahl","Butter", "Butter")?></option>
	<option <?php dynAuswahl ("auswahl","Milch", "Milch")?></option>
	<option <?php dynAuswahl ("auswahl","Eier", "Eier")?></option>
</select>
</p>
<p>
<select id='dynamisch2' name='auswahl2[]' size='5' multiple>
	<option value="Schrauben">Schrauben</option>
	<option value="Nägel">Nägel</option>
	<option value="Nadeln">Nadeln</option>
	<option value="Haken">Haken</option>
	<option value="Dübel">Dübel</option>
</select>
</p>
<input type="submit" value="abschicken">
</form>
</body>
</html>