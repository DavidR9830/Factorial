
int casos, num, cantidadCeros, calCincos;

Console.WriteLine("Inserte el número de casos");
casos = int.Parse(Console.ReadLine());
for (int i = 0; i < casos; i++)
{
    Console.WriteLine("ingrese un número");
    num = int.Parse(Console.ReadLine());
    cantidadCeros = 0;
    calCincos = num / 5;
    
    
   Console.WriteLine( "El factorial del número " + num + " contiene " + calcular (cantidadCeros,calCincos) + " ceros consecutivos a la derecha");
}

static int calcular (int cantidadCeros, int calCincos)
{
    while (calCincos > 0)
    {
        cantidadCeros += calCincos;
        calCincos /= 5;
    }
    return cantidadCeros;
}







    