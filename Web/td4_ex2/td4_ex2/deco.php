<?php
    session_start();
    session_unset();
    session_destroy();

    echo "Vous &ecirc;tes d&eacute;connect&eacute;s";

?>
<html>
<head>
    <meta charset="UTF-8">
    <title>Bienvenue</title>
</head>
<body>
      <br/>
     <br/>
     <br/>
     <form action="index.php" method="POST">
        <input type="submit" name="submit" value="se connecter"/> 
    </form>
</body>
</html>