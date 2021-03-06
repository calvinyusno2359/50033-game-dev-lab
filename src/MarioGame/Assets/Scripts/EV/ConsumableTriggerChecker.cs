using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class ConsumableTriggerChecker : MonoBehaviour
{
    public PowerUp stats;
    public CustomPowerUpEvent onCollected;

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            onCollected.Invoke(stats);
			Destroy(this.gameObject);
        }
    }
}
