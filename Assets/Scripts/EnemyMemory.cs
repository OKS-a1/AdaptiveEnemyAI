using UnityEngine;
using System.Collections.Generic;

public class EnemyMemory : MonoBehaviour
{
    Dictionary<Vector3, int> memory = new Dictionary<Vector3, int>();

    public void Remember(Vector3 pos)
    {
        Vector3 p = new Vector3(
            Mathf.Round(pos.x),
            0,
            Mathf.Round(pos.z)
        );

        if (memory.ContainsKey(p))
            memory[p]++;
        else
            memory[p] = 1;

        Debug.Log("AI Memory: " + p + " | Score: " + memory[p]);
    }

    public Vector3 GetBestLocation()
    {
        Vector3 best = transform.position;
        int score = 0;

        foreach (var m in memory)
        {
            if (m.Value > score)
            {
                score = m.Value;
                best = m.Key;
            }
        }

        return best;
    }

    public int GetBestScore()
    {
        int score = 0;

        foreach (var m in memory)
        {
            if (m.Value > score)
                score = m.Value;
        }

        return score;
    }
}