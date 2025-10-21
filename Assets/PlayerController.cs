using UnityEngine;

public class PlayerController : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject canvas;
    private Rigidbody2D rigid;
    private bool isStaying = false;
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        canvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space) && isStaying)
        {
            isStaying = false;
            rigid.AddForce(new Vector2(0, 500));
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        switch (other.gameObject.tag)
        {
            case "Ground":
                isStaying = true;
                break;

            case "Rock":
                canvas.SetActive(true);
                Destroy(gameObject);
                break;
        }
    }
}
