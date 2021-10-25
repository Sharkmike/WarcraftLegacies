using System;
using System.Collections.Generic;
using System.Linq;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class ResistantSkinCreep : Ability
    {
        public ResistantSkinCreep(): base(1802650433)
        {
        }

        public ResistantSkinCreep(int newId): base(1802650433, newId)
        {
        }

        public ResistantSkinCreep(string newRawcode): base(1802650433, newRawcode)
        {
        }

        public ResistantSkinCreep(ObjectDatabase db): base(1802650433, db)
        {
        }

        public ResistantSkinCreep(int newId, ObjectDatabase db): base(1802650433, newId, db)
        {
        }

        public ResistantSkinCreep(string newRawcode, ObjectDatabase db): base(1802650433, newRawcode, db)
        {
        }
    }
}