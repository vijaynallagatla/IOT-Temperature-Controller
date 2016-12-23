<?php 
include("connect.php");

$result=mysqli_query($conn,"SELECT * FROM `data` ORDER BY `id` DESC LIMIT 1");
while($row = mysqli_fetch_array($result))
echo $row["temp"];
?>