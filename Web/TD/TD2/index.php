<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8" />
    <title>TD2</title>
</head>
<body>
    <?php

    if(isset($_POST['nbGagnant'])){
        $nombre = $_POST['nbGagnant'];
    }else{
        $nombre = mt_rand(1 , 100);
    }
    var_dump($_POST);

    echo($_POST['nombre']);
    echo("<br/>");

    if($_POST['nombre']>$nombre)
    {
        echo("Trop grand<br/>");

    }else if($_POST['nombre']<$nombre)
    {
        echo("Trop petit<br/>");
    }else{
        echo("gagné !");
    }

    ?>

    <form action="TD2EX2.php" method="post">
        <input type="hidden" name="nbGagnant" value="<?php echo $nombre; ?>" />
        ENTRER UN NOMBRE :
        <input type="text" name="nombre" />
        <br />
        <input type="submit" name="submit" value="Entrer" />
    </form>
</body>
</html>