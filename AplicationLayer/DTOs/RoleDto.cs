namespace AplicationLayer.DTOs
{
    public class RoleDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<PermisionDto> Permisions { get; set; } // Sau orice altă informație despre permisiuni
    }

}
