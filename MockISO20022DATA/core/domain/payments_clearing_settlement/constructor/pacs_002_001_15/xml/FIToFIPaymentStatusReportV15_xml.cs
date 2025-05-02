



using System.Text;
using datapltf.core.common.generators;

public class FIToFIPaymentStatusReportV15_XML : GenerateXml
{
  public readonly List<string> _methodNameList;
  private string _alphaNumeric = alphaNumeric;
  private string _upperAlphaNumeric = upperAlphaNumeric;
  private string _lowerAlphaNumeric = lowerAlphaNumeric;

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

  public string BICFIDec2014Identifier()
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

  public string ClearingChannel2Code()
  {
    /*
       < xs:simpleType name = "ClearingChannel2Code" >
         < xs:restriction base = "xs:string" >
           < xs:enumeration value = "RTGS" />
           < xs:enumeration value = "RTNS" />
           < xs:enumeration value = "MPNS" />
           < xs:enumeration value = "BOOK" />
         </ xs:restriction >
       </ xs:simpleType >
     */
    List<string> addressType2Code = ["RTGS", "RTNS", "MPNS", "BOOK"];
    int randomNumber = new Random().Next(addressType2Code.Count);
    return addressType2Code[randomNumber];
  }

  public string CountryCode()
  {
    /*
      <xs:simpleType name="CountryCode">
          <xs:restriction base="xs:string">
              <xs:pattern value="[A-Z]{2,2}"/>
          </xs:restriction>
      </xs:simpleType>
    */
    string countryCode = "";

    for (int i = 0; i < 2; i++)
    {
      countryCode += (char)new Random().Next('A', 'Z' + 1);
    }
    return countryCode;
  }

  public string CreditDebitCode()
  {
    /*
    <xs:simpleType name="CreditDebitCode">
        <xs:restriction base="xs:string">
            <xs:enumeration value="CRDT"/>
            <xs:enumeration value="DBIT"/>
        </xs:restriction>
    </xs:simpleType>
    */

    List<string> codes = ["CRDT", "DBIT"];
    int randomNumber = new Random().Next(codes.Count);
    return codes[randomNumber];
  }

