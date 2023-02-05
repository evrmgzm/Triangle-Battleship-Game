using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_of_Battleship
{
    class Program
    {
        static void Main(string[] args)
        {

            //Music (We tried but its only working on my computer)
            //SoundPlayer carribean = new SoundPlayer();
            //string loc = "C:\\Users\\Alperen\\Desktop\\Carribean.wav";
            //carribean.SoundLocation = loc;
            //carribean.Play();


            //Starting and the formulas that all we need
            Console.WriteLine("Hello! Welcome to Battleship Survival Game!\nPlease press enter for start and enjoy!");
            Console.ReadLine();
            double sangle;
            int Ax = 0, Ay = 0, Bx = 0, By = 0, Cx = 0, Cy = 0;
            double acedge = Math.Sqrt((Math.Pow((Ax - Cx), 2) + Math.Pow((Ay - Cy), 2)));
            double abedge = Math.Sqrt((Math.Pow((Ax - Bx), 2) + Math.Pow((Ay - By), 2)));
            double bcedge = Math.Sqrt((Math.Pow((Bx - Cx), 2) + Math.Pow((By - Cy), 2)));
            double perimeter = acedge + abedge + bcedge;
            double u = perimeter / 2d;
            double area = Math.Sqrt(u * (u - acedge) * (u - abedge) * (u - bcedge));
            double angleA = Math.Acos((Math.Pow(acedge, 2) + Math.Pow(abedge, 2) - Math.Pow(bcedge, 2)) / (2 * acedge * abedge)) * 180 / Math.PI;
            double angleB = Math.Acos((Math.Pow(bcedge, 2) + Math.Pow(abedge, 2) - Math.Pow(acedge, 2)) / (2 * bcedge * abedge)) * 180 / Math.PI;
            double angleC = Math.Acos((Math.Pow(acedge, 2) + Math.Pow(bcedge, 2) - Math.Pow(abedge, 2)) / (2 * acedge * bcedge)) * 180 / Math.PI;
            double acmedianx = (Ax + Cx) / 2d;
            double acmediany = (Ay + Cy) / 2d;
            double abmedianx = (Ax + Bx) / 2d;
            double abmediany = (Ay + By) / 2d;
            double bcmedianx = (Bx + Cx) / 2d;
            double bcmediany = (By + Cy) / 2d;
            double centroidx = (Ax + Bx + Cx) / 3d;
            double centroidy = (Ay + By + Cy) / 3d;
            double k = bcedge / (abedge + acedge);
            double bisector = Math.Sqrt((abedge * acedge) - (abedge * acedge * k * k));
            double r = (2 * area) / (acedge + bcedge + abedge);
            double incircle = Math.PI * Math.Pow(r, 2);
            double R = (acedge * abedge * bcedge) / (4 * area);
            double circcircle = Math.PI * Math.Pow(R, 2);
            Random Rshoot = new Random();
            int shootx, shooty;
            shootx = Rshoot.Next(1, 31);
            shooty = Rshoot.Next(1, 13);


            Console.Clear();
            bool control = true;


            //Main loop            
            do
            {
                //Menu
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("                     MENU      \n-Please write the order of the options you want to select(1-5)-\n             -----------------------\n             |1.Enter ship location  |\n             " +
               "|2.Ship info            |\n             |3.Random shot          |\n             |4.High score table     |\n             |5.Exit                 |" +
               "\n             -----------------------");
                Console.ForegroundColor = ConsoleColor.White;
                string i = Console.ReadLine();
                Console.Clear();


                //Options
                switch (i)
                {

                    case "1":
                        //Exception handle
                        try
                        {

                            Console.WriteLine("Your battleship is going to be a triangle and this game is playing in cartesian coordinate system.\n" +
                          "So you should enter 6 number for Ax Ay Bx By Cx Cy.");
                            Console.WriteLine("\nPlease enter a number for A point's x location");
                            Ax = Convert.ToByte(Console.ReadLine());
                            if (0 > Ax || Ax > 30)
                            {
                                Console.WriteLine("Please enter number between 0 and 31 for x plane. Please press enter for return menu");
                                Console.ReadLine();
                                Console.Clear();
                                break;


                            }
                            Console.WriteLine("Please enter a number for A point's y location");
                            Ay = Convert.ToByte(Console.ReadLine());
                            if (0 > Ay || Ay > 12)
                            {
                                Console.WriteLine("Please enter number between 0 and 13 for y plane. Please press enter for return menu");
                                Console.ReadLine();
                                Console.Clear();
                                break;

                            }
                            Console.WriteLine("Please enter a number for B point's x location");
                            Bx = Convert.ToByte(Console.ReadLine());
                            if (0 > Bx || Bx > 30)
                            {
                                Console.WriteLine("Please enter number between 0 and 31 for x plane. Please press enter for return menu");
                                Console.ReadLine();
                                Console.Clear();
                                break;

                            }
                            Console.WriteLine("Please enter a number for B point's y location");
                            By = Convert.ToByte(Console.ReadLine());
                            if (0 > By || By > 12)
                            {
                                Console.WriteLine("Please enter number between 0 and 13 for y plane. Please press enter for return menu");
                                Console.ReadLine();
                                Console.Clear();
                                break;

                            }
                            Console.WriteLine("Please enter a number for C point's x location");
                            Cx = Convert.ToByte(Console.ReadLine());
                            if (0 > Cx || Cx > 30)
                            {
                                Console.WriteLine("Please enter number between 0 and 31 for x plane. Please press enter for return menu");
                                Console.ReadLine();
                                Console.Clear();
                                break;

                            }
                            Console.WriteLine("Please enter a number for C point's y location");
                            Cy = Convert.ToByte(Console.ReadLine());
                            if (0 > Cy || Cy > 12)
                            {
                                Console.WriteLine("Please enter number between 0 and 13 for x plane. Please press enter for return menu");
                                Console.ReadLine();
                                Console.Clear();
                                break;

                            }
                        }
                        catch
                        {
                            Console.WriteLine("The points are not according to the rules of game");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }


                        Console.Clear();

                        //Calculating edges for option 1
                        acedge = Math.Sqrt((Math.Pow((Ax - Cx), 2) + Math.Pow((Ay - Cy), 2)));
                        abedge = Math.Sqrt((Math.Pow((Ax - Bx), 2) + Math.Pow((Ay - By), 2)));
                        bcedge = Math.Sqrt((Math.Pow((Bx - Cx), 2) + Math.Pow((By - Cy), 2)));

                        //Check for triangle
                        if (Math.Abs(abedge - acedge) < bcedge && bcedge < (abedge + acedge))
                        {
                            Console.WriteLine("It provides triangle properties.");

                        }

                        else if (Math.Abs(abedge - bcedge) < acedge && acedge < (abedge + bcedge))
                        {
                            Console.WriteLine("It provides triangle properties.");
                        }

                        else if (Math.Abs(acedge - bcedge) < abedge && abedge < (acedge + bcedge))
                        {
                            Console.WriteLine("It provides triangle properties.");
                        }
                        else
                        {
                            Console.WriteLine("We can't form triangle with the numbers you entered. Please enter numbers that can form triangle.\nPlease press enter for return menu");
                            Console.ReadLine();
                            Console.Clear();
                            break;


                        }


                        //Printing coordinate system
                        Console.WriteLine("12|\n11|\n10|\n 9|\n 8|\n 7|\n 6|\n 5|\n 4|\n 3|\n 2|\n 1|");
                        Console.WriteLine("  *------------------------------\n  0123456789012345678901234567890");
                        Console.SetCursorPosition(Ax + 2, 13 - Ay);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("A");
                        Console.SetCursorPosition(Bx + 2, 13 - By);
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("B");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.SetCursorPosition(Cx + 2, 13 - Cy);
                        Console.WriteLine("C");
                        Console.ForegroundColor = ConsoleColor.White;

                        //Same as first calculations, but its for option 1
                        perimeter = acedge + abedge + bcedge;
                        u = perimeter / 2d;
                        area = Math.Sqrt(u * (u - acedge) * (u - abedge) * (u - bcedge));
                        angleA = Math.Acos((Math.Pow(acedge, 2) + Math.Pow(abedge, 2) - Math.Pow(bcedge, 2)) / (2 * acedge * abedge)) * 180 / Math.PI;
                        angleB = Math.Acos((Math.Pow(bcedge, 2) + Math.Pow(abedge, 2) - Math.Pow(acedge, 2)) / (2 * bcedge * abedge)) * 180 / Math.PI;
                        angleC = Math.Acos((Math.Pow(acedge, 2) + Math.Pow(bcedge, 2) - Math.Pow(abedge, 2)) / (2 * acedge * bcedge)) * 180 / Math.PI;
                        acmedianx = (Ax + Cx) / 2d;
                        acmediany = (Ay + Cy) / 2d;
                        abmedianx = (Ax + Bx) / 2d;
                        abmediany = (Ay + By) / 2d;
                        bcmedianx = (Bx + Cx) / 2d;
                        bcmediany = (By + Cy) / 2d;
                        centroidx = (Ax + Bx + Cx) / 3d;
                        centroidy = (Ay + By + Cy) / 3d;
                        k = bcedge / (abedge + acedge);
                        bisector = Math.Sqrt((abedge * acedge) - (abedge * acedge * k * k));
                        r = (2 * area) / (acedge + bcedge + abedge);
                        incircle = Math.PI * Math.Pow(r, 2);
                        R = (acedge * abedge * bcedge) / (4 * area);
                        circcircle = Math.PI * Math.Pow(R, 2);
                        string typeangle;
                        string typelength;
                        //Find the type of triangle
                        if (angleA > 90 || angleB > 90 || angleC > 90)
                        {
                            typeangle = "Obtuse-angled";
                        }
                        else if (angleA == 90 || angleB == 90 || angleC == 90)
                        {
                            typeangle = "Right-angled";
                        }
                        else
                        {
                            typeangle = "Acute-angled";
                        }
                        if (acedge == abedge && abedge == bcedge)
                        {
                            typelength = "Equilateral Ship";
                        }
                        else if (acedge == abedge && abedge != bcedge || bcedge == acedge && acedge != abedge || bcedge == abedge && bcedge != acedge)
                        {
                            typelength = "Isosceles Ship";
                        }
                        else
                        {
                            typelength = "Scalene Ship";
                        }
                        //Printing Ship Info
                        Console.WriteLine("\n\n\n\n\n\n*----------SHIP  INFO----------*");
                        Console.WriteLine("1.Length of the edges:   |AC|:" + Math.Round(acedge, 2) + "|AB|:" + Math.Round(abedge, 2) + "|BC|:" + Math.Round(bcedge, 2));
                        Console.WriteLine("2.Perimeter of the ship:" + Math.Round(perimeter, 2));
                        Console.WriteLine("3.Area of the ship:" + (area));
                        Console.WriteLine("4.The angles of the ship:   A°:" + Math.Round(angleA, 2) + " B°:" + Math.Round(angleB, 2) + " C°:" + Math.Round(angleC, 2));
                        Console.WriteLine("5.Median points of the ship:   AB:(" + Math.Round(abmedianx, 2) + ", " + Math.Round(abmediany, 2) + ")" + "  " + "AC:(" + Math.Round(acmedianx, 2) + ", " + Math.Round(acmediany, 2) + ")" + "  " + "BC:(" + Math.Round(bcmedianx, 2) + ", " + Math.Round(bcmediany, 2) + ")");
                        Console.WriteLine("6.The centroid of the ship:(" + Math.Round(centroidx, 2) + ", " + Math.Round(centroidy, 2) + ")");
                        Console.WriteLine("Length of bisector:" + Math.Round(bisector, 2));
                        Console.WriteLine("8.The area of the inscribed circle:" + Math.Round(incircle, 2));
                        Console.WriteLine("9.The area of circumscribed circle:" + Math.Round(circcircle, 2));
                        Console.WriteLine("10.Type of the ship:" + typeangle + "(" + typelength + ")");
                        Console.WriteLine("\nPlease press enter for execute random shoot, If shoot hits the ship, you loose.Otherwise your ship survive and you will get score as your ship's area");
                        Console.ReadLine();
                        Console.Clear();
                        //Create random shot
                        Rshoot = new Random();
                        shootx = Rshoot.Next(1, 31);
                        shooty = Rshoot.Next(1, 13);

                        //Show random shot at coordinate system
                        Console.WriteLine("Shoot:" + shootx + (",") + shooty);
                        Console.WriteLine("12|\n11|\n10| \n 9| \n 8| \n 7| \n 6| \n 5| \n 4| \n 3| \n 2| \n 1|\n   +-----------------------------\n  0123456789012345678901234567890  ");
                        Console.SetCursorPosition(Ax + 2, 13 - Ay);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("A");
                        Console.SetCursorPosition(Bx + 2, 13 - By);
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("B");
                        Console.SetCursorPosition(Cx + 2, 13 - Cy);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("C");
                        Console.SetCursorPosition(shootx + 2, 13 - shooty);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("X");
                        Console.SetCursorPosition(0, 15);
                        Console.ForegroundColor = ConsoleColor.White;
                        //Calculation of finding out if the triangle has been hit
                        double axedge = Math.Sqrt((Math.Pow((Ax - shootx), 2) + Math.Pow((Ay - shooty), 2)));
                        double bxedge = Math.Sqrt((Math.Pow((Bx - shootx), 2) + Math.Pow((By - shooty), 2)));
                        double cxedge = Math.Sqrt((Math.Pow((Cx - shootx), 2) + Math.Pow((Cy - shooty), 2)));
                        double angleD = Math.Acos((Math.Pow(bxedge, 2) + Math.Pow(axedge, 2) - Math.Pow(abedge, 2)) / (2 * axedge * bxedge)) * 180 / Math.PI;

                        double angleE = Math.Acos((Math.Pow(cxedge, 2) + Math.Pow(axedge, 2) - Math.Pow(acedge, 2)) / (2 * axedge * cxedge)) * 180 / Math.PI;
                        double angleF = Math.Acos((Math.Pow(cxedge, 2) + Math.Pow(bxedge, 2) - Math.Pow(bcedge, 2)) / (2 * bxedge * cxedge)) * 180 / Math.PI;




                        sangle = Convert.ToDouble(angleD + angleE + angleF);


                        bool finish = false;
                        //find out if the triangle has been hit
                        if (Convert.ToInt32(sangle) == 360)
                        {
                            finish = true;
                            Console.WriteLine("Your ship sank! Total score is:0");
                            Console.ReadLine();
                            Console.WriteLine("---------HIGH SCORE TABLE---------\nName                     Score\nNazan Kaya                    60\n" +
                                   "Ali Kurt                   30\nSibel Arslan                 10");
                            Console.ReadLine();
                            Console.Clear();
                            break;

                        }
                        else if (((((shootx == Ax) && (shooty == Ay))) || (((shootx == Bx) && (shooty == By))) || (((shootx == Cx) && (shooty == Cy)))))
                        {
                            finish = true;
                            Console.WriteLine("Your ship sank! Total score is:0");
                            Console.ReadLine();
                            Console.WriteLine("---------HIGH SCORE TABLE---------\nName                     Score\nNazan Kaya                    60\n" +
                                   "Ali Kurt                   30\nSibel Arslan                 10");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }

                        else
                        {

                            Console.WriteLine("Your ship survived! Total score is: " + Math.Round(area, 2));
                            //Loop for If the player wants to continue
                            bool yes = true;
                            int count = 2;
                            while (yes == true)

                            {


                                double score = area * count;
                                Console.WriteLine("If you want to continue please press 'y' and enter");
                                string input = Console.ReadLine();
                                Console.Clear();
                                if (input == "y" || input == "Y")
                                {
                                    Random Rshoot2 = new Random();
                                    int shootx2, shooty2;
                                    shootx2 = Rshoot2.Next(1, 31);
                                    shooty2 = Rshoot2.Next(1, 13);
                                    Console.WriteLine("Shoot:" + shootx2 + (",") + shooty2);
                                    Console.WriteLine("12|\n11|\n10| \n 9| \n 8| \n 7| \n 6| \n 5| \n 4| \n 3| \n 2| \n 1|\n   +-----------------------------\n  0123456789012345678901234567890  ");
                                    Console.SetCursorPosition(Ax + 2, 13 - Ay);
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("A");
                                    Console.SetCursorPosition(Bx + 2, 13 - By);
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.WriteLine("B");
                                    Console.SetCursorPosition(Cx + 2, 13 - Cy);
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine("C");
                                    Console.SetCursorPosition(shootx2 + 2, 13 - shooty2);
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("X");
                                    Console.SetCursorPosition(0, 15);
                                    Console.ForegroundColor = ConsoleColor.White;
                                    axedge = Math.Sqrt((Math.Pow((Ax - shootx2), 2) + Math.Pow((Ay - shooty2), 2)));
                                    bxedge = Math.Sqrt((Math.Pow((Bx - shootx2), 2) + Math.Pow((By - shooty2), 2)));
                                    cxedge = Math.Sqrt((Math.Pow((Cx - shootx2), 2) + Math.Pow((Cy - shooty2), 2)));

                                    angleD = Math.Acos((Math.Pow(bxedge, 2) + Math.Pow(axedge, 2) - Math.Pow(abedge, 2)) / (2 * axedge * bxedge)) * 180 / Math.PI;
                                    angleE = Math.Acos((Math.Pow(cxedge, 2) + Math.Pow(axedge, 2) - Math.Pow(acedge, 2)) / (2 * axedge * cxedge)) * 180 / Math.PI;
                                    angleF = Math.Acos((Math.Pow(cxedge, 2) + Math.Pow(bxedge, 2) - Math.Pow(bcedge, 2)) / (2 * bxedge * cxedge)) * 180 / Math.PI;




                                    sangle = Convert.ToDouble(angleD + angleE + angleF);




                                    if (Convert.ToInt32(sangle) == 360)
                                    {
                                        finish = true;
                                        Console.WriteLine("Your ship sank! Total score is:0");
                                        Console.ReadLine();
                                        Console.WriteLine("---------HIGH SCORE TABLE---------\nName                     Score\nNazan Kaya                    60\n" +
                                               "Ali Kurt                   30\nSibel Arslan                 10");
                                        Console.ReadLine();
                                        yes = false;
                                        Console.Clear();


                                    }
                                    else if (((((shootx == Ax) && (shooty == Ay))) || (((shootx == Bx) && (shooty == By))) || (((shootx == Cx) && (shooty == Cy)))))
                                    {
                                        finish = true;
                                        Console.WriteLine("Your ship sank! Total score is:0");
                                        Console.ReadLine();
                                        Console.WriteLine("---------HIGH SCORE TABLE---------\nName                     Score\nNazan Kaya                    60\n" +
                                               "Ali Kurt                   30\nSibel Arslan                 10");
                                        Console.ReadLine();
                                        yes = false;
                                        Console.Clear();



                                    }
                                    else
                                    {

                                        Console.WriteLine("Your ship survived! Total score is: " + Math.Round(score, 2));
                                        Console.WriteLine("Cong! If you want, you can continue the game by taking risks by pressing 'r' \nor if you want you can press any key and if your score is enough you can even enter the scoreboard  ");
                                        string risk = Console.ReadLine();
                                        if (risk == "r" || risk == "R")
                                        {
                                            yes = true;
                                        }

                                        else
                                        {
                                            finish = true;
                                            Console.WriteLine("Cong! Total score is: " + Math.Round(score, 2));
                                            if (finish == true && score <= 10)
                                            {
                                                Console.WriteLine("---------HIGH SCORE TABLE---------\nName                     Score\nNazan Kaya                    60\n" +
                                                   "Ali Kurt                   30\nSibel Arslan                 10");
                                                Console.ReadLine();


                                            }


                                            else if (finish == true && score > 10 && score <= 30)
                                            {
                                                Console.WriteLine("Please enter your name");
                                                string name = Console.ReadLine();
                                                Console.Clear();
                                                Console.WriteLine("---------HIGH SCORE TABLE---------\n");
                                                Console.WriteLine("Name                   Score\n" +
                                                    "Nazan Kaya             60\n" +
                                                   "Ali Kurt                30");
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.WriteLine(name + "                  " + Math.Round(score, 2));
                                                Console.ForegroundColor = ConsoleColor.White;
                                                Console.ReadLine();


                                            }
                                            else if (finish == true && score > 30 && score <= 60)
                                            {
                                                Console.WriteLine("Please enter your name");
                                                string name = Console.ReadLine();
                                                Console.Clear();
                                                Console.WriteLine("---------HIGH SCORE TABLE---------\n" +
                                                     "Name                   Score\n" +
                                                     "Nazan Kaya             60");
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.WriteLine(name + "                  " + Math.Round(score, 2));
                                                Console.ForegroundColor = ConsoleColor.White;
                                                Console.WriteLine("Ali Kurt               30");
                                                Console.ReadLine();

                                            }
                                            else if (finish == true && score > 60)
                                            {
                                                Console.WriteLine("Please enter your name");
                                                string name = Console.ReadLine();
                                                Console.Clear();
                                                Console.WriteLine("---------HIGH SCORE TABLE---------\n");
                                                Console.WriteLine("Name                   Score");
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.WriteLine(name + "                   " + score);
                                                Console.ForegroundColor = ConsoleColor.White;
                                                Console.WriteLine("Nazan Kaya          60\n" +
                                                                  "Ali Kurt             30");



                                                Console.ReadLine();


                                            }
                                            yes = false;
                                        }

                                        count++;

                                    }


                                }
                                else
                                {
                                    yes = false;
                                }

                            }


                            //Print high score table
                            if (finish == false && area <= 10)
                            {
                                Console.WriteLine("---------HIGH SCORE TABLE---------\nName                     Score\nNazan Kaya                    60\n" +
                                   "Ali Kurt                   30\nSibel Arslan                 10");
                                Console.ReadLine();


                            }


                            else if (finish == false && area > 10 && area <= 30)
                            {
                                Console.WriteLine("Please enter your name");
                                string name = Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine("---------HIGH SCORE TABLE---------\n" +
                                    "Name                   Score\n" +
                                    "Nazan Kaya             60\n" +
                                   "Ali Kurt               30\n");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine(name + "                  " + Math.Round(area, 2));
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.ReadLine();


                            }
                            else if (finish == false && area > 30 && area <= 60)
                            {
                                Console.WriteLine("Please enter your name");
                                string name = Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine("---------HIGH SCORE TABLE---------\n" +
                                     "Name                   Score\n" +
                                     "Nazan Kaya             60\n");
                                Console.WriteLine(name + "                   " + Math.Round(area, 2));
                                Console.WriteLine("\nAli Kurt               30");
                                Console.ReadLine();

                            }
                            else if (finish == false && area > 60)
                            {
                                Console.WriteLine("Please enter your name");
                                string name = Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine("---------HIGH SCORE TABLE---------\n");
                                Console.WriteLine("Name                   Score");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine(name + "                   " + Math.Round(area, 2));
                                Console.WriteLine("\nNazan Kaya          60\n" +
                                                  "Ali Kurt             30");



                                Console.ReadLine();


                            }

                            Console.Clear();
                            break;
                        }



                    //for option 2
                    case "2":
                        if (Ax != 0 && Ay != 0 && Bx != 0 && By != 0 && Cx != 0 && Cy != 0)
                        {
                            //Calculations for option 2
                            string typeangle1;
                            string typelength1;
                            if (angleA > 90 || angleB > 90 || angleC > 90)
                            {
                                typeangle1 = "Obtuse-angled";
                            }
                            else if (angleA == 90 || angleB == 90 || angleC == 90)
                            {
                                typeangle1 = "Right-angled";
                            }
                            else
                            {
                                typeangle1 = "Acute-angled";
                            }
                            if (acedge == abedge && abedge == bcedge)
                            {
                                typelength1 = "Equilateral Ship";
                            }
                            else if (acedge == abedge && abedge != bcedge || bcedge == acedge && acedge != abedge || bcedge == abedge && bcedge != acedge)
                            {
                                typelength1 = "Isosceles Ship";
                            }
                            else
                            {
                                typelength1 = "Scalene Ship";
                            }
                            //printing the information of the last ship used in the game
                            Console.WriteLine("\n\n\n*----------SHIP  INFO----------*");
                            Console.WriteLine("1.Length of the edges:   |AC|:" + Math.Round(acedge, 2) + "|AB|:" + Math.Round(abedge, 2) + "|BC|:" + Math.Round(bcedge, 2));
                            Console.WriteLine("2.Perimeter of the ship:" + Math.Round(perimeter, 2));
                            Console.WriteLine("3.Area of the ship:" + (area));
                            Console.WriteLine("4.The angles of the ship:   A°:" + Math.Round(angleA, 2) + " B°:" + Math.Round(angleB, 2) + " C°:" + Math.Round(angleC, 2));
                            Console.WriteLine("5.Median points of the ship:   AB:(" + Math.Round(abmedianx, 2) + ", " + Math.Round(abmediany, 2) + ")" + "  " + "AC:(" + Math.Round(acmedianx, 2) + ", " + Math.Round(acmediany, 2) + ")" + "  " + "BC:(" + Math.Round(bcmedianx, 2) + ", " + Math.Round(bcmediany, 2) + ")");
                            Console.WriteLine("6.The centroid of the ship:(" + Math.Round(centroidx, 2) + ", " + Math.Round(centroidy, 2) + ")");
                            Console.WriteLine("Length of bisector:" + Math.Round(bisector, 2));
                            Console.WriteLine("8.The area of the inscribed circle:" + Math.Round(incircle, 2));
                            Console.WriteLine("9.The area of circumscribed circle:" + Math.Round(circcircle, 2));
                            Console.WriteLine("10.Type of the ship:" + typeangle1 + "(" + typelength1 + ")");
                            Console.WriteLine("If you want to return menu, press enter");


                            Console.ReadLine();
                        }

                        else
                        {
                            Console.WriteLine("First you should enter ship location than you can see the ship info. Please press enter for return menu");
                            Console.ReadLine();

                        }
                        Console.Clear();
                        break;
                    //for option 3
                    case "3":
                        if (Ax != 0 && Ay != 0 && Bx != 0 && By != 0 && Cx != 0 && Cy != 0)
                        {
                            //Calculations for option 3
                            Random Rshoot1 = new Random();
                            int shootx1 = Rshoot1.Next(1, 31);
                            int shooty1 = Rshoot1.Next(1, 13);


                            Console.WriteLine("Shoot:" + shootx1 + (",") + shooty1);
                            Console.WriteLine("12|\n11|\n10| \n 9| \n 8| \n 7| \n 6| \n 5| \n 4| \n 3| \n 2| \n 1|\n   +-----------------------------\n   123456789012345678901234567890  ");
                            Console.SetCursorPosition(Ax + 2, 13 - Ay);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("A");
                            Console.SetCursorPosition(Bx + 2, 13 - By);
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("B");
                            Console.SetCursorPosition(Cx + 2, 13 - Cy);
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("C");
                            Console.SetCursorPosition(shootx1 + 2, 13 - shooty1);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("X");
                            Console.SetCursorPosition(0, 15);
                            Console.ForegroundColor = ConsoleColor.White;

                            axedge = Math.Sqrt((Math.Pow((Ax - shootx1), 2) + Math.Pow((Ay - shooty1), 2)));
                            bxedge = Math.Sqrt((Math.Pow((Bx - shootx1), 2) + Math.Pow((By - shooty1), 2)));
                            cxedge = Math.Sqrt((Math.Pow((Cx - shootx1), 2) + Math.Pow((Cy - shooty1), 2)));

                            angleD = Math.Acos((Math.Pow(bxedge, 2) + Math.Pow(axedge, 2) - Math.Pow(abedge, 2)) / (2 * axedge * bxedge)) * 180 / Math.PI;
                            angleE = Math.Acos((Math.Pow(cxedge, 2) + Math.Pow(axedge, 2) - Math.Pow(acedge, 2)) / (2 * axedge * cxedge)) * 180 / Math.PI;
                            angleF = Math.Acos((Math.Pow(cxedge, 2) + Math.Pow(bxedge, 2) - Math.Pow(bcedge, 2)) / (2 * bxedge * cxedge)) * 180 / Math.PI;




                            sangle = Convert.ToDouble(angleD + angleE + angleF);




                            if (Convert.ToInt32(sangle) == 360)
                            {
                                Console.WriteLine("Your ship sank! Total score is:0");
                                Console.ReadLine();
                                Console.WriteLine("---------HIGH SCORE TABLE---------\nName                     Score\nNazan Kaya                    60\n" +
                                       "Ali Kurt                   30\nSibel Arslan                 10");
                                Console.ReadLine();
                                Console.Clear();
                                break;

                            }
                            else if (((((shootx1 == Ax) && (shooty1 == Ay))) || (((shootx1 == Bx) && (shooty1 == By))) || (((shootx1 == Cx) && (shooty1 == Cy)))))
                            {
                                Console.WriteLine("Your ship sank! Total score is:0");
                                Console.ReadLine();
                                Console.WriteLine("---------HIGH SCORE TABLE---------\nName                     Score\nNazan Kaya                    60\n" +
                                       "Ali Kurt                   30\nSibel Arslan                 10");
                                Console.ReadLine();
                                Console.Clear();
                                break;
                            }

                            else
                            {

                                Console.WriteLine("Your ship survived! Total score is: " + Math.Round(area, 2));
                                Console.ReadLine();

                                if (area <= 10)
                                {
                                    Console.WriteLine("---------HIGH SCORE TABLE---------\nName                     Score\nNazan Kaya                    60\n" +
                                       "Ali Kurt                   30\nSibel Arslan                 10");
                                    Console.ReadLine();


                                }


                                else if (area > 10 && area <= 30)
                                {
                                    Console.WriteLine("Please enter your name");
                                    string name = Console.ReadLine();
                                    Console.Clear();
                                    Console.WriteLine("---------HIGH SCORE TABLE---------\n" +
                                        "Name                   Score\n" +
                                        "Nazan Kaya             60\n" +
                                       "Ali Kurt               30\n" +
                                       name + "                  " + Math.Round(area, 2));
                                    Console.ReadLine();


                                }
                                else if (area > 30 && area <= 60)
                                {
                                    Console.WriteLine("Please enter your name");
                                    string name = Console.ReadLine();
                                    Console.Clear();
                                    Console.WriteLine("---------HIGH SCORE TABLE---------\n" +
                                         "Name                   Score\n" +
                                         "Nazan Kaya             60\n" +
                                         name + "                   " + Math.Round(area, 2) +
                                        "\nAli Kurt               30");

                                    Console.ReadLine();

                                }
                                else if (area > 60)
                                {
                                    Console.WriteLine("Please enter your name");
                                    string name = Console.ReadLine();
                                    Console.Clear();
                                    Console.WriteLine("---------HIGH SCORE TABLE---------\n");
                                    Console.WriteLine("Name                   Score");
                                    Console.WriteLine(name + "                   " + area +
                                                      "\nNazan Kaya          60\n" +
                                                      "Ali Kurt             30");



                                    Console.ReadLine();


                                }
                                Console.Clear();


                            }

                        }
                        else
                        {
                            Console.WriteLine("First you should enter ship location than you can execute random shot. Please press enter for return menu");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }

                        break;
                    //For option 4
                    case "4":
                        //Print default high score table 
                        Console.WriteLine("---------HIGH SCORE TABLE---------\nName                   Score\nNazan Kaya             60\n" +
                                "Ali Kurt               30\nSibel Arslan           10");






                        Console.WriteLine("If you want to return menu press enter");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    //Exit game
                    case "5":
                        System.Environment.Exit(1);
                        break;

                    default:
                        Console.WriteLine("The value you entered is invalid. Press enter to return to the menu");
                        Console.ReadLine();
                        Console.Clear();

                        break;
                }

            } while (control == true);
        }
    }
}
        
