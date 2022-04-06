// See https://aka.ms/new-console-template for more information

Console.WriteLine("Di quanti alunni è composta la classe, da 1 a 10? ");

string sNumeroAlunni = "";

int NumeroAlunni = 0;

string sEta = "";

int iEta = 0;

string[] CopiaNomi = { };
string[] CopiaCognomi = {};
int[] CopiaEta = {};

do  
{
    sNumeroAlunni = Console.ReadLine();
} while (!int.TryParse(sNumeroAlunni,out NumeroAlunni) || NumeroAlunni>10);

string[] Nomi = new string[NumeroAlunni];

string[] Cognomi = new string[NumeroAlunni];

int[] Eta = new int[NumeroAlunni];

for (int i = 0; i < NumeroAlunni; i++)
{
    InserisciAlunni(i);
}

StampaArrayAlunni(Cognomi, Nomi, Eta);

if (NumeroAlunni < 10)
{
    Console.WriteLine("Vuoi inserire un nuovo alunno? (si/no)");
    string RispostaUtente = Console.ReadLine();
    if (RispostaUtente=="si") 
    {
        CopiaNomi = new string[NumeroAlunni+1];
        CopiaCognomi = new string[NumeroAlunni + 1];
        CopiaEta = new int[NumeroAlunni + 1];
        for (int i = 0; i < Nomi.Length; i++)
        {
            CopiaNomi[i] = Nomi[i];
            CopiaCognomi[i] = Cognomi[i];  
            CopiaEta[i] = Eta[i];
        }
        Console.WriteLine("Nome: " + (NumeroAlunni+1) );
        CopiaNomi[NumeroAlunni] = Console.ReadLine();
        Console.WriteLine("Cognome: " + (NumeroAlunni + 1));
        CopiaCognomi[NumeroAlunni] = Console.ReadLine();
        Console.WriteLine("Età: " + (NumeroAlunni + 1));
        do
        {
            sEta = Console.ReadLine();
        } while (!int.TryParse(sEta, out iEta) || iEta > 40);
        CopiaEta[NumeroAlunni] = iEta;
        StampaArrayAlunni(CopiaCognomi, CopiaNomi, CopiaEta);
    }
}

Console.WriteLine("Vuoi togliere l'ultimo alunno inserito? (si/no)");
string RispostaUtente1 = Console.ReadLine();
if (RispostaUtente1 == "si")
{
    List<int> list = new List<int>(CopiaEta);
    list.RemoveAt(CopiaEta.Length - 1);
    CopiaEta = list.ToArray();

    List<string> list1 = new List<string>(CopiaCognomi);
    list1.RemoveAt(CopiaCognomi.Length - 1);
    CopiaCognomi = list1.ToArray();

    List<string> list2 = new List<string>(CopiaNomi);
    list2.RemoveAt(CopiaNomi.Length - 1);
    CopiaNomi = list2.ToArray();

    StampaArrayAlunni(CopiaCognomi, CopiaNomi, CopiaEta);
}

double risultato = sommaElementiArray(CopiaEta);
Console.WriteLine("L'età media della classe è " + risultato);

int maxValue = CopiaEta.Max();
Console.WriteLine("L'età dell' alunno più anziano è " + maxValue);

int minValue = CopiaEta.Min();
Console.WriteLine("L'età dell' alunno più giovane è " + minValue);

void InserisciAlunni (int i) 
{ 
 Console.WriteLine("Nome: " + (i + 1));
 Nomi[i] = Console.ReadLine();
 Console.WriteLine("Cognome: " + (i + 1));
 Cognomi[i] = Console.ReadLine();
 Console.WriteLine("Età: " + (i + 1));
do
{
    sEta = Console.ReadLine();
} while (!int.TryParse(sEta, out iEta) || iEta > 40);
Eta[i] = iEta;
}

void StampaArrayAlunni(string[] arrayCognomi, string [] arrayNomi, int [] arrayEta )
{
    Console.WriteLine("La classe è composta da: " + arrayCognomi.Length + " Alunni");
    for (int i = 0; i < arrayCognomi.Length; i++)
    {
  
            Console.Write(arrayCognomi[i] + " " + arrayNomi[i] + " " + arrayEta[i] + Environment.NewLine);
        }
 }

double sommaElementiArray(int[] array)
{
    double somma = 0;
    for (int i = 0; i < array.Length; i++)
    {
        somma = somma + array[i];
    }
    somma /= array.Length;
    return somma;
}


