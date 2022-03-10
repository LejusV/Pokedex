using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Meowth Species to store common natural stats of all Meowths
	#region SpeciesMeowth
	public class SpeciesMeowth : PokemonSpecies
	{
#nullable enable
		private static SpeciesMeowth? _instance = null;
#nullable restore
        public static SpeciesMeowth Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMeowth();
                }
                return _instance;
            }
        }

		#region SpeciesMeowth Constructor
		public SpeciesMeowth() : base(
			"Meowth",
			0.4,
			4.2,
			40, // HPs
			45, 35, // Attack & Defense
			40, 40, // Special Attack & Defense
			90		
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
				"Pay-Day",
				"Scratch",
				"Cut",
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Tail-Whip",
				"Bite",
				"Growl",
				"Water-Gun",
				"Bubble-Beam",
				"Thunderbolt",
				"Thunder",
				"Dig",
				"Toxic",
				"Hypnosis",
				"Rage",
				"Mimic",
				"Screech",
				"Double-Team",
				"Defense-Curl",
				"Bide",
				"Swift",
				"Skull-Bash",
				"Amnesia",
				"Dream-Eater",
				"Flash",
				"Fury-Swipes",
				"Rest",
				"Slash",
				"Substitute",
				"Thief",
				"Nightmare",
				"Snore",
				"Curse",
				"Flail",
				"Spite",
				"Protect",
				"Feint-Attack",
				"Mud-Slap",
				"Zap-Cannon",
				"Icy-Wind",
				"Detect",
				"Endure",
				"Charm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Fake-Out",
				"Uproar",
				"Torment",
				"Facade",
				"Taunt",
				"Assist",
				"Knock-Off",
				"Snatch",
				"Secret-Power",
				"Hyper-Voice",
				"Odor-Sleuth",
				"Aerial-Ace",
				"Covet",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"Feint",
				"U-Turn",
				"Payback",
				"Assurance",
				"Punishment",
				"Last-Resort",
				"Dark-Pulse",
				"Night-Slash",
				"Seed-Bomb",
				"Nasty-Plot",
				"Shadow-Claw",
				"Gunk-Shot",
				"Captivate",
				"Hone-Claws",
				"Foul-Play",
				"Round",
				"Echoed-Voice",
				"Retaliate",
				"Work-Up",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Meowth PokemonInstance Class
	#region Meowth
	public class MeowthInstance : PokemonInstance
	{
		#region Meowth Constructors
		/// <summary>
		/// Meowth Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MeowthInstance(string nickname, int level)
		: base(
				52,
				SpeciesMeowth.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Meowth Builder only waiting for a Level
		/// </summary>
		public MeowthInstance(int level)
		: base(
				52,
				SpeciesMeowth.Instance, // PokemonInstance Species
				"Meowth", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Meowth Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Meowth() : base(
			52,
			SpeciesMeowth.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}