using Godot;

namespace components
{
    public partial class HurtComponent : Area2D
    {
        [Export]
        public HealthComponent _HealthComponent;
    }    
}
