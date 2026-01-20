using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float moveSpeed = 1.3f;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        float distanceY = moveSpeed * Time.deltaTime;

        transform.Translate(0, -distanceY, 0);
    }


    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.gameObject.CompareTag("Bullet"))
    //    {
    //        Destroy(collision.gameObject);

    //        Destroy(gameObject);
    //    }
    //}

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
