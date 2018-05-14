film = new Film();

function Film(){

	
	//*************************
	this.fuLeer = function(){
	     // Podemos Separar en 4 archivos, sin embargo reutilizaremos el MVC
         // Simulamos enviar el boton con cualquier valor
		 // Cambiamos los nombres de los parámetros con el objetivo
		 //     de entender que los nombres de las variables pueden ser diferentes
	     // var data = ventana.cmdPost("/Neg/FrFilmLeer.php"
		 // Ejecuta un Archivo Php y el resultado queda en data
	     var data = ventana.cmdPost("/MVC/FilmMVCAjax.php"
                           ,"parFilmId=" + document.getElementById("txFilmId").value
                           + "&btBuscar=1"
                           );
		 // Por medio del Objeto data recuperamos los datos
		 // y Uno a Uno los desplegamos en los campos correspondientes
		 // por medio del getElementById("").value
               document.getElementById("txTitle").value = data.title;
               document.getElementById("txDescription").value = data.description;
               document.getElementById("txReleaseYear").value = data.releaseYear;
               document.getElementById("txLanguageId").value = data.languageId;
               document.getElementById("txOriginalLanguageId").value = data.originalLanguageId;
               document.getElementById("txRentalDuration").value = data.rentalDuration;
               document.getElementById("txRentalRate").value = data.rentalRate;
               document.getElementById("txLength").value = data.length;
               document.getElementById("txReplacementCost").value = data.replacementCost;
               document.getElementById("txRating").value = data.rating;
               document.getElementById("txSpecialFeatures").value = data.specialFeatures;
               document.getElementById("txLastUpdate").value = data.lastUpdate;
	}
	
	//*************************
	this.fuActualizar = function(){
	     //var data = ventana.cmdPost("/Neg/FrFilmActualizar.php"
	     var data = ventana.cmdPost("/MVC/FilmMVCAjax.php"
                           ,"parFilmId=" + document.getElementById("txFilmId").value
                         + "&parTitle=" + document.getElementById("txTitle").value
                         + "&parDescription=" + document.getElementById("txDescription").value
                         + "&parReleaseYear=" + document.getElementById("txReleaseYear").value
                         + "&parLanguageId=" + document.getElementById("txLanguageId").value
                         + "&parOriginalLanguageId=" + document.getElementById("txOriginalLanguageId").value
                         + "&parRentalDuration=" + document.getElementById("txRentalDuration").value
                         + "&parRentalRate=" + document.getElementById("txRentalRate").value
                         + "&parLength=" + document.getElementById("txLength").value
                         + "&parReplacementCost=" + document.getElementById("txReplacementCost").value
                         + "&parRating=" + document.getElementById("txRating").value
                         + "&parSpecialFeatures=" + document.getElementById("txSpecialFeatures").value
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
	     //var data = ventana.cmdPost("/Neg/FrFilmEliminar.php"
	     var data = ventana.cmdPost("/MVC/FilmMVCAjax.php"
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
	     //var data = ventana.cmdPost("/Neg/FrFilmBuscar.php"
	     var data = ventana.cmdPost("/MVC/FilmMVCAjax.php"
                           ,"parFilmId=" + document.getElementById("txFilmId").value
                         + "&btListar=1"
                           );
	}
	
}
