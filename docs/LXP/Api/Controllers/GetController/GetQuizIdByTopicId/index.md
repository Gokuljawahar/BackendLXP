---
sidebar_label: GetQuizIdByTopicId
---

# GetController\.GetQuizIdByTopicId\(Guid\) Method

**Containing Type**: [GetController](../index.md)

**Assembly**: LXP\.Api\.dll

```csharp
[Microsoft.AspNetCore.Mvc.HttpGet("topic/{topicId}")]
public Microsoft.AspNetCore.Mvc.ActionResult<Guid?> GetQuizIdByTopicId(Guid topicId)
```

### Parameters

**topicId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

### Returns

[ActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.actionresult-1)&lt;[Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)?&gt;

### Attributes

* [HttpGetAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.httpgetattribute)

