// Paros szamok osszege

Console.WriteLine("Az intervallum also vegpontja: ");
int also = int.Parse(Console.ReadLine());

Console.WriteLine("Az intervallum felso vegpontja: ");
int felso = int.Parse(Console.ReadLine());

int osszeg = 0;

for (int i = also; i <= felso; i++)
{
    if (i % 2 == 0)
    {
        osszeg += i;
    }

}

Console.WriteLine($"A(z) [{also}; {felso}] intervallumba eso paros szamok osszege: {osszeg}");

// Prima

Console.WriteLine("Add meg a csoki gyártási számát: ");
int szam = int.Parse(Console.ReadLine());

bool prim = true;

for (int i = 2; i <= 10; i++)
{
    if (szam == 1)
    { prim = false;
        break;
    }
    if (szam != i)
    {
        if (szam % i == 0)
        {
            prim = false;
        }
    }
}
;

Console.WriteLine($"Nyertel-e: {prim}");

// Nem sikerult befejezni.