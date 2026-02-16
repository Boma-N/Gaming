using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    private CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        Vector3 move = transform.right * InputManager.Horizontal +
                       transform.forward * InputManager.Vertical;

        controller.Move(move * speed * Time.deltaTime);
    }
}

