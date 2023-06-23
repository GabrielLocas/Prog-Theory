using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public TMP_Dropdown carDropdown;
    public TMP_InputField speedInput;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    public void UpdateCarType()
    {
        MainManager.Instance.carType = carDropdown.value;
    }

    public void UpdateSpeed()
    {
        MainManager.Instance.speed = float.Parse(speedInput.text);
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(1);
    }
}
