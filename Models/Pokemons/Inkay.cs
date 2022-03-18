using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Inkay Species to store common natural stats of all Inkays
	#region SpeciesInkay
	public class SpeciesInkay : PokemonSpecies
	{
#nullable enable
		private static SpeciesInkay? _instance = null;
#nullable restore
        public static SpeciesInkay Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesInkay();
                }
                return _instance;
            }
        }

		#region SpeciesInkay Constructor
		public SpeciesInkay() : base(
			686,
			"Inkay",
			0.4,
			3.5,
			53, // HPs
			54, 53, // Attack & Defense
			37, 46, // Special Attack & Defense
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
				"Cut",
				"Bind",
				"Tackle",
				"Flamethrower",
				"Psybeam",
				"Peck",
				"Thunderbolt",
				"Toxic",
				"Psychic",
				"Hypnosis",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Constrict",
				"Flash",
				"Psywave",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Thief",
				"Snore",
				"Spite",
				"Protect",
				"Destiny-Bond",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Torment",
				"Flatter",
				"Facade",
				"Taunt",
				"Role-Play",
				"Superpower",
				"Knock-Off",
				"Snatch",
				"Secret-Power",
				"Camouflage",
				"Aerial-Ace",
				"Calm-Mind",
				"Pluck",
				"Payback",
				"Embargo",
				"Fling",
				"Guard-Swap",
				"Dark-Pulse",
				"Night-Slash",
				"Switcheroo",
				"Psycho-Cut",
				"Trick-Room",
				"Power-Split",
				"Foul-Play",
				"Simple-Beam",
				"Round",
				"Retaliate",
				"Topsy-Turvy",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Inkay PokemonInstance Class
	#region Inkay
	public class InkayInstance : PokemonInstance
	{
		#region Inkay Constructors
		/// <summary>
		/// Inkay Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public InkayInstance(string nickname, int level)
		: base(
				SpeciesInkay.Instance, // Pokemon Species
				nickname, level,
				Dark.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Inkay Builder only waiting for a Level
		/// </summary>
		public InkayInstance(int level)
		: base(
				SpeciesInkay.Instance, // PokemonInstance Species
				"Inkay", level,
				Dark.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Inkay Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public InkayInstance() : base(
			SpeciesInkay.Instance, // PokemonInstance Species
			Dark.Instance, Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}