//using DataAccesLayer.Entities.Base;
//using DataAccesLayer.Entities.Base.Defaults;
//using DataAccesLayer.Entities.Base.Departments;
//using DataAccesLayer.Entities.Base.Employees;
//using DataAccesLayer.Entities.Base.Roles;
//using Microsoft.AspNetCore.Builder;
//using Microsoft.Extensions.DependencyInjection;
//namespace DataAccesLayer
//{
//    public static class PrepDb
//    {
//        public static void PrepPopulation(IApplicationBuilder app)
//        {
//            using (var serviceScope = app.ApplicationServices.CreateScope())
//            {
//                SeedData(serviceScope.ServiceProvider.GetService<DataBaseContext>());
//            }
//        }
//        private static void SeedData(DataBaseContext dbContext)
//        {
//            if(!dbContext.Users.Any())
//            {
//                //dbContext.GroupUser.AddRange(
//                //     new GroupUser()
//                //     {
//                //         GroupId = "2",
//                //         UserId = "3",
//                //         Id = "4",
//                //     },
//                //    new GroupUser()
//                //    {
//                //        GroupId = "1",
//                //        UserId = "2",
//                //        Id = "3",
//                //    },
//                //    new GroupUser()
//                //    {
//                //        GroupId = "1",
//                //        UserId = "1",
//                //        Id = "4",
//                //    },
//                //    new GroupUser()
//                //    {
//                //        GroupId = "1",
//                //        UserId = "3",
//                //        Id = "5",
//                //    }
//                //    );
//                dbContext.RoleUsers.AddRange(
//                    new RoleUser()
//                    {
//                        Id = "1",
//                        UserId = "2",
//                        RoleId = "1",
//                    }
                    
//                    );
//                dbContext.Roles.AddRange(
//                   new Role()
//                   {
//                       Id = "1",
//                       Name = "Admin",
//                       Description = "test",
//                   }
//                   );
//                dbContext.PermissionRoles.AddRange(
//                    new PermissionRole()
//                    {
//                        PermissionId = "1",
//                        RoleId = "1",
//                        Id  = "1"
//                    },
//                      new PermissionRole()
//                      {
//                          PermissionId = "2",
//                          RoleId = "1",
//                          Id = "2"
//                      }
//                    );
//                dbContext.Permissions.AddRange(
//                    new Permission()
//                    {
//                        Id = "1",
//                        Type = HrAppCore.Enums.PermissionType.View,
//                        TableId = "User"
//                    },
//                     new Permission()
//                     {
//                         Id = "2",
//                         Type = HrAppCore.Enums.PermissionType.Update,
//                         TableId = "User"
//                     }
//                    );
//                dbContext.Employees.AddRange(
//                  new Employee()
//                  {
//                      Id= "1",
//                      FirstName="Dragos",
//                      LastName="Boboluta",
//                      Email="test@email.com",
//                      Phone = "0762031942",
//                      CNP = "124125123123",
//                      DateOfBirth = DateTime.Now,
//                      DateOfEmployeement = DateTime.Now,
//                      UserId = "2",
//                      DepartmentId = "1",
//                  }
//                   );
//                dbContext.Defaults.AddRange(
//                 new Default()
//                 {
//                     Id = "1",
//                     FirstName = "Marius",
//                     LastName = "Popescu",
//                     Email = "test@email.com",
//                     Phone = "0762031942",
//                     DateOfBirth = DateTime.Now,
//                     UserId = "1",
//                 }
//                  );
//                dbContext.Groups.AddRange(
//                    new Group()
//                    {
//                        Id = "1",
//                        Type = HrAppCore.Enums.GroupType.SRL,
//                    },
//                     new Group()
//                     {
//                         Id = "2",
//                         Type = HrAppCore.Enums.GroupType.PFA,
//                     }
//                );
//                dbContext.Departments.AddRange(
//                    new Department()
//                    {
//                        Id = "1",
//                        Type = HrAppCore.Enums.DepartmentType.HR,
//                        Manager = "Loredana Cinca",
//                        DepartmentEmployees = new List<Employee>(),
//                        GroupId = "1",
//                    },
//                     new Department()
//                     {
//                         Id = "2",
//                         Type = HrAppCore.Enums.DepartmentType.HR,
//                         Manager = "Loredana Cinca",
//                         DepartmentEmployees = new List<Employee>(),
//                         GroupId = "2",
//                     }
//                    ) ;
//            }
//            if (!dbContext.Users.Any())
//            {
//                Console.WriteLine("--> seeding data ...");
//                dbContext.Users.AddRange(
//     new User()
//     {
//         Id = "1",
//         Username = "user1",
//         Password = "password",
//         GroupId = "1",
//     },
//     new User()
//     {
//         Id = "3",
//         Username = "user2",
//         Password = "password",
//         GroupId = "1",


//     },
//     new User()
//     {
//         Id = Guid.NewGuid().ToString(),
//         Username = "user3",
//         Password = "password",
//         GroupId = "1",

//     },
//     new User()
//     {
//         Id = "2",
//         Username = "string",
//         Password = "string",
//         GroupId = "1",


//     },
//     new User()
//     {
//         Id = Guid.NewGuid().ToString(),
//         Username = "user5",
//         GroupId = "1",
//         Password = "password"

//     }
// );
//                dbContext.SaveChanges();

//            }
//            else
//            {
//                Console.WriteLine("--> we already have data");
//            }
//        }
//    }
//}
