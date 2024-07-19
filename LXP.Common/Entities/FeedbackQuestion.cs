using System;
using System.Collections.Generic;

namespace LXP.Data;

public partial class FeedbackQuestion
{
    public Guid FeedbackQuestionId { get; set; }

    public string FeedbackType { get; set; } = null!;

    public Guid FeedbackEntityId { get; set; }

    public int QuestionNo { get; set; }

    public string Question { get; set; } = null!;

    public string QuestionType { get; set; } = null!;

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedAt { get; set; }

    public virtual Course FeedbackEntity { get; set; } = null!;

    public virtual Topic FeedbackEntity1 { get; set; } = null!;

    public virtual Quiz FeedbackEntityNavigation { get; set; } = null!;

    public virtual ICollection<FeedbackQuestionsOption> FeedbackQuestionsOptions { get; set; } = new List<FeedbackQuestionsOption>();

    public virtual ICollection<FeedbackResponse> FeedbackResponses { get; set; } = new List<FeedbackResponse>();
}
