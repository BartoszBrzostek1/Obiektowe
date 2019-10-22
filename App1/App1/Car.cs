using System;

public class Car
{
    public string Marka;
    public int Rok;

    public string Model;
    public int IloscDrzwi;
    public double PojemnoscSilnika;
    public double srednieSpalanie = 2.0;

    public Car(string marka, int rok)
    {
        Marka = marka;
        Rok = rok;
    }

    private double ObliczSpalanie(double dlugoscTrasy)
    {
        double spalanie;

        spalanie = dlugoscTrasy * srednieSpalanie;

        return spalanie;
        
    }

    public double ObliczKosztPrzejazdu(double dlugoscTrasy, double cenaPaliwa)
    {
        double koszt;

        koszt = ObliczSpalanie(dlugoscTrasy) * cenaPaliwa;

        return koszt;
    }

}
