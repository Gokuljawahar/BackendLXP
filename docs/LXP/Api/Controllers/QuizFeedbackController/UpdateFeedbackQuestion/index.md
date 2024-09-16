---
sidebar_label: UpdateFeedbackQuestion
---

# QuizFeedbackController\.UpdateFeedbackQuestion\(Guid, QuizfeedbackquestionViewModel\) Method

**Containing Type**: [QuizFeedbackController](../index.md)

**Assembly**: LXP\.Api\.dll

  
Update a feedback question

```csharp
[Microsoft.AspNetCore.Mvc.HttpPut("UpdateFeedbackQuestion/{quizFeedbackQuestionId}")]
public Microsoft.AspNetCore.Mvc.IActionResult UpdateFeedbackQuestion(Guid quizFeedbackQuestionId, LXP.Common.ViewModels.QuizFeedbackQuestionViewModel.QuizfeedbackquestionViewModel quizfeedbackquestion)
```

### Parameters

**quizFeedbackQuestionId** &ensp; [Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)

Feedback question ID

**quizfeedbackquestion** &ensp; [QuizfeedbackquestionViewModel](../../../../Common/ViewModels/QuizFeedbackQuestionViewModel/QuizfeedbackquestionViewModel/index.md)

Updated feedback question details

### Returns

[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)

### Attributes

* [HttpPutAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.httpputattribute)

