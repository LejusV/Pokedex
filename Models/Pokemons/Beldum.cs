using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Beldum Species to store common natural stats of all Beldums
	#region SpeciesBeldum
	public class SpeciesBeldum : PokemonSpecies
	{
#nullable enable
		private static SpeciesBeldum? _instance = null;
#nullable restore
        public static SpeciesBeldum Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesBeldum();
                }
                return _instance;
            }
        }

		#region SpeciesBeldum Constructor
		public SpeciesBeldum() : base(
			374,
			"Beldum",
			0.6,
			95.2,
			40, // HPs
			55, 80, // Attack & Defense
			35, 60, // Special Attack & Defense
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
				"Headbutt",
				"Take-Down",
				"Iron-Defense",
				"Zen-Headbutt",
				"Iron-Head"
			};
		}
		#endregion
	}
	#endregion

	//Beldum PokemonInstance Class
	#region Beldum
	public class BeldumInstance : PokemonInstance
	{
		#region Beldum Constructors
		/// <summary>
		/// Beldum Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public BeldumInstance(string nickname, int level)
		: base(
				SpeciesBeldum.Instance, // Pokemon Species
				nickname, level,
				Steel.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Beldum Builder only waiting for a Level
		/// </summary>
		public BeldumInstance(int level)
		: base(
				SpeciesBeldum.Instance, // PokemonInstance Species
				"Beldum", level,
				Steel.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Beldum Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public BeldumInstance() : base(
			SpeciesBeldum.Instance, // PokemonInstance Species
			Steel.Instance, Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}