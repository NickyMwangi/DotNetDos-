using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Loggers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPerformance
{
    [SimpleJob(RuntimeMoniker.Net60)]
    [SimpleJob(RuntimeMoniker.Net70)]
    [MemoryDiagnoser(false)]
    public class Linqs
    {

        private IEnumerable<ProductDto> prods;

        private ICollection<ProductDto> ColProds;

        private IList<ProductDto> ListProds;

        [GlobalSetup]
        public void Setup()
        {
            IEnumerable<ProductDto> products = new ProductDto[]
            {
                new ProductDto { Id = 1, Name = "Potatoes", Description = "For cooking chips", Quantity = 1, BuyingPrice = 70, SellingPrice = 100 },
                new ProductDto { Id = 1, Name = "Tomatoes", Description = "For cooking chips", Quantity = 1, BuyingPrice = 40, SellingPrice = 50 },
                new ProductDto { Id = 1, Name = "T-Shirts", Description = "For cooking chips", Quantity = 1, BuyingPrice = 500, SellingPrice = 1500 },
                new ProductDto { Id = 1, Name = "Laptops", Description = "For cooking chips", Quantity = 1, BuyingPrice = 61000, SellingPrice = 100000 },
                new ProductDto { Id = 1, Name = "Fridge", Description = "For cooking chips", Quantity = 1, BuyingPrice = 56230, SellingPrice = 125320 },
                new ProductDto { Id = 1, Name = "Microwave", Description = "For cooking chips", Quantity = 1, BuyingPrice = 2314, SellingPrice = 5523 },
                new ProductDto { Id = 1, Name = "Mouse", Description = "For cooking chips", Quantity = 1, BuyingPrice = 500, SellingPrice = 1100 },
                new ProductDto { Id = 1, Name = "Keyboard", Description = "For cooking chips", Quantity = 1, BuyingPrice = 4520, SellingPrice = 15230 }
            };
            prods = products;
            ColProds = products.ToArray(); // ToArray() is faster than ToList()
            ListProds = products.ToArray();
        }

        #region IEnumerable
        /**
         * list or a container that can hold items/objects
         * Basic features to iterate through the list of items/objects
         * Cannot edit items like add, delete or update. 
         * Will call database for each product
         * https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable?view=net-7.0
         */
        [Benchmark]
        public void LogIEnume()
        {
            foreach (var item in prods)
            {
                Console.WriteLine($"IEnumerable -  {item.Name}");
            }
        }
        #endregion



        #region ICollections
        /**
         * implements an IEnumerable
         * Adds funtionality like add, remove, update to an enumerable
         */
        [Benchmark]
        public void LogICol()
        {
            foreach (var item in ColProds)
            {
                Console.WriteLine($"ICollection -  {item.Name}");
            }
        }
        #endregion



        #region IList
        /**
         * Extends an ICollection
         * Supports all operations combined from IEnumerable and ICollection like
         * Add, remove, update at specific index in the list 
         */
        [Benchmark]
        public void LogIList()
        {
            Console.WriteLine($"{ListProds.Count()} List");
            foreach (var item in ListProds)
            {
                Console.WriteLine($"IList -  {item.Name}");
            }
        }
        #endregion
    }
}
