[![](https://img.shields.io/nuget/v/soenneker.dtos.entities.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.entities/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.entities/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.entities/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.dtos.entities.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.entities/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.entities/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.entities/actions/workflows/codeql.yml)

# Soenneker.Dtos.Entities

Provides a reusable entity DTO base with an identifier and creation/modification timestamps.

## Installation

```bash
dotnet add package Soenneker.Dtos.Entities
```

## Usage

```csharp
using Soenneker.Dtos.Entities;

public sealed class CustomerDto : EntityDto
{
    public string Email { get; set; } = null!;
}

var customer = new CustomerDto
{
    Id = "customer-42",
    CreatedAt = DateTimeOffset.UtcNow,
    ModifiedAt = null,
    Email = "ada@example.com"
};
```

System.Text.Json maps the inherited properties to:

| Property | JSON name | Initial value |
| --- | --- | --- |
| `Id` | `id` | Uninitialized |
| `CreatedAt` | `createdAt` | `default(DateTimeOffset)` |
| `ModifiedAt` | `modifiedAt` | `null` |

The properties are virtual so specialized DTOs can override them. The class is also marked with `PublicOpenApiObject` for Soenneker OpenAPI discovery.

The model does not generate IDs or timestamps, validate identifier format, or enforce chronological ordering. `DateTimeOffset` can represent offsets other than UTC; use `UtcNow` or normalize values yourself when your API contract requires UTC.

Only System.Text.Json property-name attributes are declared. Newtonsoft.Json naming follows the caller’s serializer settings.
