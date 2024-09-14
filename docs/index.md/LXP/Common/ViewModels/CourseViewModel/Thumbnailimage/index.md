---
sidebar_label: Thumbnailimage
---

# CourseViewModel\.Thumbnailimage Property

**Containing Type**: [CourseViewModel](../index.md)

**Assembly**: LXP\.Common\.dll

  
Course Thumbnail

```csharp
[System.ComponentModel.DataAnnotations.Schema.NotMapped]
public Microsoft.AspNetCore.Http.IFormFile Thumbnailimage { get; set; }
```

### Property Value

[IFormFile](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.http.iformfile)

### Attributes

* [NotMappedAttribute](https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.schema.notmappedattribute)

## Examples

Image with filesize less than 250kb and file extension jpeg or png