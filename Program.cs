using System;

namespace Prac4 {

    public class Task1 {
        
        string[] months = {
            "January", 
            "February", 
            "March", 
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"
        };

        public void getMonthsOfLen(int n) {
            
            var selectedMonths = from month in months
                where (month.Length == n)
                orderby month
                select month;

            foreach(string item in selectedMonths) {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");
            
        }

        public void getSummerWinterMonths() {

            var selectedMonths = from month in months
                where ( (month == "January") || (month == "February") || (month == "December") || (month == "June") || (month == "July") || (month == "August") )
                orderby month
                select month;

            foreach(string item in selectedMonths) {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");
        }

        public void printAlphabetically() {

        }

        public void getMonthsWithUandLenOfFour() {

        }

    }
    
    public class Program {

        public static void Main(string[] args) {

            Task1 monthsTask = new Task1();
            monthsTask.getMonthsOfLen(7);
            monthsTask.getMonthsOfLen(8);
            monthsTask.getSummerWinterMonths();


        }

    }


}


