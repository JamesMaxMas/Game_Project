using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class EnemySpawner : MonoBehaviour
{
    //public static EnemySpawner instance;
    [SerializeField] GameObject enemyEasy;
    [SerializeField] GameObject enemyMedium;
    [SerializeField] GameObject enemyHard;
    

    private void Awake()
    {
        //instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerDetector.difficultyInfo == "Easy")
            SpawnEnemyEasy();
        else if (PlayerDetector.difficultyInfo == "Medium")
            SpawnEnemyMedium();
        else if (PlayerDetector.difficultyInfo == "Hard")
            SpawnEnemyHard();
        else {
            Debug.Log("Bad difficulty name");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            //Player.instance.transform.position = Player.instance.comeBackPosition;
            //Debug.Log(Player.instance.comeBackPosition);
            //Debug.Log("Setting position to: " + Player.instance.comeBackPosition);
            //Player.instance.transform.position = Player.instance.comeBackPosition;
            //Debug.Log("New position is: " + Player.instance.transform.position);

            Player.instance.GetComponent<NavMeshAgent>().enabled = false;
            Player.instance.transform.position = Player.instance.comeBackPosition;
            Debug.Log("New position is: " + Player.instance.transform.position);
            Player.instance.GetComponent<NavMeshAgent>().enabled = true;
            SceneManager.LoadScene("Level_1");
        }
    }

    public void SpawnEnemyEasy() { 
        Instantiate(enemyEasy, new Vector3(0f, 0f, -3f), Quaternion.identity);
        Instantiate(enemyEasy, new Vector3(3f, 0f, -3f), Quaternion.identity);
        Instantiate(enemyEasy, new Vector3(-3f, 0f, -3f), Quaternion.identity);
    }

    public void SpawnEnemyMedium() {
        Instantiate(enemyMedium, new Vector3(0f, 0f, -3f), Quaternion.identity);
        Instantiate(enemyMedium, new Vector3(3f, 0f, -3f), Quaternion.identity);
        Instantiate(enemyMedium, new Vector3(-3f, 0f, -3f), Quaternion.identity);
    }

    public void SpawnEnemyHard() {
        Instantiate(enemyHard, new Vector3(0f, 0f, -3f), Quaternion.identity);
        Instantiate(enemyHard, new Vector3(3f, 0f, -3f), Quaternion.identity);
        Instantiate(enemyHard, new Vector3(-3f, 0f, -3f), Quaternion.identity);
    }
}
