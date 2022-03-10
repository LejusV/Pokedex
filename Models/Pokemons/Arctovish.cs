using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Arctovish Species to store common natural stats of all Arctovishs
	#region SpeciesArctovish
	public class SpeciesArctovish : PokemonSpecies
	{
#nullable enable
		private static SpeciesArctovish? _instance = null;
#nullable restore
        public static SpeciesArctovish Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesArctovish();
                }
                return _instance;
            }
        }

		#region SpeciesArctovish Constructor
		public SpeciesArctovish() : base(
			"Arctovish",
			2.0,
			175.0,
			90, // HPs
			90, 100, // Attack & Defense
			80, 90, // Special Attack & Defense
			55		
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

	//Arctovish PokemonInstance Class
	#region Arctovish
	public class ArctovishInstance : PokemonInstance
	{
		#region Arctovish Constructors
		/// <summary>
		/// Arctovish Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ArctovishInstance(string nickname, int level)
		: base(
				883,
				SpeciesArctovish.Instance, // Pokemon Species
				nickname, level,
				Water.Instance, Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Arctovish Builder only waiting for a Level
		/// </summary>
		public ArctovishInstance(int level)
		: base(
				883,
				SpeciesArctovish.Instance, // PokemonInstance Species
				"Arctovish", level,
				Water.Instance, Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Arctovish Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Arctovish() : base(
			883,
			SpeciesArctovish.Instance, // PokemonInstance Species
			Water.Instance, Ice.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}