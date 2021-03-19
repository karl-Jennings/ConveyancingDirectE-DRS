using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using eDrsDB.Models;
using eDrsManagers.Interfaces;
using eDrsManagers.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace eDrsAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        private readonly IRegistration _registration;
        private readonly ILogsManager _logsManager;

        public RegistrationController(IRegistration registration, ILogsManager logsManager)
        {
            _registration = registration;
            _logsManager = logsManager;
        }

        /// <summary>
        /// Getting Registration types
        /// </summary>
        /// <returns>RegistrationType List</returns>
        [HttpGet]
        public IActionResult GetRegistrationTypes()
        {
            try
            {
                return Ok(_registration.GetRegistrationTypes());
            }
            catch (Exception ex)
            {
                return BadRequest(_logsManager.LogErrors(ex));
            }

        }

        /// <summary>
        /// Getting Registration type using ID
        /// </summary>
        /// <returns>RegistrationType List</returns>
        [HttpGet]
        public IActionResult GetRegistrationType(long regType)
        {
            try
            {
                return Ok(_registration.GetRegistrationType(regType));
            }
            catch (Exception ex)
            {
                return BadRequest(_logsManager.LogErrors(ex));
            }

        }

        /// <summary>
        /// Create Application Request : STEP 01
        /// </summary>
        /// <returns>boolean</returns>
        [HttpPost]
        public IActionResult CreateRegistration(DocumentReference viewModel)
        {
            try
            {
                return Ok(_registration.CreateRegistration(viewModel));
            }
            catch (Exception ex)
            {
                return BadRequest(_logsManager.LogErrors(ex));
            }
        }

        /// <summary>
        /// Update Registration 
        /// </summary>
        /// <returns>boolean</returns>
        [HttpPost]
        public IActionResult UpdateRegistration(DocumentReferenceViewModel viewModel)
        {
            try
            {
                return Ok(_registration.UpdateRegistration(viewModel));
            }
            catch (Exception ex)
            {
                return BadRequest(_logsManager.LogErrors(ex));
            }

        }

        /// <summary>
        /// Get Registrations
        /// </summary>
        /// <returns>DocumentReferenceViewModel List</returns>
        [HttpGet]
        public IActionResult GetRegistrations(string regType)
        {
            try
            {
                return Ok(_registration.GetRegistrations(regType));
            }
            catch (Exception ex)
            {
                return BadRequest(_logsManager.LogErrors(ex));
            }

        }

        /// <summary>
        /// Delete Registration
        /// </summary>
        /// <returns>bool</returns>
        [HttpGet]
        public IActionResult DeleteRegistration(long regId)
        {
            try
            {
                return Ok(_registration.DeleteRegistration(regId));
            }
            catch (Exception ex)
            {
                return BadRequest(_logsManager.LogErrors(ex));
            }

        }

        /// <summary>
        /// Get Registration
        /// </summary>
        /// <returns>DocumentReferenceViewModel</returns>
        [HttpGet]
        public IActionResult GetRegistration(long regId)
        {
            try
            {
                return Ok(_registration.GetRegistration(regId));
            }
            catch (Exception ex)
            {
                return BadRequest(_logsManager.LogErrors(ex));
            }

        }

        /// <summary>
        /// Getting poll request
        /// </summary>
        /// <returns>RestrictionPoolResponse</returns>
        [HttpGet]
        public IActionResult GetPoolResponse(long docRefId)
        {
            try
            {
                return Ok(_registration.GetPollResponse(docRefId));
            }
            catch (Exception ex)
            {
                return BadRequest(_logsManager.LogErrors(ex));
            }

        }

        /// <summary>
        /// Getting poll request
        /// </summary>
        /// <returns>RestrictionPoolResponse</returns>
        [HttpGet]
        public IActionResult GetOutStandingPollRequest(long docRefId, int serviceId)
        {
            try
            {
                return Ok(_registration.GetOutStandingPollRequest(docRefId, serviceId));
            }
            catch (Exception ex)
            {
                return BadRequest(_logsManager.LogErrors(ex));
            }

        }

        /// <summary>
        /// Getting Requisition request
        /// </summary>
        /// <returns>RestrictionPoolResponse</returns>
        [HttpGet]
        public IActionResult GetRequisition(long docRefId, int serviceId)
        {
            try
            {
                return Ok(_registration.GetRequisition(docRefId, serviceId));
            }
            catch (Exception ex)
            {
                return BadRequest(_logsManager.LogErrors(ex));
            }

        }

        /// <summary>
        /// Getting Requisition request
        /// </summary>
        /// <returns>RestrictionPoolResponse</returns>
        [HttpGet]
        public IActionResult GetFinalResult(long docRefId, int serviceId)
        {
            try
            {
                return Ok(_registration.GetFinalResult(docRefId, serviceId));
            }
            catch (Exception ex)
            {
                return BadRequest(_logsManager.LogErrors(ex));
            }

        }

    }
}
