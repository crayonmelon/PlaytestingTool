%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!114 &1
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 12004, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_PixelRect:
    serializedVersion: 2
    x: 0
    y: 43
    width: 1920
    height: 1007
  m_ShowMode: 4
  m_Title: Time Line Visualiser
  m_RootView: {fileID: 7}
  m_MinSize: {x: 875, y: 392}
  m_MaxSize: {x: 10000, y: 10000}
  m_Maximized: 1
--- !u!114 &2
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 12006, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: TimeLineWindow
  m_EditorClassIdentifier: 
  m_Children: []
  m_Position:
    serializedVersion: 2
    x: 982
    y: 0
    width: 938
    height: 447
  m_MinSize: {x: 101, y: 121}
  m_MaxSize: {x: 4001, y: 4021}
  m_ActualView: {fileID: 16}
  m_Panes:
  - {fileID: 16}
  m_Selected: 0
  m_LastSelected: 0
--- !u!114 &3
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 12006, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: PathVisualiserWindow
  m_EditorClassIdentifier: 
  m_Children: []
  m_Position:
    serializedVersion: 2
    x: 306
    y: 0
    width: 346
    height: 447
  m_MinSize: {x: 102, y: 121}
  m_MaxSize: {x: 4002, y: 4021}
  m_ActualView: {fileID: 18}
  m_Panes:
  - {fileID: 18}
  m_Selected: 0
  m_LastSelected: 0
--- !u!114 &4
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 12006, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: HeatMapWindow
  m_EditorClassIdentifier: 
  m_Children: []
  m_Position:
    serializedVersion: 2
    x: 652
    y: 0
    width: 330
    height: 447
  m_MinSize: {x: 102, y: 121}
  m_MaxSize: {x: 4002, y: 4021}
  m_ActualView: {fileID: 17}
  m_Panes:
  - {fileID: 17}
  m_Selected: 0
  m_LastSelected: 0
--- !u!114 &5
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 12010, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Children:
  - {fileID: 15}
  - {fileID: 3}
  - {fileID: 4}
  - {fileID: 2}
  m_Position:
    serializedVersion: 2
    x: 0
    y: 510
    width: 1920
    height: 447
  m_MinSize: {x: 406, y: 121}
  m_MaxSize: {x: 16006, y: 4021}
  vertical: 0
  controlID: 686
--- !u!114 &6
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 12010, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Children: []
  m_Position:
    serializedVersion: 2
    x: 0
    y: 0
    width: 100
    height: 127
  m_MinSize: {x: 0, y: 0}
  m_MaxSize: {x: 0, y: 0}
  vertical: 0
  controlID: 667
--- !u!114 &7
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12008, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Children:
  - {fileID: 8}
  - {fileID: 10}
  - {fileID: 9}
  m_Position:
    serializedVersion: 2
    x: 0
    y: 0
    width: 1920
    height: 1007
  m_MinSize: {x: 875, y: 392}
  m_MaxSize: {x: 10000, y: 10000}
  m_UseTopView: 1
  m_TopViewHeight: 30
  m_UseBottomView: 1
  m_BottomViewHeight: 20
--- !u!114 &8
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12011, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Children: []
  m_Position:
    serializedVersion: 2
    x: 0
    y: 0
    width: 1920
    height: 30
  m_MinSize: {x: 0, y: 0}
  m_MaxSize: {x: 0, y: 0}
  m_LoadedToolbars:
  - {fileID: 29}
  m_MainToolbar: {fileID: 29}
  m_LastLoadedLayoutName: PlaytestingTool
--- !u!114 &9
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12042, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Children: []
  m_Position:
    serializedVersion: 2
    x: 0
    y: 987
    width: 1920
    height: 20
  m_MinSize: {x: 0, y: 0}
  m_MaxSize: {x: 0, y: 0}
--- !u!114 &10
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 12010, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Children:
  - {fileID: 11}
  - {fileID: 5}
  m_Position:
    serializedVersion: 2
    x: 0
    y: 30
    width: 1920
    height: 957
  m_MinSize: {x: 504, y: 342}
  m_MaxSize: {x: 16006, y: 8042}
  vertical: 1
  controlID: 722
--- !u!114 &11
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12010, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Children:
  - {fileID: 12}
  - {fileID: 13}
  - {fileID: 14}
  m_Position:
    serializedVersion: 2
    x: 0
    y: 0
    width: 1920
    height: 510
  m_MinSize: {x: 504, y: 221}
  m_MaxSize: {x: 12004, y: 4021}
  vertical: 0
  controlID: 723
--- !u!114 &12
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12006, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_Children: []
  m_Position:
    serializedVersion: 2
    x: 0
    y: 0
    width: 248
    height: 510
  m_MinSize: {x: 201, y: 221}
  m_MaxSize: {x: 4001, y: 4021}
  m_ActualView: {fileID: 21}
  m_Panes:
  - {fileID: 21}
  m_Selected: 0
  m_LastSelected: 0
--- !u!114 &13
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12006, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: SceneView
  m_EditorClassIdentifier: 
  m_Children: []
  m_Position:
    serializedVersion: 2
    x: 248
    y: 0
    width: 1259
    height: 510
  m_MinSize: {x: 202, y: 221}
  m_MaxSize: {x: 4002, y: 4021}
  m_ActualView: {fileID: 20}
  m_Panes:
  - {fileID: 22}
  - {fileID: 20}
  m_Selected: 1
  m_LastSelected: 0
--- !u!114 &14
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 12006, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: SettingsWindow
  m_EditorClassIdentifier: 
  m_Children: []
  m_Position:
    serializedVersion: 2
    x: 1507
    y: 0
    width: 413
    height: 510
  m_MinSize: {x: 101, y: 121}
  m_MaxSize: {x: 4001, y: 4021}
  m_ActualView: {fileID: 23}
  m_Panes:
  - {fileID: 23}
  - {fileID: 24}
  - {fileID: 25}
  m_Selected: 0
  m_LastSelected: 1
--- !u!114 &15
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12006, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: VisualiseMenuWindow
  m_EditorClassIdentifier: 
  m_Children: []
  m_Position:
    serializedVersion: 2
    x: 0
    y: 0
    width: 306
    height: 447
  m_MinSize: {x: 101, y: 121}
  m_MaxSize: {x: 4001, y: 4021}
  m_ActualView: {fileID: 19}
  m_Panes:
  - {fileID: 19}
  - {fileID: 26}
  - {fileID: 27}
  - {fileID: 28}
  m_Selected: 0
  m_LastSelected: 0
--- !u!114 &16
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: e0c300c0872644e49b002ae28b5b1136, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_MinSize: {x: 100, y: 100}
  m_MaxSize: {x: 4000, y: 4000}
  m_TitleContent:
    m_Text: Time Line Visualiser
    m_Image: {fileID: 0}
    m_Tooltip: 
  m_Pos:
    serializedVersion: 2
    x: 982
    y: 583
    width: 937
    height: 426
  m_ViewDataDictionary: {fileID: 0}
--- !u!114 &17
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 6afc53fa7aeab714195699563d779eb0, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_MinSize: {x: 100, y: 100}
  m_MaxSize: {x: 4000, y: 4000}
  m_TitleContent:
    m_Text: HeatMap Visualiser
    m_Image: {fileID: 0}
    m_Tooltip: 
  m_Pos:
    serializedVersion: 2
    x: 652
    y: 583
    width: 328
    height: 426
  m_ViewDataDictionary: {fileID: 0}
