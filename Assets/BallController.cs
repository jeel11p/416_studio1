using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] public Rigidbody sphereRigidbody;
    [SerializeField] public float ballSpeed = 2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    public void MoveBall(Vector2 input)
    {
        Vector3 inputXZPlane = new(input.x, 0, input.y);
        sphereRigidbody.AddForce(inputXZPlane * ballSpeed);
    }
    void Start()
    {
     Debug.Log("Calling the Start method");   
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 inputVector = Vector2.zero; // intialize our input vector
        if (Input.GetKey(KeyCode.W))
        {
            inputVector += Vector2.up; // "a += b" <=> "a = a + b"
        }
        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log(Vector2.down);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log(Vector2.right);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log(Vector2.left);
        }
        Vector3 inputXZPlane = new Vector3(inputVector.x, 0, inputVector.y);
        Debug.Log("Resultant Vector: " + inputVector);
        Debug.Log("Resultant 3D Vector: " + inputXZPlane);
        sphereRigidbody.AddForce(inputXZPlane * ballSpeed);
    }
}
