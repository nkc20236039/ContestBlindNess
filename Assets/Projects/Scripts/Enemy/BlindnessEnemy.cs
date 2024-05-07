using Alchemy.Inspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public enum BlindnessStateType
{
    Patrol,
    Chase,
}

public class BlindnessEnemy : MonoBehaviour
{
    [LabelText("エネミーのデータ"),SerializeField]
    private EnemyData enemyData;

    private SphereCollider sphereCollider;
    private NavMeshAgent agent;

    private void Start()
    {
        sphereCollider = GetComponent<SphereCollider>();
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        
    }
}
