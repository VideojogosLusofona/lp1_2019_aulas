namespace Exercicio4
{
    public class Enemy
    {
        private string name;
        private float health;
        private float shield;

        private static int powerupCount;

        public Enemy(string name)
        {
            SetName(name);
            health = 100;
            shield = 0;
        }

        static Enemy()
        {
            powerupCount = 0;
        }

        public static int GetPowerupCount()
        {
            return powerupCount;
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

        public void PickupPowerUp(PowerUp powerUp, float gain)
        {
            powerupCount++;

            if (powerUp == PowerUp.Health)
            {
                health += gain;
                if (health > 100) health = 100;
            }
            else if (powerUp == PowerUp.Shield)
            {
                shield += gain;
                if (shield > 100) shield = 100;
            }
        }
    }
}
