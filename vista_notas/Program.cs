using lib_salones.implementaciones;


var Conexion = new Conexion();
Conexion.StringConnection = "server=localhost;database=db_colegios;Integrated Security=True;TrustServerCertificate=true;";
var lista = Conexion.Salones!.ToList();

Console.WriteLine("Hello, World!");