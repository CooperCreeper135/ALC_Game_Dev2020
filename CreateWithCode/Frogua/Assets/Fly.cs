using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    public Rigidbody2D rb;
    Vector2 movement;
    private bool m_FacingRight = true;
    public float delay = 3f;

    // Update is called once per frame
    void Start()
    {
        TurnTwo();

    }
    private void Update()
    {
        if (movement.x < 0 && !m_FacingRight)
        {
            // ... flip the player.
            Flip();
        }
        else if (movement.x > 0 && m_FacingRight)
        {
            // ... flip the player.
            Flip();
        }
    }
    public void TurnTwo()
    {
        StartCoroutine(LoadLeve());

    }

    IEnumerator LoadLeve()
    {
        yield return new WaitForSeconds(delay);
        movement.x = 1;

        Turn();
    }
    public void Turn()
    {
        StartCoroutine(LoadLevel());
    }

    IEnumerator LoadLevel()
    {
        yield return new WaitForSeconds(delay);
        movement.x = -1;
        TurnTwo();
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * 4 * Time.fixedDeltaTime);
    }

    private void Flip()
    {
        // Switch the way the player is labelled as facing.
        m_FacingRight = !m_FacingRight;

        // Multiply the player's x local scale by -1.
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

}
