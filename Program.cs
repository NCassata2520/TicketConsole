using System;
using System.IO;

namespace TicketConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "courseData.txt";
            string choice;
            string[] answer = new string[8];
           
            do
            {
                
                Console.WriteLine("1) View the tickets");
                Console.WriteLine("2) Create ticket from data.");
                Console.WriteLine("Enter any other key to exit.");
              
                choice = Console.ReadLine();

                if (choice == "1")
                {
                 
                    if (File.Exists(file))
                    {
                            foreach (var list in answer)
                            {
                                Console.Write($"{list}, ");
                            
                            }

                    }
                    else
                    {
                        Console.WriteLine("File does not exist");
                    }
                }
                else if (choice == "2")
                {
                    
                    StreamWriter sw = new StreamWriter(file);
                    for (int i = 0; i < 7; i++)
                    {
                        
                        Console.WriteLine("Summary?");
                        string summ = Console.ReadLine();
                        answer[0] = summ;

                        Console.WriteLine("Status? (Open or Close)");
                        string status = Console.ReadLine();
                        answer[1] = status;

                        Console.WriteLine("Priority scale (1-10)?");
                        string priority = Console.ReadLine();
                        answer[2] = priority;

                        Console.WriteLine("Submitter?");
                        string name = Console.ReadLine();
                        answer[3] = name;

                        Console.WriteLine("Assigned?");
                        string assign = Console.ReadLine();
                        answer[4] = assign;

                        string watch;
                        string exit = "e";
                        do
                        {
                            Console.WriteLine("Watching? Enter e to exit");
                            watch = Console.ReadLine();
                            answer[5] = watch;
                        } while (watch != exit);
               
                        { break; }
                    }
                    
                    sw.Close();
                }
            } while (choice == "1" || choice == "2");

        }
    }
}
