using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Sentret Species to store common natural stats of all Sentrets
	#region SpeciesSentret
	public class SpeciesSentret : PokemonSpecies
	{
#nullable enable
		private static SpeciesSentret? _instance = null;
#nullable restore
        public static SpeciesSentret Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSentret();
                }
                return _instance;
            }
        }

		#region SpeciesSentret Constructor
		public SpeciesSentret() : base(
			"Sentret",
			0.8,
			6.0,
			35, // HPs
			46, 34, // Attack & Defense
			35, 45, // Special Attack & Defense
			20		
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
				"Scratch",
				"Cut",
				"Slam",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Double-Edge",
				"Flamethrower",
				"Surf",
				"Ice-Beam",
				"Solar-Beam",
				"Thunderbolt",
				"Dig",
				"Toxic",
				"Quick-Attack",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Focus-Energy",
				"Swift",
				"Amnesia",
				"Fury-Swipes",
				"Rest",
				"Super-Fang",
				"Slash",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Reversal",
				"Protect",
				"Mud-Slap",
				"Foresight",
				"Detect",
				"Endure",
				"Charm",
				"Rollout",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Baton-Pass",
				"Pursuit",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Shadow-Ball",
				"Whirlpool",
				"Uproar",
				"Facade",
				"Focus-Punch",
				"Follow-Me",
				"Helping-Hand",
				"Trick",
				"Assist",
				"Brick-Break",
				"Knock-Off",
				"Secret-Power",
				"Hyper-Voice",
				"Covet",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"U-Turn",
				"Fling",
				"Me-First",
				"Last-Resort",
				"Sucker-Punch",
				"Aqua-Tail",
				"Shadow-Claw",
				"Captivate",
				"Grass-Knot",
				"Charge-Beam",
				"Hone-Claws",
				"Round",
				"Echoed-Voice",
				"Retaliate",
				"Work-Up",
				"Confide",
				"Baby-Doll-Eyes",
				"Power-Up-Punch",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Sentret PokemonInstance Class
	#region Sentret
	public class SentretInstance : PokemonInstance
	{
		#region Sentret Constructors
		/// <summary>
		/// Sentret Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SentretInstance(string nickname, int level)
		: base(
				161,
				SpeciesSentret.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sentret Builder only waiting for a Level
		/// </summary>
		public SentretInstance(int level)
		: base(
				161,
				SpeciesSentret.Instance, // PokemonInstance Species
				"Sentret", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sentret Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Sentret() : base(
			161,
			SpeciesSentret.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}