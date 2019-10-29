using System;

public class Car
{

    private double pojemnoscSilnika;
    private string marka;
    static int iloscKol;
	private Car()
	{

    }

    private Car(double pojemnoscSilnika, string marka)
    {

        this.pojemnoscSilnika = pojemnoscSilnika;
        this.marka = marka;

    }

    public static Car Create(double pojemnoscSilnika, string marka)
    {
        Car samochod1 = new Car(pojemnoscSilnika, marka);
        return samochod1;

    }

    static Car()
    {
        iloscKol = 4;
    }

}
