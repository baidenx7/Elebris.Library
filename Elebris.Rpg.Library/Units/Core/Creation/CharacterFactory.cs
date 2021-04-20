using Elebris.Rpg.Library.Unit.Core.Containers;
using Elebris.Rpg.Library.Units.Data;
using Elebris.Rpg.Library.Units.Equipment;
using Elebris.Rpg.Library.Units.Progression;
using Elebris.Rpg.Library.Units.Resources;
using Elebris.Rpg.Library.Units.Values.Creation;
using System;

namespace Elebris.Rpg.Library.Units.Core.Creation
{

    public class CharacterFactory : ICharacterFactory
    {
        private readonly IValueHandlerFactory _valueBuilder;
        private readonly IResourceHandlerFactory _resourceBuilder;
        private readonly IProgressionHandlerFactory _progressionBuilder;
        private readonly IDataHandlerFactory _dataBuilder;
        private readonly IEquipmentBuilder _equipmentBuilder;

        public CharacterFactory(IValueHandlerFactory valueBuilder, IResourceHandlerFactory resourceBuilder, IProgressionHandlerFactory progressionBuilder,
             IDataHandlerFactory dataBuilder, IEquipmentBuilder equipmentBuilder)
        {
            _valueBuilder = valueBuilder;
            _resourceBuilder = resourceBuilder;
            _progressionBuilder = progressionBuilder;
            _dataBuilder = dataBuilder;
            _equipmentBuilder = equipmentBuilder;
        }
        public Character CreateCharacter()
        {
            Character character = new Character(_valueBuilder, _resourceBuilder, _progressionBuilder,
                _dataBuilder, _equipmentBuilder);
            return character;

        }
        public Character CreateUnit(Guid guid)
        {
            Character character = new Character(_valueBuilder, _resourceBuilder, _progressionBuilder,
                _dataBuilder, _equipmentBuilder);
            //load rather than create
            return character;
        }



    }

}
