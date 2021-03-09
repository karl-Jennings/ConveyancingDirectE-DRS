using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LrApiManager.SOAPManager;
using LrApiManager.XMLClases;
using LrApiManager.XMLClases.PollResponse;
using LrApiManager.XMLClases.Requestapplicationtochangeregister;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace eDRSUnitTest
{
    [TestClass]
    public class RepresentationsTest
    {


        [TestMethod]
        public void GenerateRepresentationBody()
        {
            RepresentationXMLGen representationXMLGen = new RepresentationXMLGen();          

            //LODGING CONVENYANCER
            Lodgingconveyancer lodgingconveyancer = new Lodgingconveyancer
            {
                RepresentativeId = 1
            };

            //REPRESENTING CONVENYANCER
            List<RepresentingConveyancer> representingConveyancers = new List<RepresentingConveyancer>();

            RepresentingConveyancer RepresentingConveyancer1 = new RepresentingConveyancer
            {


                ConveyancerName = "ConveyancerName1",
                Reference = "Reference1",
                DXAddress = new DXAddress
                {

                    DXExchange = "DXexchange",
                    DXNumber = "DXNumber",
                    CareOfAddressType = new CareOfAddressType
                    {

                        CareOfName = "CareOfName",
                        CareOfReference = "CareOfReference",

                    }
                },

                PostalAddress=null

            };
            RepresentingConveyancer RepresentingConveyancer2 = new RepresentingConveyancer
            {
                ConveyancerName = "ConveyancerName2",
                Reference = "Reference2",
                PostalAddress = new PostalAddress
                {
                    AddressLine1 = "AddressLine1",
                    AddressLine2 = "AddressLine2",
                    AddressLine3 = "AddressLine3",
                    AddressLine4 = "AddressLine4",
                    City = "City",
                    County = "County",
                    Country = "Country",
                    Postcode= "Postcode",
                    CareOfAddressType = new CareOfAddressType
                    {
                        CareOfName = "CareOfName",
                        CareOfReference = "CareOfReference"
                    }
                }

            };
            representingConveyancers.Add(RepresentingConveyancer1);
            representingConveyancers.Add(RepresentingConveyancer2);

            //Certified 

            Certified certified = new Certified {

                RepresentativeId=1
            };

            IdentityEvidence identityEvidence = new IdentityEvidence {

                RepresentativeId = 1
            };


            Representations Representations = new Representations
            {

                LodgingConveyancer= lodgingconveyancer,
                RepresentationsList = representingConveyancers,
                Certified = certified,
                IdentityEvidence = identityEvidence


            };

            representationXMLGen.GenerateReprecentationElements(Representations);
        }

        

    }
}
