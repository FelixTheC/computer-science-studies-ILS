<DOCTYPE html>
<head>
	<meta charset="UTF-8" />
	<title>Klassendiagramm</title>
</head>
<body>
<?php
class Person{
	protected $Name = "";
	protected $Vorname = "";
	
	public function __construct($vName,$nName)
	{
		$this->Name = $nName;
		$this->Vorname = $vName;
		Echo"Eine Person wurde erstellt";
	}
	
	public function setname($nName)
	{
		$this->Name = $nName;
	}
	public function getname()
	{
		return $this->Name;
	}
	
	public function setVname($vName)
	{
		$this->Vorname = $vName;
	}
	
	public function getVname()
	{
		return $this->Vorname;
	}
}

$np = new Person("Bruce","Wayne");
var_dump($np);
?>
<?php
class Mitarbeiter extends Person{
	
	private $gruppierung = 0;
	private $steuerklasse = 1;
	private $kontonummer = "";
}
$mitArbeiter = new Mitarbeiter("Dick","Graces");
var_dump($mitArbeiter);
?>
<?php
class Kunde extends Person{
	
	private $bonitaet = 0;
	
	public function setBonitaet($wert)
	{
		$this->boenitaet = $wert;
	}
	
	public function getBonitaet()
	{
		return $this->bonitaet;
	}
}

$nK = new Kunde("Two","Face");
var_dump($nK);
?>
</body>
</html>
