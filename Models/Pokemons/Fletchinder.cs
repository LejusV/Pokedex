using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Fletchinder Species to store common natural stats of all Fletchinders
	#region SpeciesFletchinder
	public class SpeciesFletchinder : PokemonSpecies
	{
#nullable enable
		private static SpeciesFletchinder? _instance = null;
#nullable restore
        public static SpeciesFletchinder Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesFletchinder();
                }
                return _instance;
            }
        }

		#region SpeciesFletchinder Constructor
		public SpeciesFletchinder() : base(
			662,
			"Fletchinder",
			0.7,
			16.0,
			62, // HPs
			73, 55, // Attack & Defense
			56, 52, // Special Attack & Defense
			84		
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
				"Razor-Wind",
				"Swords-Dance",
				"Fly",
				"Tackle",
				"Growl",
				"Ember",
				"Flamethrower",
				"Peck",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Double-Team",
				"Fire-Blast",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Flail",
				"Protect",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Sunny-Day",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Taunt",
				"Snatch",
				"Secret-Power",
				"Overheat",
				"Aerial-Ace",
				"Roost",
				"Natural-Gift",
				"Tailwind",
				"U-Turn",
				"Me-First",
				"Flame-Charge",
				"Round",
				"Incinerate",
				"Acrobatics",
				"Work-Up",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Fletchinder PokemonInstance Class
	#region Fletchinder
	public class FletchinderInstance : PokemonInstance
	{
		#region Fletchinder Constructors
		/// <summary>
		/// Fletchinder Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public FletchinderInstance(string nickname, int level)
		: base(
				SpeciesFletchinder.Instance, // Pokemon Species
				nickname, level,
				Fire.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Fletchinder Builder only waiting for a Level
		/// </summary>
		public FletchinderInstance(int level)
		: base(
				SpeciesFletchinder.Instance, // PokemonInstance Species
				"Fletchinder", level,
				Fire.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Fletchinder Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public FletchinderInstance() : base(
			SpeciesFletchinder.Instance, // PokemonInstance Species
			Fire.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}