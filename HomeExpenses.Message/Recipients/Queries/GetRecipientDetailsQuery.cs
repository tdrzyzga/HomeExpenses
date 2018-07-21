using System;
using Core.Message.Queries;

namespace HomeExpenses.Message.Recipients.Queries
{
    public class GetRecipientDetailsQuery : BaseQuery
    {
        public Guid Id { get; }

        public GetRecipientDetailsQuery(Guid id)
        {
            Id = id;
        }
    }

    public class GetRecipientDetailsResult : IQueryResult
    {
        public Guid Id { get; }
        public string Name { get; }
        public string City { get; }
        public string Street { get; }
        public string Number { get; }

        public GetRecipientDetailsResult(Guid id, string name, string city, string street, string number)
        {
            Id = id;
            Name = name;
            City = city;
            Street = street;
            Number = number;
        }
    }
}