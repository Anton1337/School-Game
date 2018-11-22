using UnityEngine;
using Anton.CharacterStats;

public enum EquipmentType
{
    Weapon,
    Ability,
    Chest,
    Belt
}

[CreateAssetMenu]
public class EquippableItem : Item {

    public int DamageBonus;
    public int SpeedBonus;
    public int AttackSpeedBonus;
    public int DefenseBonus;
    [Space]
    public EquipmentType EquipmentType;

    public void Equip(Character c)
    {
        if (DamageBonus != 0)
            c.Damage.AddModifier(new StatModifier(DamageBonus, this));
        if (SpeedBonus != 0)
            c.Speed.AddModifier(new StatModifier(SpeedBonus, this));
        if (AttackSpeedBonus != 0)
            c.AttackSpeed.AddModifier(new StatModifier(AttackSpeedBonus, this));
        if (DefenseBonus != 0)
            c.Defense.AddModifier(new StatModifier(DefenseBonus, this));
    }

    public void Unequip(Character c)
    {
        c.Damage.RemoveAllModifiersFromSource(this);
        c.Speed.RemoveAllModifiersFromSource(this);
        c.AttackSpeed.RemoveAllModifiersFromSource(this);
        c.Defense.RemoveAllModifiersFromSource(this);
    }
}
