using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using DS.Api.Constants;
using DS.ViewModel.Constants;
using DS.ViewModel.Wrapper;
using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;

namespace DS.Api.Controller
{
        [Route("api/internal/[controller]")]
        [ApiController]
        public class BaseApiController : ControllerBase
        {
            protected ActionResult HandleResult<T>(T result, string? action = null)
            {
                if (!result!.Equals(default))
                {
                    var response = new Response<T>
                    {
                        StatusCode = (int)HttpStatusCode.OK,
                        Errors = default,
                        Data = result
                    };

                    response.Message = action switch
                    {
                        Applications.Actions.Add => Errors.ADD_SUCCESS,
                        Applications.Actions.Update => Errors.UPDATE_SUCCESS,
                        Applications.Actions.Delete => Errors.DELETE_SUCCESS,
                        _ => HttpStatusCode.OK.ToString()
                    };

                    return Ok(response);
                }

                return BadRequest(new Response<T>
                {
                    StatusCode = (int)HttpStatusCode.BadRequest,
                    Message = HttpStatusCode.BadRequest.ToString(),
                    Errors = default,
                    Data = default
                });
            }
        }
    }

