using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Akka.Actor;
using Core.Akka.ActorAutostart;
using Core.Application.Actor;
using Core.Domain.Repository;
using Core.Message.Response;
using HomeExpenses.Domain.Bills.Model;
using HomeExpenses.Message.Bills.Commands;
using Microsoft.Extensions.Logging;

namespace HomeExpenses.Application.Bills
{
    [AutostartActor("CreateBillCommandActor")]
    public class CreateBillCommandActor : BaseActor
    {
        private readonly IRepository<Bill> _billRepository;

        public CreateBillCommandActor(ILogger<CreateBillCommandActor> logger, IRepository<Bill> billRepository) : base(logger)
        {
            _billRepository = billRepository;

            ReceiveAsync<CreateBillCommand>(Handle);
        }

        private async Task Handle(CreateBillCommand command)
        {
            await HandleCommand(command, async x =>
            {
                var bill = new Bill(x.Id, x.Metadata.TenantId.Value, x.Name, null, new List<Payment>());

                await _billRepository.SaveAsync(bill);

                Console.Write("Zrobione");

                Sender.Tell(new CommandSuccessResponse());

                await Task.CompletedTask;
            });
        }
    }
}