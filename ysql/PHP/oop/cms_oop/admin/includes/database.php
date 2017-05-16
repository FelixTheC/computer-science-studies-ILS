<?php

require_once("new_config.php");

class Database{
    
    
    public $mysqli;
    
    
    function __construct(){
    
        $this->open_db_connection();
    }
    
    
    
    public function open_db_connection(){
        
        //$this->mysqli = mysqli_connect(DB_HOST,DB_USER,DB_PWD,DB_NAME);
        $this->mysqli = new mysqli(DB_HOST,DB_USER,DB_PWD,DB_NAME);
        
        if($this->mysqli->connect_errno){
            die("Database connection failed" . $this->mysqli->connect_error);
        }
        
    }
    
    
    
    public function query($sql){
        
        $result = $this->mysqli->query($sql); 
        $this->confirm_query($result);
        return $result;
        
    }
    
    private function confirm_query($result){
        
        if(!$result){
            die("Query failed" . $this->mysqli->error);
        }
        }
    
    public function escape_string($string){
        
        $escaped_string = $this->mysqli->real_escape_string($string);      
        return $escaped_string;
    }
    
    
    public function the_insert_id(){
        return $this->mysqli->insert_id;
    }
    

}


$database = new Database();


    
  
