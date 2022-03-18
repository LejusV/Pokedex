using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Metapod Species to store common natural stats of all Metapods
	#region SpeciesMetapod
	public class SpeciesMetapod : PokemonSpecies
	{
#nullable enable
		private static SpeciesMetapod? _instance = null;
#nullable restore
        public static SpeciesMetapod Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMetapod();
                }
                return _instance;
            }
        }

		#region SpeciesMetapod Constructor
		public SpeciesMetapod() : base(
			11,
			"Metapod",
			0.7,
			9.9,
			50, // HPs
			20, 55, // Attack & Defense
			25, 25, // Special Attack & Defense
			30		
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
				"String-Shot",
				"Harden",
				"Iron-Defense",
				"Bug-Bite",
				"Electroweb"
			};
		}
		#endregion
	}
	#endregion

	//Metapod PokemonInstance Class
	#region Metapod
	public class MetapodInstance : PokemonInstance
	{
		#region Metapod Constructors
		/// <summary>
		/// Metapod Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MetapodInstance(string nickname, int level)
		: base(
				SpeciesMetapod.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Metapod Builder only waiting for a Level
		/// </summary>
		public MetapodInstance(int level)
		: base(
				SpeciesMetapod.Instance, // PokemonInstance Species
				"Metapod", level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Metapod Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public MetapodInstance() : base(
			SpeciesMetapod.Instance, // PokemonInstance Species
			Bug.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}