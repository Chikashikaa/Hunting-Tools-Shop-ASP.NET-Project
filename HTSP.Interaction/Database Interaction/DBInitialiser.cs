namespace HTSP.Interaction.Database_Interaction.Configuration
{
    public class DBInitialiser
    {
        public static void Initialise(HTSPDbContext dbContext)
        {
            dbContext.Database.EnsureCreated();
        }
    }
}
