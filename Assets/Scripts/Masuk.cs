using UnityEngine;
using UnityEngine.SceneManagement;

public class Masuk : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void MulaiPermainan()
    {
        SceneManager.LoadScene("Gameplay");
    }
}