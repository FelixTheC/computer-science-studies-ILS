<!DOCTYPE html>
<html>
    
<?php include("includes/admin_header.php"); ?>

<body>

    <div id="wrapper">

        <!-- Navigation -->
      <?php include("includes/navigation.php"); ?>

        <div id="page-wrapper">

            <div class="container-fluid">

                <!-- Page Heading -->
                <div class="row">
                    <div class="col-lg-12">
                        <h1 class="page-header">
                            Welcome to admin
                            <small><?php echo $_SESSION['username']; ?></small>
                        </h1>
                    </div>
                </div>
                <!-- /.row -->
                           
                <!-- /.row -->
                
<div class="row">
    <?php include('includes/widget_posts.php'); ?>
    <?php include('includes/widget_comments.php'); ?>
    <?php include('includes/widget_user.php'); ?>
   <?php include('includes/widget_categories.php');?>
</div>
                <!-- /.row -->

    <?php
        
        $query="SELECT * FROM posts WHERE post_status='draft'";
        $show_all_draft = mysqli_query($mysqli, $query);
        $post_count = mysqli_num_rows($show_all_draft);        
       
        $query="SELECT * FROM comments";
        $show_all_comment = mysqli_query($mysqli, $query);
        $comment_count = mysqli_num_rows($show_all_comment);  
                
        $query="SELECT * FROM users WHERE user_role ='subscriber'";
        $show_all_user = mysqli_query($mysqli, $query);
        $users_count = mysqli_num_rows($show_all_user);  
                
        $query="SELECT * FROM categories";
        $show_all_cat = mysqli_query($mysqli, $query);
        $categories_count = mysqli_num_rows($show_all_cat);  

    ?>
                
    <div class="row">
        <script type="text/javascript">
            google.charts.load('current', {'packages':['bar']});
            google.charts.setOnLoadCallback(drawChart);
        function drawChart() {
            var data = google.visualization.arrayToDataTable([
                ['Data', 'Count'],
                
    <?php
        $element_text = ['Active Posts','Comments', 'Users', 'Categories'];
                
        $element_count = [$post_count, $comment_count, $users_count, $categories_count];
                
            for($i=0;$i <4; $i++)
                {
        echo "['$element_text[$i]','$element_count[$i]'],";
    
            }
        ?>
        
        ]);

            var options = {
                chart: {
                    title:'',
                    subtitle: '',
                }
            };

            var chart = new google.charts.Bar(document.getElementById('columnchart_material'));

            chart.draw(data, options);
            }
        </script>
    
        <div id="columnchart_material" style="width: 'auto'; height: 500px;"></div>

    </div>
</div>
            
            <!-- /.container-fluid -->

        </div>
        <!-- /#page-wrapper -->

    </div>
    <!-- /#wrapper -->

    <!-- jQuery -->
    <script src="js/jquery.js"></script>

    <!-- Bootstrap Core JavaScript -->
    <script src="js/bootstrap.min.js"></script>

</body>

</html>
