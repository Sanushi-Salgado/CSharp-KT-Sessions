using AutoMapper;
using ObjectMapping;
using System;

namespace CSharpTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating the source object
            Student student = new Student
            {
                Name = "Sanushi",
                Initials = "M S M Salgado",
                Age = 12,
                Faculty = "Department of Computing",
                Grade = 7,
            };

            // Manually copying data from one object to another object 
            StudentDTO studentDTO = new StudentDTO();
            studentDTO.Name = student.Name;
            studentDTO.Age = student.Age;
            studentDTO.Grade = student.Grade;

            // Print details
            Console.WriteLine("Name: " + studentDTO.Name);
            Console.WriteLine("Age: " + studentDTO.Age);
            Console.WriteLine("Grade: " + studentDTO.Grade);
            Console.WriteLine();


            /* -------------------------------- Using C# AutoMapper -------------------------------- */
            // Initialize the mapper
            var config = new MapperConfiguration(cfg =>
                cfg.CreateMap<Student, StudentDTO>()
                .ForMember(dest => dest.NameWithInitials, action => action.MapFrom(source => source.Initials))
                .ForMember(dest => dest.Department, action => action.MapFrom(source => source.Faculty))
            );

            var mapper = new Mapper(config);

            // Copying data from one object to another object 
            var studentDTO1 = mapper.Map<Student, StudentDTO>(student);
            var studentDTO2 = mapper.Map<StudentDTO>(student);

            Console.WriteLine("Name: " + studentDTO1.Name);
            Console.WriteLine("Initials: " + studentDTO1.NameWithInitials);
            Console.WriteLine("Age: " + studentDTO1.Age);
            Console.WriteLine("Faculty: " + studentDTO1.Department);
            Console.WriteLine("Grade: " + studentDTO1.Grade);
            Console.WriteLine();

            Console.WriteLine("Name: " + studentDTO2.Name);
            Console.WriteLine("Initials: " + studentDTO2.NameWithInitials);
            Console.WriteLine("Age: " + studentDTO2.Age);
            Console.WriteLine("Faculty: " + studentDTO1.Department);
            Console.WriteLine("Grade: " + studentDTO1.Grade);


            Console.ReadLine();
        }


    }
}
