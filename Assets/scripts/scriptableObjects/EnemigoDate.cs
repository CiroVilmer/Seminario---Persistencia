using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemigoData", menuName = "soEnemigo")]

public class EnemigoDate : ScriptableObject
{
    public bool isAlive = true;

    public int points;

    public void addPoints()
    {
        points++;
    }
}
