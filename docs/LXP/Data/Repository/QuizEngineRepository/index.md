---
sidebar_label: QuizEngineRepository
---

# QuizEngineRepository Class

[Constructors](#constructors) &#x2022; [Methods](#methods)

**Namespace**: [LXP.Data.Repository](../index.md)

**Assembly**: LXP\.Data\.dll

```csharp
public class QuizEngineRepository : LXP.Data.IRepository.IQuizEngineRepository
```

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; QuizEngineRepository

### Implements

* [IQuizEngineRepository](../../IRepository/IQuizEngineRepository/index.md)

## Constructors

| Constructor | Summary |
| ----------- | ------- |
| [QuizEngineRepository(LXPDbContext)](-ctor/index.md) | |

## Methods

| Method | Summary |
| ------ | ------- |
| [ClearLearnerAnswersAsync(Guid, Guid)](ClearLearnerAnswersAsync/index.md) |  \(Implements [IQuizEngineRepository.ClearLearnerAnswersAsync](../../IRepository/IQuizEngineRepository/ClearLearnerAnswersAsync/index.md)\) |
| [CreateLearnerAnswerAsync(Guid, Guid, Guid)](CreateLearnerAnswerAsync/index.md) |  \(Implements [IQuizEngineRepository.CreateLearnerAnswerAsync](../../IRepository/IQuizEngineRepository/CreateLearnerAnswerAsync/index.md)\) |
| [CreateLearnerAttemptAsync(Guid, Guid, DateTime)](CreateLearnerAttemptAsync/index.md) |  \(Implements [IQuizEngineRepository.CreateLearnerAttemptAsync](../../IRepository/IQuizEngineRepository/CreateLearnerAttemptAsync/index.md)\) |
| [Equals(Object)](https://docs.microsoft.com/en-us/dotnet/api/system.object.equals) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetCorrectOptionsForQuestionAsync(Guid)](GetCorrectOptionsForQuestionAsync/index.md) |  \(Implements [IQuizEngineRepository.GetCorrectOptionsForQuestionAsync](../../IRepository/IQuizEngineRepository/GetCorrectOptionsForQuestionAsync/index.md)\) |
| [GetHashCode()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetLearnerAnswersByAttemptAndQuestionAsync(Guid, Guid)](GetLearnerAnswersByAttemptAndQuestionAsync/index.md) |  \(Implements [IQuizEngineRepository.GetLearnerAnswersByAttemptAndQuestionAsync](../../IRepository/IQuizEngineRepository/GetLearnerAnswersByAttemptAndQuestionAsync/index.md)\) |
| [GetLearnerAnswersForAttemptAsync(Guid)](GetLearnerAnswersForAttemptAsync/index.md) |  \(Implements [IQuizEngineRepository.GetLearnerAnswersForAttemptAsync](../../IRepository/IQuizEngineRepository/GetLearnerAnswersForAttemptAsync/index.md)\) |
| [GetLearnerAttemptByIdAsync(Guid)](GetLearnerAttemptByIdAsync/index.md) |  \(Implements [IQuizEngineRepository.GetLearnerAttemptByIdAsync](../../IRepository/IQuizEngineRepository/GetLearnerAttemptByIdAsync/index.md)\) |
| [GetLearnerAttemptsForQuizAsync(Guid, Guid)](GetLearnerAttemptsForQuizAsync/index.md) |  \(Implements [IQuizEngineRepository.GetLearnerAttemptsForQuizAsync](../../IRepository/IQuizEngineRepository/GetLearnerAttemptsForQuizAsync/index.md)\) |
| [GetLearnerQuizAttemptAsync(Guid)](GetLearnerQuizAttemptAsync/index.md) |  \(Implements [IQuizEngineRepository.GetLearnerQuizAttemptAsync](../../IRepository/IQuizEngineRepository/GetLearnerQuizAttemptAsync/index.md)\) |
| [GetLearnerQuizAttemptResultAsync(Guid)](GetLearnerQuizAttemptResultAsync/index.md) |  \(Implements [IQuizEngineRepository.GetLearnerQuizAttemptResultAsync](../../IRepository/IQuizEngineRepository/GetLearnerQuizAttemptResultAsync/index.md)\) |
| [GetLearnerQuizStatusAsync(Guid, Guid)](GetLearnerQuizStatusAsync/index.md) |  \(Implements [IQuizEngineRepository.GetLearnerQuizStatusAsync](../../IRepository/IQuizEngineRepository/GetLearnerQuizStatusAsync/index.md)\) |
| [GetOptionIdByTextAsync(Guid, String)](GetOptionIdByTextAsync/index.md) |  \(Implements [IQuizEngineRepository.GetOptionIdByTextAsync](../../IRepository/IQuizEngineRepository/GetOptionIdByTextAsync/index.md)\) |
| [GetOptionTextByIdAsync(Guid)](GetOptionTextByIdAsync/index.md) |  \(Implements [IQuizEngineRepository.GetOptionTextByIdAsync](../../IRepository/IQuizEngineRepository/GetOptionTextByIdAsync/index.md)\) |
| [GetQuestionOptionsAsync(Guid)](GetQuestionOptionsAsync/index.md) |  \(Implements [IQuizEngineRepository.GetQuestionOptionsAsync](../../IRepository/IQuizEngineRepository/GetQuestionOptionsAsync/index.md)\) |
| [GetQuestionsForQuizAsync(Guid)](GetQuestionsForQuizAsync/index.md) |  \(Implements [IQuizEngineRepository.GetQuestionsForQuizAsync](../../IRepository/IQuizEngineRepository/GetQuestionsForQuizAsync/index.md)\) |
| [GetQuestionTypeByIdAsync(Guid)](GetQuestionTypeByIdAsync/index.md) |  \(Implements [IQuizEngineRepository.GetQuestionTypeByIdAsync](../../IRepository/IQuizEngineRepository/GetQuestionTypeByIdAsync/index.md)\) |
| [GetQuizByIdAsync(Guid)](GetQuizByIdAsync/index.md) |  \(Implements [IQuizEngineRepository.GetQuizByIdAsync](../../IRepository/IQuizEngineRepository/GetQuizByIdAsync/index.md)\) |
| [GetQuizDetailsByTopicIdAsync(Guid)](GetQuizDetailsByTopicIdAsync/index.md) |  \(Implements [IQuizEngineRepository.GetQuizDetailsByTopicIdAsync](../../IRepository/IQuizEngineRepository/GetQuizDetailsByTopicIdAsync/index.md)\) |
| [GetQuizQuestionByIdAsync(Guid)](GetQuizQuestionByIdAsync/index.md) |  \(Implements [IQuizEngineRepository.GetQuizQuestionByIdAsync](../../IRepository/IQuizEngineRepository/GetQuizQuestionByIdAsync/index.md)\) |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [IsAllowedToAttemptQuizAsync(Guid, Guid)](IsAllowedToAttemptQuizAsync/index.md) |  \(Implements [IQuizEngineRepository.IsAllowedToAttemptQuizAsync](../../IRepository/IQuizEngineRepository/IsAllowedToAttemptQuizAsync/index.md)\) |
| [IsQuestionOptionCorrectAsync(Guid, Guid)](IsQuestionOptionCorrectAsync/index.md) |  \(Implements [IQuizEngineRepository.IsQuestionOptionCorrectAsync](../../IRepository/IQuizEngineRepository/IsQuestionOptionCorrectAsync/index.md)\) |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [SaveLearnerAnswerAsync(LearnerAnswerViewModel)](SaveLearnerAnswerAsync/index.md) |  \(Implements [IQuizEngineRepository.SaveLearnerAnswerAsync](../../IRepository/IQuizEngineRepository/SaveLearnerAnswerAsync/index.md)\) |
| [ToString()](https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [UpdateLearnerAnswerAsync(Guid, Guid)](UpdateLearnerAnswerAsync/index.md) |  \(Implements [IQuizEngineRepository.UpdateLearnerAnswerAsync](../../IRepository/IQuizEngineRepository/UpdateLearnerAnswerAsync/index.md)\) |
| [UpdateLearnerAttemptAsync(LearnerAttemptViewModel)](UpdateLearnerAttemptAsync/index.md) |  \(Implements [IQuizEngineRepository.UpdateLearnerAttemptAsync](../../IRepository/IQuizEngineRepository/UpdateLearnerAttemptAsync/index.md)\) |

