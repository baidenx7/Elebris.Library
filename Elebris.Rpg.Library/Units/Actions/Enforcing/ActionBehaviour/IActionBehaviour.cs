namespace Assets.Scripts.Units
{
    public interface IActionBehaviour
    {
        //Travels to the "end" of the action and the gets covnerted to the type of ActionBehaviour you were expecting
        object ReturnBehaviour();
    }


}