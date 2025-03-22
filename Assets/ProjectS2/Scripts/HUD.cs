using Unity.Mathematics.Geometry;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UIElements;

public class HUD : MonoBehaviour
{
    [SerializeField]
    private float _hp;
    [SerializeField]
    private int _level;
    
    
    
    public float Hp
    {
        get { return _hp; }
        set { _hp = value; }
    }

    public int Level
    {
        get { return _level; }
        set { _level = value; }
    }

    public float GameTime
    {
        get;
        private set;
    }

    public int XP
    {
        get;
        set;
    }
    
    public UIDocument uiDocument;
    
    public int GetLevelUpXP()
    {
        return (int)(1000 * Mathf.Log(Level));
    }
    
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        uiDocument = GetComponent<UIDocument>();

        uiDocument.rootVisualElement.dataSource = new UIBinding(this);
    }

    // Update is called once per frame
    void Update()
    {
        GameTime += Time.deltaTime;
    }
}
