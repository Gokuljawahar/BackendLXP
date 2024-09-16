---
sidebar_label: LearnerProgressRepository
---

# LearnerProgressRepository Class

[Constructors](#constructors) &#x2022; [Methods](#methods)

**Namespace**: [LXP.Data.Repository](../index.md)

**Assembly**: LXP\.Data\.dll

```csharp
public class LearnerProgressRepository : LXP.Data.IRepository.ILearnerProgressRepository
```

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; LearnerProgressRepository

### Implements

* [ILearnerProgressRepository](../../IRepository/ILearnerProgressRepository/index.md)

## Constructors

| Constructor | Summary |
| ----------- | ------- |
| [LearnerProgressRepository(LXPDbContext)](-ctor/index.md) | |

## Methods

| Method | Summary |
| ------ | ------- |
| [AnyLearnerProgressByLearnerIdAndMaterialId(Guid, Guid)](AnyLearnerProgressByLearnerIdAndMaterialId/index.md) |  \(Implements [ILearnerProgressRepository.AnyLearnerProgressByLearnerIdAndMaterialId](../../IRepository/ILearnerProgressRepository/AnyLearnerProgressByLearnerIdAndMaterialId/index.md)\) |
| [CalculateAndUpdateCourseCompletionAsync(Guid)](CalculateAndUpdateCourseCompletionAsync/index.md) |  \(Implements [ILearnerProgressRepository.CalculateAndUpdateCourseCompletionAsync](../../IRepository/ILearnerProgressRepository/CalculateAndUpdateCourseCompletionAsync/index.md)\) |
| [Changewatchtime(LearnerProgress)](Changewatchtime/index.md) |  \(Implements [ILearnerProgressRepository.Changewatchtime](../../IRepository/ILearnerProgressRepository/Changewatchtime/index.md)\) |
| [Equals(Object)](https://docs.microsoft.com/en-us/dotnet/api/system.object.equals) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetEnrollmentByIdAsync(Guid, Guid)](GetEnrollmentByIdAsync/index.md) |  \(Implements [ILearnerProgressRepository.GetEnrollmentByIdAsync](../../IRepository/ILearnerProgressRepository/GetEnrollmentByIdAsync/index.md)\) |
| [GetHashCode()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetLearnerMaterialProgressAsync(Guid, Guid)](GetLearnerMaterialProgressAsync/index.md) |  \(Implements [ILearnerProgressRepository.GetLearnerMaterialProgressAsync](../../IRepository/ILearnerProgressRepository/GetLearnerMaterialProgressAsync/index.md)\) |
| [GetLearnerProgressById(Guid, Guid)](GetLearnerProgressById/index.md) |  \(Implements [ILearnerProgressRepository.GetLearnerProgressById](../../IRepository/ILearnerProgressRepository/GetLearnerProgressById/index.md)\) |
| [GetLearnerProgressByLearnerIdAndMaterialId(Guid, Guid)](GetLearnerProgressByLearnerIdAndMaterialId/index.md) |  \(Implements [ILearnerProgressRepository.GetLearnerProgressByLearnerIdAndMaterialId](../../IRepository/ILearnerProgressRepository/GetLearnerProgressByLearnerIdAndMaterialId/index.md)\) |
| [GetLearnerProgressByMaterialId(Guid, Guid)](GetLearnerProgressByMaterialId/index.md) |  \(Implements [ILearnerProgressRepository.GetLearnerProgressByMaterialId](../../IRepository/ILearnerProgressRepository/GetLearnerProgressByMaterialId/index.md)\) |
| [GetMaterialByTopic(Guid, Guid)](GetMaterialByTopic/index.md) |  \(Implements [ILearnerProgressRepository.GetMaterialByTopic](../../IRepository/ILearnerProgressRepository/GetMaterialByTopic/index.md)\) |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [LearnerProgress(LearnerProgress)](LearnerProgress/index.md) |  \(Implements [ILearnerProgressRepository.LearnerProgress](../../IRepository/ILearnerProgressRepository/LearnerProgress/index.md)\) |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [ToString()](https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [UpdateLearnerProgress(LearnerProgress)](UpdateLearnerProgress/index.md) |  \(Implements [ILearnerProgressRepository.UpdateLearnerProgress](../../IRepository/ILearnerProgressRepository/UpdateLearnerProgress/index.md)\) |

