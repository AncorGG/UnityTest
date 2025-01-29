using UnityEngine;
using TMPro;
public class PlayerHandler : MonoBehaviour
{
    Rigidbody rb;
    public float baseSpeed;
    public float horizontal, vertical;
    private Vector3 movement;
    public bool isRunning;
    public TextMeshProUGUI countText;
    public GameObject winTextObject;
    public int coins;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        winTextObject.SetActive(false);
        SetCountText();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        isRunning = Input.GetKey(KeyCode.LeftShift);
    }

    private void FixedUpdate()
    {
        Move();
    }

    public void Move() { 
        float speed = isRunning? baseSpeed * 2 : baseSpeed;
        Vector3 movement = new Vector3(horizontal, 0f, vertical) * speed;

        rb.linearVelocity = new Vector3(movement.x, rb.linearVelocity.y, movement.z);
    }

    private void SetCountText() {
        countText.text = "Count: " + coins;
        if (coins >= 10)
        {
            winTextObject.SetActive(true);
            Destroy(GameObject.FindGameObjectWithTag("Enemy"));
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
            coins++;
            SetCountText();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {

            winTextObject.gameObject.SetActive(true);
            winTextObject.GetComponent<TextMeshProUGUI>().text = "You Lose!";
            Destroy(gameObject);
        }
    }

}
