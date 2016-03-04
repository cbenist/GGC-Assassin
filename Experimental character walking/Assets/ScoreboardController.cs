using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreboardController : MonoBehaviour {

	Text waveLabel;
	Text scoreLabel;

	string waveTag = "Wave Number: ";
	string scoreTag = "Score: ";

	ZombieCreator z;
	int multiplier = 3;

	int score;

	// Use this for initialization
	void Start () {
		waveLabel = GameObject.Find("WaveNumber").GetComponent<Text>();
		scoreLabel = GameObject.Find("Score").GetComponent<Text>();
		z = GetComponent<ZombieCreator> ();
		score = 100;
		score += (multiplier * z.wave);
		waveLabel.text = waveTag + z.wave;
		scoreLabel.text = scoreTag + score;

	}
	// Update is called once per frame
	void Update () {
		score += (multiplier * z.wave);
		waveLabel.text = waveTag + z.wave;
		scoreLabel.text = scoreTag + score;
	}
}
