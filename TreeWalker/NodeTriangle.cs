using System.Collections.Generic;

namespace TreeWalker
{
    public class NodeTriangle : List<NodeLevel>
    {
        public NodeTriangle(List<NodeLevel> levels)
        {
            if (levels != null)
            {
                AddRange(levels);
                HookUpData();
            }
        }

        private void HookUpData()
        {
            Node[] prevLevel = null;
            foreach (var level in this)
            {

                if (prevLevel != null)
                {
                    var thisLevel = level.ToArray();
                    for (var i = 0; i < prevLevel.Length; i++)
                    {
                        prevLevel[i].Children[0] = thisLevel[i];
                        prevLevel[i].Children[1] = thisLevel[i+1];
                    }
                }

                prevLevel = level.ToArray();
            }
        }

    }
}