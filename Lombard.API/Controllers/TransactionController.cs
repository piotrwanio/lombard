using Lombard.DAL.Models;
using Lombard.DAL.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Lombard.BLL.Providers;

namespace Lombard.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionProvider _transactionProvider;

        public TransactionController(ITransactionProvider transactionRepository)
        {
            _transactionProvider = transactionRepository;
        }

        [HttpPost("")]
        public void AddTransaction(Transaction transaction)
        {
            _transactionProvider.AddTransaction(transaction);
        }

        [HttpGet("{kind}")]
        public ActionResult<List<Transaction>> GetTransactionsByType(string kind)
        {
            var type = TransactionType.None;
            switch (kind)
            {
                case "sell":
                    type = TransactionType.Sell;
                    break;
                case "purchase":
                    type = TransactionType.Purchase;
                    break;
            }

            if(type != TransactionType.None)
            {
            return _transactionProvider.GetTransactionsByType(type);
            }

            return BadRequest();
        }

        [HttpGet("")]
        public ActionResult<List<Transaction>> GetAllTransactions()
        {
            return _transactionProvider.GetTransactions();
        }
    }
}