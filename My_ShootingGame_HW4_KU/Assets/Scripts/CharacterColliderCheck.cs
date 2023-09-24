using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterColliderCheck : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        var other = collision.collider;
        if (other.tag == "Base")
        {
            if (other.name.Contains("Win"))
            {
                SceneManager.LoadScene("WinScene");
            }
            else
            {
                SceneManager.LoadScene("LoseScene");
            }
        }
    }
}
