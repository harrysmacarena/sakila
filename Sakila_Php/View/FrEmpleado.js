empleado = new Empleado();

function Empleado(){

	
	//*************************
	this.fuLeer = function(){
	     // Podemos Separar en 4 archivos, sin embargo reutilizaremos el MVC
         // Simulamos enviar el boton con cualquier valor
		 // Cambiamos los nombres de los parámetros con el objetivo
		 //     de entender que los nombres de las variables pueden ser diferentes
	     // var data = ventana.cmdPost("/Neg/FrEmpleadoLeer.php"
		 // Ejecuta un Archivo Php y el resultado queda en data
	     var data = ventana.cmdPost("/MVC/EmpleadoMVCAjax.php"
                           ,"parId=" + document.getElementById("txId").value
                           + "&btBuscar=1"
                           );
		 // Por medio del Objeto data recuperamos los datos
		 // y Uno a Uno los desplegamos en los campos correspondientes
		 // por medio del getElementById("").value
               document.getElementById("txNombre").value = data.nombre;
               document.getElementById("txSalario").value = data.salario;
               document.getElementById("txDescripcion").value = data.descripcion;
	}
	
	//*************************
	this.fuActualizar = function(){
	     //var data = ventana.cmdPost("/Neg/FrEmpleadoActualizar.php"
	     var data = ventana.cmdPost("/MVC/EmpleadoMVCAjax.php"
                           ,"parId=" + document.getElementById("txId").value
                         + "&parNombre=" + document.getElementById("txNombre").value
                         + "&parSalario=" + document.getElementById("txSalario").value
                         + "&parDescripcion=" + document.getElementById("txDescripcion").value
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
	     //var data = ventana.cmdPost("/Neg/FrEmpleadoEliminar.php"
	     var data = ventana.cmdPost("/MVC/EmpleadoMVCAjax.php"
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
	     //var data = ventana.cmdPost("/Neg/FrEmpleadoBuscar.php"
	     var data = ventana.cmdPost("/MVC/EmpleadoMVCAjax.php"
                           ,"parId=" + document.getElementById("txId").value
                         + "&btListar=1"
                           );
	}
	
}
