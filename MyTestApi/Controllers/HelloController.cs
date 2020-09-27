using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Net;
using System.Net.Http;
using System.ComponentModel;
using System.Reflection;
using System.Net.Mime;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.Extensions.Configuration;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyTestApi.Controllers
{
    /// <summary>
    /// 예제
    /// </summary>
    [ApiController, Route("[controller]"), Produces(MediaTypeNames.Application.Json)]
    public class HelloController : ControllerBase
    {
        /// <summary>
        /// 예제
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IEnumerable<string> Get()
        {
            return new string[] { "MES MVP", "대형압연 작업지시 서비스" };
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IEnumerable<string> Post()
        {
            return new string[] { "MES MVP", "대형압연 작업지시 서비스" };
        }
    }
}
