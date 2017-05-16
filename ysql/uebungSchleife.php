<?php
    $summe = 0;
    for($i = 0; $i <= 100; $i++){
        $summe += $i;
    }
    echo $summe;
    $summe = 0;
    $i=0;
    while($i <= 100){
        $summe += $i;
        $i++;
    }
    echo '<br>';
    echo $summe;
?>