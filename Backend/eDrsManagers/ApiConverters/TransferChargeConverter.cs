using eDrsDB.Models;
using System;
using System.Collections.Generic;
using System.Text;
using LrApiManager.XMLClases.TransferAndChargeApplicationRequest;

namespace eDrsManagers.ApiConverters
{
    public interface ITransferChargeConverter
    {
        TransferAndChargeApplicationRequest ArrangeLrApi(DocumentReference docRef);
    }
    public class TransferChargeConverter : ITransferChargeConverter
    {
        public TransferAndChargeApplicationRequest ArrangeLrApi(DocumentReference docRef)
        {
            throw new NotImplementedException();
        }
    }
}
