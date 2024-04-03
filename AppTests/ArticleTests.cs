namespace AppTests
{
    public class ArticleTests(App app) : TestBase<App>
    {
        public async Task Invalid_User_Input()
        {
            var (rsp, res) = await App.Client.POSTAsync<Endpoint, Request, ErrorResponse>(new()
            {
                FirstName = "x",
                LastName = "y"
            });
            rsp.StatusCode.Should().Be(HttpStatusCode.BadRequest);
            res.Errors.Count.Should().Be(2);
            res.Errors.Keys.Should().Equal("firstName", "lastName");
        }

        [Fact, Priority(2)]
        public async Task Valid_User_Input()
        {
            var (rsp, res) = await App.Client.POSTAsync<Endpoint, Request, Response>(new()
            {
                FirstName = "Mike",
                LastName = "Kelso"
            });
            rsp.IsSuccessStatusCode.Should().BeTrue();
            res.Message.Should().Be("Hello Mike Kelso...");
        }
    }
}