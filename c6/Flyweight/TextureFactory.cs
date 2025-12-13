namespace launcher.c6.Flyweight;

public class TextureFactory
{
    private Dictionary<string, Texture> _textures = new Dictionary<string, Texture>();

    public Texture GetTexture(string filename)
    {
        if (!_textures.ContainsKey(filename))
        {
            _textures[filename] = new Texture(filename);
        }
        return _textures[filename];
    }

    public int GetTotalTexturesLoaded()
    {
        return _textures.Count;
    }
}