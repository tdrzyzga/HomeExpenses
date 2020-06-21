using System;
using System.Collections.Immutable;
using Core.Message.Queries;

namespace HomeExpenses.Message.Recipients.Queries
{
    public class GetRecipientListQuery : PaginableBaseQuery
    {
        public GetRecipientListQuery(int pageIndex, int itemsPerPage, string sortBy, string sortDir) : base(pageIndex, itemsPerPage, sortBy, sortDir)
        {
        }
    }

    public class GetRecipientListQueryResult : IQueryResult
    {
        public ImmutableArray<RecipientDto> Items { get; }
        public int TotalItems { get; }

        public GetRecipientListQueryResult(ImmutableArray<RecipientDto> items, int totalItems)
        {
            Items = items;
            TotalItems = totalItems;
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