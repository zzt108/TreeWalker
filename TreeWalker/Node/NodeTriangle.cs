using System.Collections.Generic;

namespace TreeWalker.Node
{
    /// <summary>
    /// A representation of the input data for the app
    /// </summary>
    public class NodeTriangle : List<NodeLevel>
    {
        public NodeTriangle(IReadOnlyCollection<NodeLevel> levels)
        {
            if (levels != null)
            {
                AddRange(levels);
                HookUpData();
            }
        }

        /// <summary>
        /// Links child nodes to their parent nodes
        /// </summary>
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