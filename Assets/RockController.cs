using UnityEngine;

public class RockController : MonoBehaviour
{
    public float speed; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = new Vector3(12, -3, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
        if (transform.position.x < -12)
        {
            Destroy(this.gameObject);
        }
    }
}
