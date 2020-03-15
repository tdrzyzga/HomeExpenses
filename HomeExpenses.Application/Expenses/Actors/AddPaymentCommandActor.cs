﻿using System;
using System.Threading.Tasks;
using Core.Akka.ActorAutostart;
using Core.Application.Actors;
using Core.Domain.Repositories;
using HomeExpenses.Domain.Expenses.Model;
using HomeExpenses.Message.Expenses.Commands;

namespace HomeExpenses.Application.Expenses.Actors
{
    [AutostartActor("AddPaymentCommandActor")]
    public class AddPaymentCommandActor : BaseActor, ICommandActor<AddPaymentCommand>
    {
        private readonly IRepository<Expense> _expenseRepository;

        public AddPaymentCommandActor(IBaseActorPayload payload, IRepository<Expense> expenseRepository)
            : base(payload)
        {
            _expenseRepository = expenseRepository;
            ReceiveAsync<AddPaymentCommand>(Handle);
        }

        private async Task Handle(AddPaymentCommand command)
        {
            await HandleCommand(command, async x =>
            {
                var expense = await _expenseRepository.Get(command.ExpenseId, command.Metadata.TenantId);

                await expense.AddPayment(command.RecipientId, command.Amount, DateTime.UtcNow);

                await _expenseRepository.Save(expense);
            });
        }
    }
}