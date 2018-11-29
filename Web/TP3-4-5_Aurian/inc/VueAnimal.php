<!DOCTYPE html>
<style>
    table, tr, td {
        border : 1px solid black;
    }
</style>

<?php

include ('classes.php');

$manager = new AnimauxManager($db);
$listeAnimaux = $manager->getList();
echo "<p><b>Bienvenue, <br />Voici le site que j'ai réalisé lors des TP 3-4-5 du module de programmation web</b></p>";
echo "<p>Ce site vous permet de consulter et modifier une base de données contenant des animaux.<br />";
echo "Voici la liste des animaux se trouvant dans la base de données : </p>";
echo "<table>"; 
foreach($listeAnimaux as $key => $value)
{
    echo "<tr><td>"; 
    echo $value->toString();
    $id = $value->getId();
    $nom = $value->getNom();
    $espece = $value->getEspece();
    $cri = $value->getCri();
    $proprietaire = $value->getProprietaire();
    $age = $value->getAge();
    echo " | <a href=\"/inc/formModifier.php?id=$id&nom=$nom&espece=$espece&cri=$cri&proprietaire=$proprietaire&age=$age\">Modifier</a>";
    echo " <a href=\"/inc/supprimer.php?id=$id&nom=$nom&espece=$espece&cri=$cri&proprietaire=$proprietaire&age=$age\">Supprimer</a>";
    echo '<br>';
    echo "</td></tr>";
}
echo "</table>";
echo "<a href=\"/inc/ajout.php\">Ajouter un nouvel annimal</a>";
echo "<p><b>Je vous remercie d'avoir visité mon site, Aurian</b></p>";