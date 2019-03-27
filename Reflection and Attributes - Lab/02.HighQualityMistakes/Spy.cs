using System;
using System.Linq;
using System.Reflection;
using System.Text;

public class Spy
{

    public string AnalyzeAcessModifiers(string className)
    {
        var classType = Type.GetType(className);
        var fields = classType.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
        var publicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.Public);
        var nonPublicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

        var stringBuilder = new StringBuilder();

        foreach (var field in fields)
        {
            stringBuilder.AppendLine($"{field.Name} must be private!");
        }

        foreach (var method in nonPublicMethods.Where(m=>m.Name.StartsWith("get")))
        {
            stringBuilder.AppendLine($"{method.Name} have to be public!");
        }

        foreach (var method in publicMethods.Where(m => m.Name.StartsWith("set")))
        {
            stringBuilder.AppendLine($"{method.Name} have to be private!");
        }

        return stringBuilder.ToString().Trim();
    }
}
