using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using FinalProjectDB;

namespace FinalProjectRepository
{
    public class ComponentModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PartNumber { get; set; }
        public string Type { get; set; }
        public string MemberOf { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public System.DateTime CreatedDate { get; set; }

        /*
         *
      PartNumber = _componentDb.ComponentPartNumber,
      CreatedDate = _componentDb.ComponentCreatedDate,
      Description = _componentDb.ComponentDescription,
      Id = _componentDb.ComponentId,
      Name = _componentDb.ComponentName,
      Notes = _componentDb.ComponentNotes,
      Type = _componentDb.ComponentType,
      MemberOf = _componentDb.ComponentMemberOf

        */







    }

    public class ComponentRepository
    {
        public ComponentModel Add(ComponentModel _componentModel)
        {
            var _componentDb = ToDbModel(_componentModel);

            DatabaseManager.Instance.Component.Add(_componentDb);
            DatabaseManager.Instance.SaveChanges();

            // 	[ComponentId] [int] IDENTITY(1,1) NOT NULL,
            //  [ComponentPartNumber] [nvarchar] (50) NULL,
            //	[ComponentName] [nvarchar] (50) NOT NULL,
            //
            //  [ComponentDescription] [nvarchar] (50) NOT NULL,
            //  
            //  [ComponentType] [nvarchar] (50) NULL,
            //	[ComponentMemberOf] [nvarchar] (50) NULL,
            //	[ComponentNotes] [nvarchar] (1000) NULL,
            //  [ComponentCreatedDate] [datetime] NOT NULL CONSTRAINT[DF_Component_ComponentCreatedDate] DEFAULT(getdate()),
            //

            _componentModel = new ComponentModel
            {
                PartNumber = _componentDb.ComponentPartNumber,
                CreatedDate = _componentDb.ComponentCreatedDate,
                Description = _componentDb.ComponentDescription,
                Id = _componentDb.ComponentId,
                Name = _componentDb.ComponentName,
                Notes = _componentDb.ComponentNotes,
                Type = _componentDb.ComponentType,
                MemberOf = _componentDb.ComponentMemberOf
            };
            return _componentModel;
        }

        public List<ComponentModel> GetAll()
        {
            // Use .Select() to map the database contacts to ComponentModel
            var items = DatabaseManager.Instance.Component
              .Select(t => new ComponentModel
              {
                  PartNumber = t.ComponentPartNumber,
                  CreatedDate = t.ComponentCreatedDate,
                  Description = t.ComponentDescription,
                  Id = t.ComponentId,
                  Name = t.ComponentName,
                  Notes = t.ComponentNotes,
                  Type = t.ComponentType,
                  MemberOf = t.ComponentMemberOf,
              }).ToList();

            return items;
        }

        public bool Update(ComponentModel _componentModel)
        {
            var original = DatabaseManager.Instance.Component.Find(_componentModel.Id);

            if (original != null)
            {
                DatabaseManager.Instance.Entry(original).CurrentValues.SetValues(ToDbModel(_componentModel));
                DatabaseManager.Instance.SaveChanges();
                return true;
            }

            return false;
        }

        public bool Remove(int _componentId)
        {
            var items = DatabaseManager.Instance.Component
                                .Where(t => t.ComponentId == _componentId);

            if (items.Count() == 0)
            {
                return false;
            }

            DatabaseManager.Instance.Component.Remove(items.First());
            DatabaseManager.Instance.SaveChanges();

            return true;
        }

        private Component ToDbModel(ComponentModel _componentModel)
        {
            var _componentDb = new Component
            {
                ComponentPartNumber = _componentModel.PartNumber,
                ComponentCreatedDate = _componentModel.CreatedDate,
                ComponentDescription = _componentModel.Description,
                ComponentId = _componentModel.Id,
                ComponentName = _componentModel.Name,
                ComponentNotes = _componentModel.Notes,
                ComponentType = _componentModel.Type,
                ComponentMemberOf = _componentModel.MemberOf,
            };

            return _componentDb;
        }
    }
}
