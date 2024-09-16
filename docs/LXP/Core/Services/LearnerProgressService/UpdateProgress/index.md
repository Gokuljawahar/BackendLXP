---
sidebar_label: UpdateProgress
---

# LearnerProgressService\.UpdateProgress\(Guid, Guid, TimeOnly\) Method

**Containing Type**: [LearnerProgressService](../index.md)

**Assembly**: LXP\.Core\.dll

```csharp
public System.Threading.Tasks.Task<bool> UpdateProgress(Guid learnerId, Guid materialId, TimeOnly watchtime)
```

### Parameters

**learnerId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

**materialId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

**watchtime** &ensp; [TimeOnly](https://docs.microsoft.com/en-us/dotnet/api/system.timeonly)

### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)&lt;[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)&gt;

### Implements

* [ILearnerProgressService.UpdateProgress](../../../IServices/ILearnerProgressService/UpdateProgress/index.md)
