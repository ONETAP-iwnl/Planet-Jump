using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 300;
    public GameObject player;

    private Rigidbody2D characterBody;
    private float ScreenWidth;

    void Start ()
    {
        ScreenWidth = Screen.width;
        characterBody = player.GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        int i = 0;
        while (i < Input.touchCount)
        {
            if (Input.GetTouch(i).position.x > ScreenWidth / 2)
            {
                RunCharacter(1.0f);
            }
            if (Input.GetTouch(i).position.x < ScreenWidth / 2)
            {
                RunCharacter(-1.0f);
            }
            i++;
        }
    }
    void FixedUpdate()
    {
     #if UNITY_EDITOR
     RunCharacter(Input.GetAxis("Horizontal"));
     #endif   
    }
    private void RunCharacter(float horizontalInput)
    {
        characterBody.AddForce(new Vector2(horizontalInput * moveSpeed * Time.deltaTime, 0));
    }
}
