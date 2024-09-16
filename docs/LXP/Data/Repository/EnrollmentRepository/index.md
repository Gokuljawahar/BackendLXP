---
sidebar_label: EnrollmentRepository
---

# EnrollmentRepository Class

[Constructors](#constructors) &#x2022; [Methods](#methods)

**Namespace**: [LXP.Data.Repository](../index.md)

**Assembly**: LXP\.Data\.dll

```csharp
public class EnrollmentRepository : LXP.Data.IRepository.IEnrollmentRepository
```

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; EnrollmentRepository

### Implements

* [IEnrollmentRepository](../../IRepository/IEnrollmentRepository/index.md)

## Constructors

| Constructor | Summary |
| ----------- | ------- |
| [EnrollmentRepository(LXPDbContext, IWebHostEnvironment, IHttpContextAccessor)](-ctor/index.md) | |

## Methods

| Method | Summary |
| ------ | ------- |
| [Addenroll(Enrollment)](Addenroll/index.md) |  \(Implements [IEnrollmentRepository.Addenroll](../../IRepository/IEnrollmentRepository/Addenroll/index.md)\) |
| [AnyEnrollmentByLearnerAndCourse(Guid, Guid)](AnyEnrollmentByLearnerAndCourse/index.md) |  \(Implements [IEnrollmentRepository.AnyEnrollmentByLearnerAndCourse](../../IRepository/IEnrollmentRepository/AnyEnrollmentByLearnerAndCourse/index.md)\) |
| [DeleteEnrollment(Enrollment)](DeleteEnrollment/index.md) |  \(Implements [IEnrollmentRepository.DeleteEnrollment](../../IRepository/IEnrollmentRepository/DeleteEnrollment/index.md)\) |
| [Equals(Object)](https://docs.microsoft.com/en-us/dotnet/api/system.object.equals) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [FindEnrollmentId(Guid)](FindEnrollmentId/index.md) |  \(Implements [IEnrollmentRepository.FindEnrollmentId](../../IRepository/IEnrollmentRepository/FindEnrollmentId/index.md)\) |
| [GetCourseandTopicsByCourseIdAndLearnerId(Guid, Guid)](GetCourseandTopicsByCourseIdAndLearnerId/index.md) |  \(Implements [IEnrollmentRepository.GetCourseandTopicsByCourseIdAndLearnerId](../../IRepository/IEnrollmentRepository/GetCourseandTopicsByCourseIdAndLearnerId/index.md)\) |
| [GetCourseandTopicsByLearnerId(Guid)](GetCourseandTopicsByLearnerId/index.md) |  \(Implements [IEnrollmentRepository.GetCourseandTopicsByLearnerId](../../IRepository/IEnrollmentRepository/GetCourseandTopicsByLearnerId/index.md)\) |
| [GetEnrolledCompletedLearnerbyCourseId(Guid)](GetEnrolledCompletedLearnerbyCourseId/index.md) |  \(Implements [IEnrollmentRepository.GetEnrolledCompletedLearnerbyCourseId](../../IRepository/IEnrollmentRepository/GetEnrolledCompletedLearnerbyCourseId/index.md)\) |
| [GetEnrolledInprogressLearnerbyCourseId(Guid)](GetEnrolledInprogressLearnerbyCourseId/index.md) |  \(Implements [IEnrollmentRepository.GetEnrolledInprogressLearnerbyCourseId](../../IRepository/IEnrollmentRepository/GetEnrolledInprogressLearnerbyCourseId/index.md)\) |
| [GetEnrolledUser(Guid)](GetEnrolledUser/index.md) |  \(Implements [IEnrollmentRepository.GetEnrolledUser](../../IRepository/IEnrollmentRepository/GetEnrolledUser/index.md)\) |
| [GetEnrollmentReport()](GetEnrollmentReport/index.md) |  \(Implements [IEnrollmentRepository.GetEnrollmentReport](../../IRepository/IEnrollmentRepository/GetEnrollmentReport/index.md)\) |
| [GetHashCode()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [ToString()](https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [UpdateCourseStarted(Enrollment)](UpdateCourseStarted/index.md) |  \(Implements [IEnrollmentRepository.UpdateCourseStarted](../../IRepository/IEnrollmentRepository/UpdateCourseStarted/index.md)\) |

