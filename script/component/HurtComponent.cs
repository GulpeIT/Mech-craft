using Godot;
using script;

namespace component
{
    [GlobalClass]
    public partial class HurtComponent : Area2D
    {


        [Export]
        public HealthComponent _HealthComponent;
        public Damage damage;

        public override void _Process(double delta)
        {
            
        }
    }    
}