--- !u!114 &18
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: 8cfe816ae18be464b9f0308f69649fc1, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_MinSize: {x: 100, y: 100}
  m_MaxSize: {x: 4000, y: 4000}
  m_TitleContent:
    m_Text: Path Visualiser
    m_Image: {fileID: 0}
    m_Tooltip: 
  m_Pos:
    serializedVersion: 2
    x: 306
    y: 583
    width: 344
    height: 426
  m_ViewDataDictionary: {fileID: 0}
  ChosenSessionData:
  - _id: 
    SceneName: SampleScene 1
    UniqueID: 
    objectName: progressionData
    sessionName: b86a0693-67dd-4cf4-85fa-b29c7474e89f
    dateCreated: 11-03-22
    trackedPositions: []
    trackedProgressions:
    - timeStamp: 37.4327
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 2.171386
        y: 1.268135
        z: 29.031633
    - timeStamp: 13.585
      eventName: Player Won
      value: 
      trackedPosition:
        x: 19.160492
        y: 0.471471
        z: -99.789536
    - timeStamp: 73.6396
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -57.757977
        y: 1.201236
        z: 73.54202
    - timeStamp: 36.9416
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 19.011547
        y: 1.360896
        z: 72.77627
    - timeStamp: 20.6419
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -1.607487
        y: 1.842236
        z: 68.14566
    - timeStamp: 62.9678
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 54.488922
        y: 0.920854
        z: 3.257806
    - timeStamp: 81.7911
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -61.69785
        y: 1.054793
        z: 47.4194
    - timeStamp: 28.0346
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -57.62903
        y: 0.530536
        z: -45.42235
    - timeStamp: 43.743
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 33.985985
        y: 0.476473
        z: 18.44149
    - timeStamp: 22.7373
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 89.674965
        y: 1.892715
        z: 61.393925
    - timeStamp: 9.8968
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 25.486267
        y: 2.728803
        z: 17.781582
    - timeStamp: 14.8447
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -70.688484
        y: 0.637855
        z: -35.27025
    - timeStamp: 69.6299
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -91.74513
        y: 2.559627
        z: 96.234795
    - timeStamp: 36.5068
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 42.41945
        y: 1.233031
        z: -72.33325
    - timeStamp: 1.9126
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -27.792
        y: 0.938267
        z: 45.66721
    - timeStamp: 78.3606
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 64.08473
        y: 3.385415
        z: -18.609297
    - timeStamp: 75.3839
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -98.73923
        y: 3.360809
        z: -54.829575
    - timeStamp: 60.5785
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -18.700127
        y: 2.848525
        z: 77.44229
    - timeStamp: 67.9723
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -62.84854
        y: 2.969944
        z: 72.402596
    - timeStamp: 41.97
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 51.57217
        y: 2.76109
        z: 3.260874
    - timeStamp: 31.5482
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 71.55962
        y: 1.642045
        z: 1.76306
    - timeStamp: 17.6016
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -89.135284
        y: 0.805412
        z: 49.192024
    - timeStamp: 72.5498
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 97.814
        y: 3.999085
        z: -1.061658
    - timeStamp: 17.8575
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 14.104497
        y: 0.957218
        z: -65.16018
    - timeStamp: 19.3133
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 87.102066
        y: 1.389114
        z: 90.58217
    - timeStamp: 81.2674
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 15.926204
        y: 0.723408
        z: -91.392784
    - timeStamp: 47.9573
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 29.271425
        y: 2.223989
        z: 5.212317
    - timeStamp: 39.5043
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -32.97972
        y: 0.526227
        z: -54.572304
    - timeStamp: 71.8655
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -19.219963
        y: 3.139622
        z: 98.8644
    - timeStamp: 58.2451
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -63.860123
        y: 2.149213
        z: 93.64403
    - timeStamp: 15.1727
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -93.43065
        y: 3.167376
        z: -67.646515
    - timeStamp: 39.0934
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 36.66538
        y: 0.153553
        z: 80.99629
    - timeStamp: 89.2499
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 77.650536
        y: 0.296466
        z: -71.34496
    - timeStamp: 18.7046
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 24.272802
        y: 0.608775
        z: 77.03236
    - timeStamp: 52.8787
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -46.086277
        y: 2.609116
        z: 88.72125
    - timeStamp: 80.8721
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 26.944786
        y: 1.191582
        z: 78.88813
    - timeStamp: 8.2083
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 34.60676
        y: 2.343813
        z: -38.02527
    - timeStamp: 6.6592
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -74.06198
        y: 0.909845
        z: 38.14565
    - timeStamp: 30.0349
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -79.29541
        y: 2.121116
        z: 99.95733
    - timeStamp: 70.2982
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 99.62095
        y: 1.125696
        z: 64.39764
    - timeStamp: 50.1252
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -64.83038
        y: 2.00774
        z: 0.670352
    - timeStamp: 56.1103
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 46.524014
        y: 1.306814
        z: 82.59343
    - timeStamp: 65.7446
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -89.88934
        y: 0.277714
        z: -49.047424
    - timeStamp: 69.6858
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 7.6775
        y: 0.912558
        z: -7.475725
    - timeStamp: 4.099
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -56.523594
        y: 0.001669
        z: -79.87823
    - timeStamp: 3.4145
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -7.289581
        y: 0.547265
        z: 54.18419
    - timeStamp: 73.6051
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 9.358245
        y: 2.4424
        z: 70.54691
    - timeStamp: 28.6701
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 22.118305
        y: 0.483239
        z: 1.331413
    - timeStamp: 27.5212
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -45.05228
        y: 1.668429
        z: 11.741944
    - timeStamp: 51.6937
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -16.147993
        y: 2.973285
        z: 50.088142
    - timeStamp: 60.4517
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 39.617123
        y: 3.258917
        z: 52.424538
    - timeStamp: 17.2357
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 71.24774
        y: 1.15228
        z: -40.406837
    - timeStamp: 11.7605
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 28.786032
        y: 1.639374
        z: -53.206043
    - timeStamp: 80.2657
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 4.957372
        y: 0.947717
        z: 91.9394
    - timeStamp: 36.1034
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -22.222364
        y: 1.491084
        z: -10.794146
    - timeStamp: 5.5794
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 72.4533
        y: 0.140498
        z: -21.18617
    - timeStamp: 39.9432
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -19.094746
        y: 3.156498
        z: -53.419388
    - timeStamp: 27.3273
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -30.57187
        y: 3.066525
        z: -41.860207
    - timeStamp: 78.3256
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 47.090275
        y: 0.433942
        z: -71.630875
    - timeStamp: 68.0652
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 3.167822
        y: 3.948731
        z: -30.6791
    - timeStamp: 75.2919
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 61.964493
        y: 2.383672
        z: 48.687737
    - timeStamp: 76.3119
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 73.38931
        y: 1.143483
        z: -77.02701
    - timeStamp: 39.2156
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -44.28858
        y: 0.998024
        z: -50.22009
    - timeStamp: 19.5599
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 59.127106
        y: 3.908747
        z: 77.7774
    - timeStamp: 83.7564
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -5.911663
        y: 2.797946
        z: 65.981804
    - timeStamp: 10.329
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 27.024937
        y: 3.447119
        z: -55.41743
    - timeStamp: 80.1964
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -74.98061
        y: 1.506253
        z: 7.268056
    - timeStamp: 3.3673
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -64.9861
        y: 0.975512
        z: 84.960884
    - timeStamp: 27.8965
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -66.48708
        y: 0.434632
        z: -14.006819
    - timeStamp: 44.7765
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 22.269873
        y: 2.6274
        z: -1.842808
    - timeStamp: 51.6049
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 74.63858
        y: 1.286491
        z: -27.342579
    - timeStamp: 45.7589
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 91.61862
        y: 1.999034
        z: 79.53571
    - timeStamp: 51.5864
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -57.79485
        y: 0.880584
        z: 15.022655
    - timeStamp: 7.3223
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 66.1172
        y: 2.76834
        z: -20.469831
    - timeStamp: 3.7971
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -54.727345
        y: 2.860429
        z: 19.1232
    - timeStamp: 58.2691
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -62.32057
        y: 1.25686
        z: 89.01795
    - timeStamp: 36.8727
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 71.868904
        y: 0.918446
        z: 9.393019
    - timeStamp: 65.6993
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 72.60432
        y: 0.978871
        z: -65.5658
    - timeStamp: 56.6475
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 60.098267
        y: 2.407209
        z: 72.53126
    - timeStamp: 1.0444
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 63.654274
        y: 1.073083
        z: -59.270454
    - timeStamp: 75.9644
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 22.69465
        y: 1.253981
        z: -16.877722
    - timeStamp: 58.4111
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -61.160667
        y: 0.215383
        z: 29.284674
    - timeStamp: 63.9583
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -51.836914
        y: 2.512039
        z: 60.710102
    - timeStamp: 2.2108
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -66.20023
        y: 2.209782
        z: 1.9434
    - timeStamp: 3.8954
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -15.757656
        y: 1.751189
        z: -76.63476
    - timeStamp: 77.2811
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -29.062437
        y: 0.609645
        z: 2.348901
    - timeStamp: 25.6483
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -81.1963
        y: 2.266
        z: -17.95549
    - timeStamp: 55.8966
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -44.271008
        y: 0.601004
        z: 31.881285
    - timeStamp: 70.8447
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -72.887
        y: 3.536996
        z: -59.416218
    - timeStamp: 86.5901
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 14.439392
        y: 0.953077
        z: 32.554607
    - timeStamp: 41.4245
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 0.623305
        y: 2.031393
        z: 38.364426
    - timeStamp: 36.9601
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -37.93565
        y: 0.887263
        z: -91.9027
    - timeStamp: 7.6118
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 3.606648
        y: 0.698815
        z: 65.208855
    - timeStamp: 6.7286
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -12.99646
        y: 2.460589
        z: -56.163044
    - timeStamp: 88.8138
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -4.773202
        y: 1.633054
        z: 47.21959
    - timeStamp: 53.4858
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 14.730461
        y: 3.53115
        z: 0.145709
    - timeStamp: 36.4473
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 21.384668
        y: 2.277247
        z: 92.778206
    - timeStamp: 61.6816
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 21.203705
        y: 1.632509
        z: 45.511383
    - timeStamp: 53.8144
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -29.19519
        y: 2.992696
        z: -19.386797
    - timeStamp: 36.3649
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -76.37423
        y: 2.040805
        z: 69.48617
    - timeStamp: 47.3226
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -3.075653
        y: 3.899273
        z: 3.542426
    - timeStamp: 47.6386
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -2.405262
        y: 3.701794
        z: -8.932881
    - timeStamp: 76.0796
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 4.049407
        y: 2.913053
        z: -4.597596
    - timeStamp: 44.6307
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -5.788243
        y: 1.97276
        z: 2.521773
    - timeStamp: 23.5902
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -7.943949
        y: 3.172987
        z: 2.453951
    - timeStamp: 11.23
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -7.932657
        y: 3.909669
        z: 6.320744
    - timeStamp: 27.7151
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -6.257198
        y: 0.162095
        z: 0.787431
    - timeStamp: 73.4005
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 9.390555
        y: 2.147531
        z: 1.081721
    - timeStamp: 80.5284
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -5.972385
        y: 3.462248
        z: 6.299959
    - timeStamp: 43.3963
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 1.074141
        y: 0.037455
        z: 4.766186
    - timeStamp: 59.7533
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -8.356619
        y: 2.707363
        z: -7.143072
    - timeStamp: 19.229
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -2.816087
        y: 3.60074
        z: 6.633365
    - timeStamp: 0.4374
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -1.954733
        y: 1.369828
        z: 3.289735
    - timeStamp: 24.1376
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -3.932089
        y: 3.795719
        z: -8.967024
    - timeStamp: 24.7386
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -1.241063
        y: 0.28274
        z: 5.046168
    - timeStamp: 79.488
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 3.33374
        y: 1.165278
        z: 1.188445
    - timeStamp: 62.7438
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -1.90301
        y: 3.326367
        z: 0.394702
    - timeStamp: 21.6436
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 1.032359
        y: 0.482344
        z: -1.912898
    - timeStamp: 33.0717
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 0.711667
        y: 3.287319
        z: -6.378063
    - timeStamp: 73.5189
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -3.282737
        y: 2.628691
        z: 6.729795
    - timeStamp: 79.3327
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 0.934993
        y: 0.586809
        z: 5.782847
    - timeStamp: 39.263
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -3.776133
        y: 0.799304
        z: -1.494451
    - timeStamp: 66.9281
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 2.290322
        y: 3.483901
        z: -1.452193
    - timeStamp: 54.1157
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 6.47653
        y: 3.839383
        z: -8.62667
    - timeStamp: 51.4239
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -2.029574
        y: 1.224749
        z: -4.363291
    - timeStamp: 0.1959
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -3.533131
        y: 0.843287
        z: -4.809857
    - timeStamp: 14.1055
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 6.662983
        y: 1.806593
        z: 9.480259
    - timeStamp: 85.7709
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -4.066735
        y: 0.119477
        z: 2.075901
    - timeStamp: 33.4977
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -9.253522
        y: 3.969581
        z: 4.892796
    - timeStamp: 1.9084
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 9.766058
        y: 0.465795
        z: 2.469791
    - timeStamp: 2.0619
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -7.441243
        y: 1.617486
        z: -1.878917
    - timeStamp: 54.6232
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 7.883789
        y: 0.813959
        z: 8.40624
    - timeStamp: 62.864
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 0.979797
        y: 3.674482
        z: 2.563786
    - timeStamp: 0.1471
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -2.712316
        y: 0.482136
        z: 2.999959
    - timeStamp: 32.571
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 7.464532
        y: 0.892286
        z: -7.968082
    - timeStamp: 19.7738
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 6.01627
        y: 1.550134
        z: -9.101549
    - timeStamp: 85.2736
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 5.108884
        y: 3.468339
        z: -0.416294
    - timeStamp: 63.4142
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 0.028662
        y: 1.505803
        z: 8.030534
    - timeStamp: 36.8805
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -7.385096
        y: 0.084705
        z: 9.770624
    - timeStamp: 7.1784
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 3.884934
        y: 1.396833
        z: -8.486881
    - timeStamp: 70.8559
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 2.889404
        y: 1.813853
        z: 5.482252
    - timeStamp: 20.9549
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 4.011992
        y: 2.527606
        z: 3.705439
    - timeStamp: 35.5921
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -8.91675
        y: 3.798486
        z: 3.149549
    - timeStamp: 65.3683
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 7.393167
        y: 0.142885
        z: -3.983774
    - timeStamp: 50.7079
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 9.186178
        y: 3.757803
        z: -6.624122
    - timeStamp: 85.9853
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -0.380487
        y: 0.192847
        z: 9.336654
    - timeStamp: 81.7345
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 7.011308
        y: 1.238641
        z: 8.970514
    - timeStamp: 59.6516
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 5.151322
        y: 1.908377
        z: 2.524026
    - timeStamp: 50.8577
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 3.220151
        y: 0.504696
        z: 5.387141
    - timeStamp: 44.5115
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -6.621182
        y: 1.772693
        z: 1.554508
    - timeStamp: 72.0694
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -6.822407
        y: 3.287707
        z: -6.417656
    - timeStamp: 66.2545
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 6.380185
        y: 0.706362
        z: 0.548959
    - timeStamp: 52.9822
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 6.626468
        y: 0.211308
        z: 1.219872
    - timeStamp: 43.7696
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -4.502461
        y: 2.807708
        z: 7.183173
    - timeStamp: 84.9797
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 6.859011
        y: 1.967556
        z: -6.931734
    - timeStamp: 72.0661
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -4.957259
        y: 1.557024
        z: 5.600005
    - timeStamp: 86.1093
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 4.118477
        y: 0.49407
        z: 6.726874
    - timeStamp: 1.3386
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 5.646942
        y: 1.213053
        z: 0.656756
    - timeStamp: 69.8899
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 4.069484
        y: 2.983762
        z: -6.894654
    - timeStamp: 28.5742
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -7.585871
        y: 3.488591
        z: 9.69971
    - timeStamp: 17.0608
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 4.429962
        y: 3.363763
        z: -0.706914
    - timeStamp: 69.7552
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -4.584346
        y: 2.254934
        z: -9.412699
    - timeStamp: 79.9562
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 1.049362
        y: 0.270572
        z: -9.797408
    - timeStamp: 16.5655
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -1.898864
        y: 0.450646
        z: -7.93989
    - timeStamp: 1.9029
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 1.338031
        y: 3.547287
        z: -6.31422
    - timeStamp: 13.1303
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -6.059534
        y: 3.492414
        z: 7.949571
    - timeStamp: 52.7933
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -1.941409
        y: 1.744914
        z: 5.481606
    - timeStamp: 69.7471
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 9.067464
        y: 1.44797
        z: -5.657749
    - timeStamp: 77.6569
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 0.823111
        y: 2.908064
        z: 6.536891
    - timeStamp: 72.4873
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 8.371809
        y: 0.266979
        z: 6.995648
    - timeStamp: 72.2515
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 1.390308
        y: 0.931152
        z: -8.203061
    - timeStamp: 50.4981
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -9.231636
        y: 1.018301
        z: 7.864906
    - timeStamp: 0.8725
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -0.055834
        y: 1.780076
        z: -6.02487
    - timeStamp: 4.1861
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 9.192907
        y: 3.443875
        z: 4.571537
    - timeStamp: 61.8447
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -5.505424
        y: 3.87028
        z: -6.138073
    - timeStamp: 19.8828
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -4.35282
        y: 0.118156
        z: 9.251157
    - timeStamp: 4.5202
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 5.099615
        y: 2.966781
        z: -1.015625
    - timeStamp: 2.8484
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 0.338193
        y: 0.616977
        z: -5.370915
    - timeStamp: 39.0927
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 5.10216
        y: 3.570739
        z: -9.827114
    - timeStamp: 48.513
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -2.711408
        y: 2.60855
        z: 9.964841
    - timeStamp: 69.1982
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -5.614524
        y: 0.714761
        z: 5.268636
    - timeStamp: 65.7318
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -2.021148
        y: 3.993827
        z: -6.352266
    - timeStamp: 43.0804
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -6.747729
        y: 2.711589
        z: -1.731865
    - timeStamp: 21.0436
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -3.850652
        y: 2.809692
        z: 4.157078
    - timeStamp: 82.5214
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 7.639134
        y: 3.831743
        z: -1.604373
    - timeStamp: 57.3496
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 9.879444
        y: 3.534681
        z: 4.258583
    - timeStamp: 87.2473
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -7.077323
        y: 3.012428
        z: 6.206069
    - timeStamp: 59.7714
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -0.149595
        y: 0.385318
        z: 5.596085
    - timeStamp: 69.8662
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -1.008724
        y: 1.150248
        z: -9.745652
    - timeStamp: 39.9425
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 5.279887
        y: 0.70396
        z: -3.947966
    - timeStamp: 17.4603
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 1.021717
        y: 3.768799
        z: -0.375919
    - timeStamp: 20.516
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -9.708499
        y: 1.931558
        z: -3.335389
    - timeStamp: 5.405
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 8.103012
        y: 3.53479
        z: 0.83039
    - timeStamp: 24.3642
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 3.936662
        y: 1.039427
        z: -2.22914
    - timeStamp: 28.5105
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -5.832163
        y: 2.035429
        z: 0.242166
    - timeStamp: 82.9233
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -1.557272
        y: 2.642026
        z: -4.25718
    - timeStamp: 20.6197
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -8.58583
        y: 0.815153
        z: 4.156117
    - timeStamp: 63.959
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 4.132578
        y: 2.202473
        z: 5.416215
    - timeStamp: 49.9812
      eventName: Player Lost
      value: 
      trackedPosition:
        x: 8.723064
        y: 2.316839
        z: -4.037987
    - timeStamp: 60.7788
      eventName: Player Lost
      value: 
      trackedPosition:
        x: -7.054336
        y: 3.095143
        z: -6.981412
    trackedStatChanges: []
  - _id: 
    SceneName: SampleScene 1
    UniqueID: 
    objectName: progressionData
    sessionName: 010581bf-2ab7-4b12-9fbc-e19b861073f3
    dateCreated: 21-03-22
    trackedPositions: []
    trackedProgressions:
    - timeStamp: 2
      eventName: Player Started
      value: 
      trackedPosition:
        x: 9.981329
        y: 1.48
        z: 24.628387
    - timeStamp: 5
      eventName: Player Collected Coin
      value: 
      trackedPosition:
        x: 9.981329
        y: 1.48
        z: 24.628387
    - timeStamp: 8
      eventName: Player Won Level One
      value: 
      trackedPosition:
        x: 9.981329
        y: 1.48
        z: 24.628387
    - timeStamp: 12
      eventName: Player Died
      value: 
      trackedPosition:
        x: 9.981329
        y: 1.48
        z: 24.628387
    trackedStatChanges: []
  - _id: 
    SceneName: SampleScene 1
    UniqueID: 
    objectName: progressionData
    sessionName: 3549e47f-aa6f-44d9-8c1f-1aadc38e18c1
    dateCreated: 21-03-22
    trackedPositions: []
    trackedProgressions:
    - timeStamp: 11.463171
      eventName: Died
      value: 
      trackedPosition:
        x: 11.132016
        y: 1.4799999
        z: -0.41665152
    trackedStatChanges: []
  - _id: 
    SceneName: SampleScene 1
    UniqueID: 
    objectName: FPSController0
    sessionName: 44631b73-67fb-4c90-9aa3-84cd84852045
    dateCreated: 21-03-22
    trackedPositions:
    - trackedPosition:
        x: 10.25
        y: 1.2825398
        z: 45.25
      timeStamp: 2.8534114
    - trackedPosition:
        x: 10.08094
        y: 1.2825398
        z: 44.468067
      timeStamp: 5.0860105
    - trackedPosition:
        x: 10.035803
        y: 1.2825398
        z: 43.479446
      timeStamp: 5.1908827
    - trackedPosition:
        x: 10.263644
        y: 1.2825398
        z: 42.506557
      timeStamp: 5.2927203
    - trackedPosition:
        x: 10.652734
        y: 1.2825398
        z: 41.5868
      timeStamp: 5.395814
    - trackedPosition:
        x: 11.397299
        y: 1.2825398
        z: 40.40149
      timeStamp: 5.521523
    - trackedPosition:
        x: 12.134846
        y: 1.204637
        z: 39.215477
      timeStamp: 5.6657777
    - trackedPosition:
        x: 12.550032
        y: 0.812387
        z: 38.41373
      timeStamp: 5.7645783
    - trackedPosition:
        x: 12.66397
        y: 0.506315
        z: 37.224827
      timeStamp: 5.894704
    - trackedPosition:
        x: 12.444801
        y: -0.08228493
        z: 36.046043
      timeStamp: 6.0159965
    - trackedPosition:
        x: 12.405005
        y: -0.77000004
        z: 34.66449
      timeStamp: 6.149233
    - trackedPosition:
        x: 12.951699
        y: -0.77000004
        z: 33.605186
      timeStamp: 6.2730436
    - trackedPosition:
        x: 13.5521145
        y: -0.77000004
        z: 32.35238
      timeStamp: 6.4022512
    - trackedPosition:
        x: 13.502635
        y: -0.77000004
        z: 31.158749
      timeStamp: 6.5211215
    - trackedPosition:
        x: 13.353625
        y: -0.77000004
        z: 29.968073
      timeStamp: 6.6367264
    - trackedPosition:
        x: 13.216047
        y: 0.31227997
        z: 28.775988
      timeStamp: 6.760991
    - trackedPosition:
        x: 13.093486
        y: 0.99836016
        z: 27.783527
      timeStamp: 6.8761144
    - trackedPosition:
        x: 12.920347
        y: 1.6292565
        z: 26.394611
      timeStamp: 7.005395
    - trackedPosition:
        x: 12.793969
        y: 1.8639529
        z: 25.204731
      timeStamp: 7.1328483
    - trackedPosition:
        x: 12.460406
        y: 1.7806813
        z: 23.853268
      timeStamp: 7.260644
    - trackedPosition:
        x: 12.576558
        y: 1.4857615
        z: 22.862625
      timeStamp: 7.374701
    - trackedPosition:
        x: 12.879122
        y: 1.48
        z: 21.505465
      timeStamp: 7.5004873
    - trackedPosition:
        x: 12.398765
        y: 1.48
        z: 20.417355
      timeStamp: 7.6226187
    - trackedPosition:
        x: 12.015091
        y: 1.48
        z: 19.285069
      timeStamp: 7.743707
    - trackedPosition:
        x: 11.940068
        y: 1.48
        z: 18.089527
      timeStamp: 7.860685
    - trackedPosition:
        x: 11.603513
        y: 1.48
        z: 17.180025
      timeStamp: 7.975033
    - trackedPosition:
        x: 10.510188
        y: 1.48
        z: 16.306797
      timeStamp: 8.098529
    - trackedPosition:
        x: 9.519786
        y: 1.48
        z: 15.629922
      timeStamp: 8.223724
    - trackedPosition:
        x: 8.493348
        y: 1.48
        z: 15.008289
      timeStamp: 8.3479185
    - trackedPosition:
        x: 7.4669113
        y: 1.48
        z: 14.386658
      timeStamp: 8.471351
    - trackedPosition:
        x: 6.37552
        y: 1.48
        z: 13.893229
      timeStamp: 8.590235
    - trackedPosition:
        x: 5.194383
        y: 1.48
        z: 13.708695
      timeStamp: 8.714093
    - trackedPosition:
        x: 4.014145
        y: 1.48
        z: 13.903518
      timeStamp: 8.832634
    - trackedPosition:
        x: 2.848784
        y: 1.48
        z: 14.189757
      timeStamp: 8.960014
    - trackedPosition:
        x: 2.2661035
        y: 1.48
        z: 14.332877
      timeStamp: 9.079098
    - trackedPosition:
        x: 1.7805363
        y: 1.48
        z: 14.452145
      timeStamp: 9.194023
    - trackedPosition:
        x: 1.5863094
        y: 1.4799999
        z: 14.499851
      timeStamp: 9.316557
    - trackedPosition:
        x: 1.4262185
        y: 1.48
        z: 15.056166
      timeStamp: 9.852209
    - trackedPosition:
        x: 1.4694487
        y: 1.48
        z: 15.554292
      timeStamp: 9.951459
    - trackedPosition:
        x: 1.5600816
        y: 1.48
        z: 16.550177
      timeStamp: 10.062384
    - trackedPosition:
        x: 1.6507146
        y: 1.48
        z: 17.54606
      timeStamp: 10.174582
    - trackedPosition:
        x: 1.7594743
        y: 1.48
        z: 18.741121
      timeStamp: 10.294689
    - trackedPosition:
        x: 1.8682339
        y: 1.48
        z: 19.936182
      timeStamp: 10.400208
    - trackedPosition:
        x: 1.9588668
        y: 1.48
        z: 20.932068
      timeStamp: 10.50446
    - trackedPosition:
        x: 2.2209885
        y: 1.48
        z: 21.894835
      timeStamp: 10.605089
    - trackedPosition:
        x: 2.757052
        y: 1.48
        z: 22.732573
      timeStamp: 10.709069
    - trackedPosition:
        x: 3.6583774
        y: 1.48
        z: 23.523088
      timeStamp: 10.829906
    - trackedPosition:
        x: 4.906544
        y: 1.48
        z: 24.14453
      timeStamp: 10.957573
    - trackedPosition:
        x: 5.9944224
        y: 1.48
        z: 24.64349
      timeStamp: 11.079765
    - trackedPosition:
        x: 7.161343
        y: 1.48
        z: 24.67215
      timeStamp: 11.206255
    - trackedPosition:
        x: 8.321034
        y: 1.48
        z: 24.37754
      timeStamp: 11.322203
    - trackedPosition:
        x: 9.312922
        y: 1.4799999
        z: 23.718826
      timeStamp: 11.442534
    - trackedPosition:
        x: 10.012081
        y: 1.4799999
        z: 22.746988
      timeStamp: 11.558935
    - trackedPosition:
        x: 10.78467
        y: 1.4799999
        z: 21.8298
      timeStamp: 11.680868
    - trackedPosition:
        x: 11.756565
        y: 1.48
        z: 21.132307
      timeStamp: 11.797173
    - trackedPosition:
        x: 12.6568
        y: 1.48
        z: 20.698942
      timeStamp: 11.908283
    - trackedPosition:
        x: 13.573169
        y: 1.4799999
        z: 19.930796
      timeStamp: 12.023322
    - trackedPosition:
        x: 14.144528
        y: 1.48
        z: 19.112898
      timeStamp: 12.127321
    - trackedPosition:
        x: 14.329401
        y: 1.48
        z: 18.286413
      timeStamp: 12.2314825
    - trackedPosition:
        x: 14.34136
        y: 1.48
        z: 17.607943
      timeStamp: 12.35959
    - trackedPosition:
        x: 13.768875
        y: 1.48
        z: 17.38431
      timeStamp: 12.476192
    - trackedPosition:
        x: 12.559385
        y: 1.48
        z: 18.074474
      timeStamp: 12.606806
    - trackedPosition:
        x: 11.579336
        y: 1.48
        z: 18.264
      timeStamp: 12.72081
    - trackedPosition:
        x: 10.984008
        y: 1.48
        z: 18.323475
      timeStamp: 12.84789
    trackedProgressions: []
    trackedStatChanges: []
  - _id: 
    SceneName: SampleScene 1
    UniqueID: 
    objectName: progressionData
    sessionName: 44631b73-67fb-4c90-9aa3-84cd84852045
    dateCreated: 21-03-22
    trackedPositions: []
    trackedProgressions:
    - timeStamp: 12.881693
      eventName: Died
      value: 
      trackedPosition:
        x: 10.793938
        y: 1.48
        z: 18.385714
    trackedStatChanges: []
  - _id: 
    SceneName: SampleScene 1
    UniqueID: 
    objectName: FPSController0
    sessionName: 44631b73-67fb-4c90-9aa3-84cd84852045
    dateCreated: 21-03-22
    trackedPositions:
    - trackedPosition:
        x: 10.25
        y: 1.2825398
        z: 45.25
      timeStamp: 2.8534114
    - trackedPosition:
        x: 10.08094
        y: 1.2825398
        z: 44.468067
      timeStamp: 5.0860105
    - trackedPosition:
        x: 10.035803
        y: 1.2825398
        z: 43.479446
      timeStamp: 5.1908827
    - trackedPosition:
        x: 10.263644
        y: 1.2825398
        z: 42.506557
      timeStamp: 5.2927203
    - trackedPosition:
        x: 10.652734
        y: 1.2825398
        z: 41.5868
      timeStamp: 5.395814
    - trackedPosition:
        x: 11.397299
        y: 1.2825398
        z: 40.40149
      timeStamp: 5.521523
    - trackedPosition:
        x: 12.134846
        y: 1.204637
        z: 39.215477
      timeStamp: 5.6657777
    - trackedPosition:
        x: 12.550032
        y: 0.812387
        z: 38.41373
      timeStamp: 5.7645783
    - trackedPosition:
        x: 12.66397
        y: 0.506315
        z: 37.224827
      timeStamp: 5.894704
    - trackedPosition:
        x: 12.444801
        y: -0.08228493
        z: 36.046043
      timeStamp: 6.0159965
    - trackedPosition:
        x: 12.405005
        y: -0.77000004
        z: 34.66449
      timeStamp: 6.149233
    - trackedPosition:
        x: 12.951699
        y: -0.77000004
        z: 33.605186
      timeStamp: 6.2730436
    - trackedPosition:
        x: 13.5521145
        y: -0.77000004
        z: 32.35238
      timeStamp: 6.4022512
    - trackedPosition:
        x: 13.502635
        y: -0.77000004
        z: 31.158749
      timeStamp: 6.5211215
    - trackedPosition:
        x: 13.353625
        y: -0.77000004
        z: 29.968073
      timeStamp: 6.6367264
    - trackedPosition:
        x: 13.216047
        y: 0.31227997
        z: 28.775988
      timeStamp: 6.760991
    - trackedPosition:
        x: 13.093486
        y: 0.99836016
        z: 27.783527
      timeStamp: 6.8761144
    - trackedPosition:
        x: 12.920347
        y: 1.6292565
        z: 26.394611
      timeStamp: 7.005395
    - trackedPosition:
        x: 12.793969
        y: 1.8639529
        z: 25.204731
      timeStamp: 7.1328483
    - trackedPosition:
        x: 12.460406
        y: 1.7806813
        z: 23.853268
      timeStamp: 7.260644
    - trackedPosition:
        x: 12.576558
        y: 1.4857615
        z: 22.862625
      timeStamp: 7.374701
    - trackedPosition:
        x: 12.879122
        y: 1.48
        z: 21.505465
      timeStamp: 7.5004873
    - trackedPosition:
        x: 12.398765
        y: 1.48
        z: 20.417355
      timeStamp: 7.6226187
    - trackedPosition:
        x: 12.015091
        y: 1.48
        z: 19.285069
      timeStamp: 7.743707
    - trackedPosition:
        x: 11.940068
        y: 1.48
        z: 18.089527
      timeStamp: 7.860685
    - trackedPosition:
        x: 11.603513
        y: 1.48
        z: 17.180025
      timeStamp: 7.975033
    - trackedPosition:
        x: 10.510188
        y: 1.48
        z: 16.306797
      timeStamp: 8.098529
    - trackedPosition:
        x: 9.519786
        y: 1.48
        z: 15.629922
      timeStamp: 8.223724
    - trackedPosition:
        x: 8.493348
        y: 1.48
        z: 15.008289
      timeStamp: 8.3479185
    - trackedPosition:
        x: 7.4669113
        y: 1.48
        z: 14.386658
      timeStamp: 8.471351
    - trackedPosition:
        x: 6.37552
        y: 1.48
        z: 13.893229
      timeStamp: 8.590235
    - trackedPosition:
        x: 5.194383
        y: 1.48
        z: 13.708695
      timeStamp: 8.714093
    - trackedPosition:
        x: 4.014145
        y: 1.48
        z: 13.903518
      timeStamp: 8.832634
    - trackedPosition:
        x: 2.848784
        y: 1.48
        z: 14.189757
      timeStamp: 8.960014
    - trackedPosition:
        x: 2.2661035
        y: 1.48
        z: 14.332877
      timeStamp: 9.079098
    - trackedPosition:
        x: 1.7805363
        y: 1.48
        z: 14.452145
      timeStamp: 9.194023
    - trackedPosition:
        x: 1.5863094
        y: 1.4799999
        z: 14.499851
      timeStamp: 9.316557
    - trackedPosition:
        x: 1.4262185
        y: 1.48
        z: 15.056166
      timeStamp: 9.852209
    - trackedPosition:
        x: 1.4694487
        y: 1.48
        z: 15.554292
      timeStamp: 9.951459
    - trackedPosition:
        x: 1.5600816
        y: 1.48
        z: 16.550177
      timeStamp: 10.062384
    - trackedPosition:
        x: 1.6507146
        y: 1.48
        z: 17.54606
      timeStamp: 10.174582
    - trackedPosition:
        x: 1.7594743
        y: 1.48
        z: 18.741121
      timeStamp: 10.294689
    - trackedPosition:
        x: 1.8682339
        y: 1.48
        z: 19.936182
      timeStamp: 10.400208
    - trackedPosition:
        x: 1.9588668
        y: 1.48
        z: 20.932068
      timeStamp: 10.50446
    - trackedPosition:
        x: 2.2209885
        y: 1.48
        z: 21.894835
      timeStamp: 10.605089
    - trackedPosition:
        x: 2.757052
        y: 1.48
        z: 22.732573
      timeStamp: 10.709069
    - trackedPosition:
        x: 3.6583774
        y: 1.48
        z: 23.523088
      timeStamp: 10.829906
    - trackedPosition:
        x: 4.906544
        y: 1.48
        z: 24.14453
      timeStamp: 10.957573
    - trackedPosition:
        x: 5.9944224
        y: 1.48
        z: 24.64349
      timeStamp: 11.079765
    - trackedPosition:
        x: 7.161343
        y: 1.48
        z: 24.67215
      timeStamp: 11.206255
    - trackedPosition:
        x: 8.321034
        y: 1.48
        z: 24.37754
      timeStamp: 11.322203
    - trackedPosition:
        x: 9.312922
        y: 1.4799999
        z: 23.718826
      timeStamp: 11.442534
    - trackedPosition:
        x: 10.012081
        y: 1.4799999
        z: 22.746988
      timeStamp: 11.558935
    - trackedPosition:
        x: 10.78467
        y: 1.4799999
        z: 21.8298
      timeStamp: 11.680868
    - trackedPosition:
        x: 11.756565
        y: 1.48
        z: 21.132307
      timeStamp: 11.797173
    - trackedPosition:
        x: 12.6568
        y: 1.48
        z: 20.698942
      timeStamp: 11.908283
    - trackedPosition:
        x: 13.573169
        y: 1.4799999
        z: 19.930796
      timeStamp: 12.023322
    - trackedPosition:
        x: 14.144528
        y: 1.48
        z: 19.112898
      timeStamp: 12.127321
    - trackedPosition:
        x: 14.329401
        y: 1.48
        z: 18.286413
      timeStamp: 12.2314825
    - trackedPosition:
        x: 14.34136
        y: 1.48
        z: 17.607943
      timeStamp: 12.35959
    - trackedPosition:
        x: 13.768875
        y: 1.48
        z: 17.38431
      timeStamp: 12.476192
    - trackedPosition:
        x: 12.559385
        y: 1.48
        z: 18.074474
      timeStamp: 12.606806
    - trackedPosition:
        x: 11.579336
        y: 1.48
        z: 18.264
      timeStamp: 12.72081
    - trackedPosition:
        x: 10.984008
        y: 1.48
        z: 18.323475
      timeStamp: 12.84789
    trackedProgressions: []
    trackedStatChanges: []
  - _id: 
    SceneName: SampleScene 1
    UniqueID: 
    objectName: progressionData
    sessionName: 44631b73-67fb-4c90-9aa3-84cd84852045
    dateCreated: 21-03-22
    trackedPositions: []
    trackedProgressions:
    - timeStamp: 12.881693
      eventName: Died
      value: 
      trackedPosition:
        x: 10.793938
        y: 1.48
        z: 18.385714
    trackedStatChanges: []
  - _id: 
    SceneName: SampleScene 1
    UniqueID: 
    objectName: progressionData
    sessionName: b975d30a-aa84-4559-9714-6dc6f8f82daa
    dateCreated: 21-03-22
    trackedPositions: []
    trackedProgressions:
    - timeStamp: 19.695591
      eventName: Died
      value: 
      trackedPosition:
        x: 11.926077
        y: 1.4799999
        z: 0.20867345
    trackedStatChanges: []
  - _id: 
    SceneName: SampleScene 1
    UniqueID: 
    objectName: FPSController0
    sessionName: b975d30a-aa84-4559-9714-6dc6f8f82daa
    dateCreated: 21-03-22
    trackedPositions:
    - trackedPosition:
        x: 10.25
        y: 1.2825398
        z: 45.25
      timeStamp: 2.8934355
    - trackedPosition:
        x: 10.329109
        y: 1.2825398
        z: 45.43369
      timeStamp: 6.2781587
    - trackedPosition:
        x: 10.252201
        y: 1.2825398
        z: 46.027184
      timeStamp: 6.39067
    - trackedPosition:
        x: 9.963365
        y: 1.2825398
        z: 46.65766
      timeStamp: 6.5253773
    - trackedPosition:
        x: 9.524944
        y: 1.2825398
        z: 46.89099
      timeStamp: 6.6262207
    - trackedPosition:
        x: 8.928846
        y: 1.2825398
        z: 46.87047
      timeStamp: 6.755592
    - trackedPosition:
        x: 8.533662
        y: 1.2825398
        z: 46.808582
      timeStamp: 6.8560805
    - trackedPosition:
        x: 8.369083
        y: 1.28254
        z: 46.336506
      timeStamp: 7.8923116
    - trackedPosition:
        x: 8.438749
        y: 1.28254
        z: 45.34351
      timeStamp: 7.99236
    - trackedPosition:
        x: 8.666544
        y: 1.28254
        z: 44.370132
      timeStamp: 8.091745
    - trackedPosition:
        x: 8.997014
        y: 1.28254
        z: 43.4274
      timeStamp: 8.191532
    - trackedPosition:
        x: 9.513921
        y: 1.28254
        z: 42.45684
      timeStamp: 8.326472
    - trackedPosition:
        x: 9.884827
        y: 1.28254
        z: 41.86336
      timeStamp: 8.457898
    - trackedPosition:
        x: 10.270685
        y: 1.28254
        z: 41.572117
      timeStamp: 8.559569
    - trackedPosition:
        x: 10.2577715
        y: 1.2825398
        z: 42.07195
      timeStamp: 9.592984
    - trackedPosition:
        x: 10.222877
        y: 1.2825398
        z: 42.87118
      timeStamp: 9.69625
    - trackedPosition:
        x: 10.573477
        y: 1.2825398
        z: 44.008717
      timeStamp: 9.8266735
    - trackedPosition:
        x: 11.490499
        y: 1.2825398
        z: 44.766205
      timeStamp: 9.956054
    - trackedPosition:
        x: 12.682738
        y: 1.2825398
        z: 44.847847
      timeStamp: 10.059073
    - trackedPosition:
        x: 13.79214
        y: 1.2825398
        z: 44.438103
      timeStamp: 10.192321
    - trackedPosition:
        x: 14.466091
        y: 1.2825398
        z: 43.708946
      timeStamp: 10.293797
    - trackedPosition:
        x: 14.81304
        y: 1.8174157
        z: 42.370026
      timeStamp: 10.426667
    - trackedPosition:
        x: 14.821764
        y: 2.6212158
        z: 41.370342
      timeStamp: 10.52497
    - trackedPosition:
        x: 14.790006
        y: 3.228816
        z: 40.370884
      timeStamp: 10.633739
    - trackedPosition:
        x: 14.74355
        y: 3.7498405
        z: 38.9735
      timeStamp: 10.763633
    - trackedPosition:
        x: 15.15223
        y: 3.8903608
        z: 37.8537
      timeStamp: 10.890468
    - trackedPosition:
        x: 16.081074
        y: 3.6972172
        z: 36.808884
      timeStamp: 11.023007
    - trackedPosition:
        x: 16.512045
        y: 3.3238175
        z: 35.91463
      timeStamp: 11.124903
    - trackedPosition:
        x: 16.54129
        y: 2.7542179
        z: 34.920254
      timeStamp: 11.224522
    - trackedPosition:
        x: 16.113802
        y: 1.6271626
        z: 33.592754
      timeStamp: 11.360601
    - trackedPosition:
        x: 15.464445
        y: 0.3550434
        z: 32.58519
      timeStamp: 11.489536
    - trackedPosition:
        x: 14.9753685
        y: -0.77000004
        z: 31.712952
      timeStamp: 11.593864
    - trackedPosition:
        x: 14.152523
        y: -0.19354406
        z: 30.340796
      timeStamp: 11.756303
    - trackedPosition:
        x: 13.5291
        y: 0.74747205
        z: 29.315445
      timeStamp: 11.856736
    - trackedPosition:
        x: 13.145918
        y: 1.4059603
        z: 28.192604
      timeStamp: 11.991608
    - trackedPosition:
        x: 13.54721
        y: 1.8171127
        z: 26.868073
      timeStamp: 12.12367
    - trackedPosition:
        x: 14.594654
        y: 1.8437132
        z: 25.960419
      timeStamp: 12.257243
    - trackedPosition:
        x: 15.602173
        y: 1.5604416
        z: 25.689285
      timeStamp: 12.388986
    - trackedPosition:
        x: 16.257694
        y: 1.1085619
        z: 25.48885
      timeStamp: 12.490873
    - trackedPosition:
        x: 16.785091
        y: 1.48
        z: 24.62858
      timeStamp: 12.624956
    - trackedPosition:
        x: 16.406279
        y: 1.4799998
        z: 23.483416
      timeStamp: 12.757085
    - trackedPosition:
        x: 16.406279
        y: 1.48
        z: 23.363335
      timeStamp: 12.865867
    - trackedPosition:
        x: 16.406279
        y: 1.4799999
        z: 23.430216
      timeStamp: 12.990243
    - trackedPosition:
        x: 16.406279
        y: 1.4799999
        z: 23.463657
      timeStamp: 13.090539
    - trackedPosition:
        x: 17.102915
        y: 1.48
        z: 23.456612
      timeStamp: 13.656848
    - trackedPosition:
        x: 17.59105
        y: 1.48
        z: 23.564829
      timeStamp: 13.760265
    - trackedPosition:
        x: 18.170345
        y: 1.48
        z: 23.720953
      timeStamp: 13.893627
    - trackedPosition:
        x: 18.638525
        y: 1.48
        z: 23.896372
      timeStamp: 13.993945
    - trackedPosition:
        x: 19.013071
        y: 1.4799999
        z: 24.036781
      timeStamp: 14.123795
    - trackedPosition:
        x: 18.814436
        y: 1.48
        z: 24.060116
      timeStamp: 15.525587
    - trackedPosition:
        x: 17.780863
        y: 1.48
        z: 23.452492
      timeStamp: 15.656805
    - trackedPosition:
        x: 16.795683
        y: 1.48
        z: 22.767454
      timeStamp: 15.756832
    - trackedPosition:
        x: 16.387281
        y: 1.48
        z: 21.884315
      timeStamp: 15.859992
    - trackedPosition:
        x: 16.830538
        y: 1.48
        z: 20.998026
      timeStamp: 15.95787
    - trackedPosition:
        x: 17.696291
        y: 1.48
        z: 20.168308
      timeStamp: 16.089275
    - trackedPosition:
        x: 18.416208
        y: 1.48
        z: 19.475515
      timeStamp: 16.193195
    - trackedPosition:
        x: 19.04342
        y: 1.48
        z: 18.227898
      timeStamp: 16.323547
    - trackedPosition:
        x: 19.306793
        y: 1.48
        z: 17.2639
      timeStamp: 16.42455
    - trackedPosition:
        x: 19.477612
        y: 1.48
        z: 16.279142
      timeStamp: 16.529865
    - trackedPosition:
        x: 19.467127
        y: 1.48
        z: 14.881163
      timeStamp: 16.658417
    - trackedPosition:
        x: 19.21127
        y: 1.48
        z: 13.916669
      timeStamp: 16.759617
    - trackedPosition:
        x: 18.741083
        y: 1.48
        z: 13.034765
      timeStamp: 16.862078
    - trackedPosition:
        x: 18.209784
        y: 1.48
        z: 11.740231
      timeStamp: 16.99645
    - trackedPosition:
        x: 17.88521
        y: 1.48
        z: 10.794383
      timeStamp: 17.097303
    - trackedPosition:
        x: 17.574165
        y: 1.48
        z: 9.637359
      timeStamp: 17.226875
    - trackedPosition:
        x: 17.683918
        y: 1.48
        z: 8.244815
      timeStamp: 17.357622
    - trackedPosition:
        x: 17.99489
        y: 1.48
        z: 7.2955294
      timeStamp: 17.458015
    - trackedPosition:
        x: 18.439304
        y: 1.48
        z: 6.1822176
      timeStamp: 17.589428
    - trackedPosition:
        x: 18.645124
        y: 1.48
        z: 5.2038417
      timeStamp: 17.69118
    - trackedPosition:
        x: 18.858997
        y: 1.48
        z: 4.023068
      timeStamp: 17.799232
    - trackedPosition:
        x: 18.974285
        y: 1.48
        z: 2.8293874
      timeStamp: 17.930946
    - trackedPosition:
        x: 19.006742
        y: 1.48
        z: 1.8299221
      timeStamp: 18.031351
    - trackedPosition:
        x: 18.726854
        y: 1.48
        z: 0.4790767
      timeStamp: 18.157846
    - trackedPosition:
        x: 18.204952
        y: 1.48
        z: -0.37392616
      timeStamp: 18.257849
    - trackedPosition:
        x: 17.57974
        y: 1.48
        z: -1.3981872
      timeStamp: 18.390976
    - trackedPosition:
        x: 16.850328
        y: 1.48
        z: -2.5931582
      timeStamp: 18.525202
    - trackedPosition:
        x: 16.288494
        y: 1.48
        z: -3.4186485
      timeStamp: 18.632711
    - trackedPosition:
        x: 15.1057625
        y: 1.48
        z: -4.137197
      timeStamp: 18.7602
    - trackedPosition:
        x: 14.116204
        y: 1.48
        z: -4.2607784
      timeStamp: 18.861874
    - trackedPosition:
        x: 12.925844
        y: 1.48
        z: -4.1100483
      timeStamp: 18.99112
    - trackedPosition:
        x: 11.768446
        y: 1.48
        z: -3.5275946
      timeStamp: 19.127798
    - trackedPosition:
        x: 11.688091
        y: 1.48
        z: -2.166566
      timeStamp: 19.25689
    - trackedPosition:
        x: 11.917352
        y: 1.48
        z: -0.9912053
      timeStamp: 19.396982
    - trackedPosition:
        x: 11.922063
        y: 1.48
        z: -0.29128802
      timeStamp: 19.526127
    - trackedPosition:
        x: 11.926077
        y: 1.4799999
        z: 0.20867345
      timeStamp: 19.662485
    trackedProgressions: []
    trackedStatChanges: []
  - _id: 
    SceneName: SampleScene 1
    UniqueID: 
    objectName: progressionData
    sessionName: b975d30a-aa84-4559-9714-6dc6f8f82daa
    dateCreated: 21-03-22
    trackedPositions: []
    trackedProgressions:
    - timeStamp: 19.695591
      eventName: Died
      value: 
      trackedPosition:
        x: 11.926077
        y: 1.4799999
        z: 0.20867345
    trackedStatChanges: []
  - _id: 
    SceneName: SampleScene 1
    UniqueID: 
    objectName: FPSController0
    sessionName: b975d30a-aa84-4559-9714-6dc6f8f82daa
    dateCreated: 21-03-22
    trackedPositions:
    - trackedPosition:
        x: 10.25
        y: 1.2825398
        z: 45.25
      timeStamp: 2.8934355
    - trackedPosition:
        x: 10.329109
        y: 1.2825398
        z: 45.43369
      timeStamp: 6.2781587
    - trackedPosition:
        x: 10.252201
        y: 1.2825398
        z: 46.027184
      timeStamp: 6.39067
    - trackedPosition:
        x: 9.963365
        y: 1.2825398
        z: 46.65766
      timeStamp: 6.5253773
    - trackedPosition:
        x: 9.524944
        y: 1.2825398
        z: 46.89099
      timeStamp: 6.6262207
    - trackedPosition:
        x: 8.928846
        y: 1.2825398
        z: 46.87047
      timeStamp: 6.755592
    - trackedPosition:
        x: 8.533662
        y: 1.2825398
        z: 46.808582
      timeStamp: 6.8560805
    - trackedPosition:
        x: 8.369083
        y: 1.28254
        z: 46.336506
      timeStamp: 7.8923116
    - trackedPosition:
        x: 8.438749
        y: 1.28254
        z: 45.34351
      timeStamp: 7.99236
    - trackedPosition:
        x: 8.666544
        y: 1.28254
        z: 44.370132
      timeStamp: 8.091745
    - trackedPosition:
        x: 8.997014
        y: 1.28254
        z: 43.4274
      timeStamp: 8.191532
    - trackedPosition:
        x: 9.513921
        y: 1.28254
        z: 42.45684
      timeStamp: 8.326472
    - trackedPosition:
        x: 9.884827
        y: 1.28254
        z: 41.86336
      timeStamp: 8.457898
    - trackedPosition:
        x: 10.270685
        y: 1.28254
        z: 41.572117
      timeStamp: 8.559569
    - trackedPosition:
        x: 10.2577715
        y: 1.2825398
        z: 42.07195
      timeStamp: 9.592984
    - trackedPosition:
        x: 10.222877
        y: 1.2825398
        z: 42.87118
      timeStamp: 9.69625
    - trackedPosition:
        x: 10.573477
        y: 1.2825398
        z: 44.008717
      timeStamp: 9.8266735
    - trackedPosition:
        x: 11.490499
        y: 1.2825398
        z: 44.766205
      timeStamp: 9.956054
    - trackedPosition:
        x: 12.682738
        y: 1.2825398
        z: 44.847847
      timeStamp: 10.059073
    - trackedPosition:
        x: 13.79214
        y: 1.2825398
        z: 44.438103
      timeStamp: 10.192321
    - trackedPosition:
        x: 14.466091
        y: 1.2825398
        z: 43.708946
      timeStamp: 10.293797
    - trackedPosition:
        x: 14.81304
        y: 1.8174157
        z: 42.370026
      timeStamp: 10.426667
    - trackedPosition:
        x: 14.821764
        y: 2.6212158
        z: 41.370342
      timeStamp: 10.52497
    - trackedPosition:
        x: 14.790006
        y: 3.228816
        z: 40.370884
      timeStamp: 10.633739
    - trackedPosition:
        x: 14.74355
        y: 3.7498405
        z: 38.9735
      timeStamp: 10.763633
    - trackedPosition:
        x: 15.15223
        y: 3.8903608
        z: 37.8537
      timeStamp: 10.890468
    - trackedPosition:
        x: 16.081074
        y: 3.6972172
        z: 36.808884
      timeStamp: 11.023007
    - trackedPosition:
        x: 16.512045
        y: 3.3238175
        z: 35.91463
      timeStamp: 11.124903
    - trackedPosition:
        x: 16.54129
        y: 2.7542179
        z: 34.920254
      timeStamp: 11.224522
    - trackedPosition:
        x: 16.113802
        y: 1.6271626
        z: 33.592754
      timeStamp: 11.360601
    - trackedPosition:
        x: 15.464445
        y: 0.3550434
        z: 32.58519
      timeStamp: 11.489536
    - trackedPosition:
        x: 14.9753685
        y: -0.77000004
        z: 31.712952
      timeStamp: 11.593864
    - trackedPosition:
        x: 14.152523
        y: -0.19354406
        z: 30.340796
      timeStamp: 11.756303
    - trackedPosition:
        x: 13.5291
        y: 0.74747205
        z: 29.315445
      timeStamp: 11.856736
    - trackedPosition:
        x: 13.145918
        y: 1.4059603
        z: 28.192604
      timeStamp: 11.991608
    - trackedPosition:
        x: 13.54721
        y: 1.8171127
        z: 26.868073
      timeStamp: 12.12367
    - trackedPosition:
        x: 14.594654
        y: 1.8437132
        z: 25.960419
      timeStamp: 12.257243
    - trackedPosition:
        x: 15.602173
        y: 1.5604416
        z: 25.689285
      timeStamp: 12.388986
    - trackedPosition:
        x: 16.257694
        y: 1.1085619
        z: 25.48885
      timeStamp: 12.490873
    - trackedPosition:
        x: 16.785091
        y: 1.48
        z: 24.62858
      timeStamp: 12.624956
    - trackedPosition:
        x: 16.406279
        y: 1.4799998
        z: 23.483416
      timeStamp: 12.757085
    - trackedPosition:
        x: 16.406279
        y: 1.48
        z: 23.363335
      timeStamp: 12.865867
    - trackedPosition:
        x: 16.406279
        y: 1.4799999
        z: 23.430216
      timeStamp: 12.990243
    - trackedPosition:
        x: 16.406279
        y: 1.4799999
        z: 23.463657
      timeStamp: 13.090539
    - trackedPosition:
        x: 17.102915
        y: 1.48
        z: 23.456612
      timeStamp: 13.656848
    - trackedPosition:
        x: 17.59105
        y: 1.48
        z: 23.564829
      timeStamp: 13.760265
    - trackedPosition:
        x: 18.170345
        y: 1.48
        z: 23.720953
      timeStamp: 13.893627
    - trackedPosition:
        x: 18.638525
        y: 1.48
        z: 23.896372
      timeStamp: 13.993945
    - trackedPosition:
        x: 19.013071
        y: 1.4799999
        z: 24.036781
      timeStamp: 14.123795
    - trackedPosition:
        x: 18.814436
        y: 1.48
        z: 24.060116
      timeStamp: 15.525587
    - trackedPosition:
        x: 17.780863
        y: 1.48
        z: 23.452492
      timeStamp: 15.656805
    - trackedPosition:
        x: 16.795683
        y: 1.48
        z: 22.767454
      timeStamp: 15.756832
    - trackedPosition:
        x: 16.387281
        y: 1.48
        z: 21.884315
      timeStamp: 15.859992
    - trackedPosition:
        x: 16.830538
        y: 1.48
        z: 20.998026
      timeStamp: 15.95787
    - trackedPosition:
        x: 17.696291
        y: 1.48
        z: 20.168308
      timeStamp: 16.089275
    - trackedPosition:
        x: 18.416208
        y: 1.48
        z: 19.475515
      timeStamp: 16.193195
    - trackedPosition:
        x: 19.04342
        y: 1.48
        z: 18.227898
      timeStamp: 16.323547
    - trackedPosition:
        x: 19.306793
        y: 1.48
        z: 17.2639
      timeStamp: 16.42455
    - trackedPosition:
        x: 19.477612
        y: 1.48
        z: 16.279142
      timeStamp: 16.529865
    - trackedPosition:
        x: 19.467127
        y: 1.48
        z: 14.881163
      timeStamp: 16.658417
    - trackedPosition:
        x: 19.21127
        y: 1.48
        z: 13.916669
      timeStamp: 16.759617
    - trackedPosition:
        x: 18.741083
        y: 1.48
        z: 13.034765
      timeStamp: 16.862078
    - trackedPosition:
        x: 18.209784
        y: 1.48
        z: 11.740231
      timeStamp: 16.99645
    - trackedPosition:
        x: 17.88521
        y: 1.48
        z: 10.794383
      timeStamp: 17.097303
    - trackedPosition:
        x: 17.574165
        y: 1.48
        z: 9.637359
      timeStamp: 17.226875
    - trackedPosition:
        x: 17.683918
        y: 1.48
        z: 8.244815
      timeStamp: 17.357622
    - trackedPosition:
        x: 17.99489
        y: 1.48
        z: 7.2955294
      timeStamp: 17.458015
    - trackedPosition:
        x: 18.439304
        y: 1.48
        z: 6.1822176
      timeStamp: 17.589428
    - trackedPosition:
        x: 18.645124
        y: 1.48
        z: 5.2038417
      timeStamp: 17.69118
    - trackedPosition:
        x: 18.858997
        y: 1.48
        z: 4.023068
      timeStamp: 17.799232
    - trackedPosition:
        x: 18.974285
        y: 1.48
        z: 2.8293874
      timeStamp: 17.930946
    - trackedPosition:
        x: 19.006742
        y: 1.48
        z: 1.8299221
      timeStamp: 18.031351
    - trackedPosition:
        x: 18.726854
        y: 1.48
        z: 0.4790767
      timeStamp: 18.157846
    - trackedPosition:
        x: 18.204952
        y: 1.48
        z: -0.37392616
      timeStamp: 18.257849
    - trackedPosition:
        x: 17.57974
        y: 1.48
        z: -1.3981872
      timeStamp: 18.390976
    - trackedPosition:
        x: 16.850328
        y: 1.48
        z: -2.5931582
      timeStamp: 18.525202
    - trackedPosition:
        x: 16.288494
        y: 1.48
        z: -3.4186485
      timeStamp: 18.632711
    - trackedPosition:
        x: 15.1057625
        y: 1.48
        z: -4.137197
      timeStamp: 18.7602
    - trackedPosition:
        x: 14.116204
        y: 1.48
        z: -4.2607784
      timeStamp: 18.861874
    - trackedPosition:
        x: 12.925844
        y: 1.48
        z: -4.1100483
      timeStamp: 18.99112
    - trackedPosition:
        x: 11.768446
        y: 1.48
        z: -3.5275946
      timeStamp: 19.127798
    - trackedPosition:
        x: 11.688091
        y: 1.48
        z: -2.166566
      timeStamp: 19.25689
    - trackedPosition:
        x: 11.917352
        y: 1.48
        z: -0.9912053
      timeStamp: 19.396982
    - trackedPosition:
        x: 11.922063
        y: 1.48
        z: -0.29128802
      timeStamp: 19.526127
    - trackedPosition:
        x: 11.926077
        y: 1.4799999
        z: 0.20867345
      timeStamp: 19.662485
    trackedProgressions: []
    trackedStatChanges: []
  areasWithin: []
  choices:
  - 11-03-22 PlaySession b86a
  - 21-03-22 PlaySession 0105
  - 21-03-22 PlaySession 3549
  - 21-03-22 PlaySession 4463
  - 21-03-22 PlaySession 4463
  - 21-03-22 PlaySession b975
  - 21-03-22 PlaySession b975
  areaPoints:
  - pointOne: {x: 10, y: 10, z: 10}
    pointTwo: {x: 0, y: 0, z: 0}
    color: {r: 1, g: 1, b: 1, a: 1}
    name: Area_One
