using System;

namespace CProject
{
    class Program
    {
        static void Fill_names(ref string[] names){
            for(int i = 0; i < names.Length; i++ ){
                Console.WriteLine($"Enter name {i+1}: ");
                names[i] = Console.ReadLine();
                Console.Clear();                
            }
        }
        static void Names_shorter_than_seven (ref string[] names){
            for(int i = 0; i < names.Length; i++ ){
                if (names[i].Length < 7) Console.WriteLine($"Shorter than 7: {names[i]}");            
            }
            Console.Write("\n");
        }
        static void Names_dont_start_with_A  (ref string[] names){
            for(int i = 0; i < names.Length; i++ ){
                if (names[i][0] == 'A') Console.WriteLine($"Starts with A: {names[i]}");
            }
            Console.Write("\n");
        }
        static void Duplicate_names (ref string[] names){
            for(int i = 0; i < names.Length; i++ ){
                for(int j = i+1; j < names.Length; j++){
                    if (names[i] == names[j]) Console.WriteLine($"Name repeats: {names[i]}");
                }
            }
        }
        
        
        
        static void Main(string[] args)
        {
            const int SIZE = 12;
            string [] names = new string[SIZE];
            Fill_names(ref names);
            Names_shorter_than_seven(ref names);
            Names_dont_start_with_A(ref names);
            Duplicate_names(ref names);
            
            Console.Read();
        }
    }
}
