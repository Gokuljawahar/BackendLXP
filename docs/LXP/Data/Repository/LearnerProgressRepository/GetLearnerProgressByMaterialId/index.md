---
sidebar_label: GetLearnerProgressByMaterialId
---

# LearnerProgressRepository\.GetLearnerProgressByMaterialId\(Guid, Guid\) Method

**Containing Type**: [LearnerProgressRepository](../index.md)

**Assembly**: LXP\.Data\.dll

```csharp
public System.Threading.Tasks.Task<LXP.Common.Entities.LearnerProgress> GetLearnerProgressByMaterialId(Guid learnerId, Guid materialId)
```

### Parameters

**learnerId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

**materialId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)&lt;[LearnerProgress](../../../../Common/Entities/LearnerProgress/index.md)&gt;

### Implements

* [ILearnerProgressRepository.GetLearnerProgressByMaterialId](../../../IRepository/ILearnerProgressRepository/GetLearnerProgressByMaterialId/index.md)
