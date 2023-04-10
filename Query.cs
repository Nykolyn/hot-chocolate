using System.Text.Json;

public class Query
{
    private readonly HttpClient Client = new HttpClient();

    public async Task<IEnumerable<Banner>?> GetBanners()
    {
        var banners = await Client.GetFromJsonAsync<Banner[]>("http://localhost:8080/items");

        if (banners is null)
        {
            throw new Exception("Failed to get banners from API.");
        }

        return banners;
    }

    public async Task<Banner>? GetBanner(Guid id)
    {
        var banner = await Client.GetFromJsonAsync<Banner>($"http://localhost:8080/items/{id}");

        if (banner is null)
        {
            throw new Exception("Failed to get banner from API.");
        }

        return banner;
    }
}
