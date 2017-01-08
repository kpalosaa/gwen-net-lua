using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Gwen;
using Gwen.Control;
using MoonSharp.Interpreter;
using Color = Gwen.Color;

namespace Sample.MonoGame.Windows
{
	/// <summary>
	/// This is the main type for your game.
	/// </summary>
	public class SampleGame : Game
	{
		GraphicsDeviceManager graphics;

		bool changeGraphicsSettings;

		private Gwen.Renderer.MonoGame.Input.MonoGame input;
		private Gwen.Renderer.MonoGame.MonoGame renderer;
		private Gwen.Skin.SkinBase skin;
		private Gwen.Control.Canvas canvas;

		private int m_Time;

		private Script script;

		public SampleGame()
		{
			graphics = new GraphicsDeviceManager(this);
			graphics.PreferredBackBufferWidth = 1024;
			graphics.PreferredBackBufferHeight = 768;
			graphics.PreparingDeviceSettings += new EventHandler<PreparingDeviceSettingsEventArgs>(SetToPreserve‌​);

			graphics.SynchronizeWithVerticalRetrace = false;
			this.IsFixedTimeStep = false;

			Content.RootDirectory = "Content";

			changeGraphicsSettings = false;
		}

		/// <summary>
		/// Allows the game to perform any initialization it needs to before starting to run.
		/// This is where it can query for any required services and load any non-graphic
		/// related content.  Calling base.Initialize will enumerate through any components
		/// and initialize them as well.
		/// </summary>
		protected override void Initialize()
		{
			base.Initialize();

			this.Window.AllowUserResizing = true;
			this.Window.ClientSizeChanged += new EventHandler<EventArgs>(OnClientSizeChanged);

			IsMouseVisible = true;
		}

		/// <summary>
		/// LoadContent will be called once per game and is the place to load
		/// all of your content.
		/// </summary>
		protected override void LoadContent()
		{
			SampleLoader loader = new SampleLoader(Content) { Key = "112233445566778899aabbccddeeff" };

			Gwen.Platform.Platform.Init(new Gwen.Platform.MonoGame.MonoGamePlatform());
			Gwen.Loader.LoaderBase.Init(loader);

			renderer = new Gwen.Renderer.MonoGame.MonoGame(GraphicsDevice, Content, Content.Load<Effect>("GwenEffect"));
			renderer.Resize(graphics.PreferredBackBufferWidth, graphics.PreferredBackBufferHeight);

			skin = new Gwen.Skin.TexturedBase(renderer, "Skins/DefaultSkin");
			skin.DefaultFont = new Font(renderer, "Arial", 11);
			canvas = new Canvas(skin);
			input = new Gwen.Renderer.MonoGame.Input.MonoGame(this);
			input.Initialize(canvas);

			canvas.SetSize(graphics.PreferredBackBufferWidth, graphics.PreferredBackBufferHeight);
			canvas.ShouldDrawBackground = true;
			canvas.BackgroundColor = new Color(255, 150, 170, 170);

			m_Time = 0;

			script = new Script(CoreModules.Preset_SoftSandbox | CoreModules.LoadMethods);
			script.Options.ScriptLoader = loader;

			GwenNetLua.Lua.Init(script);
			GwenNetLua.Lua.SetCanvas(canvas);

			DynValue result;
			try
			{
				result = script.DoString("return require 'Sample'");
			}
			catch (ScriptRuntimeException ex)
			{
				throw new Exception(String.Format("Runtime error: {0}", ex.DecoratedMessage), ex);
			}
			catch (SyntaxErrorException ex)
			{
				throw new Exception(String.Format("Syntax error: {0}", ex.DecoratedMessage), ex);
			}
			catch (Exception ex)
			{
				throw new Exception(String.Format("Error: {0}", ex.Message), ex);
			}

			if (result.Type == DataType.UserData)
			{
				GwenNetLua.Control.ListBox textOutput = result.UserData.Object as GwenNetLua.Control.ListBox;
				if (textOutput != null)
					script.Options.DebugPrint = t => { textOutput.AddRow(t); textOutput.ScrollToBottom(); };
			}
		}

		/// <summary>
		/// UnloadContent will be called once per game and is the place to unload
		/// game-specific content.
		/// </summary>
		protected override void UnloadContent()
		{
			if (canvas != null)
			{
				canvas.Dispose();
				canvas = null;
			}
			if (skin != null)
			{
				skin.Dispose();
				skin = null;
			}
			if (renderer != null)
			{
				renderer.Dispose();
				renderer = null;
			}
		}

		/// <summary>
		/// Allows the game to run logic such as updating the world,
		/// checking for collisions, gathering input, and playing audio.
		/// </summary>
		/// <param name="gameTime">Provides a snapshot of timing values.</param>
		protected override void Update(GameTime gameTime)
		{
			if (changeGraphicsSettings)
			{
				graphics.ApplyChanges();
				changeGraphicsSettings = false;
			}

			m_Time += gameTime.ElapsedGameTime.Milliseconds;

			if (m_Time > 1000)
			{
				m_Time = 0;

				if (renderer.TextCacheSize > 1000) // each cached string is an allocated texture, flush the cache once in a while in your real project
					renderer.FlushTextCache();
			}

			input.ProcessMouseState();
			input.ProcessKeyboardState();
			input.ProcessTouchState();

			base.Update(gameTime);
		}

		/// <summary>
		/// This is called when the game should draw itself.
		/// </summary>
		/// <param name="gameTime">Provides a snapshot of timing values.</param>
		protected override void Draw(GameTime gameTime)
		{
			GraphicsDevice.Clear(Microsoft.Xna.Framework.Color.MidnightBlue);

			canvas.RenderCanvas();

			base.Draw(gameTime);
		}

		private void OnClientSizeChanged(object sender, EventArgs e)
		{
			graphics.PreferredBackBufferWidth = Window.ClientBounds.Width;
			graphics.PreferredBackBufferHeight = Window.ClientBounds.Height;

			changeGraphicsSettings = true;

			renderer.Resize(graphics.PreferredBackBufferWidth, graphics.PreferredBackBufferHeight);
			canvas.SetSize(graphics.PreferredBackBufferWidth, graphics.PreferredBackBufferHeight);
		}

		private void SetToPreserve(object sender, PreparingDeviceSettingsEventArgs eventargs)
		{
			eventargs.GraphicsDeviceInformation.PresentationParameters.R‌​enderTargetUsage = RenderTargetUsage.PreserveContents;
		}
	}
}
