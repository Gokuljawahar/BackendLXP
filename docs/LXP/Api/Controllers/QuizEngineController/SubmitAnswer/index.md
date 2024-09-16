---
sidebar_label: SubmitAnswer
---

# QuizEngineController\.SubmitAnswer\(AnswerSubmissionModel\) Method

**Containing Type**: [QuizEngineController](../index.md)

**Assembly**: LXP\.Api\.dll

  
Submits an answer for a quiz question\.

```csharp
[Microsoft.AspNetCore.Mvc.HttpPost("answer")]
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> SubmitAnswer(LXP.Common.ViewModels.QuizEngineViewModel.AnswerSubmissionModel answerSubmissionModel)
```

### Parameters

**answerSubmissionModel** &ensp; [AnswerSubmissionModel](../../../../Common/ViewModels/QuizEngineViewModel/AnswerSubmissionModel/index.md)

The model containing the answer submission details\.

### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)&lt;[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)&gt;

### Attributes

* [HttpPostAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.httppostattribute)

