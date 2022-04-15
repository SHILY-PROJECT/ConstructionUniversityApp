using Microsoft.EntityFrameworkCore;
using ConstructionUniversity.Infrastructure.Students;
using ConstructionUniversity.Infrastructure.Teachers;
using ConstructionUniversity.Infrastructure.Lessons;
using ConstructionUniversity.Infrastructure.Homeworks;
using ConstructionUniversity.Infrastructure.JournalOfStudentPerformance;

namespace ConstructionUniversity.Infrastructure.DataAccess.Configuration;

internal static class TestDataForDatabaseConfiguration
{
    public static ModelBuilder ApplyTestData(this ModelBuilder modelBuilder)
    {
        var teacher1 = new TeacherDb { Id = Guid.NewGuid(), FirstName = "Arnold", LastName = "Williams", Email = "Arnold_Williams@gmail.com" };
        var teacher2 = new TeacherDb { Id = Guid.NewGuid(), FirstName = "Arthur", LastName = "Davis", Email = "Arthur_Davis@gmail.com" };
        var teacher3 = new TeacherDb { Id = Guid.NewGuid(), FirstName = "Ashley", LastName = "Moore", Email = "Ashley_Moore@gmail.com" };
        var teacher4 = new TeacherDb { Id = Guid.NewGuid(), FirstName = "Brian", LastName = "Smith", Email = "Brian_Smith@gmail.com" };
        var teacher5 = new TeacherDb { Id = Guid.NewGuid(), FirstName = "Caleb", LastName = "Garcia", Email = "Caleb_Garcia@gmail.com" };
        var teacher6 = new TeacherDb { Id = Guid.NewGuid(), FirstName = "Clifford", LastName = "Martin", Email = "Clifford_Martin@gmail.com" };
        var teacher7 = new TeacherDb { Id = Guid.NewGuid(), FirstName = "Arthur", LastName = "Anderson", Email = "Arthur_Anderson@gmail.com" };
        var teacher8 = new TeacherDb { Id = Guid.NewGuid(), FirstName = "Daniel", LastName = "Clark", Email = "Daniel_Clark@gmail.com" };
        var teacher9 = new TeacherDb { Id = Guid.NewGuid(), FirstName = "Edwin", LastName = "King", Email = "Edwin_King@gmail.com" };

        var student1 = new StudentDb { Id = Guid.NewGuid(), FirstName = "Elliot", LastName = "Collins", Email = "Elliot_Collins@gmail.com" };
        var student2 = new StudentDb { Id = Guid.NewGuid(), FirstName = "Eric", LastName = "Moore", Email = "Eric_Moore@gmail.com" };
        var student3 = new StudentDb { Id = Guid.NewGuid(), FirstName = "Gerald", LastName = "Baker", Email = "Gerald_Baker@gmail.com" };
        var student4 = new StudentDb { Id = Guid.NewGuid(), FirstName = "Elliot", LastName = "Evans", Email = "Elliot_Evans@gmail.com" };
        var student5 = new StudentDb { Id = Guid.NewGuid(), FirstName = "Herbert", LastName = "Roberts", Email = "Herbert_Roberts@gmail.com" };
        var student6 = new StudentDb { Id = Guid.NewGuid(), FirstName = "Joshua", LastName = "Carter", Email = "Joshua_Carter@gmail.com" };
        var student7 = new StudentDb { Id = Guid.NewGuid(), FirstName = "Elliot", LastName = "King", Email = "Elliot_King@gmail.com" };
        var student8 = new StudentDb { Id = Guid.NewGuid(), FirstName = "Joshua", LastName = "Clark", Email = "Joshua_Clark@gmail.com" };
        var student9 = new StudentDb { Id = Guid.NewGuid(), FirstName = "Lester", LastName = "Thompson", Email = "Lester_Thompson@gmail.com" };

        var lesson1 = new LessonDb { Id = Guid.NewGuid(), Name = "C# Language and the .NET Platform", Date = DateTime.Now, TeacherId = teacher1.Id };
        var lesson2 = new LessonDb { Id = Guid.NewGuid(), Name = "Getting Started with Visual Studio. First program", Date = DateTime.Now, TeacherId = teacher1.Id };
        var lesson3 = new LessonDb { Id = Guid.NewGuid(), Name = "Compiling at the command line with the .NET CLI", Date = DateTime.Now, TeacherId = teacher3.Id };
        var lesson4 = new LessonDb { Id = Guid.NewGuid(), Name = "Program structure", Date = DateTime.Now, TeacherId = teacher2.Id };
        var lesson5 = new LessonDb { Id = Guid.NewGuid(), Name = "Data types", Date = DateTime.Now, TeacherId = teacher3.Id };
        var lesson6 = new LessonDb { Id = Guid.NewGuid(), Name = "Conditional Expressions", Date = DateTime.Now, TeacherId = teacher4.Id };
        var lesson7 = new LessonDb { Id = Guid.NewGuid(), Name = "Cycles", Date = DateTime.Now, TeacherId = teacher7.Id };
        var lesson8 = new LessonDb { Id = Guid.NewGuid(), Name = "Local functions", Date = DateTime.Now, TeacherId = teacher7.Id };
        var lesson9 = new LessonDb { Id = Guid.NewGuid(), Name = "Static members and static modifier", Date = DateTime.Now, TeacherId = teacher3.Id };

        var homework1 = new HomeworkDb { Id = Guid.NewGuid(), Name = $"Homework by '{lesson1.Name}'" };
        var homework2 = new HomeworkDb { Id = Guid.NewGuid(), Name = $"Homework by '{lesson2.Name}'" };
        var homework3 = new HomeworkDb { Id = Guid.NewGuid(), Name = $"Homework by '{lesson3.Name}'" };
        var homework4 = new HomeworkDb { Id = Guid.NewGuid(), Name = $"Homework by '{lesson4.Name}'" };
        var homework5 = new HomeworkDb { Id = Guid.NewGuid(), Name = $"Homework by '{lesson5.Name}'" };
        var homework6 = new HomeworkDb { Id = Guid.NewGuid(), Name = $"Homework by '{lesson6.Name}'" };
        var homework7 = new HomeworkDb { Id = Guid.NewGuid(), Name = $"Homework by '{lesson7.Name}'" };
        var homework8 = new HomeworkDb { Id = Guid.NewGuid(), Name = $"Homework by '{lesson8.Name}'" };
        var homework9 = new HomeworkDb { Id = Guid.NewGuid(), Name = $"Homework by '{lesson9.Name}'" };

        var homeworkWithMark1 = new HomeworkWithMarkDb { Id = Guid.NewGuid(), HomeworkId = homework1.Id, Mark = 3 };
        var homeworkWithMark2 = new HomeworkWithMarkDb { Id = Guid.NewGuid(), HomeworkId = homework1.Id, Mark = 4 };
        var homeworkWithMark3 = new HomeworkWithMarkDb { Id = Guid.NewGuid(), HomeworkId = homework1.Id, Mark = 4 };
        var homeworkWithMark4 = new HomeworkWithMarkDb { Id = Guid.NewGuid(), HomeworkId = homework2.Id, Mark = 3 };
        var homeworkWithMark5 = new HomeworkWithMarkDb { Id = Guid.NewGuid(), HomeworkId = homework2.Id, Mark = 2 };
        var homeworkWithMark6 = new HomeworkWithMarkDb { Id = Guid.NewGuid(), HomeworkId = homework2.Id, Mark = 0 };
        var homeworkWithMark7 = new HomeworkWithMarkDb { Id = Guid.NewGuid(), HomeworkId = homework3.Id, Mark = 5 };
        var homeworkWithMark8 = new HomeworkWithMarkDb { Id = Guid.NewGuid(), HomeworkId = homework3.Id, Mark = 4 };
        var homeworkWithMark9 = new HomeworkWithMarkDb { Id = Guid.NewGuid(), HomeworkId = homework3.Id, Mark = 3 };

        var studentPerformance1 = new StudentPerformanceDb { Id = Guid.NewGuid(), StudentId = student1.Id, LessonId = lesson1.Id, HomeworkWithMarkId = homeworkWithMark1.Id, IsWas = true };
        var studentPerformance2 = new StudentPerformanceDb { Id = Guid.NewGuid(), StudentId = student2.Id, LessonId = lesson1.Id, HomeworkWithMarkId = homeworkWithMark2.Id, IsWas = true };
        var studentPerformance3 = new StudentPerformanceDb { Id = Guid.NewGuid(), StudentId = student3.Id, LessonId = lesson1.Id, HomeworkWithMarkId = homeworkWithMark3.Id, IsWas = false };
        var studentPerformance4 = new StudentPerformanceDb { Id = Guid.NewGuid(), StudentId = student1.Id, LessonId = lesson2.Id, HomeworkWithMarkId = homeworkWithMark4.Id, IsWas = true };
        var studentPerformance5 = new StudentPerformanceDb { Id = Guid.NewGuid(), StudentId = student2.Id, LessonId = lesson2.Id, HomeworkWithMarkId = homeworkWithMark5.Id, IsWas = true };
        var studentPerformance6 = new StudentPerformanceDb { Id = Guid.NewGuid(), StudentId = student3.Id, LessonId = lesson2.Id, HomeworkWithMarkId = homeworkWithMark6.Id, IsWas = false };
        var studentPerformance7 = new StudentPerformanceDb { Id = Guid.NewGuid(), StudentId = student1.Id, LessonId = lesson3.Id, HomeworkWithMarkId = homeworkWithMark7.Id, IsWas = true };
        var studentPerformance8 = new StudentPerformanceDb { Id = Guid.NewGuid(), StudentId = student2.Id, LessonId = lesson3.Id, HomeworkWithMarkId = homeworkWithMark8.Id, IsWas = true };
        var studentPerformance9 = new StudentPerformanceDb { Id = Guid.NewGuid(), StudentId = student3.Id, LessonId = lesson3.Id, HomeworkWithMarkId = homeworkWithMark9.Id, IsWas = false };

        modelBuilder.Entity<TeacherDb>().HasData(teacher1, teacher2, teacher3, teacher4, teacher5, teacher6, teacher7, teacher8, teacher9);
        modelBuilder.Entity<StudentDb>().HasData(student1, student2, student3, student4, student5, student6, student7, student8, student9);
        modelBuilder.Entity<LessonDb>().HasData(lesson1, lesson2, lesson3, lesson4, lesson5, lesson6, lesson7, lesson8, lesson9);
        modelBuilder.Entity<HomeworkDb>().HasData(homework1, homework2, homework3, homework4, homework5, homework6, homework7, homework8, homework9);
        modelBuilder.Entity<HomeworkWithMarkDb>().HasData(homeworkWithMark1, homeworkWithMark2, homeworkWithMark3, homeworkWithMark4, homeworkWithMark5, homeworkWithMark6, homeworkWithMark7, homeworkWithMark8, homeworkWithMark9);
        modelBuilder.Entity<StudentPerformanceDb>().HasData(studentPerformance1, studentPerformance2, studentPerformance3, studentPerformance4, studentPerformance5, studentPerformance6, studentPerformance7, studentPerformance8, studentPerformance9);

        return modelBuilder;
    }
}