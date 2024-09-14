---
sidebar_label: FeedbackResponseRepository
---

# FeedbackResponseRepository Class

[Constructors](#constructors) &#x2022; [Methods](#methods)

**Namespace**: [LXP.Data.Repository](../index.md)

**Assembly**: LXP\.Data\.dll

```csharp
public class FeedbackResponseRepository : LXP.Data.IRepository.IFeedbackResponseRepository
```

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; FeedbackResponseRepository

### Implements

* [IFeedbackResponseRepository](../../IRepository/IFeedbackResponseRepository/index.md)

## Constructors

| Constructor | Summary |
| ----------- | ------- |
| [FeedbackResponseRepository(LXPDbContext)](-ctor/index.md) | |

## Methods

| Method | Summary |
| ------ | ------- |
| [AddFeedbackResponse(FeedbackResponse)](AddFeedbackResponse/index.md) |  \(Implements [IFeedbackResponseRepository.AddFeedbackResponse](../../IRepository/IFeedbackResponseRepository/AddFeedbackResponse/index.md)\) |
| [AddFeedbackResponses(IEnumerable&lt;FeedbackResponse&gt;)](AddFeedbackResponses/index.md) | |
| [DeleteFeedbackResponsesByQuizQuestionId(Guid)](DeleteFeedbackResponsesByQuizQuestionId/index.md) |  \(Implements [IFeedbackResponseRepository.DeleteFeedbackResponsesByQuizQuestionId](../../IRepository/IFeedbackResponseRepository/DeleteFeedbackResponsesByQuizQuestionId/index.md)\) |
| [DeleteFeedbackResponsesByTopicQuestionId(Guid)](DeleteFeedbackResponsesByTopicQuestionId/index.md) |  \(Implements [IFeedbackResponseRepository.DeleteFeedbackResponsesByTopicQuestionId](../../IRepository/IFeedbackResponseRepository/DeleteFeedbackResponsesByTopicQuestionId/index.md)\) |
| [Equals(Object)](https://docs.microsoft.com/en-us/dotnet/api/system.object.equals) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetCourseFeedbackQuestion(Guid)](GetCourseFeedbackQuestion/index.md) |  \(Implements [IFeedbackResponseRepository.GetCourseFeedbackQuestion](../../IRepository/IFeedbackResponseRepository/GetCourseFeedbackQuestion/index.md)\) |
| [GetCourseFeedbackQuestions(Guid)](GetCourseFeedbackQuestions/index.md) |  \(Implements [IFeedbackResponseRepository.GetCourseFeedbackQuestions](../../IRepository/IFeedbackResponseRepository/GetCourseFeedbackQuestions/index.md)\) |
| [GetCourseFeedbackResponsesByLearner(Guid, Guid)](GetCourseFeedbackResponsesByLearner/index.md) |  \(Implements [IFeedbackResponseRepository.GetCourseFeedbackResponsesByLearner](../../IRepository/IFeedbackResponseRepository/GetCourseFeedbackResponsesByLearner/index.md)\) |
| [GetExistingCourseFeedbackResponse(Guid, Guid)](GetExistingCourseFeedbackResponse/index.md) |  \(Implements [IFeedbackResponseRepository.GetExistingCourseFeedbackResponse](../../IRepository/IFeedbackResponseRepository/GetExistingCourseFeedbackResponse/index.md)\) |
| [GetExistingQuizFeedbackResponse(Guid, Guid)](GetExistingQuizFeedbackResponse/index.md) |  \(Implements [IFeedbackResponseRepository.GetExistingQuizFeedbackResponse](../../IRepository/IFeedbackResponseRepository/GetExistingQuizFeedbackResponse/index.md)\) |
| [GetExistingTopicFeedbackResponse(Guid, Guid)](GetExistingTopicFeedbackResponse/index.md) |  \(Implements [IFeedbackResponseRepository.GetExistingTopicFeedbackResponse](../../IRepository/IFeedbackResponseRepository/GetExistingTopicFeedbackResponse/index.md)\) |
| [GetHashCode()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetLearner(Guid)](GetLearner/index.md) |  \(Implements [IFeedbackResponseRepository.GetLearner](../../IRepository/IFeedbackResponseRepository/GetLearner/index.md)\) |
| [GetOptionIdByText(Guid, String)](GetOptionIdByText/index.md) |  \(Implements [IFeedbackResponseRepository.GetOptionIdByText](../../IRepository/IFeedbackResponseRepository/GetOptionIdByText/index.md)\) |
| [GetQuizFeedbackQuestion(Guid)](GetQuizFeedbackQuestion/index.md) |  \(Implements [IFeedbackResponseRepository.GetQuizFeedbackQuestion](../../IRepository/IFeedbackResponseRepository/GetQuizFeedbackQuestion/index.md)\) |
| [GetQuizFeedbackQuestions(Guid)](GetQuizFeedbackQuestions/index.md) |  \(Implements [IFeedbackResponseRepository.GetQuizFeedbackQuestions](../../IRepository/IFeedbackResponseRepository/GetQuizFeedbackQuestions/index.md)\) |
| [GetQuizFeedbackResponsesByLearner(Guid, Guid)](GetQuizFeedbackResponsesByLearner/index.md) |  \(Implements [IFeedbackResponseRepository.GetQuizFeedbackResponsesByLearner](../../IRepository/IFeedbackResponseRepository/GetQuizFeedbackResponsesByLearner/index.md)\) |
| [GetTopicFeedbackQuestion(Guid)](GetTopicFeedbackQuestion/index.md) |  \(Implements [IFeedbackResponseRepository.GetTopicFeedbackQuestion](../../IRepository/IFeedbackResponseRepository/GetTopicFeedbackQuestion/index.md)\) |
| [GetTopicFeedbackQuestions(Guid)](GetTopicFeedbackQuestions/index.md) |  \(Implements [IFeedbackResponseRepository.GetTopicFeedbackQuestions](../../IRepository/IFeedbackResponseRepository/GetTopicFeedbackQuestions/index.md)\) |
| [GetTopicFeedbackResponsesByLearner(Guid, Guid)](GetTopicFeedbackResponsesByLearner/index.md) |  \(Implements [IFeedbackResponseRepository.GetTopicFeedbackResponsesByLearner](../../IRepository/IFeedbackResponseRepository/GetTopicFeedbackResponsesByLearner/index.md)\) |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [ToString()](https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |

