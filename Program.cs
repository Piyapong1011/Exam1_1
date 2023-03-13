using System;

namespace Exam1{
    class Program{
        static void Main(string[]args){
            Console.WriteLine("------------------------------");
            Console.Write("Poster 1 position X : ");
            float p1x = float.Parse(Console.ReadLine());
            Console.Write("Poster 1 position Y : ");
            float p1y = float.Parse(Console.ReadLine());
            Console.Write("Poster 1 wide : ");
            float p1w = float.Parse(Console.ReadLine());
            Console.Write("Poster 1 high : ");
            float p1h = float.Parse(Console.ReadLine());

            Console.WriteLine("------------------------------");

            Console.Write("Poster 2 position X : ");
            float p2x = float.Parse(Console.ReadLine());
            Console.Write("Poster 2 position Y : ");
            float p2y = float.Parse(Console.ReadLine());
            Console.Write("Poster 2 wide : ");
            float p2w = float.Parse(Console.ReadLine());
            Console.Write("Poster 2 high : ");
            float p2h = float.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");
            
            float p1rex, p1lex, p1tey, p1bey;
            float p2rex, p2lex, p2tey, p2bey;
            p1rex = p1x + p1w;
            p1lex = p1x - p1w;
            p1tey = p1y + p1h;
            p1bey = p1y - p1h;

            p2rex = p2x + p2w;
            p2lex = p2x - p2w;
            p2tey = p2y + p2h;
            p2bey = p2y - p2h;


            /*while (p1x < p2x && p1y < p2y){

                break;
            }*/
        }
    }
}
