public class KPlanet
{
    public float distance = 20f;
    public float speed = 1.5f; // orbital period
    public float radius = 1f;
    public float inclination = 0f;
    public float eccentricity = 1f;

    public KPlanet(float distance, float speed, float radius, float inclination, float eccentricity)
    {
        this.distance = distance;
        this.speed = speed;
        this.radius = radius;
        this.inclination = inclination;
        this.eccentricity = eccentricity;
    }
}