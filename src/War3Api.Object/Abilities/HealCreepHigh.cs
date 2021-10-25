using System;
using System.Collections.Generic;
using System.Linq;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class HealCreepHigh : Ability
    {
        private readonly Lazy<ObjectProperty<float>> _dataHitPointsGained;
        public HealCreepHigh(): base(845704769)
        {
            _dataHitPointsGained = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataHitPointsGained, SetDataHitPointsGained));
        }

        public HealCreepHigh(int newId): base(845704769, newId)
        {
            _dataHitPointsGained = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataHitPointsGained, SetDataHitPointsGained));
        }

        public HealCreepHigh(string newRawcode): base(845704769, newRawcode)
        {
            _dataHitPointsGained = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataHitPointsGained, SetDataHitPointsGained));
        }

        public HealCreepHigh(ObjectDatabase db): base(845704769, db)
        {
            _dataHitPointsGained = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataHitPointsGained, SetDataHitPointsGained));
        }

        public HealCreepHigh(int newId, ObjectDatabase db): base(845704769, newId, db)
        {
            _dataHitPointsGained = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataHitPointsGained, SetDataHitPointsGained));
        }

        public HealCreepHigh(string newRawcode, ObjectDatabase db): base(845704769, newRawcode, db)
        {
            _dataHitPointsGained = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataHitPointsGained, SetDataHitPointsGained));
        }

        public ObjectProperty<float> DataHitPointsGained => _dataHitPointsGained.Value;
        private float GetDataHitPointsGained(int level)
        {
            return _modifications[828466504, level].ValueAsFloat;
        }

        private void SetDataHitPointsGained(int level, float value)
        {
            _modifications[828466504, level] = new LevelObjectDataModification{Id = 828466504, Type = ObjectDataType.Unreal, Value = value, Level = level, Pointer = 1};
        }
    }
}