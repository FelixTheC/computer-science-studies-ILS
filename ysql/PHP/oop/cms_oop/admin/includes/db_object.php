<?php

class Db_object {
    
        
public static function find_all(){
      
    return static::find_by_query("SELECT * FROM " . static::$db_table . "");
      
}

    
    
public static function find_by_id($id){
        
    global $database;
    $the_result_array = static::find_by_query("SELECT * FROM " . static::$db_table . " WHERE id= $id ");
    
    // der erste Teil ist die if-Anweisung ab : beginnt der else-Zweig
    //das was nachdem ? kommt ist die Anweisung im if-Zweig
    
    return !empty($the_result_array) ? array_shift($the_result_array) : false;
    
    //hier ist die obere Anweisung ausgeschrieben
//    if(!empty($the_result_array)){
//        
//        $first_item = array_shift($the_result_array);
//        return $first_item;
//    
//    } else{
//        
//        return false;
//    }
}
    
    
public static function find_by_query($sql){
    global $database;
        
    $result = $database->query($sql);
    $the_object_array = array();
    
    while($row = mysqli_fetch_array($result)){
        //the_object_array ist jetzt ein Objekt und wird somit OOP gerecht
        $the_object_array[] = static::instantiation($row);
        
    }
    return $the_object_array;
        
}


    
public static function verify_user($username, $password){
    
global $database;
    
    $username = $database->escape_string($username);
    $password = $database->escape_string($password);
    
    
    $sql = "SELECT * FROM " . static::$db_table . " WHERE username = '{$username}' AND password = '{$password}' LIMIT 1";
    
    $the_result = static::find_by_query($sql);
    return !empty($the_result) ? array_shift($the_result) : false;
    
}
   
    
    
public static function instantiation($result_id){
    
    $calling_class = get_called_class();
        
    $the_object = new $calling_class;
    
    //  $the_object->id = $result_id['id'];
//  $the_object->username = $result_id['username'];
//  $the_object->first_name = $result_id['first_name'];
//  $the_object->last_name = $result_id['last_name'];
//  $the_object->password = $result_id['password'];
        
    //etwas flexibler bzw dynamischer    
    
    foreach ($result_id as $the_attribute => $value){
          
        if($the_object->has_the_attribute($the_attribute)){
        
        $the_object->$the_attribute = $value;
        }        
            
    }
        
    return $the_object;
}
    
    
private function has_the_attribute($the_attribute){
    
    $object_properties = get_object_vars($this);
    
    return array_key_exists($the_attribute, $object_properties);
    
}
    

protected function properties(){
    
    $properties = array();
    
    foreach (static::$db_table_fields as $db_field){
        
        if(property_exists($this, $db_field)){
            
            $properties[$db_field] = $this->$db_field;
        }
        
    }
    return $properties;
}     
    
    
    
protected function clean_properties(){
    
    global $database;
    
    $clean_properties = array();
    
    foreach($this->properties() as $key=>$value){
        
        $clean_properties[$key] = $database->escape_string($value);
        
    }
    
    return $clean_properties;
}     

    
    
    
public function save(){
    
    global $database;
    
    //wenn die ID in der Datenbank existiert updaten ansonsten neues objekt erstellen
    return isset($this->id) ? $this->update() : $this->create();
    
}    

    
public function create(){
      global $database;
    
      $properties = $this->clean_properties();
    
      $sql = "INSERT INTO " . static::$db_table . "(" . implode(",", array_keys($properties)) . ")";
      $sql .=" VALUES ('" . implode("','", array_values($properties)) ."')";
      
      if($database->query($sql)){
          
          $this->id = $database->the_insert_id();
          
          return true;
          
      } else{
          
          return false;
          
      }
      
      
  } 
    
public function update(){
    
    global $database;
    $properties = $this->clean_properties();
    
    $porertie_pairs = array();
    
    foreach($properties as $key => $value){
        
        $properties_pairs[] = "{$key}='{$value}' ";
    }
    
    $sql = "UPDATE " . static::$db_table . " SET ";
    $sql .= implode(", ", $properties_pairs );
    $sql .= " WHERE id= " . $database->escape_string($this->id);
    
    $database->query($sql);
    
    return (mysqli_affected_rows($database->mysqli) == 1) ? true : false;
    
    }
    

public function delete(){
    
    global $database;
    
    $sql = "DELETE FROM " . static::$db_table . " WHERE id=" . $database->escape_string($this->id) . " LIMIT 1";
    
    $database->query($sql);
}    
    

}
?>