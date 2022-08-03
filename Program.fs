open Microsoft.Xna.Framework
open Microsoft.Xna.Framework.Input

type TestGame () as this =
  inherit Game()

  let graphics = new GraphicsDeviceManager(this)

  do
    this.IsMouseVisible <- true

    graphics.PreferredBackBufferWidth <- 640
    graphics.PreferredBackBufferHeight <- 480

    graphics.ApplyChanges()

  override this.Update(gameTime : GameTime) =
    let ks = Keyboard.GetState()

    if ks.IsKeyDown(Keys.Escape) then
      this.Exit()

  override this.Draw(gameTime : GameTime) =
    this.GraphicsDevice.Clear(Color.CornflowerBlue)

[<EntryPoint>]
let main (argv : string array) =
  use game = new TestGame()

  game.Run()

  0
