<?php 
$serverName = "serverName";
$options = array(  "UID" => "Robot",  "PWD" => "Test123",  "Database" => "Trashbot");
$conn = sqlsrv_connect($serverName, $options);

if( $conn === false )
     {
     echo "Could not connect.\n";
     die( print_r( sqlsrv_errors(), true));
     }

$weight = $_POST['weight'];
$bin_state= $_POST['bin_state'];

$query = "INSERT INTO robot
        (weight,bin_state)
        VALUES(?, ?)";
$params1 = array($weight,$bin_state);                       
$result = sqlsrv_query($conn,$query,$params1);

sqlsrv_close($conn);
?>
