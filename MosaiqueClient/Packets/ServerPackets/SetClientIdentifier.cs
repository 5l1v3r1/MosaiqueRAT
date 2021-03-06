﻿using Client.Controllers;
using ZeroFormatter;

namespace Client.Packets.ServerPackets
{
    [ZeroFormattable]
    public class SetClientIdentifier : IPackets
    {
        public override TypePackets Type
        {
            get
            {
                return TypePackets.SetClientIdentifier;
            }
        }

        [Index(0)]
        public virtual string newClientIdentifier { get; set; }

        public SetClientIdentifier()
        {
        }

        public SetClientIdentifier(string newClientID)
        {
            this.newClientIdentifier = newClientID;
        }

        public void Execute(ClientMosaique client)
        {
            client.send(this);
        }
    }
}
