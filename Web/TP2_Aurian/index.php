<!DOCTYPE html>

    <html>

        <head>

        </head>

        <body>

            <?php

            echo "Cliquez sur un bonton : ";


            ?>

            <form action="index.php" method="post">

                <input type="text" name="input" value="<?php
                if(isset($_POST['clavier'])){
                    echo($_POST['input'].$_POST['clavier']);
                }elseif(isset($_POST['result'])){
                    eval("\$result = ".$_POST['input'].";");
                    echo $result;
                }?>" />
                <br/>

                <input type="submit" name="clavier" value="7" />
                <input type="submit" name="clavier" value="8" />
                <input type="submit" name="clavier" value="9" />
                <input type="submit" name="clavier" value="+" />
                <br/>

                <input type="submit" name="clavier" value="4" />
                <input type="submit" name="clavier" value="5" />
                <input type="submit" name="clavier" value="6" />
                <input type="submit" name="clavier" value="-" />
                <br />

                <input type="submit" name="clavier" value="1" />
                <input type="submit" name="clavier" value="2" />
                <input type="submit" name="clavier" value="3" />
                <input type="submit" name="clavier" value="*" />
                <br />

                <input type="submit" onclick="func('log')" name="clavier" value="log(" />
                <input type="submit" onclick="func('sin')" name="clavier" value="sin(" />
                <input type="submit" onclick="func('cos')" name="clavier" value="cos(" />
                <input type="submit" onclick="func('exp')" name="clavier" value="exp(" />
                <br />

                <input type="submit" name="clavier" value="0" />
                <input type="submit" name="reset" value="CE" />
                <input type="submit" name="clavier" value="/" />
                <input type="submit" name="clavier" value=")" />
                <input type="submit" name="result" value="=" />
                <br />

            </form>

        </body>

    </html>

