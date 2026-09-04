using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            ScoreManager.Instance.AddPoint();

            Destroy(collision.gameObject);

            MoveTarget();
        }
    }

    void MoveTarget()
    {
        transform.position = new Vector3(
            Random.Range(-3f, 3f),
            Random.Range(1f, 3f),
            Random.Range(4f, 7f)
        );
    }
}