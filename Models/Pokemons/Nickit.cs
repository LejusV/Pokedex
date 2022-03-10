using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Nickit Species to store common natural stats of all Nickits
	#region SpeciesNickit
	public class SpeciesNickit : PokemonSpecies
	{
#nullable enable
		private static SpeciesNickit? _instance = null;
#nullable restore
        public static SpeciesNickit Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesNickit();
                }
                return _instance;
            }
        }

		#region SpeciesNickit Constructor
		public SpeciesNickit() : base(
			"Nickit",
			0.6,
			8.9,
			40, // HPs
			28, 28, // Attack & Defense
			47, 52, // Special Attack & Defense
			50		
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

	//Nickit PokemonInstance Class
	#region Nickit
	public class NickitInstance : PokemonInstance
	{
		#region Nickit Constructors
		/// <summary>
		/// Nickit Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public NickitInstance(string nickname, int level)
		: base(
				827,
				SpeciesNickit.Instance, // Pokemon Species
				nickname, level,
				Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Nickit Builder only waiting for a Level
		/// </summary>
		public NickitInstance(int level)
		: base(
				827,
				SpeciesNickit.Instance, // PokemonInstance Species
				"Nickit", level,
				Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Nickit Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Nickit() : base(
			827,
			SpeciesNickit.Instance, // PokemonInstance Species
			Dark.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}