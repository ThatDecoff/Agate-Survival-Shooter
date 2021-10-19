using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetector : MonoBehaviour
{
    public GameOverManager gameOverManager;

    float enemyDistance = float.PositiveInfinity;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy" && !other.isTrigger)
        {
            float newEnemyDistance = Vector3.Distance(transform.position, other.transform.position);
            /*
            if(newEnemyDistance <= enemyDistance)
            {
                enemyDistance = newEnemyDistance;
                gameOverManager.ShowWarning(enemyDistance);
            }
            */
            gameOverManager.ShowWarning(newEnemyDistance);
        }
    }

    /*
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Enemy" && !other.isTrigger)
        {
            float newEnemyDistance = Vector3.Distance(transform.position, other.transform.position);
            if (newEnemyDistance <= enemyDistance)
            {
                enemyDistance = newEnemyDistance;
                gameOverManager.ShowWarning(enemyDistance);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Enemy" && !other.isTrigger)
        {
            enemyDistance = float.PositiveInfinity;
        }
    }
    */
}
