---
sidebar_label: EnrollmentValidator
---

# EnrollmentValidator Class

[Constructors](#constructors) &#x2022; [Properties](#properties) &#x2022; [Methods](#methods)

**Namespace**: [LXP.Common.Validators](../index.md)

**Assembly**: LXP\.Common\.dll

```csharp
public class EnrollmentValidator : FluentValidation.AbstractValidator<LXP.Common.ViewModels.EnrollmentViewModel>
```

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; AbstractValidator&lt;T&gt; &#x2192; EnrollmentValidator

### Implements

* [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)&lt;IValidationRule&gt;
* FluentValidation\.IValidator
* FluentValidation\.IValidator&lt;EnrollmentViewModel&gt;

## Constructors

| Constructor | Summary |
| ----------- | ------- |
| [EnrollmentValidator()](-ctor/index.md) | |

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
| Include\(IValidator&lt;EnrollmentViewModel&gt;\) |  \(Inherited from AbstractValidator&lt;T&gt;\) |
| Include&lt;TValidator&gt;\(Func&lt;EnrollmentViewModel, TValidator&gt;\) |  \(Inherited from AbstractValidator&lt;T&gt;\) |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| PreValidate\(ValidationContext&lt;EnrollmentViewModel&gt;, ValidationResult\) |  \(Inherited from AbstractValidator&lt;T&gt;\) |
| RaiseValidationException\(ValidationContext&lt;EnrollmentViewModel&gt;, ValidationResult\) |  \(Inherited from AbstractValidator&lt;T&gt;\) |
| RuleFor&lt;TProperty&gt;\(Expression&lt;Func&lt;EnrollmentViewModel, TProperty&gt;&gt;\) |  \(Inherited from AbstractValidator&lt;T&gt;\) |
| RuleForEach&lt;TElement&gt;\(Expression&lt;Func&lt;EnrollmentViewModel, IEnumerable&lt;TElement&gt;&gt;&gt;\) |  \(Inherited from AbstractValidator&lt;T&gt;\) |
| RuleSet\(String, Action\) |  \(Inherited from AbstractValidator&lt;T&gt;\) |
| [ToString()](https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| Transform&lt;TProperty, TTransformed&gt;\(Expression&lt;Func&lt;EnrollmentViewModel, TProperty&gt;&gt;, Func&lt;EnrollmentViewModel, TProperty, TTransformed&gt;\) | \[deprecated\]  \(Inherited from AbstractValidator&lt;T&gt;\) |
| Transform&lt;TProperty, TTransformed&gt;\(Expression&lt;Func&lt;EnrollmentViewModel, TProperty&gt;&gt;, Func&lt;TProperty, TTransformed&gt;\) | \[deprecated\]  \(Inherited from AbstractValidator&lt;T&gt;\) |
| TransformForEach&lt;TElement, TTransformed&gt;\(Expression&lt;Func&lt;EnrollmentViewModel, IEnumerable&lt;TElement&gt;&gt;&gt;, Func&lt;EnrollmentViewModel, TElement, TTransformed&gt;\) | \[deprecated\]  \(Inherited from AbstractValidator&lt;T&gt;\) |
| TransformForEach&lt;TElement, TTransformed&gt;\(Expression&lt;Func&lt;EnrollmentViewModel, IEnumerable&lt;TElement&gt;&gt;&gt;, Func&lt;TElement, TTransformed&gt;\) | \[deprecated\]  \(Inherited from AbstractValidator&lt;T&gt;\) |
| Unless\(Func&lt;EnrollmentViewModel, Boolean&gt;, Action\) |  \(Inherited from AbstractValidator&lt;T&gt;\) |
| Unless\(Func&lt;EnrollmentViewModel, ValidationContext&lt;EnrollmentViewModel&gt;, Boolean&gt;, Action\) |  \(Inherited from AbstractValidator&lt;T&gt;\) |
| UnlessAsync\(Func&lt;EnrollmentViewModel, CancellationToken, Task&lt;Boolean&gt;&gt;, Action\) |  \(Inherited from AbstractValidator&lt;T&gt;\) |
| UnlessAsync\(Func&lt;EnrollmentViewModel, ValidationContext&lt;EnrollmentViewModel&gt;, CancellationToken, Task&lt;Boolean&gt;&gt;, Action\) |  \(Inherited from AbstractValidator&lt;T&gt;\) |
| Validate\(EnrollmentViewModel\) |  \(Inherited from AbstractValidator&lt;T&gt;\) |
| Validate\(ValidationContext&lt;EnrollmentViewModel&gt;\) |  \(Inherited from AbstractValidator&lt;T&gt;\) |
| ValidateAsync\(EnrollmentViewModel, CancellationToken\) |  \(Inherited from AbstractValidator&lt;T&gt;\) |
| ValidateAsync\(ValidationContext&lt;EnrollmentViewModel&gt;, CancellationToken\) |  \(Inherited from AbstractValidator&lt;T&gt;\) |
| When\(Func&lt;EnrollmentViewModel, Boolean&gt;, Action\) |  \(Inherited from AbstractValidator&lt;T&gt;\) |
| When\(Func&lt;EnrollmentViewModel, ValidationContext&lt;EnrollmentViewModel&gt;, Boolean&gt;, Action\) |  \(Inherited from AbstractValidator&lt;T&gt;\) |
| WhenAsync\(Func&lt;EnrollmentViewModel, CancellationToken, Task&lt;Boolean&gt;&gt;, Action\) |  \(Inherited from AbstractValidator&lt;T&gt;\) |
| WhenAsync\(Func&lt;EnrollmentViewModel, ValidationContext&lt;EnrollmentViewModel&gt;, CancellationToken, Task&lt;Boolean&gt;&gt;, Action\) |  \(Inherited from AbstractValidator&lt;T&gt;\) |

