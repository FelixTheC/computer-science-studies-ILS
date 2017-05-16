<?php
//to start a Session
session_start();

$_SESSION['greeting'] = "Hello Student this is awesome";

?>

<!DOCTYPE html>
<html lang="en">
  <head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <title>Sessions</title>
    <link href="bootstrapStyle/css/bootstrap.min.css" rel="stylesheet">
  </head>
  <body>

    
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
    <script src="bootstrapStyle/js/bootstrap.min.js"></script>
  </body>
</html>