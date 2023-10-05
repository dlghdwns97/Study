using System;

public class Solution {
    public int[] solution(string[] park, string[] routes) {
        int[] pos = new int[2] {-1, -1};
        int x, y;
        bool isMove;
        
        for (int i = 0; i < park.Length; i++)
        {
            for (int j = 0; j < park[i].Length; j++)
            {
                if (park[i][j] == 'S')
                {
                    pos[0] = i;
                    pos[1] = j;
                    break;
                }
            }
            if (pos[0] != -1 && pos[1] != -1) break;
        }
        
        for (int i = 0; i < routes.Length; i++)
        {
            x = pos[1];
            y = pos[0];
            isMove = true;
            
            for (int j = 0; j < (int)routes[i][2] - (int)'0'; j++)
            {
                if (routes[i][0] == 'N') y--;
                else if (routes[i][0] == 'S') y++;
                else if (routes[i][0] == 'E') x++;
                else if (routes[i][0] == 'W') x--;
                
                if (y < 0 || y >= park.Length || x < 0 || x >= park[0].Length || park[y][x] == 'X')
                {
                    isMove = false;
                    break;
                }
            }
                            
            if (isMove) pos = new int[2] {y, x};
        }

        return pos;
    }
}