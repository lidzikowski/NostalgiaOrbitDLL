using System;

namespace NostalgiaOrbitDLL
{
    [Serializable]
    public class ChatUser
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public ChatUser(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}