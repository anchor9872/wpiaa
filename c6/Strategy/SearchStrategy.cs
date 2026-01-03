namespace launcher.c6.Strategy;

public class SearchStrategy
{
    private IImageSearchStrategy? _searchStrategy;

    public void SetSearchStrategy(IImageSearchStrategy strategy)
    {
        _searchStrategy = strategy;
    }

    public async Task FindPhotos(string topic)
    {
        if (_searchStrategy == null)
        {
            Console.WriteLine("Nie wybrano sposobu wyszukiwania");
            return;
        }

        await _searchStrategy.Search(topic);
    }
}