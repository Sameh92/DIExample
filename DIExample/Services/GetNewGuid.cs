using System;

namespace DIExample.Services
{
    public class GetNewGuid : IGetNewGuid
    {
        public Guid id { get; set; }
        public GetNewGuid()
        {
            id= Guid.NewGuid();
        }
        public Guid GetGuid()
        {
         return id;
        }
    }
}
