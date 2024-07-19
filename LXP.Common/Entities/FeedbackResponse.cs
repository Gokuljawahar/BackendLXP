using System;
using System.Collections.Generic;

namespace LXP.Data;

public partial class FeedbackResponse
{
    public Guid FeedbackResponseId { get; set; }

    public Guid FeedbackQuestionId { get; set; }

    public Guid LearnerId { get; set; }

    public string? Response { get; set; }

    public Guid? OptionId { get; set; }

    public string? GeneratedBy { get; set; }

    public DateTime? GeneratedAt { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedAt { get; set; }

    public virtual FeedbackQuestion FeedbackQuestion { get; set; } = null!;

    public virtual Learner Learner { get; set; } = null!;
}
