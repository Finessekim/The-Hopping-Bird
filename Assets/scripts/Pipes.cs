/*using UnityEngine;

public class Pipes : MonoBehaviour
{
    public Transform top;
    public Transform bottom;
    public float speed = 5f;
    public float gap = 3f;

    private float leftEdge;
    private float initialY; // Initial y-position

    private void Start()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1f;
        top.position += Vector3.up * gap / 2;
        bottom.position += Vector3.down * gap / 2;

        // Save the initial y-position
        initialY = transform.position.y;
    }

    private void Update()
    {
        // Move the pipe only on the x-axis, while keeping the y and z positions the same
        transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, initialY, transform.position.z);

        // Destroy the pipe when it goes off-screen
        if (transform.position.x < leftEdge) {
            Destroy(gameObject);
        }
    }
    Debug.log();
} */

using UnityEngine;

public class Pipes : MonoBehaviour
{
    public Transform top;
    public Transform bottom;
    public float speed = 5f;
    public float gap = 3f;

    private float leftEdge;
    private float initialY; // Initial y-position

    private void Start()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1f;
        top.position += Vector3.up * gap / 2;
        bottom.position += Vector3.down * gap / 2;

        // Save the initial y-position
        initialY = transform.position.y;
    }

    private void Update()
    {
        // Move the pipe only on the x-axis, while keeping the y and z positions the same
        transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, initialY, transform.position.z);

        // Destroy the pipe when it goes off-screen
        if (transform.position.x < leftEdge) {
            Destroy(gameObject);
        }
    }
}
