using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Persian Species to store common natural stats of all Persians
	#region SpeciesPersian
	public class SpeciesPersian : PokemonSpecies
	{
#nullable enable
		private static SpeciesPersian? _instance = null;
#nullable restore
        public static SpeciesPersian Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesPersian();
                }
                return _instance;
            }
        }

		#region SpeciesPersian Constructor
		public SpeciesPersian() : base(
			53,
			"Persian",
			1.0,
			32.0,
			65, // HPs
			70, 60, // Attack & Defense
			65, 65, // Special Attack & Defense
			115		
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
				"Bite",
				"Growl",
				"Roar",
				"Water-Gun",
				"Bubble-Beam",
				"Hyper-Beam",
				"Thunderbolt",
				"Thunder",
				"Dig",
				"Toxic",
				"Rage",
				"Mimic",
				"Screech",
				"Double-Team",
				"Defense-Curl",
				"Bide",
				"Swift",
				"Skull-Bash",
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
				"Spite",
				"Protect",
				"Feint-Attack",
				"Mud-Slap",
				"Zap-Cannon",
				"Icy-Wind",
				"Detect",
				"Endure",
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
				"Knock-Off",
				"Snatch",
				"Secret-Power",
				"Hyper-Voice",
				"Aerial-Ace",
				"Covet",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"Feint",
				"U-Turn",
				"Payback",
				"Assurance",
				"Embargo",
				"Last-Resort",
				"Dark-Pulse",
				"Night-Slash",
				"Seed-Bomb",
				"Power-Gem",
				"Switcheroo",
				"Giga-Impact",
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
				"Play-Rough",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Persian PokemonInstance Class
	#region Persian
	public class PersianInstance : PokemonInstance
	{
		#region Persian Constructors
		/// <summary>
		/// Persian Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public PersianInstance(string nickname, int level)
		: base(
				SpeciesPersian.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Persian Builder only waiting for a Level
		/// </summary>
		public PersianInstance(int level)
		: base(
				SpeciesPersian.Instance, // PokemonInstance Species
				"Persian", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Persian Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public PersianInstance() : base(
			SpeciesPersian.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}