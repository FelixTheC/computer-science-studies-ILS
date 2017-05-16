<?php

class User extends Db_object{
    
protected static $db_table = "users";
protected static $db_table_fields = array('username', 'first_name', 'last_name', 'password');
    public $id;
    public $username;
    public $first_name;
    public $last_name;
    public $password; 
    
      
   
    
}

?>