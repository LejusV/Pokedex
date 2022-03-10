using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Scatterbug Species to store common natural stats of all Scatterbugs
	#region SpeciesScatterbug
	public class SpeciesScatterbug : PokemonSpecies
	{
#nullable enable
		private static SpeciesScatterbug? _instance = null;
#nullable restore
        public static SpeciesScatterbug Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesScatterbug();
                }
                return _instance;
            }
        }

		#region SpeciesScatterbug Constructor
		public SpeciesScatterbug() : base(
			"Scatterbug",
			0.3,
			2.5,
			38, // HPs
			35, 40, // Attack & Defense
			27, 25, // Special Attack & Defense
			35		
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
				"Tackle",
				"Poison-Powder",
				"Stun-Spore",
				"String-Shot",
				"Bug-Bite",
				"Rage-Powder"
			};
		}
		#endregion
	}
	#endregion

	//Scatterbug PokemonInstance Class
	#region Scatterbug
	public class ScatterbugInstance : PokemonInstance
	{
		#region Scatterbug Constructors
		/// <summary>
		/// Scatterbug Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ScatterbugInstance(string nickname, int level)
		: base(
				664,
				SpeciesScatterbug.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Scatterbug Builder only waiting for a Level
		/// </summary>
		public ScatterbugInstance(int level)
		: base(
				664,
				SpeciesScatterbug.Instance, // PokemonInstance Species
				"Scatterbug", level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Scatterbug Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Scatterbug() : base(
			664,
			SpeciesScatterbug.Instance, // PokemonInstance Species
			Bug.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}