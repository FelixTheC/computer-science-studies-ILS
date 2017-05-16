<!DOCTYPE HTML>
<html>
<head>
	<meta http-equiv="content-type" content="text/html" />
    <meta charset="utf-8" />
	<title>Artikel löschen</title>
<?php
    require_once("artikel.class.php");
?>
<link rel="stylesheet" type="text/css" href="styles.css" />
</head>
<body>
<?php
    require_once("artikel_db.inc.php");
?>
<?php
    if(isset($_POST["anr"])) {
		$teilnehmer = new teilnehmer();
		$teilnehmer -> loeschen($_POST["anr"]);
		echo "<h2>Artikel gelöscht</h2>";
    }
    header("refresh:3; url=e3_artikel_ausgeben.php");
?>
</body>
</html>