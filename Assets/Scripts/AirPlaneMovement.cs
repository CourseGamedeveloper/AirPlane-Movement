 using UnityEngine;

public class AirPlaneMovement : MonoBehaviour
{
    [SerializeField]
    [Tooltip("speed of the airplane when move")]
    public float speed = 5f; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //to take the movement form the keyBoard
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        // to move the air plane
        Vector3 movement = new Vector3(moveX, moveY, 0f);
        transform.position += movement * speed * Time.deltaTime;
    }
}
