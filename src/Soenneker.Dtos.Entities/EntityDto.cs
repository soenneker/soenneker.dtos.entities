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
    /// <summary>
    /// Gets or sets id.
    /// </summary>
    [JsonPropertyName("id")]
    public virtual string Id { get; set; } = null!;

    /// <summary>
    /// Gets or sets created at.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public virtual DateTimeOffset CreatedAt { get; set; }

    /// <summary>
    /// Gets or sets modified at.
    /// </summary>
    [JsonPropertyName("modifiedAt")]
    public virtual DateTimeOffset? ModifiedAt { get; set; }
}
