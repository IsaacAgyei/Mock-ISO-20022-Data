



using System.Text;

public class FIToFIPaymentStatusReportV15_XML
{
  public string ActiveOrHistoricCurrencyAndAmount_SimpleType()
  {
    /*
      <xs:simpleType name="ActiveOrHistoricCurrencyAndAmount_SimpleType">
          <xs:restriction base="xs:decimal">
              <xs:fractionDigits value="5"/>
              <xs:totalDigits value="18"/>
              <xs:minInclusive value="0"/>
          </xs:restriction>
      </xs:simpleType>
    */
    decimal wholeNumberPart = new Random().Next(100_000);
    decimal fractionalPart = new Random().Next(99999);
    string stringValue = wholeNumberPart.ToString() + "." + fractionalPart.ToString();

    if (decimal.TryParse(stringValue, out decimal convertedDecimal))
    {
      return convertedDecimal.ToString();
    }
    else
    {
      Console.WriteLine("Conversion to decimal value failed");
      throw new NotImplementedException();
    }
  }

  public string ActiveOrHistoricCurrencyCode()
  {
    /*
      <xs:simpleType name="ActiveOrHistoricCurrencyCode">
          <xs:restriction base="xs:string">
              <xs:pattern value="[A-Z]{3,3}"/>
          </xs:restriction>
      </xs:simpleType>
    */
    StringBuilder result = new(3);

    for (int i = 0; i < 3; i++)
    {
      char randomChar = (char)new Random().Next('A', 'Z' + 1);
      result.Append(randomChar);
    }
    return result.ToString();
  }

  public string AddressType2Code()
  {
    /*
      <xs:restriction base="xs:string">
          <xs:enumeration value="ADDR"/>
          <xs:enumeration value="PBOX"/>
          <xs:enumeration value="HOME"/>
          <xs:enumeration value="BIZZ"/>
          <xs:enumeration value="MLTO"/>
          <xs:enumeration value="DLVY"/>
          </xs:restriction>
      </xs:simpleType>
    */
    List<string> addressType2Code = ["ADDR", "PBOX", "HOME", "BIZZ", "MLTO", "DLVY"];
    int randomNumber = new Random().Next(addressType2Code.Count);
    return addressType2Code[randomNumber];
  }

  public string AnyBICDec2014Identifier()
  {
    //     /*
    //     <xs:simpleType name="BICFIDec2014Identifier">
    //         <xs:restriction base="xs:string">
    //             <xs:pattern value="[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"/>
    //         </xs:restriction>
    //     </xs:simpleType>
    //   */
    string bicFId = "";
    bool decision = (uint)new Random().Next(2) > 0;

    // [A-Z0 - 9]{4,4}
    for (int i = 0; i < 4; i++)
    {
      if ((uint)new Random().Next(2) > 0)
      {
        bicFId += (char)new Random().Next('A', 'Z' + 1);
      }
      else
      {
        bicFId += (uint)new Random().Next(10);
      }
    }

    // [A-Z]{2,2}
    for (int i = 0; i < 2; i++)
    {
      bicFId += (char)new Random().Next('A', 'Z' + 1);
    }

    // [A-Z0-9]{2,2}
    for (int i = 0; i < 2; i++)
    {
      if ((uint)new Random().Next(2) > 0)
      {
        bicFId += (char)new Random().Next('A', 'Z' + 1);
      }
      else
      {
        bicFId += (uint)new Random().Next(10);
      }
    }

    // ([A-Z0-9]{3,3}){0,1}
    if (decision)
    {
      for (int i = 0; i < 3; i++)
      {
        if ((uint)new Random().Next(2) > 0)
        {
          bicFId += (char)new Random().Next('A', 'Z' + 1);
        }
        else
        {
          bicFId += (uint)new Random().Next(10);
        }
      }
    }
    return bicFId;
  }




}