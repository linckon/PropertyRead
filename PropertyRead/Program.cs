using PropertyRead.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PropertyRead
{
    class Program
    {
        static void Main(string[] args)
        {
            // get all public static properties of MyClass type
            Console.WriteLine("NewPriceListEmailDto");
            PropertyInfo[] parentPropertyInfos = typeof(NewPriceListEmailDto).GetProperties();
            // sort properties by name
            //Array.Sort(propertyInfos,
            //        delegate (PropertyInfo propertyInfo1, PropertyInfo propertyInfo2)
            //        { return propertyInfo1.Name.CompareTo(propertyInfo2.Name); });

            // write property names
            foreach (PropertyInfo propertyInfo in parentPropertyInfos)
            {
                Console.WriteLine(" \t {0}", propertyInfo.Name);
                
            }
            PropertyInfo[] secondChildPropertyInfos = typeof(NewPriceListDto).GetProperties();
            foreach (PropertyInfo propertyInfo in secondChildPropertyInfos)
            {
                Console.WriteLine(" \t \t {0}", propertyInfo.Name);

            }
            PropertyInfo[] thirdChildPropertyInfos = typeof(NewPriceListProductDto).GetProperties();
            foreach (PropertyInfo propertyInfo in thirdChildPropertyInfos)
            {
                Console.WriteLine(" \t \t \t{0}", propertyInfo.Name);
            }
            //Assembly core = AppDomain.CurrentDomain.GetAssemblies().FirstOrDefault(x => x.FullName.StartsWith("PropertyRead"));
            //Type entity = core.ExportedTypes.FirstOrDefault(x => x.Name == "NewPriceListEmailDto");
            //Console.WriteLine(entity.Name);
            //var parent = new NewPriceListEmailDto();
            //var parentPropertyName = parent.GetMemberName(x => x.NewPriceListDtoItems);
            //Console.WriteLine(" \t {0}", parentPropertyName);


            //NewPriceListDto client = new NewPriceListDto();
            //var secondChildPropertyNames = client.GetMemberNames(c => c.PriceListName,c=>c.PriceListType,c=>c.UpdatedOn,c=>c.NewPriceListProductDtoItems);

            //foreach (var cPropertyName in secondChildPropertyNames)
            //{
            //    Console.WriteLine(" \t \t{0}", cPropertyName);

            //}
            //NewPriceListProductDto _NewPriceListProductDto = new NewPriceListProductDto();
            //var thirdChildItems = _NewPriceListProductDto.GetMemberNames(c => c.ProductName, c => c.ProductImage, c => c.VendorCode, c => c.Description);
            //foreach (var item in thirdChildItems)
            //{
            //    Console.WriteLine(" \t \t \t {0}", item);
            //}
            Console.ReadLine();
        }
    }
}
