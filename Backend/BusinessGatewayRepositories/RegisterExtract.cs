using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using System.Configuration;
using BGConfigurations;

namespace BusinessGatewayRepositories
{
    public class RegisterExtract
    {
        public RegisterExtract() { }
        public RES.ResponseOCWithSummaryV2_1Type GetRegisterExtract(string MessageId,string AllocatedBy, string CustomerRef, string ExternalRef, string TitleNumber, decimal GrossPrice,
            bool ContinueIfExceeds,bool IncludePlan, bool NotifyIfPendingFirstRegistration, bool SendBackDated, bool NotifyIfPendingApplication,bool ContinueIfTitleClosed,string UserName,string Password)
        {
            RES.ResponseOCWithSummaryV2_1Type _response = new RES.ResponseOCWithSummaryV2_1Type();
            RES.RequestOCWithSummaryV2_0Type _request = new RES.RequestOCWithSummaryV2_0Type();
            RES.Q1ProductType _product = new RES.Q1ProductType();
            RES.Q1TitleKnownOfficialCopyType _title = new RES.Q1TitleKnownOfficialCopyType();
            RES.OCWithSummaryV2_1ServiceClient _service = new RES.OCWithSummaryV2_1ServiceClient();
            XmlSerializer serializer = new XmlSerializer(typeof(BusinessGatewayRepositories.RES.RequestOCWithSummaryV2_0Type));
            _product.CustomerReference = new RES.Q1CustomerReferenceType{ Reference = CustomerRef, AllocatedBy = new RES.Q3TextType{ Value = AllocatedBy }, Description = new RES.Q3TextType{ Value = "Request"}};
            _product.ExternalReference = new RES.Q1ExternalReferenceType{ Reference = ExternalRef, AllocatedBy = new RES.Q3TextType{ Value = AllocatedBy }, Description = new RES.Q3TextType{ Value = "Request"}};
            _request.ID = new RES.Q1IdentifierType { MessageID = new RES.Q1TextType { Value = MessageId } };

            _product.ExpectedPrice = new RES.Q1ExpectedPriceType { GrossPriceAmount = new RES.AmountType { Value = GrossPrice, currencyID = "GBP" } };

            _title.ContinueIfActualFeeExceedsExpectedFeeIndicator = new RES.IndicatorType { Value = ContinueIfExceeds };
            _title.ContinueIfTitleIsClosedAndContinuedIndicator = new RES.IndicatorType { Value = ContinueIfTitleClosed };
            _title.IncludeTitlePlanIndicator = new RES.IndicatorType { Value = IncludePlan };
            _title.NotifyIfPendingApplicationIndicator = new RES.IndicatorType { Value = NotifyIfPendingApplication };
            _title.NotifyIfPendingFirstRegistrationIndicator = new RES.IndicatorType { Value = NotifyIfPendingFirstRegistration };
            _title.SendBackDatedIndicator = new RES.IndicatorType { Value = SendBackDated };

            _product.TitleKnownOfficialCopy = _title;

           

            _product.SubjectProperty = new RES.Q1SubjectPropertyType { TitleNumber = new RES.Q2TextType { Value = TitleNumber } };

            _request.Product = _product;

            try
            {
                _service.ChannelFactory.Endpoint.EndpointBehaviors.Add(new BusinessGatewayRepositories.HMLRBGMessageEndpointBehavior(UserName, Password));
                WriteXML(_request);
                _response = _service.performOCWithSummary(_request);

                return _response;
            }
            catch (Exception ex)
            {
                throw;
            }
            
        }
        public void WriteXML(BusinessGatewayRepositories.RES.RequestOCWithSummaryV2_0Type Request)
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

    }
}
