<DOCTYPE html>
<head>
	<meta charset="UTF-8" />
	<title>Konto</title>
<?php
	include_once("konto.class.php");
?>
</head>
<body>
<?php

$neuerKunde = new Konto(123,500,"Meier,Hans");
$neuerKunde->abbuchen(600);
$neuerKunde->einzahlen(200);
$neuerKunde->abbuchen(600);
$neuerKunde->setNummer(456);
$neuerKunde->setStand(800);
$neuerKunde->setName("Schulze,Klara");
$neuerKunde->ausgabeNummer();
$neuerKunde->ausgabeStand();
$neuerKunde->ausgabeName();

?>
</body>
</html>