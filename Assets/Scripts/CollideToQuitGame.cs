using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideToQuitGame : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerCharacter objCollidedWith = collision.gameObject.GetComponent<PlayerCharacter>();

        if (objCollidedWith != null)
        {
            Application.Quit();
        }
    }
}
