using Ejercicio_4_sobrecarga_y_encapsulamiento;
Console.WriteLine("Ingrese nombre del sector");
string nombreSector = Console.ReadLine();
Console.WriteLine("Ingrese tipo de cultivo");
string tipoCultivo = Console.ReadLine();
Console.WriteLine("Ingrese temperatura del sector");
int temperaturaSector = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese humedad del sector");
int humedadSector = int.Parse(Console.ReadLine());
Invernadero invernadero1 = new Invernadero();
invernadero1.NombreSector = nombreSector;
invernadero1.TipoCultivo = tipoCultivo;
invernadero1.TemperaturaActual = temperaturaSector;
invernadero1.HumedadSuelo = humedadSector;

while (true)
{
    Console.Clear();
    Console.WriteLine($"Reporte de Estado: \n {invernadero1.Reporte_Estado}");
    Console.WriteLine("========================================");
    Console.WriteLine($"Temperatura actual: {invernadero1.TemperaturaActual} | Humedad del piso: {invernadero1.HumedadSuelo}");
    string sistemaRiego = "";
    string sistemaCalefaccion = "";
    if (invernadero1.SistemaDeRiego)
    {
        sistemaRiego = "Activo";
    } else
    {
        sistemaRiego = "Inactivo";
    }
    if (invernadero1.Calefaccion)
    {
        sistemaCalefaccion = "Activo";
    }
    else
    {
        sistemaCalefaccion = "Inactivo";
    }
    Console.WriteLine($"Sistema de riego: {sistemaRiego} | Sistema de calefaccion: {sistemaCalefaccion}");
    Console.WriteLine("======================================== ");
    
    Console.WriteLine("[1] Forzar clima");
    Console.WriteLine("[2] Dejar pasar el tiempo");
    Console.WriteLine("[3] Ejecutar chequeo automático");
    Console.WriteLine("[0] Salir del simulador");
    Console.WriteLine("========================================");
    Console.WriteLine("Seleccione una opción del control: _");
    int op = int.Parse(Console.ReadLine());
    switch (op)
    {
        case 0:
            return;
        case 1:
            Console.WriteLine("Ingrese la humedad que quiera ingresar");
            int humedad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la temperatura que quiera agregar");
            int temperatura = int.Parse(Console.ReadLine());
            invernadero1.SimularClima(humedad, temperatura);
            break;

        case 2:
            invernadero1.SimularClima();
            break;

        case 3:
            invernadero1.ControlAutomatico();
            break;

        default:
            Console.WriteLine("Opción inválida");
            break;
    }
    Console.WriteLine("\n Seleccione cualquier letra para continuar");
    Console.ReadKey();
}
