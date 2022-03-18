using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Monferno Species to store common natural stats of all Monfernos
	#region SpeciesMonferno
	public class SpeciesMonferno : PokemonSpecies
	{
#nullable enable
		private static SpeciesMonferno? _instance = null;
#nullable restore
        public static SpeciesMonferno Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMonferno();
                }
                return _instance;
            }
        }

		#region SpeciesMonferno Constructor
		public SpeciesMonferno() : base(
			391,
			"Monferno",
			0.9,
			22.0,
			64, // HPs
			78, 52, // Attack & Defense
			78, 52, // Special Attack & Defense
			81		
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
				"Scratch",
				"Swords-Dance",
				"Cut",
				"Headbutt",
				"Leer",
				"Ember",
				"Flamethrower",
				"Low-Kick",
				"Strength",
				"Fire-Spin",
				"Dig",
				"Toxic",
				"Double-Team",
				"Fire-Blast",
				"Swift",
				"Fury-Swipes",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Flame-Wheel",
				"Snore",
				"Protect",
				"Mach-Punch",
				"Mud-Slap",
				"Endure",
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
				"Torment",
				"Will-O-Wisp",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Helping-Hand",
				"Role-Play",
				"Brick-Break",
				"Endeavor",
				"Secret-Power",
				"Slack-Off",
				"Overheat",
				"Rock-Tomb",
				"Aerial-Ace",
				"Bulk-Up",
				"Covet",
				"Natural-Gift",
				"Feint",
				"U-Turn",
				"Close-Combat",
				"Fling",
				"Flare-Blitz",
				"Poison-Jab",
				"Vacuum-Wave",
				"Focus-Blast",
				"Shadow-Claw",
				"Rock-Climb",
				"Gunk-Shot",
				"Captivate",
				"Stealth-Rock",
				"Grass-Knot",
				"Hone-Claws",
				"Flame-Charge",
				"Low-Sweep",
				"Round",
				"Incinerate",
				"Acrobatics",
				"Retaliate",
				"Fire-Pledge",
				"Work-Up",
				"Dual-Chop",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Monferno PokemonInstance Class
	#region Monferno
	public class MonfernoInstance : PokemonInstance
	{
		#region Monferno Constructors
		/// <summary>
		/// Monferno Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MonfernoInstance(string nickname, int level)
		: base(
				SpeciesMonferno.Instance, // Pokemon Species
				nickname, level,
				Fire.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Monferno Builder only waiting for a Level
		/// </summary>
		public MonfernoInstance(int level)
		: base(
				SpeciesMonferno.Instance, // PokemonInstance Species
				"Monferno", level,
				Fire.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Monferno Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public MonfernoInstance() : base(
			SpeciesMonferno.Instance, // PokemonInstance Species
			Fire.Instance, Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}