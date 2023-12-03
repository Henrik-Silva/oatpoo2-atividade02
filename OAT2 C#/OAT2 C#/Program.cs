using OAT2_C_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int validador = 0;
            do
            {
                Console.WriteLine("Olá");
                Console.WriteLine("Escolha a atividade que deseja verificar (1 a 64)");
                int numeroatividade = int.Parse(Console.ReadLine());

                while (numeroatividade < 1 || numeroatividade > 64)
                {
                    Console.WriteLine("Opção invalida, Tente novamente");
                    numeroatividade = int.Parse(Console.ReadLine());
                }

                switch (numeroatividade)
                {
                    case 1:
                        atividade01 atividade01 = new atividade01();
                        atividade01.atividade_1();
                        break;    
                       
                    case 2:
                        atividade02 atividade02 = new atividade02();   
                        atividade02.atividade_2();                       
                        break;

                    case 3:
                        atividade03 atividade03 = new atividade03();
                        atividade03.atividade_03();
                        break;

                    case 4:
                        atividade04 atividade04 = new atividade04();
                        atividade04.atividade_04();
                        break;

                    case 5:
                        atividade05 atividade05 = new atividade05();
                        atividade05.atividade_05();
                        break;

                    case 6:
                        atividade06 atividade06 = new atividade06();
                        atividade06.atividade_06();
                        break;

                    case 7:
                        atividade07 atividade07 = new atividade07();
                        atividade07.atividade_07();
                        break;

                    case 8:
                        atividade08 atividade08 = new atividade08();
                        atividade08.atividade_08();
                        break;

                    case 9:
                        atividade09 atividade09 = new atividade09();
                        atividade09.atividade_09();
                        break;

                    case 10:
                        atividade10 atividade10 = new atividade10();
                        atividade10.atividade_10();
                        break;

                    case 11:
                        atividade11 atividade11 = new atividade11();
                        atividade11.atividade_11();
                        break;

                    case 12:
                        atividade12 atividade12 = new atividade12();
                        atividade12.atividade_12();
                        break;

                    case 13:
                        atividade13 atividade13 = new atividade13();
                        atividade13.atividade_13();
                        break;

                    case 14:
                        atividade14 atividade14 = new atividade14();
                        atividade14.atividade_14();
                        break;

                    case 15:
                        atividade15 atividade15 = new atividade15();
                        atividade15.atividade_15();
                        break;

                    case 16:
                        atividade16 atividade16 = new atividade16();
                        atividade16.atividade_16();
                        break;

                    case 17:
                        atividade17 atividade17 = new atividade17();
                        atividade17.atividade_17();
                        break;

                    case 18:
                        atividade18 atividade18 = new atividade18();
                        atividade18.atividade_18();
                        break;

                    case 19:
                        atividade19 atividade19 = new atividade19();
                        atividade19.atividade_19();
                        break;

                    case 20:
                        atividade20 atividade20 = new atividade20();
                        atividade20.atividade_20();
                        break;

                    case 21:
                        atividade21 atividade21 = new atividade21();
                        atividade21.atividade_21();
                        break;

                    case 22:
                        atividade22 atividade22 = new atividade22();
                        atividade22.atividade_22();
                        break;

                    case 23:
                        atividade23 atividade23 = new atividade23();
                        atividade23.atividade_23();
                        break;

                    case 24:
                        atividade24 atividade24 = new atividade24();
                        atividade24.atividade_24();
                        break;

                    case 25:
                        atividade25 atividade25 = new atividade25();
                        atividade25.atividade_25();
                        break;

                    case 26:
                        atividade26 atividade26 = new atividade26();
                        atividade26.atividade_26();
                        break;

                    case 27:
                        atividade27 atividade27 = new atividade27();
                        atividade27.atividade_27();
                        break;

                    case 28:
                        atividade28 atividade28 = new atividade28();
                        atividade28.atividade_28();
                        break;

                    case 29:
                        atividade29 atividade29 = new atividade29();
                        atividade29.atividade_29();
                        break;

                    case 30:
                        atividade30 atividade30 = new atividade30();
                        atividade30.atividade_30();
                        break;

                    case 31:
                        atividade31 atividade31 = new atividade31();
                        atividade31.atividade_31();
                        break;

                    case 32:
                        atividade32 atividade32 = new atividade32();
                        atividade32.atividade_32();
                        break;

                    case 33:
                        atividade33 atividade33 = new atividade33();
                        atividade33.atividade_33();
                        break;

                    case 34:
                        atividade34 atividade34 = new atividade34();
                        atividade34.atividade_34();
                        break;

                    case 35:
                        atividade35 atividade35 = new atividade35();
                        atividade35.atividade_35();
                        break;

                    case 36:
                        atividade36 atividade36 = new atividade36();
                        atividade36.atividade_36();
                        break;

                    case 37:
                        atividade37 atividade37 = new atividade37();
                        atividade37.atividade_37();
                        break;

                    case 38:
                        atividade38 atividade38 = new atividade38();
                        atividade38.atividade_38();
                        break;

                    case 39:
                        atividade39 atividade39 = new atividade39();
                        atividade39.atividade_39();
                        break;

                    case 40:
                        atividade40 atividade40 = new atividade40();
                        atividade40.atividade_40();
                        break;

                    case 41:
                        atividade41 atividade41 = new atividade41();
                        atividade41.atividade_41();
                        break;

                    case 42:
                        atividade42 atividade42 = new atividade42();
                        atividade42.atividade_42();
                        break;

                    case 43:
                        atividade43 atividade43 = new atividade43();
                        atividade43.atividade_43();
                        break;

                    case 44:
                        atividade44 atividade44 = new atividade44();
                        atividade44.atividade_44();
                        break;

                    case 45:
                        atividade45 atividade45 = new atividade45();
                        atividade45.atividade_45();
                        break;

                    case 46:
                        atividade46 atividade46 = new atividade46();
                        atividade46.atividade_46();
                        break;

                    case 47:
                        atividade47 atividade47 = new atividade47();
                        atividade47.atividade_47();
                        break;

                    case 48:
                        atividade48 atividade48 = new atividade48();
                        atividade48.atividade_48();
                        break;

                    case 49:
                        atividade49 atividade49 = new atividade49();
                        atividade49.atividade_49();
                        break;

                    case 50:
                        atividade50 atividade50 = new atividade50();
                        atividade50.atividade_50();
                        break;

                    case 51:
                        atividade51 atividade51 = new atividade51();
                        atividade51.atividade_51();
                        break;

                    case 52:
                        atividade52 atividade52 = new atividade52();
                        atividade52.atividade_52();
                        break;

                    case 53:
                        atividade53 atividade53 = new atividade53();
                        atividade53.atividade_53();
                        break;

                    case 54:
                        atividade54 atividade54 = new atividade54();
                        atividade54.atividade_54();
                        break;

                    case 55:
                        atividade55 atividade55 = new atividade55();
                        atividade55.atividade_55(); 
                        break;

                    case 56:
                        atividade56 atividade56 = new atividade56();
                        atividade56.atividade_56();
                        break;

                    case 57:
                        atividade57 atividade57 = new atividade57();
                        atividade57.atividade_57();
                        break;

                    case 58:
                        atividade58 atividade58 = new atividade58();
                        atividade58.atividade_58();
                        break;

                    case 59:
                        atividade59 atividade59 = new atividade59();
                        atividade59.atividade_59();
                        break;

                    case 60:
                        atividade60 atividade60 = new atividade60();
                        atividade60.atividade_60();
                        break;

                    case 61:
                        atividade61 atividade61 = new atividade61();
                        atividade61.atividade_61();
                        break;

                    case 62:
                        atividade62 atividade62 = new atividade62();
                        atividade62.atividade_62();
                        break;

                    case 63:
                        atividade63 atividade63 = new atividade63();
                        atividade63.atividade_63();
                        break;

                    case 64:
                        atividade64 atividade64 = new atividade64();
                        atividade64.atividade_64();
                        break;
                }
                Console.Clear();

                Console.WriteLine("Gostaria de verificar mais algum atividade ? Digite 0 para 'SIM' e -1 para 'NÃO'");
                validador = int.Parse(Console.ReadLine());

                Console.Clear();

            } while (validador != -1);
        }
    }
}