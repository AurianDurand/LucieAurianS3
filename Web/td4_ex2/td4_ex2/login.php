 <?php
        session_start();
 ?>

<html>
<head>
    <title>Login</title>
</head>
<body>   
    
    <!--Formulaire-->
    <form method="POST">
        login : <input type="test" name="login" value=""/><br/>
        Mdp : <input type="text" name="mdp" value="" /><br/>
        <input type="submit" name="submit" value="OK":> <br/>
    </form>

    <!--Stockage des données dans variables-->
    <?php
              
        $_SESSION['login']=$_POST['login'];
        $_SESSION['mdp']=$_POST['mdp'];

        if(isset($_POST['submit']))
        {
            header("Location:bienvenue.php"); 
        }
       
    ?>
</body>
</html>