# ダッシュ

# 基本挙動

1. 徐々にスタミナを減らし、スタミナがなくなったらダッシュ不可能にする。
2. スタミナはダッシュしていなければ徐々に回復する。
3. スタミナを最後まで使い切った場合は、最大値に回復するまでダッシュ不可とする。
4. スタミナがない状態でダッシュをしようとした場合、**疲労状態**の動きをする。
4. 最後まで使いきった場合(クールダウン中)のスタミナ回復速度は通常の回復速度よりも早くする。

# パラメーター
|項目|変数型|単位|
|-|-|-|
|ダッシュ移動速度|float|m/s|
|スタミナの消費速度|float|m/s|
|通常時のスタミナの回復速度|float|m/s|
|クールダウン中の消費速度|float|m/s|
|スタミナの最大値|float|-|