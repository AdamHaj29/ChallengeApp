
using System.Security.Cryptography.X509Certificates;


    double liczba = 10011556987;
    string numberInString = liczba.ToString();
    char[] znaki = numberInString.ToArray();
    char[] cyfra = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    int[] licznik = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    for (int i = 0; i < znaki.Length; i++)
    {
        for (int z = 0; z < cyfra.Length; z++)
        {
            if (znaki[i] == cyfra[z])
            {
                licznik[z]++;

            }

        }
         

    }

    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine("Cyfr  " + i + " jest " + (licznik[i]));
    }
    
