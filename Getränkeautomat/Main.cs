
using System.Collections.Generic;

using System;

public class Main
{
    static void Main()
    {
        // PROGRAMM STARTS HERE
        GetraenkeListe liste = initializeGetraenkeListe();

        liste.printListe();

        bool exit = false;
        do
        {
            String input = getInput();

            if (liste.checkIfValidGetraenk(input))
            {
                int index = Int32.Parse(input) - 1;
                liste.kaufeGetraenk(index);
            }
            else if (input == "q")
            {
                Console.WriteLine("Das Programm wird beendet ...");
                exit = true;
            }
            else if (input == "m")
            {
                liste.printListe();
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe!\n'm' um das menü anzuzeigen und \n'q' um das Programm zu beenden");
            }

        } while (!exit);
    }

    private static GetraenkeListe initializeGetraenkeListe()
    {
        GetraenkeListe gl = new GetraenkeListe("Getraenke Liste 1");

        gl.addGetraenk(new Getraenk("Pepsi", 2, 10));
        gl.addGetraenk(new Getraenk("Cola", 2, 10));
        gl.addGetraenk(new Getraenk("Fanta", 1.5, 10));
        gl.addGetraenk(new Getraenk("Jägermeister", 3.14, 10));
        gl.addGetraenk(new Getraenk("Redbull", 2.99, 10));

        return gl;
    }

    private static String getInput()
    {
        Console.WriteLine("Geben Sie die Zahl des Getraenks ein, welches sie kaufen möchten");
        return Console.ReadLine();
    }

}


