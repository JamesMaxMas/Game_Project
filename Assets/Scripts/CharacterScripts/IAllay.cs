using UnityEngine;

public interface IAllay {

    //int Health { get; set; }
    //int MaxHealth { get; set; }
    //int Defence { get; set; }
    //int AttackPower { get; set; }
    //int CritChance { get; set; }
    //Vector3 Position { get; set; }
    //bool IsAlive { get; }

    void Attack();
    void Heal(int value);
    void Die();
}
