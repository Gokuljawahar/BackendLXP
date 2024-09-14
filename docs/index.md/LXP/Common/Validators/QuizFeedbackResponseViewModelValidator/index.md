---
sidebar_label: QuizFeedbackResponseViewModelValidator
---

# QuizFeedbackResponseViewModelValidator Class

[Constructors](#constructors) &#x2022; [Properties](#properties) &#x2022; [Methods](#methods)

**Namespace**: [LXP.Common.Validators](../index.md)

**Assembly**: LXP\.Common\.dll

```csharp
public class QuizFeedbackResponseViewModelValidator : FluentValidation.AbstractValidator<LXP.Common.ViewModels.FeedbackResponseViewModel.QuizFeedbackResponseViewModel>
```

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; AbstractValidator&lt;T&gt; &#x2192; QuizFeedbackResponseViewModelValidator

### Implements

* [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)&lt;IValidationRule&gt;
* FluentValidation\.IValidator
* FluentValidation\.IValidator&lt;QuizFeedbackResponseViewModel&gt;

## Constructors

| Constructor | Summary |
| ----------- | ------- |
| [QuizFeedbackResponseViewModelValidator()](-ctor/index.md) | |

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
| Include\(IValidator&lt;QuizFeedbackResponseViewModel&gt;\) |  \(Inherited from AbstractValidator&lt;T&gt;\) |
| Include&lt;TValidator&gt;\(Func&lt;QuizFeedbackResponseViewModel, TValidator&gt;\) |  \(Inherited from AbstractValidator&lt;T&gt;\) |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| PreValidate\(ValidationContext&lt;QuizFeedbackResponseViewModel&gt;, ValidationResult\) |  \(Inherited from AbstractValidator&lt;T&gt;\) |
| RaiseValidationException\(ValidationContext&lt;QuizFeedbackResponseViewModel&gt;, ValidationResult\) |  \(Inherited from AbstractValidator&lt;T&gt;\) |
| RuleFor&lt;TProperty&gt;\(Expression&lt;Func&lt;QuizFeedbackResponseViewModel, TProperty&gt;&gt;\) |  \(Inherited from AbstractValidator&lt;T&gt;\) |
| RuleForEach&lt;TElement&gt;\(Expression&lt;Func&lt;QuizFeedbackResponseViewModel, IEnumerable&lt;TElement&gt;&gt;&gt;\) |  \(Inherited from AbstractValidator&lt;T&gt;\) |
| RuleSet\(String, Action\) |  \(Inherited from AbstractValidator&lt;T&gt;\) |
| [ToString()](https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| Transform&lt;TProperty, TTransformed&gt;\(Expression&lt;Func&lt;QuizFeedbackResponseViewModel, TProperty&gt;&gt;, Func&lt;QuizFeedbackResponseViewModel, TProperty, TTransformed&gt;\) | \[deprecated\]  \(Inherited from AbstractValidator&lt;T&gt;\) |
| Transform&lt;TProperty, TTransformed&gt;\(Expression&lt;Func&lt;QuizFeedbackResponseViewModel, TProperty&gt;&gt;, Func&lt;TProperty, TTransformed&gt;\) | \[deprecated\]  \(Inherited from AbstractValidator&lt;T&gt;\) |
| TransformForEach&lt;TElement, TTransformed&gt;\(Expression&lt;Func&lt;QuizFeedbackResponseViewModel, IEnumerable&lt;TElement&gt;&gt;&gt;, Func&lt;QuizFeedbackResponseViewModel, TElement, TTransformed&gt;\) | \[deprecated\]  \(Inherited from AbstractValidator&lt;T&gt;\) |
| TransformForEach&lt;TElement, TTransformed&gt;\(Expression&lt;Func&lt;QuizFeedbackResponseViewModel, IEnumerable&lt;TElement&gt;&gt;&gt;, Func&lt;TElement, TTransformed&gt;\) | \[deprecated\]  \(Inherited from AbstractValidator&lt;T&gt;\) |
| Unless\(Func&lt;QuizFeedbackResponseViewModel, Boolean&gt;, Action\) |  \(Inherited from AbstractValidator&lt;T&gt;\) |
| Unless\(Func&lt;QuizFeedbackResponseViewModel, ValidationContext&lt;QuizFeedbackResponseViewModel&gt;, Boolean&gt;, Action\) |  \(Inherited from AbstractValidator&lt;T&gt;\) |
| UnlessAsync\(Func&lt;QuizFeedbackResponseViewModel, CancellationToken, Task&lt;Boolean&gt;&gt;, Action\) |  \(Inherited from AbstractValidator&lt;T&gt;\) |
| UnlessAsync\(Func&lt;QuizFeedbackResponseViewModel, ValidationContext&lt;QuizFeedbackResponseViewModel&gt;, CancellationToken, Task&lt;Boolean&gt;&gt;, Action\) |  \(Inherited from AbstractValidator&lt;T&gt;\) |
| Validate\(QuizFeedbackResponseViewModel\) |  \(Inherited from AbstractValidator&lt;T&gt;\) |
| Validate\(ValidationContext&lt;QuizFeedbackResponseViewModel&gt;\) |  \(Inherited from AbstractValidator&lt;T&gt;\) |
| ValidateAsync\(QuizFeedbackResponseViewModel, CancellationToken\) |  \(Inherited from AbstractValidator&lt;T&gt;\) |
| ValidateAsync\(ValidationContext&lt;QuizFeedbackResponseViewModel&gt;, CancellationToken\) |  \(Inherited from AbstractValidator&lt;T&gt;\) |
| When\(Func&lt;QuizFeedbackResponseViewModel, Boolean&gt;, Action\) |  \(Inherited from AbstractValidator&lt;T&gt;\) |
| When\(Func&lt;QuizFeedbackResponseViewModel, ValidationContext&lt;QuizFeedbackResponseViewModel&gt;, Boolean&gt;, Action\) |  \(Inherited from AbstractValidator&lt;T&gt;\) |
| WhenAsync\(Func&lt;QuizFeedbackResponseViewModel, CancellationToken, Task&lt;Boolean&gt;&gt;, Action\) |  \(Inherited from AbstractValidator&lt;T&gt;\) |
| WhenAsync\(Func&lt;QuizFeedbackResponseViewModel, ValidationContext&lt;QuizFeedbackResponseViewModel&gt;, CancellationToken, Task&lt;Boolean&gt;&gt;, Action\) |  \(Inherited from AbstractValidator&lt;T&gt;\) |

