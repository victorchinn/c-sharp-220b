using AutoMapper;
using System;


namespace ContactApp.Models
{
    public class ContactModel
    {
        private static MapperConfiguration _mapperConfiguration = new
            MapperConfiguration(t => t.CreateMap<ContactModel,
            ContactRepository.ContactModel>().ReverseMap());

        private static IMapper mapper = _mapperConfiguration.CreateMapper();


        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneType { get; set; }
        public string PhoneNumber { get; set; }
        public int Age { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedDate { get; set; }

        public ContactRepository.ContactModel ToRepositoryModel()
        {
            var _repositoryModel = mapper.Map<ContactRepository.ContactModel>
                (this);

            return _repositoryModel;

//            var repositoryModel = new ContactRepository.ContactModel
//            {
//                Age = Age,
//                CreatedDate = CreatedDate,
//                Email = Email,
//                Id = Id,
//                Name = Name,
//                Notes = Notes,
//                PhoneNumber = PhoneNumber,
//                PhoneType = PhoneType
//            };
//
//            return repositoryModel;
        }

        public static ContactModel ToModel(ContactRepository.ContactModel repositoryModel)
        {
//            var contactModel = new ContactModel
//            {
//                Age = repositoryModel.Age,
//                CreatedDate = repositoryModel.CreatedDate,
//                Email = repositoryModel.Email,
//                Id = repositoryModel.Id,
//                Name = repositoryModel.Name,
//                Notes = repositoryModel.Notes,
//                PhoneNumber = repositoryModel.PhoneNumber,
//                PhoneType = repositoryModel.PhoneType
//            };
//
//            return contactModel;

            // make sure reversemap is also specified in configuration

            var contactModel = mapper.Map<ContactModel>(repositoryModel);
            return contactModel;
        }

        public ContactModel Clone()
        {
            // need to implement this but how? why? 
            // 05.08.2020

            // deep copy
            //            Person other = (Person)this.MemberwiseClone();
            //            other.IdInfo = new IdInfo(IdInfo.IdNumber);
            //            other.Name = String.Copy(Name);
            //            return other;
            //
            return (ContactModel) this.MemberwiseClone();


        }
    }
}