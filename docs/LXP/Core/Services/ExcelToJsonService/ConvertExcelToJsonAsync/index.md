---
sidebar_label: ConvertExcelToJsonAsync
---

# ExcelToJsonService\.ConvertExcelToJsonAsync\(IFormFile\) Method

**Containing Type**: [ExcelToJsonService](../index.md)

**Assembly**: LXP\.Core\.dll

```csharp
public System.Threading.Tasks.Task<System.Collections.Generic.List<LXP.Common.ViewModels.QuizQuestionViewModel.QuizQuestionJsonViewModel>> ConvertExcelToJsonAsync(Microsoft.AspNetCore.Http.IFormFile file)
```

### Parameters

**file** &ensp; [IFormFile](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.http.iformfile)

### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)&lt;[List](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)&lt;[QuizQuestionJsonViewModel](../../../../Common/ViewModels/QuizQuestionViewModel/QuizQuestionJsonViewModel/index.md)&gt;&gt;

### Implements

* [IExcelToJsonService.ConvertExcelToJsonAsync](../../../IServices/IExcelToJsonService/ConvertExcelToJsonAsync/index.md)
