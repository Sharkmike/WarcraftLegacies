using System;
using System.Collections.Generic;
using System.Linq;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class ResistantSkin : Ability
    {
        public ResistantSkin(): base(1802728001)
        {
        }

        public ResistantSkin(int newId): base(1802728001, newId)
        {
        }

        public ResistantSkin(string newRawcode): base(1802728001, newRawcode)
        {
        }

        public ResistantSkin(ObjectDatabase db): base(1802728001, db)
        {
        }

        public ResistantSkin(int newId, ObjectDatabase db): base(1802728001, newId, db)
        {
        }

        public ResistantSkin(string newRawcode, ObjectDatabase db): base(1802728001, newRawcode, db)
        {
        }
    }
}