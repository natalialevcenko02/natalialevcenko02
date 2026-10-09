using UnityEngine;
using UnityEngine.UI;

public class _0xcf9e882a : MonoBehaviour
{
    public Button Button;
    private void Start()
    {
        if (this.IsShowLastPop)
            this.Button.onClick.AddListener(() =>
            {
                _0xad9ed8e9.Instance._0x2f9bbe27();
            });
        else if (this.IsHideAllPops)
            this.Button.onClick.AddListener(() => _0xad9ed8e9.Instance._0xad2ed0f3());
        else
            this.Button.onClick.AddListener(() => _0xad9ed8e9.Instance._0x8f7cb98f(this.PopToShowIndex));
    }

    public int PopToShowIndex;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public bool IsShowLastPop;
    public bool IsHideAllPops;
}