using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Purrloin Species to store common natural stats of all Purrloins
	#region SpeciesPurrloin
	public class SpeciesPurrloin : PokemonSpecies
	{
#nullable enable
		private static SpeciesPurrloin? _instance = null;
#nullable restore
        public static SpeciesPurrloin Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesPurrloin();
                }
                return _instance;
            }
        }

		#region SpeciesPurrloin Constructor
		public SpeciesPurrloin() : base(
			509,
			"Purrloin",
			0.4,
			10.1,
			41, // HPs
			50, 37, // Attack & Defense
			50, 37, // Special Attack & Defense
			66		
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
				"Sand-Attack",
				"Growl",
				"Thunder-Wave",
				"Toxic",
				"Double-Team",
				"Dream-Eater",
				"Fury-Swipes",
				"Rest",
				"Slash",
				"Substitute",
				"Thief",
				"Snore",
				"Spite",
				"Protect",
				"Feint-Attack",
				"Charm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Encore",
				"Pursuit",
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
				"Trick",
				"Role-Play",
				"Assist",
				"Yawn",
				"Knock-Off",
				"Snatch",
				"Secret-Power",
				"Hyper-Voice",
				"Fake-Tears",
				"Aerial-Ace",
				"Covet",
				"U-Turn",
				"Payback",
				"Assurance",
				"Embargo",
				"Copycat",
				"Sucker-Punch",
				"Dark-Pulse",
				"Night-Slash",
				"Seed-Bomb",
				"Nasty-Plot",
				"Shadow-Claw",
				"Gunk-Shot",
				"Captivate",
				"Grass-Knot",
				"Hone-Claws",
				"Foul-Play",
				"Round",
				"Echoed-Voice",
				"Snarl",
				"Play-Rough",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Purrloin PokemonInstance Class
	#region Purrloin
	public class PurrloinInstance : PokemonInstance
	{
		#region Purrloin Constructors
		/// <summary>
		/// Purrloin Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public PurrloinInstance(string nickname, int level)
		: base(
				SpeciesPurrloin.Instance, // Pokemon Species
				nickname, level,
				Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Purrloin Builder only waiting for a Level
		/// </summary>
		public PurrloinInstance(int level)
		: base(
				SpeciesPurrloin.Instance, // PokemonInstance Species
				"Purrloin", level,
				Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Purrloin Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public PurrloinInstance() : base(
			SpeciesPurrloin.Instance, // PokemonInstance Species
			Dark.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}