using System.Reflection;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace datapltf.core.common.generators;

public class GenerateJson : Generate
{
  public static JsonObject UpdateJsonValues(JsonObject json, List<string> methodList, Object classInstance)
  {

    if (json == null || !(json is System.Text.Json.Nodes.JsonObject))
    {
      JsonObject error = new()
      {
        ["error"] = "Invalid object type. Please review the equest body"
      };
      return error;
    }

    if (json.AsObject().Count == 0)
    {
      JsonObject error = new()
      {
        ["error"] = "Cannot run operations on a blank json object. Please review the request body"
      };
      return error;
    }

    JsonObject modifiedJson = (JsonObject)json.DeepClone();

    foreach (var keyValuePair in json.AsObject())
    {
      if (keyValuePair.Value != null && keyValuePair.Value.GetType() == typeof(JsonObject))
      {
        modifiedJson[keyValuePair.Key] = UpdateJsonValues((JsonObject)keyValuePair.Value.DeepClone(), methodList, classInstance); // Recursive call for nested objects
      }
      else if (keyValuePair.Value is JsonValue jsonValue && jsonValue.GetValueKind() == JsonValueKind.String && methodList.Contains(jsonValue.ToString()))
      {
        Type type = classInstance.GetType();
        MethodInfo method = type.GetMethod(keyValuePair.Value.ToString());
        modifiedJson[keyValuePair.Key] = (JsonNode?)method.Invoke(classInstance, null);
      }
      else if (keyValuePair.Value is JsonArray arrayValue && arrayValue != null && arrayValue.GetValueKind() == JsonValueKind.Array)
      {
        // if arrayValue[0] --> must _methodNameList.Contains(arrayValue.ToString()) : Throw error if failed
        if (arrayValue[0] != null && arrayValue[1] != null && arrayValue[0].GetValueKind() == JsonValueKind.String && arrayValue[1].GetValueKind() == JsonValueKind.String && methodList.Contains(arrayValue[0].ToString()))
        {
          Type getType = classInstance.GetType();
          string userText = (string)arrayValue[1];
          MethodInfo methodInfo = getType.GetMethod((string)arrayValue[0]);
          modifiedJson[keyValuePair.Key] = (JsonNode?)methodInfo.Invoke(classInstance, [userText]);
        }
        else
        {
          JsonObject error = new()
          {
            ["error"] = "Invalid array format. Ensure elements are not null and are strings"
          };
          return error;
        }
      }
    }
    return modifiedJson;
  }
}