  public string DecimalNumber()
  {
    /*
    <xs:simpleType name="DecimalNumber">
        <xs:restriction base="xs:decimal">
            <xs:fractionDigits value="17"/>
            <xs:totalDigits value="18"/>
        </xs:restriction>
    </xs:simpleType>
    */
    int wholeNumberPart = new Random().Next(2);
    decimal fractionalPart = new Random().Next(999_999_999);
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

  public string Exact2NumericText()
  {
    /*
      <xs:simpleType name="Exact2NumericText">
          <xs:restriction base="xs:string">
              <xs:pattern value="[0-9]{2}"/>
          </xs:restriction>
      </xs:simpleType>
    */
    string randomStringNumber = "";
    for (int i = 0; i < 2; i++)
    {
      randomStringNumber += new Random().Next(10);
    }
    return randomStringNumber;
  }

  public string Exact4AlphaNumericText()
  {
    /*
    <xs:simpleType name="Exact4AlphaNumericText">
        <xs:restriction base="xs:string">
            <xs:pattern value="[a-zA-Z0-9]{4}"/>
        </xs:restriction>
    </xs:simpleType>
    */

    string alphaNumeric = "";
    bool decision = new Random().Next(2) > 0;
    for (int i = 0; i < 4; i++)
    {
      if (new Random().Next(2) > 0)
      {
        alphaNumeric += (char)new Random().Next('A', 'Z' + 1);
      }
      else
      {
        alphaNumeric += new Random().Next(10);
      }
    }
    return alphaNumeric;
  }

  public string ExternalAccountIdentification1Code()
  {
    /*
      <xs:simpleType name="ExternalAccountIdentification1Code">
          <xs:restriction base="xs:string">
              <xs:minLength value="1"/>
              <xs:maxLength value="4"/>
          </xs:restriction>
      </xs:simpleType>
    */
    int length = new Random().Next(1, 5);
    string randomString = "";

    for (int i = 0; i < length; i++)
    {
      randomString += _alphaNumeric[new Random().Next(_alphaNumeric.Length)];
    }
    return randomString;
  }

  public string ExternalCashAccountType1Code()
  {
    /*
      <xs:simpleType name="ExternalCashAccountType1Code">
          <xs:restriction base="xs:string">
              <xs:minLength value="1"/>
              <xs:maxLength value="4"/>
          </xs:restriction>
      </xs:simpleType>
    */
    int length = new Random().Next(1, 5);
    string randomString = "";

    for (int i = 0; i < length; i++)
    {
      randomString += _alphaNumeric[new Random().Next(_alphaNumeric.Length)];
    }
    return randomString;
  }

  public string ExternalCashClearingSystem1Code()
  {
    /*
      <xs:simpleType name="ExternalCashClearingSystem1Code">
          <xs:restriction base="xs:string">
              <xs:minLength value="1"/>
              <xs:maxLength value="3"/>
          </xs:restriction>
      </xs:simpleType>
    */
    int length = new Random().Next(1, 4);
    string randomString = "";

    for (int i = 0; i < length; i++)
    {
      randomString += _alphaNumeric[new Random().Next(_alphaNumeric.Length)];
    }
    return randomString;
  }

  public string ExternalCategoryPurpose1Code()
  {
    /*
      <xs:simpleType name="ExternalCategoryPurpose1Code">
          <xs:restriction base="xs:string">
              <xs:minLength value="1"/>
              <xs:maxLength value="4"/>
          </xs:restriction>
      </xs:simpleType>
    */
    int length = new Random().Next(1, 5);
    string randomString = "";

    for (int i = 0; i < length; i++)
    {
      randomString += _alphaNumeric[new Random().Next(_alphaNumeric.Length)];
    }
    return randomString;
  }

  public string ExternalChargeType1Code()
  {
    /*
    <xs:simpleType name="ExternalChargeType1Code">
        <xs:restriction base="xs:string">
            <xs:minLength value="1"/>
            <xs:maxLength value="4"/>
        </xs:restriction>
    </xs:simpleType>
    */
    int length = new Random().Next(1, 5);
    string randomString = "";

    for (int i = 0; i < length; i++)
    {
      randomString += _alphaNumeric[new Random().Next(_alphaNumeric.Length)];
    }
    return randomString;
  }

  public string ExternalClearingSystemIdentification1Code()
  {
    /*
      <xs:simpleType name="ExternalClearingSystemIdentification1Code">
        <xs:restriction base="xs:string">
            <xs:minLength value="1"/>
            <xs:maxLength value="5"/>
        </xs:restriction>
      </xs:simpleType>
    */
    int length = new Random().Next(1, 6);
    string randomString = "";

    for (int i = 0; i < length; i++)
    {
      randomString += _alphaNumeric[new Random().Next(_alphaNumeric.Length)];
    }
    return randomString;
  }

  public string ExternalCreditorReferenceType1Code()
  {
    /*
      <xs:simpleType name="ExternalCreditorReferenceType1Code">
          <xs:restriction base="xs:string">
              <xs:minLength value="1"/>
              <xs:maxLength value="4"/>
          </xs:restriction>
      </xs:simpleType>
    */
    int length = new Random().Next(1, 5);
    string randomString = "";

    for (int i = 0; i < length; i++)
    {
      randomString += _alphaNumeric[new Random().Next(_alphaNumeric.Length)];
    }
    return randomString;
  }

  public string ExternalDateType1Code()
  {
    /*
      <xs:simpleType name="ExternalDateType1Code">
          <xs:restriction base="xs:string">
              <xs:minLength value="1"/>
              <xs:maxLength value="4"/>
          </xs:restriction>
      </xs:simpleType>
    */
    int length = new Random().Next(1, 5);
    string randomString = "";

    for (int i = 0; i < length; i++)
    {
      randomString += _alphaNumeric[new Random().Next(_alphaNumeric.Length)];
    }
    return randomString;
  }





}