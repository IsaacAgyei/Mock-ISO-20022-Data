
using System.Reflection;


namespace datapltf.core.common.generators;

public class Generate
{

  public static string alphaNumeric = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
  public static string upperAlphaNumeric = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
  public static string lowerAlphaNumeric = "abcdefghijklmnopqrstuvwxyz0123456789";
  public static List<string> MethodNames(object obj)
  {
    Type type = obj.GetType();
    return [.. type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly).Select(method => method.Name)];
  }

}