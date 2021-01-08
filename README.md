# Package Manager UI Injection Helper

<p align="center">
	<img alt="GitHub package.json version" src ="https://img.shields.io/github/package-json/v/Thundernerd/Unity3D-PackageManagerUIInjectionHelper" />
	<a href="https://github.com/Thundernerd/Unity3D-PackageManagerUIInjectionHelper/issues">
		<img alt="GitHub issues" src ="https://img.shields.io/github/issues/Thundernerd/Unity3D-PackageManagerUIInjectionHelper" />
	</a>
	<a href="https://github.com/Thundernerd/Unity3D-PackageManagerUIInjectionHelper/pulls">
		<img alt="GitHub pull requests" src ="https://img.shields.io/github/issues-pr/Thundernerd/Unity3D-PackageManagerUIInjectionHelper" />
	</a>
	<a href="https://github.com/Thundernerd/Unity3D-PackageManagerUIInjectionHelper/blob/master/LICENSE.md">
		<img alt="GitHub license" src ="https://img.shields.io/github/license/Thundernerd/Unity3D-PackageManagerUIInjectionHelper" />
	</a>
	<img alt="GitHub last commit" src ="https://img.shields.io/github/last-commit/Thundernerd/Unity3D-PackageManagerUIInjectionHelper" />
</p>

A set of classes that allow you to inject your own code into the Package Manager Window

## Installation
1. The package is available on the [openupm registry](https://openupm.com). You can install it via [openupm-cli](https://github.com/openupm/openupm-cli).
```
openupm add net.tnrd.packagemanagerinjection
```
2. Installing through a [Unity Package](http://package-installer.glitch.me/v1/installer/package.openupm.com/net.tnrd.packagemanagerinjection?registry=https://package.openupm.com) created by the [Package Installer Creator](https://package-installer.glitch.me) from [Needle](https://needle.tools)

[<img src="https://img.shields.io/badge/-Download-success?style=for-the-badge"/>](http://package-installer.glitch.me/v1/installer/package.openupm.com/net.tnrd.packagemanagerinjection?registry=https://package.openupm.com)

## Usage

The `PackageManagerInjectionHelper` injects a visual element into the Package Manager Window through an `IPackageManagerExtension`. This is done through a `[InitializeOnLoadMethod]`.

You can access the injected visual element through the `PackageManagerInjectionHelper` like so

```c#
public class Foo
{
    [InitializeOnLoadMethod]
    private static void Init()
    {
        PackageManagerInjectionHelper.Injected += OnVisualElementInjected;
    }
    
    private static void OnVisualElementInjected()
    {
        InjectedVisualElement element = PackageManagerInjectionHelper.InjectedVisualElement;
    }
}
```

Note that there's an event to subscribe to. The `Injected` event is required because the visual element that gets injected might not get injected immediately after recompiling your code.

You can always access the element through `PackageManagerInjectionHelper.InjectedVisualElement`. Just keep in mind that it might not be ready yet and use the event properly.

---

Once you have access to the element you receive access to a number of items in the Package Manager Window

| Name                  | Description                                                                                                                 |
|-----------------------|-----------------------------------------------------------------------------------------------------------------------------|
| Root                  | The root visual element of the Package Manager Window. You should be able to access all child visual elements through here. |
| PackageManagerToolbar | The Package Manager Toolbar is the toolbar that resides at the top of the Package Manager Window.                           |
| PackageList           | The Package List is the list on the left side of the window that contains package groups and package items.                 |
| PackageStatusBar      | The Package Status Bar is the bar on the bottom left of the window. This is where the refresh button resides.               |
| PackageDetails        | The Package Details is the right part of the window that contains all the detailed information of the selected package.     |
| PackageToolbar        | The Package Toolbar is the toolbar on the bottom right. Here you'll find buttons like download, install, and remove.        |

Each of these items gives you access to a specific part of the Package Manager Window. However, all of these are automatically generated and based on reflection. Therefore there is no guarantee that this package will work across all versions of Unity.

Therefore I encourage people to submit issues whenever they find incompatibilities with a specific version, allowing me to generate a new set of classes for that specific version of Unity.

## Support
**Package Manager UI Injection Helper ** is a small and open-source utility that I hope helps other people. It is by no means necessary but if you feel generous you can support me by donating.

[![ko-fi](https://www.ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/J3J11GEYY)

## Contributing
Pull requests are welcomed. Please feel free to fix any issues you find, or add new features.
