using Lombard.DAL.Models;
using Lombard.DAL.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Lombard.BLL.Services;

namespace Lombard.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionService _transactionService;

        public TransactionController(ITransactionService transactionRepository)
        {
            _transactionService = transactionRepository;
        }

        [HttpPost("")]
        public void AddTransaction(Transaction transaction)
        {
            _transactionService.AddTransaction(transaction);
        }

        [HttpGet("{kind}")]
        public ActionResult<List<Transaction>> GetTransactionsByType(string kind)
        {
            if (kind == "sell")
            {
                return _transactionService.GetTransactionsByType(TransactionType.Sell);
            }
            else if (kind == "purchase")
            {
                return _transactionService.GetTransactionsByType(TransactionType.Purchase);
            }

            return BadRequest();
        }

        [HttpGet("")]
        public ActionResult<List<Transaction>> GetAllTransactions()
        {
            return _transactionService.GetTransactions();
        }
    }
}