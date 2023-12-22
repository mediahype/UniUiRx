using TMPro;
using UnityEngine;

namespace UniUiRx {
    
    [RequireComponent(typeof(TextMeshProUGUI))]
    public class Labeled : Control {

        protected TextMeshProUGUI TextMesh() {
            return GetComponent<TextMeshProUGUI>();
        }
        
    }
}