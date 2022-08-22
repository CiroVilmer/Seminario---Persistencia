using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeSceneOnClick : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        int puntaje = 0;

        PlayerPrefs.SetInt("puntaje", puntaje + 1);

        PlayerPrefs.SetString("nombre", gameObject.name);

        SceneManager.LoadScene("Escena Final");

        
    }

}