--- !u!114 &19
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: a952d7f75797ded49add3aebeec8de09, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_MinSize: {x: 100, y: 100}
  m_MaxSize: {x: 4000, y: 4000}
  m_TitleContent:
    m_Text: Visualiser Menu
    m_Image: {fileID: 0}
    m_Tooltip: 
  m_Pos:
    serializedVersion: 2
    x: 0
    y: 583
    width: 305
    height: 426
  m_ViewDataDictionary: {fileID: 0}
--- !u!114 &20
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12013, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_MinSize: {x: 200, y: 200}
  m_MaxSize: {x: 4000, y: 4000}
  m_TitleContent:
    m_Text: Scene
    m_Image: {fileID: 2593428753322112591, guid: 0000000000000000d000000000000000, type: 0}
    m_Tooltip: 
  m_Pos:
    serializedVersion: 2
    x: 248
    y: 73
    width: 1257
    height: 489
  m_ViewDataDictionary: {fileID: 0}
  m_ShowContextualTools: 0
  m_WindowGUID: cc27987af1a868c49b0894db9c0f5429
  m_Gizmos: 0
  m_OverrideSceneCullingMask: 6917529027641081856
  m_SceneIsLit: 0
  m_SceneLighting: 1
  m_2DMode: 0
  m_isRotationLocked: 0
  m_PlayAudio: 0
  m_AudioPlay: 0
  m_Position:
    m_Target: {x: 0, y: 0, z: 0}
    speed: 2
    m_Value: {x: 16.423508, y: -304.7046, z: 62.884674}
  m_RenderMode: 0
  m_CameraMode:
    drawMode: 0
    name: Shaded
    section: Shading Mode
  m_ValidateTrueMetals: 0
  m_DoValidateTrueMetals: 0
  m_ExposureSliderValue: 0
  m_SceneViewState:
    m_AlwaysRefresh: 0
    showFog: 1
    showSkybox: 1
    showFlares: 1
    showImageEffects: 1
    showParticleSystems: 1
    showVisualEffectGraphs: 1
    m_FxEnabled: 1
  m_Grid:
    xGrid:
      m_Fade:
        m_Target: 0
        speed: 2
        m_Value: 0
      m_Color: {r: 0.5, g: 0.5, b: 0.5, a: 0.4}
      m_Pivot: {x: 0, y: 0, z: 0}
      m_Size: {x: 0, y: 0}
    yGrid:
      m_Fade:
        m_Target: 1
        speed: 2
        m_Value: 1
      m_Color: {r: 0.5, g: 0.5, b: 0.5, a: 0.4}
      m_Pivot: {x: 0, y: 0, z: 0}
      m_Size: {x: 1, y: 1}
    zGrid:
      m_Fade:
        m_Target: 0
        speed: 2
        m_Value: 0
      m_Color: {r: 0.5, g: 0.5, b: 0.5, a: 0.4}
      m_Pivot: {x: 0, y: 0, z: 0}
      m_Size: {x: 0, y: 0}
    m_ShowGrid: 1
    m_GridAxis: 1
    m_gridOpacity: 0.5
  m_Rotation:
    m_Target: {x: 0.4305366, y: 0.2995162, z: -0.15399407, w: 0.8373867}
    speed: 2
    m_Value: {x: -0.65171444, y: 0.027286012, z: -0.02347164, w: -0.7576124}
  m_Size:
    m_Target: 51.71428
    speed: 2
    m_Value: 51.753094
  m_Ortho:
    m_Target: 1
    speed: 2
    m_Value: 1
  m_CameraSettings:
    m_Speed: 2
    m_SpeedNormalized: 1
    m_SpeedMin: 0.001
    m_SpeedMax: 2
    m_EasingEnabled: 1
    m_EasingDuration: 0.4
    m_AccelerationEnabled: 1
    m_FieldOfViewHorizontalOrVertical: 60
    m_NearClip: 0.03
    m_FarClip: 10000
    m_DynamicClip: 1
    m_OcclusionCulling: 0
  m_LastSceneViewRotation: {x: 0, y: 0, z: 0, w: 0}
  m_LastSceneViewOrtho: 0
  m_ReplacementShader: {fileID: 0}
  m_ReplacementString: 
  m_SceneVisActive: 1
  m_LastLockedObject: {fileID: 0}
  m_ViewIsLockedToObject: 0
