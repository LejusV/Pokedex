using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Fletchling Species to store common natural stats of all Fletchlings
	#region SpeciesFletchling
	public class SpeciesFletchling : PokemonSpecies
	{
#nullable enable
		private static SpeciesFletchling? _instance = null;
#nullable restore
        public static SpeciesFletchling Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesFletchling();
                }
                return _instance;
            }
        }

		#region SpeciesFletchling Constructor
		public SpeciesFletchling() : base(
			"Fletchling",
			0.3,
			1.7,
			45, // HPs
			50, 43, // Attack & Defense
			40, 38, // Special Attack & Defense
			62		
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
				"Peck",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Double-Team",
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
				"Quick-Guard",
				"Acrobatics",
				"Work-Up",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Fletchling PokemonInstance Class
	#region Fletchling
	public class FletchlingInstance : PokemonInstance
	{
		#region Fletchling Constructors
		/// <summary>
		/// Fletchling Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public FletchlingInstance(string nickname, int level)
		: base(
				661,
				SpeciesFletchling.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Fletchling Builder only waiting for a Level
		/// </summary>
		public FletchlingInstance(int level)
		: base(
				661,
				SpeciesFletchling.Instance, // PokemonInstance Species
				"Fletchling", level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Fletchling Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Fletchling() : base(
			661,
			SpeciesFletchling.Instance, // PokemonInstance Species
			Normal.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}