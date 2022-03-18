using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Pangoro Species to store common natural stats of all Pangoros
	#region SpeciesPangoro
	public class SpeciesPangoro : PokemonSpecies
	{
#nullable enable
		private static SpeciesPangoro? _instance = null;
#nullable restore
        public static SpeciesPangoro Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesPangoro();
                }
                return _instance;
            }
        }

		#region SpeciesPangoro Constructor
		public SpeciesPangoro() : base(
			675,
			"Pangoro",
			2.1,
			136.0,
			95, // HPs
			124, 78, // Attack & Defense
			69, 71, // Special Attack & Defense
			58		
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
				"Hyper-Beam",
				"Low-Kick",
				"Strength",
				"Earthquake",
				"Dig",
				"Toxic",
				"Double-Team",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Thief",
				"Snore",
				"Spite",
				"Protect",
				"Sludge-Bomb",
				"Outrage",
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
				"Taunt",
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
				"Dragon-Claw",
				"Bulk-Up",
				"Covet",
				"Hammer-Arm",
				"Payback",
				"Embargo",
				"Fling",
				"Poison-Jab",
				"Dark-Pulse",
				"X-Scissor",
				"Drain-Punch",
				"Focus-Blast",
				"Giga-Impact",
				"Bullet-Punch",
				"Shadow-Claw",
				"Zen-Headbutt",
				"Gunk-Shot",
				"Iron-Head",
				"Stone-Edge",
				"Grass-Knot",
				"Hone-Claws",
				"Low-Sweep",
				"Foul-Play",
				"Entrainment",
				"Round",
				"Echoed-Voice",
				"Circle-Throw",
				"Quash",
				"Retaliate",
				"Bulldoze",
				"Work-Up",
				"Dual-Chop",
				"Snarl",
				"Parting-Shot",
				"Confide",
				"Infestation",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Pangoro PokemonInstance Class
	#region Pangoro
	public class PangoroInstance : PokemonInstance
	{
		#region Pangoro Constructors
		/// <summary>
		/// Pangoro Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public PangoroInstance(string nickname, int level)
		: base(
				SpeciesPangoro.Instance, // Pokemon Species
				nickname, level,
				Fighting.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pangoro Builder only waiting for a Level
		/// </summary>
		public PangoroInstance(int level)
		: base(
				SpeciesPangoro.Instance, // PokemonInstance Species
				"Pangoro", level,
				Fighting.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pangoro Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public PangoroInstance() : base(
			SpeciesPangoro.Instance, // PokemonInstance Species
			Fighting.Instance, Dark.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}