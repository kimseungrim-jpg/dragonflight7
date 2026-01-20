using UnityEngine;

public class SingletonTest : MonoBehaviour
{

    public static SingletonTest instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void PlayerSound()
    {
        Debug.Log("플레이어 사운드");
    }

    public void EnemySound()
    {
        Debug.Log("적 사운드");
    }
}
