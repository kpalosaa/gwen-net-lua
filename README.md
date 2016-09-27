# Gwen.Net Lua

MoonSharp proxy classes for Gwen.Net Ex.

[MoonSharp](http://www.moonsharp.org) is a Lua interpreter written entirely in C# for the .NET, Mono and Unity platforms.

[Gwen.Net Ex](https://github.com/kpalosaa/gwen-net-ex) is a port of [Gwen.Net](https://code.google.com/archive/p/gwen-dotnet) 
extended with a two-pass layout engine.

## Getting Started

In this example we use desktop version of Gwen.Net and OpenTK renderer. This will work on Windows, Linux and MacOS platforms.

```C#
// Set platform
Gwen.Platform.Platform.Init(new Gwen.Platform.Windows.WindowsPlatform());
// Set image and XML loader.
// In this example we use embedded resource loader and images from sample codes
Gwen.Loader.LoaderBase.Init(
	new Gwen.Loader.EmbeddedResourceLoader(
		typeof(GwenNetLua.Sample.Sample).Assembly,
		typeof(GwenNetLua.Sample.Sample).Namespace + ".Images",
		typeof(GwenNetLua.Sample.Sample).Namespace + ".Xml"));
// Create renderer
var renderer = new Gwen.Renderer.OpenTK.OpenTKGL40();
// Create skin
var skin = new Gwen.Skin.TexturedBase(renderer, "Skins/DefaultSkin.png");
// Set default font
skin.DefaultFont = new Gwen.Font(renderer, "Arial", 11);
// Create GWEN.NET canvas
var canvas = new Gwen.Control.Canvas(skin);
// Create input handler
var input = new Gwen.Renderer.OpenTK.Input.OpenTK(this);
// Initialize input handler
input.Initialize(canvas);
// Initialize canvas properties
canvas.SetSize(Width, Height); // Width and Height are the size of a window
canvas.ShouldDrawBackground = true;
canvas.BackgroundColor = new Gwen.Color(255, 150, 170, 170);
// Create MoonSharp script instance
var script = new Script(CoreModules.Preset_SoftSandbox);
// Initialize script instance with Gwen.Net Lua proxy classes and other needed stuff
GwenNetLua.Lua.Init(script);
// Set canvas
GwenNetLua.Lua.SetCanvas(canvas);
// Lua script
string lua = @"
	button = Gwen.Button.Create(Gwen.Canvas)
	button.HorizontalAlignment = Gwen.HorizontalAlignment.Center
	button.VerticalAlignment = Gwen.VerticalAlignment.Center
	button.Padding = Gwen.Padding.Five
	button.Text = 'Click Me'
	";
// Run Lua script
script.DoString(lua);
```
