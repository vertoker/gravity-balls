using UnityEngine;

public class MapGenerate : MonoBehaviour
{
    public Texture2D map;

    public ColorToPrefab[] colorMappings;

    public void Start()
    {
        GenerateLevel();
    }

    public void GenerateLevel()
    {
        for (int x = 0; x < map.width; x++)
        {
            for (int y = 0; y < map.height; y++)
            {
                GenerateTile(x, y);
            }
        }

    }

    public void GenerateTile(int x, int y)
    {
        Color pixelColor = map.GetPixel(x, y);

        if (pixelColor.a == 0)
        {
            return;
        }

        foreach (ColorToPrefab colorMapping in colorMappings)
        {
            if (colorMapping.color.Equals(pixelColor))
            {
                //Vector2 position = new Vector2(x, y);
                Instantiate(colorMapping.prefab, new Vector3(x, y, 0f), Quaternion.identity, transform);
                Instantiate(colorMapping.prefab2, new Vector3(x, y, -0.25f), Quaternion.identity, transform);
            }
        }
    }
}
