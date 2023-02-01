using System;

namespace WackyStudios
{
    class Person
    {
        public string name;
        public float speed;
        public bool alive;

        private int age;
        private char middleInitial;

        public Person()
        {
            name = "";
            speed = 1.0f;
            alive = true;
        }

        public Person(string nameParameter, float speedParameter, bool aliveParameter)
        {
            name = nameParameter;
            speed = speedParameter;
            alive = aliveParameter;
        }

        public void SetAge(int ageParameter)
        {
            age = ageParameter;
        }

        public int GetAge()
        {
            return age;
        }

        public string SayAge()
        {
            return "I am " + age + " years old.";
        }
    }
}
