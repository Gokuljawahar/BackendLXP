---
sidebar_label: CourseViewModelValidator
---

# CourseViewModelValidator Class

[Constructors](#constructors) &#x2022; [Properties](#properties) &#x2022; [Methods](#methods)

**Namespace**: [LXP.Common.Validators](../index.md)

**Assembly**: LXP\.Common\.dll

```csharp
public class CourseViewModelValidator : FluentValidation.AbstractValidator<LXP.Common.ViewModels.CourseViewModel>
```

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; AbstractValidator&lt;T&gt; &#x2192; CourseViewModelValidator

### Implements

* [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)&lt;IValidationRule&gt;
* FluentValidation\.IValidator
* FluentValidation\.IValidator&lt;CourseViewModel&gt;

## Constructors

| Constructor | Summary |
| ----------- | ------- |
| [CourseViewModelValidator()](-ctor/index.md) | |

## Properties

| Property | Summary |
| -------- | ------- |
| CascadeMode | \[deprecated\]  \(Inherited from AbstractValidator&lt;T&gt;\) |
| ClassLevelCascadeMode |  \(Inherited from AbstractValidator&lt;T&gt;\) |
| RuleLevelCascadeMode |  \(Inherited from AbstractValidator&lt;T&gt;\) |

## Methods

| Method | Summary |
| ------ | ------- |
| CreateDescriptor\(\) |  \(Inherited from AbstractValidator&lt;T&gt;\) |
| EnsureInstanceNotNull\(Object\) | \[deprecated\]  \(Inherited from AbstractValidator&lt;T&gt;\) |
| [Equals(Object)](https://docs.microsoft.com/en-us/dotnet/api/system.object.equals) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| GetEnumerator\(\) |  \(Inherited from AbstractValidator&lt;T&gt;\) |
| [GetHashCode()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| Include\(IValidator&lt;CourseViewModel&gt;\) |  \(Inherited from AbstractValidator&lt;T&gt;\) |
| Include&lt;TValidator&gt;\(Func&lt;CourseViewModel, TValidator&gt;\) |  \(Inherited from AbstractValidator&lt;T&gt;\) |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| PreValidate\(ValidationContext&lt;CourseViewModel&gt;, ValidationResult\) |  \(Inherited from AbstractValidator&lt;T&gt;\) |
| RaiseValidationException\(ValidationContext&lt;CourseViewModel&gt;, ValidationResult\) |  \(Inherited from AbstractValidator&lt;T&gt;\) |
| RuleFor&lt;TProperty&gt;\(Expression&lt;Func&lt;CourseViewModel, TProperty&gt;&gt;\) |  \(Inherited from AbstractValidator&lt;T&gt;\) |
| RuleForEach&lt;TElement&gt;\(Expression&lt;Func&lt;CourseViewModel, IEnumerable&lt;TElement&gt;&gt;&gt;\) |  \(Inherited from AbstractValidator&lt;T&gt;\) |
| RuleSet\(String, Action\) |  \(Inherited from AbstractValidator&lt;T&gt;\) |
| [ToString()](https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| Transform&lt;TProperty, TTransformed&gt;\(Expression&lt;Func&lt;CourseViewModel, TProperty&gt;&gt;, Func&lt;CourseViewModel, TProperty, TTransformed&gt;\) | \[deprecated\]  \(Inherited from AbstractValidator&lt;T&gt;\) |
| Transform&lt;TProperty, TTransformed&gt;\(Expression&lt;Func&lt;CourseViewModel, TProperty&gt;&gt;, Func&lt;TProperty, TTransformed&gt;\) | \[deprecated\]  \(Inherited from AbstractValidator&lt;T&gt;\) |
| TransformForEach&lt;TElement, TTransformed&gt;\(Expression&lt;Func&lt;CourseViewModel, IEnumerable&lt;TElement&gt;&gt;&gt;, Func&lt;CourseViewModel, TElement, TTransformed&gt;\) | \[deprecated\]  \(Inherited from AbstractValidator&lt;T&gt;\) |
| TransformForEach&lt;TElement, TTransformed&gt;\(Expression&lt;Func&lt;CourseViewModel, IEnumerable&lt;TElement&gt;&gt;&gt;, Func&lt;TElement, TTransformed&gt;\) | \[deprecated\]  \(Inherited from AbstractValidator&lt;T&gt;\) |
| Unless\(Func&lt;CourseViewModel, Boolean&gt;, Action\) |  \(Inherited from AbstractValidator&lt;T&gt;\) |
| Unless\(Func&lt;CourseViewModel, ValidationContext&lt;CourseViewModel&gt;, Boolean&gt;, Action\) |  \(Inherited from AbstractValidator&lt;T&gt;\) |
| UnlessAsync\(Func&lt;CourseViewModel, CancellationToken, Task&lt;Boolean&gt;&gt;, Action\) |  \(Inherited from AbstractValidator&lt;T&gt;\) |
| UnlessAsync\(Func&lt;CourseViewModel, ValidationContext&lt;CourseViewModel&gt;, CancellationToken, Task&lt;Boolean&gt;&gt;, Action\) |  \(Inherited from AbstractValidator&lt;T&gt;\) |
| Validate\(CourseViewModel\) |  \(Inherited from AbstractValidator&lt;T&gt;\) |
| Validate\(ValidationContext&lt;CourseViewModel&gt;\) |  \(Inherited from AbstractValidator&lt;T&gt;\) |
| ValidateAsync\(CourseViewModel, CancellationToken\) |  \(Inherited from AbstractValidator&lt;T&gt;\) |
| ValidateAsync\(ValidationContext&lt;CourseViewModel&gt;, CancellationToken\) |  \(Inherited from AbstractValidator&lt;T&gt;\) |
| When\(Func&lt;CourseViewModel, Boolean&gt;, Action\) |  \(Inherited from AbstractValidator&lt;T&gt;\) |
| When\(Func&lt;CourseViewModel, ValidationContext&lt;CourseViewModel&gt;, Boolean&gt;, Action\) |  \(Inherited from AbstractValidator&lt;T&gt;\) |
| WhenAsync\(Func&lt;CourseViewModel, CancellationToken, Task&lt;Boolean&gt;&gt;, Action\) |  \(Inherited from AbstractValidator&lt;T&gt;\) |
| WhenAsync\(Func&lt;CourseViewModel, ValidationContext&lt;CourseViewModel&gt;, CancellationToken, Task&lt;Boolean&gt;&gt;, Action\) |  \(Inherited from AbstractValidator&lt;T&gt;\) |

