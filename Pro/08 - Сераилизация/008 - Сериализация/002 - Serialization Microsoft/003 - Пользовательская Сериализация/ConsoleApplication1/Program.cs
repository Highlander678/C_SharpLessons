using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace ConsoleApplication1
{
    public class User
    {
        public int Id { get; set; }
        public String Name { get; set; }
    }
    class Program
    {
        private static List<User> users;

         static Program()
        {
            users = new List<User>
                        {
                            new User{Id=1,Name="Alex"},
                            new User{Id=2,Name="Anna"}
                        };
        }

        static void Main(string[] args)
        {
            var jSerialize = new JavaScriptSerializer();
            string json = jSerialize.Serialize(users);
            Console.WriteLine(json);
            List<User> usersnew = jSerialize.Deserialize<List<User>>(json);

            Console.ReadKey();

        }
    }
}
