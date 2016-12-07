using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BootstrapKnockout.DomainModel;
using Microsoft.EntityFrameworkCore;

namespace BootstrapKnockout.Services
{
    public interface IDataService
    {
        IList<Person> GetPersons();
        Person GetPerson(int id);
        IList<Pet> GetPets();
        Pet GetPet(int petId);

        //Comments
        IList<Comments> GetComments(int page, int pagesize);
        Comments GetComments(int id);
        void AddComments(Comments comment);
        bool UpdateComments(Comments comment);
        bool DeleteComments(int id);
        int GetNumberOfComments();

        //Posts
        IList<Post> GetPost(int page, int pagesize);
        Post GetPost(int id);
        void AddPost(Post post);
        bool UpdatePost(Post post);
        bool DeletePost(int id);
        int GetNumberOfPost();
    }
}
