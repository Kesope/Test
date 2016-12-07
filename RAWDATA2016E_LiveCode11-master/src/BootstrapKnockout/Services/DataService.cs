using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BootstrapKnockout.DomainModel;
using Microsoft.EntityFrameworkCore;
using DatabaseService;

namespace BootstrapKnockout.Services
{
    public class DataService : IDataService
    {
        private List<Pet> _pets = new List<Pet>
        {
            new Pet {Id = 1, Name = "Fido", Kind = "Dog"},
            new Pet {Id = 2, Name = "Pluto",   Kind = "Dog"},
            new Pet {Id = 3, Name = "Garfield",   Kind = "Cat"}
        };

        private List<Person> _persons = new List<Person>
        {
            new Person {Id = 1, Name = "Peter", Age = 21},
            new Person {Id = 2, Name = "Joe",   Age = 22},
            new Person {Id = 3, Name = "Sue",   Age = 23},
            new Person {Id = 4, Name = "Ellen", Age = 24},
            new Person {Id = 5, Name = "Allen", Age = 25}
        };

        public IList<Person> GetPersons()
        {
            return _persons;
        }

        public Person GetPerson(int id)
        {
            return _persons.FirstOrDefault(p => p.Id == id);
        }

        public IList<Pet> GetPets()
        {
            return _pets;
        }

        public Pet GetPet(int id)
        {
            return _pets.FirstOrDefault(p => p.Id == id);
        }

        //Post

        public IList<Post> GetPost(int page, int pagesize)
        {
            using (var db = new Sova())
            {
                return db.Post
                    .OrderBy(p => p.id)
                    .Skip(page * pagesize)
                    .Take(pagesize)
                    .ToList();
            }
        }

        public Post GetPost(int id)
        {
            using (var db = new Sova())
            {
                return db.Post.FirstOrDefault(p => p.id == id);
            }
        }

        public void AddPost(Post post)
        {
            throw new NotImplementedException();
        }

        public bool UpdatePost(Post post)
        {
            throw new NotImplementedException();
        }

        public bool DeletePost(int id)
        {
            throw new NotImplementedException();
        }

        public int GetNumberOfPost()
        {
            throw new NotImplementedException();
        }

        public IList<Comments> GetComments(int page, int pagesize)
        {
            using (var db = new Sova())
            {
                return db.Comments
                    .OrderBy(c => c.id)
                    .Skip(page * pagesize)
                    .Take(pagesize)
                    .ToList();
            }
        }

        public Comments GetComments(int id)
        {
            using (var db = new Sova())
            {
                return db.Comments.FirstOrDefault(c => c.id == id);
            }
        }

        public void AddComments(Comments comment)
        {
            throw new NotImplementedException();
        }

        public bool UpdateComments(Comments comment)
        {
            throw new NotImplementedException();
        }

        public bool DeleteComments(int id)
        {
            throw new NotImplementedException();
        }

        public int GetNumberOfComments()
        {
            throw new NotImplementedException();
        }
    }
}