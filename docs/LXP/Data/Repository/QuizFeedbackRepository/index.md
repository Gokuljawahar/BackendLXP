---
sidebar_label: QuizFeedbackRepository
---

# QuizFeedbackRepository Class

[Constructors](#constructors) &#x2022; [Methods](#methods)

**Namespace**: [LXP.Data.Repository](../index.md)

**Assembly**: LXP\.Data\.dll

```csharp
public class QuizFeedbackRepository : LXP.Data.IRepository.IQuizFeedbackRepository
```

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; QuizFeedbackRepository

### Implements

* [IQuizFeedbackRepository](../../IRepository/IQuizFeedbackRepository/index.md)

## Constructors

| Constructor | Summary |
| ----------- | ------- |
| [QuizFeedbackRepository(LXPDbContext)](-ctor/index.md) | |

## Methods

| Method | Summary |
| ------ | ------- |
| [AddFeedbackQuestion(QuizFeedbackQuestion)](AddFeedbackQuestion/index.md) |  \(Implements [IQuizFeedbackRepository.AddFeedbackQuestion](../../IRepository/IQuizFeedbackRepository/AddFeedbackQuestion/index.md)\) |
| [AddFeedbackQuestionOptions(List&lt;FeedbackQuestionsOption&gt;)](AddFeedbackQuestionOptions/index.md) |  \(Implements [IQuizFeedbackRepository.AddFeedbackQuestionOptions](../../IRepository/IQuizFeedbackRepository/AddFeedbackQuestionOptions/index.md)\) |
| [DeleteFeedbackQuestion(QuizFeedbackQuestion)](DeleteFeedbackQuestion/index.md) |  \(Implements [IQuizFeedbackRepository.DeleteFeedbackQuestion](../../IRepository/IQuizFeedbackRepository/DeleteFeedbackQuestion/index.md)\) |
| [DeleteFeedbackQuestionOptions(List&lt;FeedbackQuestionsOption&gt;)](DeleteFeedbackQuestionOptions/index.md) |  \(Implements [IQuizFeedbackRepository.DeleteFeedbackQuestionOptions](../../IRepository/IQuizFeedbackRepository/DeleteFeedbackQuestionOptions/index.md)\) |
| [DeleteFeedbackResponses(List&lt;FeedbackResponse&gt;)](DeleteFeedbackResponses/index.md) |  \(Implements [IQuizFeedbackRepository.DeleteFeedbackResponses](../../IRepository/IQuizFeedbackRepository/DeleteFeedbackResponses/index.md)\) |
| [Equals(Object)](https://docs.microsoft.com/en-us/dotnet/api/system.object.equals) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetAllFeedbackQuestions()](GetAllFeedbackQuestions/index.md) |  \(Implements [IQuizFeedbackRepository.GetAllFeedbackQuestions](../../IRepository/IQuizFeedbackRepository/GetAllFeedbackQuestions/index.md)\) |
| [GetFeedbackQuestionEntityById(Guid)](GetFeedbackQuestionEntityById/index.md) |  \(Implements [IQuizFeedbackRepository.GetFeedbackQuestionEntityById](../../IRepository/IQuizFeedbackRepository/GetFeedbackQuestionEntityById/index.md)\) |
| [GetFeedbackQuestionOptions(Guid)](GetFeedbackQuestionOptions/index.md) |  \(Implements [IQuizFeedbackRepository.GetFeedbackQuestionOptions](../../IRepository/IQuizFeedbackRepository/GetFeedbackQuestionOptions/index.md)\) |
| [GetFeedbackQuestionsByQuizId(Guid)](GetFeedbackQuestionsByQuizId/index.md) |  \(Implements [IQuizFeedbackRepository.GetFeedbackQuestionsByQuizId](../../IRepository/IQuizFeedbackRepository/GetFeedbackQuestionsByQuizId/index.md)\) |
| [GetFeedbackResponsesByQuestionId(Guid)](GetFeedbackResponsesByQuestionId/index.md) |  \(Implements [IQuizFeedbackRepository.GetFeedbackResponsesByQuestionId](../../IRepository/IQuizFeedbackRepository/GetFeedbackResponsesByQuestionId/index.md)\) |
| [GetHashCode()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetNextFeedbackQuestionNo(Guid)](GetNextFeedbackQuestionNo/index.md) |  \(Implements [IQuizFeedbackRepository.GetNextFeedbackQuestionNo](../../IRepository/IQuizFeedbackRepository/GetNextFeedbackQuestionNo/index.md)\) |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [ToString()](https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [UpdateFeedbackQuestion(QuizFeedbackQuestion)](UpdateFeedbackQuestion/index.md) |  \(Implements [IQuizFeedbackRepository.UpdateFeedbackQuestion](../../IRepository/IQuizFeedbackRepository/UpdateFeedbackQuestion/index.md)\) |

