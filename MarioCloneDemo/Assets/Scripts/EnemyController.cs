using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyController : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    private float startLocation;
    private float endLocation;
    [SerializeField] float distance;
    private Vector3 direction = Vector3.left;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startLocation = transform.position.x;
        endLocation = startLocation - distance;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * moveSpeed * Time.deltaTime);

        if (transform.position.x < endLocation)
        {
            direction = Vector3.right;
        }
        else if (transform.position.x > startLocation)
        {
            direction = Vector3.left;
        }
    }

    private void Move()
    {
        // Enemy moves in one direction continually
        //transform.position += Vector3.left * moveSpeed * Time.deltaTime;

    }
}
