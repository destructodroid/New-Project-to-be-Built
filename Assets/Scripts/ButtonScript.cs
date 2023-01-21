using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonScript : MonoBehaviour

{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }
    public void NextScreen1()
    {
        SceneManager.LoadScene(1);
    }
    public void NextScreen2()
    {
        SceneManager.LoadScene(2);
    }
    public void NextScreen3()
    {
        SceneManager.LoadScene(3);
    }
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
