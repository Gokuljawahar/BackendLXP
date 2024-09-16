---
sidebar_label: GetCourseCompletionAndCourseIdAsync
---

# ILearnerProgressService\.GetCourseCompletionAndCourseIdAsync\(Guid, Guid\) Method

**Containing Type**: [ILearnerProgressService](../index.md)

**Assembly**: LXP\.Core\.dll

```csharp
System.Threading.Tasks.Task<(decimal? CourseCompletionPercentage, Guid? CourseId)> GetCourseCompletionAndCourseIdAsync(Guid learnerId, Guid enrollmentId)
```

### Parameters

**learnerId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

**enrollmentId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)&lt;\([Decimal](https://docs.microsoft.com/en-us/dotnet/api/system.decimal)? CourseCompletionPercentage, [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)? CourseId\)&gt;

