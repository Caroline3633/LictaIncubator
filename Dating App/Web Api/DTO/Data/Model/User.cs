
using System;
namespace Web_Api.DTO.Data.Model
{
    public class User
    { 
     public int id{get;set;}

       public string firstName{get;set;} 

       public string lastName{get;set;}

       public string userName{get;set;}
     
       public string email{get;set;}

       public string password {get;set;}
       public string gender{get;set;}
       public DateTime DateOfBirth{get;set;}
    }
}