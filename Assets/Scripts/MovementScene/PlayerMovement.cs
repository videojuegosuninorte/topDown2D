using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 movementInput;
    public float movementSpeed;
    public ContactFilter2D movementFilter;
    public float collisionOffeset;
    List<RaycastHit2D> castCollisions = new List<RaycastHit2D>();

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (movementInput != Vector2.zero)
        {
            if (!TryMovement(movementInput))
            {
                if (!TryMovement(new Vector2(movementInput.x, 0)))
                {
                    TryMovement(new Vector2(0, movementInput.y));
                }
            }
        }
    }

    private bool TryMovement(Vector2 direction)
    {
        int count = rb.Cast(
        direction,
        movementFilter,
        castCollisions,
        movementSpeed * Time.fixedDeltaTime + collisionOffeset);

        if (count == 0)
        {
            rb.MovePosition(rb.position + direction * movementSpeed * Time.fixedDeltaTime);
            return true;
        }
        return false;
    }


    void OnMove(InputValue movementValue)
    {
        movementInput = movementValue.Get<Vector2>();
       
    }
}
