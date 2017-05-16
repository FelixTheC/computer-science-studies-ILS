<?php include "database.php"; ?>
<?php include "function.php"; ?>
-
<!DOCTYPE html>
<html>
<head>
	<meta charset='UTF-8' />
	<title>Test</title>
	<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.2/css/bootstrap.min.css"> 
</head>
<body>

<form action='process.php' method='post'>
	<div class="container">
	<div class="col-sm-6">
	<strong><label for="username">Username</label></strong>
	<input type='text' name='user' placeholder='Bitte Username eingeben' />
	<br />
	<label>Message</label>
	<input type='text' name='message' placeholder='Bitte Nachricht eingeben' />
	</div>
	<br/>
	<br/>
	</div>
	<div class="form-group">
	<select name="id" id="">
	<?php 
		showData();
	?>
	</select>
	<br/>
	</div>
	
	<input class="btn btn-primary" type='submit' name='update' value='Create'/>
	<br/>
	<br/>
	<input class="btn btn-primary" type='submit' name='update' value='Update'/>
	<br/>
	<br/>
	<input class="btn btn-primary" type='submit' name='delete' value='DELETE'/>
</form>
</body>
</html>	
	