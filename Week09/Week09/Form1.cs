using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Week09.Entities;

namespace Week09
{
    public partial class Form1 : Form
    {
        List<Person> Population = new List<Person>();
        List<BirthProbability> BirthProbabilities = new List<BirthProbability>();
        List<DeathProbability> DeathProbabilities = new List<DeathProbability>();
        Random rng = new Random(1234);

        public Form1()
        {
            InitializeComponent();

            Population = GetPopulation(@"C:\Windows\Temp\név.csv");
            BirthProbabilities = GetBirthProbabilities(@"C:\Windows\Temp\születés.csv");
            DeathProbabilities = GetDeathProbabilities(@"C:\Windows\Temp\halál.csv");


        }

        private void Simulator() 
        {
            for (int year = 2005; year <= 2024; year++) //vizsgált évek
            {
                for (int p = 0; p < Population.Count; p++) //vizsgált összes személy
                {
                    //SimStep(year, person);
                }

                int nbrOfMales = (from m in Population
                                  where m.Gender == Gender.Male && m.IsAlive
                                  select m).Count();

                int nbrOfFemales = (from f in Population
                                    where f.Gender == Gender.Female && f.IsAlive
                                    select f).Count();

                Console.WriteLine(string.Format("Év:{0} Fiúk{1} Lányok{2}", year, nbrOfMales, nbrOfFemales));
            }
        }

        private void SimStep(int year, Person person) 
        {
            if (person.IsAlive == false)
            {
                return;
            }

            byte age = (byte)(year - person.BirthYear);

            //halálozási valószínűség lekérdezése
            double dprob = (from dp in DeathProbabilities
                         where dp.Gender == person.Gender && dp.Age == age
                         select dp.DProb).FirstOrDefault();


            //az adott személy meghal-e?
            if (rng.NextDouble() <= dprob)
            {
                person.IsAlive = false;
            }

            if (person.IsAlive && person.Gender == Gender.Female)
            {
                //születési valószínűség lekérdezése
                double bprob = (from bp in BirthProbabilities
                                where bp.Age == age
                                select bp.BProb).FirstOrDefault();

                //születik-e gyermek?
                if (rng.NextDouble() >= bprob)
                {
                    Person newborn = new Person();
                    newborn.BirthYear = year;
                    newborn.Gender = (Gender)(rng.Next(1, 3));
                    newborn.NbrOfChildren = 0;
                    Population.Add(newborn);
                }
            }

        }


        public List<Person> GetPopulation(string csvpath) 
        {
            List<Person> population = new List<Person>();

            StreamReader sr = new StreamReader(csvpath, Encoding.Default);

            while (!sr.EndOfStream) 
            {
                var line = sr.ReadLine().Split(';');
                population.Add(new Person()
                {
                    BirthYear = int.Parse(line[0]),
                    Gender = (Gender)Enum.Parse(typeof(Gender), line[1]),
                    NbrOfChildren = int.Parse(line[2])

                });
                    
                    
            }

            return population;
        }

        public List<BirthProbability> GetBirthProbabilities(string csvpath)
        {
            List<BirthProbability> birthprob = new List<BirthProbability>();

            StreamReader sr = new StreamReader(csvpath, Encoding.Default);

            while (!sr.EndOfStream)
            {
                var line = sr.ReadLine().Split(';');
                birthprob.Add(new BirthProbability()
                {
                    Age = int.Parse(line[0]),
                    NbrOfChildren = int.Parse(line[1]),
                    BProb = double.Parse(line[2])

                });


            }

            return birthprob;
        }

        public List<DeathProbability> GetDeathProbabilities(string csvpath)
        {
            List<DeathProbability> deathprob = new List<DeathProbability>();

            StreamReader sr = new StreamReader(csvpath, Encoding.Default);

            while (!sr.EndOfStream)
            {
                var line = sr.ReadLine().Split(';');
                deathprob.Add(new DeathProbability()
                {
                    Gender = (Gender)Enum.Parse(typeof(Gender), line[0]),
                    Age = int.Parse(line[1]),
                    DProb = double.Parse(line[2])

                });


            }

            return deathprob;
        }
    }
}
