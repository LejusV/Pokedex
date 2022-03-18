using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Pancham Species to store common natural stats of all Panchams
	#region SpeciesPancham
	public class SpeciesPancham : PokemonSpecies
	{
#nullable enable
		private static SpeciesPancham? _instance = null;
#nullable restore
        public static SpeciesPancham Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesPancham();
                }
                return _instance;
            }
        }

		#region SpeciesPancham Constructor
		public SpeciesPancham() : base(
			674,
			"Pancham",
			0.6,
			8.0,
			67, // HPs
			82, 62, // Attack & Defense
			46, 48, // Special Attack & Defense
			43		
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
				"Comet-Punch",
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Swords-Dance",
				"Cut",
				"Tackle",
				"Body-Slam",
				"Leer",
				"Roar",
				"Surf",
				"Low-Kick",
				"Strength",
				"Dig",
				"Toxic",
				"Double-Team",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Snore",
				"Spite",
				"Protect",
				"Sludge-Bomb",
				"False-Swipe",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Vital-Throw",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Rock-Smash",
				"Uproar",
				"Torment",
				"Facade",
				"Focus-Punch",
				"Helping-Hand",
				"Superpower",
				"Brick-Break",
				"Knock-Off",
				"Endeavor",
				"Snatch",
				"Secret-Power",
				"Arm-Thrust",
				"Hyper-Voice",
				"Rock-Tomb",
				"Sky-Uppercut",
				"Aerial-Ace",
				"Block",
				"Bulk-Up",
				"Covet",
				"Payback",
				"Fling",
				"Me-First",
				"Dark-Pulse",
				"Drain-Punch",
				"Shadow-Claw",
				"Zen-Headbutt",
				"Gunk-Shot",
				"Iron-Head",
				"Stone-Edge",
				"Grass-Knot",
				"Storm-Throw",
				"Low-Sweep",
				"Foul-Play",
				"Entrainment",
				"Round",
				"Echoed-Voice",
				"Quick-Guard",
				"Circle-Throw",
				"Quash",
				"Retaliate",
				"Bulldoze",
				"Work-Up",
				"Dual-Chop",
				"Parting-Shot",
				"Confide",
				"Power-Up-Punch",
				"Power-Trip"
			};
		}
		#endregion
	}
	#endregion

	//Pancham PokemonInstance Class
	#region Pancham
	public class PanchamInstance : PokemonInstance
	{
		#region Pancham Constructors
		/// <summary>
		/// Pancham Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public PanchamInstance(string nickname, int level)
		: base(
				SpeciesPancham.Instance, // Pokemon Species
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pancham Builder only waiting for a Level
		/// </summary>
		public PanchamInstance(int level)
		: base(
				SpeciesPancham.Instance, // PokemonInstance Species
				"Pancham", level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pancham Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public PanchamInstance() : base(
			SpeciesPancham.Instance, // PokemonInstance Species
			Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}