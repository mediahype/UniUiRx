using System.Collections.Generic;
using UniRx;

namespace UniUiRx {
    public class Parent : Node {


        private ReactiveCollection<Node> children = new ();

        public ReactiveCollection<Node> GetChildren() {
            return children;
        }
        
    }
}