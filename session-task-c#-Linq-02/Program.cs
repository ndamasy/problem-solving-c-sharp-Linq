namespace assignment_c__Linq_02
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List <string> names = new List<string>
            {
                "Ahmed", "Ali","Mona", "Sara","Omar","Sameer","Salma","Mostafa"

            };

            List <int> numbers = new List<int>
            {
                10,3,7,15,22,5,8,30
            };
            #region Filtration
            //numbers greater than 10
            //var greaterThanTen = numbers.Where(n => n > 10);
            //foreach (var number in greaterThanTen)
            //{
            //    Console.WriteLine(number);
            //}
            //names that start with s
            //var namesStartingWithS = names.Where(n => n.StartsWith("S"));
            //foreach (var name in namesStartingWithS)
            //{
            //    Console.WriteLine(name);
            //}
            #endregion

            #region Element
            //First element in the list
            //var firstNameInList = names.First();
            //Console.WriteLine(firstNameInList);

            ////Last element in the numbers list
            //var LastNumberInList = numbers.Last();
            //Console.WriteLine(LastNumberInList);
           
            //first number more than 20 or 10 if not found

            #endregion

            #region Casting
            //convert arr list of mixed int and double to double only using casting or oftype
            //List<object> mixedList = new List<object> { 1, 2.5, 3, 4.8, 5 };
            //var doubleList = mixedList.OfType<double>().ToList();
            //foreach (var item in doubleList)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Generation
            //Generate list of 5 even numbers using Enumerable.Range or repeat
            //List<int> evenNumbers = Enumerable.Range(1, 5).Select(x => x * 2).ToList();
            //foreach (var number in evenNumbers)
            //{
            //    Console.WriteLine(number);
            //}
            #endregion

            #region Ordring
            // arrange names in ascending order
            //var orderedNames = names.OrderBy(n => n);
            //foreach (var name in orderedNames)
            //{
            //    Console.WriteLine(name);
            //}
            //arrange numbers in descending order
            //var orderedNumbers = numbers.OrderByDescending(n => n);
            //foreach (var number in orderedNumbers)
            //{
            //    Console.WriteLine(number);
            //}
            #endregion

        }
    }
}
