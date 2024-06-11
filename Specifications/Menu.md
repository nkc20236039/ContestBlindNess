# プレイヤー
<details>

## デフォルトキーコンフィグ
|行動|キー|
|-|-|
|移動|W A S D|
|走り|LShift|
|エコーロケーション|左クリック|
|アクション|E|
|メニュー|Escape(esc)|

## 目次
- [歩き](/Specifications/Player/Walk.md)
- [走り](/Specifications/Player/Dash.md)
- [視点操作](/Specifications/Player/View.md)
- [アクション](/Specifications/Player/Action.md)
- [手の動作](/Specifications/Player/Hand.md)
- [エコー](/Specifications/Player/Echo.md)
- [疲労](/Specifications/Player/Tired.md)

## デバッグ
デバッグウィンドウはオブジェクト選択中に表示する
|項目|表示場所|表示条件|表示形式|
|-|-|-|-|
|プレイヤーの現在速度|デバッグウィンドウ|選択中常に|{速度パラメータ}m/s|
|ダッシュ無制限化|デバッグウィンドウ|選択中常に|チェックボックス(デフォルト無効)|
|本来ならダッシュ可能か|デバッグウィンドウ|ダッシュ無制限が有効時|true \| false|
|本来のスタミナ消費量|デバッグウィンドウ|ダッシュ無制限が有効時|{スタミナパラメータ}|

</details>
<br/>

# 敵
<details>

## 概要
通常は特定のポイントを徘徊し、音を感じたらそこへ向かう。
プレイヤーの脅威となる存在

## 目次
- [通常時AI](/Specifications/Enemy/DefaultAI.md)
- [追跡時AI](/Specifications/Enemy/trackingAI.md)

## デバッグ
デバッグウィンドウはオブジェクト選択中に表示する
|項目|表示場所|表示条件|表示形式|
|-|-|-|-|
|敵の現在速度|デバッグウィンドウ|選択中常に|{速度パラメータ}m/s|
|待機中の時間|デバッグウィンドウ|選択中常に|移動中 \| {待機時間}s|
|現在の状態|デバッグウィンドウ|選択中常に|通常 \| 追跡|
|シーンビューにギズモを表示|デバッグウィンドウ|選択中常に|チェックボックス(デフォルト有効)|
|目的地|シーンビュー|オブジェクト選択中 & ギズモを表示項目が有効|1m程度のsphereギズモ(青)|
|敵自身と目的地を繋ぐ線|シーンビュー|オブジェクト選択中 & ギズモを表示項目が有効|lineギズモ(黄)|

</details>
<br/>

# UI
<details>

## 概要
ユーザーへの情報を視覚的に伝える。アクション時や照準、メニュー画面など。

## 目次
### メニューUI
- [メニュー画面](/Specifications/UI/MenuUI/MenuDisplay.md)
  - [ゲームに戻る](/Specifications/UI/MenuUI/ReturnGame.md)
  - [リスタート](/Specifications/UI/MenuUI/ReStart.md)
  - [オプション](/Specifications/UI/MenuUI/Option.md)
  - [タイトルに戻る](/Specifications/UI/MenuUI/ReturnTitle.md)

### プレイヤーUI
- [ダッシュゲージ](/Specifications/UI/PlayerUI/DashGage.md)
- [アクションガイド](/Specifications/UI/PlayerUI/ActionGuide.md)
- [照準](/Specifications/UI/PlayerUI/CrossHair.md)

</details>
<br/>

# アイテム
<details>

## 概要
ステージ内には**拾うことができる**オブジェクトが存在する。
使用用途については、誘導に使うものやギミックのクリアに必要なものなど様々。

### 目次
 - [アイテムを拾う](/Specifications/Item/PickUpItem.md)
 - [投擲物](/Specifications/Item/ThrowingObject.md)

</details>
<br/>

# タスク
<details>

## 概要
ゲームのクリアに必要なタスク。これをクリアすることでゲートが開き先に進めるようになる。
基本的にすでにギミックの役割を終えたものにはアクション出来なくすること。
なお、タスクの種類はステージによって異なる。内容は以下を参照。

### 目次
 - [タスク１:フィット](/Specifications/Task/Task1_Fit.md)
 - [タスク２:ターン](/Specifications/Task/Task2_Turn.md)

</details>
<br/>

# その他
<details>

### 目次
 - [セーブとロード](/Specifications/Save&Load.md)
 - [ゲームフロー](/Specifications/GameFlow.md)
 - [シチュエーション](/Specifications/Situation/Situation.md)

</details>
<br/>