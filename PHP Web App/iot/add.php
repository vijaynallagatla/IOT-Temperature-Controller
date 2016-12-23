<?php
   	include("connect.php");
   	
   	
          $t="";
$h="";
$d="";
	$t=$_REQUEST['temp'];
	$h=$_REQUEST['humid'];
	$d=$_REQUEST['date'];
	
        echo "temp ="; echo $t;echo $h; echo $d;
       $t=(string)$t;
       $h=(string)$h;
       $d=(string)$d;
	$query = "INSERT INTO data (temp,humid,date) VALUES ('$t','$h','$d')"; 
   	$res=mysqli_query($conn,$query);
   	if($res)
         echo "query successful";
        else
         echo "query failed";
	mysqli_close($conn);

   	//header("Location: index.php");
?>
	