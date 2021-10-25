using System;

namespace UnitTestAndDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Falso = new Person("Faustino Harriague", "1.234.567-8",1992,9,16);
            Person Real = new Person("Faustino Harriague", "4.784.587-5",1992,9,16);
            //Person jane = new Person("Jane Doe", "8.765.432-1");
           // john.IntroduceYourself();
            //jane.IntroduceYourself();
            Falso.IntroduceYourself();
            Real.IntroduceYourself();
        }
    }
}
