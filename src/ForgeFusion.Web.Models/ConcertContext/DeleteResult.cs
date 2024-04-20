namespace ForgeFusion.Web.Models.ConcertContext
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
