<!DOCTYPE html>
<html>
    <p>Veuillez entrer les infos afin de modifier la ligne :</p>
    <form action="modifier.php" method="post">
        <input type="hidden" name="id" value=<?php echo $_GET['id']; ?> />
        Nom : <input type="text" name="name" placeholder=<?php echo $_GET['nom']; ?> /><br /> 
        Espèce : <input type="text" name="espece" placeholder=<?php echo $_GET['espece']; ?> /><br /> 
        Cri : <input type="text" name="cri" placeholder=<?php echo $_GET['cri']; ?> /><br /> 
        Propriétaire : <input type="text" name="proprietaire" placeholder=<?php echo $_GET['proprietaire']; ?> /><br /> 
        Age : <input type="integer" name="age" placeholder=<?php echo $_GET['age']; ?> /><br /> 
        <input type="submit" name="submit" value="Modifier" />
    </form>
</html>
