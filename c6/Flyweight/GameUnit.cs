namespace launcher.c6.Flyweight;

public class GameUnit
{
    private int _x;
    private int _y;
    private Texture _texture;

    public GameUnit(int x, int y, string filename, TextureFactory factory)
    {
        _x = x;
        _y = y;
        _texture = factory.GetTexture(filename);
    }

    public void Draw()
    {
        _texture.Render(_x, _y);
    }
}