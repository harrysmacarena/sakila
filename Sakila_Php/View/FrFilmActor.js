filmActor = new FilmActor();

function FilmActor(){

	
	//*************************
	this.fuLeer = function(){
	     // Podemos Separar en 4 archivos, sin embargo reutilizaremos el MVC
         // Simulamos enviar el boton con cualquier valor
		 // Cambiamos los nombres de los parámetros con el objetivo
		 //     de entender que los nombres de las variables pueden ser diferentes
	     // var data = ventana.cmdPost("/Neg/FrFilmActorLeer.php"
		 // Ejecuta un Archivo Php y el resultado queda en data
	     var data = ventana.cmdPost("/MVC/FilmActorMVCAjax.php"
                           ,"parActorId=" + document.getElementById("txActorId").value
                         + "&parFilmId=" + document.getElementById("txFilmId").value
                           + "&btBuscar=1"
                           );
		 // Por medio del Objeto data recuperamos los datos
		 // y Uno a Uno los desplegamos en los campos correspondientes
		 // por medio del getElementById("").value
               document.getElementById("txLastUpdate").value = data.lastUpdate;
	}
	
	//*************************
	this.fuActualizar = function(){
	     //var data = ventana.cmdPost("/Neg/FrFilmActorActualizar.php"
	     var data = ventana.cmdPost("/MVC/FilmActorMVCAjax.php"
                           ,"parActorId=" + document.getElementById("txActorId").value
                         + "&parFilmId=" + document.getElementById("txFilmId").value
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
	     //var data = ventana.cmdPost("/Neg/FrFilmActorEliminar.php"
	     var data = ventana.cmdPost("/MVC/FilmActorMVCAjax.php"
                           ,"parActorId=" + document.getElementById("txActorId").value
                         + "&parFilmId=" + document.getElementById("txFilmId").value
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
	     //var data = ventana.cmdPost("/Neg/FrFilmActorBuscar.php"
	     var data = ventana.cmdPost("/MVC/FilmActorMVCAjax.php"
                           ,"parActorId=" + document.getElementById("txActorId").value
                         + "&parFilmId=" + document.getElementById("txFilmId").value
                         + "&btListar=1"
                           );
	}
	
}
