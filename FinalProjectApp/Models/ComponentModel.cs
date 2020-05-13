using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProjectApp.Models
{
    //class ComponentModel
    // {
    //}




    public class ComponentModel
    {
        //        public int Id { get; set; }
        //        public string Name { get; set; }
        //        public string Email { get; set; }                 -- PartNumber
        //        public string PhoneType { get; set; }             -- Type
        //        public string PhoneNumber { get; set; }           -- MemberOf
        //        public int Age { get; set; }                      -- Description
        //        public string Notes { get; set; }
        //        public System.DateTime CreatedDate { get; set; }

        public int Id { get; set; }
        public string Name { get; set; }
        public string PartNumber { get; set; }
        public string Type { get; set; }
        public string MemberOf { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public System.DateTime CreatedDate { get; set; }


        public FinalProjectRepository.ComponentModel ToRepositoryModel()
        {
            var _repositoryModel = new FinalProjectRepository.ComponentModel
            {
                Description = Description,
                CreatedDate = CreatedDate,
                PartNumber = PartNumber,
                Id = Id,
                Name = Name,
                Notes = Notes,
                MemberOf = MemberOf,
                Type = Type
            };

            return _repositoryModel;
        }

        public static ComponentModel ToModel(FinalProjectRepository.ComponentModel _respositoryModel)
        {
            var _componentModel = new ComponentModel
            {
                Description = _respositoryModel.Description,
                CreatedDate = _respositoryModel.CreatedDate,
                PartNumber = _respositoryModel.PartNumber,
                Id = _respositoryModel.Id,
                Name = _respositoryModel.Name,
                Notes = _respositoryModel.Notes,
                MemberOf = _respositoryModel.MemberOf,
                Type = _respositoryModel.Type
            };

            return _componentModel;
        }
        public ComponentModel Clone()
        {
            // need to implement this but how? why? 
            // 05.08.2020

            // deep copy
            //            Person other = (Person)this.MemberwiseClone();
            //            other.IdInfo = new IdInfo(IdInfo.IdNumber);
            //            other.Name = String.Copy(Name);
            //            return other;
            //

            // CLONE THYSELF
            return (ComponentModel)this.MemberwiseClone();

        }

    }

}
