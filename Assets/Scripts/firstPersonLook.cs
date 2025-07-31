using UnityEngine;

public class firstPersonLook : MonoBehaviour {
    public float mouseSensitivity = 100f;
    public Transform playerBody;  // 指向 Player 的 Transform

    float xRotation = 0f;

    void Start() {
        Cursor.lockState = CursorLockMode.Locked;  // 鎖定滑鼠
    }

    void Update() {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // 垂直旋轉 Camera
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);  // 防止過度仰頭或低頭
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        // 水平旋轉 Player 本體
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
