using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Setter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Pos.started = true;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(1,LoadSceneMode.Single);
        }
    }


}
