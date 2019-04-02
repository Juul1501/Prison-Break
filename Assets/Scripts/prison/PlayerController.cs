using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float range = 2f;
    public float shootRange = 20f;
    private Camera camera;
    public static int score;
    public Text Score;
    void Start()
    {
        score = 0;
        camera = GetComponent<Camera>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Action"))
        {
            Interact();
        }
        if (Input.GetButtonDown("Shoot"))
        {
            Shoot();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }

    void Interact()
    {
        Ray r = new Ray(transform.position, camera.transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(r, out hit, range))
        {
            IInteractable i = hit.collider.gameObject.GetComponent<IInteractable>();
            if (i != null)
            {
                i.Action();
            }
        }
    }
    void Shoot()
    {
        Ray r = new Ray(transform.position, camera.transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(r, out hit, shootRange))
        {
            IEnemy e = hit.collider.gameObject.GetComponent<IEnemy>();
            if (e != null)
            {
                e.Action();
            }
        }
    }
}
