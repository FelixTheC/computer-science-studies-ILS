<?php

class Cars {
    
    static $doors = 4;
    static $wheels = 4;
    static $test = 1;
    
static function greeting($name){
    
    return "Hello ". $name . " with " . Cars::$wheels . " wheels and " . Cars::$doors . " doors";
}    
    
    
}

echo Cars::$test = 10;
echo "<br>";
echo Cars::greeting('Lexus');
echo "<br>";

class Trucks extends Cars{
    
    
}

echo Trucks::greeting('MAN');

?>