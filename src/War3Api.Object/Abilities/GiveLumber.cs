using System;
using System.Collections.Generic;
using System.Linq;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class GiveLumber : Ability
    {
        private readonly Lazy<ObjectProperty<int>> _dataLumberGiven;
        public GiveLumber(): base(1970030913)
        {
            _dataLumberGiven = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataLumberGiven, SetDataLumberGiven));
        }

        public GiveLumber(int newId): base(1970030913, newId)
        {
            _dataLumberGiven = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataLumberGiven, SetDataLumberGiven));
        }

        public GiveLumber(string newRawcode): base(1970030913, newRawcode)
        {
            _dataLumberGiven = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataLumberGiven, SetDataLumberGiven));
        }

        public GiveLumber(ObjectDatabase db): base(1970030913, db)
        {
            _dataLumberGiven = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataLumberGiven, SetDataLumberGiven));
        }

        public GiveLumber(int newId, ObjectDatabase db): base(1970030913, newId, db)
        {
            _dataLumberGiven = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataLumberGiven, SetDataLumberGiven));
        }

        public GiveLumber(string newRawcode, ObjectDatabase db): base(1970030913, newRawcode, db)
        {
            _dataLumberGiven = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataLumberGiven, SetDataLumberGiven));
        }

        public ObjectProperty<int> DataLumberGiven => _dataLumberGiven.Value;
        private int GetDataLumberGiven(int level)
        {
            return _modifications[1836411977, level].ValueAsInt;
        }

        private void SetDataLumberGiven(int level, int value)
        {
            _modifications[1836411977, level] = new LevelObjectDataModification{Id = 1836411977, Type = ObjectDataType.Int, Value = value, Level = level, Pointer = 1};
        }
    }
}