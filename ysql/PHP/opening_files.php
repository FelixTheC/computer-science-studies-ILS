<!DOCTYPE html>
<html lang="en">
  <head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <title>Working with files</title>
    <link href="bootstrapStyle/css/bootstrap.min.css" rel="stylesheet">
  </head>
  <body>
<?php

$file="example.txt";

$handle = fopen($file, 'w');
fclose($handle);

?>
    
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
    <script src="bootstrapStyle/js/bootstrap.min.js"></script>
  </body>
</html>