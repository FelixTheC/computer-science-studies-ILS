<!DOCTYPE html>
<head>
	<meta charset="UTF-8" />
	<title>Kantinenbestellung</title>
</head>
<body>
	<form action="<?php echo $_SERVER["PHP_SELF"]; ?>", method="post">
	<h1>Kantinenbestellung</h1>
	<?php 
	if (isset($_POST["vSpeise"])){
		$vSpeise = $_POST["vSpeise"];
		$hSpeise = $_POST["hSpeise"];
		$nSpeise = $_POST["nSpeise"];
		$getraenk = $_POST["getraenk"];
		$gastStatus = $_POST["gaststatus"];
		auswerten();
		}
		else
		{
			$vSpeise= "";
			$hSpeise= "";
			$nSpeise= "";
			$getraenk= "";
			$gastStatus= "";
		}
	?>
	<?php
	function setOption($gang,$wert,$text)
	{
		$ausgabe = "value='($wert)'";
		
		if(isset($_POST["vSpeise"])){
			if($_POST[$gang] == $wert){
				$ausgabe .= " selected";
			}
		}
		if(empty($text)){
			$text = $wert;
		}
		
		$ausgabe .=">$text";
		echo $ausgabe;
	}
	?>
	<?php
	function auswerten()
	{
		if($_POST["vSpeise"]=="" && $_POST["hSpeise"]=="" && $_POST["nSpeise"]=="" && $_POST["getraenk"]=="")
		{
			echo "<p>Sie habe keinen Gang ausgewählt. Bitte wählen Sie.</p>";}
			else
			{
				echo"<h3>Vielen Danke für ihre Bestellung.</h3>\n";
				echo"<p>Sie wählten:</p>\n";
				echo"<ul>\n";
				if($_POST["vSpeise"] != ""){
					echo"<li>Vorspeise; {$_POST["vSpeise"]}</li>\n";
				}
			if($_POST["hSpeise"] != ""){
				echo"<li>Hauptspeise; {$_POST["hSpeise"]}</li>\n";
				}
			if($_POST["nSpeise"] != ""){
				echo"<li>Nachtisch; {$_POST["nSpeise"]}</li>\n";
			}
			if($_POST["getraenk"] != ""){
				echo"<li>Getränk; {$_POST["getraenk"]}</li>\n";
			}
			echo"</ul>\n";
			}
	}
?>
<fieldset>
<h2>Menüauswahl</h2>
<p>
<label for="vSpeise">Vorspeise:</label>
<select id="vSpeise" name="vSpeise">
		<option <?php setOption("vSpeise", "", "Bitte wählen Sie");?></option>
		<option <?php setOption("vSpeise", "Salat", "Gemischter Salat");?></option>
		<option <?php setOption("vSpeise", "Rinderbouillon", "Rinderbouillon");?></option>
		<option <?php setOption("vSpeise", "Schafskäse", "Gebackener Schafskäse");?></option>
</select>
</p>
<p>
<label for="hSpeise">Hauptspeise</label>
<select id="hSpeise" name="hSpeise">
	<option <?php setOption("hSpeise", "", "Bitte wählen Sie");?></option>
	<option <?php setOption("hSpeise", "Pizza", "Pizza");?></option>
	<option <?php setOption("hSpeise", "Schnitzel", "Schnitzel mit Pommes");?></option>
	<option <?php setOption("hSpeise", "Risotto", "Basilikum-Risotto mit Spargel");?></option>
</select>
</p>
<p>
<label for="nSpeise">Nachspeise</label>
<select id="nSpeise" name="nSpeise">
	<option <?php setOption("nSpeise", "", "Bitte wählen Sie");?></option>
	<option <?php setOption("nSpeise", "Pudding", "Pudding");?></option>
	<option <?php setOption("nSpeise", "Kuchen", "Kirschkuchen");?></option>
	<option <?php setOption("nSpeise", "Quark", "Quarkspeise mit Obst");?></option>
</select>
</p>
<label for="getraenk">Getränk</label>
<select id="getraenk" name="getraenk">
	<option <?php setOption("getraenk", "", "Bitte wählen Sie");?></option>
	<option <?php setOption("getraenk", "Cola", "Cola");?></option>
	<option <?php setOption("getraenk", "Saft", "Fruchtsaft");?></option>
	<option <?php setOption("getraenk", "Schorle", "Schorle");?></option>
	<option <?php setOption("getraenk", "Wasser", "Wasser");?></option>
	<option <?php setOption("getraenk", "Kaffee", "Kaffee");?></option>
	<option <?php setOption("getraenk", "Tee", "Früchtetee");?></option>
</select>
</p>
</fieldset>
<fieldset>
<p>
<input type="radio" id="eigener" name="gaststatus" value="Mitarbeiter" checked/>
<?php if($gastStatus !="Gast") echo "checked='checked'"?>
<label for="eigener">Mitarbeiter</label><br/>
<input type="radio" id="fremd" name="gaststatus" value="Gast"/>
<?php if($gastStatus =="Gast") echo "checked='checked'"?>
<label for="fremd">Gast</label>
</p>
<p>
<input type="submit" value="bestellen"/>
<input type="reset" value="zurücksetzen"/>
</p>
</fieldset>
</form>
</body>
</html>