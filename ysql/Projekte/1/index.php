<?php include 'database.php';?>
<?php include 'process.php'?>
<?php
//connection to Database
	$sql = "SELECT * FROM posts";
	$ergebnis = $mysqli->query($sql);
?>
<!DOCTYPE html>
<html>
<head>
	<meta charset='UTF-8'/>
	<title>Shout It!</title>
	<link rel="stylesheet" href="css/style.css" type ="text/css" />
</head>
	<body>
		<div class="container">
			<header>
				<h1>SHOUT IT! Shoutbox</h1>
			</header>
		<div class="shouts">
			<ul>
			<?php while($row = mysqli_fetch_assoc($ergebnis)): ?>
				<li class="shout"><span><?php echo $row['time'];?> - </span><strong><?php echo $row['user'];?>:</strong> <?php echo $row['message']; ?></li>
			<?php endwhile; ?>	
			</ul>
		</div>
		<div class="input">
			<form action="process.php" method='post'>
				<input type="text" name="user" placeholder="Enter your Name"/>
				<input type="text" name="message" placeholder="Enter a Message"/>
				<br/>
				<input class="shout-btn" type="submit" name="Submit" value="Send Message" />
				</form>
		</div>
		</div>
	</body>
</head>