--- !u!114 &21
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12061, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_MinSize: {x: 200, y: 200}
  m_MaxSize: {x: 4000, y: 4000}
  m_TitleContent:
    m_Text: Hierarchy
    m_Image: {fileID: 7966133145522015247, guid: 0000000000000000d000000000000000, type: 0}
    m_Tooltip: 
  m_Pos:
    serializedVersion: 2
    x: 0
    y: 73
    width: 247
    height: 489
  m_ViewDataDictionary: {fileID: 0}
  m_SceneHierarchy:
    m_TreeViewState:
      scrollPos: {x: 0, y: 0}
      m_SelectedIDs: 
      m_LastClickedID: 0
      m_ExpandedIDs: 52fbffff
      m_RenameOverlay:
        m_UserAcceptedRename: 0
        m_Name: 
        m_OriginalName: 
        m_EditFieldRect:
          serializedVersion: 2
          x: 0
          y: 0
          width: 0
          height: 0
        m_UserData: 0
        m_IsWaitingForDelay: 0
        m_IsRenaming: 0
        m_OriginalEventType: 11
        m_IsRenamingFilename: 0
        m_ClientGUIView: {fileID: 12}
      m_SearchString: 
    m_ExpandedScenes: []
    m_CurrenRootInstanceID: 0
    m_LockTracker:
      m_IsLocked: 0
    m_CurrentSortingName: TransformSorting
  m_WindowGUID: 4c969a2b90040154d917609493e03593
