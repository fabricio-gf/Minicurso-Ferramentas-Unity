using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateCard : MonoBehaviour {

    public TextAsset text;

    public Text title;
    public Text cost;
    public Text atk;
    public Text hp;
    public Text desc;

    // Use this for initialization
    void Start () {
        MyJSON obj = new MyJSON();

        print("title: " + obj.title + " cost: " + obj.cost + " atk: " + obj.atk + " hp: " + obj.hp + " desc: " + obj.desc);

        print(text.ToString());
        obj = JsonUtility.FromJson<MyJSON>(text.ToString());

        print("title: " + obj.title + " cost: " + obj.cost + " atk: " + obj.atk + " hp: " + obj.hp + " desc: " + obj.desc);

        title.text = obj.title;
        cost.text = obj.cost.ToString();
        atk.text = obj.atk.ToString();
        hp.text = obj.hp.ToString();
        desc.text = obj.desc;

    }
}
