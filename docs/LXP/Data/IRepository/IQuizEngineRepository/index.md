---
sidebar_label: IQuizEngineRepository
---

# IQuizEngineRepository Interface

**Namespace**: [LXP.Data.IRepository](../index.md)

**Assembly**: LXP\.Data\.dll

```csharp
public interface IQuizEngineRepository
```

### Derived

* [QuizEngineRepository](../../Repository/QuizEngineRepository/index.md)

## Methods

| Method | Summary |
| ------ | ------- |
| [ClearLearnerAnswersAsync(Guid, Guid)](ClearLearnerAnswersAsync/index.md) | |
| [CreateLearnerAnswerAsync(Guid, Guid, Guid)](CreateLearnerAnswerAsync/index.md) | |
| [CreateLearnerAttemptAsync(Guid, Guid, DateTime)](CreateLearnerAttemptAsync/index.md) | |
| [GetCorrectOptionsForQuestionAsync(Guid)](GetCorrectOptionsForQuestionAsync/index.md) | |
| [GetLearnerAnswersByAttemptAndQuestionAsync(Guid, Guid)](GetLearnerAnswersByAttemptAndQuestionAsync/index.md) | |
| [GetLearnerAnswersForAttemptAsync(Guid)](GetLearnerAnswersForAttemptAsync/index.md) | |
| [GetLearnerAttemptByIdAsync(Guid)](GetLearnerAttemptByIdAsync/index.md) | |
| [GetLearnerAttemptsForQuizAsync(Guid, Guid)](GetLearnerAttemptsForQuizAsync/index.md) | |
| [GetLearnerQuizAttemptAsync(Guid)](GetLearnerQuizAttemptAsync/index.md) | |
| [GetLearnerQuizAttemptResultAsync(Guid)](GetLearnerQuizAttemptResultAsync/index.md) | |
| [GetLearnerQuizStatusAsync(Guid, Guid)](GetLearnerQuizStatusAsync/index.md) | |
| [GetOptionIdByTextAsync(Guid, String)](GetOptionIdByTextAsync/index.md) | |
| [GetOptionTextByIdAsync(Guid)](GetOptionTextByIdAsync/index.md) | |
| [GetQuestionOptionsAsync(Guid)](GetQuestionOptionsAsync/index.md) | |
| [GetQuestionsForQuizAsync(Guid)](GetQuestionsForQuizAsync/index.md) | |
| [GetQuestionTypeByIdAsync(Guid)](GetQuestionTypeByIdAsync/index.md) | |
| [GetQuizByIdAsync(Guid)](GetQuizByIdAsync/index.md) | |
| [GetQuizDetailsByTopicIdAsync(Guid)](GetQuizDetailsByTopicIdAsync/index.md) | |
| [GetQuizQuestionByIdAsync(Guid)](GetQuizQuestionByIdAsync/index.md) | |
| [IsAllowedToAttemptQuizAsync(Guid, Guid)](IsAllowedToAttemptQuizAsync/index.md) | |
| [IsQuestionOptionCorrectAsync(Guid, Guid)](IsQuestionOptionCorrectAsync/index.md) | |
| [SaveLearnerAnswerAsync(LearnerAnswerViewModel)](SaveLearnerAnswerAsync/index.md) | |
| [UpdateLearnerAnswerAsync(Guid, Guid)](UpdateLearnerAnswerAsync/index.md) | |
| [UpdateLearnerAttemptAsync(LearnerAttemptViewModel)](UpdateLearnerAttemptAsync/index.md) | |

