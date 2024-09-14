---
sidebar_label: GetProfile
---

# RegistrationController\.GetProfile\(Guid\) Method

**Containing Type**: [RegistrationController](../index.md)

**Assembly**: LXP\.Api\.dll

  
Get profile id by learner id Ruban

```csharp
[Microsoft.AspNetCore.Mvc.HttpGet("GetProfileId/{learnerId}")]
public Guid GetProfile(Guid learnerId)
```

### Parameters

**learnerId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

### Returns

[Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

### Attributes

* [HttpGetAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.httpgetattribute)

