using System;
using System.Collections.Immutable;
using Core.Message.Queries;

namespace HomeExpenses.Message.Recipients.Queries
{
    public class GetRecipientListQuery : BaseQuery
    {
    }

    public class GetRecipientListResult : IQueryResult
    {
        public ImmutableArray<RecipientDto> Recipients { get; }

        public GetRecipientListResult(ImmutableArray<RecipientDto> recipients)
        {
            Recipients = recipients;
        }

        public class RecipientDto
        {
            public Guid Id { get; }
            public string Name { get; }
            public string City { get; }
            public string Street { get; }
            public string Number { get; }

            public RecipientDto(Guid id, string name, string city, string street, string number)
            {
                Id = id;
                Name = name;
                City = city;
                Street = street;
                Number = number;
            }
        }
    }
}