using System;

namespace PeerPaperReview.Entities
{
    public abstract class BaseEntity
    {
        public string Id { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
    }
}
