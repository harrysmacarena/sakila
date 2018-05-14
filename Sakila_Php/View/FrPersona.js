persona = new Persona();

function Persona(){

	
	//*************************
	this.fuLeer = function(){
	     // Podemos Separar en 4 archivos, sin embargo reutilizaremos el MVC
         // Simulamos enviar el boton con cualquier valor
		 // Cambiamos los nombres de los parámetros con el objetivo
		 //     de entender que los nombres de las variables pueden ser diferentes
	     // var data = ventana.cmdPost("/Neg/FrPersonaLeer.php"
		 // Ejecuta un Archivo Php y el resultado queda en data
	     var data = ventana.cmdPost("/MVC/PersonaMVCAjax.php"
                           ,"parRut=" + document.getElementById("txRut").value
                           + "&btBuscar=1"
                           );
		 // Por medio del Objeto data recuperamos los datos
		 // y Uno a Uno los desplegamos en los campos correspondientes
		 // por medio del getElementById("").value
               document.getElementById("txDv").value = data.dv;
               document.getElementById("txNombres").value = data.nombres;
               document.getElementById("txEstatura").value = data.estatura;
               document.getElementById("txSexo").value = data.sexo;
               document.getElementById("txEsCasado").value = data.esCasado;
               document.getElementById("txEmilia").value = data.emilia;
               document.getElementById("txAriel").value = data.ariel;
	}
	
	//*************************
	this.fuActualizar = function(){
	     //var data = ventana.cmdPost("/Neg/FrPersonaActualizar.php"
	     var data = ventana.cmdPost("/MVC/PersonaMVCAjax.php"
                           ,"parRut=" + document.getElementById("txRut").value
                         + "&parDv=" + document.getElementById("txDv").value
                         + "&parNombres=" + document.getElementById("txNombres").value
                         + "&parEstatura=" + document.getElementById("txEstatura").value
                         + "&parSexo=" + document.getElementById("txSexo").value
                         + "&parEsCasado=" + document.getElementById("txEsCasado").value
                         + "&parEmilia=" + document.getElementById("txEmilia").value
                         + "&parAriel=" + document.getElementById("txAriel").value
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
	     //var data = ventana.cmdPost("/Neg/FrPersonaEliminar.php"
	     var data = ventana.cmdPost("/MVC/PersonaMVCAjax.php"
                           ,"parRut=" + document.getElementById("txRut").value
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
	     //var data = ventana.cmdPost("/Neg/FrPersonaBuscar.php"
	     var data = ventana.cmdPost("/MVC/PersonaMVCAjax.php"
                           ,"parRut=" + document.getElementById("txRut").value
                         + "&btListar=1"
                           );
	}
	
}
