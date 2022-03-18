using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Runerigus Species to store common natural stats of all Runeriguss
	#region SpeciesRunerigus
	public class SpeciesRunerigus : PokemonSpecies
	{
#nullable enable
		private static SpeciesRunerigus? _instance = null;
#nullable restore
        public static SpeciesRunerigus Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesRunerigus();
                }
                return _instance;
            }
        }

		#region SpeciesRunerigus Constructor
		public SpeciesRunerigus() : base(
			867,
			"Runerigus",
			1.6,
			66.6,
			58, // HPs
			95, 145, // Attack & Defense
			50, 105, // Special Attack & Defense
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
				
			};
		}
		#endregion
	}
	#endregion

	//Runerigus PokemonInstance Class
	#region Runerigus
	public class RunerigusInstance : PokemonInstance
	{
		#region Runerigus Constructors
		/// <summary>
		/// Runerigus Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public RunerigusInstance(string nickname, int level)
		: base(
				SpeciesRunerigus.Instance, // Pokemon Species
				nickname, level,
				Ground.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Runerigus Builder only waiting for a Level
		/// </summary>
		public RunerigusInstance(int level)
		: base(
				SpeciesRunerigus.Instance, // PokemonInstance Species
				"Runerigus", level,
				Ground.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Runerigus Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public RunerigusInstance() : base(
			SpeciesRunerigus.Instance, // PokemonInstance Species
			Ground.Instance, Ghost.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}