using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Pignite Species to store common natural stats of all Pignites
	#region SpeciesPignite
	public class SpeciesPignite : PokemonSpecies
	{
#nullable enable
		private static SpeciesPignite? _instance = null;
#nullable restore
        public static SpeciesPignite Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesPignite();
                }
                return _instance;
            }
        }

		#region SpeciesPignite Constructor
		public SpeciesPignite() : base(
			499,
			"Pignite",
			1.0,
			55.5,
			90, // HPs
			93, 55, // Attack & Defense
			70, 55, // Special Attack & Defense
			55		
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
				"Thunder-Punch",
				"Tackle",
				"Take-Down",
				"Tail-Whip",
				"Roar",
				"Ember",
				"Flamethrower",
				"Low-Kick",
				"Strength",
				"Solar-Beam",
				"Toxic",
				"Double-Team",
				"Defense-Curl",
				"Smog",
				"Fire-Blast",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Helping-Hand",
				"Superpower",
				"Brick-Break",
				"Endeavor",
				"Secret-Power",
				"Arm-Thrust",
				"Overheat",
				"Odor-Sleuth",
				"Rock-Tomb",
				"Covet",
				"Gyro-Ball",
				"Assurance",
				"Fling",
				"Flare-Blitz",
				"Poison-Jab",
				"Focus-Blast",
				"Zen-Headbutt",
				"Stone-Edge",
				"Grass-Knot",
				"Head-Smash",
				"Flame-Charge",
				"Low-Sweep",
				"Round",
				"Echoed-Voice",
				"Incinerate",
				"Fire-Pledge",
				"Bulldoze",
				"Work-Up",
				"Wild-Charge",
				"Heat-Crash",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Pignite PokemonInstance Class
	#region Pignite
	public class PigniteInstance : PokemonInstance
	{
		#region Pignite Constructors
		/// <summary>
		/// Pignite Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public PigniteInstance(string nickname, int level)
		: base(
				SpeciesPignite.Instance, // Pokemon Species
				nickname, level,
				Fire.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pignite Builder only waiting for a Level
		/// </summary>
		public PigniteInstance(int level)
		: base(
				SpeciesPignite.Instance, // PokemonInstance Species
				"Pignite", level,
				Fire.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pignite Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public PigniteInstance() : base(
			SpeciesPignite.Instance, // PokemonInstance Species
			Fire.Instance, Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}