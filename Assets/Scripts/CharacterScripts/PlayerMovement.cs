//using System.Collections;
//using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{

    private NavMeshAgent agent;
    public Player player;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        //UnityEngine.Debug.Log(NavMesh.AllAreas);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(1)) {
            //UnityEngine.Debug.Log("to dziala\n");
            if (!player.inFight)
            {
                MoveToPosition();
            }
            else
            {
                MoveToPlot();
            }
            
        }
    }

    private void MoveToPosition() { 
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit)) {
            if (NavMesh.SamplePosition(hit.point, out NavMeshHit navHit, 1, NavMesh.AllAreas)) {
                agent.SetDestination(navHit.position);
            }
        }
    }
    private void MoveToPlot()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            UnityEngine.Debug.Log("1");
            if (NavMesh.SamplePosition(hit.transform.position, out NavMeshHit navHit, 1,1 << NavMesh.GetAreaFromName("Plots")))
            {
                UnityEngine.Debug.Log("2");
                agent.SetDestination(navHit.position);
            }
        }
    }
}
