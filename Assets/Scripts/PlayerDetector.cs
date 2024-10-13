using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerDetector : MonoBehaviour
{
    [SerializeField] private string fightSceneName;
    [SerializeField] private Vector3 fightScenePosition;
    [SerializeField] private string difficulty;
    [SerializeField] private GameObject camera1;
    [SerializeField] private GameObject camera2;
    public static string difficultyInfo;
    private static bool isInside = false;
    public Player player;

    // Start is called before the first frame update
    void Start()
    {
        difficultyInfo = difficulty;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(Player.instance.transform.position);
        //Player.instance.comeBackPosition = Player.instance.transform.position;
        if (!isInside)
        {
            UnityEngine.Debug.Log("jestem w player detector ");
            //UnityEngine.Debug.Log(fightScenePosition);
            isInside = true;
            camera1.SetActive(false);
            camera2.SetActive(true);
            player.inFight = true;
            UnityEngine.Debug.Log("zrobilem ");
            //Player.instance.comeBackPosition = Player.instance.transform.position;
            //UnityEngine.Debug.Log(gameObject.transform.position);
            //Player.instance.transform.position = fightScenePosition;
            //UnityEngine.Debug.Log(Player.instance.transform.position);
            //Player.instance.transform.rotation = Quaternion.Euler(0, -180, 0);
            //SceneManager.LoadScene(fightSceneName);
        }
        else { 
            isInside = false;
            gameObject.SetActive(false);
        }
    }
}
