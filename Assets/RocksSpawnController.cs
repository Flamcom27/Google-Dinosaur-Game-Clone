using UnityEditor;
using UnityEngine;

public class RocksSpawnController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject rock;
    private float timer = 0f;
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 3)
        {
            Instantiate(rock);
            timer = 0;
        }
    }
}
