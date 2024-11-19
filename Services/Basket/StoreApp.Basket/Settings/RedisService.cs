using StackExchange.Redis;

namespace StoreApp.Basket.Settings
{
    public class RedisService
    {
        public string _host { get; set; }
        public int _port { get; set; }

        private ConnectionMultiplexer _connectionMultiplexer; //redis ile bağlantı kurmak için kullanılan nesne
        public RedisService(string host, int port)
        {
            _host = host;
            _port = port;
        }

        public void Connect() => _connectionMultiplexer = ConnectionMultiplexer.Connect($"{_host}:{_port}");
        public IDatabase GetDb(int db = 0) => _connectionMultiplexer.GetDatabase(db); //0 nolu db yi getir
    }
}
