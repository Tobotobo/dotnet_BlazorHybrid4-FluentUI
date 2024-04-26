# dotnet_BlazorHybrid4

[Microsoft Fluent UI Blazor components](https://github.com/microsoft/fluentui-blazor)

```
dotnet add ./BlazorHybrid.View package Microsoft.FluentUI.AspNetCore.Components
dotnet add ./BlazorHybrid.View package Microsoft.FluentUI.AspNetCore.Components.Icons
dotnet add ./BlazorHybrid.View package Microsoft.FluentUI.AspNetCore.Components.Emoji
```


## 概要
* 試行錯誤中
* ベース: [dotnet_BlazorHybrid3](https://github.com/Tobotobo/dotnet_BlazorHybrid3)
* 以下のエラーが取れないので（というか既知の不具合なのに修正されない）、WPFはあきらめてFormsに変更
  [[WPF] VSCode が WPF プロジェクトのエラーを表示します:「名前 'InitializeComponent' が現在のコンテキストに存在しません (Roslyn CS0103)」 #5958](https://github.com/dotnet/vscode-csharp/issues/5958)
* F5 でデバッグ実行可能に

## 参考サイト
感謝！
* [ねこじょーかー/Blazor HybridとBlazor Web AppのUIをRCLで共通化する手順](https://blazor-master.com/blazor-hybrid-maui-rcl/)
* [nekojoker/BlazorHybrid](https://github.com/nekojoker/BlazorHybrid)
    > .NET MAUI Blazor アプリと Blazor Web App の Razor コンポーネントや静的資産を Razor クラスライブラリで共通化したプロジェクトです。  
    > .NET 8 に対応しています。

## 環境
```
> dotnet --info   
.NET SDK:
 Version:           8.0.204   
 Commit:            c338c7548c
 Workload version:  8.0.200-manifests.c4df6daf

ランタイム環境:
 OS Name:     Windows
 OS Version:  10.0.19045
 OS Platform: Windows
 RID:         win-x64
 Base Path:   C:\Program Files\dotnet\sdk\8.0.204\
```

## 詳細

### watch 実行　※ Web
* `Ctrl + Shift + B` またはタスクから `watch` を実行

### publish 実行　※ Forms の exe 作成
* タスクから `publish` を実行
* ルートに publish フォルダが生成される