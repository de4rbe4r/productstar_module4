using module4.Entities.Dish;
using System.Diagnostics;

namespace module4.Repositories.Dish
{
    /// <inheritdoc />
    public class DishMemoryRepository : IDishRepository
    {
        private List<DishEntity> dishes;

        public DishMemoryRepository() {
            dishes = new List<DishEntity>
            { 
                new DishEntity
                {
                    Id = 1,
                    Title = "Блюдо 1",
                    Price = (decimal)100.25,
                },
                new DishEntity
                {
                    Id = 2,
                    Title = "Блюдо 2",
                    Price = (decimal)200.55,
                },
                new DishEntity
                {
                    Id = 3,
                    Title = "Блюдо 3",
                    Price = (decimal)55.75,
                },
            };
        }


        public long Add(DishEntity dish)
        {
            ArgumentNullException.ThrowIfNull(dish);

            var addedItem = new DishEntity {
                Id = dishes.Count() + 1,
                Title = dish.Title,
                Price = dish.Price,
            };
            dishes.Add(addedItem);
            return addedItem.Id;
        }

        public bool Delete(long id)
        {
            var removedItem = dishes.FirstOrDefault(d => d.Id == id);
            if (removedItem != null)
            {
                dishes.Remove(removedItem);
                return true;
            }

            return false;
        }
    }
}
