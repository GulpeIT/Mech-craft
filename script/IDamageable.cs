using Godot;

namespace script
{
    public interface IDamageable
    {
        Damage damage { get; set; }

        public float GetDamage();
    }
}


