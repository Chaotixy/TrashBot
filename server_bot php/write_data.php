<?php

    // Prepare variables for database connection
   
    $dbusername = "Test123";  // enter database username, I used "arduino" in step 2.2
    $dbpassword = "Abc123#";  // enter database password, I used "arduinotest" in step 2.2
    $server = "localhost"; // IMPORTANT: if you are using XAMPP enter "localhost", but if you have an online website enter its address, ie."www.yourwebsite.com"

    // Connect to your database

    $dbconnect = mysql_connect($server, $dbusername, $dbpassword);
    $dbselect = mysql_select_db("trashbot",$dbconnect);

    // Prepare the SQL statement

    $sql = "INSERT INTO robot (Weight) VALUES ('".$_GET["weight"]."')";    

    // Execute SQL statement

    mysql_query($sql);

?>