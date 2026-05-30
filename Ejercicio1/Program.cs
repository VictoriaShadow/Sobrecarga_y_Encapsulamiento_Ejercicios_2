using Ejercicio_1_sobrecarga_y_encapsulamiento;

Console.WriteLine("========================================");
Console.WriteLine("   Ingrese datos del nuevo automóvil");
Console.WriteLine("========================================");
Console.WriteLine("Ingrese la marca: ");
string marca = Console.ReadLine();
Console.WriteLine("¿Tiene caja automatica? (S/N)");
string respuestaCajaAutomatica = Console.ReadLine();
bool cajaAutomatica;
if (respuestaCajaAutomatica.ToUpper() == "S")
{
    cajaAutomatica = true;
} else
{
    cajaAutomatica = false;
}
Automovil auto1 = new Automovil(marca, cajaAutomatica);
while (true)
{

    Console.Clear();
    Console.WriteLine($"Identificador del automovil: {auto1.Identificador}");
    Console.WriteLine("=============================================================");
    if (auto1.MotorEncendido)
    {
        string respuestaModo = "";
        if (auto1.ModoCrucero)
        {
            respuestaModo = "Activo";
        } else
        {
            respuestaModo = "Inactivo";
        }
        Console.WriteLine($"Motor: [ ON ] | Velocidad actual: {auto1.VelocidadActual}Km/h | Modo Crucero: {respuestaModo}");
    }
    else
    {
        Console.WriteLine("Motor: [ OFF ]");
    }
    Console.WriteLine("=============================================================");
    Console.WriteLine("[1] Encender o apagar motor");
    Console.WriteLine("[2] Acelerar");
    Console.WriteLine("[3] Frenar");
    Console.WriteLine("[4] Aceleración predeterminada");
    Console.WriteLine("[5] Freno en seco");
    Console.WriteLine("[6] Entrar en modo crucero");
    Console.WriteLine("[0] Salir del simulador");
    Console.WriteLine("=============================================================");
    Console.WriteLine("Seleccióne una opción del menú:_");
    int op = int.Parse(Console.ReadLine());
    switch (op){
        case 0:
        return;
        case 1:
            auto1.EncenderApagar();
            break;
        case 2:
            Console.WriteLine("Ingrese cuanto quiere acelerar");
            int km = int.Parse(Console.ReadLine());
            auto1.Acelerar(km);
            break;
        case 3:
            Console.WriteLine("Ingrese cuanto quiere desacelerar");
            int Fkm = int.Parse(Console.ReadLine());
            auto1.Frenar(Fkm);
            break;
        case 4:
            auto1.Acelerar();
            break;
        case 5:
            auto1.Frenar();
            break;
        case 6:
            auto1.ModoCrucero = true;
            break;
        default:
            Console.WriteLine("Opción inválida");
            break;
    }
    Console.WriteLine("\nSeleccione cualquier letra para continuar");
    Console.ReadKey();
}