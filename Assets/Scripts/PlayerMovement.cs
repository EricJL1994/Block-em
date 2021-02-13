
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private PlayerInput input;
    [Range(1, 5)]
    public int speed = 2;
    public GameObject gunPivot;
    private Rigidbody2D rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        input = new PlayerInput();
        input.Player.Move.performed += ctx => Move(ctx.ReadValue<Vector2>());
        input.Player.Move.canceled += ctx => Move(Vector2.zero);
        input.Player.Fire.performed += ctx => Fire();
    }

    private void Move(Vector2 direction)
    {
        rb.velocity = new Vector2(direction.x * speed, rb.velocity.y);
    }

    private void Update()
    {
        Vector3 mousePosition = input.Player.MousePosition.ReadValue<Vector2>();
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        Vector3 targetDirection = mousePosition - transform.position;
        float angle = Mathf.Atan2(targetDirection.y, targetDirection.x) * Mathf.Rad2Deg;
        gunPivot.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, angle));
    }

    private void Fire()
    {
        gunPivot.GetComponent<Gun>().Shoot();
    }

    private void OnEnable()
    {
        input.Player.Enable();
    }

    private void OnDisable()
    {
        input.Player.Disable();
    }
}
