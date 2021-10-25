using System;
using System.Collections.Generic;
using System.Linq;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class PassiveHumanLumberHarvestingRhlh : Ability
    {
        public PassiveHumanLumberHarvestingRhlh(): base(1751935041)
        {
        }

        public PassiveHumanLumberHarvestingRhlh(int newId): base(1751935041, newId)
        {
        }

        public PassiveHumanLumberHarvestingRhlh(string newRawcode): base(1751935041, newRawcode)
        {
        }

        public PassiveHumanLumberHarvestingRhlh(ObjectDatabase db): base(1751935041, db)
        {
        }

        public PassiveHumanLumberHarvestingRhlh(int newId, ObjectDatabase db): base(1751935041, newId, db)
        {
        }

        public PassiveHumanLumberHarvestingRhlh(string newRawcode, ObjectDatabase db): base(1751935041, newRawcode, db)
        {
        }
    }
}