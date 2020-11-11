using Moq;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Text;

namespace ApiTeste.Fixture
{
    public class DatabaseFixture : IDisposable
    {
        public IDbConnectionFactory DbConnectionFactory { get; private set; }
        public DatabaseFixture()
        {
            var factoryMock = new Mock<IDbConnectionFactory>();
            factoryMock
                .Setup(cf => cf.CreateConnectionOpened())
                .Returns(CreateConnectionMock);

            DbConnectionFactory = factoryMock.Object;
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
