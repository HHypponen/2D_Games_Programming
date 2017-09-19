using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colour_Changer : MonoBehaviour {

    public Color[] AvailableColors;
    public SpriteRenderer Sprite;

    private int _currentIndex = 0;

    private void Awake()
    {
        

        if (Sprite == null)
        {
            Sprite = GetComponent<SpriteRenderer>();
        }

        if (AvailableColors.Length == 0)
        {
            Debug.LogError("No colors available!");
        }

        // Called when game object is activated the first time.
        Debug.Log("Awake");
    }

    private void OnEnable()
    {
        // Called every time gameobject (or the component) is disabled. wrong
        Debug.Log("OnEnable");
    }

    // Use this for initialization
    void Start() {
        // Called when game object is activated the first time.
        Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {

            Sprite.color = AvailableColors[_currentIndex];
            _currentIndex++;
            if (_currentIndex >= AvailableColors.Length)
            {
                _currentIndex = 0;
            }
        }
            
        //Run every frame
            Debug.Log("Update");
        
    }

    private void FixedUpdate()
    {
        // Called everytime physics 
        Debug.Log("FixedUpdate");
    }

    private void OnDisable()
    {
        // Called every time this component is disabled
        Debug.Log("OnDisable");
    }

    private void OnDestroy()
    {
        // Called just before object is destroyed
        Debug.Log("OnDestroy");
    }
}
