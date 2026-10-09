using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0x797e7d9b : MonoBehaviour
{
    public int LoadSceneId;
    public Button Button;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    private void Start()
    {
        if (this.IsLoadCurrentScene)
            this.Button.onClick.AddListener(() =>
            {
                _0x6da5105f.Instance.LoadSceneByIndex(SceneManager.GetActiveScene().buildIndex);
            });
        else
            this.Button.onClick.AddListener(() => _0x6da5105f.Instance.LoadSceneByIndex(this.LoadSceneId));
    }

    public bool IsLoadCurrentScene;
}