using UnityEngine;

public class SimpleMove : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        // 1. Read input as two simple numbers
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        // 2. Combine those numbers into ONE direction
        Vector2 direction = new Vector2(horizontal, vertical);

        // 3. Move the object
        transform.Translate(direction * speed * Time.deltaTime, Space.World);

        // 4. Rotate to face movement direction (only if moving)
        if (direction.sqrMagnitude > 0.001f)
        {
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90f;
            transform.rotation = Quaternion.Euler(0f, 0f, angle);
        }
    }
}