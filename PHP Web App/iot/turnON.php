<?php 
include("connect.php");

$query = "INSERT INTO device (state) VALUES ('1')"; 
   	$res=mysqli_query($conn,$query);
   	if($res)
         echo "query successful";
        else
         echo "query failed";
	mysqli_close($conn);
?>