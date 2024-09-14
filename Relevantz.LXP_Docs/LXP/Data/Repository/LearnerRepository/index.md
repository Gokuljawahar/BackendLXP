---
sidebar_label: LearnerRepository
---

# LearnerRepository Class

[Constructors](#constructors) &#x2022; [Methods](#methods)

**Namespace**: [LXP.Data.Repository](../index.md)

**Assembly**: LXP\.Data\.dll

```csharp
public class LearnerRepository : LXP.Data.IRepository.ILearnerRepository
```

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; LearnerRepository

### Implements

* [ILearnerRepository](../../IRepository/ILearnerRepository/index.md)

## Constructors

| Constructor | Summary |
| ----------- | ------- |
| [LearnerRepository(LXPDbContext, IWebHostEnvironment, IHttpContextAccessor)](-ctor/index.md) | |

## Methods

| Method | Summary |
| ------ | ------- |
| [AddLearner(Learner)](AddLearner/index.md) |  \(Implements [ILearnerRepository.AddLearner](../../IRepository/ILearnerRepository/AddLearner/index.md)\) |
| [AnyLearnerByEmail(String)](AnyLearnerByEmail/index.md) |  \(Implements [ILearnerRepository.AnyLearnerByEmail](../../IRepository/ILearnerRepository/AnyLearnerByEmail/index.md)\) |
| [BeginTransaction()](BeginTransaction/index.md) |  \(Implements [ILearnerRepository.BeginTransaction](../../IRepository/ILearnerRepository/BeginTransaction/index.md)\) |
| [Equals(Object)](https://docs.microsoft.com/en-us/dotnet/api/system.object.equals) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetAllLearner()](GetAllLearner/index.md) |  \(Implements [ILearnerRepository.GetAllLearner](../../IRepository/ILearnerRepository/GetAllLearner/index.md)\) |
| [GetAllLearnerDetailsByLearnerId(Guid)](GetAllLearnerDetailsByLearnerId/index.md) |  \(Implements [ILearnerRepository.GetAllLearnerDetailsByLearnerId](../../IRepository/ILearnerRepository/GetAllLearnerDetailsByLearnerId/index.md)\) |
| [GetHashCode()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetLearnerByLearnerEmail(String)](GetLearnerByLearnerEmail/index.md) |  \(Implements [ILearnerRepository.GetLearnerByLearnerEmail](../../IRepository/ILearnerRepository/GetLearnerByLearnerEmail/index.md)\) |
| [GetLearnerDetailsByLearnerId(Guid)](GetLearnerDetailsByLearnerId/index.md) |  \(Implements [ILearnerRepository.GetLearnerDetailsByLearnerId](../../IRepository/ILearnerRepository/GetLearnerDetailsByLearnerId/index.md)\) |
| [GetLearnerEnrolledcourseByLearnerId(Guid)](GetLearnerEnrolledcourseByLearnerId/index.md) |  \(Implements [ILearnerRepository.GetLearnerEnrolledcourseByLearnerId](../../IRepository/ILearnerRepository/GetLearnerEnrolledcourseByLearnerId/index.md)\) |
| [GetLearners()](GetLearners/index.md) |  \(Implements [ILearnerRepository.GetLearners](../../IRepository/ILearnerRepository/GetLearners/index.md)\) |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [ToString()](https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [UpdateLearner(Learner)](UpdateLearner/index.md) |  \(Implements [ILearnerRepository.UpdateLearner](../../IRepository/ILearnerRepository/UpdateLearner/index.md)\) |

