actor = new Actor();

function Actor(){

	
	//*************************
	this.fuLeer = function(){
	     // Podemos Separar en 4 archivos, sin embargo reutilizaremos el MVC
         // Simulamos enviar el boton con cualquier valor
		 // Cambiamos los nombres de los parámetros con el objetivo
		 //     de entender que los nombres de las variables pueden ser diferentes
	     // var data = ventana.cmdPost("/Neg/FrActorLeer.php"
		 // Ejecuta un Archivo Php y el resultado queda en data
	     var data = ventana.cmdPost("/MVC/ActorMVCAjax.php"
                           ,"parActorId=" + document.getElementById("txActorId").value
                           + "&btBuscar=1"
                           );
		 // Por medio del Objeto data recuperamos los datos
		 // y Uno a Uno los desplegamos en los campos correspondientes
		 // por medio del getElementById("").value
               document.getElementById("txFirstName").value = data.firstName;
               document.getElementById("txLastName").value = data.lastName;
               document.getElementById("txLastUpdate").value = data.lastUpdate;
	}
	
	//*************************
	this.fuActualizar = function(){
	     //var data = ventana.cmdPost("/Neg/FrActorActualizar.php"
	     var data = ventana.cmdPost("/MVC/ActorMVCAjax.php"
                           ,"parActorId=" + document.getElementById("txActorId").value
                         + "&parFirstName=" + document.getElementById("txFirstName").value
                         + "&parLastName=" + document.getElementById("txLastName").value
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
	     //var data = ventana.cmdPost("/Neg/FrActorEliminar.php"
	     var data = ventana.cmdPost("/MVC/ActorMVCAjax.php"
                           ,"parActorId=" + document.getElementById("txActorId").value
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
	     //var data = ventana.cmdPost("/Neg/FrActorBuscar.php"
	     var data = ventana.cmdPost("/MVC/ActorMVCAjax.php"
                           ,"parActorId=" + document.getElementById("txActorId").value
                         + "&btListar=1"
                           );
	}
	
}
