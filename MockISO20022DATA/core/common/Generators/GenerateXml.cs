
using System.Reflection;
using System.Xml;
using datapltf.pacs.aggregate;

namespace datapltf.core.common.generators;

public class GenerateXml : Generate
{
  public static string UpdateXmlInnerText(XmlDocument inputXml, List<string> methodList, FIToFIPaymentStatusReportV12_XML classInstance)
  {
    if (inputXml == null)
    {
      throw new NotImplementedException($"{inputXml.DocumentElement} is null");
    }
    try
    {
      XmlDocument copyXml = (XmlDocument)inputXml.Clone();
      if (copyXml.DocumentElement != null)
      {
        ReplaceTextInNodes(copyXml.DocumentElement, methodList, classInstance);
      }

      StringWriter sw = new StringWriter();
      XmlWriter xw = new XmlTextWriter(sw);
      copyXml.WriteTo(xw);
      return sw.ToString();

    }
    catch (XmlException ex)
    {
      throw new NotImplementedException($"Error parsing XML: {ex.Message}");
    }
    catch (Exception ex)
    {
      throw new NotImplementedException($"An error occurred: {ex.Message}");
    }
  }

  private static void ReplaceTextInNodes(XmlNode node, List<string> methodList, FIToFIPaymentStatusReportV12_XML classInstance)
  {
    if (node.NodeType == XmlNodeType.Element && node.HasChildNodes)
    {
      for (int i = 0; i < node.ChildNodes.Count; i++)
      {
        XmlNode childNode = node.ChildNodes[i];
        if (methodList.Contains(childNode.InnerText) && childNode is not System.Xml.XmlWhitespace)
        {
          Type type = classInstance.GetType();
          MethodInfo method = type.GetMethod(childNode.InnerText);
          childNode.InnerText = method.Invoke(classInstance, null).ToString();
        }
        else
        {
          ReplaceTextInNodes(childNode, methodList, classInstance);
        }
      }
    }
  }
}