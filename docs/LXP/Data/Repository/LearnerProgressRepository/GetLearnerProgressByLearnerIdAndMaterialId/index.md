---
sidebar_label: GetLearnerProgressByLearnerIdAndMaterialId
---

# LearnerProgressRepository\.GetLearnerProgressByLearnerIdAndMaterialId\(Guid, Guid\) Method

**Containing Type**: [LearnerProgressRepository](../index.md)

**Assembly**: LXP\.Data\.dll

```csharp
public System.Threading.Tasks.Task<LXP.Common.Entities.LearnerProgress> GetLearnerProgressByLearnerIdAndMaterialId(Guid LearnerId, Guid MaterialId)
```

### Parameters

**LearnerId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

**MaterialId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)&lt;[LearnerProgress](../../../../Common/Entities/LearnerProgress/index.md)&gt;

### Implements

* [ILearnerProgressRepository.GetLearnerProgressByLearnerIdAndMaterialId](../../../IRepository/ILearnerProgressRepository/GetLearnerProgressByLearnerIdAndMaterialId/index.md)
