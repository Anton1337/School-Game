using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Anton.CharacterStats
{
    [Serializable]
    public class CharacterStat
    {

        public int BaseValue;

        public virtual int Value
        {
            get
            {
                if (isDirty || BaseValue != lastBaseValue)
                {
                    lastBaseValue = BaseValue;
                    _value = CalculateFinalValue();
                    isDirty = false;
                }
                return _value;
            }
        }

        protected bool isDirty = true;
        protected int _value;
        protected int lastBaseValue = int.MinValue;

        protected readonly List<StatModifier> statmodifiers;
        public readonly ReadOnlyCollection<StatModifier> StatModifiers;

        public CharacterStat()
        {
            statmodifiers = new List<StatModifier>();
            StatModifiers = statmodifiers.AsReadOnly();
        }

        public CharacterStat(int baseValue) : this()
        {
            BaseValue = baseValue;
        }

        public virtual void AddModifier(StatModifier mod)
        {
            isDirty = true;
            statmodifiers.Add(mod);
        }

        public virtual bool RemoveModifier(StatModifier mod)
        {
            if (statmodifiers.Remove(mod))
            {
                isDirty = true;
                return true;
            }
            return false;
        }

        public virtual bool RemoveAllModifiersFromSource(object source)
        {
            bool didRemove = false;

            for (int i = statmodifiers.Count - 1; i >= 0; i--)
            {
                if (statmodifiers[i].Source == source)
                {
                    isDirty = true;
                    didRemove = true;
                    statmodifiers.RemoveAt(i);
                }
            }

            return didRemove;
        }

        protected virtual int CalculateFinalValue()
        {
            int finalValue = BaseValue;

            foreach (var mod in statmodifiers)
            {
                finalValue += mod.Value;
            }

            return finalValue;
        }
    }
}
