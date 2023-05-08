﻿using System.Text.Json.Serialization;

namespace BabySounds.Contracts.Responses;

public sealed record LoginResponse
{
    [JsonPropertyName("token_type")]
    public string TokenType { get; set; }

    [JsonPropertyName("access_token")]
    public string AccessToken { get; set; }
}
