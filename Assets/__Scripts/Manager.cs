using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour
{

		public float score;
		public TextMesh scoreMesh;

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
				scoreMesh.GetComponent<TextMesh> ().text = "" + score;
		}

		public void IncrementScore ()
		{
				score = score += Time.deltaTime;
		}
}
