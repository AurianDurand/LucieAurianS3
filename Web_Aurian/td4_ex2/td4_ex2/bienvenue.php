<?php
    session_start();

    //stocke la variale de session login 
    $_login=$_SESSION['login'];

    //vérifit si la variable de session login est vide Si vide, renvoit vers login
    if($_login=="")
    {
        header("Location:login.php"); 
    }else{
         echo "Bienvenue !!! ".$_SESSION['login'];
    }

?>
<html>
<head>
    <title>Bienvenue</title>
</head>
<body>
        <br/>
     <form action="deco.php" method="POST">
        <input type="submit" name="submit" value="d&eacute;connection"/> <br/>
    </form>
</body>
</html>