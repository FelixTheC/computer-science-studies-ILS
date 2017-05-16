<?php
//Setting Cookies
$name="SomeName";
//value can be everything
$value = 100;
//wie lange soll cookie beim user sein in diesem beispiel ein Jahr
$expiration = time() + (60*60*24*7*52);
setcookie($name,$value,$expiration);
?>


<!DOCTYPE html>
<html lang="en">
  <head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <title>setting Cookies</title>
    <link href="bootstrapStyle/css/bootstrap.min.css" rel="stylesheet">
  </head>
  <body>
<?php
//Reading Cookies
//Use the SuperGlobal $_COOKIE
	if(isset($_COOKIE["SomeName"])){
		
	$someOne = $_COOKIE["SomeName"];
		echo $someOne;
	
	} else {
		
	$someOne= "";
	
	}



?>
    
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
    <script src="bootstrapStyle/js/bootstrap.min.js"></script>
  </body>
</html>