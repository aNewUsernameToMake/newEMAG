using UnityEngine;

public class InBoundScript : MonoBehaviour
{
    private Camera mainCamera;
    private Vector2 screenBounds;
    private float playerWidth;
    private float playerHeight;

    void Start()
    {
        mainCamera = Camera.main;

        // Calculate screen bounds in world units
        screenBounds = mainCamera.ViewportToWorldPoint(new Vector3(1, 1, 0));

        // Get the player's size using its Collider2D
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer != null)
        {
            playerWidth = spriteRenderer.bounds.extents.x;
            playerHeight = spriteRenderer.bounds.extents.y;
        }
    }

    void Update()
    {
        screenBounds = mainCamera.ViewportToWorldPoint(new Vector3(1, 1, 0));

        // Clamp player's position
        Vector3 position = transform.position;
        position.x = Mathf.Clamp(position.x, -screenBounds.x + playerWidth, screenBounds.x - playerWidth);
        position.y = Mathf.Clamp(position.y, -screenBounds.y + playerHeight, screenBounds.y - playerHeight);
        transform.position = position;
    }

}
