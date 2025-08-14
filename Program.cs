namespace assignment_c__Linq_01
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region fluent syntax
            #region call linq operator in static methods
            //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
            //var OddNumbers = Enumerable.Where(numbers , n => n % 2 == 1).ToList();
            //foreach (var item in OddNumbers)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region call linq operator in extension method
            //var OddNumbers = numbers.Where( n => n % 2 == 1);
            //foreach (var item in OddNumbers)
            //{
            //    Console.WriteLine(item);
            //}   
            #endregion


            #endregion

            #region Linq excusion ways

            #region Deferred Excusion
            //List<int> numbers = new List<int> () { 1, 2, 3, 4, 5 };
            //var OddNumbers = numbers.Where(n => n % 2 == 1);
            //numbers.AddRange(new int[] { 6, 7, 8, 9, 10 });
            //foreach (var item in OddNumbers)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region immediate Excusion
            //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
            //List<int> OddNumbers = numbers.Where(n => n % 2 == 1).ToList();//linq operator to convert where output to list;
            //numbers.AddRange(new int[] { 6, 7, 8, 9, 10 });
            //foreach (var item in OddNumbers)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion



            #endregion

            #region data setup
            //Console.WriteLine(ListGenerator.ProductsList[3]);
            #endregion

            #region filtration [restrictions] operator - where
            // get element out of stock
            #region fluent syntax
            // 
            //var outOfStockProducts = ListGenerator.ProductsList.Where(p => p.UnitsInStock == 0);
            //foreach (var item in outOfStockProducts)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Query syntax
            //var outOfStockProducts = from p in ListGenerator.ProductsList
            //                        where p.UnitsInStock == 0
            //                        select p;
            //foreach (var item in outOfStockProducts)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            // Find all products that are in stock and cost more than 3.00 per unit.
            #region fluent syntax
            //var inStockProducts = ListGenerator.ProductsList
            //    .Where(p => p.UnitsInStock > 0 && p.UnitPrice>3);
            //foreach (var item in inStockProducts)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Query syntax
            //var inStockProducts = from p in ListGenerator.ProductsList
            //                     where p.UnitsInStock > 0 && p.UnitPrice > 3
            //                     select p;
            //foreach (var item in inStockProducts)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            //Returns digits whose name is shorter than their value
            #region fluent syntax
            //var shortNameDigits = ListGenerator.ProductsList
            //    .Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3);
            //foreach (var item in shortNameDigits)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Query syntax
            var shortNameDigits = from p in ListGenerator.ProductsList
                                  where p.UnitsInStock > 0 && p.UnitPrice > 3
                                  select p;
            foreach (var item in shortNameDigits)
            {
                Console.WriteLine(item);
            }

            #endregion
            #endregion




        }
    }
}
