using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts
{
    public class LoseCollider : MonoBehaviour
    {
         //int GAME_OVER_SCENE = SceneManager.GetSceneByName("Game Over").buildIndex;
        private void OnTriggerEnter2D(Collider2D collision)
        {
        SceneManager.LoadScene("Game Over");
        }
    }
}
