using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CentreHitPoint : MonoBehaviour
{
    [SerializeField]
    private int maxHP = 3;
    private int hP;

    private void Start()
    {
        hP = maxHP; // Set hp to max hp on start.
    }

    private void Update()
    {
        if (hP <= 0)
        {
            // Restart level if Hp reaches 0.
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            // Reduce HP by 1 if enemy makes it to centre point.
            Debug.Log("Enemy made it through, Health reduced by 1");
            hP--;
        }
    }
}
