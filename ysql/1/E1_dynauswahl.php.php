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
		$ident = "id='$id'";
		$nam = "name='$name'";
		$temp1 = "<options value='$options[0]'>$options[0]</options>";
		$temp2 = "<options value='$options[1]'>$options[1]</options>";
		$temp3 = "<options value='$options[2]'>$options[2]</options>";
		$temp4 = "<options value='$options[3]'>$options[3]</options>";
		$size = "size=".(count($options)+1)."";
		
		if($multiple == false){
		echo "<p>
		<select ".$ident." ".$nam.">
		".$temp1."
		".$temp2."
		".$temp3."
		".$temp4."
		</select>
		</p>\n";
		}
		else{
		echo "<select ".$ident." name=".$name."[] ".$size." multiple>
		".$temp1."
		".$temp2."
		".$temp3."
		".$temp4."
		</select>
		</p>\n";
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