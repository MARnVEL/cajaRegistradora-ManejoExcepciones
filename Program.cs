

string? leerResultado = null;
bool usarDatosPrueba = false;

Console.Clear();

int[] dineroEnCaja = [ 0, 0, 0, 0 ];
int registroRevisionTotalCaja = 0;

// registroDineroDiarioInicial: $1 x 50, $5 x 20, $10 x 10, $20 x 5 => ($350 total)
int[,] registroDineroDiarioInicial = new int[,] { { 1, 50 }, { 5, 20 }, { 10, 10 }, { 20, 5 } };

int[] datosPrueba = [ 6, 10, 17, 20, 31, 36, 40, 41 ];
int contadorPrueba = 0;

CargarCajaCadaManana(registroDineroDiarioInicial, dineroEnCaja);

registroRevisionTotalCaja = registroDineroDiarioInicial[0, 0] * registroDineroDiarioInicial[0, 1] + registroDineroDiarioInicial[1, 0] * registroDineroDiarioInicial[1, 1] + registroDineroDiarioInicial[2, 0] * registroDineroDiarioInicial[2, 1] + registroDineroDiarioInicial[3, 0] * registroDineroDiarioInicial[3, 1];

// mostrar el número de billetes de cada denominación actualmente en la caja.
ImprimirEstadoCaja(dineroEnCaja);

// mostrar un mensaje que indique la cantidad de efectivo en la caja
Console.WriteLine(ResumenCantidadEnCaja(dineroEnCaja));

// mostrar el total esperado de registroDineroDiarioInicial
Console.WriteLine($"Valor esperado en caja: {registroRevisionTotalCaja}");
Console.WriteLine();

var generadorValor = new Random((int)DateTime.Now.Ticks);

int transacciones = 100;

if (usarDatosPrueba)
{
    transacciones = datosPrueba.Length;
}


Console.WriteLine("Presione la tecla Enter para salir");
do
{
    leerResultado = Console.ReadLine();

} while (leerResultado == null);



static string ResumenCantidadEnCaja(int[] dineroEnCaja)
{
    return $"La caja tiene {dineroEnCaja[3] * 20 + dineroEnCaja[2] * 10 + dineroEnCaja[1] * 5 + dineroEnCaja[0]} pesos";
}

static void ImprimirEstadoCaja(int[] dineroEnCaja)
{
    Console.WriteLine("La caja tiene actualmente:");
    Console.WriteLine($"{dineroEnCaja[3] * 20} en billetes de veinte");
    Console.WriteLine($"{dineroEnCaja[2] * 10} en billetes de diez");
    Console.WriteLine($"{dineroEnCaja[1] * 5} en billetes de cinco");
    Console.WriteLine($"{dineroEnCaja[0]} en billetes de uno");
    Console.WriteLine();
}

static void CargarCajaCadaManana(int[,] registroDineroDiarioInicial, int[] dineroEnCaja)
{
    dineroEnCaja[0] = registroDineroDiarioInicial[0, 1];
    dineroEnCaja[1] = registroDineroDiarioInicial[1, 1];
    dineroEnCaja[2] = registroDineroDiarioInicial[2, 1];
    dineroEnCaja[3] = registroDineroDiarioInicial[3, 1];
}






