using ConsoleApp9.NewFolder;
using System.Reflection;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(User);
            //PropertyInfo[]properties = type.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic); 
            //foreach (PropertyInfo property in properties)
            //{

            //    Console.WriteLine(property.Name); 
            //}



            User user = new User(); 
            PropertyInfo propId=type.GetProperty("Id",BindingFlags.Instance|BindingFlags.NonPublic);
            propId.SetValue(user, 10);
            Console.WriteLine(propId.GetValue(user));
            PropertyInfo propName = type.GetProperty("Name", BindingFlags.Instance | BindingFlags.NonPublic);
            propName.SetValue(user, "Murad");
            Console.WriteLine(propName.GetValue(user));
            PropertyInfo propSurname = type.GetProperty("Surname", BindingFlags.Instance | BindingFlags.NonPublic);
            propSurname.SetValue(user, "Mecidov");
            Console.WriteLine(propSurname.GetValue(user));
            PropertyInfo propAge = type.GetProperty("Age", BindingFlags.Static | BindingFlags.NonPublic);
            propAge.SetValue(user, 21);
            Console.WriteLine(propAge.GetValue(user));

            MethodInfo getFullNameMethod = type.GetMethod("GetFullName", BindingFlags.Public | BindingFlags.Instance);
            getFullNameMethod.Invoke(user, null);

            MethodInfo changeAgeMethod = type.GetMethod("ChangeAge", BindingFlags.Public | BindingFlags.Static);
            changeAgeMethod.Invoke(user, new object[] {30} );




            // Assembly assembly = Assembly.GetExecutingAssembly();



        }
    }
}