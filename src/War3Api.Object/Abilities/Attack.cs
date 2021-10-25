using System;
using System.Collections.Generic;
using System.Linq;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class Attack : Ability
    {
        public Attack(): base(1802789185)
        {
        }

        public Attack(int newId): base(1802789185, newId)
        {
        }

        public Attack(string newRawcode): base(1802789185, newRawcode)
        {
        }

        public Attack(ObjectDatabase db): base(1802789185, db)
        {
        }

        public Attack(int newId, ObjectDatabase db): base(1802789185, newId, db)
        {
        }

        public Attack(string newRawcode, ObjectDatabase db): base(1802789185, newRawcode, db)
        {
        }
    }
}