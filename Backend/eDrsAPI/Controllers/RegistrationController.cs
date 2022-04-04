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
        /// Create Application Request : STEP 01
        /// </summary>
        /// <returns>boolean</returns>
        [HttpPost]
        public IActionResult CreateRegistration(DocumentReferenceViewModel viewModel)
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

        [HttpGet]
        public IActionResult GetRegistrationByReference(string reference)
        {
            try
            {
                return Ok(_registration.GetRegistrationByReference(reference));
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
        public IActionResult GetRequisition(string AdditionalProviderFilter)
        {
            try
            {
                return Ok(_registration.GetRequisition(AdditionalProviderFilter));
            }
            catch (Exception ex)
            {
                return BadRequest(_logsManager.LogErrors(ex));
            }

        }

        [HttpGet]
        public IActionResult CollectResults(string AdditionalProviderFilter)
        {
            try
            {
                return Ok(_registration.CollectResultsAsync(AdditionalProviderFilter));
            }
            catch (Exception ex)
            {
                return BadRequest(_logsManager.LogErrors(ex));
            }

        }

        [HttpGet]
        public IActionResult GetEarlyCompletion(string AdditionalProviderFilter)
        {
            try
            {
                return Ok(_registration.EarlyCompletionAsync(AdditionalProviderFilter));
            }
            catch (Exception ex)
            {
                return BadRequest(_logsManager.LogErrors(ex));
            }

        }

        [HttpGet]
        public IActionResult CollectAllOutstandingsAsync(string AdditionalProviderFilter)
        {
            try
            {
                return Ok(_registration.CollectAllOutstandingsAsync(AdditionalProviderFilter));
            }
            catch (Exception ex)
            {
                return BadRequest(_logsManager.LogErrors(ex));
            }

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

        [HttpPost]
        public IActionResult UpdateRegistrationForRequisition(DocumentReferenceViewModel viewModel)
        {
            try
            {
                return Ok(_registration.UpdateRegistrationForRequisition(viewModel));
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

       

    
    }
}
