using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopingPlatform : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    private float startLocation;
    [SerializeField] float distance;
    private Vector3 direction = Vector3.up;

    // Start is called before the first frame update
    void Start()
    {
        startLocation = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * moveSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            direction = collision.transform.up;
        } 
    }
}
