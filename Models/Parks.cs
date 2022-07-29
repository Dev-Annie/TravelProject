//using System;
//using System.Collections.Generic;

//namespace TravelProject.Models
//{

//public class Parks
//{
//    public string Parkname;
//    public int Fee;

//        public string City { get; internal set; }
//        public bool MakeModel { get; internal set; }

//        public bool WorthBuying(int maxFee)
//    {
//        return (Fee <= maxFee);
//    }
//}

//public class Program
//{
//    public static void Main()
//    {
//        Parks one = new Parks();
//        one.City = "Jaco";
//        one.Fee = 1100;
      

//        Parks two = new Parks();
//        two.City = "Jaco";
//        two.Fee = 700;
   

//        Parks three = Parks();
//        three.City = "Cartago";
//        three.Fee = 1400;
        

//        Parks four = new Parks();
//        four.City = "Limon";
//        four.Fee = 400;
        

//        List<Parks> Cars = new List<Parks>() { one, two, three, four };

//        Console.WriteLine("Enter maximum price: ");
//        string stringMaxPrice = Console.ReadLine();
//        int maxPrice = int.Parse(stringMaxPrice);

//        List<Parks> ParksMatchingSearch = new List<Parks>(0);

//        foreach (Parks nature in Parks)
//        {
//            if (nature.WorthBuying(maxPrice))
//            {
//                ParksMatchingSearch.Add(nature);
//            }
//        }

//        foreach (Parks nature in ParksMatchingSearch)
//        {
//            Console.WriteLine(nature.MakeModel);
//        }
//    }
//}