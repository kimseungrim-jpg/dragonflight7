using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemy;
    public int rnd = 0;

    void Start()
    {
        InvokeRepeating("Spawn", 0.5f, 3f);
        
    }

    void Spawn()
    {
        rnd = Random.Range(-2, 2);
        transform.position = new Vector3(0 + rnd, 4.5f, 0);
        //미사일 프리팹, 런쳐포지션, 방향값 없음
        Instantiate(enemy, transform.position, Quaternion.identity);
    }


    void Update()
    {
        
    }
}
