namespace ForgeFusion.Web.Models.Entities.Ticketing
{
    public class DeleteResult : UpdateResult
    {
        public static new DeleteResult SuccessResult()
        {
            return new DeleteResult
            {
                Success = true,
            };
        }
    }
}
