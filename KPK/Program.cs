using System;

namespace KPK
{
    class MainClass
    {
        public static void Main(string[] args)

        {
            // Start:

            //  kivi = 1;
            // paber = 2;
            //käärid = 3;

            int arvutiSkoor = 0;
            int kasutajaSkoor = 0;
            String[] vastused = { "tyhi", "kivi", "paber", "käärid" };



            Console.WriteLine("Mängu nimi on kivi/paber/käärid. Palun sisestage oma nimi et mängida");
                string nimi = Console.ReadLine();
            Console.WriteLine("Tere " + nimi + ".");
            while (kasutajaSkoor < 4 || arvutiSkoor < 4 )
            {
                Console.WriteLine("Kivi! Paber! Käärid!\nÜks, kaks, kolm!");

                string vast1 = Console.ReadLine();

                Random random = new Random();
                int arvuti = random.Next(1, 4);
                string vast2 = vastused[arvuti];
            Console.WriteLine(nimi + " pakkus " + vast1 + ". Arvuti pakkus " + vast2) ;
                if (vast1 == vast2) {
                    
                    Console.WriteLine("Viik! Proovi uuesti.");


                }
                if (vast1 == "kivi" && vast2 == "käärid" || vast1 == "paber" && vast2 == "kivi" || vast1 == "käärid" && vast2 == "paber") {
                    kasutajaSkoor++;
                    Console.WriteLine("Üks punkt " + nimi + "le.");
                    Console.WriteLine("Skoor on:\nArvuti: " + arvutiSkoor + "\n" + nimi + ": " + kasutajaSkoor);
                }
                if (vast2 == "kivi" && vast1 == "käärid" || vast2 == "paber" && vast1 == "kivi" || vast2 == "käärid" && vast1 == "paber")
                {
                    arvutiSkoor++;
                    Console.WriteLine("Üks punkt arvutile.");
                    Console.WriteLine("Skoor on:\nArvuti: " + arvutiSkoor + "\n" + nimi + ": " + kasutajaSkoor);
                }
                if (arvutiSkoor == 3)
                {
                    Console.WriteLine("Võitja on arvuti");
                    break;
                }
                if (kasutajaSkoor == 3)
                {
                    Console.WriteLine("Võitja on " + nimi);
                    break;
                }

            }


        }


        }
    }
