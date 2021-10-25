using System;
using System.Collections.Generic;
using System.Linq;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class DeathCoilCreep : Ability
    {
        private readonly Lazy<ObjectProperty<float>> _dataAmountHealedDamaged;
        public DeathCoilCreep(): base(1667515201)
        {
            _dataAmountHealedDamaged = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataAmountHealedDamaged, SetDataAmountHealedDamaged));
        }

        public DeathCoilCreep(int newId): base(1667515201, newId)
        {
            _dataAmountHealedDamaged = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataAmountHealedDamaged, SetDataAmountHealedDamaged));
        }

        public DeathCoilCreep(string newRawcode): base(1667515201, newRawcode)
        {
            _dataAmountHealedDamaged = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataAmountHealedDamaged, SetDataAmountHealedDamaged));
        }

        public DeathCoilCreep(ObjectDatabase db): base(1667515201, db)
        {
            _dataAmountHealedDamaged = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataAmountHealedDamaged, SetDataAmountHealedDamaged));
        }

        public DeathCoilCreep(int newId, ObjectDatabase db): base(1667515201, newId, db)
        {
            _dataAmountHealedDamaged = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataAmountHealedDamaged, SetDataAmountHealedDamaged));
        }

        public DeathCoilCreep(string newRawcode, ObjectDatabase db): base(1667515201, newRawcode, db)
        {
            _dataAmountHealedDamaged = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataAmountHealedDamaged, SetDataAmountHealedDamaged));
        }

        public ObjectProperty<float> DataAmountHealedDamaged => _dataAmountHealedDamaged.Value;
        private float GetDataAmountHealedDamaged(int level)
        {
            return _modifications[828597333, level].ValueAsFloat;
        }

        private void SetDataAmountHealedDamaged(int level, float value)
        {
            _modifications[828597333, level] = new LevelObjectDataModification{Id = 828597333, Type = ObjectDataType.Unreal, Value = value, Level = level, Pointer = 1};
        }
    }
}