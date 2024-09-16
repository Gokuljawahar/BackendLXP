---
sidebar_label: GetMaterialByTopic
---

# LearnerProgressRepository\.GetMaterialByTopic\(Guid, Guid\) Method

**Containing Type**: [LearnerProgressRepository](../index.md)

**Assembly**: LXP\.Data\.dll

```csharp
public System.Threading.Tasks.Task<System.Collections.Generic.List<LXP.Common.Entities.LearnerProgress>> GetMaterialByTopic(Guid topicId, Guid learnerId)
```

### Parameters

**topicId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

**learnerId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)&lt;[List](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)&lt;[LearnerProgress](../../../../Common/Entities/LearnerProgress/index.md)&gt;&gt;

### Implements

* [ILearnerProgressRepository.GetMaterialByTopic](../../../IRepository/ILearnerProgressRepository/GetMaterialByTopic/index.md)
