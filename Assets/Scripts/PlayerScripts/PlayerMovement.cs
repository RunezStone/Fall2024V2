using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 1f;

    public Rigidbody2D rb;

    public Rigidbody2D shootSpawn;

    private Vector2 direction;

    // we want mouse pos for animation and shooiting
    public Vector2 mousePos;
    public Camera cam;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    void FixedUpdate()
    {
        rb.velocity = direction * movementSpeed;

        anglePos();
    }

    private void anglePos()
    {
        Vector2 lookDirection = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg - 90f;
        shootSpawn.rotation = angle;

    }
}
