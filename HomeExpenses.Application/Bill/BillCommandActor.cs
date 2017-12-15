using Akka.Actor;
using Core.Akka.ActorAutostart;
using HomeExpenses.Message.Bill.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HomeExpenses.Application.Bill
{
    [AutostartActor("BillCommandActor")]
    public class BillCommandActor : ReceiveActor
    {
        public BillCommandActor()
        {
            ReceiveAsync<AddBillCommand>(Handle);
        }

        private async Task Handle(AddBillCommand command)
        {
            Console.Write("Zrobione");

            await Task.CompletedTask;
        }
    }
}
