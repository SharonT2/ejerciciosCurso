using System;
class Tipos

{
    static void Main(String[] args)
    {
        Console.WriteLine("Tipos de datos");
        //Tipo de .NET System.SByte ---> alias byte, de -128 a 127--->Entero con 8 bits
        //definidas de manera distinta.
        System.SByte ochoBitsSigno = 125;
        sbyte ochoBitSignoAlias = 125;
        Console.WriteLine("Ejemplo de tipo sbyte: " + ochoBitsSigno.ToString());
        Console.WriteLine("Ejemplo de tipo sbyte alias: " + ochoBitSignoAlias.ToString());

        //Tipo de .NET System.Byte ---> alias byte, de 0 a 225--->Entero con 8 bits sin signo
        //definidas de manera distinta.
        System.Byte ochoBitSinSigno = 245;
        byte ochoBitSinSignoAlias = 123;
        Console.WriteLine("Ejemplo de tipo byte: " + ochoBitSinSigno.ToString());
        Console.WriteLine("Ejemplo de tipo byte alias: " + ochoBitSinSignoAlias.ToString());




        //Tipo de .NET System.Int16 ---> alias short, de -32000 a 32767--->Entero 16 bits con signo
        //definidas de manera distinta.
        System.Int16 dieciseisBitConSigno = 20000;
        short dieciseisBitConSignoAlias = -20000;
        Console.WriteLine("Ejemplo de tipo short: " + dieciseisBitConSigno.ToString());
        Console.WriteLine("Ejemplo de tipo short alias: " + dieciseisBitConSignoAlias.ToString());

        //Tipo de .NET System.UInt16 ---> alias ushort, de 0 a 65535--->Entero 16 bits sin signo
        //definidas de manera distinta. 
        System.UInt16 dieciseisBitSinSigno = 54954;
        ushort dieciseisBitSinSignoAlias = 45784;
        Console.WriteLine("Ejemplo de tipo ushort: " + dieciseisBitSinSigno.ToString());
        Console.WriteLine("Ejemplo de tipo ushort alias: " + dieciseisBitSinSignoAlias.ToString());




        //Tipo de .NET System.Int32 ---> alias int, de -2147483648 a 2147483647--->Entero 32 bits con signo
        //definidas de manera distinta.
        System.Int32 treintaDosBitConSigno = 56789465;
        int treintaDosBitConSignoAlias = -21474864;
        Console.WriteLine("Ejemplo de tipo int: " + treintaDosBitConSigno.ToString());
        Console.WriteLine("Ejemplo de tipo int alias: " + treintaDosBitConSignoAlias.ToString());

        //Tipo de .NET System.UInt32 ---> alias uint, de 0 a 4294967295--->Entero 32 bits sin signo
        //definidas de manera distinta. 
        System.UInt32 treintaDosBitSinSigno = 54954;
        uint treintaDosBitSinSignoAlias = 45784;
        Console.WriteLine("Ejemplo de tipo uint: " + treintaDosBitSinSigno.ToString());
        Console.WriteLine("Ejemplo de tipo uint alias: " + treintaDosBitSinSignoAlias.ToString());





        //Tipo de .NET System.Int64 ---> alias long 64 bits con signo
        //definidas de manera distinta.
        System.Int64 sesentaCuatroDosBitConSigno = 56789465;
        long sesentaCuatroDosBitConSignoAlias = -21474864;
        Console.WriteLine("Ejemplo de tipo long: " + sesentaCuatroDosBitConSigno.ToString());
        Console.WriteLine("Ejemplo de tipo long alias: " + sesentaCuatroDosBitConSignoAlias.ToString());

        //Tipo de .NET System.Int64 ---> alias ulong 64 bits sin signo
        //definidas de manera distinta. 
        System.UInt64 sesentaCuatroDosBitSinSigno = 54954;
        ulong sesentaCuatroDosBitSinSignoAlias = 45784;
        Console.WriteLine("Ejemplo de tipo ulong: " + sesentaCuatroDosBitSinSigno.ToString());
        Console.WriteLine("Ejemplo de tipo ulong alias: " + sesentaCuatroDosBitSinSignoAlias.ToString());

    }



}   