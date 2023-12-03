using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumper : MonoBehaviour
{

  [SerializeField]
  float jumpforce = 100;

  [SerializeField]
  Transform groundCheck;

  [SerializeField]
  float groundRadius = 0.4f;

  [SerializeField]
  LayerMask groundLayer;

  bool mayJump = true;

  [SerializeField]
  float health = 3.0f;


  public static bool isGrounded;

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    // bool isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, groundLayer);
    Vector3 size = MakeGroundcheckSize();
    isGrounded = Physics2D.OverlapBox(groundCheck.position, size, 0, groundLayer);


    if (Input.GetAxisRaw("Jump") > 0 && mayJump == true && isGrounded == true)
    {
      Rigidbody2D rb = GetComponent<Rigidbody2D>();
      Vector2 jump = Vector2.up * jumpforce;

      rb.AddForce(jump);

      mayJump = false;
    }


    if (Input.GetAxisRaw("Jump") == 0)
    {
      mayJump = true;
    }


  }

  public Vector3 MakeGroundcheckSize() => new Vector3(groundRadius, groundRadius);

  private void OnTriggerEnter2D(Collider2D other)
  {
    if (other.gameObject.tag == "enemy")
    {
      health--;
      if (health < 1)
      {
        Destroy(this.gameObject);
      }
    }

  }
}
