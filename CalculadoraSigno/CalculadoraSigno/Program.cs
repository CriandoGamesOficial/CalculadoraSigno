using System;

namespace CalculadoraSigno
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string day;
            string month;

         

            Console.WriteLine("Em qual dia você Nasceu ?");
            day = Console.ReadLine();

            Console.WriteLine("Em qual mês você Nasceu ?");
            month = Console.ReadLine();

            Interpretersign interpretersign = new Interpretersign();

            byte tempDay  =0;
            byte temMonth = 0;

            try
            {
               tempDay = Convert.ToByte(day);
               temMonth = Convert.ToByte(month);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();

            }

             Signo sing = interpretersign.Interpreter(tempDay,temMonth);

            if(sing!= null)
            {
                Console.WriteLine("Seu Signo é" + sing.name + " " + sing.characteristics);
            }
           
        }
    }
}
