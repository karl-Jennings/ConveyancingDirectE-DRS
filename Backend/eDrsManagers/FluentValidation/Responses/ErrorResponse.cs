using System.Collections.Generic;

namespace eDrsManagers.FluentValidation.Responses {
    public class ErrorResponse {
        public List<ErrorModel> Errors { get; set; } = new List<ErrorModel>(); 
    }
}
