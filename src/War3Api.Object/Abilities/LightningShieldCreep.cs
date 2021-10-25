using System;
using System.Collections.Generic;
using System.Linq;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class LightningShieldCreep : Ability
    {
        private readonly Lazy<ObjectProperty<float>> _dataDamagePerSecond;
        public LightningShieldCreep(): base(1936474945)
        {
            _dataDamagePerSecond = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamagePerSecond, SetDataDamagePerSecond));
        }

        public LightningShieldCreep(int newId): base(1936474945, newId)
        {
            _dataDamagePerSecond = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamagePerSecond, SetDataDamagePerSecond));
        }

        public LightningShieldCreep(string newRawcode): base(1936474945, newRawcode)
        {
            _dataDamagePerSecond = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamagePerSecond, SetDataDamagePerSecond));
        }

        public LightningShieldCreep(ObjectDatabase db): base(1936474945, db)
        {
            _dataDamagePerSecond = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamagePerSecond, SetDataDamagePerSecond));
        }

        public LightningShieldCreep(int newId, ObjectDatabase db): base(1936474945, newId, db)
        {
            _dataDamagePerSecond = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamagePerSecond, SetDataDamagePerSecond));
        }

        public LightningShieldCreep(string newRawcode, ObjectDatabase db): base(1936474945, newRawcode, db)
        {
            _dataDamagePerSecond = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamagePerSecond, SetDataDamagePerSecond));
        }

        public ObjectProperty<float> DataDamagePerSecond => _dataDamagePerSecond.Value;
        private float GetDataDamagePerSecond(int level)
        {
            return _modifications[828928844, level].ValueAsFloat;
        }

        private void SetDataDamagePerSecond(int level, float value)
        {
            _modifications[828928844, level] = new LevelObjectDataModification{Id = 828928844, Type = ObjectDataType.Unreal, Value = value, Level = level, Pointer = 1};
        }
    }
}