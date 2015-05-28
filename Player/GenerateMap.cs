using UnityEngine;
using System.Collections;

public class GenerateMap : MonoBehaviour {
	
	public GameObject cameraObj;     // drag your secondary camera to this in the inspector
	private Camera camera;
	private RectTransform me;
	
	public bool inUse = false;
	
	private int sW = 0;
	private int sH = 0;
	
	
	// Use this for initialization
	void Start()
	{
		camera = cameraObj.GetComponent<Camera>();
		me = this.gameObject.GetComponent<RectTransform>();
		
		if (inUse)
			Init();
	}
	
	// Update is called once per frame
	void Update()
	{
		if (inUse)
		{
			if ((Screen.width != sW) || (Screen.height != sH))
				Init();
		}
	}
	
	
	void Init()
	{
		sW = Screen.width;
		sH = Screen.height;
		
		camera.pixelRect = GetScreenRect(me);
	}
	
	
	public void TurnOn(bool yes)
	{
		inUse = yes;
		
		if (inUse)
			Init();
		
		cameraObj.SetActive(yes);
	}
	
	
	public Rect GetScreenRect(RectTransform rectTransform)
	{
		Vector3[] corners = new Vector3[4];
		
		rectTransform.GetWorldCorners(corners);
		
		float xMin = float.PositiveInfinity;
		float xMax = float.NegativeInfinity;
		float yMin = float.PositiveInfinity;
		float yMax = float.NegativeInfinity;
		
		for (int i = 0; i < 4; i++)
		{
			// For Canvas mode Screen Space - Overlay there is no Camera; best solution I've found
			// is to use RectTransformUtility.WorldToScreenPoint) with a null camera.
			
			Vector3 screenCoord = RectTransformUtility.WorldToScreenPoint(null, corners[i]);
			
			if (screenCoord.x < xMin)
				xMin = screenCoord.x;
			if (screenCoord.x > xMax)
				xMax = screenCoord.x;
			if (screenCoord.y < yMin)
				yMin = screenCoord.y;
			if (screenCoord.y > yMax)
				yMax = screenCoord.y;
		}
		
		Rect result = new Rect(xMin, yMin, xMax - xMin, yMax - yMin);
		
		return result;
	}
}