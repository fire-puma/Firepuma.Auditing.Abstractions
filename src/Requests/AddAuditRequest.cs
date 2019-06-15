using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Firepuma.Auditing.Abstractions.Requests
{
    public class AddAuditRequest
    {
        [Required, JsonRequired]
        public DateTime UtcTimestamp { get; set; }
        
        [Required, JsonRequired]
        public AuditActor Actor { get; set; }

        [Required, JsonRequired]
        public string PersonName { get; set; }
        
        [Required, JsonRequired]
        public string ActorIp { get; set; }

        [Required, JsonRequired]
        public string Action { get; set; }

        [Required, JsonRequired]
        public string EntityId { get; set; }

        [Required, JsonRequired]
        public string EntityDescription { get; set; }

        public string OldValue { get; set; }

        public string NewValue { get; set; }

        public AddAuditRequest(DateTime utcTimestamp, AuditActor actor, string actorIp, string personName, string action, string entityId, string entityDescription, string oldValue, string newValue)
        {
            UtcTimestamp = utcTimestamp;
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
            [Required, JsonRequired]
            public string Id { get; set; }

            [Required, JsonRequired]
            public string Email { get; set; }

            [Required, JsonRequired]
            public string FullName { get; set; }

            public AuditActor(string id, string email, string fullName)
            {
                Id = id;
                Email = email;
                FullName = fullName;
            }
        }
    }
}