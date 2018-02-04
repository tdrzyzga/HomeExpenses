namespace Core.Domain.ValueObjects
{
    public class AddressValueObject
    {
        public string Country { get; private set; }
        public string Voivodeship { get; private set; }
        public string County { get; private set; }
        public string Community { get; private set; }
        public string City { get; private set; }
        public string District { get; private set; }
        public string Street { get; private set; }
        public string Number { get; private set; }

        public bool IsEmpty => Equals(new AddressValueObject());

        public AddressValueObject()
        {
        }

        public AddressValueObject(string city, string street, string number)
        {
            City = city;
            Street = street;
            Number = number;
        }

        public AddressValueObject(string country, string voivodeship, string county, string community, string city, string district, string street, string number)
        {
            Country = country;
            Voivodeship = voivodeship;
            County = county;
            Community = community;
            City = city;
            District = district;
            Street = street;
            Number = number;
        }

        public void New(AddressValueObject address)
        {
            Country = address.Country;
            Voivodeship = address.Voivodeship;
            County = address.County;
            Community = address.Community;
            City = address.City;
            District = address.District;
            Street = address.Street;
            Number = address.Number;
        }

        public override bool Equals(object obj)
        {
            return obj is AddressValueObject address && Equals(address);
        }

        protected bool Equals(AddressValueObject other)
        {
            return string.Equals(Country, other.Country) && string.Equals(Voivodeship, other.Voivodeship) && string.Equals(County, other.County) &&
                   string.Equals(Community, other.Community) && string.Equals(City, other.City) && string.Equals(District, other.District) && string.Equals(Street, other.Street) &&
                   string.Equals(Number, other.Number);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = Country != null ? Country.GetHashCode() : 0;
                hashCode = (hashCode * 397) ^ (Voivodeship != null ? Voivodeship.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (County != null ? County.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Community != null ? Community.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (City != null ? City.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (District != null ? District.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Street != null ? Street.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Number != null ? Number.GetHashCode() : 0);
                return hashCode;
            }
        }
    }
}