using Crud_Mongodb.Models;
using MongoDB.Driver;

namespace Crud_Mongodb.Services
{
    public class StudentService : IStudentService
    {
        private readonly IMongoCollection<Student> _students;
        public StudentService(IStudentStoreDatabaseSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.getDatabase(settings.DatabaseName);
            _students = database.GetCollection<Student>(settings.StudentCoursesCollectionName);
        }

        public List<Student> Get()
        {
            throw new NotImplementedException();
        }

        public Student Get(string Id)
        {
            throw new NotImplementedException();
        }

        public void Remove()
        {

        }

        public void Update()
        {

        }
    }
}