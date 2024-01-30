﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ft.Commands
{
    public class PurgeComplete : Command
    {
        public const byte COMMAND_ID = 4;
        public override byte CommandId => COMMAND_ID;

        public int ConnectionId { get; protected set; }

        public PurgeComplete() { }

        public PurgeComplete(int connectionId)
        {
            ConnectionId = connectionId;
        }

        protected override void Serialize(BinaryWriter writer)
        {
            writer.Write(ConnectionId);
        }

        protected override void Deserialize(BinaryReader reader)
        {
            ConnectionId = reader.ReadInt32();
        }
    }
}
