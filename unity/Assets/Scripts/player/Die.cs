using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour
{
    public AK.Wwise.Event death_event;
    private bool init_dieing = false;
    private bool dieing = false;
    private bool dead = false;
    public Texture texture;
    private float fade = 0.0f;
    [Range(0.01f, 1.0f)]
    public float fadeSpeed;

    void Start()
    {
        
    }

    void Update()
    {
        // Player dies when you hit the F key.
        if(Input.GetKeyDown("f"))
        {
            init_dieing = true;
            dieing = true;
        }
    }

    void OnGUI()
    {
        // Fading to red on death.
        if(dead)
        {
            GUI.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
            GUI.DrawTexture(new Rect(0.0f, 0.0f, Screen.width, Screen.height), texture);
        }
        if (dieing && !dead)
        {
            if(init_dieing)
            {
                death_event.Post(gameObject);
                init_dieing = false;
            }

            // Rotating the camera to simulate player dieing.
            PlayerMovement pm = GetComponent<PlayerMovement>();
            pm.moveSpeed = 0.0f;
            pm.look_speed = 0.2f;
            pm.playerCamera.transform.Rotate(0, 0, fade / 12);
            pm.playerCamera.transform.Translate(0, -0.0007f, 0);

            fade += fadeSpeed * Time.deltaTime;

            GUI.color = new Color(1.0f, 1.0f, 1.0f, Mathf.Clamp(fade, 0.0f, 1.0f));
            GUI.DrawTexture(new Rect(0.0f, 0.0f, Screen.width, Screen.height), texture);

            if (fade >= 1.33f)
            {
                dead = true;
                Application.Quit();
            }
        }
    }
}
