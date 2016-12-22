using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationExample1
{
   
    class Player
    {
        //Data Types
        private string name;
        private int age;
        private char gender;
        private string country;
        
        public Player()
        {
            name = "";
            age = 0;
            gender = '\0';
            country = "";
        }
        public Player(string name,int age,char gender,string country)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.country = country;
        }

        public void setName(string name)
        {
            this.name = name;
        }
        public void setAge(int age)
        {
            this.age = age;
        }
        public void setGender(char gender)
        {
            this.gender = gender;
        }
        public void setCountry(string country)
        {
            this.country = country;
        }
        public string getName()
        {
            return this.name;
        }
        public int getAge()
        {
            return this.age;
        }
        public string getCountry()
        {
            return this.country;
        }
        public char getGender()
        {
            return this.gender;
        }

    }

    class CricketPlayer:  Player
    {
        private int runs;
        private int wickets;
        private int noOfMatches;

        public CricketPlayer()
        {
            runs = 0;
            wickets = 0;
            noOfMatches = 0;
        }
        public CricketPlayer(int runs,int wickets,int noOfMatches)
        {
            this.runs = runs;
            this.wickets = wickets;
            this.noOfMatches = noOfMatches;
        }
        public int getRuns()
        {
            return this.runs;
        }
        public int getWickets()
        {
            return this.wickets;
        }
        public int getMatches()
        {
            return this.noOfMatches;
        }
        public void setRuns(int runs)
        {
            this.runs = runs;
        }
        public void setWickets(int wickets)
        {
            this.wickets = wickets;
        }
        public void setMatches(int matches)
        {
            this.noOfMatches = matches;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of players in a team");
            int n = Convert.ToInt16(Console.ReadLine());
            CricketPlayer[] sachin = new CricketPlayer[n];// Array of Objects
            for (int i = 0; i < n; i++)
                sachin[i] = new CricketPlayer();
            while (true)
            {
                Console.WriteLine("Enter the Choice\n 1. Enter the Details of selected Team Players \n 2. Display the Names of selected Team\n 3. Display the Details of a player\n 4.Exit");
                int choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        int k;
                        for (k = 0; k < n; k++)
                        {
                            Console.WriteLine("Enter the name");
                            sachin[k].setName(Console.ReadLine());
                            Console.WriteLine("Enter the Age");
                            sachin[k].setAge(Convert.ToInt16(Console.ReadLine()));
                            Console.WriteLine("Enter the Gender");
                            sachin[k].setGender(Convert.ToChar(Console.ReadLine()));
                            Console.WriteLine("Enter the Runs");
                            sachin[k].setRuns(Convert.ToInt32(Console.ReadLine()));
                            Console.WriteLine("Enter the Wickets");
                            sachin[k].setWickets(Convert.ToInt32(Console.ReadLine()));
                            Console.WriteLine("Enter the Number of Matches Played");
                            sachin[k].setMatches(Convert.ToInt32(Console.ReadLine()));
                            Console.WriteLine("----------------------------------------------------");
                        }
                            break;
                    case 2:
                            int i;
                            for (i = 0; i < n; i++)
                            {
                                Console.WriteLine("----------------------------------------------------");
                                Console.WriteLine(i+"  Name:           " + sachin[i].getName());
                                Console.WriteLine("----------------------------------------------------");
                            }
                            break;
                    case 3:
                            Console.WriteLine("----------------------------------------------------");
                            Console.WriteLine("enter the Id of the Player");
                            i = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine("Name:                              " + sachin[i].getName());
                            Console.WriteLine("Age:                               " + sachin[i].getAge());
                            Console.WriteLine("Gender:                            " + sachin[i].getGender());
                            Console.WriteLine("Runs:                              " + sachin[i].getRuns());
                            Console.WriteLine("Wickets:                           " + sachin[i].getWickets());
                            Console.WriteLine("Matches Played:                    " + sachin[i].getMatches());
                            Console.WriteLine("----------------------------------------------------");
                            break;
                    case 4: return ;         
                    default:
                            Console.WriteLine("Wrong Choice.select the right choice");
                            break;
                   
                }
            }
        }
    }
}
