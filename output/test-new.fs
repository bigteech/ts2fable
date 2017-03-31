yarn test v0.21.3
$ node ./dist/ts2fable ./node_modules/@types/electron/index.d.ts 
namespace Fable.Import
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import.JS

type [<AllowNullLiteral>] Document =
    abstract createElement: ``[object Object]``: obj -> obj

and [<AllowNullLiteral>] Window =
    abstract ``open``: ``[object Object]``: string * ?``[object Object]``: string * ?``[object Object]``: string -> obj

and [<AllowNullLiteral>] File =
    abstract path: obj with get, set

and [<AllowNullLiteral>] NodeRequireFunction =
    [<Emit("$0($1...)")>] abstract Invoke: ``[object Object]``: obj -> obj

module Electron =
    type [<AllowNullLiteral>] Event =
        abstract preventDefault: obj with get, set
        abstract sender: obj with get, set

    and Point =
        obj

    and Size =
        obj

    and Rectangle =
        obj

    and [<AllowNullLiteral>] Destroyable =
        abstract destroy: unit -> obj
        abstract isDestroyed: unit -> obj

    and VibrancyType =
        obj

    and [<AllowNullLiteral>] App =
        inherit NodeJS.EventEmitter
        abstract commandLine: obj with get, set
        abstract dock: obj with get, set
        abstract on: ``[object Object]``: obj * ``[object Object]``: Function -> obj
        abstract on: ``[object Object]``: obj * ``[object Object]``: Func<Event, obj, unit> -> obj
        abstract on: ``[object Object]``: obj * ``[object Object]``: Func<Event, unit> -> obj
        abstract on: ``[object Object]``: obj * ``[object Object]``: Func<Event, float, unit> -> obj
        abstract on: ``[object Object]``: obj * ``[object Object]``: Func<Event, string, unit> -> obj
        abstract on: ``[object Object]``: obj * ``[object Object]``: Func<Event, string, obj, unit> -> obj
        abstract on: ``[object Object]``: obj * ``[object Object]``: Func<Event, BrowserWindow, unit> -> obj
        abstract on: ``[object Object]``: obj * ``[object Object]``: Func<Event, WebContents, unit> -> obj
        abstract on: ``[object Object]``: obj * ``[object Object]``: Func<Event, WebContents, string, string, Certificate, Func<bool, unit>, unit> -> obj
        abstract on: ``[object Object]``: obj * ``[object Object]``: Func<Event, WebContents, string, ResizeArray<Certificate>, Func<Certificate, unit>, unit> -> obj
        abstract on: ``[object Object]``: obj * ``[object Object]``: Func<Event, WebContents, LoginRequest, LoginAuthInfo, Func<string, string, unit>, unit> -> obj
        abstract on: ``[object Object]``: obj * ``[object Object]``: Func<Event, bool, unit> -> obj
        abstract on: ``[object Object]``: string * ``[object Object]``: Function -> obj
        abstract quit: unit -> obj
        abstract exit: ?``[object Object]``: float -> obj
        abstract relaunch: ?``[object Object]``: obj -> obj
        abstract isReady: unit -> obj
        abstract focus: unit -> obj
        abstract hide: unit -> obj
        abstract show: unit -> obj
        abstract getAppPath: unit -> obj
        abstract getPath: ``[object Object]``: AppPathName -> obj
        abstract setPath: ``[object Object]``: AppPathName * ``[object Object]``: string -> obj
        abstract getVersion: unit -> obj
        abstract getName: unit -> obj
        abstract setName: ``[object Object]``: string -> obj
        abstract getLocale: unit -> obj
        abstract addRecentDocument: ``[object Object]``: string -> obj
        abstract clearRecentDocuments: unit -> obj
        abstract setAsDefaultProtocolClient: ``[object Object]``: string * ?``[object Object]``: string * ?``[object Object]``: ResizeArray<string> -> obj
        abstract removeAsDefaultProtocolClient: ``[object Object]``: string * ?``[object Object]``: string * ?``[object Object]``: ResizeArray<string> -> obj
        abstract isDefaultProtocolClient: ``[object Object]``: string * ?``[object Object]``: string * ?``[object Object]``: ResizeArray<string> -> obj
        abstract setUserTasks: ``[object Object]``: ResizeArray<Task> -> obj
        abstract getJumpListSettings: unit -> obj
        abstract setJumpList: ``[object Object]``: ResizeArray<JumpListCategory> -> obj
        abstract makeSingleInstance: ``[object Object]``: Func<ResizeArray<string>, string, unit> -> obj
        abstract releaseSingleInstance: unit -> obj
        abstract setUserActivity: ``[object Object]``: string * ``[object Object]``: obj * ?``[object Object]``: string -> obj
        abstract getCurrentActivityType: unit -> obj
        abstract setAppUserModelId: ``[object Object]``: string -> obj
        abstract importCertificate: ``[object Object]``: ImportCertificateOptions * ``[object Object]``: Func<float, unit> -> obj
        abstract disableHardwareAcceleration: unit -> obj
        abstract setBadgeCount: ``[object Object]``: float -> obj
        abstract getBadgeCount: unit -> obj
        abstract isUnityRunning: unit -> obj
        abstract isAccessibilitySupportEnabled: unit -> obj
        abstract getLoginItemSettings: unit -> obj
        abstract setLoginItemSettings: ``[object Object]``: LoginItemSettings -> obj
        abstract setAboutPanelOptions: ``[object Object]``: AboutPanelOptions -> obj

    and AppPathName =
        obj

    and [<AllowNullLiteral>] ImportCertificateOptions =
        abstract certificate: obj with get, set
        abstract password: obj with get, set

    and [<AllowNullLiteral>] CommandLine =
        abstract appendSwitch: ``[object Object]``: string * ?``[object Object]``: string -> obj
        abstract appendArgument: ``[object Object]``: string -> obj

    and [<AllowNullLiteral>] Dock =
        abstract bounce: ?``[object Object]``: U2<obj, obj> -> obj
        abstract cancelBounce: ``[object Object]``: float -> obj
        abstract downloadFinished: ``[object Object]``: string -> obj
        abstract setBadge: ``[object Object]``: string -> obj
        abstract getBadge: unit -> obj
        abstract hide: unit -> obj
        abstract show: unit -> obj
        abstract isVisible: unit -> obj
        abstract setMenu: ``[object Object]``: Menu -> obj
        abstract setIcon: ``[object Object]``: U2<NativeImage, string> -> obj

    and [<AllowNullLiteral>] Task =
        abstract program: obj with get, set
        abstract arguments: obj with get, set
        abstract title: obj with get, set
        abstract description: obj with get, set
        abstract iconPath: obj with get, set
        abstract iconIndex: obj with get, set

    and SetJumpListResult =
        obj

    and [<AllowNullLiteral>] JumpListSettings =
        abstract minItems: obj with get, set
        abstract removedItems: obj with get, set

    and [<AllowNullLiteral>] JumpListCategory =
        abstract ``type``: obj with get, set
        abstract name: obj with get, set
        abstract items: obj with get, set

    and [<AllowNullLiteral>] JumpListItem =
        abstract ``type``: obj with get, set
        abstract path: obj with get, set
        abstract program: obj with get, set
        abstract args: obj with get, set
        abstract title: obj with get, set
        abstract description: obj with get, set
        abstract iconPath: obj with get, set
        abstract iconIndex: obj with get, set

    and [<AllowNullLiteral>] LoginItemSettings =
        abstract openAtLogin: obj with get, set
        abstract openAsHidden: obj with get, set
        abstract wasOpenedAtLogin: obj with get, set
        abstract wasOpenedAsHidden: obj with get, set
        abstract restoreState: obj with get, set

    and [<AllowNullLiteral>] AboutPanelOptions =
        abstract applicationName: obj with get, set
        abstract applicationVersion: obj with get, set
        abstract copyright: obj with get, set
        abstract credits: obj with get, set
        abstract version: obj with get, set

    and [<AllowNullLiteral>] AutoUpdater =
        inherit NodeJS.EventEmitter
        abstract on: ``[object Object]``: obj * ``[object Object]``: Func<Error, unit> -> obj
        abstract on: ``[object Object]``: obj * ``[object Object]``: Function -> obj
        abstract on: ``[object Object]``: obj * ``[object Object]``: Func<Event, string, string, DateTime, string, unit> -> obj
        abstract on: ``[object Object]``: string * ``[object Object]``: Function -> obj
        abstract setFeedURL: ``[object Object]``: string * ?``[object Object]``: Headers -> obj
        abstract getFeedURL: unit -> obj
        abstract checkForUpdates: unit -> obj
        abstract quitAndInstall: unit -> obj

    and [<AllowNullLiteral>] [<Import("BrowserWindow","Electron")>] BrowserWindow(?``[object Object]``: BrowserWindowOptions) =
        interface NodeJS.EventEmitter
        interface Destroyable with
            member __.destroy(): obj = jsNative
            member __.isDestroyed(): obj = jsNative
        member __. with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __. with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.on(``[object Object]``: obj, ``[object Object]``: Func<Event, string, unit>): obj = jsNative
        member __.on(``[object Object]``: obj, ``[object Object]``: Func<Event, unit>): obj = jsNative
        member __.on(``[object Object]``: obj, ``[object Object]``: Function): obj = jsNative
        member __.on(``[object Object]``: obj, ``[object Object]``: Func<Event, SwipeDirection, unit>): obj = jsNative
        member __.on(``[object Object]``: string, ``[object Object]``: Function): obj = jsNative
        member __.getAllWindows(): obj = jsNative
        member __.getFocusedWindow(): obj = jsNative
        member __.fromWebContents(``[object Object]``: WebContents): obj = jsNative
        member __.fromId(``[object Object]``: float): obj = jsNative
        member __.addDevToolsExtension(``[object Object]``: string): obj = jsNative
        member __.removeDevToolsExtension(``[object Object]``: string): obj = jsNative
        member __.getDevToolsExtensions(): obj = jsNative
        member __.close(): obj = jsNative
        member __.focus(): obj = jsNative
        member __.blur(): obj = jsNative
        member __.isFocused(): obj = jsNative
        member __.show(): obj = jsNative
        member __.showInactive(): obj = jsNative
        member __.hide(): obj = jsNative
        member __.isVisible(): obj = jsNative
        member __.isModal(): obj = jsNative
        member __.maximize(): obj = jsNative
        member __.unmaximize(): obj = jsNative
        member __.isMaximized(): obj = jsNative
        member __.minimize(): obj = jsNative
        member __.restore(): obj = jsNative
        member __.isMinimized(): obj = jsNative
        member __.setFullScreen(``[object Object]``: bool): obj = jsNative
        member __.isFullScreen(): obj = jsNative
        member __.setAspectRatio(``[object Object]``: float, ?``[object Object]``: Size): obj = jsNative
        member __.previewFile(``[object Object]``: string, ?``[object Object]``: string): obj = jsNative
        member __.setBounds(``[object Object]``: Rectangle, ?``[object Object]``: bool): obj = jsNative
        member __.getBounds(): obj = jsNative
        member __.setContentBounds(``[object Object]``: Rectangle, ?``[object Object]``: bool): obj = jsNative
        member __.getContentBounds(): obj = jsNative
        member __.setSize(``[object Object]``: float, ``[object Object]``: float, ?``[object Object]``: bool): obj = jsNative
        member __.getSize(): obj = jsNative
        member __.setContentSize(``[object Object]``: float, ``[object Object]``: float, ?``[object Object]``: bool): obj = jsNative
        member __.getContentSize(): obj = jsNative
        member __.setMinimumSize(``[object Object]``: float, ``[object Object]``: float): obj = jsNative
        member __.getMinimumSize(): obj = jsNative
        member __.setMaximumSize(``[object Object]``: float, ``[object Object]``: float): obj = jsNative
        member __.getMaximumSize(): obj = jsNative
        member __.setResizable(``[object Object]``: bool): obj = jsNative
        member __.isResizable(): obj = jsNative
        member __.setMovable(``[object Object]``: bool): obj = jsNative
        member __.isMovable(): obj = jsNative
        member __.setMinimizable(``[object Object]``: bool): obj = jsNative
        member __.isMinimizable(): obj = jsNative
        member __.setMaximizable(``[object Object]``: bool): obj = jsNative
        member __.isMaximizable(): obj = jsNative
        member __.setFullScreenable(``[object Object]``: bool): obj = jsNative
        member __.isFullScreenable(): obj = jsNative
        member __.setClosable(``[object Object]``: bool): obj = jsNative
        member __.isClosable(): obj = jsNative
        member __.setAlwaysOnTop(``[object Object]``: bool, ?``[object Object]``: WindowLevel): obj = jsNative
        member __.isAlwaysOnTop(): obj = jsNative
        member __.center(): obj = jsNative
        member __.setPosition(``[object Object]``: float, ``[object Object]``: float, ?``[object Object]``: bool): obj = jsNative
        member __.getPosition(): obj = jsNative
        member __.setTitle(``[object Object]``: string): obj = jsNative
        member __.getTitle(): obj = jsNative
        member __.setSheetOffset(``[object Object]``: float, ?``[object Object]``: float): obj = jsNative
        member __.flashFrame(``[object Object]``: bool): obj = jsNative
        member __.setSkipTaskbar(``[object Object]``: bool): obj = jsNative
        member __.setKiosk(``[object Object]``: bool): obj = jsNative
        member __.isKiosk(): obj = jsNative
        member __.getNativeWindowHandle(): obj = jsNative
        member __.hookWindowMessage(``[object Object]``: float, ``[object Object]``: Function): obj = jsNative
        member __.isWindowMessageHooked(``[object Object]``: float): obj = jsNative
        member __.unhookWindowMessage(``[object Object]``: float): obj = jsNative
        member __.unhookAllWindowMessages(): obj = jsNative
        member __.setRepresentedFilename(``[object Object]``: string): obj = jsNative
        member __.getRepresentedFilename(): obj = jsNative
        member __.setDocumentEdited(``[object Object]``: bool): obj = jsNative
        member __.isDocumentEdited(): obj = jsNative
        member __.focusOnWebView(): obj = jsNative
        member __.blurWebView(): obj = jsNative
        member __.capturePage(``[object Object]``: Rectangle, ``[object Object]``: Func<NativeImage, unit>): obj = jsNative
        member __.capturePage(``[object Object]``: Func<NativeImage, unit>): obj = jsNative
        member __.loadURL(``[object Object]``: string, ?``[object Object]``: LoadURLOptions): obj = jsNative
        member __.reload(): obj = jsNative
        member __.setMenu(``[object Object]``: U2<Menu, obj>): obj = jsNative
        member __.setProgressBar(``[object Object]``: float, ?``[object Object]``: obj): obj = jsNative
        member __.setOverlayIcon(``[object Object]``: NativeImage, ``[object Object]``: string): obj = jsNative
        member __.setHasShadow(``[object Object]``: bool): obj = jsNative
        member __.hasShadow(): obj = jsNative
        member __.setThumbarButtons(``[object Object]``: ResizeArray<ThumbarButton>): obj = jsNative
        member __.setThumbnailClip(``[object Object]``: Rectangle): obj = jsNative
        member __.setThumbnailToolTip(``[object Object]``: string): obj = jsNative
        member __.showDefinitionForSelection(): obj = jsNative
        member __.setIcon(``[object Object]``: NativeImage): obj = jsNative
        member __.setAutoHideMenuBar(``[object Object]``: bool): obj = jsNative
        member __.isMenuBarAutoHide(): obj = jsNative
        member __.setMenuBarVisibility(``[object Object]``: bool): obj = jsNative
        member __.isMenuBarVisible(): obj = jsNative
        member __.setVisibleOnAllWorkspaces(``[object Object]``: bool): obj = jsNative
        member __.isVisibleOnAllWorkspaces(): obj = jsNative
        member __.setIgnoreMouseEvents(``[object Object]``: bool): obj = jsNative
        member __.setContentProtection(``[object Object]``: bool): obj = jsNative
        member __.setFocusable(``[object Object]``: bool): obj = jsNative
        member __.setParentWindow(``[object Object]``: BrowserWindow): obj = jsNative
        member __.getParentWindow(): obj = jsNative
        member __.getChildWindows(): obj = jsNative
        member __.setVibrancy(``[object Object]``: VibrancyType): obj = jsNative

    and WindowLevel =
        obj

    and SwipeDirection =
        U4<obj, obj, obj, obj>

    and ThumbarButtonFlags =
        obj

    and [<AllowNullLiteral>] ThumbarButton =
        abstract icon: obj with get, set
        abstract click: obj with get, set
        abstract tooltip: obj with get, set
        abstract flags: obj with get, set

    and [<AllowNullLiteral>] DevToolsExtensions =
        [<Emit("$0[$1]{{=$2}}")>] abstract Item: ``[object Object]``: string -> obj with get, set

    and [<AllowNullLiteral>] WebPreferences =
        abstract devTools: obj with get, set
        abstract nodeIntegration: obj with get, set
        abstract preload: obj with get, set
        abstract session: obj with get, set
        abstract partition: obj with get, set
        abstract zoomFactor: obj with get, set
        abstract javascript: obj with get, set
        abstract webSecurity: obj with get, set
        abstract allowDisplayingInsecureContent: obj with get, set
        abstract allowRunningInsecureContent: obj with get, set
        abstract images: obj with get, set
        abstract textAreasAreResizable: obj with get, set
        abstract webgl: obj with get, set
        abstract webaudio: obj with get, set
        abstract plugins: obj with get, set
        abstract experimentalFeatures: obj with get, set
        abstract experimentalCanvasFeatures: obj with get, set
        abstract directWrite: obj with get, set
        abstract scrollBounce: obj with get, set
        abstract blinkFeatures: obj with get, set
        abstract disableBlinkFeatures: obj with get, set
        abstract defaultFontFamily: obj with get, set
        abstract defaultFontSize: obj with get, set
        abstract defaultMonospaceFontSize: obj with get, set
        abstract minimumFontSize: obj with get, set
        abstract defaultEncoding: obj with get, set
        abstract backgroundThrottling: obj with get, set
        abstract offscreen: obj with get, set
        abstract sandbox: obj with get, set

    and [<AllowNullLiteral>] BrowserWindowOptions =
        abstract width: obj with get, set
        abstract height: obj with get, set
        abstract x: obj with get, set
        abstract y: obj with get, set
        abstract useContentSize: obj with get, set
        abstract center: obj with get, set
        abstract minWidth: obj with get, set
        abstract minHeight: obj with get, set
        abstract maxWidth: obj with get, set
        abstract maxHeight: obj with get, set
        abstract resizable: obj with get, set
        abstract movable: obj with get, set
        abstract minimizable: obj with get, set
        abstract maximizable: obj with get, set
        abstract closable: obj with get, set
        abstract focusable: obj with get, set
        abstract alwaysOnTop: obj with get, set
        abstract fullscreen: obj with get, set
        abstract fullscreenable: obj with get, set
        abstract skipTaskbar: obj with get, set
        abstract kiosk: obj with get, set
        abstract title: obj with get, set
        abstract icon: obj with get, set
        abstract show: obj with get, set
        abstract frame: obj with get, set
        abstract parent: obj with get, set
        abstract modal: obj with get, set
        abstract acceptFirstMouse: obj with get, set
        abstract disableAutoHideCursor: obj with get, set
        abstract autoHideMenuBar: obj with get, set
        abstract enableLargerThanScreen: obj with get, set
        abstract backgroundColor: obj with get, set
        abstract hasShadow: obj with get, set
        abstract darkTheme: obj with get, set
        abstract transparent: obj with get, set
        abstract ``type``: obj with get, set
        abstract titleBarStyle: obj with get, set
        abstract thickFrame: obj with get, set
        abstract vibrancy: obj with get, set
        abstract webPreferences: obj with get, set

    and BrowserWindowType =
        U3<BrowserWindowTypeLinux, BrowserWindowTypeMac, BrowserWindowTypeWindows>

    and BrowserWindowTypeLinux =
        obj

    and BrowserWindowTypeMac =
        U2<obj, obj>

    and BrowserWindowTypeWindows =
        obj

    and [<AllowNullLiteral>] Clipboard =
        abstract readText: ?``[object Object]``: ClipboardType -> obj
        abstract writeText: ``[object Object]``: string * ?``[object Object]``: ClipboardType -> obj
        abstract readHTML: ?``[object Object]``: ClipboardType -> obj
        abstract writeHTML: ``[object Object]``: string * ?``[object Object]``: ClipboardType -> obj
        abstract readImage: ?``[object Object]``: ClipboardType -> obj
        abstract writeImage: ``[object Object]``: NativeImage * ?``[object Object]``: ClipboardType -> obj
        abstract readRTF: ?``[object Object]``: ClipboardType -> obj
        abstract writeRTF: ``[object Object]``: string * ?``[object Object]``: ClipboardType -> obj
        abstract clear: ?``[object Object]``: ClipboardType -> obj
        abstract availableFormats: ?``[object Object]``: ClipboardType -> obj
        abstract has: ``[object Object]``: string * ?``[object Object]``: ClipboardType -> obj
        abstract read: ``[object Object]``: string * ?``[object Object]``: ClipboardType -> obj
        abstract write: ``[object Object]``: U4<obj, obj, obj, obj> * ?``[object Object]``: ClipboardType -> obj
        abstract readBookmark: unit -> obj
        abstract writeBookmark: ``[object Object]``: string * ``[object Object]``: string * ?``[object Object]``: ClipboardType -> obj
        abstract readFindText: unit -> obj
        abstract writeFindText: ``[object Object]``: string -> obj

    and ClipboardType =
        U2<obj, obj>

    and [<AllowNullLiteral>] Bookmark =
        abstract title: obj with get, set
        abstract url: obj with get, set

    and [<AllowNullLiteral>] ContentTracing =
        abstract getCategories: ``[object Object]``: Func<ResizeArray<string>, unit> -> obj
        abstract startRecording: ``[object Object]``: ContentTracingOptions * ``[object Object]``: Function -> obj
        abstract stopRecording: ``[object Object]``: string * ``[object Object]``: Func<string, unit> -> obj
        abstract startMonitoring: ``[object Object]``: ContentTracingOptions * ``[object Object]``: Function -> obj
        abstract stopMonitoring: ``[object Object]``: Function -> obj
        abstract captureMonitoringSnapshot: ``[object Object]``: string * ``[object Object]``: Func<string, unit> -> obj
        abstract getTraceBufferUsage: ``[object Object]``: Function -> obj
        abstract setWatchEvent: ``[object Object]``: string * ``[object Object]``: string * ``[object Object]``: Function -> obj
        abstract cancelWatchEvent: unit -> obj

    and [<AllowNullLiteral>] ContentTracingOptions =
        abstract categoryFilter: obj with get, set
        abstract traceOptions: obj with get, set

    and [<AllowNullLiteral>] CrashReporter =
        abstract start: ``[object Object]``: CrashReporterStartOptions -> obj
        abstract getLastCrashReport: unit -> obj
        abstract getUploadedReports: unit -> obj

    and [<AllowNullLiteral>] CrashReporterStartOptions =
        abstract productName: obj with get, set
        abstract companyName: obj with get, set
        abstract submitURL: obj with get, set
        abstract autoSubmit: obj with get, set
        abstract ignoreSystemCrashHandler: obj with get, set
        abstract extra: obj with get, set

    and [<AllowNullLiteral>] CrashReport =
        abstract id: obj with get, set
        abstract date: obj with get, set

    and [<AllowNullLiteral>] DesktopCapturer =
        abstract getSources: ``[object Object]``: DesktopCapturerOptions * ``[object Object]``: Func<Error, ResizeArray<DesktopCapturerSource>, obj> -> obj

    and [<AllowNullLiteral>] DesktopCapturerOptions =
        abstract types: obj with get, set
        abstract thumbnailSize: obj with get, set

    and [<AllowNullLiteral>] DesktopCapturerSource =
        abstract id: obj with get, set
        abstract name: obj with get, set
        abstract thumbnail: obj with get, set

    and [<AllowNullLiteral>] Dialog =
        abstract showOpenDialog: ``[object Object]``: BrowserWindow * ``[object Object]``: OpenDialogOptions * ?``[object Object]``: Func<ResizeArray<string>, unit> -> obj
        abstract showOpenDialog: ``[object Object]``: OpenDialogOptions * ?``[object Object]``: Func<ResizeArray<string>, unit> -> obj
        abstract showSaveDialog: ``[object Object]``: BrowserWindow * ``[object Object]``: SaveDialogOptions * ?``[object Object]``: Func<string, unit> -> obj
        abstract showSaveDialog: ``[object Object]``: SaveDialogOptions * ?``[object Object]``: Func<string, unit> -> obj
        abstract showMessageBox: ``[object Object]``: BrowserWindow * ``[object Object]``: ShowMessageBoxOptions * ?``[object Object]``: Func<float, unit> -> obj
        abstract showMessageBox: ``[object Object]``: ShowMessageBoxOptions * ?``[object Object]``: Func<float, unit> -> obj
        abstract showErrorBox: ``[object Object]``: string * ``[object Object]``: string -> obj

    and [<AllowNullLiteral>] OpenDialogOptions =
        abstract title: obj with get, set
        abstract defaultPath: obj with get, set
        abstract buttonLabel: obj with get, set
        abstract filters: obj with get, set
        abstract properties: obj with get, set

    and [<AllowNullLiteral>] SaveDialogOptions =
        abstract title: obj with get, set
        abstract defaultPath: obj with get, set
        abstract buttonLabel: obj with get, set
        abstract filters: obj with get, set

    and [<AllowNullLiteral>] ShowMessageBoxOptions =
        abstract ``type``: obj with get, set
        abstract buttons: obj with get, set
        abstract defaultId: obj with get, set
        abstract title: obj with get, set
        abstract message: obj with get, set
        abstract detail: obj with get, set
        abstract icon: obj with get, set
        abstract cancelId: obj with get, set
        abstract noLink: obj with get, set

    and [<AllowNullLiteral>] DownloadItem =
        inherit NodeJS.EventEmitter
        abstract on: ``[object Object]``: obj * ``[object Object]``: Func<Event, U2<obj, obj>, unit> -> obj
        abstract on: ``[object Object]``: obj * ``[object Object]``: Func<Event, U3<obj, obj, obj>, unit> -> obj
        abstract on: ``[object Object]``: string * ``[object Object]``: Function -> obj
        abstract setSavePath: ``[object Object]``: string -> obj
        abstract getSavePath: unit -> obj
        abstract pause: unit -> obj
        abstract isPaused: unit -> obj
        abstract resume: unit -> obj
        abstract canResume: unit -> obj
        abstract cancel: unit -> obj
        abstract getURL: unit -> obj
        abstract getMimeType: unit -> obj
        abstract hasUserGesture: unit -> obj
        abstract getFilename: unit -> obj
        abstract getTotalBytes: unit -> obj
        abstract getReceivedBytes: unit -> obj
        abstract getContentDisposition: unit -> obj
        abstract getState: unit -> obj

    and [<AllowNullLiteral>] GlobalShortcut =
        abstract register: ``[object Object]``: string * ``[object Object]``: Function -> obj
        abstract isRegistered: ``[object Object]``: string -> obj
        abstract unregister: ``[object Object]``: string -> obj
        abstract unregisterAll: unit -> obj

    and [<AllowNullLiteral>] IpcMain =
        inherit NodeJS.EventEmitter
        abstract addListener: ``[object Object]``: string * ``[object Object]``: IpcMainEventListener -> obj
        abstract on: ``[object Object]``: string * ``[object Object]``: IpcMainEventListener -> obj
        abstract once: ``[object Object]``: string * ``[object Object]``: IpcMainEventListener -> obj
        abstract removeListener: ``[object Object]``: string * ``[object Object]``: IpcMainEventListener -> obj
        abstract removeAllListeners: ?``[object Object]``: string -> obj

    and IpcMainEventListener =
        Func<IpcMainEvent, obj, unit>

    and [<AllowNullLiteral>] IpcMainEvent =
        abstract returnValue: obj with get, set
        abstract sender: obj with get, set

    and [<AllowNullLiteral>] IpcRenderer =
        inherit NodeJS.EventEmitter
        abstract addListener: ``[object Object]``: string * ``[object Object]``: IpcRendererEventListener -> obj
        abstract on: ``[object Object]``: string * ``[object Object]``: IpcRendererEventListener -> obj
        abstract once: ``[object Object]``: string * ``[object Object]``: IpcRendererEventListener -> obj
        abstract removeListener: ``[object Object]``: string * ``[object Object]``: IpcRendererEventListener -> obj
        abstract removeAllListeners: ?``[object Object]``: string -> obj
        abstract send: ``[object Object]``: string * [<ParamArray>] ``[object Object]``: obj[] -> obj
        abstract sendSync: ``[object Object]``: string * [<ParamArray>] ``[object Object]``: obj[] -> obj
        abstract sendToHost: ``[object Object]``: string * [<ParamArray>] ``[object Object]``: obj[] -> obj

    and IpcRendererEventListener =
        Func<IpcRendererEvent, obj, unit>

    and [<AllowNullLiteral>] IpcRendererEvent =
        abstract sender: obj with get, set

    and [<AllowNullLiteral>] [<Import("MenuItem","Electron")>] MenuItem(``[object Object]``: MenuItemOptions) =
        member __. with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __. with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __. with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __. with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __. with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __. with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __. with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __. with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __. with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __. with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __. with get(): obj = jsNative and set(v: obj): unit = jsNative

    and MenuItemType =
        obj

    and MenuItemRole =
        obj

    and MenuItemRoleMac =
        obj

    and [<AllowNullLiteral>] MenuItemOptions =
        abstract click: obj with get, set
        abstract ``type``: obj with get, set
        abstract label: obj with get, set
        abstract sublabel: obj with get, set
        abstract accelerator: obj with get, set
        abstract icon: obj with get, set
        abstract enabled: obj with get, set
        abstract visible: obj with get, set
        abstract ``checked``: obj with get, set
        abstract submenu: obj with get, set
        abstract id: obj with get, set
        abstract position: obj with get, set
        abstract role: obj with get, set

    and [<AllowNullLiteral>] [<Import("Menu","Electron")>] Menu() =
        interface NodeJS.EventEmitter
        member __. with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.setApplicationMenu(``[object Object]``: Menu): obj = jsNative
        member __.getApplicationMenu(): obj = jsNative
        member __.sendActionToFirstResponder(``[object Object]``: string): obj = jsNative
        member __.buildFromTemplate(``[object Object]``: ResizeArray<MenuItemOptions>): obj = jsNative
        member __.popup(?``[object Object]``: BrowserWindow, ?``[object Object]``: float, ?``[object Object]``: float): obj = jsNative
        member __.append(``[object Object]``: MenuItem): obj = jsNative
        member __.insert(``[object Object]``: float, ``[object Object]``: MenuItem): obj = jsNative

    and [<AllowNullLiteral>] [<Import("NativeImage","Electron")>] NativeImage() =
        member __.createEmpty(): obj = jsNative
        member __.createFromPath(``[object Object]``: string): obj = jsNative
        member __.createFromBuffer(``[object Object]``: Buffer, ?``[object Object]``: float): obj = jsNative
        member __.createFromDataURL(``[object Object]``: string): obj = jsNative
        member __.toPNG(): obj = jsNative
        member __.toJPEG(``[object Object]``: float): obj = jsNative
        member __.toBitmap(): obj = jsNative
        member __.getBitmap(): obj = jsNative
        member __.toDataURL(): obj = jsNative
        member __.getNativeHandle(): obj = jsNative
        member __.isEmpty(): obj = jsNative
        member __.getSize(): obj = jsNative
        member __.setTemplateImage(``[object Object]``: bool): obj = jsNative
        member __.isTemplateImage(): obj = jsNative

    and [<AllowNullLiteral>] Net =
        inherit NodeJS.EventEmitter
        abstract request: ``[object Object]``: U2<string, RequestOptions> * ?``[object Object]``: Func<IncomingMessage, unit> -> obj

    and [<AllowNullLiteral>] RequestOptions =
        abstract ``method``: obj with get, set
        abstract url: obj with get, set
        abstract session: obj with get, set
        abstract partition: obj with get, set
        abstract protocol: obj with get, set
        abstract host: obj with get, set
        abstract hostname: obj with get, set
        abstract port: obj with get, set
        abstract path: obj with get, set
        abstract headers: obj with get, set

    and [<AllowNullLiteral>] [<Import("ClientRequest","Electron")>] ClientRequest(``[object Object]``: U2<string, RequestOptions>, ?``[object Object]``: Func<IncomingMessage, unit>) =
        interface NodeJS.EventEmitter
        member __. with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.on(``[object Object]``: obj, ``[object Object]``: Func<IncomingMessage, unit>): obj = jsNative
        member __.on(``[object Object]``: obj, ``[object Object]``: Func<LoginAuthInfo, Func<string, string, unit>, unit>): obj = jsNative
        member __.on(``[object Object]``: obj, ``[object Object]``: Func<unit, unit>): obj = jsNative
        member __.on(``[object Object]``: obj, ``[object Object]``: Func<Error, unit>): obj = jsNative
        member __.on(``[object Object]``: string, ``[object Object]``: Function): obj = jsNative
        member __.setHeader(``[object Object]``: string, ``[object Object]``: string): obj = jsNative
        member __.getHeader(``[object Object]``: string): obj = jsNative
        member __.removeHeader(``[object Object]``: string): obj = jsNative
        member __.write(``[object Object]``: U2<string, Buffer>, ?``[object Object]``: string, ?``[object Object]``: Function): obj = jsNative
        member __.``end``(?``[object Object]``: U2<string, Buffer>, ?``[object Object]``: string, ?``[object Object]``: Function): obj = jsNative
        member __.abort(): obj = jsNative

    and [<AllowNullLiteral>] IncomingMessage =
        inherit NodeJS.ReadableStream
        abstract statusCode: obj with get, set
        abstract statusMessage: obj with get, set
        abstract headers: obj with get, set
        abstract httpVersion: obj with get, set
        abstract httpVersionMajor: obj with get, set
        abstract httpVersionMinor: obj with get, set
        abstract on: ``[object Object]``: obj * ``[object Object]``: Func<Buffer, unit> -> obj
        abstract on: ``[object Object]``: obj * ``[object Object]``: Func<unit, unit> -> obj
        abstract on: ``[object Object]``: obj * ``[object Object]``: Func<Error, unit> -> obj
        abstract on: ``[object Object]``: string * ``[object Object]``: Function -> obj

    and [<AllowNullLiteral>] PowerMonitor =
        inherit NodeJS.EventEmitter
        abstract on: ``[object Object]``: obj * ``[object Object]``: Function -> obj
        abstract on: ``[object Object]``: string * ``[object Object]``: Function -> obj

    and [<AllowNullLiteral>] PowerSaveBlocker =
        abstract start: ``[object Object]``: U2<obj, obj> -> obj
        abstract stop: ``[object Object]``: float -> obj
        abstract isStarted: ``[object Object]``: float -> obj

    and [<AllowNullLiteral>] Protocol =
        abstract registerStandardSchemes: ``[object Object]``: ResizeArray<string> -> obj
        abstract registerServiceWorkerSchemes: ``[object Object]``: ResizeArray<string> -> obj
        abstract registerFileProtocol: ``[object Object]``: string * ``[object Object]``: FileProtocolHandler * ?``[object Object]``: Func<Error, unit> -> obj
        abstract registerBufferProtocol: ``[object Object]``: string * ``[object Object]``: BufferProtocolHandler * ?``[object Object]``: Func<Error, unit> -> obj
        abstract registerStringProtocol: ``[object Object]``: string * ``[object Object]``: StringProtocolHandler * ?``[object Object]``: Func<Error, unit> -> obj
        abstract registerHttpProtocol: ``[object Object]``: string * ``[object Object]``: HttpProtocolHandler * ?``[object Object]``: Func<Error, unit> -> obj
        abstract unregisterProtocol: ``[object Object]``: string * ?``[object Object]``: Func<Error, unit> -> obj
        abstract isProtocolHandled: ``[object Object]``: string * ``[object Object]``: Func<bool, unit> -> obj
        abstract interceptFileProtocol: ``[object Object]``: string * ``[object Object]``: FileProtocolHandler * ?``[object Object]``: Func<Error, unit> -> obj
        abstract interceptBufferProtocol: ``[object Object]``: string * ``[object Object]``: BufferProtocolHandler * ?``[object Object]``: Func<Error, unit> -> obj
        abstract interceptStringProtocol: ``[object Object]``: string * ``[object Object]``: StringProtocolHandler * ?``[object Object]``: Func<Error, unit> -> obj
        abstract interceptHttpProtocol: ``[object Object]``: string * ``[object Object]``: HttpProtocolHandler * ?``[object Object]``: Func<Error, unit> -> obj
        abstract uninterceptProtocol: ``[object Object]``: string * ?``[object Object]``: Func<Error, unit> -> obj

    and FileProtocolHandler =
        Func<ProtocolRequest, FileProtocolCallback, unit>

    and BufferProtocolHandler =
        Func<ProtocolRequest, BufferProtocolCallback, unit>

    and StringProtocolHandler =
        Func<ProtocolRequest, StringProtocolCallback, unit>

    and HttpProtocolHandler =
        Func<ProtocolRequest, HttpProtocolCallback, unit>

    and [<AllowNullLiteral>] ProtocolRequest =
        abstract url: obj with get, set
        abstract referrer: obj with get, set
        abstract ``method``: obj with get, set
        abstract uploadData: obj with get, set

    and [<AllowNullLiteral>] ProtocolCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``[object Object]``: float -> obj
        [<Emit("$0($1...)")>] abstract Invoke: ``[object Object]``: obj -> obj
        [<Emit("$0($1...)")>] abstract Invoke: unit -> obj

    and [<AllowNullLiteral>] FileProtocolCallback =
        inherit ProtocolCallback
        [<Emit("$0($1...)")>] abstract Invoke: ``[object Object]``: string -> obj
        [<Emit("$0($1...)")>] abstract Invoke: ``[object Object]``: obj -> obj

    and [<AllowNullLiteral>] BufferProtocolCallback =
        inherit ProtocolCallback
        [<Emit("$0($1...)")>] abstract Invoke: ``[object Object]``: Buffer -> obj
        [<Emit("$0($1...)")>] abstract Invoke: ``[object Object]``: obj -> obj

    and [<AllowNullLiteral>] StringProtocolCallback =
        inherit ProtocolCallback
        [<Emit("$0($1...)")>] abstract Invoke: ``[object Object]``: string -> obj
        [<Emit("$0($1...)")>] abstract Invoke: ``[object Object]``: obj -> obj

    and [<AllowNullLiteral>] HttpProtocolCallback =
        inherit ProtocolCallback
        [<Emit("$0($1...)")>] abstract Invoke: ``[object Object]``: obj -> obj

    and [<AllowNullLiteral>] Remote =
        inherit CommonElectron
        abstract ``process``: obj with get, set
        abstract require: ``[object Object]``: string -> obj
        abstract getCurrentWindow: unit -> obj
        abstract getCurrentWebContents: unit -> obj
        abstract getGlobal: ``[object Object]``: string -> obj

    and [<AllowNullLiteral>] Display =
        abstract id: obj with get, set
        abstract bounds: obj with get, set
        abstract workArea: obj with get, set
        abstract size: obj with get, set
        abstract workAreaSize: obj with get, set
        abstract scaleFactor: obj with get, set
        abstract rotation: obj with get, set
        abstract touchSupport: obj with get, set

    and DisplayMetrics =
        U4<obj, obj, obj, obj>

    and [<AllowNullLiteral>] Screen =
        inherit NodeJS.EventEmitter
        abstract on: ``[object Object]``: obj * ``[object Object]``: Func<Event, Display, unit> -> obj
        abstract on: ``[object Object]``: obj * ``[object Object]``: Func<Event, Display, ResizeArray<DisplayMetrics>, unit> -> obj
        abstract on: ``[object Object]``: string * ``[object Object]``: Function -> obj
        abstract getCursorScreenPoint: unit -> obj
        abstract getPrimaryDisplay: unit -> obj
        abstract getAllDisplays: unit -> obj
        abstract getDisplayNearestPoint: ``[object Object]``: Point -> obj
        abstract getDisplayMatching: ``[object Object]``: Rectangle -> obj

    and [<AllowNullLiteral>] [<Import("Session","Electron")>] Session() =
        interface NodeJS.EventEmitter
        member __. with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __. with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __. with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __. with get(): obj = jsNative and set(v: obj): unit = jsNative
        member __.fromPartition(``[object Object]``: string, ?``[object Object]``: FromPartitionOptions): obj = jsNative
        member __.on(``[object Object]``: obj, ``[object Object]``: Func<Event, DownloadItem, WebContents, unit>): obj = jsNative
        member __.on(``[object Object]``: string, ``[object Object]``: Function): obj = jsNative
        member __.getCacheSize(``[object Object]``: Func<float, unit>): obj = jsNative
        member __.clearCache(``[object Object]``: Function): obj = jsNative
        member __.clearStorageData(``[object Object]``: Function): obj = jsNative
        member __.clearStorageData(``[object Object]``: ClearStorageDataOptions, ``[object Object]``: Function): obj = jsNative
        member __.flushStorageData(): obj = jsNative
        member __.setProxy(``[object Object]``: ProxyConfig, ``[object Object]``: Function): obj = jsNative
        member __.resolveProxy(``[object Object]``: URL, ``[object Object]``: Func<string, unit>): obj = jsNative
        member __.setDownloadPath(``[object Object]``: string): obj = jsNative
        member __.enableNetworkEmulation(``[object Object]``: NetworkEmulationOptions): obj = jsNative
        member __.disableNetworkEmulation(): obj = jsNative
        member __.setCertificateVerifyProc(``[object Object]``: U2<Func<string, Certificate, Func<bool, unit>, unit>, obj>): obj = jsNative
        member __.setPermissionRequestHandler(``[object Object]``: Func<WebContents, Permission, Func<bool, unit>, unit>): obj = jsNative
        member __.clearHostResolverCache(``[object Object]``: Function): obj = jsNative
        member __.allowNTLMCredentialsForDomains(``[object Object]``: string): obj = jsNative
        member __.setUserAgent(``[object Object]``: string, ?``[object Object]``: string): obj = jsNative
        member __.getUserAgent(): obj = jsNative
        member __.getBlobData(``[object Object]``: string, ``[object Object]``: Func<Buffer, unit>): obj = jsNative

    and Permission =
        obj

    and [<AllowNullLiteral>] FromPartitionOptions =
        abstract cache: obj with get, set

    and [<AllowNullLiteral>] ClearStorageDataOptions =
        abstract origin: obj with get, set
        abstract storages: obj with get, set
        abstract quotas: obj with get, set

    and [<AllowNullLiteral>] ProxyConfig =
        abstract pacScript: obj with get, set
        abstract proxyRules: obj with get, set
        abstract proxyBypassRules: obj with get, set

    and [<AllowNullLiteral>] NetworkEmulationOptions =
        abstract offline: obj with get, set
        abstract latency: obj with get, set
        abstract downloadThroughput: obj with get, set
        abstract uploadThroughput: obj with get, set

    and [<AllowNullLiteral>] CookieFilter =
        abstract url: obj with get, set
        abstract name: obj with get, set
        abstract domain: obj with get, set
        abstract path: obj with get, set
        abstract secure: obj with get, set
        abstract session: obj with get, set

    and [<AllowNullLiteral>] Cookie =
        abstract name: obj with get, set
        abstract value: obj with get, set
        abstract domain: obj with get, set
        abstract hostOnly: obj with get, set
        abstract path: obj with get, set
        abstract secure: obj with get, set
        abstract httpOnly: obj with get, set
        abstract session: obj with get, set
        abstract expirationDate: obj with get, set
        abstract on: ``[object Object]``: obj * ``[object Object]``: Func<Event, Cookie, CookieChangedCause, unit> -> obj
        abstract on: ``[object Object]``: string * ``[object Object]``: Function -> obj

    and CookieChangedCause =
        obj

    and [<AllowNullLiteral>] CookieDetails =
        abstract url: obj with get, set
        abstract name: obj with get, set
        abstract value: obj with get, set
        abstract domain: obj with get, set
        abstract path: obj with get, set
        abstract secure: obj with get, set
        abstract httpOnly: obj with get, set
        abstract expirationDate: obj with get, set

    and [<AllowNullLiteral>] SessionCookies =
        abstract get: ``[object Object]``: CookieFilter * ``[object Object]``: Func<Error, ResizeArray<Cookie>, unit> -> obj
        abstract set: ``[object Object]``: CookieDetails * ``[object Object]``: Func<Error, unit> -> obj
        abstract remove: ``[object Object]``: string * ``[object Object]``: string * ``[object Object]``: Func<Error, unit> -> obj

    and [<AllowNullLiteral>] WebRequest =
        abstract onBeforeRequest: ``[object Object]``: Func<WebRequest.BeforeRequestDetails, WebRequest.BeforeRequestCallback, unit> -> obj
        abstract onBeforeRequest: ``[object Object]``: WebRequest.Filter * ``[object Object]``: Func<WebRequest.BeforeRequestDetails, WebRequest.BeforeRequestCallback, unit> -> obj
        abstract onBeforeSendHeaders: ``[object Object]``: Func<WebRequest.BeforeSendHeadersDetails, WebRequest.BeforeSendHeadersCallback, unit> -> obj
        abstract onBeforeSendHeaders: ``[object Object]``: WebRequest.Filter * ``[object Object]``: Func<WebRequest.BeforeSendHeadersDetails, WebRequest.BeforeSendHeadersCallback, unit> -> obj
        abstract onSendHeaders: ``[object Object]``: Func<WebRequest.SendHeadersDetails, unit> -> obj
        abstract onSendHeaders: ``[object Object]``: WebRequest.Filter * ``[object Object]``: Func<WebRequest.SendHeadersDetails, unit> -> obj
        abstract onHeadersReceived: ``[object Object]``: Func<WebRequest.HeadersReceivedDetails, WebRequest.HeadersReceivedCallback, unit> -> obj
        abstract onHeadersReceived: ``[object Object]``: WebRequest.Filter * ``[object Object]``: Func<WebRequest.HeadersReceivedDetails, WebRequest.HeadersReceivedCallback, unit> -> obj
        abstract onResponseStarted: ``[object Object]``: Func<WebRequest.ResponseStartedDetails, unit> -> obj
        abstract onResponseStarted: ``[object Object]``: WebRequest.Filter * ``[object Object]``: Func<WebRequest.ResponseStartedDetails, unit> -> obj
        abstract onBeforeRedirect: ``[object Object]``: Func<WebRequest.BeforeRedirectDetails, unit> -> obj
        abstract onBeforeRedirect: ``[object Object]``: WebRequest.Filter * ``[object Object]``: Func<WebRequest.BeforeRedirectDetails, unit> -> obj
        abstract onCompleted: ``[object Object]``: Func<WebRequest.CompletedDetails, unit> -> obj
        abstract onCompleted: ``[object Object]``: WebRequest.Filter * ``[object Object]``: Func<WebRequest.CompletedDetails, unit> -> obj
        abstract onErrorOccurred: ``[object Object]``: Func<WebRequest.ErrorOccurredDetails, unit> -> obj
        abstract onErrorOccurred: ``[object Object]``: WebRequest.Filter * ``[object Object]``: Func<WebRequest.ErrorOccurredDetails, unit> -> obj

    and [<AllowNullLiteral>] Shell =
        abstract showItemInFolder: ``[object Object]``: string -> obj
        abstract openItem: ``[object Object]``: string -> obj
        abstract openExternal: ``[object Object]``: string * ?``[object Object]``: obj -> obj
        abstract moveItemToTrash: ``[object Object]``: string -> obj
        abstract beep: unit -> obj
        abstract writeShortcutLink: ``[object Object]``: string * ``[object Object]``: ShortcutLinkOptions -> obj
        abstract writeShortcutLink: ``[object Object]``: string * ``[object Object]``: U3<obj, obj, obj> * ``[object Object]``: ShortcutLinkOptions -> obj
        abstract readShortcutLink: ``[object Object]``: string -> obj

    and [<AllowNullLiteral>] ShortcutLinkOptions =
        abstract target: obj with get, set
        abstract cwd: obj with get, set
        abstract args: obj with get, set
        abstract description: obj with get, set
        abstract icon: obj with get, set
        abstract iconIndex: obj with get, set
        abstract appUserModelId: obj with get, set

    and SystemColor =
        obj

    and [<AllowNullLiteral>] SystemPreferences =
        abstract on: ``[object Object]``: obj * ``[object Object]``: Func<Event, string, unit> -> obj
        abstract on: ``[object Object]``: obj * ``[object Object]``: Func<Event, unit> -> obj
        abstract on: ``[object Object]``: obj * ``[object Object]``: Func<Event, bool, unit> -> obj
        abstract on: ``[object Object]``: string * ``[object Object]``: Function -> obj
        abstract isDarkMode: unit -> obj
        abstract isSwipeTrackingFromScrollEventsEnabled: unit -> obj
        abstract postNotification: ``[object Object]``: string * ``[object Object]``: obj -> obj
        abstract postLocalNotification: ``[object Object]``: string * ``[object Object]``: obj -> obj
        abstract subscribeNotification: ``[object Object]``: string * ``[object Object]``: Func<Event, obj, unit> -> obj
        abstract unsubscribeNotification: ``[object Object]``: float -> obj
        abstract subscribeLocalNotification: ``[object Object]``: string * ``[object Object]``: Func<Event, obj, unit> -> obj
        abstract unsubscribeLocalNotification: ``[object Object]``: float -> obj
        abstract getUserDefault: ``[object Object]``: string * ``[object Object]``: obj -> obj
        abstract isAeroGlassEnabled: unit -> obj
        abstract getAccentColor: unit -> obj
        abstract isInvertedColorScheme: unit -> obj
        abstract getColor: ``[object Object]``: SystemColor -> obj

    and [<AllowNullLiteral>] [<Import("Tray","Electron")>] Tray(``[object Object]``: U2<NativeImage, string>) =
        interface NodeJS.EventEmitter
        interface Destroyable with
            member __.destroy(): obj = jsNative
            member __.isDestroyed(): obj = jsNative
        member __.on(``[object Object]``: obj, ``[object Object]``: Func<Modifiers, Rectangle, unit>): obj = jsNative
        member __.on(``[object Object]``: obj, ``[object Object]``: Function): obj = jsNative
        member __.on(``[object Object]``: obj, ``[object Object]``: Func<Event, ResizeArray<string>, unit>): obj = jsNative
        member __.on(``[object Object]``: obj, ``[object Object]``: Func<Event, string, unit>): obj = jsNative
        member __.on(``[object Object]``: string, ``[object Object]``: Function): obj = jsNative
        member __.setImage(``[object Object]``: U2<NativeImage, string>): obj = jsNative
        member __.setPressedImage(``[object Object]``: NativeImage): obj = jsNative
        member __.setToolTip(``[object Object]``: string): obj = jsNative
        member __.setTitle(``[object Object]``: string): obj = jsNative
        member __.setHighlightMode(``[object Object]``: U3<obj, obj, obj>): obj = jsNative
        member __.displayBalloon(?``[object Object]``: obj): obj = jsNative
        member __.popUpContextMenu(?``[object Object]``: Menu, ?``[object Object]``: Point): obj = jsNative
        member __.setContextMenu(``[object Object]``: Menu): obj = jsNative
        member __.getBounds(): obj = jsNative

    and [<AllowNullLiteral>] Modifiers =
        abstract altKey: obj with get, set
        abstract shiftKey: obj with get, set
        abstract ctrlKey: obj with get, set
        abstract metaKey: obj with get, set

    and [<AllowNullLiteral>] DragItem =
        abstract file: obj with get, set
        abstract icon: obj with get, set

    and [<AllowNullLiteral>] WebContentsStatic =
        abstract getAllWebContents: unit -> obj
        abstract getFocusedWebContents: unit -> obj
        abstract fromId: ``[object Object]``: float -> obj

    and [<AllowNullLiteral>] WebContents =
        inherit NodeJS.EventEmitter
        abstract id: obj with get, set
        abstract session: obj with get, set
        abstract hostWebContents: obj with get, set
        abstract devToolsWebContents: obj with get, set
        abstract debugger: obj with get, set
        abstract on: ``[object Object]``: obj * ``[object Object]``: Function -> obj
        abstract on: ``[object Object]``: obj * ``[object Object]``: Func<Event, float, string, string, bool, unit> -> obj
        abstract on: ``[object Object]``: obj * ``[object Object]``: Func<Event, bool, unit> -> obj
        abstract on: ``[object Object]``: obj * ``[object Object]``: Func<Event, bool, string, string, float, string, string, Headers, string, unit> -> obj
        abstract on: ``[object Object]``: obj * ``[object Object]``: Func<Event, string, string, bool, float, string, string, Headers, unit> -> obj
        abstract on: ``[object Object]``: obj * ``[object Object]``: Func<Event, unit> -> obj
        abstract on: ``[object Object]``: obj * ``[object Object]``: Func<Event, ResizeArray<string>, unit> -> obj
        abstract on: ``[object Object]``: obj * ``[object Object]``: Func<Event, string, string, NewWindowDisposition, BrowserWindowOptions, unit> -> obj
        abstract on: ``[object Object]``: obj * ``[object Object]``: Func<Event, string, unit> -> obj
        abstract on: ``[object Object]``: obj * ``[object Object]``: Func<Event, string, bool, unit> -> obj
        abstract on: ``[object Object]``: obj * ``[object Object]``: Func<Event, string, string, unit> -> obj
        abstract on: ``[object Object]``: obj * ``[object Object]``: Func<Event, string, string, Certificate, Func<bool, unit>, unit> -> obj
        abstract on: ``[object Object]``: obj * ``[object Object]``: Func<Event, string, ResizeArray<Certificate>, Func<Certificate, unit>, unit> -> obj
        abstract on: ``[object Object]``: obj * ``[object Object]``: Func<Event, LoginRequest, LoginAuthInfo, Func<string, string, unit>, unit> -> obj
        abstract on: ``[object Object]``: obj * ``[object Object]``: Func<Event, FoundInPageResult, unit> -> obj
        abstract on: ``[object Object]``: obj * ``[object Object]``: Func<Event, CursorType, NativeImage, float, Size, Point, unit> -> obj
        abstract on: ``[object Object]``: obj * ``[object Object]``: Func<Event, ContextMenuParams, unit> -> obj
        abstract on: ``[object Object]``: obj * ``[object Object]``: Func<Event, ResizeArray<BluetoothDevice>, Func<string, unit>, unit> -> obj
        abstract on: ``[object Object]``: obj * ``[object Object]``: Func<Event, Rectangle, NativeImage, unit> -> obj
        abstract on: ``[object Object]``: string * ``[object Object]``: Function -> obj
        abstract loadURL: ``[object Object]``: string * ?``[object Object]``: LoadURLOptions -> obj
        abstract downloadURL: ``[object Object]``: string -> obj
        abstract getURL: unit -> obj
        abstract getTitle: unit -> obj
        abstract isDestroyed: unit -> obj
        abstract isFocused: unit -> obj
        abstract isLoading: unit -> obj
        abstract isLoadingMainFrame: unit -> obj
        abstract isWaitingForResponse: unit -> obj
        abstract stop: unit -> obj
        abstract reload: unit -> obj
        abstract reloadIgnoringCache: unit -> obj
        abstract canGoBack: unit -> obj
        abstract canGoForward: unit -> obj
        abstract canGoToOffset: ``[object Object]``: float -> obj
        abstract clearHistory: unit -> obj
        abstract goBack: unit -> obj
        abstract goForward: unit -> obj
        abstract goToIndex: ``[object Object]``: float -> obj
        abstract goToOffset: ``[object Object]``: float -> obj
        abstract isCrashed: unit -> obj
        abstract setUserAgent: ``[object Object]``: string -> obj
        abstract getUserAgent: unit -> obj
        abstract insertCSS: ``[object Object]``: string -> obj
        abstract executeJavaScript: ``[object Object]``: string * ?``[object Object]``: bool * ?``[object Object]``: Func<obj, unit> -> obj
        abstract setAudioMuted: ``[object Object]``: bool -> obj
        abstract isAudioMuted: unit -> obj
        abstract setZoomFactor: ``[object Object]``: float -> obj
        abstract getZoomFactor: ``[object Object]``: Func<float, unit> -> obj
        abstract setZoomLevel: ``[object Object]``: float -> obj
        abstract getZoomLevel: ``[object Object]``: Func<float, unit> -> obj
        abstract setVisualZoomLevelLimits: ``[object Object]``: float * ``[object Object]``: float -> obj
        abstract setLayoutZoomLevelLimits: ``[object Object]``: float * ``[object Object]``: float -> obj
        abstract undo: unit -> obj
        abstract redo: unit -> obj
        abstract cut: unit -> obj
        abstract copy: unit -> obj
        abstract copyImageAt: ``[object Object]``: float * ``[object Object]``: float -> obj
        abstract paste: unit -> obj
        abstract pasteAndMatchStyle: unit -> obj
        abstract delete: unit -> obj
        abstract selectAll: unit -> obj
        abstract unselect: unit -> obj
        abstract replace: ``[object Object]``: string -> obj
        abstract replaceMisspelling: ``[object Object]``: string -> obj
        abstract insertText: ``[object Object]``: string -> obj
        abstract findInPage: ``[object Object]``: string * ?``[object Object]``: FindInPageOptions -> obj
        abstract stopFindInPage: ``[object Object]``: StopFindInPageAtion -> obj
        abstract hasServiceWorker: ``[object Object]``: Func<bool, unit> -> obj
        abstract unregisterServiceWorker: ``[object Object]``: Func<bool, unit> -> obj
        abstract print: ?``[object Object]``: PrintOptions -> obj
        abstract printToPDF: ``[object Object]``: PrintToPDFOptions * ``[object Object]``: Func<Error, Buffer, unit> -> obj
        abstract addWorkSpace: ``[object Object]``: string -> obj
        abstract removeWorkSpace: ``[object Object]``: string -> obj
        abstract openDevTools: ?``[object Object]``: obj -> obj
        abstract closeDevTools: unit -> obj
        abstract isDevToolsOpened: unit -> obj
        abstract isDevToolsFocused: unit -> obj
        abstract toggleDevTools: unit -> obj
        abstract inspectElement: ``[object Object]``: float * ``[object Object]``: float -> obj
        abstract inspectServiceWorker: unit -> obj
        abstract send: ``[object Object]``: string * [<ParamArray>] ``[object Object]``: obj[] -> obj
        abstract enableDeviceEmulation: ``[object Object]``: DeviceEmulationParameters -> obj
        abstract disableDeviceEmulation: unit -> obj
        abstract sendInputEvent: ``[object Object]``: SendInputEvent -> obj
        abstract beginFrameSubscription: ``[object Object]``: bool * ``[object Object]``: BeginFrameSubscriptionCallback -> obj
        abstract beginFrameSubscription: ``[object Object]``: BeginFrameSubscriptionCallback -> obj
        abstract endFrameSubscription: unit -> obj
        abstract savePage: ``[object Object]``: string * ``[object Object]``: U3<obj, obj, obj> * ?``[object Object]``: Func<Error, unit> -> obj
        abstract showDefinitionForSelection: unit -> obj
        abstract isOffscreen: unit -> obj
        abstract startPainting: unit -> obj
        abstract stopPainting: unit -> obj
        abstract isPainting: unit -> obj
        abstract setFrameRate: ``[object Object]``: float -> obj
        abstract getFrameRate: unit -> obj
        abstract invalidate: unit -> obj
        abstract startDrag: ``[object Object]``: DragItem -> obj
        abstract capturePage: ``[object Object]``: Func<NativeImage, unit> -> obj
        abstract capturePage: ``[object Object]``: Rectangle * ``[object Object]``: Func<NativeImage, unit> -> obj

    and [<AllowNullLiteral>] BeginFrameSubscriptionCallback =
        [<Emit("$0($1...)")>] abstract Invoke: ``[object Object]``: Buffer * ?``[object Object]``: Rectangle -> obj

    and [<AllowNullLiteral>] ContextMenuParams =
        abstract x: obj with get, set
        abstract y: obj with get, set
        abstract linkURL: obj with get, set
        abstract linkText: obj with get, set
        abstract pageURL: obj with get, set
        abstract frameURL: obj with get, set
        abstract srcURL: obj with get, set
        abstract mediaType: obj with get, set
        abstract mediaFlags: obj with get, set
        abstract hasImageContents: obj with get, set
        abstract isEditable: obj with get, set
        abstract editFlags: obj with get, set
        abstract selectionText: obj with get, set
        abstract titleText: obj with get, set
        abstract misspelledWord: obj with get, set
        abstract frameCharset: obj with get, set
        abstract inputFieldType: obj with get, set
        abstract menuSourceType: obj with get, set

    and [<AllowNullLiteral>] BluetoothDevice =
        abstract deviceName: obj with get, set
        abstract deviceId: obj with get, set

    and [<AllowNullLiteral>] Headers =
        [<Emit("$0[$1]{{=$2}}")>] abstract Item: ``[object Object]``: string -> obj with get, set

    and NewWindowDisposition =
        obj

    and StopFindInPageAtion =
        U3<obj, obj, obj>

    and CursorType =
        obj

    and [<AllowNullLiteral>] LoadURLOptions =
        abstract httpReferrer: obj with get, set
        abstract userAgent: obj with get, set
        abstract extraHeaders: obj with get, set
        abstract postData: obj with get, set

    and [<AllowNullLiteral>] UploadRawData =
        abstract ``type``: obj with get, set
        abstract bytes: obj with get, set

    and [<AllowNullLiteral>] UploadFileSystem =
        abstract ``type``: obj with get, set
        abstract fileSystemURL: obj with get, set
        abstract offset: obj with get, set
        abstract length: obj with get, set
        abstract modificationTime: obj with get, set

    and [<AllowNullLiteral>] UploadBlob =
        abstract ``type``: obj with get, set
        abstract blobUUID: obj with get, set

    and [<AllowNullLiteral>] PrintOptions =
        abstract silent: obj with get, set
        abstract printBackground: obj with get, set

    and [<AllowNullLiteral>] PrintToPDFOptions =
        abstract marginsType: obj with get, set
        abstract pageSize: obj with get, set
        abstract printBackground: obj with get, set
        abstract printSelectionOnly: obj with get, set
        abstract landscape: obj with get, set

    and [<AllowNullLiteral>] Certificate =
        abstract data: obj with get, set
        abstract issuer: obj with get, set
        abstract issuerName: obj with get, set
        abstract issuerCert: obj with get, set
        abstract subject: obj with get, set
        abstract subjectName: obj with get, set
        abstract serialNumber: obj with get, set
        abstract validStart: obj with get, set
        abstract validExpiry: obj with get, set
        abstract fingerprint: obj with get, set

    and [<AllowNullLiteral>] CertificatePrincipal =
        abstract commonName: obj with get, set
        abstract organizations: obj with get, set
        abstract organizationUnits: obj with get, set
        abstract locality: obj with get, set
        abstract state: obj with get, set
        abstract country: obj with get, set

    and [<AllowNullLiteral>] LoginRequest =
        abstract ``method``: obj with get, set
        abstract url: obj with get, set
        abstract referrer: obj with get, set

    and [<AllowNullLiteral>] LoginAuthInfo =
        abstract isProxy: obj with get, set
        abstract scheme: obj with get, set
        abstract host: obj with get, set
        abstract port: obj with get, set
        abstract realm: obj with get, set

    and [<AllowNullLiteral>] FindInPageOptions =
        abstract forward: obj with get, set
        abstract findNext: obj with get, set
        abstract matchCase: obj with get, set
        abstract wordStart: obj with get, set
        abstract mediaDone in 0.70s.
