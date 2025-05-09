using Lab2.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Lab2
{
    public class SomeEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
    }
    public class SomeImageEntity : SomeEntity
    {
        public string ImageUrl { get; set; }
    }

    public class SomeEntityController
    {
        private List<SomeEntity> _entities = new();
        private int _nextId = 1;

        public SomeEntity Create(SomeEntity entity)
        {
            entity.Id = _nextId++;
            _entities.Add(entity);
            return entity;
        }

        public SomeEntity Update(int id, SomeEntity updated)
        {
            var entity = _entities.FirstOrDefault(e => e.Id == id);
            if (entity == null) return null;

            entity.Name = updated.Name;
            entity.Description = updated.Description;
            entity.Status = updated.Status;
            return entity;
        }

        public SomeEntity? GetOne(int id)
        {
            return _entities.FirstOrDefault(e => e.Id == id);
        }

        public List<SomeEntity> GetMany()
        {
            return _entities;
        }

        public List<SomeEntity> GetByFilter(string status)
        {
            return _entities.Where(e => e.Status == status).ToList();
        }

        public bool Delete(int id)
        {
            var entity = _entities.FirstOrDefault(e => e.Id == id);
            if (entity == null) return false;

            _entities.Remove(entity);
            return true;
        }

        public void DeleteMany(List<int> ids)
        {
            _entities.RemoveAll(e => ids.Contains(e.Id));
        }

        public string? Print(int id)
        {
            var entity = _entities.FirstOrDefault(e => e.Id == id);
            return entity != null ? $"[{entity.Id}] {entity.Name}: {entity.Description} [{entity.Status}]" : null;
        }

        public List<string> PrintMany()
        {
            return _entities.Select(e => $"[{e.Id}] {e.Name}: {e.Description} [{e.Status}]").ToList();
        }

        public SomeEntity SetStatus(int id, string status)
        {
            var entity = _entities.FirstOrDefault(e => e.Id == id);
            if (entity == null) return null;

            entity.Status = status;
            return entity;
        }

        public SomeEntity Activate(int id) => SetStatus(id, "Active");
        public SomeEntity Deactivate(int id) => SetStatus(id, "Inactive");
    }

    public class SomeEntityClient
    {
        private readonly SomeEntityController _controller;

        public SomeEntityClient(SomeEntityController controller)
        {
            _controller = controller;
        }

        public SomeEntity Create(string name, string description, string status)
        {
            var entity = new SomeEntity
            {
                Name = name,
                Description = description,
                Status = status
            };
            return _controller.Create(entity);
        }

        public SomeEntity? Update(int id, string name, string description, string status)
        {
            var updated = new SomeEntity
            {
                Name = name,
                Description = description,
                Status = status
            };
            return _controller.Update(id, updated);
        }

        public SomeEntity? GetOne(int id)
        {
            return _controller.GetOne(id);
        }

        public List<SomeEntity> GetMany()
        {
            return _controller.GetMany();
        }

        public List<SomeEntity> GetByFilter(string status)
        {
            return _controller.GetByFilter(status);
        }

        public bool Delete(int id)
        {
            return _controller.Delete(id);
        }

        public void DeleteMany(List<int> ids)
        {
            _controller.DeleteMany(ids);
        }

        public SomeEntity? SetStatus(int id, string status)
        {
            return _controller.SetStatus(id, status);
        }
    }
    public class SomeEntityQueryService
    {
        private readonly SomeEntityController _controller;

        public SomeEntityQueryService(SomeEntityController controller)
        {
            _controller = controller;
        }

        public List<SomeEntity> GetActive()
        {
            return _controller.GetByFilter("Active");
        }

        public List<SomeEntity> GetInactive()
        {
            return _controller.GetByFilter("Inactive");
        }

        public List<SomeEntity> SearchByName(string keyword)
        {
            return _controller.GetMany()
                .Where(e => e.Name.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }
    }
    public class SomeImageEntityController
    {
        private readonly SomeEntityController _baseController;

        public SomeImageEntityController(SomeEntityController baseController)
        {
            _baseController = baseController;
        }

        public string? GetImage(int id)
        {
            var entity = _baseController.GetOne(id);
            return entity is SomeImageEntity imageEntity ? imageEntity.ImageUrl : null;
        }

        public bool SetImage(int id, string imageUrl)
        {
            var entity = _baseController.GetOne(id);
            if (entity is SomeImageEntity imageEntity)
            {
                imageEntity.ImageUrl = imageUrl;
                return true;
            }
            return false;
        }

        public List<SomeImageEntity> GetEntitiesByFilter(string status)
        {
            return _baseController
                .GetByFilter(status)
                .OfType<SomeImageEntity>()
                .ToList();
        }
    }
    public class Task2: IExamplePattern
    {
        public void Do()
        {
            var controller = new SomeEntityController();
            var client = new SomeEntityClient(controller);
            var query = new SomeEntityQueryService(controller);
            var imageController = new SomeImageEntityController(controller);

            // Создание обычных сущностей
            client.Create("Task A", "Generic entity", "Active");
            client.Create("Task B", "Generic entity", "Inactive");

            // Создание сущности с изображением через контроллер напрямую
            var imageEntity = new SomeImageEntity
            {
                Name = "Image Task",
                Description = "Entity with image",
                Status = "Active",
                ImageUrl = "http://example.com/image.jpg"
            };
            controller.Create(imageEntity);

            // Установка и получение изображения
            imageController.SetImage(imageEntity.Id, "http://example.com/updated-image.jpg");
            var imageUrl = imageController.GetImage(imageEntity.Id);
            Console.WriteLine($"Image URL for entity {imageEntity.Id}: {imageUrl}");

            // Поиск всех активных сущностей
            Console.WriteLine("\n▶ Active entities:");
            foreach (var entity in query.GetActive())
            {
                Console.WriteLine($"- {entity.Name} [{entity.Status}]");
            }

            // Поиск всех SomeImageEntity
            Console.WriteLine("\n▶ Image entities (active):");
            var imageEntities = imageController.GetEntitiesByFilter("Active");
            foreach (var img in imageEntities)
            {
                Console.WriteLine($"- {img.Name} | {img.ImageUrl}");
            }

            // Поиск по имени
            Console.WriteLine("\n▶ Search by name contains 'Task':");
            var searchResults = query.SearchByName("Task");
            foreach (var e in searchResults)
            {
                Console.WriteLine($"- {e.Name} [{e.Status}]");
            }
        }
    }
}