--- !u!114 &22
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12015, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_MinSize: {x: 200, y: 200}
  m_MaxSize: {x: 4000, y: 4000}
  m_TitleContent:
    m_Text: Game
    m_Image: {fileID: -6423792434712278376, guid: 0000000000000000d000000000000000, type: 0}
    m_Tooltip: 
  m_Pos:
    serializedVersion: 2
    x: 402
    y: 73
    width: 966
    height: 623
  m_ViewDataDictionary: {fileID: 0}
  m_SerializedViewNames: []
  m_SerializedViewValues: []
  m_PlayModeViewName: GameView
  m_ShowGizmos: 0
  m_TargetDisplay: 0
  m_ClearColor: {r: 0, g: 0, b: 0, a: 0}
  m_TargetSize: {x: 966, y: 602}
  m_TextureFilterMode: 0
  m_TextureHideFlags: 61
  m_RenderIMGUI: 1
  m_MaximizeOnPlay: 0
  m_UseMipMap: 0
  m_VSyncEnabled: 0
  m_Gizmos: 0
  m_Stats: 0
  m_SelectedSizes: 00000000000000000000000000000000000000000000000000000000000000000000000000000000
  m_ZoomArea:
    m_HRangeLocked: 0
    m_VRangeLocked: 0
    hZoomLockedByDefault: 0
    vZoomLockedByDefault: 0
    m_HBaseRangeMin: -483
    m_HBaseRangeMax: 483
    m_VBaseRangeMin: -311.5
    m_VBaseRangeMax: 311.5
    m_HAllowExceedBaseRangeMin: 1
    m_HAllowExceedBaseRangeMax: 1
    m_VAllowExceedBaseRangeMin: 1
    m_VAllowExceedBaseRangeMax: 1
    m_ScaleWithWindow: 0
    m_HSlider: 0
    m_VSlider: 0
    m_IgnoreScrollWheelUntilClicked: 0
    m_EnableMouseInput: 0
    m_EnableSliderZoomHorizontal: 0
    m_EnableSliderZoomVertical: 0
    m_UniformScale: 1
    m_UpDirection: 1
    m_DrawArea:
      serializedVersion: 2
      x: 0
      y: 0
      width: 966
      height: 623
    m_Scale: {x: 1, y: 1}
    m_Translation: {x: 483, y: 311.5}
    m_MarginLeft: 0
    m_MarginRight: 0
    m_MarginTop: 0
    m_MarginBottom: 0
    m_LastShownAreaInsideMargins:
      serializedVersion: 2
      x: -483
      y: -311.5
      width: 966
      height: 623
    m_MinimalGUI: 1
  m_defaultScale: 1
  m_LastWindowPixelSize: {x: 966, y: 623}
  m_ClearInEditMode: 1
  m_NoCameraWarning: 1
  m_LowResolutionForAspectRatios: 01000000000000000000
  m_XRRenderMode: 0
  m_RenderTexture: {fileID: 0}
