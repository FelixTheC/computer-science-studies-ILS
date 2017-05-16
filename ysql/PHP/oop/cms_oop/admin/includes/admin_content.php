<div class="row">
    <div class="col-lg-12">
        <h1 class="page-header">
            Admin
            <small><?php 
                        $found_user = User::find_by_id($_SESSION['user_id']); 
                        echo $found_user->username; 
                    ?>
            </small>
        </h1>
        
<?php
        /* die einstiegs Variante am Ende findet sich die richtige
        OOP Variante
        da class User static ist können wir diese so aufrufen
        $result_set = User::find_all_users();
        
        wenn man mag kann man das auch so machen
        $user = new User();
        $result_set = $user->find_all();
        
        while($row = mysqli_fetch_array($result_set)){
            
            echo $row['username'] . "<br>";
        }
        */
        
//        $result_id = User::find_by_id(1);
//        $user = User::instantiation($result_id);
//        
//        echo $user->username;
        
//        $photos = Photo::find_all();
//        foreach ($photos as $photo){
//            
//            echo $photo->title . "<br>";
//        }
//        
//        $found_user = User::find_by_id(1);
//        echo $found_user->username;
        
//        $user = User::find_by_id(3);
//        $user->last_name = "Kater";
//        $user->first_name = "Gestiefelter";
//        $user->update();
        
//        $photo = new Photo();
//        $photo->title = "Adventure";
//        $photo->filename = "image23.jpg";
//        $photo->type = "jpeg";
//        $photo->size = "250";
//        $photo->save();
        
       
?>                        
        <ol class="breadcrumb">
            <li>
                <i class="fa fa-dashboard"></i>  <a href="index.html">Dashboard</a>
            </li>
            <li class="active">
                <i class="fa fa-file"></i> Blank Page
            </li>
        </ol>
    </div>
</div>