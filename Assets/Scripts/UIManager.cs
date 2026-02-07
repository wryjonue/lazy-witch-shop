using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    public Button backButton;
    public GameObject shopPanel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        if (backButton == null) {
            Debug.LogError("UIManager: backButton is not assigned!");
            return;
        }
        Debug.Log("UI Manager Started");
        backButton.onClick.AddListener(() => {
            Debug.Log("Back Button Clicked");
            shopPanel.SetActive(false);
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
