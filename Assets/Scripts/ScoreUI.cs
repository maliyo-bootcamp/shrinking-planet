using UnityEngine.UI;
using UnityEngine;

public class ScoreUI : MonoBehaviour {

	public Text text;
	public RowUI rowUI;
	public ScoreManager scoreManager;
	RectTransform rt;
	Vector2 startPos;

	void Start ()
	{
		scoreManager.AddScore(new Score("Janet", 12));
		scoreManager.AddScore(new Score("Pete", 42));

		var scores = scoreManager.GetHighScores().ToArray();
		for (int i = 0; i < scores.Length; i++)
        {
			var row = Instantiate(rowUI, transform).GetComponent<RowUI>();
			row.name.text = scores[i].name;
			row.score.text = scores[i].score.ToString();
        }
		rt = GetComponent<RectTransform>();
		startPos = rt.anchoredPosition;
		
    }

	void Update ()
	{
		text.text = Planet.Score.ToString("0.#") + "m";

		rt.anchoredPosition = Vector2.Lerp(Vector2.zero, startPos, Planet.Size);
	}

}
