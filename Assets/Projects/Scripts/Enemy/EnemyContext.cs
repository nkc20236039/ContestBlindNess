using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyContext 
{
    public EnemyData enemyData { get; }

    public EnemyContext(EnemyData enemyData)
    {
        this.enemyData = enemyData;
    }
}
