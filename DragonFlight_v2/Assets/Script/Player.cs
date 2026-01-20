using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 3;

    void Start()
    {
        
    }

    
    void Update()
    {
        float distanceX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;

        transform.Translate(distanceX, 0, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);

            Destroy(gameObject);
        }
    }
}