--- !u!114 &23
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 11500000, guid: a70a2b5663549e04cb5c6d360be49bf5, type: 3}
  m_Name: 
  m_EditorClassIdentifier: 
  m_MinSize: {x: 100, y: 100}
  m_MaxSize: {x: 4000, y: 4000}
  m_TitleContent:
    m_Text: Tool Settings
    m_Image: {fileID: 0}
    m_Tooltip: 
  m_Pos:
    serializedVersion: 2
    x: 1507
    y: 73
    width: 412
    height: 489
  m_ViewDataDictionary: {fileID: 0}
  windowRect:
    serializedVersion: 2
    x: 100
    y: 100
    width: 200
    height: 200
--- !u!114 &24
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 12019, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_MinSize: {x: 275, y: 100}
  m_MaxSize: {x: 4000, y: 4000}
  m_TitleContent:
    m_Text: Inspector
    m_Image: {fileID: -2667387946076563598, guid: 0000000000000000d000000000000000, type: 0}
    m_Tooltip: 
  m_Pos:
    serializedVersion: 2
    x: 1370
    y: 73
    width: 549
    height: 448
  m_ViewDataDictionary: {fileID: 0}
  m_ObjectsLockedBeforeSerialization: []
  m_InstanceIDsLockedBeforeSerialization: 
  m_PreviewResizer:
    m_CachedPref: -345
    m_ControlHash: 1412526313
    m_PrefName: Preview_InspectorPreview
  m_LastInspectedObjectInstanceID: 16574
  m_LastVerticalScrollValue: 0
  m_GlobalObjectId: 
  m_LockTracker:
    m_IsLocked: 0
  m_PreviewWindow: {fileID: 0}
