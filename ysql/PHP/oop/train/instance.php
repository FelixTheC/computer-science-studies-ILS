<?php

class Cars {
    
    function greeting($name){
    
        echo "Hello ". $name;
    }    
    
    
}

$test = new Cars();

$test->greeting('Felix');

?>