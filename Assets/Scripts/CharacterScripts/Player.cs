using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player instance;
    public bool isAlive;
    public int health;
    public int maxHealth;
    public int defense;
    public int attackPower;
    public int critChance;
    public Vector3 comeBackPosition = new Vector3(0,0,0);
    //public bool inRoom = false;
    private List<IAllay> allays = new List<IAllay>();
    public bool inFight = false;
    private void Awake()
    {
        if (instance != null) { 
            Destroy(gameObject);
            return;
        }

        instance = this;
        isAlive = true;
        DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        //if (instance != null)
        //{
        //    Destroy(gameObject);
        //    return;
        //}

        //instance = this;
        //isAlive = true;
        //DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
