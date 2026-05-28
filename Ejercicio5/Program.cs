using Ejercicio_5_sobrecarga_y_encapsulamiento;
Console.WriteLine("Ingrese el porcentaje de bateria: ");
int bateria = int.Parse(Console.ReadLine());
Batería bateria1 = new Batería();
bateria1.PorcentajeCarga = bateria;

bateria1.SaludBateria = 100;
while (true)
{
    Console.Clear();
    Console.WriteLine("=============================================================");
    Console.WriteLine($"Estado: {bateria1.Estado_Texto}");
    Console.WriteLine("=============================================================");
    if (bateria1.ModoAhorroEnergia)
    {
        Console.WriteLine($"El modo de ahorro de energía esta activo");
    }
    else
    {
        Console.WriteLine($"El modo de ahorro de energía esta inactivo");
    }
    
    Console.WriteLine("[1] Conectar o desconectar el cargador");
    Console.WriteLine("[2] Usar el teléfono en reposo");
    Console.WriteLine("[3] Abrir una app pesada");
    Console.WriteLine("[4] Simular el paso del tiempo conectado al cargador");
    Console.WriteLine("[0] Salir del simulador");
    Console.WriteLine("=============================================================");
    Console.WriteLine("Seleccióne una opción del menú:_");
    int op = int.Parse(Console.ReadLine());
    switch (op)
    {
        case 0:
            return;
        case 1:
            bateria1.AlternarCargador();
            break;
        case 2:
            bateria1.ConsumirEnergia();
            break;
        case 3:
            Console.WriteLine("Ingrese cuanta bateria consume");
            int app = int.Parse(Console.ReadLine());
            bateria1.ConsumirEnergia(app);
            break;
        case 4:
            bateria1.CicloDeCarga();
            break;
        default:
            Console.WriteLine("Opción inválida");
            break;
    }
    Console.WriteLine("\nSeleccione cualquier letra para continuar");
    Console.ReadKey();
}