--- !u!114 &25
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 12141, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_MinSize: {x: 300, y: 360}
  m_MaxSize: {x: 4000, y: 4000}
  m_TitleContent:
    m_Text: Navigation
    m_Image: {fileID: 1087843850482249999, guid: 0000000000000000d000000000000000, type: 0}
    m_Tooltip: 
  m_Pos:
    serializedVersion: 2
    x: 1564
    y: 73
    width: 355
    height: 614
  m_ViewDataDictionary: {fileID: 0}
--- !u!114 &26
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12003, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_MinSize: {x: 100, y: 100}
  m_MaxSize: {x: 4000, y: 4000}
  m_TitleContent:
    m_Text: Console
    m_Image: {fileID: -4327648978806127646, guid: 0000000000000000d000000000000000, type: 0}
    m_Tooltip: 
  m_Pos:
    serializedVersion: 2
    x: 0
    y: 583
    width: 1920
    height: 426
  m_ViewDataDictionary: {fileID: 0}
--- !u!114 &27
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 12014, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_MinSize: {x: 230, y: 250}
  m_MaxSize: {x: 10000, y: 10000}
  m_TitleContent:
    m_Text: Project
    m_Image: {fileID: -5467254957812901981, guid: 0000000000000000d000000000000000, type: 0}
    m_Tooltip: 
  m_Pos:
    serializedVersion: 2
    x: 0
    y: 583
    width: 1920
    height: 426
  m_ViewDataDictionary: {fileID: 0}
  m_SearchFilter:
    m_NameFilter: 
    m_ClassNames: []
    m_AssetLabels: []
    m_AssetBundleNames: []
    m_VersionControlStates: []
    m_SoftLockControlStates: []
    m_ReferencingInstanceIDs: 
    m_SceneHandles: 
    m_ShowAllHits: 0
    m_SkipHidden: 0
    m_SearchArea: 2
    m_Folders:
    - Packages/com.ciaranmalone.playtestingtool/Runtime/Trackers
    m_Globs: []
    m_OriginalText: 
  m_ViewMode: 1
  m_StartGridSize: 16
  m_LastFolders:
  - Packages/com.ciaranmalone.playtestingtool/Runtime/Trackers
  m_LastFoldersGridSize: 16
  m_LastProjectPath: C:\Users\Crayon\Documents\GitHub\PlayerMovementTracking
  m_LockTracker:
    m_IsLocked: 1
  m_FolderTreeState:
    scrollPos: {x: 0, y: 110}
    m_SelectedIDs: d6430000
    m_LastClickedID: 17366
    m_ExpandedIDs: 0000000076430000784300007a4300007c430000
    m_RenameOverlay:
      m_UserAcceptedRename: 0
      m_Name: 
      m_OriginalName: 
      m_EditFieldRect:
        serializedVersion: 2
        x: 0
        y: 0
        width: 0
        height: 0
      m_UserData: 0
      m_IsWaitingForDelay: 0
      m_IsRenaming: 0
      m_OriginalEventType: 11
      m_IsRenamingFilename: 1
      m_ClientGUIView: {fileID: 15}
    m_SearchString: 
    m_CreateAssetUtility:
      m_EndAction: {fileID: 0}
      m_InstanceID: 0
      m_Path: 
      m_Icon: {fileID: 0}
      m_ResourceFile: 
  m_AssetTreeState:
    scrollPos: {x: 0, y: 0}
    m_SelectedIDs: 
    m_LastClickedID: 0
    m_ExpandedIDs: 0000000076430000784300007a4300007c430000
    m_RenameOverlay:
      m_UserAcceptedRename: 0
      m_Name: 
      m_OriginalName: 
      m_EditFieldRect:
        serializedVersion: 2
        x: 0
        y: 0
        width: 0
        height: 0
      m_UserData: 0
      m_IsWaitingForDelay: 0
      m_IsRenaming: 0
      m_OriginalEventType: 11
      m_IsRenamingFilename: 1
      m_ClientGUIView: {fileID: 0}
    m_SearchString: 
    m_CreateAssetUtility:
      m_EndAction: {fileID: 0}
      m_InstanceID: 0
      m_Path: 
      m_Icon: {fileID: 0}
      m_ResourceFile: 
  m_ListAreaState:
    m_SelectedInstanceIDs: 
    m_LastClickedInstanceID: 0
    m_HadKeyboardFocusLastEvent: 0
    m_ExpandedInstanceIDs: 
    m_RenameOverlay:
      m_UserAcceptedRename: 0
      m_Name: 
      m_OriginalName: 
      m_EditFieldRect:
        serializedVersion: 2
        x: 0
        y: 0
        width: 0
        height: 0
      m_UserData: 0
      m_IsWaitingForDelay: 0
      m_IsRenaming: 0
      m_OriginalEventType: 11
      m_IsRenamingFilename: 1
      m_ClientGUIView: {fileID: 15}
    m_CreateAssetUtility:
      m_EndAction: {fileID: 0}
      m_InstanceID: 0
      m_Path: 
      m_Icon: {fileID: 0}
      m_ResourceFile: 
    m_NewAssetIndexInList: -1
    m_ScrollPosition: {x: 0, y: 0}
    m_GridSize: 16
  m_SkipHiddenPackages: 0
  m_DirectoriesAreaWidth: 172
