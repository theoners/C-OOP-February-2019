    using System;
    using System.Linq;
    using System.Reflection;
    using System.Text;

    public class Spy
    {
        public string StealFieldInfo(string className, params string[] requestedFields)
        {

            var classType = Type.GetType(className);
            var fields = classType.GetFields(BindingFlags.Instance | BindingFlags.Static |
                                             BindingFlags.NonPublic | BindingFlags.Public)
                .Where(f => requestedFields.Contains(f.Name));
            var stringBuilder = new StringBuilder();

            var classInstance = Activator.CreateInstance(classType, new object[] { });


            stringBuilder.AppendLine($"Class under investigation: {classType}");

            foreach (var field in fields)
            {
                stringBuilder.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
            }

            return stringBuilder.ToString().Trim();
        }
    }
