// See https://aka.ms/new-console-template for more information

Console.WriteLine("Di quanti alunni è composta la classe, da 1 a 10? ");

string sNumeroAlunni = "";

int NumeroAlunni = 0;

string sEta = "";

int iEta = 0;

do  
{
    sNumeroAlunni = Console.ReadLine();
} while (!int.TryParse(sNumeroAlunni,out NumeroAlunni) || NumeroAlunni>10);

string[] Nomi = new string[NumeroAlunni];

string[] Cognomi = new string[NumeroAlunni];

int[] Eta = new int[NumeroAlunni];

for (int i = 0; i < NumeroAlunni; i++)
{
    Console.WriteLine("Nome: " + (i+1));
    Nomi[i] = Console.ReadLine();
    Console.WriteLine("Cognome: " + (i+1));
    Cognomi[i] = Console.ReadLine();
    Console.WriteLine("Età: " + (i+1));
    do
    {
        sEta = Console.ReadLine();
    } while (!int.TryParse(sEta, out iEta) || iEta > 40);
    Eta[i] = iEta;
}

StampaArrayAlunni(Cognomi, Nomi, Eta);

void StampaArrayAlunni(string[] arrayCognomi, string [] arrayNomi, int [] arrayEta )
{
    Console.WriteLine("La classe è composta da: " + arrayCognomi.Length + " Alunni");
    for (int i = 0; i < arrayCognomi.Length; i++)
    {
  
            Console.Write(arrayCognomi[i] + " " + arrayNomi[i] + " " + arrayEta[i] + Environment.NewLine);
        }
 }
