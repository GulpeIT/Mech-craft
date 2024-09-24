using Godot;

public partial class HealthComponent : Node2D
{
    [Export]
    public float MaxHealth { get; set; }
    [Export]
    public float CurrentHealth { get; set; }
    [Export]
    public float Armor { get; set; }

    public void RemoveHealth(Damage damage)
    {
        CurrentHealth = CurrentHealth - damage.GetDamage();
    }
}
