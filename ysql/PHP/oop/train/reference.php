<?php

class Cars {
    
    static $doors = 4;
    static $wheels = 4;
    static $test = 1;
    
static function greeting($name){
    
    return "Hello ". $name . " with " . self::$wheels . " wheels and " . self::$doors . " doors";
}    
    
    
}

echo Cars::$test = 10;
echo "<br>";
echo Cars::greeting('Lexus');
echo "<br>";

class Trucks extends Cars{
    
    static function display(){
        
        echo parent::greeting('Volvo');
    }
    
}
Trucks::display();
echo "<br>";
echo Trucks::greeting('MAN');

?>