using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Menu
{
    public class GameExit : MonoBehaviour
    {
        // Start is called before the first frame update
        private void Awake()
        {
            Application.Quit();
        }
    }
}