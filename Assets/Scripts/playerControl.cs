/*using UnityEngine;

public class playerControl : MonoBehaviour {
    private CharacterController player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        player = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update() {
        // Get the horizontal input axis
        float horizontal = Input.GetAxis("Horizontal");

        // Get the vertical input axis
        float vertical = Input.GetAxis("Vertical");

        // Create a movement vector based on input
        Vector3 movement = new Vector3(horizontal, 0, vertical);
        Debug.DrawRay(transform.position, movement, Color.red);

        // move by the direction of the movement vector
        player.SimpleMove(movement * 5f); // Adjust speed as needed // Simple Move is effected by gravity
    }
}*/
using UnityEngine;

public class playerControl : MonoBehaviour {
    private CharacterController player;

    public float moveSpeed = 5f;
    public float turnSpeed = 120f;  // 轉向速度

    void Start() {
        player = GetComponent<CharacterController>();
    }

    void Update() {
        float horizontal = Input.GetAxis("Horizontal");  // A/D 鍵（-1 到 1）
        float vertical = Input.GetAxis("Vertical");      // W/S 鍵

        // 旋轉角色（只轉 Y 軸）
        transform.Rotate(0, horizontal * turnSpeed * Time.deltaTime, 0);

        // 前後移動（以角色面向方向）
        Vector3 forward = transform.forward * vertical;
        player.SimpleMove(forward * moveSpeed);
    }
}
