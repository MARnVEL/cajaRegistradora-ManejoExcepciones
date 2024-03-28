# Gestión de vuelto en caja registradora. ConsoleApp

> Este proyecto se trata de una simple aplicación de consola creada con el **framework .NET**.
>
> El objetivo de este proyecto es realizar prácticas para aprender **C#** y el marco de
> trabajo **.NET-Core**.
>
> Mi interés central en este caso, es la gestión de excepciones utilizando el patrón `try-catch` y también practicar con las herramientas de depuración que pone a disposición **Visual Studio Code** para desarrollar con **.NET** utilizando el plugin *C# Dev Kit*.

## Sobre la APP

> Esta es una sencilla aplicación de consola que consiste en la *"gesión del vuelto"* de dinero de una caja registradora en un comercio.
>
> La aplicación gestiona transacciones en la línea de caja de una tienda.
>
> La línea de caja tiene una cajero (una persona), y el cajero tiene una caja registradora que se prepara con una cantidad de billetes cada mañana.
>
> La caja incluye billetes de cuatro denominaciones: $1, $5, $10 y $20.
>
> La caja se utiliza para proporcionar cambio al cliente durante la transacción.
>
> El costo del artículo es un número generado aleatoriamente entre 2 y 49.
>
> El cliente ofrece el pago basándose en un algoritmo que determina una cantidad de billetes en cada denominación.
>
> Cada día, la caja registradora se carga al comienzo del día. A medida que se producen las transacciones, la caja registradora se gestiona mediante un método denominado `MakeChange` (los pagos del cliente entran y el cambio que se devuelve al cliente sale).
>
> En el "programa principal" se realiza un cálculo de "verificación de seguridad" independiente que se utiliza para verificar la cantidad de dinero en la caja.
> Esta verificación de seguridad se utiliza para garantizar que la lógica del método `MakeChange` funcione como se esperaba.
>

## About the APP

> This is a simple console application that consists of *"change management"* of money from a cash register in a store.
>
> The application manages transactions at a store check-out line.
>
> The check-out line has a cash register (a person), and the register has a cash till that is prepared with a number of bills each morning.
>
> The till includes bills of four denominations: $1, $5, $10, and $20.
>
> The till is used to provide the customer with change during the transaction.
>
> The item cost is a randomly generated number between 2 and 49.
>
> The customer  offers payment based on an algorithm that determines a number of bills in each denomination.
>
> Each day, the cash till is loaded at the start of the day. As transactions occur, the cash till is managed in a method named `MakeChange` (customer  payments go in and the change returned to the customer comes out).
>
> A separate "safety check" calculation that's used to verify the amount of money in the till is performed in the "main program".
> This safety check is used to ensure that logic in the `MakeChange` method is working as expected.
>

## Tecnologías utilizadas:
<div align="center" style="display: flex">
      <span>
         <a href="https://learn.microsoft.com/en-us/dotnet/csharp/" target="_blank">
               <img width="100" style="margin: 10" title='cSharp' src='https://upload.wikimedia.org/wikipedia/commons/4/4f/Csharp_Logo.png'>
         </a>
      </span>
      <span>
         <a href="https://learn.microsoft.com/en-us/dotnet/" target="_blank" title='dotNET'>
               <img width="100" style="margin: 10" title='dotNET' src='https://upload.wikimedia.org/wikipedia/commons/e/ee/.NET_Core_Logo.svg'>
         </a>
      </span>
</div>

## Requerimientos

- Tener intalado el sdk **dotNET 8** (<https://dotnet.microsoft.com/en-us/download>).
- Tener instalado **Git**.

## Usos

### Para ejecutar o utilizar el proyecto debes clonar este repositorio en un directorio de tu sistema. Abre una terminal y ejecuta el siguiente comando

```bash
git clone https://github.com/MARnVEL/cajaRegistradora-ManejoExcepciones.git
```

### Con una terminal localizarse en el directorio del proyecto que contiene el fichero `Program.cs`

> De acuerdo a tu sistema podría variar, pero el directorio se parece a lo siguiente:
> `C:<direcotrio_donde_se_clono_el_proyecto>\cajaRegistradora-ManejoExcepciones\`

### Ejecutar

```bash
dotnet build
```

#### Se crearán un par de directorios con los binarios necesarios para la correcta ejecución del sofware

### Para correr el proyecto debes dirigirte al directorio `C:<direcotrio_donde_se_clono_el_proyecto>\cajaRegistradora-ManejoExcepciones\bin\Debug\net8.0\`

### Abrir/Ejecutar el fichero `cajaRegistradora-ManejoExcepciones.exe`
