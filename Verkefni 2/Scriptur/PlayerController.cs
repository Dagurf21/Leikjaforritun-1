using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    public float groundCheckDistance = 0.1f;
    public LayerMask groundLayer;

    private Rigidbody rb;
    private bool isGrounded;
    private bool isJumping;

    public string gameOverSceneName = "GameOver";

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * moveSpeed * Time.fixedDeltaTime;
        rb.MovePosition(transform.position + movement);

        if (Input.GetKeyDown(KeyCode.Space) && !isJumping && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isJumping = true;
            StartCoroutine(ResetJump());
        }

        if (Input.GetKey(KeyCode.F))
        {
            transform.Rotate(Vector3.up, -90f * Time.fixedDeltaTime);
        }

        if (Input.GetKey(KeyCode.G))
        {
            transform.Rotate(Vector3.up, 90f * Time.fixedDeltaTime);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            isJumping = false;
        }
        if (other.gameObject.CompareTag("Bomb"))
        {
            SceneManager.LoadScene(gameOverSceneName);
        }

    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }

    private bool IsGrounded()
    {
        return Physics.Raycast(transform.position, -Vector3.up, groundCheckDistance, groundLayer);
    }

    private IEnumerator ResetJump()
    {
        yield return new WaitForSeconds(0.1f);
        isJumping = false;
    }
}


/* public class PlayerController : MonoBehaviour - Þessi virkaði
{
    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    public float groundCheckDistance = 0.1f;
    public LayerMask groundLayer;

    private Rigidbody rb;
    private bool isGrounded;
    private bool isJumping;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * moveSpeed * Time.fixedDeltaTime;
        rb.MovePosition(transform.position + movement);

        if (Input.GetKeyDown(KeyCode.Space) && !isJumping && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isJumping = true;
        }

        if (Input.GetKey(KeyCode.F))
        {
            transform.Rotate(Vector3.up, -90f * Time.fixedDeltaTime);
        }

        if (Input.GetKey(KeyCode.G))
        {
            transform.Rotate(Vector3.up, 90f * Time.fixedDeltaTime);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            isJumping = false;
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }

    private bool IsGrounded()
    {
        return Physics.Raycast(transform.position, -Vector3.up, groundCheckDistance, groundLayer);
    }
} */

/* public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    public float groundCheckDistance = 0.1f;
    public LayerMask groundLayer;

    private Rigidbody rb;
    private bool isGrounded;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * moveSpeed * Time.fixedDeltaTime;
        rb.MovePosition(transform.position + movement);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.F))
        {
            transform.Rotate(Vector3.up, -90f * Time.fixedDeltaTime);
        }

        if (Input.GetKey(KeyCode.G))
        {
            transform.Rotate(Vector3.up, 90f * Time.fixedDeltaTime);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }

    private bool IsGrounded()
    {
        return Physics.Raycast(transform.position, -Vector3.up, groundCheckDistance, groundLayer);
    }
} */

