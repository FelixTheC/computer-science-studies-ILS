<?php
class artikel {
	
	private $tabelle = "artikel";

public function loeschen($id) {
	
     require("artikel_db.inc.php");
     
     $sql = "DELETE FROM " .$this->tabelle ." WHERE anr=? ";
     if ($stmt = $mysqli -> prepare($sql)) {
		$stmt->bind_param('i', $id);
        $stmt -> execute();
      }
      $stmt->close();
      $mysqli->close(); 
}

}
?>