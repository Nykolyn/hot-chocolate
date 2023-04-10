using DTOs;

public class Mutation
{
    private readonly HttpClient Client = new HttpClient();

    public async Task<Banner?> AddBanner(CreateBannerDTO banner)
    {
        var response = await Client.PostAsJsonAsync<CreateBannerDTO>("http://localhost:8080/items", banner);

        var createdBanner = await response.Content.ReadFromJsonAsync<Banner>();
        if (createdBanner is null)
        {
            return null;
        }

        return createdBanner;
    }

    public async Task<Banner?> UpdateBanner(UpdateBannerDTO banner)
    {
        var response = await Client.PatchAsJsonAsync<UpdateBannerDTO>($"http://localhost:8080/items/{banner.Id}", banner);

        var updatedBanner = await response.Content.ReadFromJsonAsync<Banner>();
        if (updatedBanner is null)
        {
            return null;
        }

        return updatedBanner;
    }

    public async Task<Guid> DeleteBanner(Guid id)
    {
        await Client.DeleteAsync($"http://localhost:8080/items/{id}");

        return id;
    }
}