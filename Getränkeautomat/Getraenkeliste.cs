
using System.Collections.Generic;

using System;

class GetraenkeListe
{

    private String name;

    private List<Getraenk> liste = new List<Getraenk>();

    public GetraenkeListe(String nameListe)
    {
        this.name = nameListe;
    }

    public void addGetraenk(Getraenk g)
    {
        this.liste.Add(g);
    }

    public void printListe()
    {
        Console.WriteLine("--------------------------------------------------------------------");
        Console.WriteLine("-> " + this.name);
        Console.WriteLine("--------------------------------------------------------------------");

        for (int i = 0; i < liste.Count; i++)
        {
            Console.WriteLine(i + 1 + ". Getraenk: " + liste[i].getName() + " kostet " + liste[i].getPreis() + "€ und ist noch " + liste[i].getAnzahl() + " mal vorhanden");
        }

        Console.WriteLine("--------------------------------------------------------------------");
    }

    public bool checkIfValidGetraenk(String input)
    {
        int auswahl;
        // check if valid integer
        if (!int.TryParse(input, out auswahl))
        {
            return false;
        }
        // check if valid Getraenk id
        if (auswahl <= this.liste.Count && auswahl >= 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public Getraenk getGetraenkByIndex(int index)
    {
        return liste[index];
    }

    public void kaufeGetraenk(int index)
    {
        // Getraenkekauf Ablauf

        Getraenk g = getGetraenkByIndex(index);
        Console.WriteLine("Sie haben '" + g.getName() + "' für " + g.getPreis() + "€ ausgewählt");

        double nochzuzahlen = g.getPreis();
        bool exit = false;
        do
        {
            String input = getGeldInput();

            if (checkIfValidDouble(input))
            {

                double eingabeBetrag = Double.Parse(input);

                if (eingabeBetrag > nochzuzahlen)
                {
                    double rückgeld = eingabeBetrag - nochzuzahlen;
                    Console.WriteLine("Sie haben zu viel eingezahlt, Ihr Wecheslgeld beträgt " + rückgeld + "€");
                    liste[index].verringereAnzahl(1);
                    exit = true;
                }
                else if (eingabeBetrag == nochzuzahlen)
                {
                    Console.WriteLine("Sie haben passend bezahlt!");
                    liste[index].verringereAnzahl(1);
                    exit = true;
                }
                else if (eingabeBetrag < nochzuzahlen)
                {
                    nochzuzahlen = nochzuzahlen - eingabeBetrag;
                    Console.WriteLine("Sie müssen noch " + nochzuzahlen + "€ bezahlen");
                }

            }
            else
            {
                Console.WriteLine("Ungültige Zahl!");
            }

        } while (!exit);

    }

    private String getGeldInput()
    {
        Console.WriteLine("Geben Sie bitte den Geldbetrag ein: (€)");
        return Console.ReadLine();
    }

    private bool checkIfValidDouble(String input)
    {
        return Double.TryParse(input, out _);
    }

}