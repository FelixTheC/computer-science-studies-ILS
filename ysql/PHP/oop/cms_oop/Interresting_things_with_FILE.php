<?php

if(isset($_POST['submit'])){
//    echo "<pre>";
//    print_r($_FILES['file_upload']);
//    echo "<pre>";


$upload_errors = array(

UPLOAD_ERR_OK => "There is no error",
UPLOAD_ERR_INI_SIZE => "The uploaded file exceeds the upload_max_filesize",
UPLOAD_ERR_FORM_SIZE => "The uploaded file exceeds the MAX_FILE_SIZE",
UPLOAD_ERR_PARTIAL => "The uploaded File was only partially uploaded",
UPLOAD_ERR_NO_FILE => "No file was uploaded",
UPLOAD_ERR_NO_TMP_DIR => "Missing a temporary Folder",
UPLOAD_ERR_CANT_WRITE => "Failed to write file to disk",
UPLOAD_ERR_EXTENSION => "A PHP Extension stoped the file upload"

);


    
########################################################

$temp_name = $_FILES['file_upload']['tmp_name'];
$file = $_FILES['file_upload']['name'];
$directory = "uploads";

    
if(move_uploaded_file($temp_name, $directory . "/" . $file)){
    
    $the_error_message = "File uploaded successfully";
    
} else{
    
    $the_error_num = $_FILES['file_upload']['error'];
    $the_error_message = $upload_errors[$the_error_num];
    
}   
    
}
?>

<!DOCTYPE html>
<html lang="en">

<head>

    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="description" content="">
    <meta name="author" content="">

    <link href="css/bootstrap.min.css" rel="stylesheet">

    <link href="css/blog-home.css" rel="stylesheet">

</head>
<body>

<form action="" enctype="multipart/form-data" method="post">
    <h2>
        <?php 
        
            if(!empty($upload_errors)){
                echo $the_error_message;
            }
        
        ?>
    </h2>
    <input type="file" name="file_upload">
    <input type="submit" value="Submit" name="submit">
</form>  
    
</body>