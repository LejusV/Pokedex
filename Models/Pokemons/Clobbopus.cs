using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Clobbopus Species to store common natural stats of all Clobbopuss
	#region SpeciesClobbopus
	public class SpeciesClobbopus : PokemonSpecies
	{
#nullable enable
		private static SpeciesClobbopus? _instance = null;
#nullable restore
        public static SpeciesClobbopus Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesClobbopus();
                }
                return _instance;
            }
        }

		#region SpeciesClobbopus Constructor
		public SpeciesClobbopus() : base(
			"Clobbopus",
			0.6,
			4.0,
			50, // HPs
			68, 60, // Attack & Defense
			50, 50, // Special Attack & Defense
			32		
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

	//Clobbopus PokemonInstance Class
	#region Clobbopus
	public class ClobbopusInstance : PokemonInstance
	{
		#region Clobbopus Constructors
		/// <summary>
		/// Clobbopus Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ClobbopusInstance(string nickname, int level)
		: base(
				852,
				SpeciesClobbopus.Instance, // Pokemon Species
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Clobbopus Builder only waiting for a Level
		/// </summary>
		public ClobbopusInstance(int level)
		: base(
				852,
				SpeciesClobbopus.Instance, // PokemonInstance Species
				"Clobbopus", level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Clobbopus Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Clobbopus() : base(
			852,
			SpeciesClobbopus.Instance, // PokemonInstance Species
			Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}