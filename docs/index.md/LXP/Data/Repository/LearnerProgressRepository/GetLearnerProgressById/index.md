---
sidebar_label: GetLearnerProgressById
---

# LearnerProgressRepository\.GetLearnerProgressById\(Guid, Guid\) Method

**Containing Type**: [LearnerProgressRepository](../index.md)

**Assembly**: LXP\.Data\.dll

```csharp
public System.Threading.Tasks.Task<LXP.Common.Entities.LearnerProgress> GetLearnerProgressById(Guid learnerId, Guid courseId)
```

### Parameters

**learnerId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

**courseId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)&lt;[LearnerProgress](../../../../Common/Entities/LearnerProgress/index.md)&gt;

### Implements

* [ILearnerProgressRepository.GetLearnerProgressById](../../../IRepository/ILearnerProgressRepository/GetLearnerProgressById/index.md)
