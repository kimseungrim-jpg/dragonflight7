using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 1f;

    Animator animator;

    void Update()
    {
        float distanceX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float distanceY = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(distanceX, distanceY, 0);
    }
}
