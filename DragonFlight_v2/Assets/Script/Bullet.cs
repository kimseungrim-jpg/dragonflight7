using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float moveSpeed = 1;
    public GameObject effect;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            GameObject go = Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(go, 1);

            SoungManager.instance.SoundDie();

            Destroy(collision.gameObject);

            Destroy(gameObject);
        }
    }
}
