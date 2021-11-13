using System;
using System.Collections.Generic;
using System.Linq;
using War3Api.Object.Abilities;
using War3Api.Object.Enums;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class SpawnHydraHatchling : Ability
    {
        private readonly Lazy<ObjectProperty<int>> _dataNumberOfUnits;
        private readonly Lazy<ReadOnlyObjectProperty<bool>> _isDataNumberOfUnitsModified;
        private readonly Lazy<ObjectProperty<string>> _dataUnitTypeRaw;
        private readonly Lazy<ReadOnlyObjectProperty<bool>> _isDataUnitTypeModified;
        private readonly Lazy<ObjectProperty<Unit>> _dataUnitType;
        public SpawnHydraHatchling(): base(1953526593)
        {
            _dataNumberOfUnits = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataNumberOfUnits, SetDataNumberOfUnits));
            _isDataNumberOfUnitsModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataNumberOfUnitsModified));
            _dataUnitTypeRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataUnitTypeRaw, SetDataUnitTypeRaw));
            _isDataUnitTypeModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataUnitTypeModified));
            _dataUnitType = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataUnitType, SetDataUnitType));
        }

        public SpawnHydraHatchling(int newId): base(1953526593, newId)
        {
            _dataNumberOfUnits = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataNumberOfUnits, SetDataNumberOfUnits));
            _isDataNumberOfUnitsModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataNumberOfUnitsModified));
            _dataUnitTypeRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataUnitTypeRaw, SetDataUnitTypeRaw));
            _isDataUnitTypeModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataUnitTypeModified));
            _dataUnitType = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataUnitType, SetDataUnitType));
        }

        public SpawnHydraHatchling(string newRawcode): base(1953526593, newRawcode)
        {
            _dataNumberOfUnits = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataNumberOfUnits, SetDataNumberOfUnits));
            _isDataNumberOfUnitsModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataNumberOfUnitsModified));
            _dataUnitTypeRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataUnitTypeRaw, SetDataUnitTypeRaw));
            _isDataUnitTypeModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataUnitTypeModified));
            _dataUnitType = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataUnitType, SetDataUnitType));
        }

        public SpawnHydraHatchling(ObjectDatabase db): base(1953526593, db)
        {
            _dataNumberOfUnits = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataNumberOfUnits, SetDataNumberOfUnits));
            _isDataNumberOfUnitsModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataNumberOfUnitsModified));
            _dataUnitTypeRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataUnitTypeRaw, SetDataUnitTypeRaw));
            _isDataUnitTypeModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataUnitTypeModified));
            _dataUnitType = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataUnitType, SetDataUnitType));
        }

        public SpawnHydraHatchling(int newId, ObjectDatabase db): base(1953526593, newId, db)
        {
            _dataNumberOfUnits = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataNumberOfUnits, SetDataNumberOfUnits));
            _isDataNumberOfUnitsModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataNumberOfUnitsModified));
            _dataUnitTypeRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataUnitTypeRaw, SetDataUnitTypeRaw));
            _isDataUnitTypeModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataUnitTypeModified));
            _dataUnitType = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataUnitType, SetDataUnitType));
        }

        public SpawnHydraHatchling(string newRawcode, ObjectDatabase db): base(1953526593, newRawcode, db)
        {
            _dataNumberOfUnits = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataNumberOfUnits, SetDataNumberOfUnits));
            _isDataNumberOfUnitsModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataNumberOfUnitsModified));
            _dataUnitTypeRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataUnitTypeRaw, SetDataUnitTypeRaw));
            _isDataUnitTypeModified = new Lazy<ReadOnlyObjectProperty<bool>>(() => new ReadOnlyObjectProperty<bool>(GetIsDataUnitTypeModified));
            _dataUnitType = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataUnitType, SetDataUnitType));
        }

        public ObjectProperty<int> DataNumberOfUnits => _dataNumberOfUnits.Value;
        public ReadOnlyObjectProperty<bool> IsDataNumberOfUnitsModified => _isDataNumberOfUnitsModified.Value;
        public ObjectProperty<string> DataUnitTypeRaw => _dataUnitTypeRaw.Value;
        public ReadOnlyObjectProperty<bool> IsDataUnitTypeModified => _isDataUnitTypeModified.Value;
        public ObjectProperty<Unit> DataUnitType => _dataUnitType.Value;
        private int GetDataNumberOfUnits(int level)
        {
            return _modifications[828665683, level].ValueAsInt;
        }

        private void SetDataNumberOfUnits(int level, int value)
        {
            _modifications[828665683, level] = new LevelObjectDataModification{Id = 828665683, Type = ObjectDataType.Int, Value = value, Level = level, Pointer = 1};
        }

        private bool GetIsDataNumberOfUnitsModified(int level)
        {
            return _modifications.ContainsKey(828665683, level);
        }

        private string GetDataUnitTypeRaw(int level)
        {
            return _modifications[845442899, level].ValueAsString;
        }

        private void SetDataUnitTypeRaw(int level, string value)
        {
            _modifications[845442899, level] = new LevelObjectDataModification{Id = 845442899, Type = ObjectDataType.String, Value = value, Level = level, Pointer = 2};
        }

        private bool GetIsDataUnitTypeModified(int level)
        {
            return _modifications.ContainsKey(845442899, level);
        }

        private Unit GetDataUnitType(int level)
        {
            return GetDataUnitTypeRaw(level).ToUnit(this);
        }

        private void SetDataUnitType(int level, Unit value)
        {
            SetDataUnitTypeRaw(level, value.ToRaw(null, null));
        }
    }
}