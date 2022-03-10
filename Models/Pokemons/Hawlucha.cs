using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Hawlucha Species to store common natural stats of all Hawluchas
	#region SpeciesHawlucha
	public class SpeciesHawlucha : PokemonSpecies
	{
#nullable enable
		private static SpeciesHawlucha? _instance = null;
#nullable restore
        public static SpeciesHawlucha Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesHawlucha();
                }
                return _instance;
            }
        }

		#region SpeciesHawlucha Constructor
		public SpeciesHawlucha() : base(
			"Hawlucha",
			0.8,
			21.5,
			78, // HPs
			92, 75, // Attack & Defense
			74, 63, // Special Attack & Defense
			118		
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
				"Karate-Chop",
				"Fire-Punch",
				"Thunder-Punch",
				"Swords-Dance",
				"Cut",
				"Wing-Attack",
				"Fly",
				"Tackle",
				"Low-Kick",
				"Strength",
				"Dig",
				"Toxic",
				"Agility",
				"Double-Team",
				"High-Jump-Kick",
				"Sky-Attack",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Detect",
				"False-Swipe",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Baton-Pass",
				"Encore",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Rock-Smash",
				"Torment",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Helping-Hand",
				"Superpower",
				"Brick-Break",
				"Endeavor",
				"Secret-Power",
				"Feather-Dance",
				"Mud-Sport",
				"Rock-Tomb",
				"Aerial-Ace",
				"Bulk-Up",
				"Bounce",
				"Roost",
				"Feint",
				"Tailwind",
				"U-Turn",
				"Payback",
				"Fling",
				"Me-First",
				"Last-Resort",
				"Poison-Jab",
				"X-Scissor",
				"Drain-Punch",
				"Focus-Blast",
				"Giga-Impact",
				"Zen-Headbutt",
				"Iron-Head",
				"Stone-Edge",
				"Grass-Knot",
				"Hone-Claws",
				"Low-Sweep",
				"Entrainment",
				"Round",
				"Quick-Guard",
				"Ally-Switch",
				"Sky-Drop",
				"Acrobatics",
				"Retaliate",
				"Work-Up",
				"Dual-Chop",
				"Flying-Press",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Hawlucha PokemonInstance Class
	#region Hawlucha
	public class HawluchaInstance : PokemonInstance
	{
		#region Hawlucha Constructors
		/// <summary>
		/// Hawlucha Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public HawluchaInstance(string nickname, int level)
		: base(
				701,
				SpeciesHawlucha.Instance, // Pokemon Species
				nickname, level,
				Fighting.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hawlucha Builder only waiting for a Level
		/// </summary>
		public HawluchaInstance(int level)
		: base(
				701,
				SpeciesHawlucha.Instance, // PokemonInstance Species
				"Hawlucha", level,
				Fighting.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hawlucha Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Hawlucha() : base(
			701,
			SpeciesHawlucha.Instance, // PokemonInstance Species
			Fighting.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}