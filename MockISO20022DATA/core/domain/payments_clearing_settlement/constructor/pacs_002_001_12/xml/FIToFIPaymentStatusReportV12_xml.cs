using System.Text;
using System.Xml;
using datapltf.core.common.generators;

namespace datapltf.pacs.aggregate;

public class FIToFIPaymentStatusReportV12_XML
{
  public readonly List<string> _methodNameList;
  private string _alphaNumeric = GenerateXml.alphaNumeric;
  private string _upperAlphaNumeric = GenerateXml.upperAlphaNumeric;
  private string _lowerAlphaNumeric = GenerateXml.lowerAlphaNumeric;

  public FIToFIPaymentStatusReportV12_XML()
  {
    _methodNameList = GenerateXml.MethodNames(this);
  }

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
      <xs:simpleType name="AddressType2Code">
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
    //     /*
    //       <xs:simpleType name="ClearingChannel2Code">
    //           <xs:restriction base="xs:string">
    //               <xs:enumeration value="RTGS"/>
    //               <xs:enumeration value="RTNS"/>
    //               <xs:enumeration value="MPNS"/>
    //               <xs:enumeration value="BOOK"/>
    //           </xs:restriction>
    //       </xs:simpleType>
    //     */
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

  public string DocumentType3Code()
  {
    /*
    <xs:simpleType name="DocumentType3Code">
        <xs:restriction base="xs:string">
            <xs:enumeration value="RADM"/>
            <xs:enumeration value="RPIN"/>
            <xs:enumeration value="FXDR"/>
            <xs:enumeration value="DISP"/>
            <xs:enumeration value="PUOR"/>
            <xs:enumeration value="SCOR"/>
        </xs:restriction>
    </xs:simpleType>
    */
    List<string> codes = ["RADM", "RPIN", "FXDR", "DISP", "PUOR", "SCOR"];
    int randomNumber = new Random().Next(codes.Count);
    return codes[randomNumber];
  }

