---
sidebar_label: EnrollmentService
---

# EnrollmentService Class

[Constructors](#constructors) &#x2022; [Methods](#methods)

**Namespace**: [LXP.Core.Services](../index.md)

**Assembly**: LXP\.Core\.dll

```csharp
public class EnrollmentService : LXP.Core.IServices.IEnrollmentService
```

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; EnrollmentService

### Implements

* [IEnrollmentService](../../IServices/IEnrollmentService/index.md)

## Constructors

| Constructor | Summary |
| ----------- | ------- |
| [EnrollmentService(IEnrollmentRepository, ILearnerRepository, ICourseRepository, IWebHostEnvironment, IHttpContextAccessor)](-ctor/index.md) | |

## Methods

| Method | Summary |
| ------ | ------- |
| [Addenroll(EnrollmentViewModel)](Addenroll/index.md) |  \(Implements [IEnrollmentService.Addenroll](../../IServices/IEnrollmentService/Addenroll/index.md)\) |
| [DeleteEnrollment(Guid)](DeleteEnrollment/index.md) |  \(Implements [IEnrollmentService.DeleteEnrollment](../../IServices/IEnrollmentService/DeleteEnrollment/index.md)\) |
| [Equals(Object)](https://docs.microsoft.com/en-us/dotnet/api/system.object.equals) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetCourseandTopicsByCourseId(Guid, Guid)](GetCourseandTopicsByCourseId/index.md) |  \(Implements [IEnrollmentService.GetCourseandTopicsByCourseId](../../IServices/IEnrollmentService/GetCourseandTopicsByCourseId/index.md)\) |
| [GetCourseandTopicsByLearnerId(Guid)](GetCourseandTopicsByLearnerId/index.md) |  \(Implements [IEnrollmentService.GetCourseandTopicsByLearnerId](../../IServices/IEnrollmentService/GetCourseandTopicsByLearnerId/index.md)\) |
| [GetEnrolledCompletedLearnerbyCourseId(Guid)](GetEnrolledCompletedLearnerbyCourseId/index.md) |  \(Implements [IEnrollmentService.GetEnrolledCompletedLearnerbyCourseId](../../IServices/IEnrollmentService/GetEnrolledCompletedLearnerbyCourseId/index.md)\) |
| [GetEnrolledInprogressLearnerbyCourseId(Guid)](GetEnrolledInprogressLearnerbyCourseId/index.md) |  \(Implements [IEnrollmentService.GetEnrolledInprogressLearnerbyCourseId](../../IServices/IEnrollmentService/GetEnrolledInprogressLearnerbyCourseId/index.md)\) |
| [GetEnrolledUsers(Guid)](GetEnrolledUsers/index.md) |  \(Implements [IEnrollmentService.GetEnrolledUsers](../../IServices/IEnrollmentService/GetEnrolledUsers/index.md)\) |
| [GetEnrollmentsReport()](GetEnrollmentsReport/index.md) |  \(Implements [IEnrollmentService.GetEnrollmentsReport](../../IServices/IEnrollmentService/GetEnrollmentsReport/index.md)\) |
| [GetHashCode()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [ToString()](https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [UpdateCourseStarted(Guid)](UpdateCourseStarted/index.md) |  \(Implements [IEnrollmentService.UpdateCourseStarted](../../IServices/IEnrollmentService/UpdateCourseStarted/index.md)\) |

