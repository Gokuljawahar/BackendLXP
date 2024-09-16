---
sidebar_label: LearnerProgressService
---

# LearnerProgressService Class

[Constructors](#constructors) &#x2022; [Methods](#methods)

**Namespace**: [LXP.Core.Services](../index.md)

**Assembly**: LXP\.Core\.dll

```csharp
public class LearnerProgressService : LXP.Core.IServices.ILearnerProgressService
```

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; LearnerProgressService

### Implements

* [ILearnerProgressService](../../IServices/ILearnerProgressService/index.md)

## Constructors

| Constructor | Summary |
| ----------- | ------- |
| [LearnerProgressService(ILearnerProgressRepository, IMaterialRepository, ICourseTopicRepository, IEnrollmentRepository, ICourseRepository)](-ctor/index.md) | |

## Methods

| Method | Summary |
| ------ | ------- |
| [CalculateMaterialProgressAsync(Guid, Guid)](CalculateMaterialProgressAsync/index.md) |  \(Implements [ILearnerProgressService.CalculateMaterialProgressAsync](../../IServices/ILearnerProgressService/CalculateMaterialProgressAsync/index.md)\) |
| [CourseTotalTime(Guid)](CourseTotalTime/index.md) |  \(Implements [ILearnerProgressService.CourseTotalTime](../../IServices/ILearnerProgressService/CourseTotalTime/index.md)\) |
| [CourseWatchTime(Guid, Guid)](CourseWatchTime/index.md) |  \(Implements [ILearnerProgressService.CourseWatchTime](../../IServices/ILearnerProgressService/CourseWatchTime/index.md)\) |
| [Equals(Object)](https://docs.microsoft.com/en-us/dotnet/api/system.object.equals) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetCourseCompletionAndCourseIdAsync(Guid, Guid)](GetCourseCompletionAndCourseIdAsync/index.md) |  \(Implements [ILearnerProgressService.GetCourseCompletionAndCourseIdAsync](../../IServices/ILearnerProgressService/GetCourseCompletionAndCourseIdAsync/index.md)\) |
| [GetHashCode()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetLearnerProgressByLearnerIdAndMaterialId(String, String)](GetLearnerProgressByLearnerIdAndMaterialId/index.md) |  \(Implements [ILearnerProgressService.GetLearnerProgressByLearnerIdAndMaterialId](../../IServices/ILearnerProgressService/GetLearnerProgressByLearnerIdAndMaterialId/index.md)\) |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [LearnerProgress(ProgressViewModel)](LearnerProgress/index.md) |  \(Implements [ILearnerProgressService.LearnerProgress](../../IServices/ILearnerProgressService/LearnerProgress/index.md)\) |
| [materialCompletion(Guid, Guid)](materialCompletion/index.md) |  \(Implements [ILearnerProgressService.materialCompletion](../../IServices/ILearnerProgressService/materialCompletion/index.md)\) |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [Progress(LearnerProgressViewModel)](Progress/index.md) |  \(Implements [ILearnerProgressService.Progress](../../IServices/ILearnerProgressService/Progress/index.md)\) |
| [TopicTotalTime(Guid)](TopicTotalTime/index.md) |  \(Implements [ILearnerProgressService.TopicTotalTime](../../IServices/ILearnerProgressService/TopicTotalTime/index.md)\) |
| [TopicWatchTime(Guid, Guid)](TopicWatchTime/index.md) |  \(Implements [ILearnerProgressService.TopicWatchTime](../../IServices/ILearnerProgressService/TopicWatchTime/index.md)\) |
| [ToString()](https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [UpdateProgress(Guid, Guid, TimeOnly)](UpdateProgress/index.md) |  \(Implements [ILearnerProgressService.UpdateProgress](../../IServices/ILearnerProgressService/UpdateProgress/index.md)\) |

