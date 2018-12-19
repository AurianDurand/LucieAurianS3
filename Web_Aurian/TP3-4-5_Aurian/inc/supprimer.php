<?php
include ('classes.php');
$animal = new Animal(array( 
    'id' => $_GET['id'],
    'nom' => $_GET['nom'], 
    'espece' => $_GET['espece'],
    'cri' => $_GET['cri'],
    'proprietaire' => $_GET['proprietaire'],
    'age' => $_GET['age']
));
$manager = new AnimauxManager($db);
$manager -> delete($animal);
header('Location:../index.php');
?>