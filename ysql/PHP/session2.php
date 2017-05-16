<?php
//to start a Session or and use Session
session_start();

echo $_SESSION['greeting'];

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
	<form action="practical9.php" method="GET">
	<a href="practical9.php" name="link">Drück mich</a> 
	</form>
    
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
    <script src="bootstrapStyle/js/bootstrap.min.js"></script>
  </body>
</html>