using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Grubbin Species to store common natural stats of all Grubbins
	#region SpeciesGrubbin
	public class SpeciesGrubbin : PokemonSpecies
	{
#nullable enable
		private static SpeciesGrubbin? _instance = null;
#nullable restore
        public static SpeciesGrubbin Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesGrubbin();
                }
                return _instance;
            }
        }

		#region SpeciesGrubbin Constructor
		public SpeciesGrubbin() : base(
			736,
			"Grubbin",
			0.4,
			4.4,
			47, // HPs
			62, 45, // Attack & Defense
			55, 45, // Special Attack & Defense
			46		
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
				"Harden",
				"Light-Screen",
				"Rest",
				"Substitute",
				"Protect",
				"Mud-Slap",
				"Endure",
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
				"Mud-Shot",
				"Poison-Jab",
				"X-Scissor",
				"Bug-Bite",
				"Charge-Beam",
				"Round",
				"Acrobatics",
				"Volt-Switch",
				"Electroweb",
				"Wild-Charge",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Grubbin PokemonInstance Class
	#region Grubbin
	public class GrubbinInstance : PokemonInstance
	{
		#region Grubbin Constructors
		/// <summary>
		/// Grubbin Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public GrubbinInstance(string nickname, int level)
		: base(
				SpeciesGrubbin.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Grubbin Builder only waiting for a Level
		/// </summary>
		public GrubbinInstance(int level)
		: base(
				SpeciesGrubbin.Instance, // PokemonInstance Species
				"Grubbin", level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Grubbin Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public GrubbinInstance() : base(
			SpeciesGrubbin.Instance, // PokemonInstance Species
			Bug.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}