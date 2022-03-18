using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Scraggy Species to store common natural stats of all Scraggys
	#region SpeciesScraggy
	public class SpeciesScraggy : PokemonSpecies
	{
#nullable enable
		private static SpeciesScraggy? _instance = null;
#nullable restore
        public static SpeciesScraggy Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesScraggy();
                }
                return _instance;
            }
        }

		#region SpeciesScraggy Constructor
		public SpeciesScraggy() : base(
			559,
			"Scraggy",
			0.6,
			11.8,
			50, // HPs
			75, 70, // Attack & Defense
			35, 70, // Special Attack & Defense
			48		
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
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Sand-Attack",
				"Headbutt",
				"Leer",
				"Roar",
				"Low-Kick",
				"Counter",
				"Strength",
				"Dig",
				"Toxic",
				"Double-Team",
				"Amnesia",
				"High-Jump-Kick",
				"Rest",
				"Rock-Slide",
				"Super-Fang",
				"Substitute",
				"Snore",
				"Spite",
				"Protect",
				"Scary-Face",
				"Feint-Attack",
				"Sludge-Bomb",
				"Detect",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Rock-Smash",
				"Fake-Out",
				"Torment",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Brick-Break",
				"Knock-Off",
				"Snatch",
				"Secret-Power",
				"Rock-Tomb",
				"Iron-Defense",
				"Dragon-Claw",
				"Bulk-Up",
				"Dragon-Dance",
				"Payback",
				"Fling",
				"Poison-Jab",
				"Dark-Pulse",
				"Dragon-Pulse",
				"Drain-Punch",
				"Focus-Blast",
				"Zen-Headbutt",
				"Rock-Climb",
				"Iron-Head",
				"Stone-Edge",
				"Grass-Knot",
				"Head-Smash",
				"Smack-Down",
				"Low-Sweep",
				"Acid-Spray",
				"Foul-Play",
				"Round",
				"Chip-Away",
				"Quick-Guard",
				"Incinerate",
				"Retaliate",
				"Dragon-Tail",
				"Work-Up",
				"Dual-Chop",
				"Snarl",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Scraggy PokemonInstance Class
	#region Scraggy
	public class ScraggyInstance : PokemonInstance
	{
		#region Scraggy Constructors
		/// <summary>
		/// Scraggy Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ScraggyInstance(string nickname, int level)
		: base(
				SpeciesScraggy.Instance, // Pokemon Species
				nickname, level,
				Dark.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Scraggy Builder only waiting for a Level
		/// </summary>
		public ScraggyInstance(int level)
		: base(
				SpeciesScraggy.Instance, // PokemonInstance Species
				"Scraggy", level,
				Dark.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Scraggy Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public ScraggyInstance() : base(
			SpeciesScraggy.Instance, // PokemonInstance Species
			Dark.Instance, Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}