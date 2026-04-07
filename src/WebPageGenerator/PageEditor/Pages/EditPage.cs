using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageEditor.Pages
{
    public abstract class EditPage : UserControl
    {
        protected bool IsChange = false;
        protected abstract void DoInituializeData();
        protected abstract void DoLoadData(StreamReader sr);
        protected abstract void DoSaveData(StreamWriter sw);

        public void LoadData(string filePath)
        {
            if (File.Exists(filePath))
            {
                using StreamReader sr = new(filePath);
                DoLoadData(sr);
            }
            else
            {
                // 必ずデータを保存する
                IsChange = true;
                DoInituializeData();
            }
        }

        public void SaveData(string filePath, bool discard = false)
        {
            if (discard || !IsChange) return;
            using StreamWriter sw = new(filePath);

            DoSaveData(sw);
        }
    }
}
