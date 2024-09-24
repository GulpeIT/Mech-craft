using Godot;

namespace script
{
    public interface IDamageable
    {
        public Damage _Damage { get; set; }

        public float GetDamage();
    }
}


