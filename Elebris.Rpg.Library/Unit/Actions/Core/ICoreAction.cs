using Elebris.Rpg.Library.CharacterValues;

namespace Elebris.Actions.Library.Actions.Core
{
    public interface ICoreAction
    {
        void Execute(Unit target);
        void DefineAction(Unit user);
        //check if any passives apply to the particular action-type based on what action type it is, what kind of damage it deals etc


    }


}

