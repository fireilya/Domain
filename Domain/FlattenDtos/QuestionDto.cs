using System;
using Domain.Enumerations;

namespace Domain.FlattenDtos
{
    public record QuestionDto(Guid Id, Guid QuestId, Guid? ParentId, string Content, string Answer, QuestionType Type)
    {
        public Guid Id { get; set; } = Id;
        public Guid QuestId { get; set; } = QuestId;
        public Guid? ParentId { get; set; } = ParentId;
        public string Content { get; set; } = Content;
        public string Answer { get; set; } = Answer;
        public QuestionType Type { get; set; } = Type;
    }
}