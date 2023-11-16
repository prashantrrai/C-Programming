using System;

namespace ATM;

class ATM_PIN
{
    private int atmPIN;

    public void setAtmPin()
    {
        Console.WriteLine("Set the 4 digit PIN");
        atmPIN = Convert.ToInt16(Console.ReadLine());
    }

    //public int getAtmPin()
    //{
    //    return atmPIN;
    //}

    public void showAtmpin()
    {
        Console.WriteLine($"Your ATM PIN is {atmPIN}");
    }
}

class MainClass
{
    static void Main(string[] args)
    {
        ATM_PIN mynewpin = new ATM_PIN();

        mynewpin.setAtmPin();
        //mynewpin.getAtmPin();
        mynewpin.showAtmpin();

        Console.ReadLine();

    }
}