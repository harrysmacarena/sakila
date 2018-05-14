filmText = new FilmText();

function FilmText(){

	
	//*************************
	this.fuLeer = function(){
	     // Podemos Separar en 4 archivos, sin embargo reutilizaremos el MVC
         // Simulamos enviar el boton con cualquier valor
		 // Cambiamos los nombres de los parámetros con el objetivo
		 //     de entender que los nombres de las variables pueden ser diferentes
	     // var data = ventana.cmdPost("/Neg/FrFilmTextLeer.php"
		 // Ejecuta un Archivo Php y el resultado queda en data
	     var data = ventana.cmdPost("/MVC/FilmTextMVCAjax.php"
                           ,"parFilmId=" + document.getElementById("txFilmId").value
                           + "&btBuscar=1"
                           );
		 // Por medio del Objeto data recuperamos los datos
		 // y Uno a Uno los desplegamos en los campos correspondientes
		 // por medio del getElementById("").value
               document.getElementById("txTitle").value = data.title;
               document.getElementById("txDescription").value = data.description;
	}
	
	//*************************
	this.fuActualizar = function(){
	     //var data = ventana.cmdPost("/Neg/FrFilmTextActualizar.php"
	     var data = ventana.cmdPost("/MVC/FilmTextMVCAjax.php"
                           ,"parFilmId=" + document.getElementById("txFilmId").value
                         + "&parTitle=" + document.getElementById("txTitle").value
                         + "&parDescription=" + document.getElementById("txDescription").value
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
	     //var data = ventana.cmdPost("/Neg/FrFilmTextEliminar.php"
	     var data = ventana.cmdPost("/MVC/FilmTextMVCAjax.php"
                           ,"parFilmId=" + document.getElementById("txFilmId").value
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
	     //var data = ventana.cmdPost("/Neg/FrFilmTextBuscar.php"
	     var data = ventana.cmdPost("/MVC/FilmTextMVCAjax.php"
                           ,"parFilmId=" + document.getElementById("txFilmId").value
                         + "&btListar=1"
                           );
	}
	
}
