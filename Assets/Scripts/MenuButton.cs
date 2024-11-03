using FMODUnity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MenuButton : Button
{
    private Button button;
    private Text text;
    private string defaultText;
    private string highlightText;
    private StudioEventEmitter tick;
    private bool played = false;
    void Start()
    {
        button = GetComponent<Button>();
        text = GetComponentInChildren<Text>();
        tick = gameObject.GetComponent<StudioEventEmitter>();
        defaultText = text.text;
        highlightText = text.text + " <";

    }

    // Update is called once per frame
    void Update()
    {
        //if (text.text.Contains('<')) text.text = defaultText.Remove(defaultText.IndexOf('<'));

        if (IsHighlighted())
        {
            text.text = highlightText;
            if (!played) tick.Play();
            played = true;
            
        }
        else
        {
            text.text = defaultText;
            played = false;
        }
    }
}
