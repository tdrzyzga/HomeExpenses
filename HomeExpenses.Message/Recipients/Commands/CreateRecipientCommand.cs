using Core.Message.Commands;
using FluentValidation;
using Microsoft.Extensions.Localization;

namespace HomeExpenses.Message.Recipients.Commands
{
    public class CreateRecipientCommand : BaseCommand
    {
        public string Name { get; }
        public string City { get; }
        public string Street { get; }
        public string Number { get; }

        public CreateRecipientCommand(string name, string city, string street, string number)
        {
            Name = name;
            City = city;
            Street = street;
            Number = number;
        }
    }

    public class CreateRecipientCommandValidator : AbstractValidator<CreateRecipientCommand>
    {
        public CreateRecipientCommandValidator(IStringLocalizer<CreateRecipientCommand> localizer)
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithName(x => localizer["Name"]);

            RuleFor(x => x.City)
                .NotEmpty()
                .WithName(x => localizer["City"]);

            RuleFor(x => x.Street)
                .NotEmpty()
                .WithName(x => localizer["Street"]);

            RuleFor(x => x.Street)
                .NotEmpty()
                .WithName(x => localizer["Street"]);

            RuleFor(x => x.Number)
                .NotEmpty()
                .WithName(x => localizer["Number"]);
        }
    }
}