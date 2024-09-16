---
sidebar_label: GetEnrollmentByIdAsync
---

# LearnerProgressRepository\.GetEnrollmentByIdAsync\(Guid, Guid\) Method

**Containing Type**: [LearnerProgressRepository](../index.md)

**Assembly**: LXP\.Data\.dll

```csharp
public System.Threading.Tasks.Task<LXP.Common.Entities.Enrollment> GetEnrollmentByIdAsync(Guid learnerId, Guid enrollmentId)
```

### Parameters

**learnerId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

**enrollmentId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)&lt;[Enrollment](../../../../Common/Entities/Enrollment/index.md)&gt;

### Implements

* [ILearnerProgressRepository.GetEnrollmentByIdAsync](../../../IRepository/ILearnerProgressRepository/GetEnrollmentByIdAsync/index.md)
