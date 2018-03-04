using Akka.Actor;
using Core.Akka.ActorAutostart;
using Core.Domain.Repository;
using HomeExpenses.Domain.Bill;
using HomeExpenses.Message.Bill.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using HomeExpenses.Domain.Bill.Model;

namespace HomeExpenses.Application.Bill
{
    [AutostartActor("BillCommandActor")]
    public class BillCommandActor : ReceiveActor
    {
        private readonly IWriteRepository<Domain.Bill.Model.Bill> _billWriteRepository;

        public BillCommandActor(IWriteRepository<Domain.Bill.Model.Bill> billWriteRepository)
        {
            _billWriteRepository = billWriteRepository;

            ReceiveAsync<CreateBillCommand>(Handle);
        }

        private async Task Handle(CreateBillCommand command)
        {
            await _billWriteRepository.AddAsync(new Domain.Bill.Model.Bill(command.Id, command.Metadata.UserId.Value, command.Name, null, new List<Payment>()));

            await _billWriteRepository.SaveChangesAsync();

            Console.Write("Zrobione");

            await Task.CompletedTask;
        }
    }
}
