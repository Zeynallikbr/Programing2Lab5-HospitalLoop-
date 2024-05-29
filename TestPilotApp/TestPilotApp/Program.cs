using System.Numerics;

namespace TestPilotApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Xestaxanamiza xos gelmisiniz: ");

            bool flag = true;
            int doctotCount = 0;
            int totalPrice = 0;
            string DoctorSpecialty = " ";
            string nextDoctorName = " ";
            int consultationPrice = 0;
            int positiveFeedback = 0;
            int negativeFeedback = 0;
            int doctorCount = 0;
            bool finlyResult = false;
            while (flag)
            {
                doctorCount++;
                Console.Write("Hekimin Bolumu:");
                DoctorSpecialty = Console.ReadLine();
            
                Console.Write("Hekimin adi:");
                nextDoctorName = Console.ReadLine();

                Console.Write("Konsultasiya giymetini daxil edin:");
                consultationPrice = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Yekun reyi|musbet=1 ve ya menfi=2|)");
                int finalOpinion = int.Parse(Console.ReadLine());
                if (finalOpinion ==1 )
                {
                    positiveFeedback++;
                    positiveFeedback += positiveFeedback;                   
                }
                else
                {
                    negativeFeedback++;
                    negativeFeedback += negativeFeedback;    
                }
                Console.WriteLine("Baska bir hekime ehtiyac var mi? (y/n)");
                char yesOrno = char.Parse(Console.ReadLine());
                if(yesOrno == 'y')
                {
                    flag = true;
                }
                else
                {
                    flag = false;   
                }
                totalPrice += consultationPrice;
                doctotCount++;
            }
            if(positiveFeedback >negativeFeedback)
            {
                finlyResult = true;
                Console.WriteLine("Siz yekun netice musbet oldu.");
            }
            else if(negativeFeedback >positiveFeedback)
            {
                finlyResult = false;
                Console.WriteLine("sizin netice menfi oldu.");
            }
            
            
            Console.WriteLine($"Namizedlerin yaxinlasdigi hekim sayi: {doctorCount}");
            Console.WriteLine($"Namizədin yaxınlaşdığı həkim sayı: {DoctorSpecialty}");
            Console.WriteLine($"Namizədin xərclədiyi pul miqdarı: {totalPrice}");
            Console.WriteLine($"Namizədin aldığı müsbət cavabların sayı: {positiveFeedback}");
            Console.WriteLine($"Namizədin aldığı mənfi cavabların sayı: {negativeFeedback}");

        }

    }
}