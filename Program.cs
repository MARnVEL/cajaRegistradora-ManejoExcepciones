

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

// mostrar la cantidad de billetes de cada denominación actualmente en la caja.
ImprimirEstadoCaja(dineroEnCaja);

// mostrar un mensaje que indique la cantidad de efectivo en la caja
Console.WriteLine(ResumenCantidadEnCaja(dineroEnCaja));

// mostrar el total de dinero esperado de registroDineroDiarioInicial
Console.WriteLine($"Valor esperado en caja: {registroRevisionTotalCaja}");
Console.WriteLine();

var generadorValor = new Random((int)DateTime.Now.Ticks);

int transacciones = 100;

if (usarDatosPrueba)
{
    transacciones = datosPrueba.Length;
}

while(transacciones > 0)
{
    // transacciones = transacciones - 1;
    // transacciones--;
    transacciones -= 1;

    int costoItem = generadorValor.Next(2,50);

    if (usarDatosPrueba)
    {
        costoItem = datosPrueba[contadorPrueba];
        contadorPrueba += 1;
    }

    // ! el valor es 1 cuando costoItem es impar, el valor es 0 cuando costoItem es par
    int pagoEnBilletesDeUno = costoItem % 2;

    // ! el valor es 1 cuando costoItem termina en 8 o 9, de otra forma el valor es 0
    int pagoEnBilletesDeCinco = (costoItem % 10 > 7) ? 1 : 0;

    // ! el valor es 1 cuando 13 < costoItem < 20 O 33 < costoItem < 40, de otra forma el valor es 0
    int pagoEnBilletesDeDiez = (costoItem % 20 > 13) ? 1 : 0;

    // ! el valor es 1 cuando costoItem < 20, de otra forma el valor es 2.
    int pagoEnBilletesDeVeinte = (costoItem < 20) ? 1 : 2;

    // mostramos un mensaje describiendo la transacción actual realizada
    Console.WriteLine($"El cliente está haciendo una compra de {costoItem}");
    Console.WriteLine($"\t Usando {pagoEnBilletesDeVeinte} billetes de veinte pesos");
    Console.WriteLine($"\t Usando {pagoEnBilletesDeDiez} billetes de diez pesos");
    Console.WriteLine($"\t Usando {pagoEnBilletesDeCinco} billetes de cinco pesos");
    Console.WriteLine($"\t Usando {pagoEnBilletesDeUno} billetes de un peso");

    try
    {
        // ! GenerarVuelto gestiona la transacción y actualiza la caja.
        GenerarVuelto(
            costoItem, 
            dineroEnCaja, 
            pagoEnBilletesDeVeinte, 
            pagoEnBilletesDeDiez, 
            pagoEnBilletesDeCinco, 
            pagoEnBilletesDeUno
        );

        // cálculo de respaldo: cada transacción agrega el "costoItem" actual a la caja
        registroRevisionTotalCaja += costoItem;

    }
    catch (InvalidOperationException e)
    {
        Console.WriteLine($"No se pudo completar la transacción: {e.Message}");
    }

    Console.WriteLine(ResumenCantidadEnCaja(dineroEnCaja));
    Console.WriteLine($"Valor esperado en la caja: {registroRevisionTotalCaja}");
    Console.WriteLine();
}

Console.WriteLine("Presione la tecla Enter para salir");
do
{
    leerResultado = Console.ReadLine();

} while (leerResultado == null);

static void GenerarVuelto(int costo, int[] dineroEnCaja, int veintes, int dieces = 0, int cincos = 0, int unos = 0)
{

}

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






