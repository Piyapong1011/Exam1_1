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
            
            float high, wide ;
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

            //north east
            if (p1x < p2x && p1y < p2y){
                if (p2lex < p1rex && p2bey < p1tey){
                    wide = p1rex - p2lex;
                    high = p1tey - p2bey;
                    if (wide * high > 8){
                        Console.WriteLine("Too Much Overlaping");
                    }
                    else {
                        Console.WriteLine("Not Much Overlaping");
                    }
                }
                else {
                    Console.WriteLine("No Overlapping");
                }
            }
            //east
            else if (p1x < p2x && p1y == p2y){
                if (p2lex < p1rex){
                    wide = p1rex - p2lex;
                    if (p1h > p2h){
                        high = p2h * 2;
                        if (wide * high > 8){
                            Console.WriteLine("Too Much Overlaping");
                        }
                        else {
                            Console.WriteLine("Not Much Overlaping");
                        }
                    }
                    else if (p1h < p2h){
                        high = p1h * 2;
                        if (wide * high > 8){
                            Console.WriteLine("Too Much Overlaping");
                        }
                        else {
                            Console.WriteLine("Not Much Overlaping");
                        }
                    }
                    else {
                        high = p1h * 2;
                        if (wide * high > 8){
                            Console.WriteLine("Too Much Overlaping");
                        }
                        else {
                            Console.WriteLine("Not Much Overlaping");
                        }
                    }
                }
                else {
                    Console.WriteLine("No Overlapping");
                }
            }
            //south east
            else if (p1x < p2x && p1y > p2y){
                if (p2lex < p1rex && p2tey > p1bey){
                    wide = p1rex - p2lex;
                    high = p2tey - p1bey;
                    if (wide * high > 8){
                        Console.WriteLine("Too Much Overlaping");
                    }
                    else {
                        Console.WriteLine("Not Much Overlaping");
                    }
                }
                else {
                    Console.WriteLine("No Overlapping");
                }
            }
            //south
            else if (p1x == p2x && p1y > p2y){
                if (p2tey > p1bey){
                    high = p2tey - p1bey;
                    if (p1w > p2w){
                        wide = p2w * 2;
                        if (wide * high > 8){
                            Console.WriteLine("Too Much Overlaping");
                        }
                        else {
                            Console.WriteLine("Not Much Overlaping");
                        }
                    }
                    else if (p1w < p2w){
                        wide = p1w * 2;
                        if (wide * high > 8){
                            Console.WriteLine("Too Much Overlaping");
                        }
                        else {
                            Console.WriteLine("Not Much Overlaping");
                        }
                    }
                    else {
                        wide = p1w * 2;
                        if (wide * high > 8){
                            Console.WriteLine("Too Much Overlaping");
                        }
                        else {
                            Console.WriteLine("Not Much Overlaping");
                        }
                    }
                }
                else {
                    Console.WriteLine("No Overlapping");
                }
            }
            //south west
            else if (p1x > p2x && p1y > p2y){
                if (p2rex > p1lex && p2tey > p1bey){
                    wide = p2rex - p1lex;
                    high = p2tey - p1bey;
                    if (wide * high > 8){
                        Console.WriteLine("Too Much Overlaping");
                    }
                    else {
                        Console.WriteLine("Not Much Overlaping");
                    }
                }
                else {
                    Console.WriteLine("No Overlapping");
                }
            }    
            //west
            else if (p1x > p2x && p1y == p2y){
                if (p2rex > p1lex){
                    wide = p2rex - p1lex;
                    if (p1h > p2h){
                        high = p2h * 2;
                        if (wide * high > 8){
                            Console.WriteLine("Too Much Overlaping");
                        }
                        else {
                            Console.WriteLine("Not Much Overlaping");
                        }
                    }
                    else if (p1h < p2h){
                        high = p1h * 2;
                        if (wide * high > 8){
                            Console.WriteLine("Too Much Overlaping");
                        }
                        else {
                            Console.WriteLine("Not Much Overlaping");
                        }
                    }
                    else {
                        high = p1h * 2;
                        if (wide * high > 8){
                            Console.WriteLine("Too Much Overlaping");
                        }
                        else {
                            Console.WriteLine("Not Much Overlaping");
                        }
                    }
                }
                else {
                    Console.WriteLine("No Overlapping");
                }
            }
            //north west
            else if (p1x > p2x && p1y < p2y){
                if (p2rex > p1lex && p2bey < p1tey){
                    wide = p2rex - p1lex;
                    high = p1tey - p2bey;
                    if (wide * high > 8){
                        Console.WriteLine("Too Much Overlaping");
                    }
                    else {
                        Console.WriteLine("Not Much Overlaping");
                    }
                }
                else {
                    Console.WriteLine("No Overlapping");
                }
            }
            //north
            else if (p1x == p2x && p1y < p2y){
                if (p2bey < p1tey){
                    high = p1tey - p2bey;
                    if (p1w > p2w){
                        wide = p2w * 2;
                        if (wide * high > 8){
                            Console.WriteLine("Too Much Overlaping");
                        }
                        else {
                            Console.WriteLine("Not Much Overlaping");
                        }
                    }
                    else if (p1w < p2w){
                        wide = p1w * 2;
                        if (wide * high > 8){
                            Console.WriteLine("Too Much Overlaping");
                        }
                        else {
                            Console.WriteLine("Not Much Overlaping");
                        }
                    }
                    else {
                        wide = p1w * 2;
                        if (wide * high > 8){
                            Console.WriteLine("Too Much Overlaping");
                        }
                        else {
                            Console.WriteLine("Not Much Overlaping");
                        }
                    }
                }
                else {
                    Console.WriteLine("No Overlapping");
                }
            }
        }
    }
}
