# RealmObjectVM

RealmObjectでViewModelの実装を検討する。

# History

## ViewModel : RealmObject

        public string Name { get; set; }

とするとsetでトランザクションが無いので落ちる。
getは普通に動く。

バックストアのprivateをここで作ると
privateとpublicで別の名前になって矛盾する。

ここから導き出されるのはバックストアをRealmで作って、
バックストアをインスタンスで持つViewModelを
RealmObjectではないクラスで作るということ。
良いことがほとんどない。

## InstanceState : RealmObject

BizLogicで必要とする不揮発可変データをRealmにもつ。
ViewModelは従来通り作ってTwoWay/OneWayデータは、
バックストアをRealm参照する。
トランザクションはここで作る。

RealmからのイベントはViewModelで終端して、
ViewModelのイベントに変換してInvokeする。
面倒になっただけで苦労が報われない。

エントリーシートみたいな
ページ単位でコミットできるアプリなら、
コミット時にRealm保存で分離できる。
これは完全に今までのスタイルの永続化置き換え。
こっちのほうがまだわかりやすい。

検索アプリのような
リアルタイムで永続化したいアプリの場合は、
ViewModel:RealmObject型を基本にして、
文字入力は別に作るのが良さそう。
入力完了時点でCommand契機でRealmに保存すると
履歴は残せる。
