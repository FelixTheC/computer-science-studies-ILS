 <div class="col-md-4">

     
                <!-- Blog Search Well -->
                <div class="well">
                    <h4>Blog Search</h4>
           <form action="search.php" method="post">
                    <div class="input-group">
                        <input name="search" type="text" class="form-control">
                        <span class="input-group-btn">
                            <button name="submit" class="btn btn-default" type="button">
                                <span class="glyphicon glyphicon-search"></span>
                        </button>
                        </span>
                    </div>
            </form><!--search form -->
                    <!-- /.input-group -->
                </div>
     <div class="well">
        <h4>Log In</h4>
            <form action="login.php" method="post">
                <div class="form-group">
                    <label for="name_input">Username</label>
                        <input type="text" name="name_input" class="form-control">
                    <label for="passwd">Password</label>
                        <input type="password" name="passwd" class="form-control">
                    <br/>
                    <button class="btn btn-success btn-lg" name="login">Log In</button>
                    <button class="btn btn-primary btn-lg" name="logout">Log Out</button>
                </div>          
            </form>
         <h4><a href="createNew.php">Create New Account</a></h4s>
     </div>
     
     <?php
     
        $query = "SELECT * FROM categories";
        $categories = mysqli_query($mysqli, $query);
     ?>
    
                <!-- Blog Categories Well -->
                <div class="well">
                    <h4>Blog Categories</h4>
                    <div class="row">
                        <div class="col-lg-6">
                            <ul class="list-unstyled">
        <?php
            while($row = mysqli_fetch_assoc($categories)){
            $cat_title = $row['cat_title'];
                $cat_id = $row['cat_id'];
            echo "<li><a href='category.php?category=$cat_id'>{$cat_title}</a></li>";
            }
        ?>
                                
                            </ul>
                        </div>
                        <!-- /.col-lg-6 -->
                    </div>
                    <!-- /.row -->
                </div>

                <!-- Side Widget Well -->
                <div class="well">
                    <h4>Side Widget Well</h4>
                    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Inventore, perspiciatis adipisci accusamus laudantium odit aliquam repellat tempore quos aspernatur vero.</p>
                </div>

            </div>