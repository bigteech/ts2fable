yarn test-orig v0.21.3
$ node ./orig/ts2fable.js ./node_modules/@types/electron/index.d.ts 
namespace Fable.Import
open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import.JS

type [<AllowNullLiteral>] Document =
    abstract createElement: tagName: obj -> Electron.WebViewElement

and [<AllowNullLiteral>] Window =
    abstract ``open``: url: string * ?frameName: string * ?features: string -> Electron.BrowserWindowProxy

and [<AllowNullLiteral>] File =
    abstract path: string with get, set

and [<AllowNullLiteral>] NodeRequireFunction =
    [<Emit("$0($1...)")>] abstract Invoke: moduleName: obj -> Electron.ElectronMainAndRenderer

module Electron =
    type [<AllowNullLiteral>] Event =
        abstract preventDefault: Function with get, set
        abstract sender: NodeJS.EventEmitter with get, set

    and Point =
        obj

    and Size =
        obj

    and Rectangle =
        obj

    and [<AllowNullLiteral>] Destroyable =
        abstract destroy: unit -> unit
        abstract isDestroyed: unit -> bool

    and VibrancyType =
        obj

    and [<AllowNullLiteral>] App =
        inherit NodeJS.EventEmitter
        abstract commandLine: CommandLine with get, set
        abstract dock: Dock with get, set
        abstract on: ``event``: obj * listener: Function -> obj
        abstract on: ``event``: obj * listener: Func<Event, obj, unit> -> obj
        abstract on: ``event``: obj * listener: Func<Event, unit> -> obj
        abstract on: ``event``: obj * listener: Func<Event, float, unit> -> obj
        abstract on: ``event``: obj * listener: Func<Event, string, unit> -> obj
        abstract on: ``event``: obj * listener: Func<Event, string, obj, unit> -> obj
        abstract on: ``event``: obj * listener: Func<Event, BrowserWindow, unit> -> obj
        abstract on: ``event``: obj * listener: Func<Event, WebContents, unit> -> obj
        abstract on: ``event``: obj * listener: Func<Event, WebContents, string, string, Certificate, Func<bool, unit>, unit> -> obj
        abstract on: ``event``: obj * listener: Func<Event, WebContents, string, ResizeArray<Certificate>, Func<Certificate, unit>, unit> -> obj
        abstract on: ``event``: obj * listener: Func<Event, WebContents, LoginRequest, LoginAuthInfo, Func<string, string, unit>, unit> -> obj
        abstract on: ``event``: obj * listener: Func<Event, bool, unit> -> obj
        abstract on: ``event``: string * listener: Function -> obj
        abstract quit: unit -> unit
        abstract exit: ?exitCode: float -> unit
        abstract relaunch: ?options: obj -> unit
        abstract isReady: unit -> bool
        abstract focus: unit -> unit
        abstract hide: unit -> unit
        abstract show: unit -> unit
        abstract getAppPath: unit -> string
        abstract getPath: name: AppPathName -> string
        abstract setPath: name: AppPathName * path: string -> unit
        abstract getVersion: unit -> string
        abstract getName: unit -> string
        abstract setName: name: string -> unit
        abstract getLocale: unit -> string
        abstract addRecentDocument: path: string -> unit
        abstract clearRecentDocuments: unit -> unit
        abstract setAsDefaultProtocolClient: protocol: string * ?path: string * ?args: ResizeArray<string> -> bool
        abstract removeAsDefaultProtocolClient: protocol: string * ?path: string * ?args: ResizeArray<string> -> bool
        abstract isDefaultProtocolClient: protocol: string * ?path: string * ?args: ResizeArray<string> -> bool
        abstract setUserTasks: tasks: ResizeArray<Task> -> bool
        abstract getJumpListSettings: unit -> JumpListSettings
        abstract setJumpList: categories: ResizeArray<JumpListCategory> -> SetJumpListResult
        abstract makeSingleInstance: callback: Func<ResizeArray<string>, string, unit> -> bool
        abstract releaseSingleInstance: unit -> unit
        abstract setUserActivity: ``type``: string * userInfo: obj * ?webpageURL: string -> unit
        abstract getCurrentActivityType: unit -> string
        abstract setAppUserModelId: id: string -> unit
        abstract importCertificate: options: ImportCertificateOptions * callback: Func<float, unit> -> unit
        abstract disableHardwareAcceleration: unit -> unit
        abstract setBadgeCount: count: float -> bool
        abstract getBadgeCount: unit -> float
        abstract isUnityRunning: unit -> bool
        abstract isAccessibilitySupportEnabled: unit -> bool
        abstract getLoginItemSettings: unit -> LoginItemSettings
        abstract setLoginItemSettings: settings: LoginItemSettings -> unit
        abstract setAboutPanelOptions: options: AboutPanelOptions -> unit

    and AppPathName =
        obj

    and [<AllowNullLiteral>] ImportCertificateOptions =
        abstract certificate: string with get, set
        abstract password: string with get, set

    and [<AllowNullLiteral>] CommandLine =
        abstract appendSwitch: _switch: string * ?value: string -> unit
        abstract appendArgument: value: string -> unit

    and [<AllowNullLiteral>] Dock =
        abstract bounce: ?``type``: U2<obj, obj> -> float
        abstract cancelBounce: id: float -> unit
        abstract downloadFinished: filePath: string -> unit
        abstract setBadge: text: string -> unit
        abstract getBadge: unit -> string
        abstract hide: unit -> unit
        abstract show: unit -> unit
        abstract isVisible: unit -> bool
        abstract setMenu: menu: Menu -> unit
        abstract setIcon: icon: U2<NativeImage, string> -> unit

    and [<AllowNullLiteral>] Task =
        abstract program: string with get, set
        abstract arguments: string with get, set
        abstract title: string with get, set
        abstract description: string option with get, set
        abstract iconPath: string with get, set
        abstract iconIndex: float option with get, set

    and SetJumpListResult =
        obj

    and [<AllowNullLiteral>] JumpListSettings =
        abstract minItems: float with get, set
        abstract removedItems: ResizeArray<JumpListItem> with get, set

    and [<AllowNullLiteral>] JumpListCategory =
        abstract ``type``: U4<obj, obj, obj, obj> option with get, set
        abstract name: string option with get, set
        abstract items: ResizeArray<JumpListItem> option with get, set

    and [<AllowNullLiteral>] JumpListItem =
        abstract ``type``: U3<obj, obj, obj> with get, set
        abstract path: string option with get, set
        abstract program: string option with get, set
        abstract args: string option with get, set
        abstract title: string option with get, set
        abstract description: string option with get, set
        abstract iconPath: string option with get, set
        abstract iconIndex: float option with get, set

    and [<AllowNullLiteral>] LoginItemSettings =
        abstract openAtLogin: bool with get, set
        abstract openAsHidden: bool with get, set
        abstract wasOpenedAtLogin: bool option with get, set
        abstract wasOpenedAsHidden: bool option with get, set
        abstract restoreState: bool option with get, set

    and [<AllowNullLiteral>] AboutPanelOptions =
        abstract applicationName: string option with get, set
        abstract applicationVersion: string option with get, set
        abstract copyright: string option with get, set
        abstract credits: string option with get, set
        abstract version: string option with get, set

    and [<AllowNullLiteral>] AutoUpdater =
        inherit NodeJS.EventEmitter
        abstract on: ``event``: obj * listener: Func<Error, unit> -> obj
        abstract on: ``event``: obj * listener: Function -> obj
        abstract on: ``event``: obj * listener: Func<Event, string, string, DateTime, string, unit> -> obj
        abstract on: ``event``: string * listener: Function -> obj
        abstract setFeedURL: url: string * ?requestHeaders: Headers -> unit
        abstract getFeedURL: unit -> string
        abstract checkForUpdates: unit -> unit
        abstract quitAndInstall: unit -> unit

    and [<AllowNullLiteral>] [<Import("BrowserWindow","Electron")>] BrowserWindow(?options: BrowserWindowOptions) =
        interface NodeJS.EventEmitter
        interface Destroyable with
            member __.destroy(): unit = jsNative
            member __.isDestroyed(): bool = jsNative
        member __.webContents with get(): WebContents = jsNative and set(v: WebContents): unit = jsNative
        member __.id with get(): float = jsNative and set(v: float): unit = jsNative
        member __.on(``event``: obj, listener: Func<Event, string, unit>): obj = jsNative
        member __.on(``event``: obj, listener: Func<Event, unit>): obj = jsNative
        member __.on(``event``: obj, listener: Function): obj = jsNative
        member __.on(``event``: obj, listener: Func<Event, SwipeDirection, unit>): obj = jsNative
        member __.on(``event``: string, listener: Function): obj = jsNative
        member __.getAllWindows(): ResizeArray<BrowserWindow> = jsNative
        member __.getFocusedWindow(): BrowserWindow = jsNative
        member __.fromWebContents(webContents: WebContents): BrowserWindow = jsNative
        member __.fromId(id: float): BrowserWindow = jsNative
        member __.addDevToolsExtension(path: string): string = jsNative
        member __.removeDevToolsExtension(name: string): unit = jsNative
        member __.getDevToolsExtensions(): DevToolsExtensions = jsNative
        member __.close(): unit = jsNative
        member __.focus(): unit = jsNative
        member __.blur(): unit = jsNative
        member __.isFocused(): bool = jsNative
        member __.show(): unit = jsNative
        member __.showInactive(): unit = jsNative
        member __.hide(): unit = jsNative
        member __.isVisible(): bool = jsNative
        member __.isModal(): bool = jsNative
        member __.maximize(): unit = jsNative
        member __.unmaximize(): unit = jsNative
        member __.isMaximized(): bool = jsNative
        member __.minimize(): unit = jsNative
        member __.restore(): unit = jsNative
        member __.isMinimized(): bool = jsNative
        member __.setFullScreen(flag: bool): unit = jsNative
        member __.isFullScreen(): bool = jsNative
        member __.setAspectRatio(aspectRatio: float, ?extraSize: Size): unit = jsNative
        member __.previewFile(path: string, ?displayName: string): unit = jsNative
        member __.setBounds(options: Rectangle, ?animate: bool): unit = jsNative
        member __.getBounds(): Rectangle = jsNative
        member __.setContentBounds(options: Rectangle, ?animate: bool): unit = jsNative
        member __.getContentBounds(): Rectangle = jsNative
        member __.setSize(width: float, height: float, ?animate: bool): unit = jsNative
        member __.getSize(): ResizeArray<float> = jsNative
        member __.setContentSize(width: float, height: float, ?animate: bool): unit = jsNative
        member __.getContentSize(): ResizeArray<float> = jsNative
        member __.setMinimumSize(width: float, height: float): unit = jsNative
        member __.getMinimumSize(): ResizeArray<float> = jsNative
        member __.setMaximumSize(width: float, height: float): unit = jsNative
        member __.getMaximumSize(): ResizeArray<float> = jsNative
        member __.setResizable(resizable: bool): unit = jsNative
        member __.isResizable(): bool = jsNative
        member __.setMovable(movable: bool): unit = jsNative
        member __.isMovable(): bool = jsNative
        member __.setMinimizable(minimizable: bool): unit = jsNative
        member __.isMinimizable(): bool = jsNative
        member __.setMaximizable(maximizable: bool): unit = jsNative
        member __.isMaximizable(): bool = jsNative
        member __.setFullScreenable(fullscreenable: bool): unit = jsNative
        member __.isFullScreenable(): bool = jsNative
        member __.setClosable(closable: bool): unit = jsNative
        member __.isClosable(): bool = jsNative
        member __.setAlwaysOnTop(flag: bool, ?level: WindowLevel): unit = jsNative
        member __.isAlwaysOnTop(): bool = jsNative
        member __.center(): unit = jsNative
        member __.setPosition(x: float, y: float, ?animate: bool): unit = jsNative
        member __.getPosition(): ResizeArray<float> = jsNative
        member __.setTitle(title: string): unit = jsNative
        member __.getTitle(): string = jsNative
        member __.setSheetOffset(offsetY: float, ?offsetX: float): unit = jsNative
        member __.flashFrame(flag: bool): unit = jsNative
        member __.setSkipTaskbar(skip: bool): unit = jsNative
        member __.setKiosk(flag: bool): unit = jsNative
        member __.isKiosk(): bool = jsNative
        member __.getNativeWindowHandle(): Buffer = jsNative
        member __.hookWindowMessage(message: float, callback: Function): unit = jsNative
        member __.isWindowMessageHooked(message: float): bool = jsNative
        member __.unhookWindowMessage(message: float): unit = jsNative
        member __.unhookAllWindowMessages(): unit = jsNative
        member __.setRepresentedFilename(filename: string): unit = jsNative
        member __.getRepresentedFilename(): string = jsNative
        member __.setDocumentEdited(edited: bool): unit = jsNative
        member __.isDocumentEdited(): bool = jsNative
        member __.focusOnWebView(): unit = jsNative
        member __.blurWebView(): unit = jsNative
        member __.capturePage(rect: Rectangle, callback: Func<NativeImage, unit>): unit = jsNative
        member __.capturePage(callback: Func<NativeImage, unit>): unit = jsNative
        member __.loadURL(url: string, ?options: LoadURLOptions): unit = jsNative
        member __.reload(): unit = jsNative
        member __.setMenu(menu: U2<Menu, obj>): unit = jsNative
        member __.setProgressBar(progress: float, ?options: obj): unit = jsNative
        member __.setOverlayIcon(overlay: NativeImage, description: string): unit = jsNative
        member __.setHasShadow(hasShadow: bool): unit = jsNative
        member __.hasShadow(): bool = jsNative
        member __.setThumbarButtons(buttons: ResizeArray<ThumbarButton>): bool = jsNative
        member __.setThumbnailClip(region: Rectangle): bool = jsNative
        member __.setThumbnailToolTip(toolTip: string): bool = jsNative
        member __.showDefinitionForSelection(): unit = jsNative
        member __.setIcon(icon: NativeImage): unit = jsNative
        member __.setAutoHideMenuBar(hide: bool): unit = jsNative
        member __.isMenuBarAutoHide(): bool = jsNative
        member __.setMenuBarVisibility(visibile: bool): unit = jsNative
        member __.isMenuBarVisible(): bool = jsNative
        member __.setVisibleOnAllWorkspaces(visible: bool): unit = jsNative
        member __.isVisibleOnAllWorkspaces(): bool = jsNative
        member __.setIgnoreMouseEvents(ignore: bool): unit = jsNative
        member __.setContentProtection(enable: bool): unit = jsNative
        member __.setFocusable(focusable: bool): unit = jsNative
        member __.setParentWindow(parent: BrowserWindow): unit = jsNative
        member __.getParentWindow(): BrowserWindow = jsNative
        member __.getChildWindows(): ResizeArray<BrowserWindow> = jsNative
        member __.setVibrancy(``type``: VibrancyType): unit = jsNative

    and WindowLevel =
        obj

    and SwipeDirection =
        U4<obj, obj, obj, obj>

    and ThumbarButtonFlags =
        obj

    and [<AllowNullLiteral>] ThumbarButton =
        abstract icon: U2<NativeImage, string> with get, set
        abstract click: Function with get, set
        abstract tooltip: string option with get, set
        abstract flags: ResizeArray<ThumbarButtonFlags> option with get, set

    and [<AllowNullLiteral>] DevToolsExtensions =
        [<Emit("$0[$1]{{=$2}}")>] abstract Item: name: string -> obj with get, set

    and [<AllowNullLiteral>] WebPreferences =
        abstract devTools: bool option with get, set
        abstract nodeIntegration: bool option with get, set
        abstract preload: string option with get, set
        abstract session: Session option with get, set
        abstract partition: string option with get, set
        abstract zoomFactor: float option with get, set
        abstract javascript: bool option with get, set
        abstract webSecurity: bool option with get, set
        abstract allowDisplayingInsecureContent: bool option with get, set
        abstract allowRunningInsecureContent: bool option with get, set
        abstract images: bool option with get, set
        abstract textAreasAreResizable: bool option with get, set
        abstract webgl: bool option with get, set
        abstract webaudio: bool option with get, set
        abstract plugins: bool option with get, set
        abstract experimentalFeatures: bool option with get, set
        abstract experimentalCanvasFeatures: bool option with get, set
        abstract directWrite: bool option with get, set
        abstract scrollBounce: bool option with get, set
        abstract blinkFeatures: string option with get, set
        abstract disableBlinkFeatures: string option with get, set
        abstract defaultFontFamily: obj option with get, set
        abstract defaultFontSize: float option with get, set
        abstract defaultMonospaceFontSize: float option with get, set
        abstract minimumFontSize: float option with get, set
        abstract defaultEncoding: string option with get, set
        abstract backgroundThrottling: bool option with get, set
        abstract offscreen: bool option with get, set
        abstract sandbox: bool option with get, set

    and [<AllowNullLiteral>] BrowserWindowOptions =
        abstract width: float option with get, set
        abstract height: float option with get, set
        abstract x: float option with get, set
        abstract y: float option with get, set
        abstract useContentSize: bool option with get, set
        abstract center: bool option with get, set
        abstract minWidth: float option with get, set
        abstract minHeight: float option with get, set
        abstract maxWidth: float option with get, set
        abstract maxHeight: float option with get, set
        abstract resizable: bool option with get, set
        abstract movable: bool option with get, set
        abstract minimizable: bool option with get, set
        abstract maximizable: bool option with get, set
        abstract closable: bool option with get, set
        abstract focusable: bool option with get, set
        abstract alwaysOnTop: bool option with get, set
        abstract fullscreen: bool option with get, set
        abstract fullscreenable: bool option with get, set
        abstract skipTaskbar: bool option with get, set
        abstract kiosk: bool option with get, set
        abstract title: string option with get, set
        abstract icon: U2<NativeImage, string> option with get, set
        abstract show: bool option with get, set
        abstract frame: bool option with get, set
        abstract parent: BrowserWindow option with get, set
        abstract modal: bool option with get, set
        abstract acceptFirstMouse: bool option with get, set
        abstract disableAutoHideCursor: bool option with get, set
        abstract autoHideMenuBar: bool option with get, set
        abstract enableLargerThanScreen: bool option with get, set
        abstract backgroundColor: string option with get, set
        abstract hasShadow: bool option with get, set
        abstract darkTheme: bool option with get, set
        abstract transparent: bool option with get, set
        abstract ``type``: BrowserWindowType option with get, set
        abstract titleBarStyle: U3<obj, obj, obj> option with get, set
        abstract thickFrame: bool option with get, set
        abstract vibrancy: VibrancyType option with get, set
        abstract webPreferences: WebPreferences option with get, set

    and BrowserWindowType =
        U3<BrowserWindowTypeLinux, BrowserWindowTypeMac, BrowserWindowTypeWindows>

    and BrowserWindowTypeLinux =
        obj

    and BrowserWindowTypeMac =
        U2<obj, obj>

    and BrowserWindowTypeWindows =
        obj

    and [<AllowNullLiteral>] Clipboard =
        abstract readText: ?``type``: ClipboardType -> string
        abstract writeText: text: string * ?``type``: ClipboardType -> unit
        abstract readHTML: ?``type``: ClipboardType -> string
        abstract writeHTML: markup: string * ?``type``: ClipboardType -> unit
        abstract readImage: ?``type``: ClipboardType -> NativeImage
        abstract writeImage: image: NativeImage * ?``type``: ClipboardType -> unit
        abstract readRTF: ?``type``: ClipboardType -> string
        abstract writeRTF: text: string * ?``type``: ClipboardType -> unit
        abstract clear: ?``type``: ClipboardType -> unit
        abstract availableFormats: ?``type``: ClipboardType -> ResizeArray<string>
        abstract has: format: string * ?``type``: ClipboardType -> bool
        abstract read: format: string * ?``type``: ClipboardType -> U2<string, NativeImage>
        abstract write: data: U4<obj, obj, obj, obj> * ?``type``: ClipboardType -> unit
        abstract readBookmark: unit -> Bookmark
        abstract writeBookmark: title: string * url: string * ?``type``: ClipboardType -> unit
        abstract readFindText: unit -> string
        abstract writeFindText: text: string -> unit

    and ClipboardType =
        U2<obj, obj>

    and [<AllowNullLiteral>] Bookmark =
        abstract title: string with get, set
        abstract url: string with get, set

    and [<AllowNullLiteral>] ContentTracing =
        abstract getCategories: callback: Func<ResizeArray<string>, unit> -> unit
        abstract startRecording: options: ContentTracingOptions * callback: Function -> unit
        abstract stopRecording: resultFilePath: string * callback: Func<string, unit> -> unit
        abstract startMonitoring: options: ContentTracingOptions * callback: Function -> unit
        abstract stopMonitoring: callback: Function -> unit
        abstract captureMonitoringSnapshot: resultFilePath: string * callback: Func<string, unit> -> unit
        abstract getTraceBufferUsage: callback: Function -> unit
        abstract setWatchEvent: categoryName: string * eventName: string * callback: Function -> unit
        abstract cancelWatchEvent: unit -> unit

    and [<AllowNullLiteral>] ContentTracingOptions =
        abstract categoryFilter: string with get, set
        abstract traceOptions: string with get, set

    and [<AllowNullLiteral>] CrashReporter =
        abstract start: options: CrashReporterStartOptions -> unit
        abstract getLastCrashReport: unit -> CrashReport
        abstract getUploadedReports: unit -> ResizeArray<CrashReport>

    and [<AllowNullLiteral>] CrashReporterStartOptions =
        abstract productName: string option with get, set
        abstract companyName: string with get, set
        abstract submitURL: string with get, set
        abstract autoSubmit: bool option with get, set
        abstract ignoreSystemCrashHandler: bool option with get, set
        abstract extra: obj option with get, set

    and [<AllowNullLiteral>] CrashReport =
        abstract id: string with get, set
        abstract date: DateTime with get, set

    and [<AllowNullLiteral>] DesktopCapturer =
        abstract getSources: options: DesktopCapturerOptions * callback: Func<Error, ResizeArray<DesktopCapturerSource>, obj> -> unit

    and [<AllowNullLiteral>] DesktopCapturerOptions =
        abstract types: ResizeArray<U2<obj, obj>> option with get, set
        abstract thumbnailSize: Size option with get, set

    and [<AllowNullLiteral>] DesktopCapturerSource =
        abstract id: string with get, set
        abstract name: string with get, set
        abstract thumbnail: NativeImage with get, set

    and [<AllowNullLiteral>] Dialog =
        abstract showOpenDialog: browserWindow: BrowserWindow * options: OpenDialogOptions * ?callback: Func<ResizeArray<string>, unit> -> ResizeArray<string>
        abstract showOpenDialog: options: OpenDialogOptions * ?callback: Func<ResizeArray<string>, unit> -> ResizeArray<string>
        abstract showSaveDialog: browserWindow: BrowserWindow * options: SaveDialogOptions * ?callback: Func<string, unit> -> string
        abstract showSaveDialog: options: SaveDialogOptions * ?callback: Func<string, unit> -> string
        abstract showMessageBox: browserWindow: BrowserWindow * options: ShowMessageBoxOptions * ?callback: Func<float, unit> -> float
        abstract showMessageBox: options: ShowMessageBoxOptions * ?callback: Func<float, unit> -> float
        abstract showErrorBox: title: string * content: string -> unit

    and [<AllowNullLiteral>] OpenDialogOptions =
        abstract title: string option with get, set
        abstract defaultPath: string option with get, set
        abstract buttonLabel: string option with get, set
        abstract filters: ResizeArray<obj> option with get, set
        abstract properties: ResizeArray<obj> option with get, set

    and [<AllowNullLiteral>] SaveDialogOptions =
        abstract title: string option with get, set
        abstract defaultPath: string option with get, set
        abstract buttonLabel: string option with get, set
        abstract filters: ResizeArray<obj> option with get, set

    and [<AllowNullLiteral>] ShowMessageBoxOptions =
        abstract ``type``: obj option with get, set
        abstract buttons: ResizeArray<string> option with get, set
        abstract defaultId: float option with get, set
        abstract title: string option with get, set
        abstract message: string option with get, set
        abstract detail: string option with get, set
        abstract icon: NativeImage option with get, set
        abstract cancelId: float option with get, set
        abstract noLink: bool option with get, set

    and [<AllowNullLiteral>] DownloadItem =
        inherit NodeJS.EventEmitter
        abstract on: ``event``: obj * listener: Func<Event, U2<obj, obj>, unit> -> obj
        abstract on: ``event``: obj * listener: Func<Event, U3<obj, obj, obj>, unit> -> obj
        abstract on: ``event``: string * listener: Function -> obj
        abstract setSavePath: path: string -> unit
        abstract getSavePath: unit -> string
        abstract pause: unit -> unit
        abstract isPaused: unit -> bool
        abstract resume: unit -> unit
        abstract canResume: unit -> bool
        abstract cancel: unit -> unit
        abstract getURL: unit -> string
        abstract getMimeType: unit -> string
        abstract hasUserGesture: unit -> bool
        abstract getFilename: unit -> string
        abstract getTotalBytes: unit -> float
        abstract getReceivedBytes: unit -> float
        abstract getContentDisposition: unit -> string
        abstract getState: unit -> U4<obj, obj, obj, obj>

    and [<AllowNullLiteral>] GlobalShortcut =
        abstract register: accelerator: string * callback: Function -> unit
        abstract isRegistered: accelerator: string -> bool
        abstract unregister: accelerator: string -> unit
        abstract unregisterAll: unit -> unit

    and [<AllowNullLiteral>] IpcMain =
        inherit NodeJS.EventEmitter
        abstract addListener: channel: string * listener: IpcMainEventListener -> obj
        abstract on: channel: string * listener: IpcMainEventListener -> obj
        abstract once: channel: string * listener: IpcMainEventListener -> obj
        abstract removeListener: channel: string * listener: IpcMainEventListener -> obj
        abstract removeAllListeners: ?channel: string -> obj

    and IpcMainEventListener =
        Func<IpcMainEvent, obj, unit>

    and [<AllowNullLiteral>] IpcMainEvent =
        abstract returnValue: obj option with get, set
        abstract sender: WebContents with get, set

    and [<AllowNullLiteral>] IpcRenderer =
        inherit NodeJS.EventEmitter
        abstract addListener: channel: string * listener: IpcRendererEventListener -> obj
        abstract on: channel: string * listener: IpcRendererEventListener -> obj
        abstract once: channel: string * listener: IpcRendererEventListener -> obj
        abstract removeListener: channel: string * listener: IpcRendererEventListener -> obj
        abstract removeAllListeners: ?channel: string -> obj
        abstract send: channel: string * [<ParamArray>] args: obj[] -> unit
        abstract sendSync: channel: string * [<ParamArray>] args: obj[] -> obj
        abstract sendToHost: channel: string * [<ParamArray>] args: obj[] -> unit

    and IpcRendererEventListener =
        Func<IpcRendererEvent, obj, unit>

    and [<AllowNullLiteral>] IpcRendererEvent =
        abstract sender: IpcRenderer with get, set

    and [<AllowNullLiteral>] [<Import("MenuItem","Electron")>] MenuItem(options: MenuItemOptions) =
        member __.click with get(): Func<Event, BrowserWindow, WebContents, unit> = jsNative and set(v: Func<Event, BrowserWindow, WebContents, unit>): unit = jsNative
        member __.``type`` with get(): MenuItemType = jsNative and set(v: MenuItemType): unit = jsNative
        member __.role with get(): U2<MenuItemRole, MenuItemRoleMac> = jsNative and set(v: U2<MenuItemRole, MenuItemRoleMac>): unit = jsNative
        member __.accelerator with get(): string = jsNative and set(v: string): unit = jsNative
        member __.icon with get(): U2<NativeImage, string> = jsNative and set(v: U2<NativeImage, string>): unit = jsNative
        member __.submenu with get(): U2<Menu, ResizeArray<MenuItemOptions>> = jsNative and set(v: U2<Menu, ResizeArray<MenuItemOptions>>): unit = jsNative
        member __.label with get(): string = jsNative and set(v: string): unit = jsNative
        member __.sublabel with get(): string = jsNative and set(v: string): unit = jsNative
        member __.enabled with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.visible with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.``checked`` with get(): bool = jsNative and set(v: bool): unit = jsNative

    and MenuItemType =
        obj

    and MenuItemRole =
        obj

    and MenuItemRoleMac =
        obj

    and [<AllowNullLiteral>] MenuItemOptions =
        abstract click: Func<MenuItem, BrowserWindow, Event, unit> option with get, set
        abstract ``type``: MenuItemType option with get, set
        abstract label: string option with get, set
        abstract sublabel: string option with get, set
        abstract accelerator: string option with get, set
        abstract icon: U2<NativeImage, string> option with get, set
        abstract enabled: bool option with get, set
        abstract visible: bool option with get, set
        abstract ``checked``: bool option with get, set
        abstract submenu: U2<Menu, ResizeArray<MenuItemOptions>> option with get, set
        abstract id: string option with get, set
        abstract position: string option with get, set
        abstract role: U2<MenuItemRole, MenuItemRoleMac> option with get, set

    and [<AllowNullLiteral>] [<Import("Menu","Electron")>] Menu() =
        interface NodeJS.EventEmitter
        member __.items with get(): ResizeArray<MenuItem> = jsNative and set(v: ResizeArray<MenuItem>): unit = jsNative
        member __.setApplicationMenu(menu: Menu): unit = jsNative
        member __.getApplicationMenu(): Menu = jsNative
        member __.sendActionToFirstResponder(action: string): unit = jsNative
        member __.buildFromTemplate(template: ResizeArray<MenuItemOptions>): Menu = jsNative
        member __.popup(?browserWindow: BrowserWindow, ?x: float, ?y: float): unit = jsNative
        member __.append(menuItem: MenuItem): unit = jsNative
        member __.insert(position: float, menuItem: MenuItem): unit = jsNative

    and [<AllowNullLiteral>] [<Import("NativeImage","Electron")>] NativeImage() =
        member __.createEmpty(): NativeImage = jsNative
        member __.createFromPath(path: string): NativeImage = jsNative
        member __.createFromBuffer(buffer: Buffer, ?scaleFactor: float): NativeImage = jsNative
        member __.createFromDataURL(dataURL: string): NativeImage = jsNative
        member __.toPNG(): Buffer = jsNative
        member __.toJPEG(quality: float): Buffer = jsNative
        member __.toBitmap(): Buffer = jsNative
        member __.getBitmap(): Buffer = jsNative
        member __.toDataURL(): string = jsNative
        member __.getNativeHandle(): Buffer = jsNative
        member __.isEmpty(): bool = jsNative
        member __.getSize(): Size = jsNative
        member __.setTemplateImage(option: bool): unit = jsNative
        member __.isTemplateImage(): bool = jsNative

    and [<AllowNullLiteral>] Net =
        inherit NodeJS.EventEmitter
        abstract request: options: U2<string, RequestOptions> * ?callback: Func<IncomingMessage, unit> -> ClientRequest

    and [<AllowNullLiteral>] RequestOptions =
        abstract ``method``: string option with get, set
        abstract url: string option with get, set
        abstract session: Session option with get, set
        abstract partition: string option with get, set
        abstract protocol: U2<obj, obj> option with get, set
        abstract host: string option with get, set
        abstract hostname: string option with get, set
        abstract port: float option with get, set
        abstract path: string option with get, set
        abstract headers: obj option with get, set

    and [<AllowNullLiteral>] [<Import("ClientRequest","Electron")>] ClientRequest(options: U2<string, RequestOptions>, ?callback: Func<IncomingMessage, unit>) =
        interface NodeJS.EventEmitter
        member __.chunkedEncoding with get(): bool = jsNative and set(v: bool): unit = jsNative
        member __.on(``event``: obj, listener: Func<IncomingMessage, unit>): obj = jsNative
        member __.on(``event``: obj, listener: Func<LoginAuthInfo, Func<string, string, unit>, unit>): obj = jsNative
        member __.on(``event``: obj, listener: Func<unit, unit>): obj = jsNative
        member __.on(``event``: obj, listener: Func<Error, unit>): obj = jsNative
        member __.on(``event``: string, listener: Function): obj = jsNative
        member __.setHeader(name: string, value: string): unit = jsNative
        member __.getHeader(name: string): string = jsNative
        member __.removeHeader(name: string): unit = jsNative
        member __.write(chunk: U2<string, Buffer>, ?encoding: string, ?callback: Function): bool = jsNative
        member __.``end``(?chunk: U2<string, Buffer>, ?encoding: string, ?callback: Function): bool = jsNative
        member __.abort(): unit = jsNative

    and [<AllowNullLiteral>] IncomingMessage =
        inherit NodeJS.ReadableStream
        abstract statusCode: float with get, set
        abstract statusMessage: string with get, set
        abstract headers: obj with get, set
        abstract httpVersion: string with get, set
        abstract httpVersionMajor: float with get, set
        abstract httpVersionMinor: float with get, set
        abstract on: ``event``: obj * listener: Func<Buffer, unit> -> obj
        abstract on: ``event``: obj * listener: Func<unit, unit> -> obj
        abstract on: ``event``: obj * listener: Func<Error, unit> -> obj
        abstract on: ``event``: string * listener: Function -> obj

    and [<AllowNullLiteral>] PowerMonitor =
        inherit NodeJS.EventEmitter
        abstract on: ``event``: obj * listener: Function -> obj
        abstract on: ``event``: string * listener: Function -> obj

    and [<AllowNullLiteral>] PowerSaveBlocker =
        abstract start: ``type``: U2<obj, obj> -> float
        abstract stop: id: float -> unit
        abstract isStarted: id: float -> bool

    and [<AllowNullLiteral>] Protocol =
        abstract registerStandardSchemes: schemes: ResizeArray<string> -> unit
        abstract registerServiceWorkerSchemes: schemes: ResizeArray<string> -> unit
        abstract registerFileProtocol: scheme: string * handler: FileProtocolHandler * ?completion: Func<Error, unit> -> unit
        abstract registerBufferProtocol: scheme: string * handler: BufferProtocolHandler * ?completion: Func<Error, unit> -> unit
        abstract registerStringProtocol: scheme: string * handler: StringProtocolHandler * ?completion: Func<Error, unit> -> unit
        abstract registerHttpProtocol: scheme: string * handler: HttpProtocolHandler * ?completion: Func<Error, unit> -> unit
        abstract unregisterProtocol: scheme: string * ?completion: Func<Error, unit> -> unit
        abstract isProtocolHandled: scheme: string * callback: Func<bool, unit> -> unit
        abstract interceptFileProtocol: scheme: string * handler: FileProtocolHandler * ?completion: Func<Error, unit> -> unit
        abstract interceptBufferProtocol: scheme: string * handler: BufferProtocolHandler * ?completion: Func<Error, unit> -> unit
        abstract interceptStringProtocol: scheme: string * handler: StringProtocolHandler * ?completion: Func<Error, unit> -> unit
        abstract interceptHttpProtocol: scheme: string * handler: HttpProtocolHandler * ?completion: Func<Error, unit> -> unit
        abstract uninterceptProtocol: scheme: string * ?completion: Func<Error, unit> -> unit

    and FileProtocolHandler =
        Func<ProtocolRequest, FileProtocolCallback, unit>

    and BufferProtocolHandler =
        Func<ProtocolRequest, BufferProtocolCallback, unit>

    and StringProtocolHandler =
        Func<ProtocolRequest, StringProtocolCallback, unit>

    and HttpProtocolHandler =
        Func<ProtocolRequest, HttpProtocolCallback, unit>

    and [<AllowNullLiteral>] ProtocolRequest =
        abstract url: string with get, set
        abstract referrer: string with get, set
        abstract ``method``: string with get, set
        abstract uploadData: ResizeArray<obj> option with get, set

    and [<AllowNullLiteral>] ProtocolCallback =
        [<Emit("$0($1...)")>] abstract Invoke: error: float -> unit
        [<Emit("$0($1...)")>] abstract Invoke: obj: obj -> unit
        [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

    and [<AllowNullLiteral>] FileProtocolCallback =
        inherit ProtocolCallback
        [<Emit("$0($1...)")>] abstract Invoke: filePath: string -> unit
        [<Emit("$0($1...)")>] abstract Invoke: obj: obj -> unit

    and [<AllowNullLiteral>] BufferProtocolCallback =
        inherit ProtocolCallback
        [<Emit("$0($1...)")>] abstract Invoke: buffer: Buffer -> unit
        [<Emit("$0($1...)")>] abstract Invoke: obj: obj -> unit

    and [<AllowNullLiteral>] StringProtocolCallback =
        inherit ProtocolCallback
        [<Emit("$0($1...)")>] abstract Invoke: str: string -> unit
        [<Emit("$0($1...)")>] abstract Invoke: obj: obj -> unit

    and [<AllowNullLiteral>] HttpProtocolCallback =
        inherit ProtocolCallback
        [<Emit("$0($1...)")>] abstract Invoke: redirectRequest: obj -> unit

    and [<AllowNullLiteral>] Remote =
        inherit CommonElectron
        abstract ``process``: NodeJS.Process with get, set
        abstract require: ``module``: string -> obj
        abstract getCurrentWindow: unit -> BrowserWindow
        abstract getCurrentWebContents: unit -> WebContents
        abstract getGlobal: name: string -> obj

    and [<AllowNullLiteral>] Display =
        abstract id: float with get, set
        abstract bounds: Rectangle with get, set
        abstract workArea: Rectangle with get, set
        abstract size: Size with get, set
        abstract workAreaSize: Size with get, set
        abstract scaleFactor: float with get, set
        abstract rotation: float with get, set
        abstract touchSupport: U3<obj, obj, obj> with get, set

    and DisplayMetrics =
        U4<obj, obj, obj, obj>

    and [<AllowNullLiteral>] Screen =
        inherit NodeJS.EventEmitter
        abstract on: ``event``: obj * listener: Func<Event, Display, unit> -> obj
        abstract on: ``event``: obj * listener: Func<Event, Display, ResizeArray<DisplayMetrics>, unit> -> obj
        abstract on: ``event``: string * listener: Function -> obj
        abstract getCursorScreenPoint: unit -> Point
        abstract getPrimaryDisplay: unit -> Display
        abstract getAllDisplays: unit -> ResizeArray<Display>
        abstract getDisplayNearestPoint: point: Point -> Display
        abstract getDisplayMatching: rect: Rectangle -> Display

    and [<AllowNullLiteral>] [<Import("Session","Electron")>] Session() =
        interface NodeJS.EventEmitter
        member __.defaultSession with get(): Session = jsNative and set(v: Session): unit = jsNative
        member __.cookies with get(): SessionCookies = jsNative and set(v: SessionCookies): unit = jsNative
        member __.webRequest with get(): WebRequest = jsNative and set(v: WebRequest): unit = jsNative
        member __.protocol with get(): Protocol = jsNative and set(v: Protocol): unit = jsNative
        member __.fromPartition(partition: string, ?options: FromPartitionOptions): Session = jsNative
        member __.on(``event``: obj, listener: Func<Event, DownloadItem, WebContents, unit>): obj = jsNative
        member __.on(``event``: string, listener: Function): obj = jsNative
        member __.getCacheSize(callback: Func<float, unit>): unit = jsNative
        member __.clearCache(callback: Function): unit = jsNative
        member __.clearStorageData(callback: Function): unit = jsNative
        member __.clearStorageData(options: ClearStorageDataOptions, callback: Function): unit = jsNative
        member __.flushStorageData(): unit = jsNative
        member __.setProxy(config: ProxyConfig, callback: Function): unit = jsNative
        member __.resolveProxy(url: URL, callback: Func<string, unit>): unit = jsNative
        member __.setDownloadPath(path: string): unit = jsNative
        member __.enableNetworkEmulation(options: NetworkEmulationOptions): unit = jsNative
        member __.disableNetworkEmulation(): unit = jsNative
        member __.setCertificateVerifyProc(proc: U2<Func<string, Certificate, Func<bool, unit>, unit>, obj>): unit = jsNative
        member __.setPermissionRequestHandler(handler: Func<WebContents, Permission, Func<bool, unit>, unit>): unit = jsNative
        member __.clearHostResolverCache(callback: Function): unit = jsNative
        member __.allowNTLMCredentialsForDomains(domains: string): unit = jsNative
        member __.setUserAgent(userAgent: string, ?acceptLanguages: string): unit = jsNative
        member __.getUserAgent(): string = jsNative
        member __.getBlobData(identifier: string, callback: Func<Buffer, unit>): unit = jsNative

    and Permission =
        obj

    and [<AllowNullLiteral>] FromPartitionOptions =
        abstract cache: bool option with get, set

    and [<AllowNullLiteral>] ClearStorageDataOptions =
        abstract origin: string option with get, set
        abstract storages: ResizeArray<obj> option with get, set
        abstract quotas: ResizeArray<U3<obj, obj, obj>> option with get, set

    and [<AllowNullLiteral>] ProxyConfig =
        abstract pacScript: string with get, set
        abstract proxyRules: string with get, set
        abstract proxyBypassRules: string with get, set

    and [<AllowNullLiteral>] NetworkEmulationOptions =
        abstract offline: bool option with get, set
        abstract latency: float option with get, set
        abstract downloadThroughput: float option with get, set
        abstract uploadThroughput: float option with get, set

    and [<AllowNullLiteral>] CookieFilter =
        abstract url: string option with get, set
        abstract name: string option with get, set
        abstract domain: string option with get, set
        abstract path: string option with get, set
        abstract secure: bool option with get, set
        abstract session: bool option with get, set

    and [<AllowNullLiteral>] Cookie =
        abstract name: string with get, set
        abstract value: string with get, set
        abstract domain: string with get, set
        abstract hostOnly: string with get, set
        abstract path: string with get, set
        abstract secure: bool with get, set
        abstract httpOnly: bool with get, set
        abstract session: bool with get, set
        abstract expirationDate: float option with get, set
        abstract on: ``event``: obj * listener: Func<Event, Cookie, CookieChangedCause, unit> -> obj
        abstract on: ``event``: string * listener: Function -> obj

    and CookieChangedCause =
        obj

    and [<AllowNullLiteral>] CookieDetails =
        abstract url: string with get, set
        abstract name: string option with get, set
        abstract value: string option with get, set
        abstract domain: string option with get, set
        abstract path: string option with get, set
        abstract secure: bool option with get, set
        abstract httpOnly: bool option with get, set
        abstract expirationDate: float option with get, set

    and [<AllowNullLiteral>] SessionCookies =
        abstract get: filter: CookieFilter * callback: Func<Error, ResizeArray<Cookie>, unit> -> unit
        abstract set: details: CookieDetails * callback: Func<Error, unit> -> unit
        abstract remove: url: string * name: string * callback: Func<Error, unit> -> unit

    and [<AllowNullLiteral>] WebRequest =
        abstract onBeforeRequest: listener: Func<WebRequest.BeforeRequestDetails, WebRequest.BeforeRequestCallback, unit> -> unit
        abstract onBeforeRequest: filter: WebRequest.Filter * listener: Func<WebRequest.BeforeRequestDetails, WebRequest.BeforeRequestCallback, unit> -> unit
        abstract onBeforeSendHeaders: listener: Func<WebRequest.BeforeSendHeadersDetails, WebRequest.BeforeSendHeadersCallback, unit> -> unit
        abstract onBeforeSendHeaders: filter: WebRequest.Filter * listener: Func<WebRequest.BeforeSendHeadersDetails, WebRequest.BeforeSendHeadersCallback, unit> -> unit
        abstract onSendHeaders: listener: Func<WebRequest.SendHeadersDetails, unit> -> unit
        abstract onSendHeaders: filter: WebRequest.Filter * listener: Func<WebRequest.SendHeadersDetails, unit> -> unit
        abstract onHeadersReceived: listener: Func<WebRequest.HeadersReceivedDetails, WebRequest.HeadersReceivedCallback, unit> -> unit
        abstract onHeadersReceived: filter: WebRequest.Filter * listener: Func<WebRequest.HeadersReceivedDetails, WebRequest.HeadersReceivedCallback, unit> -> unit
        abstract onResponseStarted: listener: Func<WebRequest.ResponseStartedDetails, unit> -> unit
        abstract onResponseStarted: filter: WebRequest.Filter * listener: Func<WebRequest.ResponseStartedDetails, unit> -> unit
        abstract onBeforeRedirect: listener: Func<WebRequest.BeforeRedirectDetails, unit> -> unit
        abstract onBeforeRedirect: filter: WebRequest.Filter * listener: Func<WebRequest.BeforeRedirectDetails, unit> -> unit
        abstract onCompleted: listener: Func<WebRequest.CompletedDetails, unit> -> unit
        abstract onCompleted: filter: WebRequest.Filter * listener: Func<WebRequest.CompletedDetails, unit> -> unit
        abstract onErrorOccurred: listener: Func<WebRequest.ErrorOccurredDetails, unit> -> unit
        abstract onErrorOccurred: filter: WebRequest.Filter * listener: Func<WebRequest.ErrorOccurredDetails, unit> -> unit

    and [<AllowNullLiteral>] Shell =
        abstract showItemInFolder: fullPath: string -> bool
        abstract openItem: fullPath: string -> bool
        abstract openExternal: url: string * ?options: obj -> bool
        abstract moveItemToTrash: fullPath: string -> bool
        abstract beep: unit -> unit
        abstract writeShortcutLink: shortcutPath: string * options: ShortcutLinkOptions -> bool
        abstract writeShortcutLink: shortcutPath: string * operation: U3<obj, obj, obj> * options: ShortcutLinkOptions -> bool
        abstract readShortcutLink: shortcutPath: string -> ShortcutLinkOptions

    and [<AllowNullLiteral>] ShortcutLinkOptions =
        abstract target: string with get, set
        abstract cwd: string option with get, set
        abstract args: string option with get, set
        abstract description: string option with get, set
        abstract icon: string option with get, set
        abstract iconIndex: float option with get, set
        abstract appUserModelId: string option with get, set

    and SystemColor =
        obj

    and [<AllowNullLiteral>] SystemPreferences =
        abstract on: ``event``: obj * listener: Func<Event, string, unit> -> obj
        abstract on: ``event``: obj * listener: Func<Event, unit> -> obj
        abstract on: ``event``: obj * listener: Func<Event, bool, unit> -> obj
        abstract on: ``event``: string * listener: Function -> obj
        abstract isDarkMode: unit -> bool
        abstract isSwipeTrackingFromScrollEventsEnabled: unit -> bool
        abstract postNotification: ``event``: string * userInfo: obj -> unit
        abstract postLocalNotification: ``event``: string * userInfo: obj -> unit
        abstract subscribeNotification: ``event``: string * callback: Func<Event, obj, unit> -> float
        abstract unsubscribeNotification: id: float -> unit
        abstract subscribeLocalNotification: ``event``: string * callback: Func<Event, obj, unit> -> float
        abstract unsubscribeLocalNotification: id: float -> unit
        abstract getUserDefault: key: string * ``type``: obj -> obj
        abstract isAeroGlassEnabled: unit -> bool
        abstract getAccentColor: unit -> string
        abstract isInvertedColorScheme: unit -> bool
        abstract getColor: color: SystemColor -> string

    and [<AllowNullLiteral>] [<Import("Tray","Electron")>] Tray(image: U2<NativeImage, string>) =
        interface NodeJS.EventEmitter
        interface Destroyable with
            member __.destroy(): unit = jsNative
            member __.isDestroyed(): bool = jsNative
        member __.on(``event``: obj, listener: Func<Modifiers, Rectangle, unit>): obj = jsNative
        member __.on(``event``: obj, listener: Function): obj = jsNative
        member __.on(``event``: obj, listener: Func<Event, ResizeArray<string>, unit>): obj = jsNative
        member __.on(``event``: obj, listener: Func<Event, string, unit>): obj = jsNative
        member __.on(``event``: string, listener: Function): obj = jsNative
        member __.setImage(image: U2<NativeImage, string>): unit = jsNative
        member __.setPressedImage(image: NativeImage): unit = jsNative
        member __.setToolTip(toolTip: string): unit = jsNative
        member __.setTitle(title: string): unit = jsNative
        member __.setHighlightMode(mode: U3<obj, obj, obj>): unit = jsNative
        member __.displayBalloon(?options: obj): unit = jsNative
        member __.popUpContextMenu(?menu: Menu, ?position: Point): unit = jsNative
        member __.setContextMenu(menu: Menu): unit = jsNative
        member __.getBounds(): Rectangle = jsNative

    and [<AllowNullLiteral>] Modifiers =
        abstract altKey: bool with get, set
        abstract shiftKey: bool with get, set
        abstract ctrlKey: bool with get, set
        abstract metaKey: bool with get, set

    and [<AllowNullLiteral>] DragItem =
        abstract file: string with get, set
        abstract icon: NativeImage with get, set

    and [<AllowNullLiteral>] WebContentsStatic =
        abstract getAllWebContents: unit -> ResizeArray<WebContents>
        abstract getFocusedWebContents: unit -> WebContents
        abstract fromId: id: float -> WebContents

    and [<AllowNullLiteral>] WebContents =
        inherit NodeJS.EventEmitter
        abstract id: float with get, set
        abstract session: Session with get, set
        abstract hostWebContents: WebContents with get, set
        abstract devToolsWebContents: WebContents with get, set
        abstract debugger: Debugger with get, set
        abstract on: ``event``: obj * listener: Function -> obj
        abstract on: ``event``: obj * listener: Func<Event, float, string, string, bool, unit> -> obj
        abstract on: ``event``: obj * listener: Func<Event, bool, unit> -> obj
        abstract on: ``event``: obj * listener: Func<Event, bool, string, string, float, string, string, Headers, string, unit> -> obj
        abstract on: ``event``: obj * listener: Func<Event, string, string, bool, float, string, string, Headers, unit> -> obj
        abstract on: ``event``: obj * listener: Func<Event, unit> -> obj
        abstract on: ``event``: obj * listener: Func<Event, ResizeArray<string>, unit> -> obj
        abstract on: ``event``: obj * listener: Func<Event, string, string, NewWindowDisposition, BrowserWindowOptions, unit> -> obj
        abstract on: ``event``: obj * listener: Func<Event, string, unit> -> obj
        abstract on: ``event``: obj * listener: Func<Event, string, bool, unit> -> obj
        abstract on: ``event``: obj * listener: Func<Event, string, string, unit> -> obj
        abstract on: ``event``: obj * listener: Func<Event, string, string, Certificate, Func<bool, unit>, unit> -> obj
        abstract on: ``event``: obj * listener: Func<Event, string, ResizeArray<Certificate>, Func<Certificate, unit>, unit> -> obj
        abstract on: ``event``: obj * listener: Func<Event, LoginRequest, LoginAuthInfo, Func<string, string, unit>, unit> -> obj
        abstract on: ``event``: obj * listener: Func<Event, FoundInPageResult, unit> -> obj
        abstract on: ``event``: obj * listener: Func<Event, CursorType, NativeImage, float, Size, Point, unit> -> obj
        abstract on: ``event``: obj * listener: Func<Event, ContextMenuParams, unit> -> obj
        abstract on: ``event``: obj * listener: Func<Event, ResizeArray<BluetoothDevice>, Func<string, unit>, unit> -> obj
        abstract on: ``event``: obj * listener: Func<Event, Rectangle, NativeImage, unit> -> obj
        abstract on: ``event``: string * listener: Function -> obj
        abstract loadURL: url: string * ?options: LoadURLOptions -> unit
        abstract downloadURL: url: string -> unit
        abstract getURL: unit -> string
        abstract getTitle: unit -> string
        abstract isDestroyed: unit -> bool
        abstract isFocused: unit -> bool
        abstract isLoading: unit -> bool
        abstract isLoadingMainFrame: unit -> bool
        abstract isWaitingForResponse: unit -> bool
        abstract stop: unit -> unit
        abstract reload: unit -> unit
        abstract reloadIgnoringCache: unit -> unit
        abstract canGoBack: unit -> bool
        abstract canGoForward: unit -> bool
        abstract canGoToOffset: offset: float -> bool
        abstract clearHistory: unit -> unit
        abstract goBack: unit -> unit
        abstract goForward: unit -> unit
        abstract goToIndex: index: float -> unit
        abstract goToOffset: offset: float -> unit
        abstract isCrashed: unit -> bool
        abstract setUserAgent: userAgent: string -> unit
        abstract getUserAgent: unit -> string
        abstract insertCSS: css: string -> unit
        abstract executeJavaScript: code: string * ?userGesture: bool * ?callback: Func<obj, unit> -> Promise<obj>
        abstract setAudioMuted: muted: bool -> unit
        abstract isAudioMuted: unit -> bool
        abstract setZoomFactor: factor: float -> unit
        abstract getZoomFactor: callback: Func<float, unit> -> unit
        abstract setZoomLevel: level: float -> unit
        abstract getZoomLevel: callback: Func<float, unit> -> unit
        abstract setVisualZoomLevelLimits: minimumLevel: float * maximumLevel: float -> unit
        abstract setLayoutZoomLevelLimits: minimumLevel: float * maximumLevel: float -> unit
        abstract undo: unit -> unit
        abstract redo: unit -> unit
        abstract cut: unit -> unit
        abstract copy: unit -> unit
        abstract copyImageAt: x: float * y: float -> unit
        abstract paste: unit -> unit
        abstract pasteAndMatchStyle: unit -> unit
        abstract delete: unit -> unit
        abstract selectAll: unit -> unit
        abstract unselect: unit -> unit
        abstract replace: text: string -> unit
        abstract replaceMisspelling: text: string -> unit
        abstract insertText: text: string -> unit
        abstract findInPage: text: string * ?options: FindInPageOptions -> float
        abstract stopFindInPage: action: StopFindInPageAtion -> unit
        abstract hasServiceWorker: callback: Func<bool, unit> -> unit
        abstract unregisterServiceWorker: callback: Func<bool, unit> -> unit
        abstract print: ?options: PrintOptions -> unit
        abstract printToPDF: options: PrintToPDFOptions * callback: Func<Error, Buffer, unit> -> unit
        abstract addWorkSpace: path: string -> unit
        abstract removeWorkSpace: path: string -> unit
        abstract openDevTools: ?options: obj -> unit
        abstract closeDevTools: unit -> unit
        abstract isDevToolsOpened: unit -> bool
        abstract isDevToolsFocused: unit -> bool
        abstract toggleDevTools: unit -> unit
        abstract inspectElement: x: float * y: float -> unit
        abstract inspectServiceWorker: unit -> unit
        abstract send: channel: string * [<ParamArray>] args: obj[] -> unit
        abstract enableDeviceEmulation: parameters: DeviceEmulationParameters -> unit
        abstract disableDeviceEmulation: unit -> unit
        abstract sendInputEvent: ``event``: SendInputEvent -> unit
        abstract beginFrameSubscription: onlyDirty: bool * callback: BeginFrameSubscriptionCallback -> unit
        abstract beginFrameSubscription: callback: BeginFrameSubscriptionCallback -> unit
        abstract endFrameSubscription: unit -> unit
        abstract savePage: fullPath: string * saveType: U3<obj, obj, obj> * ?callback: Func<Error, unit> -> bool
        abstract showDefinitionForSelection: unit -> unit
        abstract isOffscreen: unit -> bool
        abstract startPainting: unit -> unit
        abstract stopPainting: unit -> unit
        abstract isPainting: unit -> bool
        abstract setFrameRate: fps: float -> unit
        abstract getFrameRate: unit -> float
        abstract invalidate: unit -> unit
        abstract startDrag: item: DragItem -> unit
        abstract capturePage: callback: Func<NativeImage, unit> -> unit
        abstract capturePage: rect: Rectangle * callback: Func<NativeImage, unit> -> unit

    and [<AllowNullLiteral>] BeginFrameSubscriptionCallback =
        [<Emit("$0($1...)")>] abstract Invoke: frameBuffer: Buffer * ?dirtyRect: Rectangle -> unit

    and [<AllowNullLiteral>] ContextMenuParams =
        abstract x: float with get, set
        abstract y: float with get, set
        abstract linkURL: string with get, set
        abstract linkText: string with get, set
        abstract pageURL: string with get, set
        abstract frameURL: string with get, set
        abstract srcURL: string with get, set
        abstract mediaType: obj with get, set
        abstract mediaFlags: obj with get, set
        abstract hasImageContents: bool with get, set
        abstract isEditable: bool with get, set
        abstract editFlags: obj with get, set
        abstract selectionText: string with get, set
        abstract titleText: string with get, set
        abstract misspelledWord: string with get, set
        abstract frameCharset: string with get, set
        abstract inputFieldType: U4<obj, obj, obj, obj> with get, set
        abstract menuSourceType: obj with get, set

    and [<AllowNullLiteral>] BluetoothDevice =
        abstract deviceName: string with get, set
        abstract deviceId: string with get, set

    and [<AllowNullLiteral>] Headers =
        [<Emit("$0[$1]{{=$2}}")>] abstract Item: key: string -> string with get, set

    and NewWindowDisposition =
        obj

    and StopFindInPageAtion =
        U3<obj, obj, obj>

    and CursorType =
        obj

    and [<AllowNullLiteral>] LoadURLOptions =
        abstract httpReferrer: string option with get, set
        abstract userAgent: string option with get, set
        abstract extraHeaders: string option with get, set
        abstract postData: ResizeArray<U3<UploadRawData, UploadFileSystem, UploadBlob>> option with get, set

    and [<AllowNullLiteral>] UploadRawData =
        abstract ``type``: obj with get, set
        abstract bytes: Buffer with get, set

    and [<AllowNullLiteral>] UploadFileSystem =
        abstract ``type``: obj with get, set
        abstract fileSystemURL: string with get, set
        abstract offset: float with get, set
        abstract length: float with get, set
        abstract modificationTime: float with get, set

    and [<AllowNullLiteral>] UploadBlob =
        abstract ``type``: obj with get, set
        abstract blobUUID: string with get, set

    and [<AllowNullLiteral>] PrintOptions =
        abstract silent: bool option with get, set
        abstract printBackground: bool option with get, set

    and [<AllowNullLiteral>] PrintToPDFOptions =
        abstract marginsType: float option with get, set
        abstract pageSize: obj option with get, set
        abstract printBackground: bool option with get, set
        abstract printSelectionOnly: bool option with get, set
        abstract landscape: bool option with get, set

    and [<AllowNullLiteral>] Certificate =
        abstract data: string with get, set
        abstract issuer: CertificatePrincipal with get, set
        abstract issuerName: string with get, set
        abstract issuerCert: Certificate with get, set
        abstract subject: CertificatePrincipal with get, set
        abstract subjectName: string with get, set
        abstract serialNumber: string with get, set
        abstract validStart: float with get, set
        abstract validExpiry: float with get, set
        abstract fingerprint: string with get, set

    and [<AllowNullLiteral>] CertificatePrincipal =
        abstract commonName: string with get, set
        abstract organizations: ResizeArray<string> with get, set
        abstract organizationUnits: ResizeArray<string> with get, set
        abstract locality: string with get, set
        abstract state: string with get, set
        abstract country: string with get, set

    and [<AllowNullLiteral>] LoginRequest =
        abstract ``method``: string with get, set
        abstract url: string with get, set
        abstract referrer: string with get, set

    and [<AllowNullLiteral>] LoginAuthInfo =
        abstract isProxy: bool with get, set
        abstract scheme: string with get, set
        abstract host: string with get, set
        abstract port: float with get, set
        abstract realm: string with get, set

    and [<AllowNullLiteral>] FindInPageOptions =
        abstract forward: bool option with get, set
        abstract findNext: bool option with get, set
        abstract matchCase: bool option with get, set
        abstract wordStart: bool option with get, set
        abstract medialCapitalAsWordStart: bool option with get, set

    and [<AllowNullLiteral>] FoundInPageResult =
        abstract requestId: float with get, set
        abstract finalUpdate: bool with get, set
        abstract activeMatchOrdinal: float option with get, set
        abstract matches: float option with get, set
        abstract selectionArea: Rectangle option with get, set

    and [<AllowNullLiteral>] DeviceEmulationParameters =
        abstract screenPosition: U2<obj, obj> option with get, set
        abstract screenSize: Size option with get, set
        abstract viewPosition: Point option with get, set
        abstract deviceScaleFactor: float with get, set
        abstract viewSize: Size option with get, set
        abstract fitToView: bool option with get, set
        abstract offset: Point option with get, set
        abstract scale: float with get, set

    and [<AllowNullLiteral>] SendInputEvent =
        abstract ``type``: obj with get, set
        abstract modifiers: ResizeArray<obj> with get, set

    and [<AllowNullLiteral>] SendInputKeyboardEvent =
        inherit SendInputEvent
        abstract keyCode: string with get, set

    and [<AllowNullLiteral>] SendInputMouseEvent =
        inherit SendInputEvent
        abstract x: float with get, set
        abstract y: float with get, set
        abstract button: U3<obj, obj, obj> option with get, set
        abstract globalX: float option with get, set
        abstract globalY: float option with get, set
        abstract movementX: float option with get, set
        abstract movementY: float option with get, set
        abstract clickCount: float option with get, set

    and [<AllowNullLiteral>] SendInputMouseWheelEvent =
        inherit SendInputEvent
        abstract deltaX: float option with get, set
        abstract deltaY: float option with get, set
        abstract wheelTicksX: float option with get, set
        abstract wheelTicksY: float option with get, set
        abstract accelerationRatioX: float option with get, set
        abstract accelerationRatioY: float option with get, set
        abstract hasPreciseScrollingDeltas: bool option with get, set
        abstract canScroll: bool option with get, set

    and [<AllowNullLiteral>] Debugger =
        inherit NodeJS.EventEmitter
        abstract attach: ?protocolVersion: string -> unit
        abstract isAttached: unit -> bool
        abstract detach: unit -> unit
        abstract sendCommand: ``meDone in 0.78s.
