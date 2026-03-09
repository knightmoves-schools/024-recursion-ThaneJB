namespace knightmoves;
public class ToDo
{
    // Add your code here
    public string[] MarkAsDone(string[] todos){
        int i = 0;
        todos[i] = "done - " + todos[i];
        i++;

        if(i < todos.Length){
            return MarkAsDone(todos);
        } else {
            return todos;
        }
    }
}
