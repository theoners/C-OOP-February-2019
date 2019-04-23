namespace _01.HarvestingFields
{
    using System.Linq;
    using System.Reflection;
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var classType = typeof(HarvestingFields);
            var fields = classType.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).ToList();

            var accessModifier = Console.ReadLine();
            while (accessModifier!="HARVEST")
            {
                if (accessModifier=="protected")
                {
                    accessModifier = "family";
                }

                if (accessModifier != "all")
                {
                    foreach (var field in fields.Where(f => f.Attributes.ToString().ToLower() == accessModifier))
                    {
                        PrintField(field);
                    }
                }
                else
                {
                    foreach (var field in fields)
                    {
                        PrintField(field);
                    }
                }
                accessModifier = Console.ReadLine();
            }
            
        }

        private static void PrintField(FieldInfo field)
        {
            var accessModifier = field.Attributes.ToString().ToLower();

            if (accessModifier=="family")
            {
                accessModifier = "protected";
            }
            Console.WriteLine($"{accessModifier} {field.FieldType.Name} {field.Name}");
        }
    }
}
