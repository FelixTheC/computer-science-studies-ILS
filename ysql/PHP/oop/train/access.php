<?php

class Cars {
    
    public $wheels = 4;
    private $doors = 4;
    
function greeting($name){
    
    echo "Hello ". $name . " with " . $this->wheels . " wheels and " . $this->doors . " doors";
}    
    
    
}

$test = new Cars();

$test->greeting('Audi');
echo "<br>";
echo $test->wheels;
echo "<br>";
//echo funktinoiert nicht da doors = private $test->doors;

class Trucks extends Cars{
    
    
}

$another = new Trucks();

echo "<br>";
$another->greeting('Volvo');

?>