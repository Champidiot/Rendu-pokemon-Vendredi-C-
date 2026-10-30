using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge.Heritage
{
    public class Animalerie
    {
        
        private List<Animal> __animals;

        public event Action<Animal> OnAddAnimal;

        public Animalerie()
        {
            __animals = new List<Animal>();
        }

        public void AddAnimal(Animal animal)
        {
            __animals.Add(animal);

            if (animal is Chat chat && animal is not ChatQuiBoite && __animals.Any(a => a is Poisson))
            {
                Animal poisson = __animals.First(a => a is Poisson);
                chat.hasEatFish = true;
                poisson.Die();

            }

            else if (animal is Poisson && __animals.Any(a => a is Chat chatRi && chatRi is not ChatQuiBoite))
            {
                animal.Die();
                Chat chats = (Chat)__animals.First(a => a is Chat);
                chats.hasEatFish = true;

            }

            OnAddAnimal?.Invoke(animal);
            return;
        }

        public bool Contains(Animal anim)
        {
            for (int i = 0; i < __animals.Count; i++)
            {
                if (__animals[i] == anim)
                {
                    return true;
                }
            }
            return false;
        }

        public Animal GetAnimal(int i)
        {
            return __animals[i];
        }

        public void FeedAll()
        {
            for (int i = 0; i < __animals.Count; i++)
            {
                __animals[i].feedTime += 1;
            }
        }
    }
}
