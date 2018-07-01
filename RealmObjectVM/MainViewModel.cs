using Realms;
using System;
using System.Collections.Generic;
using System.Text;

namespace RealmObjectVM
{
    public class MainViewModel : RealmObject
    {
        public MainViewModel()
        {
            Title = "コンストラクタで設定したタイトル";
            Description = "コンストラクタで設定した説明文";
            Name = "";
            NameHeader = "お名前";
            NameError = null;
            SystemError = null;
            LabelCommit = "実行ボタン";
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string NameHeader { get; set; }
        public string NameError { get; set; }
        public string SystemError { get; set; }

        public string LabelCommit { get; set; }

        public void CommandCommit()
        {
            System.Diagnostics.Debug.WriteLine($"CommandCommit {Name}.");
        }
    }
}
