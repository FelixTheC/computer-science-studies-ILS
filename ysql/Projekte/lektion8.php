<?php
	//verschlüsselung
	$pwd = 'Wir09032013';
	
	$hashFormat = '$2a$17';
	$salt = 'idontwant2behacked22';
	
	$pwd = crypt($pwd, $hashFormat . $salt);
	
	echo "$pwd";
	
?>