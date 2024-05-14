using UnityEngine;

public class NpcAimController : MonoBehaviour
{    
    private SpriteRenderer spriteRenderer;
    private Transform player;
    private float detectionRange = 3.0f;
    private bool facingRight= true;

    private void Awake()
    {       
        player = GameObject.FindGameObjectWithTag("Player").transform;
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }

    void Update()
    {
        if (Vector2.Distance(transform.position, player.position) <= detectionRange)
        {
            if (player.position.x < transform.position.x && facingRight)
            {
                spriteRenderer.flipX = true;
                facingRight = false;
            }
            else if (player.position.x > transform.position.x && !facingRight)
            {
                spriteRenderer.flipX = false;
                facingRight = true;
            }
        }
        else
        {
            spriteRenderer.flipX = false;
            facingRight = true;
        }
    }
}
