using Ejercicio_2_sobrecarga_y_encapsulamiento;
Console.WriteLine("Ingrese la marca: ");
string marca = Console.ReadLine();
Console.WriteLine("¿De cuantas pulgadas es la TV?");
int pulgadas = int.Parse(Console.ReadLine());
Console.WriteLine("¿Tienes plan premium? (S/N)");
string respuestaPlan = Console.ReadLine();
bool planPremium;
if (respuestaPlan.ToUpper() == "S")
{
    planPremium = true;
}
else
{
    planPremium = false;
}
SmartTV tv1 = new SmartTV(marca, pulgadas, planPremium);

while (true)
{
    string volumen = "";
    if (tv1.Volumen <= 0)
    {
        volumen = "MUTE";
    } else
    {
        volumen = tv1.Volumen.ToString();
    }
    Console.Clear();
    Console.WriteLine($"Identificador de la Smart TV: {tv1.CodigoConfig}");
    Console.WriteLine("=============================================================");
    if (tv1.Encendido)
    {
        Console.WriteLine($"Tv: [ ON ] | Canal actual: {tv1.CanalActual} | Volumen: {volumen}");
    }
    else
    {
        Console.WriteLine("Tv: [ OFF ]");
    }
    Console.WriteLine("=============================================================");
    Console.WriteLine("[1] Encender o apagar televisor");
    Console.WriteLine("[2] Cambiar canal");
    Console.WriteLine("[3] Subir canal");
    Console.WriteLine("[4] Regular volumen");
    Console.WriteLine("[0] Salir del simulador");
    Console.WriteLine("=============================================================");
    Console.WriteLine("Seleccióne una opción del menú:_");
    int op = int.Parse(Console.ReadLine());
    switch (op)
    {
        case 0:
            return;
        case 1:
            tv1.Power();
            break;
        case 2:
            Console.WriteLine("Ingrese a que canal quiere cambiar");
            int canal = int.Parse(Console.ReadLine());
            tv1.CambiarCanal(canal);
            break;
        case 3:
            tv1.CambiarCanal();
            break;
        case 4:
            Console.WriteLine("¿Quiere subir o bajar el volumen? SUBIR / BAJAR");
            string respuesta = Console.ReadLine();
            bool cambio;
            if (respuesta.ToUpper() == "SUBIR")
            {
                cambio = true;
            }
            else
            {
                cambio = false;
            }
            tv1.RegularVolumen(cambio);
            break;
        default:
            Console.WriteLine("Opción inválida");
            break;
    }
    Console.WriteLine("\nSeleccione cualquier letra para continuar");
    Console.ReadKey();
}