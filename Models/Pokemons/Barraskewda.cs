using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Barraskewda Species to store common natural stats of all Barraskewdas
	#region SpeciesBarraskewda
	public class SpeciesBarraskewda : PokemonSpecies
	{
#nullable enable
		private static SpeciesBarraskewda? _instance = null;
#nullable restore
        public static SpeciesBarraskewda Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesBarraskewda();
                }
                return _instance;
            }
        }

		#region SpeciesBarraskewda Constructor
		public SpeciesBarraskewda() : base(
			847,
			"Barraskewda",
			1.3,
			30.0,
			61, // HPs
			123, 60, // Attack & Defense
			60, 50, // Special Attack & Defense
			136		
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

	//Barraskewda PokemonInstance Class
	#region Barraskewda
	public class BarraskewdaInstance : PokemonInstance
	{
		#region Barraskewda Constructors
		/// <summary>
		/// Barraskewda Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public BarraskewdaInstance(string nickname, int level)
		: base(
				SpeciesBarraskewda.Instance, // Pokemon Species
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Barraskewda Builder only waiting for a Level
		/// </summary>
		public BarraskewdaInstance(int level)
		: base(
				SpeciesBarraskewda.Instance, // PokemonInstance Species
				"Barraskewda", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Barraskewda Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public BarraskewdaInstance() : base(
			SpeciesBarraskewda.Instance, // PokemonInstance Species
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}