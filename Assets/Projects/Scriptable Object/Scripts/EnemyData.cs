using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BlindnessData", menuName = "Data/Enemy")]
public class EnemyData : ScriptableObject
{
    [SerializeField][Header("’Tõ’n“_")]
    private Vector3[] searchPoint;
    public Vector3[] SearchPoint => searchPoint;

    [SerializeField][Header("’TõŽž‚Ì‘¬‚³")]
    private float searchSpeed;
    public float SearchSpeed => searchSpeed;

    [SerializeField][Header("’ÇÕŽž‚Ì‘¬‚³")]
    private float chaseSpeed;
    public float ChaseeSpeed => chaseSpeed;
}
