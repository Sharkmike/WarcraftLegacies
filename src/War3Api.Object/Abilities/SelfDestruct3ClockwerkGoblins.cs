using System;
using System.Collections.Generic;
using System.Linq;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class SelfDestruct3ClockwerkGoblins : Ability
    {
        private readonly Lazy<ObjectProperty<bool>> _dataExplodesOnDeath;
        public SelfDestruct3ClockwerkGoblins(): base(862221121)
        {
            _dataExplodesOnDeath = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataExplodesOnDeath, SetDataExplodesOnDeath));
        }

        public SelfDestruct3ClockwerkGoblins(int newId): base(862221121, newId)
        {
            _dataExplodesOnDeath = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataExplodesOnDeath, SetDataExplodesOnDeath));
        }

        public SelfDestruct3ClockwerkGoblins(string newRawcode): base(862221121, newRawcode)
        {
            _dataExplodesOnDeath = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataExplodesOnDeath, SetDataExplodesOnDeath));
        }

        public SelfDestruct3ClockwerkGoblins(ObjectDatabase db): base(862221121, db)
        {
            _dataExplodesOnDeath = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataExplodesOnDeath, SetDataExplodesOnDeath));
        }

        public SelfDestruct3ClockwerkGoblins(int newId, ObjectDatabase db): base(862221121, newId, db)
        {
            _dataExplodesOnDeath = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataExplodesOnDeath, SetDataExplodesOnDeath));
        }

        public SelfDestruct3ClockwerkGoblins(string newRawcode, ObjectDatabase db): base(862221121, newRawcode, db)
        {
            _dataExplodesOnDeath = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataExplodesOnDeath, SetDataExplodesOnDeath));
        }

        public ObjectProperty<bool> DataExplodesOnDeath => _dataExplodesOnDeath.Value;
        private bool GetDataExplodesOnDeath(int level)
        {
            return _modifications[913531987, level].ValueAsBool;
        }

        private void SetDataExplodesOnDeath(int level, bool value)
        {
            _modifications[913531987, level] = new LevelObjectDataModification{Id = 913531987, Type = ObjectDataType.Bool, Value = value, Level = level, Pointer = 6};
        }
    }
}