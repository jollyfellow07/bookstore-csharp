// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
Console.Write("Digita il titolo del libro: ");
string titolo = Console.ReadLine();

Console.Write("\n Digita l'autore del libro: ");
string autore = Console.ReadLine();

Console.Write("\n Digita l'isbn dell'articolo: ");
string isbn = Console.ReadLine();

Console.Write("\n Digita le pagine dell'articolo, sono ammessi solo valori numerici: ");
string pagine = Console.ReadLine();

Console.Write("\n Digita il peso dell'articolo in grammi: ");
string peso = Console.ReadLine();

Console.Write("\n Digita la lunghezza del libro, sono ammessi solo valori numerici: ");
string lunghezza = Console.ReadLine();

Console.Write("\n Digita lo spessore del libro, sono ammessi solo valori numerici: ");
string spessore = Console.ReadLine();

Console.Write("\n Digita l'altezza del libro, sono ammessi solo valori numerici: ");
string altezza = Console.ReadLine();

Console.Write("\n Digita la valutazione del libro che va da 0 a 5: ");
string valutazione = Console.ReadLine();

Console.Write("\n Digita il numero di recensioni che sono state effetuate: ");
string numeroRecensioni = Console.ReadLine();

Console.Write("\n è disponibile il formato kindle? ");
string kindle = Console.ReadLine();

Console.Write("\n è disponibile il formato con copertina flessibile? ");
string copertina = Console.ReadLine();

//conversioni stringhe in int
int.Parse(pagine);
int.Parse(peso);
int.Parse(numeroRecensioni);
//conversioni stringhe in float
float.Parse(lunghezza);
float.Parse(altezza);
float.Parse(spessore);
float.Parse(valutazione);
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

