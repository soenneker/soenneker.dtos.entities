using Soenneker.Attributes.PublicOpenApiObject;
using System;
using System.Text.Json.Serialization;

namespace Soenneker.Dtos.Entities;

/// <summary>
/// A hard type mapping to Entity
/// </summary>
[PublicOpenApiObject]
public class EntityDto
{
    [JsonPropertyName("id")]
    public virtual string Id { get; set; } = null!;

    [JsonPropertyName("createdAt")]
    public virtual DateTimeOffset CreatedAt { get; set; }

    [JsonPropertyName("modifiedAt")]
    public virtual DateTimeOffset? ModifiedAt { get; set; }
}
