using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    CharacterController c;

    void Start()
    {
        c = GetComponent<CharacterController>();
    }

    void Update()
    {
        Vector2 input = Vector2.zero;

        if (Keyboard.current != null)
        {
            input.x = (Keyboard.current.dKey.isPressed ? 1 : 0) -
                      (Keyboard.current.aKey.isPressed ? 1 : 0);

            input.y = (Keyboard.current.wKey.isPressed ? 1 : 0) -
                      (Keyboard.current.sKey.isPressed ? 1 : 0);
        }

        Vector3 m = new Vector3(input.x, 0, input.y);

        if (m.sqrMagnitude > 1)
            m.Normalize();

        c.Move(m * speed * Time.deltaTime);
    }
}