using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace лаба_11
{
    static class Reflector
    {
        private static ArrayList infoClass = new ArrayList();

        public static void InfoBuild(Type type)
        {
            Assembly assembly = Assembly.GetAssembly(type);

            infoClass.Add(assembly.FullName);

            Console.WriteLine(assembly.FullName);
        }

        public static void GetClassName(Type type)
        {
            infoClass.Add(type.Name);
            Console.WriteLine(type.Name);
        }

        public static void Constructors(Type type) {
            var constructors = type.GetConstructors();

            bool hasPublic = constructors.Any(c => c.IsPublic);

            infoClass.Add(hasPublic);

            Console.WriteLine(hasPublic);
        }

        public static List<string> GetPublicMethods(Type type)
        {
            var publicMethods =  type.GetMethods().Where(m => m.IsPublic);

            List<string> MethodName = new List<string>();   

            foreach (var method in publicMethods)
            {
                MethodName.Add(method.Name);
                infoClass.Add(method.Name);
            }

            return MethodName;
        }

        public static List<string> GetFieldAndProperty(Type type)
        {
            List<string> fieldsAndProperty = new List<string>();

            if (type.GetFields().Count() == 0)
            {
                fieldsAndProperty.Add("Публичных методов нет");
                return fieldsAndProperty;
            }

            foreach (FieldInfo field in type.GetFields())
            {
                string str = $"Поле: {field.Name}, Тип: {field.FieldType}";
                fieldsAndProperty.Add(str);
                infoClass.Add(str);
            }
            
            foreach (PropertyInfo property in type.GetProperties())
            {
                string str = $"Свойство: {property.Name}, Тип: {property.PropertyType}";
                fieldsAndProperty.Add(str);
                infoClass.Add(str);
            }

            return fieldsAndProperty;
        }


        public static List<string> GetPublicMethodsSort(Type type, string NameMethod)
        {
            List<string> MethodName = new List<string>();

            var publicMethods = type.GetMethods().Where(m => m.IsPublic);

            if (publicMethods.Count() == 0)
            {
                MethodName.Add("Публичных методов нет");
                return MethodName;
            }

            foreach (var method in publicMethods)
                if (method.Name == NameMethod)
                    MethodName.Add(method.Name);

            infoClass.Add(MethodName);

            return MethodName;
        }
        
        public static List<string> GetInterface(Type type)
        {
            List<string> interfacesName = new List<string>();

            var interfaces = type.GetInterfaces();

            if(interfaces.Count() == 0)
            {
                interfacesName.Add("Интерфейсов нет");
                return interfacesName;
            }

            foreach (var elem in interfaces)
               interfacesName.Add(elem.Name);

            infoClass.Add(interfacesName);

            return interfacesName;
        }

        public static void WriteToFile(string nameFile)
        {

            File.AppendAllText(nameFile, $"---------------------------------------\n");
            foreach (var element in infoClass)
            {
                File.AppendAllText(nameFile, $"{element}\n");
            }
            File.AppendAllText(nameFile, $"---------------------------------------\n");
        }

        public static void DeleteContentFile(string nameFile)
        {
            File.WriteAllText(nameFile, string.Empty);
        }

        public static void InvokeMethod(string nameFile, object instance, string methodName, object[] parametrs)
        {
            Type type = instance.GetType();

            string fileText = File.ReadAllText(nameFile);
            string[] list = fileText.Split('\n');

            int result = Array.IndexOf(list, methodName);

            if (result >= 0)
            {
                var method = type.GetMethod(methodName);

                method.Invoke(instance, parametrs);
            }

            
        }

        public static T Create<T>()
        {
            Type type = typeof(T);
            ConstructorInfo constructor = type.GetConstructor(BindingFlags.Public | BindingFlags.Instance, null, Type.EmptyTypes, null);


            return (T)constructor.Invoke(null);
        } 
    }
}
