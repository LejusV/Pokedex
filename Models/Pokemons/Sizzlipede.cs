using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Sizzlipede Species to store common natural stats of all Sizzlipedes
	#region SpeciesSizzlipede
	public class SpeciesSizzlipede : PokemonSpecies
	{
#nullable enable
		private static SpeciesSizzlipede? _instance = null;
#nullable restore
        public static SpeciesSizzlipede Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSizzlipede();
                }
                return _instance;
            }
        }

		#region SpeciesSizzlipede Constructor
		public SpeciesSizzlipede() : base(
			850,
			"Sizzlipede",
			0.7,
			1.0,
			50, // HPs
			65, 45, // Attack & Defense
			50, 50, // Special Attack & Defense
			45		
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

	//Sizzlipede PokemonInstance Class
	#region Sizzlipede
	public class SizzlipedeInstance : PokemonInstance
	{
		#region Sizzlipede Constructors
		/// <summary>
		/// Sizzlipede Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SizzlipedeInstance(string nickname, int level)
		: base(
				SpeciesSizzlipede.Instance, // Pokemon Species
				nickname, level,
				Fire.Instance, Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sizzlipede Builder only waiting for a Level
		/// </summary>
		public SizzlipedeInstance(int level)
		: base(
				SpeciesSizzlipede.Instance, // PokemonInstance Species
				"Sizzlipede", level,
				Fire.Instance, Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sizzlipede Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public SizzlipedeInstance() : base(
			SpeciesSizzlipede.Instance, // PokemonInstance Species
			Fire.Instance, Bug.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}