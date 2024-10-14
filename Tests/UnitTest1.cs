using AplicationLayer.AutomapProfiles;
using AplicationLayer.DTOs;
using AutoMapper;
using DataAccesLayer.Entities.Base.Groups;
using HrAppCore.Enums;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        private readonly IMapper _mapper;

        public UnitTest1()
        {
            // Configurarea AutoMapper pentru testare
            var config = new MapperConfiguration(cfg => cfg.AddProfile<AutoMapperProfile>());
            _mapper = config.CreateMapper();
        }

        [TestMethod]
        public void Should_Map_GroupDto_To_Group()
        {
            // Arrange: Creează un GroupDto pentru testare
            var groupDto = new GroupDto
            {
                Cui = "123456",
                Type = GroupType.PFA,
                DepartmentGroups = new List<DepartmentDto>()
                {
                   new DepartmentDto()
                   {
                           Type = 0,
                           Name = "d",
                           Manager = "d"
                   }

                },
                Users = new List<UserDto>()
                {
                    new UserDto()
                    {
                        Username = "x",
                        Email = "x",
                        Password = "x",
                        IsEmployeed = true
                    }
                }
            };

            // Act: Mapează GroupDto la Group
            var group = _mapper.Map<Group>(groupDto);

            // Assert: Verifică dacă proprietățile au fost mapate corect
            Assert.AreEqual(groupDto.Cui, group.Cui);
            Assert.AreEqual(groupDto.Type, group.Type);
            Assert.AreEqual(groupDto.DepartmentGroups.Count, group.DepartmentGroups.Count);
            Assert.AreEqual(groupDto.Users.Count, group.Users.Count);
        }
    }
}