---
sidebar_label: GetAllMaterialDetailsByTopicAndMaterialType
---

# MaterialController\.GetAllMaterialDetailsByTopicAndMaterialType\(String, String\) Method

**Containing Type**: [MaterialController](../index.md)

**Assembly**: LXP\.Api\.dll

```csharp
[Microsoft.AspNetCore.Mvc.HttpGet("/lxp/course/topic/{topicId}/materialtype/{materialTypeId}/")]
public System.Threading.Tasks.Task<System.Collections.Generic.List<LXP.Common.ViewModels.MaterialListViewModel>> GetAllMaterialDetailsByTopicAndMaterialType(string topicId, string materialTypeId)
```

### Parameters

**topicId** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

**materialTypeId** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)&lt;[List](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)&lt;[MaterialListViewModel](../../../../Common/ViewModels/MaterialListViewModel/index.md)&gt;&gt;

### Attributes

* [HttpGetAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.httpgetattribute)

