using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Akka.Actor;
using Core.Akka.ActorAutostart;
using Core.Domain.Repository;
using Core.Message.Response;
using HomeExpenses.Domain.Bills.Model;
using HomeExpenses.Message.Bills.Commands;

namespace HomeExpenses.Application.Bills
{
    [AutostartActor("CreateBillCommandActor")]
    public class CreateBillCommandActor : ReceiveActor
    {
        private readonly IRepository<Bill> _billRepository;

        public CreateBillCommandActor(IRepository<Bill> billRepository)
        {
            _billRepository = billRepository;

            ReceiveAsync<CreateBillCommand>(Handle);
        }

        private async Task Handle(CreateBillCommand command)
        {
            var bill = new Bill(command.Id, command.Metadata.TenantId.Value, command.Name, null, new List<Payment>());

            await _billRepository.SaveAsync(bill);

            Console.Write("Zrobione");

            Sender.Tell(new CommandSuccessResponse());

            await Task.CompletedTask;
        }
    }
}