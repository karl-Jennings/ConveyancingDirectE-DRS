using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessGatewayModels
{
    public class ResponseOwnerVerification
    {
        public string Reference { get; set; }
        public string Error { get; set; }
        public bool Successful { get; set; }
        public string SurnameMatch { get; set; }
        public string FirstNameMatch { get; set; }
        public string MiddleNameMatch { get; set; }
        public int NumberOfMatches { get; set; }
        public string MatchResult { get; set; } 
        public List<MatchInformation> Matches { get; set; }
        public ResponseOwnerVerification() { }
        public ResponseOwnerVerification(BusinessGatewayRepositories.OwnerVerification.ResponseOnlineOwnershipVerificationType Response)
        {

            switch (Response.TypeCode)
            {
                case BusinessGatewayRepositories.OwnerVerification.TypeCodes.Item10:
                    Successful = false;
                    Error = "Unable to process at this time";
                    break;
                case BusinessGatewayRepositories.OwnerVerification.TypeCodes.Item20:
                    Successful = false;
                    Error = Response.Rejection.Reason;
                    break;
                case BusinessGatewayRepositories.OwnerVerification.TypeCodes.Item30:
                    break;
            }

            Matches = new List<MatchInformation>();
            if (Response.Result != null)
            {
                switch (Response.Result.MatchResult.ToString().ToLower())
                {
                    case "single_match":
                        MatchResult = "Single";
                        break;
                    case "no_matches":
                        MatchResult = "None";
                        break;
                    case "multiple_matches":
                        MatchResult = "Multiple";
                        break;
                }
                if(Response.Result.Match != null)
                {
                    NumberOfMatches = Response.Result.Match.Length;
                    foreach (var _match in Response.Result.Match)
                    {

                        FirstNameMatch = TypeOfMatch(_match.ForenameMatchDetails.TypeOfMatch.ToString());
                        MiddleNameMatch = TypeOfMatch(_match.MiddleNameMatchDetails.TypeOfMatch.ToString());
                        SurnameMatch = TypeOfMatch(_match.SurnameMatch.TypeOfMatch.ToString());
                        MatchInformation _matchInfo = new MatchInformation();
                        if (_match.MatchInformation != null)
                        {
                            foreach (var _matchInformation in _match.MatchInformation)
                            {
                                switch (_matchInformation.Name.ToLower())
                                {
                                    case "historicalmatch":
                                        _matchInfo.Historical = Convert.ToBoolean(_matchInformation.Value);
                                        break;
                                    case "proprietorfrom":
                                        _matchInfo.ProprietorFrom = Convert.ToDateTime(_matchInformation.Value);
                                        break;
                                    case "proprietorto":
                                        _matchInfo.ProprietorTo = Convert.ToDateTime(_matchInformation.Value);
                                        break;
                                    case "ownership":
                                        _matchInfo.Ownership = _matchInformation.Value;
                                        break;
                                }
                            }
                            Matches.Add(_matchInfo);
                        }
                        
                    }
                }
                this.Reference = Response.Result.Reference;
                Successful = true;
            }
        }
        private string TypeOfMatch(string MatchType)
        {
            string _returnValue = "";
            switch (MatchType.ToLower())
            {
                case "match":
                    _returnValue = "Match";
                    break;
                case "no_match":
                    _returnValue = "No Match";
                    break;
                case "skipped":
                    _returnValue = "Skipped";
                    break;
                case "partial_match":
                    _returnValue = "Partial";
                    break;
            }
            return _returnValue;
        }
    }
    public class MatchInformation
    {
        public bool Historical { get; set; }
        public DateTime ProprietorFrom { get; set; }
        public DateTime ProprietorTo { get; set; }
        public string Ownership { get; set; }
        public MatchInformation()
        {
            //this.MatchType = Result.ForenameMatchDetails.TypeOfMatch;

        }
    }
}
