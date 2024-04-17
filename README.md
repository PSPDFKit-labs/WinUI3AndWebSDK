# PSPDFKit for Web on WinUI3

1. I used Template Studio for WinUI to create this app, so there is some boilerplate code in it.
2. Updated the WinUI3/Views/MainPage.xaml and the corresponding code behind file. I used [`SetVirtualHostNameToFolderMapping`](SetVirtualHostNameToFolderMapping) to load the sdk and run it in WebView2.
3. Added web SDK's dist/pspdfkit.js & dist/pspdfkit-lib in sdk/Standalone folder.
4. Added index.html with minimalist HTML to load pspdfkit.js and load a document which is also present beside html file.

> Note:
> PSPDFKit for Web in a WinUI3 application isn't an officially supported configuration when this sample was created. 
> For latest updates and more information on integration or support please contact us at https://pspdfkit.com/company/contact/