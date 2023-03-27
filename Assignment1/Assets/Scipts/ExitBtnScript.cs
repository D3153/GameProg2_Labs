using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ExitBtnScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(LoadExit);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadExit(){
        Application.Quit();
    }
}
