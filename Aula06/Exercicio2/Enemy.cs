namespace Exercicio2
{
    class Enemy
    {
        private string name;
        private float health;
        private float shield;

        public Enemy(string name)
        {
            SetName(name);
            health = 100;
            shield = 0;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name.Trim();
        }

        public float GetHealth()
        {
            return health;
        }

        public float GetShield()
        {
            return shield;
        }

        public void TakeDamage(float damage)
        {
            shield -= damage;
            if (shield < 0)
            {
                float damageLeft = -shield;
                shield = 0;
                health -= damageLeft;
                if (health < 0) health = 0;
            }
        }
    }
}
