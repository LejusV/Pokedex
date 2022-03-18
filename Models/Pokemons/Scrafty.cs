using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Scrafty Species to store common natural stats of all Scraftys
	#region SpeciesScrafty
	public class SpeciesScrafty : PokemonSpecies
	{
#nullable enable
		private static SpeciesScrafty? _instance = null;
#nullable restore
        public static SpeciesScrafty Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesScrafty();
                }
                return _instance;
            }
        }

		#region SpeciesScrafty Constructor
		public SpeciesScrafty() : base(
			560,
			"Scrafty",
			1.1,
			30.0,
			65, // HPs
			90, 115, // Attack & Defense
			45, 115, // Special Attack & Defense
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
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Sand-Attack",
				"Headbutt",
				"Leer",
				"Roar",
				"Hyper-Beam",
				"Low-Kick",
				"Strength",
				"Dig",
				"Toxic",
				"Double-Team",
				"High-Jump-Kick",
				"Rest",
				"Rock-Slide",
				"Super-Fang",
				"Substitute",
				"Thief",
				"Snore",
				"Spite",
				"Protect",
				"Scary-Face",
				"Feint-Attack",
				"Sludge-Bomb",
				"Outrage",
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
				"Payback",
				"Fling",
				"Poison-Jab",
				"Dark-Pulse",
				"Dragon-Pulse",
				"Drain-Punch",
				"Focus-Blast",
				"Giga-Impact",
				"Zen-Headbutt",
				"Rock-Climb",
				"Iron-Head",
				"Stone-Edge",
				"Grass-Knot",
				"Head-Smash",
				"Smack-Down",
				"Low-Sweep",
				"Foul-Play",
				"Round",
				"Chip-Away",
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

	//Scrafty PokemonInstance Class
	#region Scrafty
	public class ScraftyInstance : PokemonInstance
	{
		#region Scrafty Constructors
		/// <summary>
		/// Scrafty Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ScraftyInstance(string nickname, int level)
		: base(
				SpeciesScrafty.Instance, // Pokemon Species
				nickname, level,
				Dark.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Scrafty Builder only waiting for a Level
		/// </summary>
		public ScraftyInstance(int level)
		: base(
				SpeciesScrafty.Instance, // PokemonInstance Species
				"Scrafty", level,
				Dark.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Scrafty Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public ScraftyInstance() : base(
			SpeciesScrafty.Instance, // PokemonInstance Species
			Dark.Instance, Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}