--- !u!114 &28
MonoBehaviour:
  m_ObjectHideFlags: 52
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 1
  m_Script: {fileID: 12014, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_MinSize: {x: 230, y: 250}
  m_MaxSize: {x: 10000, y: 10000}
  m_TitleContent:
    m_Text: Project
    m_Image: {fileID: -5467254957812901981, guid: 0000000000000000d000000000000000, type: 0}
    m_Tooltip: 
  m_Pos:
    serializedVersion: 2
    x: 0
    y: 583
    width: 1920
    height: 426
  m_ViewDataDictionary: {fileID: 0}
  m_SearchFilter:
    m_NameFilter: 
    m_ClassNames: []
    m_AssetLabels: []
    m_AssetBundleNames: []
    m_VersionControlStates: []
    m_SoftLockControlStates: []
    m_ReferencingInstanceIDs: 
    m_SceneHandles: 
    m_ShowAllHits: 0
    m_SkipHidden: 0
    m_SearchArea: 1
    m_Folders:
    - Assets
    m_Globs: []
    m_OriginalText: 
  m_ViewMode: 1
  m_StartGridSize: 16
  m_LastFolders:
  - Assets
  m_LastFoldersGridSize: 16
  m_LastProjectPath: C:\Users\Crayon\Documents\GitHub\PlayerMovementTracking
  m_LockTracker:
    m_IsLocked: 0
  m_FolderTreeState:
    scrollPos: {x: 0, y: 0}
    m_SelectedIDs: 76430000
    m_LastClickedID: 17270
    m_ExpandedIDs: 0000000076430000784300007a4300007c430000
    m_RenameOverlay:
      m_UserAcceptedRename: 0
      m_Name: 
      m_OriginalName: 
      m_EditFieldRect:
        serializedVersion: 2
        x: 0
        y: 0
        width: 0
        height: 0
      m_UserData: 0
      m_IsWaitingForDelay: 0
      m_IsRenaming: 0
      m_OriginalEventType: 11
      m_IsRenamingFilename: 1
      m_ClientGUIView: {fileID: 15}
    m_SearchString: 
    m_CreateAssetUtility:
      m_EndAction: {fileID: 0}
      m_InstanceID: 0
      m_Path: 
      m_Icon: {fileID: 0}
      m_ResourceFile: 
  m_AssetTreeState:
    scrollPos: {x: 0, y: 0}
    m_SelectedIDs: 
    m_LastClickedID: 0
    m_ExpandedIDs: 0000000076430000784300007a4300007c430000
    m_RenameOverlay:
      m_UserAcceptedRename: 0
      m_Name: 
      m_OriginalName: 
      m_EditFieldRect:
        serializedVersion: 2
        x: 0
        y: 0
        width: 0
        height: 0
      m_UserData: 0
      m_IsWaitingForDelay: 0
      m_IsRenaming: 0
      m_OriginalEventType: 11
      m_IsRenamingFilename: 1
      m_ClientGUIView: {fileID: 0}
    m_SearchString: 
    m_CreateAssetUtility:
      m_EndAction: {fileID: 0}
      m_InstanceID: 0
      m_Path: 
      m_Icon: {fileID: 0}
      m_ResourceFile: 
  m_ListAreaState:
    m_SelectedInstanceIDs: 
    m_LastClickedInstanceID: 0
    m_HadKeyboardFocusLastEvent: 0
    m_ExpandedInstanceIDs: c6230000
    m_RenameOverlay:
      m_UserAcceptedRename: 0
      m_Name: 
      m_OriginalName: 
      m_EditFieldRect:
        serializedVersion: 2
        x: 0
        y: 0
        width: 0
        height: 0
      m_UserData: 0
      m_IsWaitingForDelay: 0
      m_IsRenaming: 0
      m_OriginalEventType: 11
      m_IsRenamingFilename: 1
      m_ClientGUIView: {fileID: 15}
    m_CreateAssetUtility:
      m_EndAction: {fileID: 0}
      m_InstanceID: 0
      m_Path: 
      m_Icon: {fileID: 0}
      m_ResourceFile: 
    m_NewAssetIndexInList: -1
    m_ScrollPosition: {x: 0, y: 0}
    m_GridSize: 16
  m_SkipHiddenPackages: 0
  m_DirectoriesAreaWidth: 232
--- !u!114 &29
MonoBehaviour:
  m_ObjectHideFlags: 0
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 13963, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: 
  m_EditorClassIdentifier: 
  m_DontSaveToLayout: 0
