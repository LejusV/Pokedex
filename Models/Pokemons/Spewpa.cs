using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Spewpa Species to store common natural stats of all Spewpas
	#region SpeciesSpewpa
	public class SpeciesSpewpa : PokemonSpecies
	{
#nullable enable
		private static SpeciesSpewpa? _instance = null;
#nullable restore
        public static SpeciesSpewpa Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSpewpa();
                }
                return _instance;
            }
        }

		#region SpeciesSpewpa Constructor
		public SpeciesSpewpa() : base(
			665,
			"Spewpa",
			0.3,
			8.4,
			45, // HPs
			22, 60, // Attack & Defense
			27, 30, // Special Attack & Defense
			29		
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
				"Harden",
				"Protect",
				"Iron-Defense",
				"Bug-Bite",
				"Electroweb"
			};
		}
		#endregion
	}
	#endregion

	//Spewpa PokemonInstance Class
	#region Spewpa
	public class SpewpaInstance : PokemonInstance
	{
		#region Spewpa Constructors
		/// <summary>
		/// Spewpa Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SpewpaInstance(string nickname, int level)
		: base(
				SpeciesSpewpa.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Spewpa Builder only waiting for a Level
		/// </summary>
		public SpewpaInstance(int level)
		: base(
				SpeciesSpewpa.Instance, // PokemonInstance Species
				"Spewpa", level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Spewpa Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public SpewpaInstance() : base(
			SpeciesSpewpa.Instance, // PokemonInstance Species
			Bug.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}