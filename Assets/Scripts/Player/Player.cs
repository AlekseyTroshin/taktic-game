using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private Vector2 _cellPosition;

	public Vector2 CellPosition
	{
		get { return _cellPosition; }
		set { _cellPosition = value; }
	}

	public void Initialize(PlayerData data)
	{
		transform.Find("Border").gameObject.SetActive(false);
		_cellPosition = data._cellPosition;

		transform.position = (Vector3) _cellPosition;
		transform.Find("Body").GetComponent<SpriteRenderer>().color = getPlayerBodyColor(data._color);
	}

	private Color getPlayerBodyColor(ColorPlayer color)
	{
		return color switch
		{
			ColorPlayer.Red => new Color(1f, 0f, 0f),
			ColorPlayer.Blue => new Color(0f, 0f, 1f),
			ColorPlayer.Green => new Color(0f, 1f, 0f),
			_ => new Color(1f, 1f, 0f)
		};
	}

	public void ShowBorder()
	{
		transform.Find("Border").gameObject.SetActive(true);
	}

	public void HideBorder()
	{
		transform.Find("Border").gameObject.SetActive(false);
	}

}
