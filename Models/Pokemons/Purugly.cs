using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Purugly Species to store common natural stats of all Puruglys
	#region SpeciesPurugly
	public class SpeciesPurugly : PokemonSpecies
	{
#nullable enable
		private static SpeciesPurugly? _instance = null;
#nullable restore
        public static SpeciesPurugly Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesPurugly();
                }
                return _instance;
            }
        }

		#region SpeciesPurugly Constructor
		public SpeciesPurugly() : base(
			432,
			"Purugly",
			1.0,
			43.8,
			71, // HPs
			82, 64, // Attack & Defense
			64, 59, // Special Attack & Defense
			112		
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
				"Scratch",
				"Cut",
				"Headbutt",
				"Body-Slam",
				"Growl",
				"Roar",
				"Hyper-Beam",
				"Thunderbolt",
				"Thunder",
				"Dig",
				"Toxic",
				"Hypnosis",
				"Double-Team",
				"Swift",
				"Dream-Eater",
				"Flash",
				"Fury-Swipes",
				"Rest",
				"Super-Fang",
				"Slash",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Feint-Attack",
				"Mud-Slap",
				"Endure",
				"Charm",
				"Rollout",
				"Swagger",
				"Fury-Cutter",
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
				"Torment",
				"Facade",
				"Taunt",
				"Assist",
				"Knock-Off",
				"Snatch",
				"Secret-Power",
				"Hyper-Voice",
				"Aerial-Ace",
				"Covet",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"U-Turn",
				"Payback",
				"Last-Resort",
				"Sucker-Punch",
				"Giga-Impact",
				"Shadow-Claw",
				"Captivate",
				"Hone-Claws",
				"Foul-Play",
				"Round",
				"Echoed-Voice",
				"Retaliate",
				"Bulldoze",
				"Work-Up",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Purugly PokemonInstance Class
	#region Purugly
	public class PuruglyInstance : PokemonInstance
	{
		#region Purugly Constructors
		/// <summary>
		/// Purugly Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public PuruglyInstance(string nickname, int level)
		: base(
				SpeciesPurugly.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Purugly Builder only waiting for a Level
		/// </summary>
		public PuruglyInstance(int level)
		: base(
				SpeciesPurugly.Instance, // PokemonInstance Species
				"Purugly", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Purugly Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public PuruglyInstance() : base(
			SpeciesPurugly.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}