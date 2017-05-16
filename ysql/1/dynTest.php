<!DOCTYPE html>
<html>
<head>
	<meta charset="UTF-8" />
	<title> test </title>
</head>
<body>
<?php
	function dynAuswahl($id,$name,array $options,$multiple)
	{
		$temp="";
		if(is_array($options))
		{foreach($options as $wert)
		$temp = $wert;}
		$ausgabe= "value='$temp'";
		if($options == $temp){
		$ausgabe .=" selected";}
		$ausgabe = ">$temp";
		echo $ausgabe;
		if($multiple == true)
		{
			echo "<p>
			<select id=".$id." name=".$name."[] size='5' multiple>
			<options $ausgabe</options>
			<options $ausgabe</options>
			<options $ausgabe</options>
			</select>
			</p>";
		}
		else
		{
			echo "<p>
			<select id=".$id." name=".$name.">
			<options>$temp</options>
			<options>$temp</options>
			<options>$temp</options>
			</select>
			</p>";
			
		}
		
	}	
?>
<form action="<?php echo $_SERVER["PHP_SELF"];?>" method="post">
<?php
	echo"<h1>Dynamische Auswahl</h1>";
	echo dynAuswahl("dynamisch1","auswahl1",array("Brot","Wasser","Milch"),false);
	echo dynAuswahl("dynamische2","auswahl2",array("Schrauben","Muttern","Nägel"),true); 
?>
</form>
<p><input type ="submit" value="Abschicken"/>
</p>
</body>
</html>