[![](https://img.shields.io/nuget/v/soenneker.dtos.entities.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.entities/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.entities/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.entities/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.dtos.entities.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.entities/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.entities/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.entities/actions/workflows/codeql.yml)

# Soenneker.Dtos.Entities

Provides the stable identifier and creation or modification timestamps shared by entity data-transfer objects.

## Install

```bash
dotnet add package Soenneker.Dtos.Entities
```

## What you get

- `EntityDto` — Provides the stable identifier and creation or modification timestamps shared by entity data-transfer objects.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `EntityDto.Id` | Stable unique identifier of the resource. | Stable unique identifier of the resource. |
| `EntityDto.CreatedAt` | UTC timestamp when the resource was created. | UTC timestamp when the resource was created. |
| `EntityDto.ModifiedAt` | UTC timestamp when the resource was last modified, or `null` when it has not been updated. | UTC timestamp when the resource was last modified, or `null` when it has not been updated. |
