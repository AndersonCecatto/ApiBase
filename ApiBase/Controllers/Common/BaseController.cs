using Microsoft.AspNetCore.Mvc;
using System;

namespace ApiBase.Controllers.Common
{
    public abstract class BaseController : ControllerBase
    {
        protected ActionResult Execute(Func<object> func)
        {
            try
            {
                return Ok(func());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
