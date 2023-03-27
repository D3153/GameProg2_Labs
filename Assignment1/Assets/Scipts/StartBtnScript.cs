using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartBtnScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(LoadNextScene);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadNextScene(){
        SceneManager.LoadScene(1);
    }
}
