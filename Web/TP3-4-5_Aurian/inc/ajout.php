<!DOCTYPE html>
<html>

    <p>Veuillez entrer les infos afin d'ajoute une ligne :</p>
    <form action="ajout.php" method="post">
        Nom : <input type="text" name="name" /><br /> 
        Espèce : <input type="text" name="espece" /><br /> 
        Cri : <input type="text" name="cri" /><br /> 
        Propriétaire : <input type="text" name="proprietaire" /><br /> 
        Age : <input type="integer" name="age" placeholder="0" /><br /> 
        <input type="submit" name="submit" value="Ajouter" />
    </form>

    <?php
    include ('classes.php');
    if(!empty($_POST['submit']))
    {
        $animal = new Animal(array( 
            'nom' => $_POST['name'], 
            'espece' => $_POST['espece'],
            'cri' => $_POST['cri'],
            'proprietaire' => $_POST['proprietaire'],
            'age' => $_POST['age']
        ));
        $manager = new AnimauxManager($db);
        if($manager->canBeCreated($animal) == true)
        {
            $manager -> add($animal);
        }
        header('Location:../index.php');
    }
    ?>
</html>