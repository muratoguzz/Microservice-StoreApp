using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Order.Application.Features.CQRS.Queries.AddressQueries
{
    public class GetAddressByIdQuery //sorgu için gerekli olan parametreyi taşıyan yapı, handleri db den bağımsız hale getiriyoruz
    {
        public int Id { get; set; }
        public GetAddressByIdQuery(int id)
        {
            Id = id;
        }
    }
}
