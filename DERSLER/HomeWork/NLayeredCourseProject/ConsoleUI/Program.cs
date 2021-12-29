using System;
using System.IO;
using System.Linq;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Newtonsoft.Json;
using Autofac.Extras.DynamicProxy;
using Business;
using Castle.DynamicProxy;


namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            
            //foreach (var product in productManager.GetAll().Data)
            //{
            //    string json = JsonConvert.SerializeObject(product, Formatting.Indented);
            //    Console.WriteLine(json);
            //}
            //Console.WriteLine("ProductManager Get All Methodu Çağırıldığında Gelen MESAJ : {0}", productManager.GetAll().Message);
            //Console.WriteLine("Success Bilgisi  : {0}", productManager.GetAll().Success);

            //string fullJson = JsonConvert.SerializeObject(productManager.GetAll(), Formatting.Indented);
            //Console.WriteLine(fullJson);

            Product product = new Product
            {
                ProductName = "xynıBeaaa",
                CategoryId = 1,
                UnitPrice = 5,
                UnitsInStock = 10
            };

            Console.WriteLine(productManager.Update(product).Message);

            // Named registration

            //builder.Register(c => new CallLogger(Console.Out))
            //    .Named<IInterceptor>("log-calls");

            // Typed registration
            //builder.Register(c => new CallLogger(Console.Out));


            //First first = new First();

            //Console.WriteLine(first.GetValue());

        }

        public class CallLogger : IInterceptor
        {
            TextWriter _output;

            public CallLogger(TextWriter output)
            {
                _output = output;
            }

            public void Intercept(IInvocation invocation)
            {
                _output.Write("Calling method {0} with parameters {1}... ",
                    invocation.Method.Name,
                    string.Join(", ", invocation.Arguments.Select(a => (a ?? "").ToString()).ToArray()));

                invocation.Proceed();

                _output.WriteLine("Done: result was {0}.", invocation.ReturnValue);
            }
        }


        [Intercept(typeof(CallLogger))]
        public class First
        {
            public virtual int GetValue()
            {
                return 10;
            }
        }
    }
}
