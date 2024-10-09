using script;
using Godot;

namespace component
{
    [GlobalClass]
    public partial class HealthComponent : Node2D
    {
        [Export]
        public float _MaxHealth { get; set; }
        [Export]
        public float _CurrentHealth { get; set; }
        [Export]
        public float _Armor { get; set; }

        public override void _Ready()
        {
            
        }

        public void AddHealth(float HP)
        {
            _CurrentHealth += HP;
            if (_CurrentHealth > _MaxHealth)
            {
                _CurrentHealth = _MaxHealth;
            }
        }
    }
}

