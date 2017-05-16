<?php

class Cars {
    
    var $wheels = 4;
    var $doors = 4;
    
function greeting($name){
    
    echo "Hello ". $name . " with " . $this->wheels . " wheels and " . $this->doors . " doors";
}    
    
    
}

$test = new Cars();

$test->greeting('Audi');

class Trucks extends Cars{
    
    
}

$another = new Trucks();

echo "<br>";
$another->greeting('Volvo');

?>