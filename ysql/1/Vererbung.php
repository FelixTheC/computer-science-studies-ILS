<DOCTYPE html>
<head>
	<meta charset ="UTF-8" />
	<title> Vererbung </title>
<?php
	//um auf die Klasse Auto zugreifen zukönnen
	include_once("KlassenInPhp.php");
?>
</head>
<body>
<?php
	//die Klasse Sportwagen ist eine "Erweiterung" der Klasse Autoklasse
	class sportwagen extends Autoklasse{
		//jetzt können wir hier noch erweiterungen für die Klasse Sportwagen erstellen
		private $hoechstgeschwindigkeit = 0;
		private $geschwindigkeitsBegrenzer = true;
		private $carbonBremsen = true;
		
		public function setHoechstgeschwindigkeit($wert)
		{
			$this->hoechstgeschwindigkeit = $wert;
		}
		
		public function getHoechstgeschwindigkeit()
		{
			return $this->hoechstgeschwindigkeit;
		}
		
		public function ausgeben()
		{
			//um auch auf ausgeben der Ursprungsklasse zuzugreifen zur Not einfach noch einmal auskommentieren um den Unterschied festzustellen
			Autoklasse::ausgeben();
			echo"<br />Die Höchstgeschwindigkeit beträgt ".$this->hoechstgeschwindigkeit." km/h";
		}
		
	}
$sw1 = new Sportwagen(250);
$sw1->setHoechstgeschwindigkeit(280);
$sw1->ausgeben();
?>
</body>
</html>
