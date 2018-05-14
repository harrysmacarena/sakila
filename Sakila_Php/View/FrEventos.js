eventos = new Eventos();

function Eventos(){

	
	//*************************
	this.fuLeer = function(){
	     // Podemos Separar en 4 archivos, sin embargo reutilizaremos el MVC
         // Simulamos enviar el boton con cualquier valor
		 // Cambiamos los nombres de los parámetros con el objetivo
		 //     de entender que los nombres de las variables pueden ser diferentes
	     // var data = ventana.cmdPost("/Neg/FrEventosLeer.php"
		 // Ejecuta un Archivo Php y el resultado queda en data
	     var data = ventana.cmdPost("/MVC/EventosMVCAjax.php"
                           ,"parId=" + document.getElementById("txId").value
                           + "&btBuscar=1"
                           );
		 // Por medio del Objeto data recuperamos los datos
		 // y Uno a Uno los desplegamos en los campos correspondientes
		 // por medio del getElementById("").value
               document.getElementById("txTitle").value = data.title;
               document.getElementById("txBody").value = data.body;
               document.getElementById("txUrl").value = data.url;
               document.getElementById("txClass").value = data.class;
               document.getElementById("txStart").value = data.start;
               document.getElementById("txEnd").value = data.end;
               document.getElementById("txInicioNormal").value = data.inicioNormal;
               document.getElementById("txFinalNormal").value = data.finalNormal;
	}
	
	//*************************
	this.fuActualizar = function(){
	     //var data = ventana.cmdPost("/Neg/FrEventosActualizar.php"
	     var data = ventana.cmdPost("/MVC/EventosMVCAjax.php"
                           ,"parId=" + document.getElementById("txId").value
                         + "&parTitle=" + document.getElementById("txTitle").value
                         + "&parBody=" + document.getElementById("txBody").value
                         + "&parUrl=" + document.getElementById("txUrl").value
                         + "&parClass=" + document.getElementById("txClass").value
                         + "&parStart=" + document.getElementById("txStart").value
                         + "&parEnd=" + document.getElementById("txEnd").value
                         + "&parInicioNormal=" + document.getElementById("txInicioNormal").value
                         + "&parFinalNormal=" + document.getElementById("txFinalNormal").value
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
	     //var data = ventana.cmdPost("/Neg/FrEventosEliminar.php"
	     var data = ventana.cmdPost("/MVC/EventosMVCAjax.php"
                           ,"parId=" + document.getElementById("txId").value
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
	     //var data = ventana.cmdPost("/Neg/FrEventosBuscar.php"
	     var data = ventana.cmdPost("/MVC/EventosMVCAjax.php"
                           ,"parId=" + document.getElementById("txId").value
                         + "&btListar=1"
                           );
	}
	
}
