<?php
        $query="SELECT * FROM posts";
        $show_all = mysqli_query($mysqli, $query);
        $count = mysqli_num_rows($show_all);        
?>

<div class="col-lg-3 col-md-6">
        <div class="panel panel-primary">
            <div class="panel-heading">
                <div class="row">
                    <div class="col-xs-3">
                        <i class="fa fa-file-text fa-5x"></i>
                    </div>
                    <div class="col-xs-9 text-right">
                  <div class='huge'><?php echo $count; ?></div>
                        <div>Posts</div>
                    </div>
                </div>
            </div>
            <a href="allPosts.php">
                <div class="panel-footer">
                    <span class="pull-left">View Details</span>
                    <span class="pull-right"><i class="fa fa-arrow-circle-right"></i></span>
                    <div class="clearfix"></div>
                </div>
            </a>
        </div>
    </div>