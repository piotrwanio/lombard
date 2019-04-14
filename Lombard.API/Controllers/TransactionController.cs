using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lombard.DAL.Models;
using Lombard.DAL.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lombard.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private ITransactionRepository _transactionRepository;

        public TransactionController(ITransactionRepository transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }

        [HttpPost("")]
        public void AddTransaction(Transaction transaction)
        {
            _transactionRepository.AddTransaction(transaction);
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
            List<Transaction> transactions = _transactionRepository.GetTransactionsByType(type);
            return transactions;
            }

            return BadRequest();
        }

        [HttpGet("")]
        public ActionResult<List<Transaction>> GetAllTransactions()
        {
            List<Transaction> transactions = _transactionRepository.GetTransactions();
            return transactions;
        }
    }
}