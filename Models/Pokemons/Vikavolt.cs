using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Vikavolt Species to store common natural stats of all Vikavolts
	#region SpeciesVikavolt
	public class SpeciesVikavolt : PokemonSpecies
	{
#nullable enable
		private static SpeciesVikavolt? _instance = null;
#nullable restore
        public static SpeciesVikavolt Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesVikavolt();
                }
                return _instance;
            }
        }

		#region SpeciesVikavolt Constructor
		public SpeciesVikavolt() : base(
			738,
			"Vikavolt",
			1.5,
			45.0,
			77, // HPs
			70, 90, // Attack & Defense
			145, 75, // Special Attack & Defense
			43		
		)
		{
			InitMovesList();
		}
		#endregion

		#region Methods
		private void InitMovesList()
		{
			_moveList = new List<string>()
			{
				"Vice-Grip",
				"Guillotine",
				"Bite",
				"Hyper-Beam",
				"Solar-Beam",
				"String-Shot",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Dig",
				"Toxic",
				"Agility",
				"Double-Team",
				"Light-Screen",
				"Rest",
				"Substitute",
				"Protect",
				"Mud-Slap",
				"Zap-Cannon",
				"Swagger",
				"Spark",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Facade",
				"Charge",
				"Roost",
				"Poison-Jab",
				"Air-Slash",
				"X-Scissor",
				"Bug-Buzz",
				"Energy-Ball",
				"Giga-Impact",
				"Flash-Cannon",
				"Bug-Bite",
				"Charge-Beam",
				"Round",
				"Sky-Drop",
				"Acrobatics",
				"Volt-Switch",
				"Wild-Charge",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Vikavolt PokemonInstance Class
	#region Vikavolt
	public class VikavoltInstance : PokemonInstance
	{
		#region Vikavolt Constructors
		/// <summary>
		/// Vikavolt Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public VikavoltInstance(string nickname, int level)
		: base(
				SpeciesVikavolt.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance, Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vikavolt Builder only waiting for a Level
		/// </summary>
		public VikavoltInstance(int level)
		: base(
				SpeciesVikavolt.Instance, // PokemonInstance Species
				"Vikavolt", level,
				Bug.Instance, Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vikavolt Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public VikavoltInstance() : base(
			SpeciesVikavolt.Instance, // PokemonInstance Species
			Bug.Instance, Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}