 <?php
        session_start();

        //stocke la variale de session login 
    $_login=$_SESSION['login'];

    //vérifit si la variable de session login est vide Si vide, renvoit vers login
    if($_login=="")
    {
        header("Location:login.php");
    }
    else
    {
        header("Location:bienvenue.php");
    }

        
 ?>
