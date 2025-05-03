using System.Text.Json;
using System.Text.Json.Nodes;
using System.Xml;
using datapltf.core.common.generators;
using datapltf.pacs.aggregate;
using Microsoft.AspNetCore.Mvc;

namespace datapltf.controller.pacs;

[Controller]
[Route("api/v1/[controller]/")]

// Payments Clearing and Settlements (PACS)
public class PacsController() : Controller
{

  [HttpPost]
  [Route("00200112/json/{amountToGenerate}")]
  public IActionResult FIToFIPaymentStatusReportV12MessageJson([FromBody] JsonObject requestBody, Int16 amountToGenerate)
  {
    FIToFIPaymentStatusReportV12_JSON classInstance = new();
    List<JsonObject> responseList = [];

    if (amountToGenerate < 0)
    {
      return BadRequest("Please indicate the amount of mock data objects you want generated. Must be greater than 0.");
    }

    try
    {
      for (Int16 i = 0; i < amountToGenerate; i++)
      {
        JsonObject updatedObject = GenerateJson.UpdateJsonValues(requestBody, classInstance._methodNameList, classInstance);
        responseList.Add(updatedObject);
      }

      string jsonResponse = JsonSerializer.Serialize(responseList, new JsonSerializerOptions { WriteIndented = true });
      return Ok(jsonResponse);
    }
    catch (Exception ex)
    {
      return StatusCode(500, $"An error occurred while generating the JSON objects: {ex.Message} ");
    }
  }

  [HttpPost]
  [Route("00200112/xml/{amountToGenerate}")]
  public IActionResult FIToFIPaymentStatusReportV12MessageXml([FromBody] XmlDocument requestBody, Int16 amountToGenerate)
  {
    FIToFIPaymentStatusReportV12_XML classInstance = new();
    List<string> responseList = [];

    if (amountToGenerate < 0)
    {
      return BadRequest("Please indicate the amount of mock XML documents you want generated. Must be greater than 0.");
    }

    try
    {
      for (Int16 i = 0; i < amountToGenerate; i++)
      {
        string updatedXml = GenerateXml.UpdateXmlInnerText(requestBody, classInstance._methodNameList, classInstance);
        responseList.Add(updatedXml);
      }

      return Ok(responseList);
    }
    catch (Exception ex)
    {
      return StatusCode(500, $"An error occurred while generating the XML documents: {ex.Message}");
    }
  }

  [HttpPost]
  [Route("00200115/json/{amountToGenerate}")]
  public IActionResult FIToFIPaymentStatusReportV15MessageJson([FromBody] JsonObject requestBody, Int16 amountToGenerate)
  {
    FIToFIPaymentStatusReportV15_JSON classInstance = new();
    List<JsonObject> responseList = [];

    if (amountToGenerate < 0)
    {
      return BadRequest("Please indicate the amount of mock data objects you want generated. Must be greater than 0.");
    }

    try
    {
      for (Int16 i = 0; i < amountToGenerate; i++)
      {
        JsonObject updatedObject = GenerateJson.UpdateJsonValues(requestBody, classInstance._methodNameList, classInstance);
        responseList.Add(updatedObject);
      }

      string jsonResponse = JsonSerializer.Serialize(responseList, new JsonSerializerOptions { WriteIndented = true });
      return Ok(jsonResponse);
    }
    catch (Exception ex)
    {
      return StatusCode(500, $"An error occurred while generating the JSON objects: {ex.Message} ");
    }
  }

  [HttpPost]
  [Route("00200115/xml/{amountToGenerate}")]
  public IActionResult FIToFIPaymentStatusReportV15MessageXml([FromBody] XmlDocument requestBody, Int16 amountToGenerate)
  {
    FIToFIPaymentStatusReportV15_XML classInstance = new();
    List<string> responseList = [];

    if (amountToGenerate < 0)
    {
      return BadRequest("Please indicate the amount of mock XML documents you want generated. Must be greater than 0.");
    }

    try
    {
      for (Int16 i = 0; i < amountToGenerate; i++)
      {
        string updatedXml = GenerateXml.UpdateXmlInnerText(requestBody, classInstance._methodNameList, classInstance);
        responseList.Add(updatedXml);
      }

      return Ok(responseList);
    }
    catch (Exception ex)
    {
      return StatusCode(500, $"An error occurred while generating the XML documents: {ex.Message}");
    }
  }
}