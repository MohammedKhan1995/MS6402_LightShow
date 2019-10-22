using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowPlayer : MonoBehaviour
{
    private NavMeshAgent nmAgent;
    private float nmAgentStartSpeed;

    public float attackSpeedRatio = 4;
    public float attackDistance;
    public float bufferDistance;
    private GameObject player;

    Transform playerTransform;

    void GetPlayerTransform()
    {
        if (player != null)
        {
            playerTransform = player.transform;
        }
        else
        {
            Debug.Log("Player not specified in Inspector");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        nmAgent = GetComponent<NavMeshAgent>();
        nmAgentStartSpeed = nmAgent.speed;

        GetPlayerTransform();

        player = GameObject.Find("PC");
    }

    // Update is called once per frame
    void Update()
    {
        if (player == null)
        {
            player = GameObject.Find("PC");
        }

        nmAgent.SetDestination(player.transform.position);

        var distance = Vector3.Distance(player.transform.position, transform.position);
        // Debug.Log("Distance to Player" + distance);
        if (distance <= attackDistance)
        {
            if (distance >= bufferDistance)
            {
                nmAgent.speed = nmAgentStartSpeed * attackSpeedRatio; 
                //transform.position += transform.forward * attackSpeedRatio * Time.deltaTime;
            }
        }
    }
}