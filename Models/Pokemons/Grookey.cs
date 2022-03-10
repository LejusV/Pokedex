using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Grookey Species to store common natural stats of all Grookeys
	#region SpeciesGrookey
	public class SpeciesGrookey : PokemonSpecies
	{
#nullable enable
		private static SpeciesGrookey? _instance = null;
#nullable restore
        public static SpeciesGrookey Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesGrookey();
                }
                return _instance;
            }
        }

		#region SpeciesGrookey Constructor
		public SpeciesGrookey() : base(
			"Grookey",
			0.3,
			5.0,
			50, // HPs
			65, 50, // Attack & Defense
			40, 40, // Special Attack & Defense
			65		
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

	//Grookey PokemonInstance Class
	#region Grookey
	public class GrookeyInstance : PokemonInstance
	{
		#region Grookey Constructors
		/// <summary>
		/// Grookey Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public GrookeyInstance(string nickname, int level)
		: base(
				810,
				SpeciesGrookey.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Grookey Builder only waiting for a Level
		/// </summary>
		public GrookeyInstance(int level)
		: base(
				810,
				SpeciesGrookey.Instance, // PokemonInstance Species
				"Grookey", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Grookey Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Grookey() : base(
			810,
			SpeciesGrookey.Instance, // PokemonInstance Species
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}