using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject bullet;


    void Start()
    {
        InvokeRepeating("Shoot", 0.5f, 1f);
    }

    void Shoot()
    {
        SoungManager.instance.SoundBullet();
        //미사일 프리팹, 런쳐포지션, 방향값 없음
        Instantiate(bullet, transform.position, Quaternion.identity);
    }

    
    void Update()
    {
        
    }
}
