namespace Titan
{
    public static class QuestionController
    {
        public static void ConfigureQuestionController(this WebApplication app)
        {
            app.MapGet("/Questions", GetUsers);
            app.MapGet("/Questions/{id}", GetUser);
            app.MapPost("/Questions", InsertUser);
            app.MapPut("/Questions", UpdateUser);
            app.MapDelete("/Questions", DeleteUser);
        }

        private static async Task<IResult> GetUsers(IUser data)
        {
            try
            {
                //var t = await data.GetUsers();
                //return Results.Ok(await data.GetUsers());
                var tt = data.GetUsers();
                return Results.Ok(tt);
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> GetUser(int id, IUser data)
        {
            try
            {
                var results = await data.GetUser(id);
                if (results == null) return Results.NotFound();
                return Results.Ok(results);
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> InsertUser(User user, IUser data)
        {
            try
            {
                await data.InsertUser(user);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> UpdateUser(User user, IUser data)
        {
            try
            {
                await data.UpdateUser(user);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> DeleteUser(int id, IUser data)
        {
            try
            {
                await data.DeleteUser(id);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

    }
}
