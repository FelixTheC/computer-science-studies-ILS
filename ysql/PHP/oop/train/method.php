<?php

class Cars {
    
function greeting($name){
    
    echo "Hello ". $name;
}    
    
    
}

$the_methods = get_class_methods('Cars');

foreach ($the_methods as $method){
    
    echo $method;
}

?>