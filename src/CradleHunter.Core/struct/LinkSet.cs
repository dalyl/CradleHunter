using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CradleHunter.Core
{
    /// <summary>
    /// 链式集合
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinkSet<T>
    {
 
        public int Level { get; private set; }

        public LinkSet(T node)
        {
            Node = node;
            Level = 0;
        }

        public LinkSet(LinkSet<T> last, T node)
        {
            LastSet = last;
            Node = node;
            Level = last.Level + 1;
        }

        public T Node { get; private set; }

        public T LastNode { get { if (LastSet == null) return default(T); return LastSet.Node; } }

        public T NextNode { get { if (NextSet == null) return default(T); return NextSet.Node; } }

        public LinkSetCollection<T> Next { get; set; }

        public LinkSet<T> NextSet
        {
            get
            {
                if (Level == 0) return null;
                return Next == null ? null : Next.First();
            }
        }

        public LinkSet<T> LastSet { get; private set; }

        public void Add(T node)
        {
            if (Next == null) Next = new LinkSetCollection<T>(this);
            Next.Add(node);
        }
    }

    public class LinkSetCollection<T> : List<LinkSet<T>>
    {
        public LinkSet<T> LastSet { get; private set; }

        public int Level { get; private set; }

        public LinkSetCollection(LinkSet<T> last)
        {
            LastSet = last;
            Level = last.Level + 1;
        }

        public new void Add(LinkSet<T> model)
        {
            if (model.LastSet == this.LastSet)
            {
                base.Add(model);
            }
        }

        public void Add(T node)
        {
            base.Add(new LinkSet<T>(this.LastSet, node));
        }
    }

}
