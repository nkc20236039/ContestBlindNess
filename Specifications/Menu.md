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
- [エコー](/Specifications/Echo.md)

## デバッグ
- プレイヤーの速度をデバッグ用ウィンドウに表示する(単位：m/s)※
- ダッシュ制限を無効化する機能を実装し、切り替えられるようにする
- ダッシュ無制限の場合、さらに次のことをデバッグ用ウィンドウに表示する※
    - 本来ならスタミナがどれだけ残っているかの数値(現在値/最大値)
    - ダッシュが可能かどうか(true | false)

※ 選択中のみ表示

</details>

# 敵
<details>

## 概要
通常は特定のポイントを徘徊し、音を感じたらそこへ向かう。
プレイヤーの脅威となる存在

## 目次
- [通常時AI](/Specifications/Enemy/DefaultAI.md)
- [追跡時AI](/Specifications/Enemy/trackingAI.md)

## デバッグ


</details>


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

# アイテム
<details>

## 概要
ステージ内には**拾うことができる**オブジェクトが存在する。
使用用途については、誘導に使うものやギミックのクリアに必要なものなど様々。

### 目次
 - [アイテムを拾う](/Specifications/Item/PickUpItem.md)
 - [投擲物](/Specifications/Item/ThrowingObject.md)

</details>



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
