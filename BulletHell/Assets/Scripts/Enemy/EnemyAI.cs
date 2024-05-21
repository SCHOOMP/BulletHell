using System.Collections;
using UnityEngine;

public class EnemyAI
 : MonoBehaviour
{
    private enum State{
        Roaming
    }

    private State state;
    private EnemyPathFinding enemyPathFinding;


    private void Start() {
        enemyPathFinding = GetComponent<EnemyPathFinding>();
        StartCoroutine(RoamingRoutine());
    }

    private IEnumerator RoamingRoutine() {
        while (state == State.Roaming)
        {
            Vector2 roamPosition = GetRoamingPosition();
            enemyPathFinding.MoveTo(roamPosition);
            yield return new WaitForSeconds(.5f);
        }
    }
    private Vector2 GetRoamingPosition(){
        return new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
    }
}
