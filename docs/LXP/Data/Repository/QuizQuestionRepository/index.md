---
sidebar_label: QuizQuestionRepository
---

# QuizQuestionRepository Class

[Constructors](#constructors) &#x2022; [Methods](#methods)

**Namespace**: [LXP.Data.Repository](../index.md)

**Assembly**: LXP\.Data\.dll

```csharp
public class QuizQuestionRepository : LXP.Data.IRepository.IQuizQuestionRepository
```

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; QuizQuestionRepository

### Implements

* [IQuizQuestionRepository](../../IRepository/IQuizQuestionRepository/index.md)

## Constructors

| Constructor | Summary |
| ----------- | ------- |
| [QuizQuestionRepository(LXPDbContext)](-ctor/index.md) | |

## Methods

| Method | Summary |
| ------ | ------- |
| [AddQuestionAsync(QuizQuestionViewModel, List&lt;QuestionOptionViewModel&gt;)](AddQuestionAsync/index.md) |  \(Implements [IQuizQuestionRepository.AddQuestionAsync](../../IRepository/IQuizQuestionRepository/AddQuestionAsync/index.md)\) |
| [DeleteQuestionAsync(Guid)](DeleteQuestionAsync/index.md) |  \(Implements [IQuizQuestionRepository.DeleteQuestionAsync](../../IRepository/IQuizQuestionRepository/DeleteQuestionAsync/index.md)\) |
| [Equals(Object)](https://docs.microsoft.com/en-us/dotnet/api/system.object.equals) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetAllQuestionsAsync()](GetAllQuestionsAsync/index.md) |  \(Implements [IQuizQuestionRepository.GetAllQuestionsAsync](../../IRepository/IQuizQuestionRepository/GetAllQuestionsAsync/index.md)\) |
| [GetAllQuestionsByQuizIdAsync(Guid)](GetAllQuestionsByQuizIdAsync/index.md) |  \(Implements [IQuizQuestionRepository.GetAllQuestionsByQuizIdAsync](../../IRepository/IQuizQuestionRepository/GetAllQuestionsByQuizIdAsync/index.md)\) |
| [GetHashCode()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetNextQuestionNoAsync(Guid)](GetNextQuestionNoAsync/index.md) |  \(Implements [IQuizQuestionRepository.GetNextQuestionNoAsync](../../IRepository/IQuizQuestionRepository/GetNextQuestionNoAsync/index.md)\) |
| [GetQuestionByIdAsync(Guid)](GetQuestionByIdAsync/index.md) |  \(Implements [IQuizQuestionRepository.GetQuestionByIdAsync](../../IRepository/IQuizQuestionRepository/GetQuestionByIdAsync/index.md)\) |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [ReorderQuestionNos(Guid, Int32)](ReorderQuestionNos/index.md) |  \(Implements [IQuizQuestionRepository.ReorderQuestionNos](../../IRepository/IQuizQuestionRepository/ReorderQuestionNos/index.md)\) |
| [ToString()](https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [UpdateQuestionAsync(Guid, QuizQuestionViewModel, List&lt;QuestionOptionViewModel&gt;)](UpdateQuestionAsync/index.md) |  \(Implements [IQuizQuestionRepository.UpdateQuestionAsync](../../IRepository/IQuizQuestionRepository/UpdateQuestionAsync/index.md)\) |

