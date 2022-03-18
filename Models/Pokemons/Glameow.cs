using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Glameow Species to store common natural stats of all Glameows
	#region SpeciesGlameow
	public class SpeciesGlameow : PokemonSpecies
	{
#nullable enable
		private static SpeciesGlameow? _instance = null;
#nullable restore
        public static SpeciesGlameow Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesGlameow();
                }
                return _instance;
            }
        }

		#region SpeciesGlameow Constructor
		public SpeciesGlameow() : base(
			431,
			"Glameow",
			0.5,
			3.9,
			49, // HPs
			55, 42, // Attack & Defense
			42, 37, // Special Attack & Defense
			85		
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
				"Sand-Attack",
				"Headbutt",
				"Tail-Whip",
				"Bite",
				"Growl",
				"Thunderbolt",
				"Thunder",
				"Dig",
				"Toxic",
				"Hypnosis",
				"Quick-Attack",
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
				"Flail",
				"Protect",
				"Feint-Attack",
				"Mud-Slap",
				"Endure",
				"Charm",
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
				"Fake-Tears",
				"Aerial-Ace",
				"Covet",
				"Shock-Wave",
				"Water-Pulse",
				"Wake-Up-Slap",
				"Natural-Gift",
				"U-Turn",
				"Payback",
				"Assurance",
				"Last-Resort",
				"Sucker-Punch",
				"Shadow-Claw",
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

	//Glameow PokemonInstance Class
	#region Glameow
	public class GlameowInstance : PokemonInstance
	{
		#region Glameow Constructors
		/// <summary>
		/// Glameow Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public GlameowInstance(string nickname, int level)
		: base(
				SpeciesGlameow.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Glameow Builder only waiting for a Level
		/// </summary>
		public GlameowInstance(int level)
		: base(
				SpeciesGlameow.Instance, // PokemonInstance Species
				"Glameow", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Glameow Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public GlameowInstance() : base(
			SpeciesGlameow.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}