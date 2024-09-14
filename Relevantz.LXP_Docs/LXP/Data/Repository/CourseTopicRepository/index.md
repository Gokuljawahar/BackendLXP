---
sidebar_label: CourseTopicRepository
---

# CourseTopicRepository Class

[Constructors](#constructors) &#x2022; [Methods](#methods)

**Namespace**: [LXP.Data.Repository](../index.md)

**Assembly**: LXP\.Data\.dll

```csharp
public class CourseTopicRepository : LXP.Data.IRepository.ICourseTopicRepository
```

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; CourseTopicRepository

### Implements

* [ICourseTopicRepository](../../IRepository/ICourseTopicRepository/index.md)

## Constructors

| Constructor | Summary |
| ----------- | ------- |
| [CourseTopicRepository(LXPDbContext, IWebHostEnvironment, IHttpContextAccessor)](-ctor/index.md) | |

## Methods

| Method | Summary |
| ------ | ------- |
| [AddCourseTopic(Topic)](AddCourseTopic/index.md) |  \(Implements [ICourseTopicRepository.AddCourseTopic](../../IRepository/ICourseTopicRepository/AddCourseTopic/index.md)\) |
| [AnyTopicByTopicName(String)](AnyTopicByTopicName/index.md) |  \(Implements [ICourseTopicRepository.AnyTopicByTopicName](../../IRepository/ICourseTopicRepository/AnyTopicByTopicName/index.md)\) |
| [AnyTopicByTopicNameAndCourseId(String, Guid)](AnyTopicByTopicNameAndCourseId/index.md) |  \(Implements [ICourseTopicRepository.AnyTopicByTopicNameAndCourseId](../../IRepository/ICourseTopicRepository/AnyTopicByTopicNameAndCourseId/index.md)\) |
| [Equals(Object)](https://docs.microsoft.com/en-us/dotnet/api/system.object.equals) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetAllTopicDetailsByCourseId(String)](GetAllTopicDetailsByCourseId/index.md) |  \(Implements [ICourseTopicRepository.GetAllTopicDetailsByCourseId](../../IRepository/ICourseTopicRepository/GetAllTopicDetailsByCourseId/index.md)\) |
| [GetAllTopics()](GetAllTopics/index.md) |  \(Implements [ICourseTopicRepository.GetAllTopics](../../IRepository/ICourseTopicRepository/GetAllTopics/index.md)\) |
| [GetHashCode()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetTopicByTopicId(Guid)](GetTopicByTopicId/index.md) |  \(Implements [ICourseTopicRepository.GetTopicByTopicId](../../IRepository/ICourseTopicRepository/GetTopicByTopicId/index.md)\) |
| [GetTopicDetails(String)](GetTopicDetails/index.md) |  \(Implements [ICourseTopicRepository.GetTopicDetails](../../IRepository/ICourseTopicRepository/GetTopicDetails/index.md)\) |
| [GetTopicDetailsByTopicNameAndCourse(String, Guid)](GetTopicDetailsByTopicNameAndCourse/index.md) |  \(Implements [ICourseTopicRepository.GetTopicDetailsByTopicNameAndCourse](../../IRepository/ICourseTopicRepository/GetTopicDetailsByTopicNameAndCourse/index.md)\) |
| [GetTopicsbycouresId(Guid)](GetTopicsbycouresId/index.md) |  \(Implements [ICourseTopicRepository.GetTopicsbycouresId](../../IRepository/ICourseTopicRepository/GetTopicsbycouresId/index.md)\) |
| [GetTopicsbyLearnerId(Guid, Guid)](GetTopicsbyLearnerId/index.md) |  \(Implements [ICourseTopicRepository.GetTopicsbyLearnerId](../../IRepository/ICourseTopicRepository/GetTopicsbyLearnerId/index.md)\) |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [ToString()](https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [UpdateCourseTopic(Topic)](UpdateCourseTopic/index.md) |  \(Implements [ICourseTopicRepository.UpdateCourseTopic](../../IRepository/ICourseTopicRepository/UpdateCourseTopic/index.md)\) |

