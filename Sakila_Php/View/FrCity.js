city = new City();

function City(){

	
	//*************************
	this.fuLeer = function(){
	     // Podemos Separar en 4 archivos, sin embargo reutilizaremos el MVC
         // Simulamos enviar el boton con cualquier valor
		 // Cambiamos los nombres de los parámetros con el objetivo
		 //     de entender que los nombres de las variables pueden ser diferentes
	     // var data = ventana.cmdPost("/Neg/FrCityLeer.php"
		 // Ejecuta un Archivo Php y el resultado queda en data
	     var data = ventana.cmdPost("/MVC/CityMVCAjax.php"
                           ,"parCityId=" + document.getElementById("txCityId").value
                           + "&btBuscar=1"
                           );
		 // Por medio del Objeto data recuperamos los datos
		 // y Uno a Uno los desplegamos en los campos correspondientes
		 // por medio del getElementById("").value
               document.getElementById("txCity").value = data.city;
               document.getElementById("txCountryId").value = data.countryId;
               document.getElementById("txLastUpdate").value = data.lastUpdate;
	}
	
	//*************************
	this.fuActualizar = function(){
	     //var data = ventana.cmdPost("/Neg/FrCityActualizar.php"
	     var data = ventana.cmdPost("/MVC/CityMVCAjax.php"
                           ,"parCityId=" + document.getElementById("txCityId").value
                         + "&parCity=" + document.getElementById("txCity").value
                         + "&parCountryId=" + document.getElementById("txCountryId").value
                         + "&parLastUpdate=" + document.getElementById("txLastUpdate").value
                         + "&btActualizar=1"
                           );
          if (data.okey){
		     alert(data.msg);
		  }
		  else {
		      alert(data.msg);
		  }						   
	}
	
	//*************************
	this.fuEliminar = function(){
	     //var data = ventana.cmdPost("/Neg/FrCityEliminar.php"
	     var data = ventana.cmdPost("/MVC/CityMVCAjax.php"
                           ,"parCityId=" + document.getElementById("txCityId").value
                         + "&btEliminar=1"
                           );
          if (data.okey){
		     alert(data.msg);
		  }
		  else {
		      alert(data.msg);
		  }						   
	}
	
	//*************************
	this.fuBuscar = function(){
	     //var data = ventana.cmdPost("/Neg/FrCityBuscar.php"
	     var data = ventana.cmdPost("/MVC/CityMVCAjax.php"
                           ,"parCityId=" + document.getElementById("txCityId").value
                         + "&btListar=1"
                           );
	}
	
}
