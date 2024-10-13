using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    public int health;
    public int maxHealth;
    public int defense;
    public int attackPower;
    public int critChance;
    public bool isAlive { get; private set; }
    private Vector3 position;
    // Start is called before the first frame update
    void Start()
    {
        isAlive = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Attack() { }
    public void Heal(int value)
    {
        health += value;
    }
    public void Die()
    {
        isAlive = false;
    }
}
