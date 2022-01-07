using System;
using System.Collections.Generic;



namespace Take_Home_Assignment_Week_12_AngellieEnnovarynM_0706022110042
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu \n1. Urut berdasarkan nama belakang (Ascending) \n2. Urut berdasarkan Nama Depan (Ascending), kemudian Experience Year nya (Ascending) \n3. Munculkan Nama dengan tahun lahir dibawah input");
            Console.Write("Pilih menu yang akan dipilih: ");
            int pilihanMenu = Convert.ToInt16(Console.ReadLine());

            // List of string 
            List<string> firstNames = new List<string>() { "Clifftion, Billy, Brian, Yohan, Billy, Billy, Billy" };
            List<string> lastNames = new List<string>() { "Sunarto, Agustian, Putrantio, Anthony, Panjaitan, Anthony, Jefferson" };
            List<DateTime> dateOfBirth = new List<DateTime> { Convert.ToDateTime("12-Feb-03"), Convert.ToDateTime("06-Oct-03"), Convert.ToDateTime("09-Aug-98"), Convert.ToDateTime("10-Jun-01"), Convert.ToDateTime("06-Aug-00"), Convert.ToDateTime("09-Dec-02"), Convert.ToDateTime("11-Feb-97") };
            List<int> yearOfExperiences = new List<int> { 4, 5, 7, 2, 4, 3, 6 };

            var person0 = $"{firstNames[0]} {lastNames[0]} ~ {dateOfBirth[0]} ~ {yearOfExperiences[0]}";
            var person1 = $"{firstNames[1]} {lastNames[1]} ~ {dateOfBirth[1]} ~ {yearOfExperiences[1]}";
            var person2 = $"{firstNames[2]} {lastNames[2]} ~ {dateOfBirth[2]} ~ {yearOfExperiences[2]}";
            var person3 = $"{firstNames[3]} {lastNames[3]} ~ {dateOfBirth[3]} ~ {yearOfExperiences[3]}";
            var person4 = $"{firstNames[4]} {lastNames[4]} ~ {dateOfBirth[4]} ~ {yearOfExperiences[4]}";
            var person5 = $"{firstNames[5]} {lastNames[5]} ~ {dateOfBirth[5]} ~ {yearOfExperiences[5]}";
            var person6 = $"{firstNames[6]} {lastNames[6]} ~ {dateOfBirth[6]} ~ {yearOfExperiences[6]}";

            if (pilihanMenu == 1)
            {
                // Sort list of lastNames  
                lastNames.Sort();
                Console.WriteLine();

                // Print sorted items  
                foreach (var lastName in lastNames)
                    Console.WriteLine(lastNames);
            }

            else if (pilihanMenu == 2)
            {
                // Sort list of fisrtNames  
                firstNames.Sort();
                Console.WriteLine();

                // Print sorted items  
                foreach (var firstName in firstNames)
                    Console.WriteLine(firstNames);


                // Sort list of Experience
                yearOfExperiences.Sort();
                Console.WriteLine();

                // Print sorted items  
                foreach (var yearOfExperience in yearOfExperiences)
                    Console.WriteLine(yearOfExperiences);

            }

            else if (pilihanMenu == 3)
            {
                Console.Write("Tahun lahir di bawah tahun : ");
                int Year = Convert.ToInt16(Console.ReadLine());

                int idx = dateOfBirth.IndexOf(person);
                if (idx > 0)
                    Console.WriteLine($"Terdapat nama dengan tahun lahir nya : {idx}");
                else
                    Console.WriteLine("Tidak ada nama dengan tahun lahir dibawah {year} ");
            }
        }
    }
}

