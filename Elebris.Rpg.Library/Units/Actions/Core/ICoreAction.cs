using Elebris.Rpg.Library.Unit.Core.Containers;

namespace Elebris.Actions.Library.Actions.Core
{
    public interface ICoreAction
    {
        void Execute(Character target);
        void DefineAction(Character user);
        //check if any passives apply to the particular action-type based on what action type it is, what kind of damage it deals etc


    }


}

