using UnityEngine;
using UnityEngine.UI;

public class _0xab0af1ab : MonoBehaviour
{
    public Button Button;
    private void Start()
    {
        this.Button.onClick.AddListener(() => _0x6da5105f.Instance._0x1d3787ef(this.IsPhysicsRunOnClick));
    }

    public bool IsPhysicsRunOnClick;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }
}