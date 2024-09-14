---
sidebar_label: PostCategory
---

# CategoryController\.PostCategory\(CourseCategoryViewModel\) Method

**Containing Type**: [CategoryController](../index.md)

**Assembly**: LXP\.Api\.dll

  
adding new category

```csharp
[Microsoft.AspNetCore.Mvc.HttpPost("/lxp/course/category")]
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> PostCategory(LXP.Common.ViewModels.CourseCategoryViewModel category)
```

### Parameters

**category** &ensp; [CourseCategoryViewModel](../../../../Common/ViewModels/CourseCategoryViewModel/index.md)

### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)&lt;[IActionResult](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult)&gt;

### Attributes

* [HttpPostAttribute](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.httppostattribute)

