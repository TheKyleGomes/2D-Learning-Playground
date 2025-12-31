using UnityEngine;

public class Boost : MonoBehaviour
{
    SimpleMove move;

    void Awake()
    {
        move = GetComponent<SimpleMove>();
    }

    void Update()
    {
        while (Input.GetKey(KeyCode.LeftControl))
        {
            move.speed += 0.2f;
        }
    }
}