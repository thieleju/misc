
using System.Collections.Generic;

using System;

class Getraenk
{
    private String name;
    private double preis;
    private int anzahl;

    public Getraenk(String nameGetraenk, double preisGetraenk, int anzahlGetraenk)
    {
        this.name = nameGetraenk;
        this.preis = preisGetraenk;
        this.anzahl = anzahlGetraenk;
    }

    public void verringereAnzahl(int i)
    {
        if (this.anzahl < i)
        {
            Console.WriteLine("Fehler, das Getraenk " + this.name + " ist nur noch " + this.anzahl + " mal vorhanden!");
        }
        else
        {
            this.anzahl -= i;
        }
    }

    public int getAnzahl()
    {
        return this.anzahl;
    }

    public double getPreis()
    {
        return this.preis;
    }

    public String getName()
    {
        return this.name;
    }
}