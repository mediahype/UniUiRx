using System;
using UnityEngine;

namespace UniUiRx {
    
    // TODO: disallow on 3D Objects
    [RequireComponent(typeof(RectTransform))]
    public class Node : MonoBehaviour {


        protected RectTransform RectTransform() {
            return GetComponent<RectTransform>();    
        }

        /// <summary>
        /// add me to the given parent as a child
        /// </summary>
        /// <param name="parent"></param>
        /// <returns></returns>
        public Node WithParent(Pane parent) {
            transform.SetParent(parent.transform, false);
            parent.GetChildren().Add(this);
            return this;
        }

    }
}