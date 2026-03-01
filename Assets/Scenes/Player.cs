using NUnit.Framework;
using UnityEngine;

public class Player : MonoBehaviour
{
    //variables
    public float acceleration = 5f;
    public float maxSpeed = 5f;
    public float jumpForce = 2f;

    // Update is called once per frame
    void Update()
    {
        //Movement
        transform.Rotate(0, 0, 0);
        float move = Input.GetAxis("Horizontal") * acceleration * Time.deltaTime;
        GetComponent<Rigidbody2D>().linearVelocity += Vector2.right * move;
        if (GetComponent<Rigidbody2D>().linearVelocity.x > maxSpeed)
        {
            GetComponent<Rigidbody2D>().linearVelocity = new Vector2(maxSpeed, GetComponent<Rigidbody2D>().linearVelocity.y);
        }
        //Jump
        if (Input.GetKeyDown(KeyCode.Space)&& GetComponent<Rigidbody2D>().linearVelocity.y == 0)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce), ForceMode2D.Force);

        }
    }
}
