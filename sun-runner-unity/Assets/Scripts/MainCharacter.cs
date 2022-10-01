using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using Quaternion = UnityEngine.Quaternion;

public class MainCharacter : MonoBehaviour
{
    public float speed = 2;
    [SerializeField]
    private SpriteRenderer spriteRenderer;
    [SerializeField]
    private Rigidbody2D player_rb;
    [SerializeField]
    private Animator animator;
    [SerializeField]
    private TextMeshProUGUI textMeshPro;

    private static SceneName currentSceneName;
    
    // Start is called before the first frame update
    void Start()
    {
        currentSceneName = (SceneName)Enum.Parse(typeof(SceneName), SceneManager.GetActiveScene().name);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(x, y);

        var rotationAngle = x >= 0 ? 90 : -90;

        animator.enabled = false;

        if (movement.x != 0)
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, rotationAngle));
            animator.enabled = true;
        }

        if (movement.magnitude > 1)
        {
            movement.Normalize();
        }

        player_rb.velocity = movement * speed * Time.fixedDeltaTime;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        player_rb.velocity = Vector2.zero;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Finish")
        {
            StartCoroutine(Win());
            return;
        }

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private IEnumerator Win()
    {
        textMeshPro.enabled = true;
        yield return new WaitForSeconds(1);
        textMeshPro.enabled = false;

        currentSceneName = (SceneName)Mathf.Clamp((int)++currentSceneName, 0, Enum.GetNames(typeof(SceneName)).Length - 1);

        SceneManager.LoadScene(currentSceneName.ToString());
    }

    private enum SceneName
    {
        a = 0,
        b,
        c
        // TODO: replace scene
    }
}
