<?php
class Autoklasse{
	private $geschwindigkeit = 0;
	
	//der Konstruktor der Aufruf kann somit direkt beim erzeugen der Instanz erfolgen
	public function __construct($standard)
	{
		$this->geschwindigkeit = $standard;
		echo"<br />Objekt erstellt<br />";
	}
	//wenn es einen Konstruktor gibt gibt es auch einen Destruktor dies erfolgt dann mit unset siehe weiter unten
	public function __destruct()
	{
		echo"<br />Das Objekt wurde Zerstört!!!<br />";
	}
	
	public function bremsen($aenderung)
	{
		if($this->geschwindigkeit - $aenderung < 0)
		{
			$this->geschwindigkeit =0;
		}
		else
		{
			$this->geschwindigkeit = $this->geschwindigkeit - $aenderung;
		}
	}
	
	public function gasgeben($aenderung)
	{
		$this->geschwindigkeit = $this->geschwindigkeit + $aenderung;
	}
	
	public function ausgeben()
	{
		echo "Die aktuelle Geschwindigkeit beträgt ".$this->geschwindigkeit." km/h";
	}
	
	//im Sinne der Datenkapselung ist es besser die Geschwindigkeit nicht direkt zuändern sondern über set- und mit get- ausgeben lassen
	public function getGeschwindigkeit()
	{
		return $this->geschwindigkeit;
	}
	
	public function setGeschwindigkeit($neuerWert)
	{
		$this->geschwindigkeit = $neuerWert;
	}
}
	
	/*Alles auskommentiert da ich auf diese Datei von der Datei Vererbung.php zugreife
	$auto1 = new Autoklasse(0);
	//$auto1 -> initialisieren(0); entfällt da Konstruktor vorhanden
	//$auto1 -> gasgeben(50); entfällt da wir set- und get- nutzen
	$auto1->setGeschwindigkeit(50);
	$auto1 -> ausgeben();
	$auto1 -> bremsen(20);
	$auto1 -> ausgeben();
	//und zum Abschluss zerstören wir noch unsere Instanz
	unset($auto1);*/