using Alchemy.Inspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BlindnessData", menuName = "Data/Enemy")]
public class EnemyData : ScriptableObject
{
    [Title("巡回状態"),LabelText("巡回地点"), SerializeField]
    private Vector3[] patrolPoint;
    public Vector3[] PatrolPoint => patrolPoint;
    [LabelText("巡回時の移動速度"), SerializeField]
    private float searchSpeed;
    public float SearchSpeed => searchSpeed;

    [Title("追跡状態"), LabelText("追跡時の移動速度"), SerializeField]
    private float chaseSpeed;
    public float ChaseeSpeed;
}
