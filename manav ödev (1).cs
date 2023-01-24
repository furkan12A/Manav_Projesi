using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList Meyveler = new ArrayList() { "Çilek ,Elma, Armut,Kiraz" };
            ArrayList Sebzeler = new ArrayList() { "Patates,Domates,Havuc,Soğan" };

            ArrayList meyveler = new ArrayList();
            ArrayList sebzeler = new ArrayList();
            ArrayList sepet = new ArrayList();


            int ÇİLEK = 0, ELMA = 0, ARMUT = 0, KİRAZ = 0, PATATES = 0, DOMATES = 0, HAVUC = 0, SOĞAN = 0;

            while (true)
            {
                Giriş:
                Console.WriteLine("Hoş Geldiniz");
                Console.WriteLine("Meyveler İçin M Sebzler için S basın");
                string tercih = Console.ReadLine();
                if( tercih == "M")
                {
                    Console.WriteLine("Çilek--1\nElma--2\nArmut--3\nKiraz--4\n");
                    int meyve =Convert.ToInt32(Console.ReadLine());
                    if (meyve == 1)
                    {
                        Console.WriteLine("***ÇİLEK**");
                        Console.WriteLine("Kilo Miktarını Girin Lütfen");
                        ÇİLEK = Convert.ToInt32(Console.ReadLine()) + ÇİLEK;


                    }

                    else if (meyve == 2)
                    {
                          Console.WriteLine("**Elma**");
                        Console.WriteLine("Kilo Miktarını Girin Lütfen");
                        ELMA = Convert.ToInt32(Console.ReadLine());


                    }
                    else if (meyve == 3)
                    {
                       Console.WriteLine("**Armut**");
                        Console.WriteLine(" Kilo Miktarınızı Girin Lütfen");
                        ARMUT = Convert.ToInt32(Console.ReadLine());



                    }

                    else if (meyve == 4)
                    {
                        Console.WriteLine("**Kiraz**");
                        Console.WriteLine(" Kilo Miktarınızı Girin Lütfen");
                        KİRAZ = Convert.ToInt32(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("****Hatalı İşlem****");
                        Thread.Sleep(1500);
                        goto Giriş;


                    }
                }
                else if (tercih == "S")
                {
                    Console.WriteLine("Patates--1\nDomates--2\nHavuc--3\nSoğan--4\n");
                    int sebze = Convert.ToInt32(Console.ReadLine());
                    if (sebze == 1)
                    {
                        Console.WriteLine("**Patates**");
                        Console.WriteLine("Kilo Miktarınızı Girin Lütfen");
                        PATATES = Convert.ToInt32(Console.ReadLine()) + PATATES;

                    }
                    else if (sebze  == 2)
                    {
                        Console.WriteLine("**Domates**");
                        Console.WriteLine("Kilo Miktarınızı Girin Lütfen");
                        DOMATES = Convert.ToInt32(Console.ReadLine()) + DOMATES;


                    }

                    else if (sebze == 3)
                    {
                        Console.WriteLine("**Havuc**");
                        Console.WriteLine("Kilo Miktarınızı Girin Lütfen");
                        HAVUC = Convert.ToInt32(Console.ReadLine()) + HAVUC;


                    }

                    else if (sebze == 4)
                    {
                        Console.WriteLine("**Soğan**");
                        Console.WriteLine("Kilo Miktarınızı Girin Lütfen");
                        SOĞAN= Convert.ToInt32(Console.ReadLine()) + SOĞAN;
                    }
                    else
                    {
                        Console.WriteLine("***HaTAlı İşlem**");
                        Thread.Sleep(1500);
                        goto Giriş;
                    }

                    Console.WriteLine("Başka Bir Arzunuz Varsa Evet Yoksa Hayır Seçiniz lütfen :)");
                    string Sık = Console.ReadLine();
                    if (Sık == "Evet")
                    {
                        goto Giriş;

                    }

                    else if (tercih == "q")
                    {

                        Environment.Exit(0);
                    }

                    else
                    {
                       Dön:
                        Console.WriteLine("**Manava Hoş Geldiniz**");
                        Console.WriteLine("Meyveler İçin M Sebzler için S basın");
                        string terch = Console.ReadLine().ToLower();

                        if (terch == "M")
                        {
                            
                            Console.WriteLine("çilek--1\nelma--2\narmut--3\nkiraz--4\n");
                            int meyv = Convert.ToInt32(Console.ReadLine());
                             
                            if (meyv == 1)
                            {
                                Console.WriteLine("Çilek");
                                Console.WriteLine("Kilo Miktarınızı Girin Lütfen");
                                int çilek = Convert.ToInt32(Console.ReadLine());
                                if (çilek <= ÇİLEK)
                                {
                                    ÇİLEK = ÇİLEK - çilek;
                                    sepet[0] = "ÇİLEK";
                                    
                                }
                                else
                                {
                                    Console.WriteLine("Malesef Elimizde Çilek kalmamiştir");
                                        goto Dön;
                                }
                            }
                            else if (meyv == 2)
                            {
                                Console.WriteLine("Elma");
                                Console.WriteLine("Kilo Miktarınızı Girin Lütfen");
                                int elma = Convert.ToInt32(Console.ReadLine());
                                
                                if(elma <= ELMA)
                                {
                                    ELMA = ELMA - elma;
                                    sepet[1] = "ELMA";

                                }
                                else
                                {
                                    Console.WriteLine("Malesef Elimizde Elma kalmamiştir");
                                    goto Dön;
                                }
                               


                            }
                            else if (meyv == 3)
                            {
                                Console.WriteLine("Armut");
                                Console.WriteLine("Kilo Miktarınızı Girin Lütfen");
                                int armut = Convert.ToInt32(Console.ReadLine());
                                if (armut <= ARMUT)
                                {
                                    ARMUT= armut - armut;
                                    sepet[2] = "ARMUT";
                                }
                                else
                                {
                                    Console.WriteLine("Malesef Elimizde Armut kalmamiştir");
                                    goto Dön;

                                }
                            }
                            else if (meyv == 4)
                            {
                                Console.WriteLine("Kiraz");
                                Console.WriteLine("Kilo Miktarınızı Girin Lütfen");
                                int kiraz = Convert.ToInt32(Console.Read());

                                if (kiraz <= KİRAZ)
                                {
                                    KİRAZ = KİRAZ - kiraz;
                                    sepet[3] = "KİRAZ";
                                }
                                else
                                {
                                    Console.WriteLine("Malesef Elimizde Kiraz kalmamiştir");
                                    goto Dön;
                                }

                            }

                        }
                        else if (terch == "S")
                        {
                            Console.WriteLine("patates--1\ndomates--2\nhavuc--3\nsoğan--4\n");
                            int sebz = Convert.ToInt32(Console.ReadLine());
                            
                            if (sebz == 1)
                            {
                                Console.WriteLine("Patates");
                                Console.WriteLine("Kilo Miktarınızı Girin Lütfen");
                                int patates = Convert.ToInt32(Console.Read());

                                if (patates <= PATATES)
                                {
                                    PATATES= patates - patates;
                                    sepet[4] = "Patates";

                                }
                                else
                                {
                                    Console.WriteLine("Malesef Elimizde Patates kalmamiştir");
                                    goto Dön;
                                }
                                

                            }
                            else if (sebz == 2)
                            {
                                Console.WriteLine("Domates");
                                Console.WriteLine("Kilo Miktarınızı Girin Lütfen");
                                int domates = Convert.ToInt32(Console.ReadLine());
                                 
                                if (domates <= DOMATES)
                                {

                                    DOMATES= domates - domates;
                                    sepet[5] = "Domates";
                                }
                                else
                                {
                                    Console.WriteLine("Malesef Elimizde Domates kalmamiştir");
                                    goto Dön;
                                }
                            }
                            else if (sebz == 3)
                            {
                                Console.WriteLine("Havuc");
                                Console.WriteLine("Kilo Miktarınızı Girin Lütfen");
                                int havuc = Convert.ToInt32(Console.ReadLine());

                                if (havuc <=HAVUC)
                                {
                                 
                                    HAVUC= havuc - havuc;
                                    sepet[6] = "Havuc";


                                }
                                else
                                {
                                    Console.WriteLine("Malesef Elimizde Havuc kalmamiştir");
                                    goto Dön;
                                }
                            }

                            else if (sebz == 4)
                            {

                                Console.WriteLine("Soğan");
                                Console.WriteLine("Kilo Miktarınızı Girin Lütfen");
                                int soğan = Convert.ToInt32(Console.ReadLine());

                                if (soğan <= SOĞAN)
                                {
                                    SOĞAN = soğan - soğan;
                                    sepet[7] = "Soğan";

                                }
                                else
                                {
                                    Console.WriteLine("Malesef Elimizde Soğan kalmamiştir");
                                    goto Dön;
                                }


                            }

                            Console.WriteLine("Başka Bir Arzunuz Varsa Evet Yoksa Hayır Seçiniz lütfen :)");
                            string Sık2 = Console.ReadLine();
                            if (Sık == "Evet")
                            {
                                Thread.Sleep(1500);
                                goto Giriş;

                            }

                            else
                            {
                                foreach (int item in sepet)
                                {
                                    Console.WriteLine(item);
                                }
                            }
                        }

                    }
                }


                

            }



        }
    }
}
