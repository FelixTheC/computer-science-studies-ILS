<?php

class Cars {
    
    var $wheel_count = 4;
    var $door_count = 4;
    
    
    function car_detail($name){
    
        return "This car is a ". $name . " with ". $this->wheel_count . " Wheels and " . $this->door_count . " doors";;
    }    
    
    
}

$test = new Cars();

echo $test->car_detail('BMW');
echo "<br>";
echo $test->car_detail('Audi');

?>