using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class CameraScript : MonoBehaviour
{
    public CinemachineVirtualCamera virtualCamera;
    
    // Start is called before the first frame update
    void Start()
    {
        virtualCamera.Follow = Player.instance.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
