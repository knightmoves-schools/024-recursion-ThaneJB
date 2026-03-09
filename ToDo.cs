namespace knightmoves;
public class ToDo
{
    // Add your code here
    public string[] MarkAsDone(string[] todos){
        todos[i] = "done - " + todos[i]
        i++;

        if(index < todos.Length){
            return MarkAsDone(todos);
        } else {
            return todos;
        }
    }
}
