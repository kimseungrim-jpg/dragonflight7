using UnityEngine;

public class BackGround : MonoBehaviour
{
    public float scrollSpeed = 0.01f;
    Material material;
    void Start()
    {
        material = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        float newOffSetY = material.mainTextureOffset.y + scrollSpeed * Time.deltaTime;

        Vector2 newOffSet = new Vector2(0, newOffSetY);

        material.mainTextureOffset = newOffSet;
    }
}
