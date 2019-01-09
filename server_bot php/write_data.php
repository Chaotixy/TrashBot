<?php

    // Prepare variables for database connection
   
    $dbusername = "Robot";  // enter database username, I used "arduino" in step 2.2
    $dbpassword = "Test123";  // enter database password, I used "arduinotest" in step 2.2
    $server = "81.169.200.100,1433"; // IMPORTANT: if you are using XAMPP enter "localhost", but if you have an online website enter its address, ie."www.yourwebsite.com"

    // Connect to your database

    $dbconnect = mysql_pconnect($server, $dbusername, $dbpassword);
    $dbselect = mysql_select_db("test",$dbconnect);

    // Prepare the SQL statement

    $sql = "INSERT INTO Robot (Weight, bin_state) VALUES ('".$_GET["weight"]."', '".$_GET["bin_state"]."')";    

    // Execute SQL statement

    mysql_query($sql);

?>