
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
	}
	
	public function buchen($wert)
	{
		$this->kStand = $this->kStand + $wert;
		echo "Es wurden ".$wert." Geldeinheiten ihrem Konto ".$this->kNummer." gutgeschrieben.<br />";
		echo "Ihr neuer Kontostand beträgt ".$this->kStand."";
	}
	
	public function abbuchen($wert)
	{
		if($wert > $this->kStand){
			echo "Ihr Guthaben reicht nicht aus ".$this->kStand."";
		}
		else{
			$this->kStand = $this->kStand - $wert;
			echo "Es konnten erfolgreich ".$wert." von ihrem Konto ".$this->kNummer." abgebucht werden<br />";
			echo "Ihr neuer Kontostand beträgt ".$this->kStand"";
		}
	}
	
}
?>
