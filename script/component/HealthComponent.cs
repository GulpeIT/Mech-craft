using script;
using Godot;

namespace components
{    
    public partial class HealthComponent : Node2D
    {
        [Export]
        public float _MaxHealth { get; set; }
        [Export]
        public float _CurrentHealth { get; set; }
        [Export]
        public float _Armor { get; set; }

        public void RemoveHealth(Damage damage)
        {
            _CurrentHealth = _CurrentHealth - damage.GetDamage();
        }
    }
}

