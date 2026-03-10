namespace knightmoves;
public class ToDo
{
    // Add your code here
    public string[] MarkAsDone(string[] todos, int i = 0){
        
        if(i >= todos.Length){
            return todos;
        }

        todos[i]= "done - " + todos[i];
        return MarkAsDone(todos, i + 1);
    }
}
