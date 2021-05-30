//------------------------------------------------------------------------------------------------------------------------------------
//Dateiname		: HelloWorld 
//Projekt		: kA
//Beschreibung	: Erste Versucher mit VS und C#
//Autoren		: Paul A.
//Erstellung	: 15.12.2020
//letzte Änd.	: 15.12.2020
//Fehler		: nicht bekannt
//Dokument		: AB1 Aufgabe_Einführung C# und VisualStudio .NET 15122020
//------------------------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace HelloWorld
{
	class Program
	{
		static void Main(string[] args)
		{
			//Hier gehört alles rein, was gemnacht werden soll
			Console.WriteLine("Hallo ATIW!");														//A1: Gib den Text "Hallo ATIW!" aus
			Console.WriteLine("Angemeldeter User: "+Environment.UserName);							//A3: Gibt aktuellen Username aus
			Console.WriteLine("Betriebssystem: "+Environment.OSVersion);							//A4: Gibt Betriebssystem aus
			Console.WriteLine("Aktuelles Datum: "+DateTime.Now.ToLongDateString());					//A3: Gibt aktuelles Datum aus
			Console.WriteLine("Aktuelle Uhrzeit: "+DateTime.Now.ToLongTimeString());				//A4: Gibt aktuelle Uhrzeit aus
			Console.ReadLine();
			Thread.Sleep(3000);																		//A5: Main Methode schläft 3Sek
			//Console.Clear();
			Console.ForegroundColor = ConsoleColor.Yellow;											//A5: Fordergrund Gelb
			Console.BackgroundColor = ConsoleColor.Blue;											//A5: Hintergrund Blau
			Console.Clear();																		//A5: Konsolenfenster säubern
			Console.SetCursorPosition(Console.WindowWidth / 2 - 9 / 2, Console.WindowHeight / 2);	//A5: Schrift mittig setzten
			Console.WriteLine("FERTIG!!!");															//A5: "FERTIG!!!" ausgeben
			Console.Beep(4000, 2000);																//A5: aksutisches Signal ausgeben
			Console.ReadLine();										
		}
		
	}
}

/*Aufgabe6:
 
	HelloWorld	enthält für jedes Projekt ein eigenes Verzeichnis
		
	
		Programm.cs Programmklasse mit der main Methode
		.csproj Information für speziell ein Projekt (externe Bibliotheken, Quelltext// Metainformationen)
	bin		
		Ergebnis der Übersetzung 
						entweder Debug oder Release
	obj
		all das, was für jede Datei einzeln übersetzt wird
		Hilfs- und Temporärdateien für den Übersetzungsvorgangs
	HelloWorld.sln Solutiondatei mit der man das Projekt am einfachsten öffnet
	.vs Datei = Versionsdateien


 */