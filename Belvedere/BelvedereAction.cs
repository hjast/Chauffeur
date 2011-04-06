using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Belvedere
{
    public class BelvedereAction
    {
        public Delegate action;
        public Panel actionPanel;
        public int args;

        public BelvedereAction(Delegate del)
        {
            action = del;
            args = action.Method.GetParameters().Length;
        }

      
        public void testing(BelvedereAction ba)
        {
            /*
            ba.action.DynamicInvoke
            */
        }

    }

    public class BelvedereActionFactory
    {
         public static BelvedereAction getMoveAction()
        {
            Action<Folder, string> move = new Action<Folder, string>(delegate(Folder f, string pathToMove) { moveTo(f, pathToMove); });
            Action<Folder, string> rename = new Action<Folder, string>(delegate(Folder f, string pathToMove) { rename(f, pathToMove); });
            Action<Folder> delete = new Action<Folder>(delegate(Folder f) { deleteFile(f); });
            return new BelvedereAction(move);
        }

        public static BelvedereAction get
        }
}
