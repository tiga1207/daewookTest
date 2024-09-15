using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public Rigidbody2D rb; //리저드 바디
    public int x;//test
    public float xInput, yInput, moveSpeed;//x축, y축, 이동속도

    void Update()
    {
        InputManager();
        Movement();
    }

    void Movement()
    {
        rb.velocity = new Vector2(xInput * moveSpeed, yInput * moveSpeed);
    }

    void InputManager()
    {
        yInput = Input.GetAxisRaw("Vertical"); // 수직 입력 관리
        xInput = Input.GetAxisRaw("Horizontal"); // 수평 입력 관리
    }
}
