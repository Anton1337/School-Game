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
    public float DamagePercentBonus;
    public float SpeedPercentBonus;
    public float AttackSpeedPercentBonus;
    public float DefencePercentBonus;
    [Space]
    public EquipmentType EquipmentType;
}
