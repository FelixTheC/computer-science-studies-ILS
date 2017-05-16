 <nav class="navbar navbar-inverse navbar-fixed-top" role="navigation">
        <div class="container">
            <!-- Brand and toggle get grouped for better mobile display -->
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1">
                    <span class="sr-only">Toggle navigation</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <a class="navbar-brand" href="index.php">Home</a>
            </div>
            <!-- Collect the nav links, forms, and other content for toggling -->
            <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
                <ul class="nav navbar-nav">
                    <?php
                        //was möchte ich aus der ausgewählten Datenbank nutzen 
                        $query = "SELECT * FROM categories";
                        //verbindung von dem was ich benutzen möchte und der Verbindung mit
                        //der Datenbank an sich
                        $select_all_categories_query = mysqli_query($mysqli, $query);
                        
                        //zugriff auf die einzelnen Zeilen ohne while schleife würde man
                    //immer das letzte element auswählen
                    while($row = mysqli_fetch_assoc($select_all_categories_query)){
                        //um nur eine spezielle spalte auszuwählen gut ist wenn man die Variable
                        //die man erstellt genauso benennt wie die spalte
                        $cat_title = $row['cat_title'];
                        $cat_id = $row['cat_id'];
                        echo "<li><a href='category.php?category=$cat_id'>{$cat_title}</a></li>";
                    }
                    ?>
                    <?php
                if(isset($_SESSION['role'])){
                 if ($_SESSION['role'] == 'admin') {
                     
                echo "<li class='nav navbar-nav'><a href='admin/index.php'>Admin</a></li>";
                 }
                }
                ?>
                </ul>
            </div>
            <!-- /.navbar-collapse -->
        </div>
        <!-- /.container -->
    </nav>