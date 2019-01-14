using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
namespace c_sharp5
{
    class Program
    {
        private static int y;
        private static int h;
        private static int m;
        private static int w;

        public static string line { get; private set; }

        static void Main(string[] args)
        {
           
            Console.WriteLine("Lab5 c# done by David SHylyuk,IS-73");
            Console.WriteLine("Project was successfully created");
            Console.WriteLine("Starting program...");

            Console.WriteLine("\n**********Creating enterprise**********\n");
            float a; int b, c; 

                Console.WriteLine("Enter number of deparments(for example 2) - ");
                while (!int.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine("Please Enter a valid int value!");
                }

                Console.WriteLine("Enter number of products(for example 3) - ");
                while (!int.TryParse(Console.ReadLine(), out c))
                {
                    Console.WriteLine("Please Enter a valid int value!");
                }
                Console.WriteLine("Enter power productivity of your enteprise(for example 320.2) - ");

                while (!float.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("Please Enter a valid float value!");
                }
                Console.Clear();
            enterprise d = new enterprise(a, b, c, true);
            Console.WriteLine("\nYou created enterprise: name - {0}, number departments - {1}, number products - {2}, power productivity - {3}.\nFinished creating enterprise",d.Name,d.Num_depart,d.Number_product,d.Productivity_pow); Console.WriteLine("Press something to continue....");
            Console.ReadLine(); Console.Clear();

            Console.WriteLine("Now u should describe your enterprise - ");

           

            for (int i = 0;i<d.Num_depart;i++)
            {
      
                Console.WriteLine("Department{0}:\nEnter name of department #{1} - ",i,i);
                line = Console.ReadLine();
                while (line == "")
                {
                    Console.WriteLine("Empty field...\nEnter name of department #{0} - ",i);
                    line = Console.ReadLine();
                }
                d.departs[0].Name = line;
                Console.WriteLine("Enter number_conveyer_lines of department #{0} (for example enter 2) - ", i);
                while (!int.TryParse(Console.ReadLine(), out c))
                {
                    Console.WriteLine("Please Enter a valid int value!");
                } 
                d.departs[i].Number_lines = c;
               // Console.WriteLine(int.Parse(line));
                Console.WriteLine("Enter number of workers of department #{0} - ", i);
                while (!int.TryParse(Console.ReadLine(), out c))
                {
                    Console.WriteLine("Please Enter a valid int value!");
                }
                d.departs[i].Number_workers = c;
                //Console.WriteLine( int.Parse(line));
        Console.WriteLine("Enter number_tecnics of department #{0} - ", i);
        while (!int.TryParse(Console.ReadLine(), out c))
        {
            Console.WriteLine("Please Enter a valid int value!");
        }
        d.departs[i].Number_tecnic = c;
        //Console.WriteLine(int.Parse(line));
                d.departs[i].Pos_in_prod = i;

                Console.WriteLine("\nYou described department#{0}: name - {1}, number_lines - {2}, workers - {3}, tecs - {4}", i, d.departs[i].Name, d.departs[i].Number_lines,
                    d.departs[i].Number_workers, d.departs[i].Number_tecnic);


                int t = d.departs[i].Number_workers / d.departs[i].Number_lines, ost = d.departs[i].Number_workers % d.departs[i].Number_lines;
                //Console.WriteLine(ost);
                for (int u = 0;u< d.departs[i].Number_tecnic;u++)
                {
                    d.departs[i].tecniques.Add(new tecnique());

                }
                bool o;
                Console.WriteLine("\n*********************************");
                for (int j =0; j<d.departs[i].Number_lines;j++)
                {
                   // Console.Write("\n");
                    Console.WriteLine("Conveyer_line#{0}:", j);
                    do
                    {
                        o = true;
                        int l, k;
                        try
                        {
                            Console.WriteLine("Enter equipment condition(0<value<10) - ", j);
                            while (!int.TryParse(Console.ReadLine(), out l))
                            {
                                Console.WriteLine("Please Enter a valid int value!");
                            }
                            if (l < 0 || l > 10) throw new Errors(10);
              
                            Console.WriteLine("Enter time for making 1 item(detail) in minutes - ");
                            while (!int.TryParse(Console.ReadLine(), out k))
                            {
                                Console.WriteLine("Please Enter a valid int value!");
                            }
                            if (k <= 0) throw new Errors(2);
                            d.departs[i].conveyer_lines.Add(new conveyer_line(t, j, l, k, false, "green"));

                            if (j == d.departs[i].Number_lines - 1) t += ost;
                            for (int r = 0; r < t; r++)
                            {
                                d.departs[i].conveyer_lines[j].hand_workers.Add(new hand_worker(r, 5));
                            }
                       Console.WriteLine("You described conveyer_line#{0}: equipment condition - {1}, average time for making 1 item(detail) in minutes - {2}\n*********************************\n", j, l, k);
                        }
                        catch(Errors ex)
                        {
                            ex.error(); o = false;
                        }
                    } while (o == false);
                    
                }
               if(i!= d.Num_depart-1)
                {
                    Console.WriteLine("Press something to describe next department..."); Console.ReadLine(); Console.Clear();
                }//be careful
               // Console.ReadLine(); Console.Clear();
            }
            Console.WriteLine("\nYou described departments and its lines...Press something to describe products of your enterprise");
            Console.ReadLine();  Console.Clear();

            Console.WriteLine("Now u should describe your products - ");

         
            bool check;
            for (int i = 0;i<d.Number_product;i++)
            {
                do
                {
                    check = true;
                    try
                    {
                        Console.WriteLine("Product#{0}:",i);
                        Console.WriteLine("Enter name of product - "); 
                        line = Console.ReadLine();
                        while (line == "")
                        {
                            Console.WriteLine("Empty field...\nEnter name of product - ");
                            line = Console.ReadLine();
                        } 

                        d.products[i].Name_product = line;
                        Console.WriteLine("Enter list of necessary details - "); // string[] words = line.Split(' ');
                        line = Console.ReadLine();
                        while (line == "")
                        {
                            Console.WriteLine("Empty field...\nEnter list of necessary details - ");
                            line = Console.ReadLine();
                        }

                        int pos = 0;
                        string[] words = line.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                        int length = words.Length;

                        foreach (string word in words)
                        {
                            //Console.WriteLine(word); 
                           
                                d.products[i].List_details.Add(word);
                          
                            pos++;
                        }

                        Console.WriteLine("Enter necessary quantity of these materials ({0} kinds of details defined above, so enter {1} numbers) - ", d.products[i].List_details.Count - 1, d.products[i].List_details.Count - 1);
                        line = Console.ReadLine();
                        while (line == "")
                        {
                            Console.WriteLine("Empty field...\nEnter necessary quantity of these materials - ");
                            line = Console.ReadLine();
                        }


                        words = line.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                        if (words.Length != length) { throw new Errors(6); }
                        for (pos = 0; pos < length; pos++)
                        {
                           // Console.WriteLine(words[pos]);
                            d.products[i].Number_details.Add(words[pos]);
                        }

                        Console.WriteLine("Enter list of departments to make this product({0} existing department(s),so u can enter {1} numbers) - ", d.departs.Count, d.departs.Count);
                        line = Console.ReadLine();
                        while (line == "")
                        {
                            Console.WriteLine("Empty field...\nEnter list of departments to make this product - ");
                            line = Console.ReadLine();
                        }

                        words = line.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                       // Console.WriteLine(words.Length); Console.WriteLine(d.departs.Count);
                        if (words.Length > d.departs.Count) throw new Errors(11);
                        for (pos = 1; pos < words.Length; pos++)
                        {
                            d.products[i].List_departments.Add(words[pos]);
                        }

                        Console.WriteLine("Enter current quality of this product(0<value<10) - ");
                        if (!int.TryParse(Console.ReadLine(), out c))
                        {
                            throw new Errors(3);
                        }
                        else if (c <= 0 || c > 10) throw new Errors(8);
                        d.products[i].Quality = c; Console.WriteLine("");

                        Console.WriteLine("**************\nYou described product: name - {0}, details(in pairs) - ", d.products[i].Name_product);
                        for (pos = 0; pos < d.products[i].Number_details.Count-1; pos++)
                        {
                            Console.WriteLine("{0}: {1}", d.products[i].List_details[pos+1], d.products[i].Number_details[pos+1]);
                        }
                        Console.WriteLine("\nlist of departments involved in making this product or detail:");
                      
                        for (pos = 0; pos < d.products[i].List_departments.Count; pos++)
                        {
                            Console.WriteLine(d.products[i].List_departments[pos]);
                        }
                        Console.WriteLine("\nquality - {0}\n**************\n", d.products[i].Quality);
                        if (i != d.Number_product - 1)
                        {
                            Console.WriteLine("Press something to describe next product...");
                            Console.ReadLine(); Console.Clear();
                        }
                    }
                    catch(Errors ex)
                    {
                        ex.error(); check = false; if (ex.typeOfException != 8 || ex.typeOfException != 11) Console.WriteLine("\n");
                    }
                    
                } while (check == false);
                
            }

            Console.WriteLine("You finally described everything......"); Console.ReadLine(); Console.Clear();

            do
            {
                check = true;
                try
                {
                    Console.WriteLine("1.Check equipment\n2.Qualify workers\n3.Take order\n4.Do prototype\n5.Fix_equipment\n6.Exit");
                    line = Console.ReadLine();
                    switch (line)
                    {
                        case "1":
                        
                            Console.WriteLine("\nChecking will show conv. lines with equipment condition <=4:");
                            for (int i = 0; i < d.departs.Count; i++)
                            {

                                d.departs[i].check_equipment();
                            }
                            break;

                        case "2":
                            do
                            {
                                Console.WriteLine("Notice:countdown starts from index 0 for all next inputs\nIf u want to qualify from 3 to 10 worker of department 1, line 1 - enter '0' for 'department', '0' for 'conveyer line', '2' for 'first worker' and '9' for 'last worker'\n");
                                // int y, h,m,w;
                                Console.WriteLine("Enter number of department to qualify its workers(existing departments - {0}) - ",d.departs.Count);
                                while (!int.TryParse(Console.ReadLine(), out m))
                                {
                                    Console.WriteLine("Please Enter a valid int value!");
                                }
                                if (m < 0 || m >= d.departs.Count) throw new Errors(9);
                                Console.WriteLine("Enter number of conveyer line - ");
                                while (!int.TryParse(Console.ReadLine(), out w))
                                {
                                    Console.WriteLine("Please Enter a valid int value!");
                                }
                                Console.WriteLine("Enter first wortker to qualify - ");
                                while (!int.TryParse(Console.ReadLine(), out y))
                                {
                                    Console.WriteLine("Please Enter a valid int value!");
                                }
                                Console.WriteLine("Enter last worker to qualify - ");
                                while (!int.TryParse(Console.ReadLine(), out h))
                                {
                                    Console.WriteLine("Please Enter a valid int value!");
                                }
                               
                                if (y > h || y < 0 || y >= d.departs[m].conveyer_lines[w].Workers
                            || h < 0 || h >= d.departs[m].conveyer_lines[w].Workers)
                                {
                                    throw new Errors(7);
                                }
                                else
                                {
                                    for (int i = y; i < h; i++) { d.departs[m].conveyer_lines[w].hand_workers[i]++; }
                                }
                            } while (check == false); Console.WriteLine("Qualification succesfully completed!"); break;
                        case "3":
                            Console.WriteLine("Enter name of orderer - "); line = Console.ReadLine(); d.ord.Name_orderer = line;
                            Console.WriteLine("Enter name of product to order - "); line = Console.ReadLine(); d.ord.Kind_prod = line;
                            Console.WriteLine("Enter quantity of product - "); 
                            while (!int.TryParse(Console.ReadLine(), out c))
                    {
                        Console.WriteLine("Please Enter a valid int value!");
                    } 
                    d.ord.Numb_prod = c;
                            Console.WriteLine("Enter deadline - "); 
                            while (!int.TryParse(Console.ReadLine(), out c))
                    {
                        Console.WriteLine("Please Enter a valid int value!");
                    } 
                    d.ord.Dead_line = c;
                            Console.WriteLine("U took order: name_orderer:{0}, product_name:{1}, quantity:{2},deadline:{3} days", d.ord.Name_orderer, d.ord.Kind_prod, d.ord.Numb_prod, d.ord.Dead_line);
                            line = DateTime.Now.ToString("dd MMMM yyyy | HH:mm:ss"); Console.WriteLine("Order was taken {0}", line);

                            break;

                        case "4": Console.WriteLine("U are going to create a prototype by entering necessary info, estimating and approving or declining it");
                            prototype prot = new prototype();
                            Console.WriteLine("Enter name of prototype - ");
                             line = Console.ReadLine();
                        while (line == "")
                        {
                            Console.WriteLine("Empty field...\nEnter name of product - ");
                            line = Console.ReadLine();
                        }
                        prot.Name_prod = line;
                        Console.WriteLine("Enter needed details for prototype - ");
                     
                           line = Console.ReadLine();
                        while (line == "")
                        {
                            Console.WriteLine("Empty field...\nEnter needed details for prototype - ");
                            line = Console.ReadLine();
                        }

                        string[] words;
                        words = line.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                        for (int i = 1; i < words.Length;i++ )
                        {
                            // Console.WriteLine(words[pos]);
                            prot.Kind_detail.Add(words[i]);
                        }


                        Console.WriteLine("Enter quantity of materials, defined above - ");
                               line = Console.ReadLine();
                        while (line == "")
                        {
                            Console.WriteLine("Empty field...\nEnter quantity of materials - ");
                            line = Console.ReadLine();
                        }

                        words = line.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                        for (int i = 1; i < words.Length; i++)
                        {
                            // Console.WriteLine(words[pos]);
                            prot.Needed_detail.Add(words[i]);
                        }
                        Console.WriteLine("Are u sure this prototype can be useful?(enter 'y' or 'n') - ");
                        line = Console.ReadLine();
                           ArrayList list = new ArrayList();
            
                          list.Add(0);
                          while (line == "")
                          {
                              Console.WriteLine("Empty field...\nEnter 'y' or 'n' - ");
                              line = Console.ReadLine();
                          }
                            if (line=="y")
                            {
                                
                                product c1 = new product(prot, list, 5);
                                Console.WriteLine("Prototype approved and succesfully added to the list of products(now u can produce it).");
                                Console.WriteLine("Current quality of this development - 5, department#0 lines were equipped with necessary tools for creating new product. ");
                            }
                            else
                            {
                                Console.WriteLine("U saw a lot of disadvantages in new potential products and comission declined it.");
                            }
                         
                                         
                            break;

                        case "5":
                            for (int i = 0; i < d.departs.Count; i++)
                            {
                                for (int j = 0; j < d.departs[i].conveyer_lines.Count; j++)
                                {
                                    if (d.departs[i].conveyer_lines[j].Eqiupment_stat <= 4)
                                    {
                                        d.departs[i].tecniques[0].fix_problem(i, j);
                                        d.departs[i].conveyer_lines[j]++;
                                    }
                                }

                            } break;


                        case "6": break;
                        default: throw new Errors(1);
                    }
                }

                catch(Errors ex)
                {
                    ex.error(); check = false; Console.WriteLine("Press to try again....."); Console.ReadLine(); Console.Clear();
                }
               if (check != false &&line !="6")
                {
                    Console.WriteLine("\nPress to continue...");
                    Console.ReadLine(); Console.Clear();
                }
                
            } while (line != "6");
         


        }
    }
}
