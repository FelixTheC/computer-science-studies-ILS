<?php include("includes/header.php"); ?>
<?php if(!$session->is_signed_in()) {redirect("login.php");} ?>

<!-- Navigation -->
<?php include("includes/top_nav.php"); ?>

<!--Sidebar -->
<?php include("includes/sidebar.php"); ?> 

<div id="page-wrapper">       
    <div class="row">
        <div class="col-lg-12">
            <h1 class="page-header">
                Edit Photos
            <small><?php 
                        $found_user = User::find_by_id($_SESSION['user_id']); 
                        echo $found_user->username; 
                    ?>
            </small>
        </h1>
        
            <div class="container-fluid">

                <div class="col-md-6">
                    <div class="form-group">
                        <label for="text">Title</label>
                        <input type="text" name="title" class="form-control">
                    </div>
                    <div class="form-group">
                        <label for="caption">Caption</label>
                        <input type="text" name="caption" class="form-control">
                    </div>
                    <div class="form-group">
                         <label for="slternate">Alternate Text</label>
                        <input type="text" name="alternate" class="form-control">
                    </div>
                    <div class="form-group">
                         <label for="description">Description</label>
                        <textarea class="form-control" name="description" id="" cols="30" rows="10"></textarea>
                    </div>
                    <div class="form-group">
                        <button class="btn btn-warning" name="logout" class="form-control">Save</button>
                        <button class="btn btn-primary" name="back" class="form-control">Back</button>
                    </div>
                    
                </div>
            </div>
        </div>
    </div>
</div>
  <?php include("includes/footer.php"); ?>