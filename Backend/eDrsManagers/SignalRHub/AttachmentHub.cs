using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eDrsDB.Data;
using Microsoft.AspNetCore.SignalR;

namespace eDrsManagers.SignalRHub
{
    public class AttachmentHub : Hub
    {
        private readonly AppDbContext _context;

        public AttachmentHub(AppDbContext context)
        {
            _context = context;
        }

        public bool ChangeAttachmentState(long id, string type, bool state)
        {
            if (type == "app")
            {
                var application = _context.ApplicationForms.FirstOrDefault(x => x.ApplicationFormId == id);
                if (application != null) application.IsChecked = state;
            }
            else
            {
                var supportingDocuments = _context.SupportingDocuments.FirstOrDefault(x => x.SupportingDocumentId == id);
                if (supportingDocuments != null) supportingDocuments.IsChecked = state;
            }

            return _context.SaveChanges() > 0;

        }

    }
}
