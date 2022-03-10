using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Charjabug Species to store common natural stats of all Charjabugs
	#region SpeciesCharjabug
	public class SpeciesCharjabug : PokemonSpecies
	{
#nullable enable
		private static SpeciesCharjabug? _instance = null;
#nullable restore
        public static SpeciesCharjabug Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesCharjabug();
                }
                return _instance;
            }
        }

		#region SpeciesCharjabug Constructor
		public SpeciesCharjabug() : base(
			"Charjabug",
			0.5,
			10.5,
			57, // HPs
			82, 95, // Attack & Defense
			55, 75, // Special Attack & Defense
			36		
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
				"Bite",
				"String-Shot",
				"Thunderbolt",
				"Thunder-Wave",
				"Dig",
				"Toxic",
				"Double-Team",
				"Light-Screen",
				"Rest",
				"Substitute",
				"Protect",
				"Mud-Slap",
				"Swagger",
				"Spark",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Crunch",
				"Facade",
				"Charge",
				"Iron-Defense",
				"Poison-Jab",
				"X-Scissor",
				"Discharge",
				"Bug-Bite",
				"Charge-Beam",
				"Round",
				"Acrobatics",
				"Volt-Switch",
				"Wild-Charge",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Charjabug PokemonInstance Class
	#region Charjabug
	public class CharjabugInstance : PokemonInstance
	{
		#region Charjabug Constructors
		/// <summary>
		/// Charjabug Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public CharjabugInstance(string nickname, int level)
		: base(
				737,
				SpeciesCharjabug.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance, Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Charjabug Builder only waiting for a Level
		/// </summary>
		public CharjabugInstance(int level)
		: base(
				737,
				SpeciesCharjabug.Instance, // PokemonInstance Species
				"Charjabug", level,
				Bug.Instance, Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Charjabug Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Charjabug() : base(
			737,
			SpeciesCharjabug.Instance, // PokemonInstance Species
			Bug.Instance, Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}