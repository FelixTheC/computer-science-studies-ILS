<?php

$mysqli = new mysqli("localhost", "root", "walle", "bestelldatenbank");

if ($mysqli->connect_error) {
  echo "Verbindungsfehler: " . $mysqli->connect_error;
  exit();
}
if (!$mysqli->set_charset("utf8")) {
  echo "Fehler beim Laden von UTF8 ". $mysqli->error;
}
?>