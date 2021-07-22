using System;
using LinqToDB.Mapping;

namespace Console
{
    public record ValidIp
    {
        [PrimaryKey]
        public Guid Id { get; init; } = Guid.NewGuid();

        public string Ip { get; init; }
    }
}
