using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionRepository _repository;
        public TransactionController()
        {

        }

        [HttpGet("", Name = "GetTransactions")]
        public async Task<IActionResult> Get()
        {
            return NotFound();
        }

    }
}
