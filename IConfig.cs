using Amazon;

namespace poc_sns
{
    internal interface IConfig
    {
        RegionEndpoint RegionEndpoint { get; }
        string AccessKey { get; }
        string SecretKey { get; }
        
        /// <summary>
        /// Use +
        /// Ex: +5521999999999
        /// </summary>
        string Number { get; }
    }
}
