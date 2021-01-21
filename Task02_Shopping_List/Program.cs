using System;
using System.Linq;
using System.Collections.Generic;

namespace Task02_Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shopingList = Console.ReadLine().Split('!', StringSplitOptions.RemoveEmptyEntries).ToList();

            while (true)
            {
                string[] rawComand = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                string comand = rawComand[0];


                if (comand.ToUpper() == "GO" && rawComand[1].ToUpper() == "SHOPPING!")
                {
                    break;
                }

                else if (comand.ToUpper() == "URGENT")
                {
                    string item = rawComand[1];
                    if (!shopingList.Contains(item))
                    {
                        shopingList.Insert(0, item);
                    }
                }

                else if (comand.ToUpper() == "UNNECESSARY")
                {
                    string item = rawComand[1];
                    if (shopingList.Contains(item))
                    {
                        shopingList.Remove(item);
                    }
                }

                else if (comand.ToUpper() == "CORRECT")
                {
                    string oldItem = rawComand[1];
                    string newItem = rawComand[2];

                    if (shopingList.Contains(oldItem))
                    {
                        shopingList[shopingList.FindIndex(x => x.Equals(oldItem))] = newItem;
                    }
                }

                else if (comand.ToUpper() == "REARRANGE")
                {
                    string item = rawComand[1];
                    if (shopingList.Contains(item))
                    {
                        shopingList.Add(item);
                        shopingList.Remove(item);
                    }
                }

            }
                Console.WriteLine(string.Join(", ", shopingList));
        }
    }
}
