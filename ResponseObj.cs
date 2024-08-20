using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class data
{
    [JsonProperty("march_equinox")]
    public string marchequinox { get; set; }

    [JsonProperty("june_solstice")]
    public string junesolstice { get; set; }

    [JsonProperty("september_equinox")]
    public string septemberequinox { get; set; }

    [JsonProperty("december_solstice")]
    public string decembersolstice { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
