using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BlindnessData", menuName = "Data/Enemy")]
public class EnemyData : ScriptableObject
{
    [SerializeField][Header("�T���n�_")]
    private Vector3[] searchPoint;
    public Vector3[] SearchPoint => searchPoint;

    [SerializeField][Header("�T�����̑���")]
    private float searchSpeed;
    public float SearchSpeed => searchSpeed;

    [SerializeField][Header("�ǐՎ��̑���")]
    private float chaseSpeed;
    public float ChaseeSpeed => chaseSpeed;
}
