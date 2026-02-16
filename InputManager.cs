using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static float Horizontal => Input.GetAxis("Horizontal");
    public static float Vertical => Input.GetAxis("Vertical");
    public static bool Shoot => Input.GetMouseButtonDown(0);
}
