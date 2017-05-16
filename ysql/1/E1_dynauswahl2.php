<!DOCTYPE html>
<html>
<head>
	<meta charset="UTF-8" />
	<title> test </title>
</head>
<body>
<?php
	function dynAuswahl($id,$name,array$options,$multiple)
	{
		$ident = "id='$id'";
		$nam = "name='$name'";
		$size = "size=".(count($options)+1)."";
		if($multiple == false){
		echo"<select $ident $nam >\n";
		foreach($options as $wert){
			echo"<option value = $wert >$wert</option>\n";
		}
		echo"</select>";
		}
		if($multiple == true){
			echo"<select $ident ($nam) $size multiple>\n";
			foreach($options as $wert){
			echo"<option value = $wert >$wert</option>\n";
		}
		echo"</select>";
		}
	}
?>
<form action="<?php echo $_SERVER["PHP_SELF"];?>" method="post">
<?php
	echo dynAuswahl("dynamisch1","auswahl1",array("Brot","Butter","Milch","Eier"),false);
?>
<p>
</p>
<?php
	echo dynAuswahl("dynamische2","auswahl2",array("Schrauben","Nägel","Haken","Dübel"),true); 
?>
<p>
<input type ="submit" value="abschicken"/>
</p>
</form>
</body>
</html>