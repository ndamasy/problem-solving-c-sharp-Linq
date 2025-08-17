

using Day_01_G03;
using System.Net.Security;

namespace assignment_c__Linq_02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region LINQ – Transformation Operators
            #region  Return a sequence of just the names of a list of products.
            //var result =  ListGenerator.ProductsList.Select(p=>p.ProductName);
            //var result = from p in ListGenerator.ProductsList
            //             select p.ProductName;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region  Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
            //String [] words = {"aPPLE", "BlUeBeRrY", "cHeRry"};
            //var wordPairs = from w in words
            //               select new  {Upper = w.ToUpper(),Lower = w.ToLower() };

            //foreach (var item in wordPairs)
            //{
            //    Console.WriteLine($"Uppercase: {item.Upper},\n Lowercase: {item.Lower}");
            //}

            #endregion

            #region Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.
            //var result = ListGenerator.ProductsList.Select(p => new
            //{
            //    p.ProductName,
            //    p.UnitsInStock,
            //    Price = p.UnitPrice
            //});
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Product Name: {item.ProductName}, Units In Stock: {item.UnitsInStock}, Price: {item.Price}");
            //}
            #endregion

            #region  Determine if the value of int in an array matches their position in the array.

            // int [] Arr = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
            // var result = Arr.Select((value, index) => new { Value = value, Index = index })
            //        .Where(x => x.Value == x.Index);
            //  foreach (var item in result)
            //{
            //    if(item.Value == item.Index)
            //    {
            //        Console.WriteLine($"Value: {item.Value}, Index: {item.Index} - true");
            //        //Console.WriteLine("true");
            //    }else
            //        Console.WriteLine($"Value: {item.Value}, Index: {item.Index} - false");

            //}


            #endregion



            #endregion

            #region LINQ - Ordering Operators

            #region Sort a list of products by name
            //var result = ListGenerator.ProductsList.OrderBy(p => p.ProductName).ToList();
           
            //var result = from p in ListGenerator.ProductsList
            //             orderby p.ProductName
            //             select p;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            #region  Uses a custom comparer to do a case-insensitive sort of the words in an array.

            //String [] Arr = {"aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry"};

            #endregion

            #region  Sort a list of products by units in stock from highest to lowest.
            //var result = from p in ListGenerator.ProductsList
            //             orderby p.UnitsInStock descending
            //             select p;
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Product Name: {item.ProductName}, Units In Stock: {item.UnitsInStock}");
            //}
            #endregion


            #region  Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            //string [] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //var result = from num in Arr
            //             orderby num.Length,
            //                 num
            //             select num;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

                #endregion


            #region LINQ - Element Operators fluent syntax only

                #region Get first Product out of Stock
            //var result = ListGenerator.ProductsList.FirstOrDefault(p => p.UnitsInStock == 0);
            //if (result != null)
            //{
            //    Console.WriteLine($"First out of stock product: {result.ProductName}");
            //}
            //else
            //{
            //    Console.WriteLine("No products are out of stock.");
            //}
            #endregion

            #region Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            //var result = ListGenerator.ProductsList.FirstOrDefault(p => p.UnitPrice > 1000);
            //if (result != null)
            //{
            //    Console.WriteLine($"First product with price > 1000: {result.ProductName}, Price: {result.UnitPrice}");
            //}
            //else
            //{
            //    Console.WriteLine("No products found with price greater than 1000.");
            //}
            #endregion

            #region Retrieve the second number greater than 5 

           //int [] Arr = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

           // var result = Arr.Where(x => x > 5).Skip(1).FirstOrDefault();
           // if (result != 0)
           // {
           //     Console.WriteLine($"The second number greater than 5 is: {result}");
           // }
           // else
           // {
           //     Console.WriteLine("There is no second number greater than 5.");
           // }


            #endregion

            #endregion


            #region LINQ - Aggregate Operators

            #region Uses Count to get the number of odd numbers in the array
            //int [] Arr = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
            //var result= Arr.Count(x => x % 2 != 0);
            //Console.WriteLine($"The number of odd numbers in the array is: {result}");


            #endregion

            #region Return a list of customers and how many orders each has
            //var result = ListGenerator.CustomersList
            //    .Select(c => new
            //    {
            //        CustomerName = c.CustomerName,
            //        OrderCount = c.Orders.Count()
            //    });
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Customer Name: {item.CustomerName}, Order Count: {item.OrderCount}");
            //}
            #endregion

                #region . Return a list of categories and how many products each has
          
                #endregion


            #region  Get the total of the numbers in an array.
            int [] Arr = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
            var result = Arr.Sum(); 
            Console.WriteLine($"The total of the numbers in the array is: {result}");

            #endregion


            #endregion



        }
    }
}
