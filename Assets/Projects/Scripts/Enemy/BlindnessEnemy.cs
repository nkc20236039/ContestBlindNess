using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;
using UnityEngine.AI;

public class BlindnessEnemy : MonoBehaviour
{
    [SerializeField][Header("エネミーのデータ")]
    private EnemyData enemyData;
    [SerializeField] Player.Player player;

    private NavMeshAgent agent;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        SetSearchPoint();
    }

    private void Update()
    {
        if (agent.remainingDistance <= agent.stoppingDistance)
        {
            SetSearchPoint();
        }
    }

    private void SetSearchPoint()
    {
        int x = Random.Range(0, enemyData.SearchPoint.Length);
        agent.destination = enemyData.SearchPoint[x];
        agent.speed = enemyData.SearchSpeed;
    }

    public void ChaseePoint()
    {
        agent.destination = player.transform.position;
        agent.speed = enemyData.ChaseeSpeed;
    }
}
