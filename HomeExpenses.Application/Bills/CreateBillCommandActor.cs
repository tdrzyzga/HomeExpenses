using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Akka.Actor;
using Core.Akka.ActorAutostart;
using Core.Application.Actor;
using Core.Domain.Repository;
using Core.Domain.ValueObjects;
using Core.Message.Response;
using HomeExpenses.Domain;
using HomeExpenses.Domain.Bills.Factory;
using HomeExpenses.Domain.Bills.Model;
using HomeExpenses.Message.Bills.Commands;
using Microsoft.Extensions.Logging;

namespace HomeExpenses.Application.Bills
{
    [AutostartActor("CreateBillCommandActor")]
    public class CreateBillCommandActor : BaseActor
    {
        private readonly IRepository<Bill> _billRepository;
        private readonly IBillFactory _billFactory;

        public CreateBillCommandActor(ILogger<CreateBillCommandActor> logger, IRepository<Bill> billRepository, IBillFactory billFactory) : base(logger)
        {
            _billRepository = billRepository;
            _billFactory = billFactory;

            ReceiveAsync<CreateBillCommand>(Handle);
        }

        private async Task Handle(CreateBillCommand command)
        {
            await HandleCommand(command, async x =>
            {
                var recipientAddress = new AddressValueObject(command.City, command.Street, command.Number);

                var bill = await _billFactory.Create(command.Id, command.Metadata.TenantId, command.Name, (BillType) command.Type, command.RecipientName, recipientAddress);

                await _billRepository.SaveAsync(bill);
            });
        }
    }
}