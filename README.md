## Mock ISO 20022 Data Generator API

This application serves as a valuable tool for developers requiring sample ISO 20022 data. It offers a straightforward API to programmatically generate realistic ISO 20022 messages in both JSON and XML formats. This capability streamlines testing and development workflows by providing readily available data structures that adhere to the ISO 20022 standard.

**Currently, the API supports the generation of pacs.002.001.12 messages.**

Future enhancements to this API will include support for a wider range of ISO 20022 message sets, further expanding its utility for various financial messaging scenarios.

Here is an example of a pacs.002.001.12 XML message. Each inner text represents the simpleType the element should derive its value from.
The inner text that do not correspond with a simpleType name will be treated as unmutable text.

```xml
<?xml version="1.0"?>
<NtfctnToRcv>
    <GrpHdr>
        <MsgId>318393</MsgId>
        <CreDtTm>ISODateTime</CreDtTm>
    </GrpHdr>
    <Ntfctn>
        <Id>ExternalAccountIdentification1Code</Id>
        <Itm>
            <Id>BEBEBB0023CRESZZ</Id>
            <EndToEndId>BEBEBB0023CRESZZ</EndToEndId>
            <Acct>
                <Id>
                    <Othr>
                        <SchmeNm/>
                    </Othr>
                </Id>
            </Acct>
            <Amt>
                <ActiveOrHistoricCurrencyAndAmount_SimpleType Ccy="USD">
                    <ActiveOrHistoricCurrencyAndAmount_SimpleType>ActiveOrHistoricCurrencyAndAmount_SimpleType</ActiveOrHistoricCurrencyAndAmount_SimpleType>
                </ActiveOrHistoricCurrencyAndAmount_SimpleType>
            </Amt>
            <XpctdValDt>2010-02-22</XpctdValDt>
            <Dbtr>
                <Pty>
                    <PstlAdr/>
                    <Id>
                        <OrgId/>
                        <PrvtId>
                            <Othr>
                                <SchmeNm/>
                            </Othr>
                        </PrvtId>
                    </Id>
                </Pty>
            </Dbtr>
            <DbtrAgt>
                <FinInstnId>
                    <BICFI>BICFIDec2014Identifier</BICFI>
                    <ClrSysMmbId>
                        <ClrSysId/>
                        <MmbId/>
                    </ClrSysMmbId>
                    <PstlAdr/>
                </FinInstnId>
            </DbtrAgt>
            <IntrmyAgt>
                <FinInstnId>
                    <BICFI>BICFIDec2014Identifier</BICFI>
                    <ClrSysMmbId>
                        <ClrSysId/>
                        <MmbId/>
                    </ClrSysMmbId>
                    <PstlAdr/>
                </FinInstnId>
            </IntrmyAgt>
        </Itm>
    </Ntfctn>
</NtfctnToRcv>
</Document>
```
