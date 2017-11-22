using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class MultiplayerController : NetworkBehaviour {

    public float Speed;
	public Rigidbody2D rigid;
	
	void Start(){
		rigid = GetComponent<Rigidbody2D>();
		
		Debug.Log(Network.player.ipAddress);
	}

    // Update is called once per frame
    void Update () {

        if (!isLocalPlayer)
        {
            return;
        }
        rigid.velocity = new Vector2(Input.GetAxis("Horizontal")*Speed, Input.GetAxis("Vertical")*Speed);
    }
}
