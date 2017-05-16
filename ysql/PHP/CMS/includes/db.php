<?php

$db['db_host'] = "localhost";
$db['db_user'] = "root";
$db['db_pwd'] = "walle";
$db['db_name'] = "altedatenbank";

foreach ($db as $key => $value){
    
define(strtoupper($key), $value);
    
}

$mysqli = mysqli_connect(DB_HOST,DB_USER,DB_PWD,DB_NAME);

if(!$mysqli){
      echo "Verbindung Fehlgeschlagen", mysqli_error();
}

    
  
