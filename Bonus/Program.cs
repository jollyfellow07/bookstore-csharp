// See https://aka.ms/new-console-template for more information
//
Console.Write("Digita il titolo del libro: ");
string titolo = Console.ReadLine();
Console.Clear();

Console.Write(" Digita l'autore del libro: ");
string autore = Console.ReadLine();
Console.Clear();

Console.Write(" Digita l'isbn dell'articolo: ");
string isbn = Console.ReadLine();
Console.Clear();

Console.Write(" Digita le pagine dell'articolo, sono ammessi solo valori numerici: ");
int pagine = int.Parse(Console.ReadLine());
Console.Clear();

Console.Write(" Digita il peso dell'articolo in grammi: ");
int peso = int.Parse(Console.ReadLine());
Console.Clear();

Console.Write(" Digita la lunghezza del libro in centimetri, sono ammessi solo valori numerici: ");
float lunghezza = float.Parse(Console.ReadLine());
Console.Clear();

Console.Write(" Digita lo spessore del libro in centimetri, sono ammessi solo valori numerici: ");
float spessore = float.Parse(Console.ReadLine());
Console.Clear();

Console.Write(" Digita l'altezza del libro in centimetri, sono ammessi solo valori numerici: ");
float altezza = float.Parse(Console.ReadLine());
Console.Clear();

Console.Write(" Digita la valutazione del libro che va da 0 a 5: ");
float valutazione = float.Parse(Console.ReadLine());
Console.Clear();

Console.Write(" Digita il numero di recensioni che sono state effetuate: ");
int numeroRecensioni = int.Parse(Console.ReadLine());
Console.Clear();

Console.Write(" è disponibile il formato kindle? ");
string kindle = Console.ReadLine();
Console.Clear();

Console.Write(" è disponibile il formato con copertina flessibile? ");
string copertina = Console.ReadLine();
Console.Clear();

//stampa di tutta la descrizione
Console.WriteLine("Titolo: " + titolo + "\n");
Console.WriteLine("Autore: " + autore + "\n");
Console.WriteLine("isbn-13: " + isbn + "\n");
Console.WriteLine("Pagine: " + pagine + "\n");
Console.WriteLine("Dimensioni: " + lunghezza + " x " + altezza + " x " + spessore + " cm\n");
Console.WriteLine("Valutazione media: " + valutazione + " su 5\n");
Console.WriteLine("Numero di recensioni : " + numeroRecensioni + "\n");
Console.WriteLine("Disponibilità in kindle: " + kindle + "\n");
Console.WriteLine("Disponibilità con copertina flessibile : " + copertina);

//system pause finchè non diamo un input
Console.ReadKey();