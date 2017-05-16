<?php

class Cars {
    
    private $wheels = 4;
    private $doors = 4;
    
function get_wheels(){
   
    return $this->wheels;
}    
    
function get_doors(){
   
    return $this->doors;
}   
    
function set_wheels($num){
   
    $this->wheels = $num;
    return $this->wheels;
}    
    
function set_doors($num){
   
    $this->doors = $num;
    return $this->doors;
}      
    
    
}

$test = new Cars();
echo $test->get_doors();
$test->set_doors(8);
echo "<br>";
echo $test->get_doors();


//echo funktinoiert nicht da doors = private $test->doors;

class Trucks extends Cars{
    
    
}

$another = new Trucks();


?>