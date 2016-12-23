<?php

	
?>

<html>
   <head>
      <title>Sensor Data</title>
	  <!-- Latest compiled and minified CSS -->
<link rel="stylesheet" href="css/bootstrap.min.css">

<!-- jQuery library -->
<script src="js/jquery.min.js"></script>

<!-- Latest compiled JavaScript -->
<script src="js/bootstrap.min.js"></script>

<script type="text/javascript" src="https://www.google.com/jsapi"></script>
	  <script type="text/javascript">
	  var d=0;
	  
	  setInterval(liveTemp, 1000);
function liveTemp() {
  var xhttp = new XMLHttpRequest();
  xhttp.onreadystatechange = function() {
    if (xhttp.readyState == 4 && xhttp.status == 200) {
		d=xhttp.responseText;
      document.getElementById("temperature").innerHTML = xhttp.responseText+" &deg;C";
    }
  }
  xhttp.open("GET", "temperature.php", true);
  xhttp.send();
}

function turnON()
{
  var xhttp1 = new XMLHttpRequest();
  xhttp1.onreadystatechange = function() {
    if (xhttp1.readyState == 4 && xhttp1.status == 200) {
		d=xhttp1.responseText;
      document.getElementById("statusRefrig").innerHTML = xhttp1.responseText;
    }
  }
  xhttp1.open("GET", "turnON.php", true);
  xhttp1.send();
}
</script>



    <script type="text/javascript">
      google.load("visualization", "1", {packages:["gauge"]});
      google.setOnLoadCallback(drawChart1);
      function drawChart1() {

        var data1 = google.visualization.arrayToDataTable([
          ['Label', 'Value'],
          ['Temperature', 25],
        ]);
        var tempOptions1 = {
          width: 300, height: 300,
          redFrom: 45, redTo: 60,
          yellowFrom:30, yellowTo: 45,
          minorTicks: 10,
		  max: 60,
		  min: -30,
        };
        var chart1 = new google.visualization.Gauge(document.getElementById('chart_div'));
        chart1.draw(data1, tempOptions1);
        setInterval(function() {
          data1.setValue(0, 1,d);
          chart1.draw(data1, tempOptions1);
        }, 1000);
      }
	  
	 
    </script>
	<script type="text/javascript">
		 var count=0;
	google.load('visualization', '1.1', {packages: ['line']});
    google.setOnLoadCallback(drawChart2);

    function drawChart2() {

      var data2 = new google.visualization.DataTable();
      data2.addColumn('number', 'Count');
      data2.addColumn('number', 'Temperature');
      

      data2.addRows([
        [1, 0],
       
      ]);

      var options2 = {
        chart: {
          title: 'Temperature',
          subtitle: 'in Degree Celcius'
        },
        width: 900,
        height: 500
      };

      var chart2 = new google.charts.Line(document.getElementById('linechart_material'));
		chart2.draw(data2, options2);
		setInterval(function() {
		count++;
		data2.addRows([
		[count,parseInt(d)]
		]);
          chart2.draw(data2, options2);
          
        }, 1000);
      
     
    }
	</script>
   </head>
<body>

  <nav class="navbar navbar-default">
  <div class="container-fluid">
    <div class="navbar-header">
      <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#myNavbar">
        <span class="icon-bar"></span>
        <span class="icon-bar"></span>
        <span class="icon-bar"></span>                        
      </button>
      <a class="navbar-brand" href="#">Iot &amp; EA</a>
    </div>
    <div class="collapse navbar-collapse" id="myNavbar">
      <ul class="nav navbar-nav">
        <li class="active"><a href="#">Home</a></li>
        
        <li><a href="#">Warnings</a></li>
        <li><a href="#">Complete LOG</a></li>
      </ul>
      <ul class="nav navbar-nav navbar-right">
        <li><a href="#"><span class="glyphicon glyphicon-user"></span> Sign Up</a></li>
        <li><a href="#"><span class="glyphicon glyphicon-log-in"></span> Login</a></li>
      </ul>
    </div>
  </div>
</nav>
<div class="container">
	<center>
	<div class="refrigerator">
		<label>Device Status : </label>
		<div id="statusRefrig">
		</div>
		<br/>
		<Button class="btn btn-success" onclick="turnON()">Turn ON</Button>
		<Button class="btn btn-warning" onclick="turnOFF()">Turn OFF</Button>
	</div>
	</center>
</div>
<div class="container-fluid" style="margin-top:20px">
<div class="row">
<div class="col-sm-4">
<center>
	
   <div class="well">
		<h2> Current Temperature</h2>
   <div id="chart_div" style="width: 300px; height: 400px;"></div><button class="btn btn-primary" id="temperature">No data</button>
   </div>
   </center>
  </div>
  <div class="col-sm-8">
  <div class="well">
	<div id="linechart_material" style="width: 900px; height: 500px;">
	</div>
  </div>
  </div>
   
   </div>
</body>
</html>
