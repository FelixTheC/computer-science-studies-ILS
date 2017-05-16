<?php
class Konto{
	
	private $kNummer = 0;
	private $kStand = 0;
	private $kName ="";
	
	public function __construct($KontoNr, $KontoSt, $KontoNa)
	{
		$this->kNummer = $KontoNr;
		$this->kStand = $KontoSt;
		$this->kName = $KontoNa;
		echo "Konto:".$this->kNummer." wurde erfolgreich erstellt";
		echo "<br /> Kontoinhaber: ".$this->kName."";
		echo "<br /> Kontostand: ".$this->kStand."";
	}
	
	public function einzahlen($wert)
	{
		$this->kStand = $this->kStand + $wert;
		echo "<br />Es wurden erfolgreich ".$wert." ihrem Konto ".$this->kNummer." gutgeschrieben.<br />";
		echo "Ihr neuer Kontostand beträgt ".$this->kStand."";
	}
	
	public function abbuchen($wert)
	{
		if($wert > $this->kStand){
			echo "<br /> Sie haben versucht ".$wert." von ihrem Konto abzubuchen aber ";
			echo "<br />Ihr Guthaben von ".$this->kStand." auf ihrem Konto ".$this->kNummer." reicht nicht aus";
		}
		else{
			$this->kStand = $this->kStand - $wert;
			echo "<br />Es konnten erfolgreich ".$wert." von ihrem Konto ".$this->kNummer." abgebucht werden<br />";
			echo "Ihr neuer Kontostand beträgt ".$this->kStand."";
		}
	}
	
	public function setNummer($neueNummer)
	{
		$this->kNummer = $neueNummer;
	}
	public function getNummer()
	{
		return $this->kNummer;
	}
	
	public function setStand($neuerStand)
	{
		$this->kStand = $neuerStand;
	}
	public function getStand()
	{
		return $this->kStand;
	}
	
	public function setName($neuerName)
	{
		$this->kName = $neuerName;
	}
	public function getName()
	{
		return $this->kName;
	}
	
	public function ausgabeNummer()
	{
		echo"<br />Konto: ".$this->kNummer." konnte erfolgreich angelegt werde";
	}
	
	public function ausgabeStand()
	{
		echo"<br />Konto: ".$this->kNummer." enthält ".$this->kStand." ";
	}
	
	public function ausgabeName()
	{
		echo"<br />Kontoinhaber: ".$this->kName." ";
	}
}
?>
