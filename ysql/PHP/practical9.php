<?php
//to start a Session
session_start();

$_SESSION['practice'] = "This is great";

?>
<?php
$name="MyName";
$value=200;
$expiration = time() + (60*60*24*7);

setcookie($name,$value,$expiration);
?>

<!DOCTYPE html>
<html lang="en">
  <head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <title>Practical9</title>
    <link href="bootstrapStyle/css/bootstrap.min.css" rel="stylesheet">
  </head>
  <body>
	<form action="#" method="GET">
	<a href="practical9.php?source=1234">Drück mich</a> 
	</form>
	<?php
		if(isset($_GET["source"])){
			
			$link = $_GET["source"];
			echo $link;		
		}
		echo "<br />";
		if(isset($_COOKIE['MyName'])){
			echo $_COOKIE['MyName'];
		}
		?>
		<br />
	<?php
		if(isset($_SESSION['practice'])){
			echo $_SESSION['practice'];
		}
    ?>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
    <script src="bootstrapStyle/js/bootstrap.min.js"></script>
  </body>
</html>