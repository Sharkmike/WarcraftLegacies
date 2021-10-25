using System;
using System.Collections.Generic;
using System.Linq;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class ChaosPeon : Ability
    {
        private readonly Lazy<ObjectProperty<string>> _dataNewUnitTypeRaw;
        private readonly Lazy<ObjectProperty<Unit>> _dataNewUnitType;
        public ChaosPeon(): base(895574867)
        {
            _dataNewUnitTypeRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataNewUnitTypeRaw, SetDataNewUnitTypeRaw));
            _dataNewUnitType = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataNewUnitType, SetDataNewUnitType));
        }

        public ChaosPeon(int newId): base(895574867, newId)
        {
            _dataNewUnitTypeRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataNewUnitTypeRaw, SetDataNewUnitTypeRaw));
            _dataNewUnitType = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataNewUnitType, SetDataNewUnitType));
        }

        public ChaosPeon(string newRawcode): base(895574867, newRawcode)
        {
            _dataNewUnitTypeRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataNewUnitTypeRaw, SetDataNewUnitTypeRaw));
            _dataNewUnitType = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataNewUnitType, SetDataNewUnitType));
        }

        public ChaosPeon(ObjectDatabase db): base(895574867, db)
        {
            _dataNewUnitTypeRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataNewUnitTypeRaw, SetDataNewUnitTypeRaw));
            _dataNewUnitType = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataNewUnitType, SetDataNewUnitType));
        }

        public ChaosPeon(int newId, ObjectDatabase db): base(895574867, newId, db)
        {
            _dataNewUnitTypeRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataNewUnitTypeRaw, SetDataNewUnitTypeRaw));
            _dataNewUnitType = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataNewUnitType, SetDataNewUnitType));
        }

        public ChaosPeon(string newRawcode, ObjectDatabase db): base(895574867, newRawcode, db)
        {
            _dataNewUnitTypeRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataNewUnitTypeRaw, SetDataNewUnitTypeRaw));
            _dataNewUnitType = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataNewUnitType, SetDataNewUnitType));
        }

        public ObjectProperty<string> DataNewUnitTypeRaw => _dataNewUnitTypeRaw.Value;
        public ObjectProperty<Unit> DataNewUnitType => _dataNewUnitType.Value;
        private string GetDataNewUnitTypeRaw(int level)
        {
            return _modifications[828467267, level].ValueAsString;
        }

        private void SetDataNewUnitTypeRaw(int level, string value)
        {
            _modifications[828467267, level] = new LevelObjectDataModification{Id = 828467267, Type = ObjectDataType.String, Value = value, Level = level};
        }

        private Unit GetDataNewUnitType(int level)
        {
            return GetDataNewUnitTypeRaw(level).ToUnit(this);
        }

        private void SetDataNewUnitType(int level, Unit value)
        {
            SetDataNewUnitTypeRaw(level, value.ToRaw(null, null));
        }
    }
}