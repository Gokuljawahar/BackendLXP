---
sidebar_label: GetAllMaterialDetailsByTopicAndType
---

# MaterialServices\.GetAllMaterialDetailsByTopicAndType\(String, String\) Method

**Containing Type**: [MaterialServices](../index.md)

**Assembly**: LXP\.Core\.dll

```csharp
public System.Threading.Tasks.Task<System.Collections.Generic.List<LXP.Common.ViewModels.MaterialListViewModel>> GetAllMaterialDetailsByTopicAndType(string topicId, string materialTypeId)
```

### Parameters

**topicId** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

**materialTypeId** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)&lt;[List](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)&lt;[MaterialListViewModel](../../../../Common/ViewModels/MaterialListViewModel/index.md)&gt;&gt;

### Implements

* [IMaterialServices.GetAllMaterialDetailsByTopicAndType](../../../IServices/IMaterialServices/GetAllMaterialDetailsByTopicAndType/index.md)
