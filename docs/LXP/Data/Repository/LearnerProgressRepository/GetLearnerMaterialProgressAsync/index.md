---
sidebar_label: GetLearnerMaterialProgressAsync
---

# LearnerProgressRepository\.GetLearnerMaterialProgressAsync\(Guid, Guid\) Method

**Containing Type**: [LearnerProgressRepository](../index.md)

**Assembly**: LXP\.Data\.dll

```csharp
public System.Threading.Tasks.Task<LXP.Common.Entities.LearnerProgress> GetLearnerMaterialProgressAsync(Guid materialId, Guid learnerId)
```

### Parameters

**materialId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

**learnerId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)&lt;[LearnerProgress](../../../../Common/Entities/LearnerProgress/index.md)&gt;

### Implements

* [ILearnerProgressRepository.GetLearnerMaterialProgressAsync](../../../IRepository/ILearnerProgressRepository/GetLearnerMaterialProgressAsync/index.md)
