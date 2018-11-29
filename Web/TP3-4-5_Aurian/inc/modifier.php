<?php
include ('classes.php');
if(!empty($_POST['submit']))
{
    $animal = new Animal(array( 
        'id' => $_POST['id'],
        'nom' => $_POST['name'], 
        'espece' => $_POST['espece'],
        'cri' => $_POST['cri'],
        'proprietaire' => $_POST['proprietaire'],
        'age' => $_POST['age']
    ));
    $manager = new AnimauxManager($db);
    $manager -> modify($animal);
    header('Location:../index.php');
}
?>

