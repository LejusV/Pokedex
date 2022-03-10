using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Morpeko Species to store common natural stats of all Morpekos
	#region SpeciesMorpeko
	public class SpeciesMorpeko : PokemonSpecies
	{
#nullable enable
		private static SpeciesMorpeko? _instance = null;
#nullable restore
        public static SpeciesMorpeko Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMorpeko();
                }
                return _instance;
            }
        }

		#region SpeciesMorpeko Constructor
		public SpeciesMorpeko() : base(
			"Morpeko",
			0.3,
			3.0,
			58, // HPs
			95, 58, // Attack & Defense
			70, 58, // Special Attack & Defense
			97		
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

	//Morpeko PokemonInstance Class
	#region Morpeko
	public class MorpekoInstance : PokemonInstance
	{
		#region Morpeko Constructors
		/// <summary>
		/// Morpeko Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MorpekoInstance(string nickname, int level)
		: base(
				877,
				SpeciesMorpeko.Instance, // Pokemon Species
				nickname, level,
				Electric.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Morpeko Builder only waiting for a Level
		/// </summary>
		public MorpekoInstance(int level)
		: base(
				877,
				SpeciesMorpeko.Instance, // PokemonInstance Species
				"Morpeko", level,
				Electric.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Morpeko Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Morpeko() : base(
			877,
			SpeciesMorpeko.Instance, // PokemonInstance Species
			Electric.Instance, Dark.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}