using UnityEngine;
using System.Collections;

public class NodePathing : MonoBehaviour {

	public float speed = 3f;
	public Transform[] nodes;
	private int targetNode = -1;
	private Vector3 previousNode;
	private float nodeDistance;
	private float nodeTimer;


	// Use this for initialization
	void Start () {
		NodeSetup ();
	}
	
	// Update is called once per frame
	void Update () {
		if (!Main.m.paused) {
			if (nodeTimer >= 1f) {
				NodeSetup();
			} else {
				nodeTimer += (speed * Time.deltaTime) / nodeDistance;
				transform.position = Vector3.Lerp(previousNode, nodes[targetNode].position, nodeTimer);

			}
		}
	}

	void NodeSetup() {
		previousNode = transform.position;
		targetNode += 1;
		if (targetNode >= nodes.Length) {
			//TRIGGER ENDGAME
			//Main.m.paused = true;
			return;
		}
		nodeTimer = 0f;
		nodeDistance = Vector3.Distance (previousNode, nodes[targetNode].position);
	}
}
