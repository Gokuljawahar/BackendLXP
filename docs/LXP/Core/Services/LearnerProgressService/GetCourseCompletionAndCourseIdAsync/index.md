---
sidebar_label: GetCourseCompletionAndCourseIdAsync
---

# LearnerProgressService\.GetCourseCompletionAndCourseIdAsync\(Guid, Guid\) Method

**Containing Type**: [LearnerProgressService](../index.md)

**Assembly**: LXP\.Core\.dll

```csharp
public System.Threading.Tasks.Task<(decimal? CourseCompletionPercentage, Guid? CourseId)> GetCourseCompletionAndCourseIdAsync(Guid learnerId, Guid enrollmentId)
```

### Parameters

**learnerId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

**enrollmentId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)&lt;\([Decimal](https://docs.microsoft.com/en-us/dotnet/api/system.decimal)? CourseCompletionPercentage, [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)? CourseId\)&gt;

### Implements

* [ILearnerProgressService.GetCourseCompletionAndCourseIdAsync](../../../IServices/ILearnerProgressService/GetCourseCompletionAndCourseIdAsync/index.md)
