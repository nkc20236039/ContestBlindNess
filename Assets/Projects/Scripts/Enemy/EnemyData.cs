using Alchemy.Inspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BlindnessData", menuName = "Data/Enemy")]
public class EnemyData : ScriptableObject
{
    [Title("������"),LabelText("����n�_"), SerializeField]
    private Vector3[] patrolPoint;
    public Vector3[] PatrolPoint => patrolPoint;
    [LabelText("���񎞂̈ړ����x"), SerializeField]
    private float searchSpeed;
    public float SearchSpeed => searchSpeed;

    [Title("�ǐՏ��"), LabelText("�ǐՎ��̈ړ����x"), SerializeField]
    private float chaseSpeed;
    public float ChaseeSpeed;
}
