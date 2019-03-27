using System;
using System.Linq;
using System.Reflection;
using System.Text;

public class Spy
{
    public string CollectGettersAndSetters(string className)
    {
        var classType = Type.GetType(className);
        var allMethods = classType.GetMethods(BindingFlags.Instance|BindingFlags.Static | BindingFlags.NonPublic|BindingFlags.Public);

        var stringBuilder = new StringBuilder();
        
        foreach (var method in allMethods.Where(m=>m.Name.StartsWith("get")))
        {
            stringBuilder.AppendLine($"{method.Name} will return {method.ReturnType}");
        }


        foreach (var method in allMethods.Where(m => m.Name.StartsWith("set")))
        {
            stringBuilder.AppendLine($"{method.Name} will set field of {method.GetParameters().First().ParameterType}");
        }

        return stringBuilder.ToString().Trim();
    }
}
