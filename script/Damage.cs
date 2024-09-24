using Godot;

public class Damage
{
    public float DealDamage {get; set;}
    public float ArmorPenetration {get; set;}

    public float GetDamage() => DealDamage + ArmorPenetration;
}