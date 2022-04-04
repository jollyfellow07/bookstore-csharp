// See https://aka.ms/new-console-template for more information

//dichiarazione variabili
string titolo = "La coscienza di Zeno ";
string autore = "Italo Svevo";
string isbn = "978-8867581252";
int pagine = 266;
int peso = 580;
float lunghezza = 17.78f;
float spessore = 1.52f;
float altezza = 25.4f;
float valutazione = 4.4f;
int numeroRecensioni = 72;
string kindle = "No";
string copertina = "Si";

//stampo libro
Console.WriteLine("Titolo: " + titolo + "\n");
Console.WriteLine("Autore: " + autore + "\n");
Console.WriteLine("isbn-13: " + isbn + "\n");
Console.WriteLine("Pagine: " + pagine + "\n");
Console.WriteLine("Peso articolo: " + peso + " g\n");
Console.WriteLine("Dimensioni: " + lunghezza + " x " + altezza + " x " + spessore + " cm\n");
Console.WriteLine("Valutazione media: " + valutazione + " su 5\n");
Console.WriteLine("Numero di recensioni : " + numeroRecensioni + "\n");
Console.WriteLine("Disponibilità in kindle: " + kindle + "\n");
Console.WriteLine("Disponibilità con copertina flessibile : " + copertina);


//system pause finchè non diamo un input
Console.ReadKey();














