language = new Language();

function Language(){

	
	//*************************
	this.fuLeer = function(){
	     // Podemos Separar en 4 archivos, sin embargo reutilizaremos el MVC
         // Simulamos enviar el boton con cualquier valor
		 // Cambiamos los nombres de los parámetros con el objetivo
		 //     de entender que los nombres de las variables pueden ser diferentes
	     // var data = ventana.cmdPost("/Neg/FrLanguageLeer.php"
		 // Ejecuta un Archivo Php y el resultado queda en data
	     var data = ventana.cmdPost("/MVC/LanguageMVCAjax.php"
                           ,"parLanguageId=" + document.getElementById("txLanguageId").value
                           + "&btBuscar=1"
                           );
		 // Por medio del Objeto data recuperamos los datos
		 // y Uno a Uno los desplegamos en los campos correspondientes
		 // por medio del getElementById("").value
               document.getElementById("txName").value = data.name;
               document.getElementById("txLastUpdate").value = data.lastUpdate;
	}
	
	//*************************
	this.fuActualizar = function(){
	     //var data = ventana.cmdPost("/Neg/FrLanguageActualizar.php"
	     var data = ventana.cmdPost("/MVC/LanguageMVCAjax.php"
                           ,"parLanguageId=" + document.getElementById("txLanguageId").value
                         + "&parName=" + document.getElementById("txName").value
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
	     //var data = ventana.cmdPost("/Neg/FrLanguageEliminar.php"
	     var data = ventana.cmdPost("/MVC/LanguageMVCAjax.php"
                           ,"parLanguageId=" + document.getElementById("txLanguageId").value
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
	     //var data = ventana.cmdPost("/Neg/FrLanguageBuscar.php"
	     var data = ventana.cmdPost("/MVC/LanguageMVCAjax.php"
                           ,"parLanguageId=" + document.getElementById("txLanguageId").value
                         + "&btListar=1"
                           );
	}
	
}
