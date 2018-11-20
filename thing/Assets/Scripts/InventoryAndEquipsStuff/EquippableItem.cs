using UnityEngine;

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
}
