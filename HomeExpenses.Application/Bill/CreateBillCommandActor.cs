﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Akka.Actor;
using Core.Akka.ActorAutostart;
using Core.Domain.Repository;
using Core.Message.Response;
using HomeExpenses.Domain.Bill.Model;
using HomeExpenses.Message.Bill.Command;

namespace HomeExpenses.Application.Bill
{
    [AutostartActor("CreateBillCommandActor")]
    public class CreateBillCommandActor : ReceiveActor
    {
        private readonly IRepository<Domain.Bill.Model.Bill> _billRepository;

        public CreateBillCommandActor(IRepository<Domain.Bill.Model.Bill> billRepository)
        {
            _billRepository = billRepository;

            ReceiveAsync<CreateBillCommand>(Handle);
        }

        private async Task Handle(CreateBillCommand command)
        {
            var bill = new Domain.Bill.Model.Bill(command.Id, command.Metadata.UserId.Value, command.Name, null, new List<Payment>());

            await _billRepository.SaveAsync(bill);

            Console.Write("Zrobione");

            Sender.Tell(new CommandSuccessResponse());

            await Task.CompletedTask;
        }
    }
}