  public string DocumentType6Code()
  {
    /*
    <xs:simpleType name="DocumentType6Code">
        <xs:restriction base="xs:string">
            <xs:enumeration value="MSIN"/>
            <xs:enumeration value="CNFA"/>
            <xs:enumeration value="DNFA"/>
            <xs:enumeration value="CINV"/>
            <xs:enumeration value="CREN"/>
            <xs:enumeration value="DEBN"/>
            <xs:enumeration value="HIRI"/>
            <xs:enumeration value="SBIN"/>
            <xs:enumeration value="CMCN"/>
            <xs:enumeration value="SOAC"/>
            <xs:enumeration value="DISP"/>
            <xs:enumeration value="BOLD"/>
            <xs:enumeration value="VCHR"/>
            <xs:enumeration value="AROI"/>
            <xs:enumeration value="TSUT"/>
            <xs:enumeration value="PUOR"/>
        </xs:restriction>
      </xs:simpleType>
    */
    List<string> codes = ["MSIN", "CNFA", "DNFA", "CINV",
                            "CREN", "DEBN", "HIRI", "SBIN",
                            "CMCN", "SOAC", "DISP", "BOLD",
                            "VCHR", "AROI", "TSUT", "PUOR"
                        ];
    int randomNumber = new Random().Next(codes.Count);
    return codes[randomNumber];
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

  public string ExternalDiscountAmountType1Code()
  {
    /*
    <xs:simpleType name="ExternalDiscountAmountType1Code">
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

  public string ExternalDocumentLineType1Code()
  {
    /*
    <xs:simpleType name="ExternalDocumentLineType1Code">
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

  public string ExternalFinancialInstitutionIdentification1Code()
  {
    /*
    <xs:simpleType name="ExternalFinancialInstitutionIdentification1Code">
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

  public string ExternalGarnishmentType1Code()
  {
    /*
    <xs:simpleType name="ExternalGarnishmentType1Code">
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

  public string ExternalLocalInstrument1Code()
  {
    /*
    <xs:simpleType name="ExternalLocalInstrument1Code">
        <xs:restriction base="xs:string">
            <xs:minLength value="1"/>
            <xs:maxLength value="35"/>
        </xs:restriction>
    </xs:simpleType>
    */
    int length = new Random().Next(1, 36);
    string randomString = "";

    for (int i = 0; i < length; i++)
    {
      randomString += _alphaNumeric[new Random().Next(_alphaNumeric.Length)];
    }
    return randomString;
  }

  public string ExternalMandateSetupReason1Code()
  {
    /*
    <xs:simpleType name="ExternalMandateSetupReason1Code">
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

  public string ExternalOrganisationIdentification1Code()
  {
    /*
    <xs:simpleType name="ExternalOrganisationIdentification1Code">
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

  public string ExternalPaymentGroupStatus1Code()
  {
    /*
    <xs:simpleType name="ExternalPaymentGroupStatus1Code">
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

  public string ExternalPaymentTransactionStatus1Code()
  {
    /*
    <xs:simpleType name="ExternalPaymentTransactionStatus1Code">
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

  public string ExternalPersonIdentification1Code()
  {
    /*
    <xs:simpleType name="ExternalPersonIdentification1Code">
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

  public string ExternalProxyAccountType1Code()
  {
    /*
    <xs:simpleType name="ExternalProxyAccountType1Code">
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

  public string ExternalPurpose1Code()
  {
    /*
    <xs:simpleType name="ExternalPurpose1Code">
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

  public string ExternalServiceLevel1Code()
  {
    /*
    <xs:simpleType name="ExternalServiceLevel1Code">
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

  public string ExternalStatusReason1Code()
  {
    /*
    <xs:simpleType name="ExternalStatusReason1Code">
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

  public string ExternalTaxAmountType1Code()
  {
    /*
    <xs:simpleType name="ExternalTaxAmountType1Code">
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

  public string Frequency6Code()
  {
    /*
    <xs:simpleType name="Frequency6Code">
        <xs:restriction base="xs:string">
            <xs:enumeration value="YEAR"/>
            <xs:enumeration value="MNTH"/>
            <xs:enumeration value="QURT"/>
            <xs:enumeration value="MIAN"/>
            <xs:enumeration value="WEEK"/>
            <xs:enumeration value="DAIL"/>
            <xs:enumeration value="ADHO"/>
            <xs:enumeration value="INDA"/>
            <xs:enumeration value="FRTN"/>
        </xs:restriction>
    </xs:simpleType>
    */
    List<string> codes = ["YEAR", "MNTH", "QURT",
                            "MIAN", "WEEK", "DAIL",
                            "ADHO", "INDA", "FRTN",
                            ];
    int randomNumber = new Random().Next(codes.Count);
    return codes[randomNumber];
  }

  public string IBAN2007Identifier()
  {
    /*
    <xs:simpleType name="IBAN2007Identifier">
        <xs:restriction base="xs:string">
            <xs:pattern value="[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"/>
        </xs:restriction>
    </xs:simpleType>
    */
    string iBanId = "";
    bool decision = (uint)new Random().Next(2) > 0;

    // [A-Z]{2,2}
    for (int i = 0; i < 2; i++)
    {
      iBanId += (char)new Random().Next('A', 'Z' + 1);
    }

    // [0-9]{2,2}
    for (int i = 0; i < 2; i++)
    {
      iBanId += (uint)new Random().Next(10);
    }

    // [a-zA-Z0-9]{1,30}
    int length = new Random().Next(1, 30);

    for (int i = 0; i < length; i++)
    {
      iBanId += _alphaNumeric[new Random().Next(_alphaNumeric.Length)];
    }
    return iBanId;
  }

  public string ISODate()
  {
    /*
    <xs:simpleType name="ISODate">
        <xs:restriction base="xs:date"/>
    </xs:simpleType>
    */
    return DateTime.UtcNow.ToString("yyyy-MM-dd");
  }

  public string ISODateTime()
  {
    /*
    <xs:simpleType name="ISODateTime">
        <xs:restriction base="xs:dateTime"/>
    </xs:simpleType>
    */
    return DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ");
  }

  public string ISOYear()
  {
    /*
    <xs:simpleType name="ISOYear">
        <xs:restriction base="xs:gYear"/>
    </xs:simpleType>
    */
    return DateTime.UtcNow.ToString("yyyy");
  }

  public string LEIIdentifier()
  {
    /*
    <xs:simpleType name="LEIIdentifier">
        <xs:restriction base="xs:string">
            <xs:pattern value="[A-Z0-9]{18,18}[0-9]{2,2}"/>
        </xs:restriction>
    </xs:simpleType>
    */

    // [A-Z0-9]{18,18}
    string leiIdentifier = "";
    for (int i = 0; i < 18; i++)
    {
      leiIdentifier += _upperAlphaNumeric[new Random().Next(_upperAlphaNumeric.Length)];
    }

    // [0-9]{2,2}
    for (int i = 0; i < 2; i++)
    {
      leiIdentifier += _upperAlphaNumeric[new Random().Next(10)];
    }

    return leiIdentifier;
  }

  public string MandateClassification1Code()
  {
    /*
    <xs:simpleType name="MandateClassification1Code">
        <xs:restriction base="xs:string">
            <xs:enumeration value="FIXE"/>
            <xs:enumeration value="USGB"/>
            <xs:enumeration value="VARI"/>
        </xs:restriction>
    </xs:simpleType>
    */
    List<string> codes = ["FIXE", "USGB", "VARI"];
    int randomNumber = new Random().Next(codes.Count);
    return codes[randomNumber];
  }

  // public string Max1025Text(string userText)
  // {
  //   /*
  //   <xs:simpleType name="Max1025Text">
  //       <xs:restriction base="xs:string">
  //           <xs:minLength value="1"/>
  //           <xs:maxLength value="1025"/>
  //       </xs:restriction>
  //   </xs:simpleType>
  //   */
  //   if (userText.Length > 0 && userText.Length <= 1025)
  //   {
  //     return userText;
  //   }
  //   else
  //   {
  //     throw new NotImplementedException();
  //   }
  // }

  // public string Max105Text(string userText)
  // {
  //   /*
  //   <xs:simpleType name="Max105Text">
  //       <xs:restriction base="xs:string">
  //           <xs:minLength value="1"/>
  //           <xs:maxLength value="105"/>
  //       </xs:restriction>
  //   </xs:simpleType>
  //   */
  //   if (userText.Length > 0 && userText.Length <= 105)
  //   {
  //     return userText;
  //   }
  //   else
  //   {
  //     throw new NotImplementedException();
  //   }
  // }

  // public string Max10KBinary(string userText)
  // {
  //   /*
  //   <xs:simpleType name="Max10KBinary">
  //       <xs:restriction base="xs:base64Binary">
  //           <xs:minLength value="1"/>
  //           <xs:maxLength value="10240"/>
  //       </xs:restriction>
  //   </xs:simpleType>
  //   */
  //   int textLength = userText.Length;

  //   if (textLength < 1 || textLength > 10240)
  //   {
  //     return null; // Invalid length.
  //   }
  //   try
  //   {
  //     // Generate a random byte array of the specified length.
  //     byte[] randomBytes = new byte[textLength];
  //     Random random = new();
  //     random.NextBytes(randomBytes);

  //     // Encode the byte array to base64.
  //     string base64String = Convert.ToBase64String(randomBytes);
  //     return base64String;
  //   }
  //   catch (Exception)
  //   {
  //     return null; // Handle any unexpected errors.
  //   }
  // }

  // public string Max128Text(string userText)
  // {
  //   /*
  //   <xs:simpleType name="Max128Text">
  //       <xs:restriction base="xs:string">
  //           <xs:minLength value="1"/>
  //           <xs:maxLength value="128"/>
  //       </xs:restriction>
  //   </xs:simpleType>
  //   */
  //   if (userText.Length > 0 && userText.Length <= 128)
  //   {
  //     return userText;
  //   }
  //   else
  //   {
  //     throw new NotImplementedException();
  //   }
  // }

  // public string Max140Text(string userText)
  // {
  //   /*
  //   <xs:simpleType name="Max140Text">
  //       <xs:restriction base="xs:string">
  //           <xs:minLength value="1"/>
  //           <xs:maxLength value="140"/>
  //       </xs:restriction>
  //   </xs:simpleType>
  //   */
  //   if (userText.Length > 0 && userText.Length <= 140)
  //   {
  //     return userText;
  //   }
  //   else
  //   {
  //     throw new NotImplementedException();
  //   }
  // }

  public string Max15NumericText()
  {
    /*
    <xs:simpleType name="Max15NumericText">
        <xs:restriction base="xs:string">
            <xs:pattern value="[0-9]{1,15}"/>
        </xs:restriction>
    </xs:simpleType>
    */
    string numericText = "";
    for (int i = 0; i < new Random().Next(1, 15); i++)
    {
      numericText += new Random().Next(10);
    }
    return numericText;
  }

  // public string Max16Text(string userText)
  // {
  //   /*
  //   <xs:simpleType name="Max16Text">
  //       <xs:restriction base="xs:string">
  //           <xs:minLength value="1"/>
  //           <xs:maxLength value="16"/>
  //       </xs:restriction>
  //   </xs:simpleType>
  //   */
  //   if (userText.Length > 0 && userText.Length <= 16)
  //   {
  //     return userText;
  //   }
  //   else
  //   {
  //     throw new NotImplementedException();
  //   }
  // }

  // public string Max2048Text(string userText)
  // {
  //   /*
  //   <xs:simpleType name="Max2048Text">
  //       <xs:restriction base="xs:string">
  //           <xs:minLength value="1"/>
  //           <xs:maxLength value="2048"/>
  //       </xs:restriction>
  //   </xs:simpleType>
  //   */
  //   if (userText.Length > 0 && userText.Length <= 2028)
  //   {
  //     return userText;
  //   }
  //   else
  //   {
  //     throw new NotImplementedException();
  //   }
  // }

  // public string Max34Text(string userText)
  // {
  //   /*
  //   <xs:simpleType name="Max34Text">
  //       <xs:restriction base="xs:string">
  //           <xs:minLength value="1"/>
  //           <xs:maxLength value="34"/>
  //       </xs:restriction>
  //   </xs:simpleType>
  //   */
  //   if (userText.Length > 0 && userText.Length <= 34)
  //   {
  //     return userText;
  //   }
  //   else
  //   {
  //     throw new NotImplementedException();
  //   }
  // }

  // public string Max350Text(string userText)
  // {
  //   /*
  //   <xs:simpleType name="Max350Text">
  //       <xs:restriction base="xs:string">
  //           <xs:minLength value="1"/>
  //           <xs:maxLength value="350"/>
  //       </xs:restriction>
  //   </xs:simpleType>
  //   */
  //   if (userText.Length > 0 && userText.Length <= 350)
  //   {
  //     return userText;
  //   }
  //   else
  //   {
  //     throw new NotImplementedException();
  //   }
  // }

  // public string Max35Text(string userText)
  // {
  //   /*
  //   <xs:simpleType name="Max35Text">
  //       <xs:restriction base="xs:string">
  //           <xs:minLength value="1"/>
  //           <xs:maxLength value="35"/>
  //       </xs:restriction>
  //   </xs:simpleType>
  //   */
  //   if (userText.Length > 0 && userText.Length <= 35)
  //   {
  //     return userText;
  //   }
  //   else
  //   {
  //     throw new NotImplementedException();
  //   }
  // }

  // public string Max4Text(string userText)
  // {
  //   /*
  //   <xs:simpleType name="Max4Text">
  //       <xs:restriction base="xs:string">
  //           <xs:minLength value="1"/>
  //           <xs:maxLength value="4"/>
  //       </xs:restriction>
  //   </xs:simpleType>
  //   */
  //   if (userText.Length > 0 && userText.Length <= 4)
  //   {
  //     return userText;
  //   }
  //   else
  //   {
  //     throw new NotImplementedException();
  //   }
  // }

  // public string Max70Text(string userText)
  // {
  //   /*
  //   <xs:simpleType name="Max70Text">
  //       <xs:restriction base="xs:string">
  //           <xs:minLength value="1"/>
  //           <xs:maxLength value="70"/>
  //       </xs:restriction>
  //   </xs:simpleType>
  //   */
  //   if (userText.Length > 0 && userText.Length <= 70)
  //   {
  //     return userText;
  //   }
  //   else
  //   {
  //     throw new NotImplementedException();
  //   }
  // }

  public string NamePrefix2Code()
  {
    /*
    <xs:simpleType name="NamePrefix2Code">
        <xs:restriction base="xs:string">
            <xs:enumeration value="DOCT"/>
            <xs:enumeration value="MADM"/>
            <xs:enumeration value="MISS"/>
            <xs:enumeration value="MIST"/>
            <xs:enumeration value="MIKS"/>
        </xs:restriction>
    </xs:simpleType>
    */
    List<string> codes = ["DOCT", "MADM", "MISS",
                            "MIST", "MIKS",
                            ];
    int randomNumber = new Random().Next(codes.Count);
    return codes[randomNumber];
  }

  public string Number()
  {
    /*
    <xs:simpleType name="Number">
        <xs:restriction base="xs:decimal">
            <xs:fractionDigits value="0"/>
            <xs:totalDigits value="18"/>
        </xs:restriction>
    </xs:simpleType>
    */
    int randomDecimal = new Random().Next(999_999_999);

    if (randomDecimal < 999_999_999)
    {
      return randomDecimal.ToString();
    }
    else
    {
      throw new NotImplementedException();
    }
  }

  public string PaymentMethod4Code()
  {
    /*
    <xs:simpleType name="PaymentMethod4Code">
        <xs:restriction base="xs:string">
            <xs:enumeration value="CHK"/>
            <xs:enumeration value="TRF"/>
            <xs:enumeration value="DD"/>
            <xs:enumeration value="TRA"/>
        </xs:restriction>
    </xs:simpleType>
    */
    List<string> codes = ["CHK", "TRF", "DD", "TRA"];
    int randomNumber = new Random().Next(codes.Count);
    return codes[randomNumber];
  }

  public string PercentageRate()
  {
    /*
    <xs:simpleType name="PercentageRate">
        <xs:restriction base="xs:decimal">
            <xs:fractionDigits value="10"/>
            <xs:totalDigits value="11"/>
        </xs:restriction>
    </xs:simpleType>
    */
    decimal wholeNumberPart = new Random().Next(0, 2);
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

  public string PhoneNumber()
  {
    // NEEDS TO FETCH NUMBERS FROM DBIT
    /*
    <xs:simpleType name="PhoneNumber">
        <xs:restriction base="xs:string">
            <xs:pattern value="\+[0-9]{1,3}-[0-9()+\-]{1,30}"/>
        </xs:restriction>
    </xs:simpleType>
    */
    StringBuilder phoneNumber = new();

    // Start with required plus sign
    phoneNumber.Append("+");

    // Generate country code (1-3 digits)
    int countryCodeLength = new Random().Next(1, 4); // 1 to 3 digits
    for (int i = 0; i < countryCodeLength; i++)
    {
      phoneNumber.Append(new Random().Next(0, 10)); // 0-9
    }

    // Add required hyphen
    phoneNumber.Append("-");

    // Generate remaining number (1-30 characters)
    int remainingLength = new Random().Next(1, 31); // 1 to 30 characters
    char[] allowedChars = ['0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '(', ')', '+', '-'];

    for (int i = 0; i < remainingLength; i++)
    {
      phoneNumber.Append(allowedChars[new Random().Next(allowedChars.Length)]);
    }
    return phoneNumber.ToString();
  }

  public string PreferredContactMethod1Code()
  {
    /*
    <xs:simpleType name="PreferredContactMethod1Code">
        <xs:restriction base="xs:string">
            <xs:enumeration value="LETT"/>
            <xs:enumeration value="MAIL"/>
            <xs:enumeration value="PHON"/>
            <xs:enumeration value="FAXX"/>
            <xs:enumeration value="CELL"/>
        </xs:restriction>
    </xs:simpleType>
    */
    List<string> codes = ["LETT", "MAIL", "PHON", "FAXX", "CELL"];
    int randomNumber = new Random().Next(codes.Count);
    return codes[randomNumber];
  }

  public string Priority2Code()
  {
    /*
    <xs:simpleType name="Priority2Code">
        <xs:restriction base="xs:string">
            <xs:enumeration value="HIGH"/>
            <xs:enumeration value="NORM"/>
        </xs:restriction>
    </xs:simpleType>
    */
    List<string> codes = ["HIGH", "NORM"];
    int randomNumber = new Random().Next(codes.Count);
    return codes[randomNumber];
  }

  public string SequenceType3Code()
  {
    /*
    <xs:simpleType name="SequenceType3Code">
        <xs:restriction base="xs:string">
            <xs:enumeration value="FRST"/>
            <xs:enumeration value="RCUR"/>
            <xs:enumeration value="FNAL"/>
            <xs:enumeration value="OOFF"/>
            <xs:enumeration value="RPRE"/>
        </xs:restriction>
    </xs:simpleType>
    */
    List<string> codes = ["FRST", "RCUR", "FNAL", "OOFF", "RPRE"];
    int randomNumber = new Random().Next(codes.Count);
    return codes[randomNumber];
  }

  public string SettlementMethod1Code()
  {
    /*
    <xs:simpleType name="SettlementMethod1Code">
        <xs:restriction base="xs:string">
            <xs:enumeration value="INDA"/>
            <xs:enumeration value="INGA"/>
            <xs:enumeration value="COVE"/>
            <xs:enumeration value="CLRG"/>
        </xs:restriction>
    </xs:simpleType>
    */
    List<string> codes = ["INDA", "INGA", "COVE", "CLRG"];
    int randomNumber = new Random().Next(codes.Count);
    return codes[randomNumber];
  }

  public string TaxRecordPeriod1Code()
  {
    /*
    <xs:simpleType name="TaxRecordPeriod1Code">
        <xs:restriction base="xs:string">
            <xs:enumeration value="MM01"/>
            <xs:enumeration value="MM02"/>
            <xs:enumeration value="MM03"/>
            <xs:enumeration value="MM04"/>
            <xs:enumeration value="MM05"/>
            <xs:enumeration value="MM06"/>
            <xs:enumeration value="MM07"/>
            <xs:enumeration value="MM08"/>
            <xs:enumeration value="MM09"/>
            <xs:enumeration value="MM10"/>
            <xs:enumeration value="MM11"/>
            <xs:enumeration value="MM12"/>
            <xs:enumeration value="QTR1"/>
            <xs:enumeration value="QTR2"/>
            <xs:enumeration value="QTR3"/>
            <xs:enumeration value="QTR4"/>
            <xs:enumeration value="HLF1"/>
            <xs:enumeration value="HLF2"/>
        </xs:restriction>
    </xs:simpleType>
    */
    List<string> codes = ["MM01", "MM02", "MM03", "MM04", "MM05",
                            "MM06", "MM07", "MM08", "MM09", "MM10",
                            "MM11", "MM12", "QTR1", "QTR2", "QTR3",
                            "QTR4", "HLF1", "HLF2"];
    int randomNumber = new Random().Next(codes.Count);
    return codes[randomNumber];
  }

  public string TrueFalseIndicator()
  {
    /*
    <xs:simpleType name="TrueFalseIndicator">
        <xs:restriction base="xs:boolean"/>
    </xs:simpleType>
    */
    int decision = new Random().Next(2);
    if (decision > 0)
    {
      return true.ToString();
    }
    else
    {
      return false.ToString();
    }
  }

  public string UUIDv4Identifier()
  {
    /*
    <xs:simpleType name="UUIDv4Identifier">
      <xs:restriction base="xs:string">
          <xs:pattern value="[a-f0-9]{8}-[a-f0-9]{4}-4[a-f0-9]{3}-[89ab][a-f0-9]{3}-[a-f0-9]{12}"/>
      </xs:restriction>
    </xs:simpleType>
    */

    string randomString = "";

    // [a-f0-9]{8}-
    for (int i = 0; i < 8; i++)
    {
      randomString += _lowerAlphaNumeric[new Random().Next(_lowerAlphaNumeric.Length)];
    }
    randomString += "-";

    // [a-f0-9]{4}-
    for (int i = 0; i < 4; i++)
    {
      randomString += _lowerAlphaNumeric[new Random().Next(_lowerAlphaNumeric.Length)];
    }
    randomString += "-";

    // 4[a-f0-9]{3}-
    randomString += "4";
    for (int i = 0; i < 3; i++)
    {
      randomString += _lowerAlphaNumeric[new Random().Next(_lowerAlphaNumeric.Length)];
    }
    randomString += "-";

    // [89ab][a-f0-9]{3}-
    List<string> randomChar = ["8", "9", "a", "b"];
    randomString += randomChar[new Random().Next(4)];

    for (int i = 0; i < 3; i++)
    {
      randomString += _lowerAlphaNumeric[new Random().Next(_lowerAlphaNumeric.Length)];
    }
    randomString += "-";

    // [a-f0-9]{12}
    for (int i = 0; i < 12; i++)
    {
      randomString += _lowerAlphaNumeric[new Random().Next(_lowerAlphaNumeric.Length)];
    }
    return randomString;
  }
}