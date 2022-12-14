using Microsoft.OpenApi.Extensions;

namespace LanguageFika.Api.Models.ViewModels;

public class UserViewModel
{
    public string? FirstName{ get; set; }
    public string? LastName{ get; set; }
    public string? Email{ get; set; }
    public string? PhoneNumber{ get; set; }
    
    public string? StreetAddress { get; set; }
    public string? City { get; set; }
    public string? Country { get; set; }
    public string? PostalCode { get; set; }
    public string? Description { get; set; }
    public DateTime? BirthDate { get; set; }
    

    public string? LearningLanguage{ get; set; }

    public string? TeachingLanguage{ get; set; }


    public string EnumToStringConverter(Language language){
        return language.GetDisplayName();
    }

}