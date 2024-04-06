using DotEnv.Core;

namespace DoteDog.Api.Configurations
{
    public class AppSettings
    {
        [EnvKey("CONNECTION_STRING")]
        public string? ConnectionString { get; set; }

    }
}