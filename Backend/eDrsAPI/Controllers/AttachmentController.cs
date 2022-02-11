using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eDrsManagers.Interfaces;
using eDrsManagers.ViewModels;

namespace eDrsAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AttachmentController : ControllerBase
    {
        private readonly ILogsManager _logsManager;
        private readonly IAttachmentManager _attachment;

        public AttachmentController(IAttachmentManager attachment, ILogsManager logsManager)
        {
            _attachment = attachment;
            _logsManager = logsManager;
        }

        /// <summary>
        /// Get Poll Attachment 
        /// </summary>
        /// <returns>byte[]</returns>
        [HttpGet]
        public IActionResult GetAttachment(long requestId)
        {
            try
            {
                return File(
                    _attachment.GetAttachment(requestId),
                    "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"

                );

            }
            catch (Exception ex)
            {
                return BadRequest(_logsManager.LogErrors(ex));
            }
        }

        /// <summary>
        /// Calling Attachments
        /// </summary>
        /// <returns>byte[]</returns>
        [HttpGet]
        public IActionResult RespondToRequisition(long docRefId)
        {
            try
            {
                return Ok(_attachment.RespondToRequisition(docRefId));

            }
            catch (Exception ex)
            {
                return BadRequest(_logsManager.LogErrors(ex));
            }
        }

        [HttpGet]
        public IActionResult RespondToRequisitionByReference(string reference)
        {
            try
            {
                return Ok(_attachment.RespondToRequisitionByReference(reference));

            }
            catch (Exception ex)
            {
                return BadRequest(_logsManager.LogErrors(ex));
            }
        }

        [HttpGet]
        public IActionResult CollectAttachmentResults(long docRefId)
        {
            try
            {
                return Ok(_attachment.CollectAttachmentResults(docRefId));

            }
            catch (Exception ex)
            {
                return BadRequest(_logsManager.LogErrors(ex));
            }
        }
        [HttpPost]
        public IActionResult DirectRespondToRequisition(DocumentReferenceViewModel viewModel)
        {
            try
            {
                return Ok(_attachment.DirectRespondToRequisition(viewModel));
            }
            catch (Exception ex)
            {
                return BadRequest(_logsManager.LogErrors(ex));
            }
        }
    }
}
