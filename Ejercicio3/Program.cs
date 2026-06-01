using Ejercicio_3_sobrecarga_y_encapsulamiento;
Console.WriteLine("Ingrese la potencia: ");
int potencia = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el tiempo (en segundos)");
int tiempoSegundos = int.Parse(Console.ReadLine());
Microondas microondas1 = new Microondas(potencia, tiempoSegundos);

while (true)
{
    Console.Clear();
    if (microondas1.PuertaAbierta)
    {
        Console.WriteLine($"Puerta: Abierta | Potencia: {microondas1.Potencia}");
    }
    else
    {
        Console.WriteLine($"Puerta: Cerrada | Potencia: {microondas1.Potencia}");
    }
    Console.WriteLine("=============================================================");
    Console.WriteLine($"Tiempo: {microondas1.Pantalla_Tiempo}");
    Console.WriteLine("=============================================================");
    Console.WriteLine("[1] Abrir o cerrar puerta");
    Console.WriteLine("[2] Agregar tiempo");
    Console.WriteLine("[3] Botón rápido");
    Console.WriteLine("[4] Iniciar");
    Console.WriteLine("[5] Detener");
    Console.WriteLine("[0] Salir del simulador");
    Console.WriteLine("=============================================================");
    Console.WriteLine("Seleccióne una opción del menú:_");
    int op = int.Parse(Console.ReadLine());
    switch (op)
    {
        case 0:
            return;
        case 1:
            microondas1.AbrirCerrarPuerta();
            break;
        case 2:
            Console.WriteLine("Ingrese cuantos segundos quiere agragar");
            int segundos = int.Parse(Console.ReadLine());
            microondas1.AgregarTiempo(segundos);
            break;
        case 3:
            microondas1.AgregarTiempo();
            break;
        case 4:
            microondas1.Iniciar();
            break;
        case 5:
            microondas1.Detener();
            break;
        default:
            Console.WriteLine("Opción inválida");
            break;
    }
    Console.WriteLine("\nSeleccione cualquier letra para continuar");
    Console.ReadKey();
}