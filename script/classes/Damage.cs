using Godot;

namespace script
{
    public class Damage
    {
        public float _DealDamage {get; set;}
        public float _ArmorPenetration {get; set;}

        public float GetDamage() => _DealDamage + _ArmorPenetration;
    }
}
