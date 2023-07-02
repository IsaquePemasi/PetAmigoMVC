namespace PetAmigoMVC.Services
    //feito para gerenciar as permissões(roles)
{
    public interface ISeedUserRoleInitial
    {
        Task SeedRolesAsync();
        Task SeedUsersAsync();
    }
}
