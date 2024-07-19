using System;
using System.Collections.Generic;

namespace LXP.Data;

public partial class FeedbackQuestionsOption
{
    public Guid FeedbackQuestionOptionId { get; set; }

    public Guid FeedbackQuestionId { get; set; }

    public string OptionText { get; set; } = null!;

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedAt { get; set; }

    public virtual FeedbackQuestion FeedbackQuestion { get; set; } = null!;
}
