using System;
using System.Xml.Serialization;
using System.IO;
using System.Xml;

namespace BusinessGatewayRepositories
{
    public class OS1Repository
    {
        public OS1Repository() { }
        public OS1.ResponseOfficialSearchOfWholeWithPriorityV2_0Type GetOS1(string MessageId, string ExternalRef, string PropertyDescription, string CustomerRef, string TitleNumber, string ContactName, string Telephone, decimal ExpectedAmount, string PriorityCode, string Proprietor,string Applicant, DateTime SearchDate, string Username, string Password)
        {
            try
            {
                OS1.Q1ProductType _product = new OS1.Q1ProductType();
                OS1.Q1ContactType[] _Contact = new OS1.Q1ContactType[1];
                OS1.OfficialSearchV2_1ServiceClient _service = new OS1.OfficialSearchV2_1ServiceClient();
                XmlSerializer serializer = new XmlSerializer(typeof(BusinessGatewayRepositories.OS1.RequestOfficialSearchOfWholeWithPriorityV2_1Type));
                OS1.RequestOfficialSearchOfWholeWithPriorityV2_1Type _request = new OS1.RequestOfficialSearchOfWholeWithPriorityV2_1Type();
                _request.ID = new OS1.Q1IdentifierType { MessageID = new OS1.Q1TextType { Value = MessageId } };
                OS1.Q1SubjectPropertyType _subjectProperty = new OS1.Q1SubjectPropertyType();
                
                OS1.Q1OfficialSearchOfWholeWithPriorityType _officialSearch = new OS1.Q1OfficialSearchOfWholeWithPriorityType();
                _Contact[0] = new OS1.Q1ContactType { Name = new OS1.Q3TextType { Value = ContactName }, Communication = new OS1.Q1CommunicationType { Telephone = new OS1.Q3TextType { Value = Telephone } } };
                _product.Contact = _Contact;

                OS1.AmountType _amount = new OS1.AmountType { Value = ExpectedAmount, currencyID = "GBP" };
                _product.ExpectedPrice = new OS1.Q1ExpectedPriceType { GrossPriceAmount = _amount, NetPriceAmount = _amount, VATAmount = new OS1.AmountType { Value = 12 } };
                //_product.ExpectedPrice = new OS1.Q1ExpectedPriceType { GrossPriceAmount = new OS1.AmountType { Value = ExpectedAmount, currencyID = "GBP" } };

                //Add the external reference details
                
                _product.ExternalReference = new OS1.Q1ExternalReferenceType
                {
                    AllocatedBy = new OS1.Q3TextType { Value = ContactName },
                    Description = new OS1.Q3TextType { Value = "OSRequest" },
                    Reference = ExternalRef
                };
                //Add the customer refernence details
                _product.CustomerReference = new OS1.Q1CustomerReferenceType
                {
                    AllocatedBy = new OS1.Q3TextType { Value = ContactName },
                    Description = new OS1.Q3TextType { Value = "OSRequest" },
                    Reference = CustomerRef
                };
                _subjectProperty.TitleNumber = new OS1.Q2TextType { Value = TitleNumber };
                _officialSearch.ContinueIfActualFeeExceedsExpectedFeeIndicator = new OS1.IndicatorType { Value = true };
                _officialSearch.ContinueIfNameMismatchOnRegisterIndicator = new OS1.IndicatorType { Value = true };
                _officialSearch.ContinueIfPendingSearchesOfPartIndicator = new OS1.IndicatorType { Value = true };
                _officialSearch.ContinueIfDeveloperTitleIndicator = new OS1.IndicatorType { Value = true };
                _officialSearch.ApplicantParty = ContactName;
                _officialSearch.SearchFromDate = new OS1.SearchFromDateType { Value = SearchDate };
                _officialSearch.PropertyDescription = PropertyDescription;
                _officialSearch.RegisteredProprietorsDetailsOrApplicantsForFirstRegistration = Proprietor;
                _officialSearch.ApplicantParty = Applicant;
                switch (PriorityCode)
                {
                    case "Purchase":
                        _officialSearch.PriorityTypeCode = new OS1.PriorityCodeType { Value = OS1.PriorityCodeContentType.Item10 };
                        break;
                    case "Lease":
                        _officialSearch.PriorityTypeCode = new OS1.PriorityCodeType { Value = OS1.PriorityCodeContentType.Item20 };
                        break;
                    case "Charge":
                        _officialSearch.PriorityTypeCode = new OS1.PriorityCodeType { Value = OS1.PriorityCodeContentType.Item30 };
                        break;
                }
                
                _product.OfficialSearchOfWholeWithPriority = _officialSearch;
                _product.SubjectProperty = _subjectProperty;
                _request.Product = _product;
                _service.ChannelFactory.Endpoint.EndpointBehaviors.Add(new BusinessGatewayRepositories.HMLRBGMessageEndpointBehavior(Username, Password));
                string _requestXml = SerializeRequest(_request);
                WriteXML(_request);
                OS1.ResponseOfficialSearchOfWholeWithPriorityV2_0Type _response = _service.processOS1Request(_request);
                //string _responseXml = SerializeResponse(_response);
                WriteXMLResponse(_response, TitleNumber);
                if (_response.GatewayResponse.Results != null)
                {
                    WriteAttachment(TitleNumber, _response.GatewayResponse.Results.Attachment);
                }
                
                return _response;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private string SerializeRequest(object Object)
        {
            XmlSerializer xsSubmit = new XmlSerializer(typeof(OS1.RequestOfficialSearchOfWholeWithPriorityV2_1Type));
            StringWriter sww = new StringWriter();
            XmlWriter writer = XmlWriter.Create(sww);
            xsSubmit.Serialize(writer, Object);
            return sww.ToString(); //
        }
        private string SerializeResponse(object Object)
        {
            XmlSerializer xsSubmit = new XmlSerializer(typeof(OS1.ResponseOfficialSearchOfWholeWithPriorityV2_0Type));
            StringWriter sww = new StringWriter();
            XmlWriter writer = XmlWriter.Create(sww);
            xsSubmit.Serialize(writer, Object);
            return sww.ToString(); //
        }
        public void WriteXML(OS1.RequestOfficialSearchOfWholeWithPriorityV2_1Type Request)
        {
          //  string _FileLocation = ConfigurationManager.AppSettings["FileLocation"] + Request.Product.SubjectProperty.TitleNumber.Value + "_req.xml";
            string _FileLocation = AppSettings.Resolve.GetSetting_ByName("FileLocation").Value + Request.Product.SubjectProperty.TitleNumber.Value + "_req.xml";
            //If the file exists for some reason then we don't want to create it twice
            if (System.IO.File.Exists(_FileLocation) == false)
            {
                System.IO.FileStream f = System.IO.File.Create(_FileLocation);
                f.Close();
            }

            //We then want to serialise the response object and write it out to the xml file
            XmlSerializer serializer = new XmlSerializer(Request.GetType());
            TextWriter tw = new StreamWriter(_FileLocation);
            serializer.Serialize(tw, Request);
            tw.Close();
        }
        public void WriteAttachment(string TitleNumber, BusinessGatewayRepositories.OS1.Q1AttachmentType Attachment)
        {
            //string _FileLocation = ConfigurationManager.AppSettings["FileLocation"] + TitleNumber + "." + Attachment.EmbeddedFileBinaryObject.format;
            string _FileLocation = AppSettings.Resolve.GetSetting_ByName("FileLocation").Value + TitleNumber + "." + Attachment.EmbeddedFileBinaryObject.format; //We want to get the pdf from the value of the byte array and write it.
            BusinessGatewayRepositories.OS1.BinaryObjectType _binaryFile = Attachment.EmbeddedFileBinaryObject;

            byte[] buff;
            buff = _binaryFile.Value;
            try
            {
                FileStream fs = new FileStream(_FileLocation, FileMode.Create, FileAccess.ReadWrite);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(buff);
                bw.Close();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void WriteXMLResponse(OS1.ResponseOfficialSearchOfWholeWithPriorityV2_0Type Response,string TitleNumber)
        {
           // string _FileLocation = ConfigurationManager.AppSettings["FileLocation"] + TitleNumber + "_res.xml";
            string _FileLocation = AppSettings.Resolve.GetSetting_ByName("FileLocation").Value + TitleNumber + "_res.xml";
            //If the file exists for some reason then we don't want to create it twice
            if (System.IO.File.Exists(_FileLocation) == false)
            {
                System.IO.FileStream f = System.IO.File.Create(_FileLocation);
                f.Close();
            }

            //We then want to serialise the response object and write it out to the xml file
            XmlSerializer serializer = new XmlSerializer(Response.GetType());
            TextWriter tw = new StreamWriter(_FileLocation);
            serializer.Serialize(tw, Response);
            tw.Close();
        }
    }
}
