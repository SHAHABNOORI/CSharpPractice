using System;

namespace ShallowCopyVsDeepCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            //test();
            Company c1 = new Company(548, "GeeksForGeeks", "Sandeep Jain");

            // Performing Shallow copy                      
            Company c2 = (Company)c1.DeepCopy();

            Console.WriteLine("Before Changing: ");

            // Before changing the value of
            // c2 GBRank and CompanyName
            Console.WriteLine(c1.GbRank);
            Console.WriteLine(c2.GbRank);
            Console.WriteLine(c2.Desc.CompanyName);
            Console.WriteLine(c1.Desc.CompanyName);

            // changing the value of c2 GBRank
            // and CompanyName
            c2.GbRank = 59;
            c2.Desc.CompanyName = "GFG";

            Console.WriteLine("\nAfter Changing: ");

            // After changing the value of 
            // c2 GBRank and CompanyName
            Console.WriteLine(c1.GbRank);
            Console.WriteLine(c2.GbRank);
            Console.WriteLine(c2.Desc.CompanyName);
            Console.WriteLine(c1.Desc.CompanyName);
        }

        private static void test()
        {
            // Random Social Security Number Generator, which returns a tuple (int threeDigits, int twoDigits,int fourDigits)
            // xxx-xx-xxxx format
            SsnGenerator ssnGenerator = new(new Random());

            Staff hrStaff = new(new QuickInfo("Jessy", "Herolt"),
                new DetailedInfo(Guid.NewGuid(),
                    "0001-89938749928-388293",
                    "Budgie Str. Cathood Avn. 33242 / 233",
                    new DateTime(1990, 03, 1), ssnGenerator.Ssn),
                "dummyData");


            Staff shallowCopy = hrStaff.ShallowCopy();
            Staff deepCopy = hrStaff.DeepCopy();

            Print(hrStaff, "Original");

            // alter the values in hrStaff , DummyData is the only primitive type in Staff class
            hrStaff.QuickInformation.FirstName = "Dalton";
            hrStaff.QuickInformation.LastName = "Mayer";
            hrStaff.DummyData = "DummyData changed";
            hrStaff.DetailedInformation.Id = Guid.NewGuid();
            hrStaff.DetailedInformation.IBAN = "0001-19958649928-088293";
            hrStaff.DetailedInformation.Address = "Nowhere";
            hrStaff.DetailedInformation.BirthDate = new DateTime(1956, 1, 2);
            hrStaff.DetailedInformation.SSN = ssnGenerator.Ssn;

            Print(shallowCopy, "Shallow Copy");
            Print(deepCopy, "Deep Copy");


            static void Print(Staff hrStaff, string copyType)
            {
                Console.WriteLine($"{copyType}\n");
                Console.WriteLine(
                    $"FirstName:{hrStaff.QuickInformation.FirstName}\nLastName:{hrStaff.QuickInformation.LastName}\nDummyData:{hrStaff.DummyData}\n" +
                    $"Detailed Information:\n" +
                    $"  Id:{hrStaff.DetailedInformation.Id}\n  IBAN:{hrStaff.DetailedInformation.IBAN}\n" +
                    $"  Address:{hrStaff.DetailedInformation.Address}\n  BirthDate:{hrStaff.DetailedInformation.BirthDate}\n" +
                    $"  SSN:{hrStaff.DetailedInformation.SSN.treeDigits}-" +
                    $"{hrStaff.DetailedInformation.SSN.twoDigits}-" +
                    $"{hrStaff.DetailedInformation.SSN.fourDigits}\n");
            }
        }
    }
}
