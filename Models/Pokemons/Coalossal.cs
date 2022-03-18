using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Coalossal Species to store common natural stats of all Coalossals
	#region SpeciesCoalossal
	public class SpeciesCoalossal : PokemonSpecies
	{
#nullable enable
		private static SpeciesCoalossal? _instance = null;
#nullable restore
        public static SpeciesCoalossal Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesCoalossal();
                }
                return _instance;
            }
        }

		#region SpeciesCoalossal Constructor
		public SpeciesCoalossal() : base(
			839,
			"Coalossal",
			2.8,
			310.5,
			110, // HPs
			80, 120, // Attack & Defense
			80, 90, // Special Attack & Defense
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

	//Coalossal PokemonInstance Class
	#region Coalossal
	public class CoalossalInstance : PokemonInstance
	{
		#region Coalossal Constructors
		/// <summary>
		/// Coalossal Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public CoalossalInstance(string nickname, int level)
		: base(
				SpeciesCoalossal.Instance, // Pokemon Species
				nickname, level,
				Rock.Instance, Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Coalossal Builder only waiting for a Level
		/// </summary>
		public CoalossalInstance(int level)
		: base(
				SpeciesCoalossal.Instance, // PokemonInstance Species
				"Coalossal", level,
				Rock.Instance, Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Coalossal Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public CoalossalInstance() : base(
			SpeciesCoalossal.Instance, // PokemonInstance Species
			Rock.Instance, Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}