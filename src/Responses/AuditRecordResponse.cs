using System;

namespace Firepuma.Auditing.Abstractions.Responses
{
    public class AuditRecordResponse
    {
        public string Id { get; }
        public DateTime Timestamp { get; }
        public AuditActor Actor { get; }
        public string ActorIp { get; }
        public string PersonName { get; }
        public string Action { get; }
        public string EntityId { get; }
        public string EntityDescription { get; }
        public string OldValue { get; }
        public string NewValue { get; }
        
        public AuditRecordResponse(string id, DateTime timestamp, 
            AuditActor actor, string actorIp, string personName, 
            string action, string entityId, string entityDescription,
            string oldValue, string newValue)
        {
            Id = id;
            Timestamp = timestamp;
            Actor = actor;
            ActorIp = actorIp;
            PersonName = personName;
            Action = action;
            EntityId = entityId;
            EntityDescription = entityDescription;
            OldValue = oldValue;
            NewValue = newValue;
        }
        
        public class AuditActor
        {
            public string Id { get; }
            public string Email { get; }
            public string FullName { get; }

            public AuditActor(string id, string email, string fullName)
            {
                Id = id;
                Email = email;
                FullName = fullName;
            }
        }
    }
}