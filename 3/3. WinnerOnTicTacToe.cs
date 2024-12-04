//leet code 1275: Find Winner on a Tic Tac Toe Game

public class Solution {
    public string Tictactoe(int[][] moves) {
        string[][] map = 
        {
            new string[] { "", "", "" },
            new string[] { "", "", "" },
            new string[] { "", "", "" }
        }; //map in 3x3 space

        int index = 0;
        foreach(var move in moves)
        {
            if(index % 2 == 0)
            {
                map[move[0]][move[1]] = "X";
            }
            else
            {
                map[move[0]][move[1]] = "O";
            }
            index++;
        }

        string result = "";
        
        result = RowCheck(map);
        if(result == "X") return "A";
        else if(result == "O") return "B";

        result = ColCheck(map);
        if(result == "X") return "A";
        else if(result == "O") return "B";

        result = DiagCheck(map);
        if(result == "X") return "A";
        else if(result == "O") return "B";

        if(IsSpace(map))
        {
            return "Pending";
        }
        else return "Draw";

    }

    private string RowCheck(string[][] map)
    {
        for(int i=0; i<3; i++)
        {
            if(map[i][0] == map[i][1] && map[i][0] == map[i][2] && map[i][0] != "") return map[i][0];
        }
        
        return "Draw";
    }

    private string ColCheck(string[][] map)
    {
        for(int i=0; i<3; i++)
        {
            if(map[0][i] == map[1][i] && map[0][i] == map[2][i] && map[0][i] != "") return map[0][i];
        }

        return "Draw";
    }

    private string DiagCheck(string[][] map)
    {
        if(map[0][0] == map[1][1] && map[1][1] == map[2][2] && map[1][1] != "") return map[1][1];
        if(map[0][2] == map[1][1] && map[1][1] == map[2][0] && map[1][1] != "") return map[1][1];
        
        return "Draw";
    }

    private bool IsSpace(string[][] map)
    {
        foreach(var m in map)
        {
            for(int i=0; i<3; i++)
            {
                if(m[i] != "X" && m[i] != "O") return true;
            }
        }
        
        return false;
    }
}