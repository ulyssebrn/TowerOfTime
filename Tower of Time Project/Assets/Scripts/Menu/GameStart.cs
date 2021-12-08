using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace RPG.Menu
{
    public class GameStart : MonoBehaviour
    {
        // Start is called before the first frame update
        private void Awake()
        {
            SceneManager.LoadScene(0);
        }

    }
}