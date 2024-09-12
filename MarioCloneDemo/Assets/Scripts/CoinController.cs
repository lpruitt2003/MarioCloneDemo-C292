using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] int pointValue;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            removeCoin();
            UIManager.Instance.IncreaseScore(pointValue);
        }
    }

    private void removeCoin()
    {
        Destroy(gameObject);
    }
}
