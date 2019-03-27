using System;
using System.Reflection;
using System.Text;

public class Spy
{
    public string RevealPrivateMethods(string className)
    {
        var classType = Type.GetType(className);
        var privateMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

        var stringBuilder = new StringBuilder();
        stringBuilder.AppendLine($"All Private Methods of Class: {className}");
        stringBuilder.AppendLine($"Base Class: {classType.BaseType.Name}");

        foreach (var method in privateMethods)
        {
            stringBuilder.AppendLine(method.Name);
        }

        return stringBuilder.ToString().Trim();
    }
}
