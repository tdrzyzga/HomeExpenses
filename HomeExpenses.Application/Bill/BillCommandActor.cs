﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Akka.Actor;
using Core.Akka.ActorAutostart;
using Core.Domain.Repository;
using HomeExpenses.Domain.Bill.Model;
using HomeExpenses.Message.Bill.Command;

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
            var bill = new Domain.Bill.Model.Bill(command.Id, command.Metadata.UserId.Value, command.Name, null, new List<Payment>());

            await _billWriteRepository.SaveAsync(bill);

            Console.Write("Zrobione");

            await Task.CompletedTask;
        }
    }
}