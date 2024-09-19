using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        const string InitialMsg = "Si vols calcular les teves notes prem 1, si vols guardar una ciutat i el seu CP prem dos, i si vols sortir prem qualsevol altre tecla \n";

        
        while (true)
        {
            Console.WriteLine(InitialMsg);
            string opcio = Console.ReadLine();
            switch (opcio)
            {
                case "1":
                    CalcularNotes();
                    break;
                case "2":
                    GuardaCiutat();
                    break;
                default:
                    return;
            }
        }
        
       
        

    }

    public static void CalcularNotes()
    {
        const string PrimeraQualificacio = "Introdueix la primera qualificació\n";
        const string SegonaQualificacio = "Introdueix la segona qualificació\n";
        const string TerceraQualificacio = "Introdueix la tercera qualificació\n";
        int nota1 = 0, nota2 = 0, nota3 = 0;
        try
        {
            Console.WriteLine(PrimeraQualificacio);
            nota1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(SegonaQualificacio);
            nota2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(TerceraQualificacio);
            nota3 = Convert.ToInt32(Console.ReadLine());

            float promig = (nota1 + nota2 + nota3) / 3;

            string resultat = promig > 6 ? "Aprovat" : "Suspès";

            Console.WriteLine($"El promig de les notes es:  {promig} i està {resultat}\n");
        }
        catch
        {
            Console.WriteLine("Error, introdueix un valor vàlid\n");

        }
    }

    public static void GuardaCiutat()
    {
        const string NomCiutat = "Introdueix el nom de la ciutat\n";
        const string CodiPostal = "Introdueix el codi postal de la ciutat\n";
        string ciutat = "", codiPostal = "";
        try
        {
            Console.WriteLine(NomCiutat);
            ciutat = Console.ReadLine();

            Console.WriteLine(CodiPostal);
            codiPostal = Console.ReadLine();

            Console.WriteLine($"La ciutat {ciutat} amb codi postal {codiPostal} ha estat guardada correctament\n");
        }
        catch
        {
            Console.WriteLine("Error, introdueix un valor vàlid\n");

        }
    }
}

