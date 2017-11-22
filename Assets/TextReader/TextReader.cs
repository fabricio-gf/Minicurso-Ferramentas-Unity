using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextReader : MonoBehaviour {

    public TextAsset NaviDialogue;
    Text SpeechBubble;
    int count = 0;
    string[] linesInFile;

    // Use this for initialization
    void Start () {     
        
        SpeechBubble = GetComponent<Text>();
        linesInFile = NaviDialogue.text.Split('\n');
        SpeechBubble.text = linesInFile[count];
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (count < linesInFile.Length-1)
            {
                count++;
                SpeechBubble.text = linesInFile[count];
            }
            else
            {
                SpeechBubble.text = "Hey Listen!";
            }
        }
	}
}
