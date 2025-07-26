using TMPro;
using UnityEngine;

[RequireComponent(typeof(Canvas))]
public class InformationUI : MonoBehaviour
{
    private static InformationUI instance;
    public static InformationUI Instance
    {
        get => instance;
        private set => instance = value;
    }

    // Components (UI)
    private Canvas canvas;

    [SerializeField]
    private TextMeshProUGUI versionText;

    private void Awake()
    {
        SetupSingleton();
        SetupComponents();
    }

    private void Start() => LoadApplicationVersion();

    private void SetupSingleton()
    {
        if (instance == null)
        {
            instance = this;

            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void SetupComponents() => canvas = GetComponent<Canvas>();

    private void LoadApplicationVersion() => versionText.text = $"v{Application.version}";
}
