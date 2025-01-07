namespace ethereumLibrary.Models
{
    using System.Text.Json.Serialization;

    public class GasTrackModel
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("result")]
        public object ResultObject { get; set; }

        public GasTrackResultModel Result { get; set; }
    }

    public class GasTrackResultModel
    {
        [JsonPropertyName("LastBlock")]
        public string LastBlock { get; set; }

        [JsonPropertyName("SafeGasPrice")]
        public string SafeGasPrice { get; set; }

        [JsonPropertyName("ProposeGasPrice")]
        public string ProposeGasPrice { get; set; }

        [JsonPropertyName("FastGasPrice")]
        public string FastGasPrice { get; set; }
    }

    public class GasTrackConstantValues
    {
        public static string SuccessStatus = "1";
        public static string FailStatus = "0";
        public static string OkMessage = "OK";
        public static string NotOkMessage = "NOTOK";
    }
    public class EtherscanConstantValues
    {
        public static string SuccessStatus = "1";
        public static string FailStatus = "0";
        public static string OkMessage = "OK";
        public static string NotOkMessage = "NOTOK";
    }
}
